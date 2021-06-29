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

        public void InsertDepartRecord(int cd, string name)
        {

            using(var ent = new debit_schemaEntities())
            {

                ent.depart_table.Add(new depart_table()
                    {
                    depart_cd = cd,
                    depart_name = name,
                    
                });

                ent.SaveChanges();

            }


        }

        /// <summary>
        /// 取引先コードを元に検索する
        /// </summary>
        /// <param name="departCd"></param>
        /// <returns></returns>
        public string SelectDepartNameForCode(int departCd)
        {

            var result = "";

            using(debit_schemaEntities ent = new debit_schemaEntities())
            {


                result = (from x in ent.depart_table
                          where x.depart_cd == departCd
                          select x).FirstOrDefault().depart_name;

            }

            return result;

        }



    }
}
