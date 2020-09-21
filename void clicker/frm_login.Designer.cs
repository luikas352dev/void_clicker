namespace void_client
{
    partial class frm_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.txt_user = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lb_logo = new System.Windows.Forms.Label();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.txt_pass = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.btn_login = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pn_bottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.AcceptsReturn = false;
            this.txt_user.AcceptsTab = false;
            this.txt_user.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_user.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_user.BackgroundImage")));
            this.txt_user.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(222)))));
            this.txt_user.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_user.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(222)))));
            this.txt_user.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txt_user.BorderRadius = 1;
            this.txt_user.BorderThickness = 0;
            this.txt_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_user.DefaultFont = new System.Drawing.Font("Roboto", 10F);
            this.txt_user.DefaultText = "";
            this.txt_user.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_user.ForeColor = System.Drawing.Color.White;
            this.txt_user.HideSelection = true;
            this.txt_user.IconLeft = null;
            this.txt_user.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txt_user.IconPadding = 10;
            this.txt_user.IconRight = null;
            this.txt_user.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txt_user.Location = new System.Drawing.Point(170, 104);
            this.txt_user.MaxLength = 16;
            this.txt_user.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_user.Modified = false;
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.ReadOnly = false;
            this.txt_user.SelectedText = "";
            this.txt_user.SelectionLength = 0;
            this.txt_user.SelectionStart = 0;
            this.txt_user.ShortcutsEnabled = true;
            this.txt_user.Size = new System.Drawing.Size(272, 35);
            this.txt_user.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txt_user.TabIndex = 0;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_user.TextMarginLeft = 5;
            this.txt_user.TextPlaceholder = "username";
            this.txt_user.UseSystemPasswordChar = false;
            // 
            // lb_logo
            // 
            this.lb_logo.AutoSize = true;
            this.lb_logo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.lb_logo.ForeColor = System.Drawing.Color.White;
            this.lb_logo.Location = new System.Drawing.Point(26, 20);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(47, 23);
            this.lb_logo.TabIndex = 2;
            this.lb_logo.Text = "void";
            // 
            // pic_close
            // 
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(576, 27);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(10, 10);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_close.TabIndex = 3;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.AcceptsReturn = false;
            this.txt_pass.AcceptsTab = false;
            this.txt_pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_pass.BackgroundImage")));
            this.txt_pass.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(222)))));
            this.txt_pass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_pass.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(222)))));
            this.txt_pass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txt_pass.BorderRadius = 1;
            this.txt_pass.BorderThickness = 0;
            this.txt_pass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_pass.DefaultFont = new System.Drawing.Font("Roboto", 10F);
            this.txt_pass.DefaultText = "";
            this.txt_pass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_pass.ForeColor = System.Drawing.Color.White;
            this.txt_pass.HideSelection = true;
            this.txt_pass.IconLeft = null;
            this.txt_pass.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txt_pass.IconPadding = 10;
            this.txt_pass.IconRight = null;
            this.txt_pass.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txt_pass.Location = new System.Drawing.Point(170, 167);
            this.txt_pass.MaxLength = 16;
            this.txt_pass.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_pass.Modified = false;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '•';
            this.txt_pass.ReadOnly = false;
            this.txt_pass.SelectedText = "";
            this.txt_pass.SelectionLength = 0;
            this.txt_pass.SelectionStart = 0;
            this.txt_pass.ShortcutsEnabled = true;
            this.txt_pass.Size = new System.Drawing.Size(272, 35);
            this.txt_pass.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txt_pass.TabIndex = 4;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_pass.TextMarginLeft = 5;
            this.txt_pass.TextPlaceholder = "password";
            this.txt_pass.UseSystemPasswordChar = false;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Roboto", 9F);
            this.lb_username.ForeColor = System.Drawing.Color.White;
            this.lb_username.Location = new System.Drawing.Point(170, 86);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(61, 14);
            this.lb_username.TabIndex = 5;
            this.lb_username.Text = "username";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Roboto", 9F);
            this.lb_pass.ForeColor = System.Drawing.Color.White;
            this.lb_pass.Location = new System.Drawing.Point(170, 150);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(60, 14);
            this.lb_pass.TabIndex = 6;
            this.lb_pass.Text = "password";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.ButtonText = "sign in";
            this.btn_login.ButtonTextMarginLeft = 0;
            this.btn_login.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btn_login.DisabledFillColor = System.Drawing.Color.Gray;
            this.btn_login.DisabledForecolor = System.Drawing.Color.White;
            this.btn_login.Font = new System.Drawing.Font("Roboto", 9.5F);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.IconPadding = 5;
            this.btn_login.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(222)))));
            this.btn_login.IdleBorderRadius = 1;
            this.btn_login.IdleBorderThickness = 0;
            this.btn_login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(222)))));
            this.btn_login.IdleIconLeftImage = null;
            this.btn_login.IdleIconRightImage = null;
            this.btn_login.Location = new System.Drawing.Point(170, 219);
            this.btn_login.Name = "btn_login";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(222)))));
            stateProperties1.BorderRadius = 0;
            stateProperties1.BorderThickness = 0;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(222)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btn_login.onHoverState = stateProperties1;
            this.btn_login.Size = new System.Drawing.Size(272, 33);
            this.btn_login.TabIndex = 7;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pn_bottom
            // 
            this.pn_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(222)))));
            this.pn_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_bottom.Location = new System.Drawing.Point(0, 337);
            this.pn_bottom.Name = "pn_bottom";
            this.pn_bottom.Size = new System.Drawing.Size(612, 1);
            this.pn_bottom.TabIndex = 8;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(612, 338);
            this.Controls.Add(this.pn_bottom);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.lb_logo);
            this.Controls.Add(this.txt_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_user;
        private System.Windows.Forms.Label lb_logo;
        private System.Windows.Forms.PictureBox pic_close;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_pass;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_pass;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_login;
        private System.Windows.Forms.Panel pn_bottom;
    }
}

