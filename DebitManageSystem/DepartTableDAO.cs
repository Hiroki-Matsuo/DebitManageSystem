using System;
using System.Linq;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DebitManageSystem
{
    /// <summary>
    /// 部門テーブルに関するDAO
    /// </summary>
    class DepartTableDAO : IDAOBase
    {
        private static readonly string Server = "localhost";      // ホスト名
        private static readonly int Port = 3306;                  // ポート番号
        private static readonly string Database = "debit_schema";       // データベース名
        private static readonly string Uid = "root";              // ユーザ名
        private static readonly string Pwd = "Localhost123";          // パスワード

        // 接続文字列
        private static readonly string ConnectionString = $"Server={Server}; Port={Port}; Database={Database}; Uid={Uid}; Pwd={Pwd}";
        // データ登録SQL
        private static readonly string InsertTableSql = $"INSERT INTO {Database}.depart_table (depart_cd, depart_name) VALUES (@depart_cd, @depart_name)";

        // データ登録SQL
        private static readonly string UpdateTableSql = $"Update {Database}.depart_table SET depart_name = @depart_name WHERE depart_cd = @depart_cd";

        // 複数更新SQL
        private static readonly string UpdateRecordsSql_Former = $"Update {Database}.depart_table SET depart_name = CASE depart_cd ";

        private static readonly string UpdateRecordsSql_Later = "END WHERE depart_cd IN ";

        // データ登録SQL
        private static readonly string InsertTableSqlIgnore = $"INSERT IGNORE INTO {Database}.depart_table (depart_cd, depart_name) VALUES ";

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
                comm.Parameters.AddWithValue("@depart_cd", cd);
                comm.Parameters.AddWithValue("@depart_name", name);

                result = comm.ExecuteNonQuery();

            }

            return result;

        }

        /// <summary>
        /// 取引先コードを元に検索する
        /// </summary>
        /// <param name="departCd"></param>
        /// <returns></returns>
        public depart_table SelectDepartNameForCode(int departCd)
        {

            var result = new depart_table();

            using(debit_schemaEntities ent = new debit_schemaEntities())
            {

                result = (from x in ent.depart_table
                          where x.depart_cd == departCd
                          select x).FirstOrDefault();

            }

            return result;

        }

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
                comm.Parameters.AddWithValue("@depart_cd", cd);
                comm.Parameters.AddWithValue("@depart_name", name);

                result = comm.ExecuteNonQuery();
            }

            return result;

        }

        public int UpdateSomeRecords(List<InputCSVInfo> infos)
        {

            var result = 99;


            var valueQueries = "";

            //CASEのWHENとそれ以降
            var whenQueries = "";

            //IN句
            var idList = "(";

            //INSERTのVALUE句の作成
            //CASE文とIN句の作成
            foreach (InputCSVInfo info in infos)
            {
                //WHEN （更新対象ID） THEN　（更新するNAME）
                whenQueries = whenQueries + "WHEN " + info.ID + " THEN " + "'" + info.Name + "' ";

                if (idList.Equals("("))
                {

                    valueQueries = valueQueries + "(" + info.ID + ", '" + info.Name + "')";

                    idList = idList + info.ID + " ";

                }
                else
                {

                    valueQueries = valueQueries + ", (" + info.ID + ", '" + info.Name + "')";

                    idList = idList + ", " + info.ID + " ";

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
                catch (Exception e)
                {
                    //ロールバック・軽くエラーハンドル
                    tran.Rollback();

                    Console.WriteLine("  Message: {0}", e.Message);

                    result = 1;
                }
            }

            return result;
        }
    }
}
