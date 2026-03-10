namespace ShoesProject
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pbLogo = new PictureBox();
            pnMain = new Panel();
            btnGuest = new Button();
            btnLogin = new Button();
            lbPassword = new Label();
            txtPassword = new TextBox();
            txtlogin = new TextBox();
            lblogin = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(141, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pnMain
            // 
            pnMain.Anchor = AnchorStyles.None;
            pnMain.Controls.Add(btnGuest);
            pnMain.Controls.Add(btnLogin);
            pnMain.Controls.Add(lbPassword);
            pnMain.Controls.Add(txtPassword);
            pnMain.Controls.Add(txtlogin);
            pnMain.Controls.Add(lblogin);
            pnMain.Location = new Point(31, 129);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(322, 220);
            pnMain.TabIndex = 1;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.Chartreuse;
            btnGuest.BackgroundImageLayout = ImageLayout.Center;
            btnGuest.FlatAppearance.BorderSize = 0;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Location = new Point(86, 185);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(150, 30);
            btnGuest.TabIndex = 5;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += BtnGuest_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSpringGreen;
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(86, 143);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(132, 74);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(58, 19);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(36, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 26);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtlogin
            // 
            txtlogin.Location = new Point(36, 36);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(250, 26);
            txtlogin.TabIndex = 1;
            txtlogin.UseSystemPasswordChar = true;
            // 
            // lblogin
            // 
            lblogin.AutoSize = true;
            lblogin.Location = new Point(135, 5);
            lblogin.Name = "lblogin";
            lblogin.Size = new Size(52, 19);
            lblogin.TabIndex = 0;
            lblogin.Text = "Логин";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(pnMain);
            Controls.Add(pbLogo);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Panel pnMain;
        private Button btnGuest;
        private Button btnLogin;
        private Label lbPassword;
        private TextBox txtPassword;
        private TextBox txtlogin;
        private Label lblogin;
    }
}