using Contractflow.Forms.DashboardForm;
using Contractflow.Forms.ForgotPassword;
using Contractflow.Services;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Contractflow
{
    public partial class Login : Form
    {
        AuthService authService;
        public Login()
        {
            InitializeComponent();
            authService = new AuthService();
            emailTxtInput.Focus();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            emailTxtInput.Focus();
        }

        // Method to paint the custom gradient in the leftSidePanel
        private void leftSidePanel_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle, 
                Color.FromArgb(9, 198, 249), 
                Color.FromArgb(4, 93, 233), 
                49F
                ))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void forgotPasswordLabel_Click(object sender, EventArgs e)
        {
            RecoverPassword recoverPasswordForm = new RecoverPassword();
            recoverPasswordForm.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private async void DoLogin()
        {
            if (ValidateInputs())
            {
                if (await authService.Login(emailTxtInput.Text, passwordTxtInput.Text))
                {
                    Hide();
                    using (Dashboard dashboardForm = new Dashboard())
                    {
                        dashboardForm.ShowDialog();
                    }
                    Close();
                }
            }
        }

        private bool ValidateInputs()
        {
            emailTxtInput.Text = emailTxtInput.Text.ToString().Trim();
            passwordTxtInput.Text = passwordTxtInput.Text.ToString().Trim();
            if(emailTxtInput.Text == string.Empty || passwordTxtInput.Text == string.Empty)
            {
                MessageBox.Show(
                    "Algunos de los campos requeridos están vacíos o no son válidos.", 
                    "Error al iniciar sesión" ,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }

            return true;
        }

        private void emailTxtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }

        private void passwordTxtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }
    }
}
