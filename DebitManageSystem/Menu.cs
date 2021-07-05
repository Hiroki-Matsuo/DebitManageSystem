using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebitManageSystem
{
    public partial class Menu : BaseForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 画面を閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EndButton_Click(object sender, EventArgs e)
        {

            this.Close();           

        }


        public void button1_Click(object sender, EventArgs e)
        {

            string connstr = "userid=root; Port=3306; password=Localhost123; database=debit_schema; Host=localhost";
            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();
            // datatableを設定
            DataTable dt = new DataTable();

            // SQL文と接続情報を指定し、データアダプタを作成
            MySqlDataAdapter da = new MySqlDataAdapter("select * from client_table", conn);

            // 結果をdatatableに格納
            da.Fill(dt);

            //DataRowsに格納してからデータを取得する⑤
            string sampleStr = string.Empty;

            foreach (DataRow dr in dt.Rows)
            {
                sampleStr = sampleStr + dr[1].ToString() + ",";
            }
            this.textBox1.Text = sampleStr;


            conn.Close();

        }

        /// <summary>
        /// 部門管理画面を表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepartManagebutton_Click(object sender, EventArgs e)
        {

            this.Visible = false;

            var departManageForm = new DepartManageForm();

            departManageForm.ShowDialog();

            this.Visible = true;

        }

        private void ClientManageButton_Click(object sender, EventArgs e)
        {

            this.Visible = false;

            var clientManageForm = new ClientManageForm();

            clientManageForm.ShowDialog();

            Visible = true;

        }
    }
}
