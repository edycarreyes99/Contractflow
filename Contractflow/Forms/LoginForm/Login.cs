using Contractflow.Forms.ForgotPassword;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Contractflow
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
    }
}
