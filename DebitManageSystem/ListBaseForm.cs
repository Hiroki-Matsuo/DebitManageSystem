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
    /// <summary>
    /// リスト表示する画面のベースフォーム
    /// </summary>
    public partial class ListBaseForm : BaseForm
    {

        protected enum TableItem 
        {
            取引先,
            部門,
            与信情報
        }
        

        public ListBaseForm()
        {
            InitializeComponent();
        }

        private　protected void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        /// <summary>
        /// コンボボックスにアイテムを追加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBaseForm_Load(object sender, EventArgs e)
        {

            foreach (TableItem item in Enum.GetValues(typeof(TableItem)))
            {

                ItemCombo.Items.Add(item.ToString());

            }

        }
    }
}
