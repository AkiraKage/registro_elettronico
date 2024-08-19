namespace registro_elettronico
{
    partial class Form1
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.summary_btn = new System.Windows.Forms.Button();
            this.summaryControl1 = new registro_elettronico.SummaryControl();
            this.loginControl1 = new registro_elettronico.LoginControl();
            this.addNewControl1 = new registro_elettronico.AddNewControl();
            this.addScoresControl1 = new registro_elettronico.AddScoresControl();
            this.delStudentControl1 = new registro_elettronico.DelStudentControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.delete_btn);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.new_btn);
            this.panel1.Controls.Add(this.summary_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 561);
            this.panel1.TabIndex = 0;
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(0, 55);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(187, 43);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(0, 325);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(187, 43);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Elimina";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(0, 266);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(187, 43);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Aggiungi voti";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // new_btn
            // 
            this.new_btn.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_btn.Location = new System.Drawing.Point(0, 207);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(187, 43);
            this.new_btn.TabIndex = 2;
            this.new_btn.Text = "Registra nuovo";
            this.new_btn.UseVisualStyleBackColor = true;
            // 
            // summary_btn
            // 
            this.summary_btn.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_btn.Location = new System.Drawing.Point(0, 148);
            this.summary_btn.Name = "summary_btn";
            this.summary_btn.Size = new System.Drawing.Size(187, 43);
            this.summary_btn.TabIndex = 1;
            this.summary_btn.Text = "Situazione";
            this.summary_btn.UseVisualStyleBackColor = true;
            // 
            // summaryControl1
            // 
            this.summaryControl1.Location = new System.Drawing.Point(187, 0);
            this.summaryControl1.Name = "summaryControl1";
            this.summaryControl1.Size = new System.Drawing.Size(767, 561);
            this.summaryControl1.TabIndex = 2;
            // 
            // loginControl1
            // 
            this.loginControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginControl1.Location = new System.Drawing.Point(187, 0);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(767, 561);
            this.loginControl1.TabIndex = 1;
            // 
            // addNewControl1
            // 
            this.addNewControl1.Location = new System.Drawing.Point(187, 0);
            this.addNewControl1.Name = "addNewControl1";
            this.addNewControl1.Size = new System.Drawing.Size(767, 561);
            this.addNewControl1.TabIndex = 3;
            // 
            // addScoresControl1
            // 
            this.addScoresControl1.Location = new System.Drawing.Point(187, 0);
            this.addScoresControl1.Name = "addScoresControl1";
            this.addScoresControl1.Size = new System.Drawing.Size(767, 561);
            this.addScoresControl1.TabIndex = 4;
            // 
            // delStudentControl1
            // 
            this.delStudentControl1.Location = new System.Drawing.Point(187, 0);
            this.delStudentControl1.Name = "delStudentControl1";
            this.delStudentControl1.Size = new System.Drawing.Size(767, 561);
            this.delStudentControl1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.delStudentControl1);
            this.Controls.Add(this.addScoresControl1);
            this.Controls.Add(this.addNewControl1);
            this.Controls.Add(this.summaryControl1);
            this.Controls.Add(this.loginControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button summary_btn;
        private System.Windows.Forms.Button login_btn;
        private LoginControl loginControl1;
        private SummaryControl summaryControl1;
        private AddNewControl addNewControl1;
        private AddScoresControl addScoresControl1;
        private DelStudentControl delStudentControl1;
    }
}

