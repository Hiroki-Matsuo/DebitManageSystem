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
    public partial class ClientManageForm : BaseForm
    {

        ClientTableDAO clientTableDAO = new ClientTableDAO();

        public ClientManageForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 画面を閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var result = clientTableDAO.SelectDepartNameForCode(Int32.Parse(ClientId_SearchTextBox.Text));

            if (result != null)
            {
                ClientNameTextBox.Text = result.client_name;
                ClientId_DisplayTextBox.Text = ClientId_SearchTextBox.Text;
            }
            else
            {
                MessageBox.Show("IDが存在しませんでした。");
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            //CDがテーブルに存在するかチェック
            var checkRes = clientTableDAO.SelectDepartNameForCode(Int32.Parse(ClientId_DisplayTextBox.Text));

            //メッセージを格納
            string message;
            MessageBoxIcon msgStyle = MessageBoxIcon.Information;
            if (checkRes == null)
            {
                //登録処理
                var result = clientTableDAO.InsertDepartRecord(Int32.Parse(ClientId_DisplayTextBox.Text), ClientNameTextBox.Text);

                if (result != 1)
                {

                    message = "登録エラーです。";
                    msgStyle = MessageBoxIcon.Error;

                }
                else
                {
                    message = "登録完了しました。";
                    msgStyle = MessageBoxIcon.Information;
                }
            }
            else
            {//更新処理

                var result = clientTableDAO.UpdateDepartRecord(Int32.Parse(ClientId_DisplayTextBox.Text), ClientNameTextBox.Text);

                if (result != 1)
                {
                    message = "更新エラーです。";
                    msgStyle = MessageBoxIcon.Error;
                }
                else
                {

                    message = "登録完了しました。";
                    msgStyle = MessageBoxIcon.Information;
                }

            }

            MessageBox.Show(message,"システム", MessageBoxButtons.OK, msgStyle);

            //テキストボックスから消す
            ClientId_DisplayTextBox.Text = "";
            ClientNameTextBox.Text = "";

        }
    }
}
