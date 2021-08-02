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

            var checkRes = departTableDAO.SelectDepartNameForCode(Int32.Parse(DepartId_DisplayTextBox.Text));

            string message;
            MessageBoxIcon msgStyle = MessageBoxIcon.Information;
            if (checkRes == null)
            {
                //登録処理
                var result = departTableDAO.InsertDepartRecord(Int32.Parse(DepartId_DisplayTextBox.Text), DepartNameTextBox.Text);

                if (result != 1)
                {

                    message  = "登録エラーです。";
                    msgStyle = MessageBoxIcon.Error;

                    return;

                }

                message = "登録完了しました。";
                msgStyle = MessageBoxIcon.Information;
            }
            else
            {//更新処理

                var result = departTableDAO.UpdateDepartRecord(Int32.Parse(DepartId_DisplayTextBox.Text), DepartNameTextBox.Text);

                if(result != 1)
                {
                    message = "更新エラーです。";
                    msgStyle = MessageBoxIcon.Error;
                    return;
                }

                message = "登録完了しました。";
                msgStyle = MessageBoxIcon.Information;
            }

            MessageBox.Show(message, "システム",MessageBoxButtons.OK, msgStyle);

            //テキストボックスから消す
            DepartId_DisplayTextBox.Text = "";
            DepartNameTextBox.Text = "";
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

             var result= departTableDAO.SelectDepartNameForCode(Int32.Parse(DepartId_SearchTextBox.Text));

            if (result != null)
            {
                DepartNameTextBox.Text = result.depart_name;
                DepartId_DisplayTextBox.Text = DepartId_SearchTextBox.Text;
            }
            else
            {
                MessageBox.Show("IDが存在しませんでした。");
            }
        }
    }
}
