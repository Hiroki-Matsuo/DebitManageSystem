using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebitManageSystem
{
    public partial class InputCSVForm : BaseForm
    {
        private List<DebitInfo> Subjects;
        BindingSource bindingSource;

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
        private void InputButton_Click(object sender, EventArgs e)
        {

            //CSVファイルのパスを開く
            StreamReader reader = new StreamReader(FilePathTextBox.Text);
            {

                // 配列からリストに格納する

                // 末尾まで繰り返す
                while (!reader.EndOfStream)
                {
                    // CSVファイルの一行を読み込む
                    string line = reader.ReadLine();
                    // 読み込んだ一行をカンマ毎に分けて配列に格納する
                    string[] values = line.Split(',');

                    DebitInfo debitInfo = new DebitInfo();

                    debitInfo.ID = int.Parse(values[0]);
                    debitInfo.SubjectName = values[1];


                    Subjects.Add(debitInfo);
                }

                dataGridView1.DataSource = Subjects;

                ExecuteButton.Enabled = true;

            }

        }

        private void InputCSVForm_Load(object sender, EventArgs e)
        {

            Subjects = new List<DebitInfo>();

            bindingSource = new BindingSource(Subjects, string.Empty);

            dataGridView1.DataSource = bindingSource;

            //更新ボタンはInput前で使用不可の状態にする
            ExecuteButton.Enabled = false;

        }


        /// <summary>
        /// 表示しているデータをDBに連携する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExecuteButton_Click(object sender, EventArgs e)
        {



        }
    }
}
