using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            ControlBox = false;
        }
        #region открытие форм
        private void btnTaken_Click(object sender, EventArgs e)
        {
            FormTaken ft = new FormTaken();
            ft.Show();
        }

       
        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReport fr = new FormReport();
            fr.Show();
        }

        private void btnSklads_Click(object sender, EventArgs e)
        {
            FormSklad fsklad = new FormSklad();
            fsklad.Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            FormSale fssale = new FormSale();
            fssale.Show();
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите выйти?", "Внимание!", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
              Application.Exit();
            }
            else if (dialog == DialogResult.Cancel)
            {
            }
          
        }
        private void btnMiniClose_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       
    }
}
