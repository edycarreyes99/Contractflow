
namespace Contractflow.Forms.ForgotPassword
{
    partial class RecoverPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelRecoverPasswordBtn = new System.Windows.Forms.Button();
            this.recoverPasswordBtn = new System.Windows.Forms.Button();
            this.recoverEmailTxtInput = new System.Windows.Forms.TextBox();
            this.userRecoverPasswordLabel = new System.Windows.Forms.Label();
            this.recoverPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelRecoverPasswordBtn
            // 
            this.cancelRecoverPasswordBtn.Location = new System.Drawing.Point(203, 120);
            this.cancelRecoverPasswordBtn.Name = "cancelRecoverPasswordBtn";
            this.cancelRecoverPasswordBtn.Size = new System.Drawing.Size(85, 30);
            this.cancelRecoverPasswordBtn.TabIndex = 14;
            this.cancelRecoverPasswordBtn.Text = "Cancelar";
            this.cancelRecoverPasswordBtn.UseVisualStyleBackColor = true;
            this.cancelRecoverPasswordBtn.Click += new System.EventHandler(this.cancelRecoverPasswordBtn_Click);
            // 
            // recoverPasswordBtn
            // 
            this.recoverPasswordBtn.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recoverPasswordBtn.Location = new System.Drawing.Point(112, 120);
            this.recoverPasswordBtn.Name = "recoverPasswordBtn";
            this.recoverPasswordBtn.Size = new System.Drawing.Size(85, 30);
            this.recoverPasswordBtn.TabIndex = 13;
            this.recoverPasswordBtn.Text = "Recuperar";
            this.recoverPasswordBtn.UseVisualStyleBackColor = true;
            this.recoverPasswordBtn.Click += new System.EventHandler(this.recoverPasswordBtn_Click);
            // 
            // recoverEmailTxtInput
            // 
            this.recoverEmailTxtInput.BackColor = System.Drawing.Color.White;
            this.recoverEmailTxtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recoverEmailTxtInput.Location = new System.Drawing.Point(97, 77);
            this.recoverEmailTxtInput.Name = "recoverEmailTxtInput";
            this.recoverEmailTxtInput.Size = new System.Drawing.Size(256, 22);
            this.recoverEmailTxtInput.TabIndex = 12;
            // 
            // userRecoverPasswordLabel
            // 
            this.userRecoverPasswordLabel.AutoSize = true;
            this.userRecoverPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.userRecoverPasswordLabel.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userRecoverPasswordLabel.Location = new System.Drawing.Point(27, 77);
            this.userRecoverPasswordLabel.Name = "userRecoverPasswordLabel";
            this.userRecoverPasswordLabel.Size = new System.Drawing.Size(63, 20);
            this.userRecoverPasswordLabel.TabIndex = 11;
            this.userRecoverPasswordLabel.Text = "Usuario";
            // 
            // recoverPasswordLabel
            // 
            this.recoverPasswordLabel.AutoSize = true;
            this.recoverPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.recoverPasswordLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recoverPasswordLabel.Location = new System.Drawing.Point(101, 12);
            this.recoverPasswordLabel.Name = "recoverPasswordLabel";
            this.recoverPasswordLabel.Size = new System.Drawing.Size(191, 22);
            this.recoverPasswordLabel.TabIndex = 10;
            this.recoverPasswordLabel.Text = "Recuperar Contraseña";
            // 
            // RecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 174);
            this.Controls.Add(this.cancelRecoverPasswordBtn);
            this.Controls.Add(this.recoverPasswordBtn);
            this.Controls.Add(this.recoverEmailTxtInput);
            this.Controls.Add(this.userRecoverPasswordLabel);
            this.Controls.Add(this.recoverPasswordLabel);
            this.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecoverPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelRecoverPasswordBtn;
        private System.Windows.Forms.Button recoverPasswordBtn;
        private System.Windows.Forms.TextBox recoverEmailTxtInput;
        private System.Windows.Forms.Label userRecoverPasswordLabel;
        private System.Windows.Forms.Label recoverPasswordLabel;
    }
}