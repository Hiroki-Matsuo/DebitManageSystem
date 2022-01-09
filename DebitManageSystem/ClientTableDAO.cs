using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DebitManageSystem
{
    class ClientTableDAO :IDAOBase, IClientDAO
    {
        //文字列
        private static readonly string Server = "localhost";      // ホスト名
        private static readonly int Port = 3306;                  // ポート番号
        private static readonly string Database = "debit_schema";       // データベース名
        private static readonly string Uid = "root";              // ユーザ名
        private static readonly string Pwd = "Localhost123";          // パスワード

        // 接続文字列
        private static readonly string ConnectionString = $"Server={Server}; Port={Port}; Database={Database}; Uid={Uid}; Pwd={Pwd}";
        // データ登録SQL
        private static readonly string InsertTableSql = $"INSERT INTO {Database}.client_table (client_id, client_name) VALUES (@client_cd, @client_name)";

        // データ更新SQL
        private static readonly string UpdateTableSql = $"Update {Database}.client_table SET client_name = @client_name WHERE client_id = @client_cd";

        // 複数更新SQL
        private static readonly string UpdateRecordsSql_Former = $"Update {Database}.client_table SET client_name = CASE client_id ";

        private static readonly string UpdateRecordsSql_Later = "END WHERE client_id IN ";

        // データ登録SQL
        private static readonly string InsertTableSqlIgnore = $"INSERT IGNORE INTO {Database}.client_table (client_id, client_name) VALUES ";

        //(@client_cd, @client_name)

        //private static readonly string WhenQuery = "WHEN client_name THEN ";

        // WHEN client_name THEN 'client_name' 
        //
        //@client_name WHERE client_id = @client_cd";

        /// <summary>
        /// 登録処理
        /// </summary>
        /// <param name="cd"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public int InsertRecord(int cd, string name)
        {

            var result = 99;

            using (var conn = new MySqlConnection(ConnectionString))
            using (var comm = new MySqlCommand())
            {

                conn.Open();

                //SQLへ格納
                comm.Connection = conn;
                comm.CommandText = InsertTableSql;

                //パラメータを格納
                comm.Parameters.AddWithValue("@client_cd", cd);
                comm.Parameters.AddWithValue("@client_name", name);

                result = comm.ExecuteNonQuery();

            }

            return result;

        }

        /// <summary>
        /// 全件取得
        /// </summary>
        /// <returns></returns>
        public List<client_table> GetClientDataAll()
        {
            var result = new List<client_table>();

            using (debit_schemaEntities ent = new debit_schemaEntities())
            {

                result = (from x in ent.client_table
                          select x).ToList();

            }

            return result;

        }


        /// <summary>
        /// 取引先コードを元に検索する
        /// </summary>
        /// <param name="cd"></param>
        /// <returns></returns>
        public client_table SelectNameForCode(int cd)
        {

            var result = new client_table();

            using (debit_schemaEntities ent = new debit_schemaEntities())
            {

                result = (from x in ent.client_table
                          where x.client_id == cd
                          select x).FirstOrDefault();

            }

            return result;

        }

        /// <summary>
        /// 更新処理
        /// </summary>
        /// <param name="cd"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public int UpdateRecord(int cd, string name)
        {

            var result = 99;

            using (var conn = new MySqlConnection(ConnectionString))
            using (var comm = new MySqlCommand())
            {

                conn.Open();

                //SQLへ格納
                comm.Connection = conn;
                comm.CommandText = UpdateTableSql;

                //パラメータを格納
                comm.Parameters.AddWithValue("@client_cd", cd);
                comm.Parameters.AddWithValue("@client_name", name);

                result = comm.ExecuteNonQuery();
            }

            return result;

        }

        /// <summary>
        /// 登録と更新を実行する
        /// 登録が必要なレコードのみ登録し、差分更新を行う
        /// </summary>
        /// <param name="debitInfos"></param>
        /// <returns></returns>
        public int UpdateSomeRecords(List<InputCSVInfo> debitInfos)
        {

            var result = 99;


            var valueQueries = "";

            //CASEのWHENとそれ以降
            var whenQueries = "";

            //IN句
            var idList = "(";

            //INSERTのVALUE句の作成
            //CASE文とIN句の作成
            foreach(InputCSVInfo info in debitInfos)
            {
                //WHEN （更新対象ID） THEN　（更新するNAME）
                whenQueries = whenQueries + "WHEN " + info.ID + " THEN " + "'"+ info.Name + "' ";

                if(idList.Equals("("))
                {
                    
                    valueQueries = valueQueries + "(" + info.ID + ", '" + info.Name + "')";

                    idList = idList + info.ID + " ";

                }
                else
                {

                    valueQueries = valueQueries + ", (" + info.ID + ", '" + info.Name + "')";

                    idList =  idList+ ", " + info.ID + " ";

                }

            }

            idList = idList + ")";

            //挿入用（重複が合った場合はスルー）
            var insertQuery = InsertTableSqlIgnore + valueQueries;

            //更新用
            var updateQuery = UpdateRecordsSql_Former + whenQueries + UpdateRecordsSql_Later + idList;

            using (var conn = new MySqlConnection(ConnectionString))
            using (var comm = new MySqlCommand())
            {

                MySqlTransaction tran = null;

                try
                {
                    conn.Open();

                    tran = conn.BeginTransaction();

                    //SQLへ格納
                    comm.Connection = conn;

                    comm.CommandText = insertQuery;

                    //不存在のキーを挿入
                    comm.ExecuteNonQuery();

                    comm.CommandText = updateQuery;

                    comm.ExecuteNonQuery();

                    tran.Commit();

                    result = 0;

                }
                catch(Exception e)
                {

                    tran.Rollback();

                    Console.WriteLine("  Message: {0}", e.Message);

                    result = 1;
                }
            }

            return result;
        }

    }
}
