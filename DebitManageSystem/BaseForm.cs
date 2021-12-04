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
    public partial class BaseForm : Form
    {
        protected enum Status
        {
            Success,
            Fault
        }

        public BaseForm()
        {
            InitializeComponent();
        }



    }
}
