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
    public partial class InputCSVForm : ListBaseForm
    {
        //メッセージ
        private static readonly string SUCCEED_MESSAGE = "更新成功";
        private static readonly string ERROR_MESSAGE = "更新エラー発生";

        private List<InputCSVInfo> InputRecords;

        BindingSource bindingSource;

        public InputCSVForm()
        {
            InitializeComponent();

            //ファイルのデータをそのまま更新する機能のため
            ListGridView.AllowUserToAddRows = false;
            ListGridView.AllowUserToDeleteRows = false;
            ListGridView.ReadOnly = true;

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
                ListGridView.DataSource = null;

                InputRecords.Clear();

                // 配列からリストに格納する

                // 末尾まで繰り返す
                while (!reader.EndOfStream)
                {
                    // CSVファイルの一行を読み込む
                    string line = reader.ReadLine();
                    // 読み込んだ一行をカンマ毎に分けて配列に格納する
                    string[] values = line.Split(',');

                    var csvInfo = new InputCSVInfo();

                    csvInfo.ID = int.Parse(values[0]);
                    csvInfo.Name = values[1];


                    InputRecords.Add(csvInfo);
                }

                ListGridView.DataSource = InputRecords;

                ExecuteButton.Enabled = true;

            }

        }

        private void InputCSVForm_Load(object sender, EventArgs e)
        {

            InputRecords = new List<InputCSVInfo>();

            bindingSource = new BindingSource(InputRecords, string.Empty);

            ListGridView.DataSource = bindingSource;

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

            IDAOBase dao;

            if(ItemCombo.SelectedIndex == ((int)TableItem.取引先))
            {
                dao = new ClientTableDAO();
            }
            else if(ItemCombo.SelectedIndex == (int)TableItem.部門)
            {
                dao = new DepartTableDAO();
            }
            else
            {
                dao = new ClientTableDAO();
            }

            var result = dao.UpdateSomeRecords(InputRecords);

            var SQLMessage ="";

            if(result == (int)BaseForm.Status.Success)
            {

                SQLMessage = SUCCEED_MESSAGE;

            }
            else
            {
                SQLMessage = ERROR_MESSAGE;
            }



            MessageBox.Show("結果：" + SQLMessage , "システム", MessageBoxButtons.OK);

        }


    }
}
