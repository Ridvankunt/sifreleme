using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sezar
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSifrele frmSifrele = new frmSifrele();
            frmSifrele.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSifreCoz frmSifreCoz = new frmSifreCoz();
            frmSifreCoz.Show();
        }
    }
}
