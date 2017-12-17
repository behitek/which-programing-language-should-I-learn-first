using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Which_Programing_Should_I_Learn
{
    public partial class frmHistory : Form
    {
        public frmHistory(String history)
        {
            InitializeComponent();
            this.txtView.Text = history;
        }
    }
}
