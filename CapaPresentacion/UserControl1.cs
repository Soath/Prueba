using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void kryptonLinkLabel7_LinkClicked(object sender, EventArgs e)
        {

        }

        private void kryptonLinkLabel8_LinkClicked(object sender, EventArgs e)
        {
            Form FrmExcel = new FrmExcel();
            FrmExcel.ShowDialog();

        }
    }
}
