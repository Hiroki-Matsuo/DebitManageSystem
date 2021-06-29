using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DebitManageSystem
{
    public partial class DepartManageForm : BaseForm
    {
        public DepartManageForm()
        {
            InitializeComponent();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 入力している部門IDがレコードに無ければ登録、あれば更新する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {

            //まず登録処理を実装する
            string insertSql = $"INSERT INTO debit_schema.depart_table (depart_cd, depart_name) VALUES(" + DepartId_DisplayTextBox.Text + ", '" + DepartNameTextBox.Text + "');";

            string connstr = "userid=root; Port=3306; password=Localhost123; database=debit_schema; Host=localhost";

            try
            {

                using (MySqlConnection conn = new MySqlConnection(connstr))
                    using(var command = new MySqlCommand())
                {

                    conn.Open();
                    // datatableを設定
                    DataTable dt = new DataTable();

                    // SQL文と接続情報を指定し、データアダプタを作成
                    command.Connection = conn;
                    command.CommandText = insertSql;

                    var result = command.ExecuteNonQuery();

                    conn.Close();
                }

                //テキストボックスから消す
                DepartId_DisplayTextBox.Text = "";
                DepartNameTextBox.Text = "";
            }
            catch(Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
            finally
            {

                MessageBox.Show("処理を実行しました。");

            }
        }
    }
}
