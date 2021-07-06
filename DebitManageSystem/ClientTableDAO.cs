using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DebitManageSystem
{
    class ClientTableDAO
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
        private static readonly string InsertTableSql = $"INSERT INTO {Database}.client_table (client_cd, client_name) VALUES (@client_cd, @client_name)";

        // データ更新SQL
        private static readonly string UpdateTableSql = $"Update {Database}.client_table SET client_name = @client_name WHERE client_cd = @client_cd";

        /// <summary>
        /// 登録処理
        /// </summary>
        /// <param name="cd"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public int InsertDepartRecord(int cd, string name)
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
        /// <param name="clientCd"></param>
        /// <returns></returns>
        public client_table SelectDepartNameForCode(int clientCd)
        {

            var result = new client_table();

            using (debit_schemaEntities ent = new debit_schemaEntities())
            {

                result = (from x in ent.client_table
                          where x.client_cd == clientCd
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
        public int UpdateDepartRecord(int cd, string name)
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





    }
}
