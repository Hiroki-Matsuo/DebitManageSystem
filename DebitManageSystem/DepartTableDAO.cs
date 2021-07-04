using System;
using System.Linq;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace DebitManageSystem
{
    /// <summary>
    /// 部門テーブルに関するDAO
    /// </summary>
    public class DepartTableDAO
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

        public int UpdateDepartRecord(int cd, string name)
        {

            var result = 99;

            using(debit_schemaEntities ent = new debit_schemaEntities())
            {

                var departData = ent.depart_table.Single(x => x.depart_cd == cd);

                departData.depart_name = name;

                result = ent.SaveChanges();

            }

            return result;


        }



    }
}
