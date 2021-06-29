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
        DepartTableDAO departTableDAO = new DepartTableDAO();

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
            departTableDAO.InsertDepartRecord(Int32.Parse(DepartId_DisplayTextBox.Text), DepartNameTextBox.Text);


            //テキストボックスから消す
            DepartId_DisplayTextBox.Text = "";
            DepartNameTextBox.Text = "";
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            DepartNameTextBox.Text = departTableDAO.SelectDepartNameForCode(Int32.Parse(DepartId_SearchTextBox.Text));

            DepartId_DisplayTextBox.Text = DepartId_SearchTextBox.Text;

        }
    }
}
