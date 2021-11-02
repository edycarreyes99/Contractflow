
namespace Contractflow
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftSidePanel = new System.Windows.Forms.Panel();
            this.developedByLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.rightSidePanel = new System.Windows.Forms.Panel();
            this.forgotPasswordLabel = new System.Windows.Forms.Label();
            this.passwordTxtInput = new System.Windows.Forms.TextBox();
            this.emailTxtInput = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.contractflowLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.leftSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.rightSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // leftSidePanel
            // 
            this.leftSidePanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.leftSidePanel.Controls.Add(this.developedByLabel);
            this.leftSidePanel.Controls.Add(this.logoLabel);
            this.leftSidePanel.Controls.Add(this.logoImg);
            this.leftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSidePanel.Location = new System.Drawing.Point(0, 0);
            this.leftSidePanel.Name = "leftSidePanel";
            this.leftSidePanel.Size = new System.Drawing.Size(300, 530);
            this.leftSidePanel.TabIndex = 0;
            this.leftSidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftSidePanel_Paint);
            // 
            // developedByLabel
            // 
            this.developedByLabel.AutoSize = true;
            this.developedByLabel.BackColor = System.Drawing.Color.Transparent;
            this.developedByLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.developedByLabel.ForeColor = System.Drawing.Color.White;
            this.developedByLabel.Location = new System.Drawing.Point(81, 416);
            this.developedByLabel.Name = "developedByLabel";
            this.developedByLabel.Size = new System.Drawing.Size(213, 44);
            this.developedByLabel.TabIndex = 2;
            this.developedByLabel.Text = "Desarrollado por\nEdycar Reyes - FireCodes";
            this.developedByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel.Font = new System.Drawing.Font("Montserrat Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoLabel.ForeColor = System.Drawing.Color.White;
            this.logoLabel.Location = new System.Drawing.Point(55, 164);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logoLabel.Size = new System.Drawing.Size(237, 99);
            this.logoLabel.TabIndex = 1;
            this.logoLabel.Text = "Bienvenidos al\nsistema de gestión\nde contratos";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoImg
            // 
            this.logoImg.BackColor = System.Drawing.Color.Transparent;
            this.logoImg.Image = global::Contractflow.Properties.Resources.Contractflow_Logo_White;
            this.logoImg.Location = new System.Drawing.Point(94, 35);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(99, 92);
            this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImg.TabIndex = 0;
            this.logoImg.TabStop = false;
            // 
            // rightSidePanel
            // 
            this.rightSidePanel.Controls.Add(this.forgotPasswordLabel);
            this.rightSidePanel.Controls.Add(this.passwordTxtInput);
            this.rightSidePanel.Controls.Add(this.emailTxtInput);
            this.rightSidePanel.Controls.Add(this.loginBtn);
            this.rightSidePanel.Controls.Add(this.passwordLabel);
            this.rightSidePanel.Controls.Add(this.emailLabel);
            this.rightSidePanel.Controls.Add(this.loginLabel);
            this.rightSidePanel.Controls.Add(this.contractflowLabel);
            this.rightSidePanel.Controls.Add(this.closeBtn);
            this.rightSidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightSidePanel.ForeColor = System.Drawing.Color.Transparent;
            this.rightSidePanel.Location = new System.Drawing.Point(300, 0);
            this.rightSidePanel.Name = "rightSidePanel";
            this.rightSidePanel.Size = new System.Drawing.Size(450, 530);
            this.rightSidePanel.TabIndex = 1;
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.forgotPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Montserrat", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forgotPasswordLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.forgotPasswordLabel.Location = new System.Drawing.Point(226, 321);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(175, 18);
            this.forgotPasswordLabel.TabIndex = 8;
            this.forgotPasswordLabel.Text = "¿Olvidaste tu contraseña?";
            this.forgotPasswordLabel.Click += new System.EventHandler(this.forgotPasswordLabel_Click);
            // 
            // passwordTxtInput
            // 
            this.passwordTxtInput.AccessibleDescription = "";
            this.passwordTxtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTxtInput.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxtInput.Location = new System.Drawing.Point(135, 285);
            this.passwordTxtInput.Name = "passwordTxtInput";
            this.passwordTxtInput.PasswordChar = '*';
            this.passwordTxtInput.Size = new System.Drawing.Size(263, 24);
            this.passwordTxtInput.TabIndex = 7;
            this.passwordTxtInput.UseSystemPasswordChar = true;
            // 
            // emailTxtInput
            // 
            this.emailTxtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTxtInput.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTxtInput.Location = new System.Drawing.Point(135, 239);
            this.emailTxtInput.Name = "emailTxtInput";
            this.emailTxtInput.Size = new System.Drawing.Size(263, 24);
            this.emailTxtInput.TabIndex = 6;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(179, 362);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(120, 41);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Iniciar Sesión";
            this.loginBtn.UseVisualStyleBackColor = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.Color.Black;
            this.passwordLabel.Location = new System.Drawing.Point(25, 287);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(103, 22);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Contraseña";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(57, 241);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(71, 22);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Usuario";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Montserrat Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.ForeColor = System.Drawing.Color.Black;
            this.loginLabel.Location = new System.Drawing.Point(71, 164);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(327, 33);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Inicia sesión con tu cuenta";
            // 
            // contractflowLabel
            // 
            this.contractflowLabel.AutoSize = true;
            this.contractflowLabel.BackColor = System.Drawing.Color.Transparent;
            this.contractflowLabel.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contractflowLabel.ForeColor = System.Drawing.Color.Black;
            this.contractflowLabel.Location = new System.Drawing.Point(3, 18);
            this.contractflowLabel.Name = "contractflowLabel";
            this.contractflowLabel.Size = new System.Drawing.Size(226, 44);
            this.contractflowLabel.TabIndex = 1;
            this.contractflowLabel.Text = "Contractflow";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundImage = global::Contractflow.Properties.Resources.close_icon;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Location = new System.Drawing.Point(408, 26);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.rightSidePanel);
            this.Controls.Add(this.leftSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contractflow";
            this.leftSidePanel.ResumeLayout(false);
            this.leftSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.rightSidePanel.ResumeLayout(false);
            this.rightSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftSidePanel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.Panel rightSidePanel;
        private System.Windows.Forms.Label developedByLabel;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Label contractflowLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox passwordTxtInput;
        private System.Windows.Forms.TextBox emailTxtInput;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label forgotPasswordLabel;
    }
}

