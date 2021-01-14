using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Inventory
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {

            InitializeComponent();

            tmSplash.Start();
        }

        private void tmSplash_Tick(object sender, EventArgs e)
        {
            tmSplash.Stop();

            showLoginForm();
        }

        private void showLoginForm()
        {
            FrmLogin frmLogin = new FrmLogin();

            this.Hide();

            frmLogin.Show();
        }

        public void Suicide()
        {
            this.Close();
        }
    }
}
