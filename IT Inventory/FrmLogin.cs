using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Inventory
{
    public partial class FrmLogin : Form
    {
        FrmSplashScreen frmSplashScreen;

        private bool mouseIsDown = false;
        private Point firstPoint;

        public FrmLogin()
        {
            InitializeComponent();    
        }

        #region TITLE BAR EVENTS

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }
        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }
        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SignIn();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        


        private void SignIn()
        {
            if(!String.IsNullOrEmpty(txtUser.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                clsDBHelper dBHelper = new clsDBHelper();

                if (dBHelper.IsUserEnable(txtUser.Text))
                {
                    if (clsLogin.isAnActiveDirectoryUser(txtUser.Text, txtPassword.Text))
                    {
                        GetUserInformation();

                        if (clsUserInformation.PREFERENCES_SHOW_INITIAL_CATEGORY_FORM) ShowMainInitialCategoryForm();
                        else ShowMainForm();

                        // ShowMainForm();
                    }
                    else
                        MessageBox.Show("La contraseña ingresada es incorrecta");
                }
                else
                {
                    MessageBox.Show("El nombre de usuario es invalido o no tiene permisos para iniciar sesión en la aplicación.", "IT Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }                      
        }

        private void GetUserInformation()
        {
            // Pendiente query para obtener la información del usuario.
            clsUserInformation.NAME = "Abel Estrada";
            clsUserInformation.USERNAME = "abel.estrada";
            clsUserInformation.PREFERENCES_SHOW_INITIAL_CATEGORY_FORM = true;
        }

        private void ShowMainInitialCategoryForm()
        {
            FrmMainInitialCategory frm = new FrmMainInitialCategory();
            this.Hide();
            frm.Show();
        }

        private void ShowMainForm()
        {
            FrmMain frmMain = new FrmMain(-1);
            this.Hide();
            frmMain.Show();
        }




    }
}
