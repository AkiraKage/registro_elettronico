namespace registro_elettronico
{
    partial class LoginControl
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.access_btn = new System.Windows.Forms.Button();
            this.pass_visibility = new System.Windows.Forms.Button();
            this.login_error_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(247, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accedi al registro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username_txtbox
            // 
            this.username_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txtbox.Location = new System.Drawing.Point(317, 191);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(193, 24);
            this.username_txtbox.TabIndex = 3;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txtbox.Location = new System.Drawing.Point(317, 249);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(193, 24);
            this.password_txtbox.TabIndex = 4;
            this.password_txtbox.UseSystemPasswordChar = true;
            // 
            // access_btn
            // 
            this.access_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.access_btn.Location = new System.Drawing.Point(304, 316);
            this.access_btn.Name = "access_btn";
            this.access_btn.Size = new System.Drawing.Size(116, 34);
            this.access_btn.TabIndex = 5;
            this.access_btn.Text = "Accedi";
            this.access_btn.UseVisualStyleBackColor = true;
            this.access_btn.Click += new System.EventHandler(this.access_btn_Click);
            // 
            // pass_visibility
            // 
            this.pass_visibility.BackgroundImage = global::registro_elettronico.Properties.Resources.no_eye;
            this.pass_visibility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pass_visibility.Location = new System.Drawing.Point(516, 246);
            this.pass_visibility.Name = "pass_visibility";
            this.pass_visibility.Size = new System.Drawing.Size(29, 30);
            this.pass_visibility.TabIndex = 6;
            this.pass_visibility.UseVisualStyleBackColor = true;
            this.pass_visibility.Click += new System.EventHandler(this.pass_visibility_Click);
            // 
            // login_error_lbl
            // 
            this.login_error_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.login_error_lbl.Location = new System.Drawing.Point(225, 285);
            this.login_error_lbl.Name = "login_error_lbl";
            this.login_error_lbl.Size = new System.Drawing.Size(271, 23);
            this.login_error_lbl.TabIndex = 7;
            this.login_error_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.login_error_lbl);
            this.Controls.Add(this.pass_visibility);
            this.Controls.Add(this.access_btn);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.username_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(836, 523);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Button access_btn;
        private System.Windows.Forms.Button pass_visibility;
        private System.Windows.Forms.Label login_error_lbl;
    }
}
