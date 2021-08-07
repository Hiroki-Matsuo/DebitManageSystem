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
    public partial class InputCSVForm : BaseForm
    {
        public InputCSVForm()
        {
            InitializeComponent();
        }


        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        /// <summary>
        /// ダイアログを開き、ファイルを選択する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchFilePathButton_Click(object sender, EventArgs e)
        {

            //クラスをNewする
            OpenFileDialog ofd = new OpenFileDialog();

            //ダイアログの設定する

            ofd.Filter = "CSVファイル(*.csv)|*.csv";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKを選んだ場合テキストボックスに入力する

                FilePathTextBox.Text = ofd.FileName;
            }

        }

        /// <summary>
        /// CSVを取り込み、データを持った上で画面のDataGridViewに表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExecuteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
