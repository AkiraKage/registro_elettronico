namespace registro_elettronico
{
    partial class DelStudentControl
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
            this.classSelectBox = new System.Windows.Forms.ComboBox();
            this.studentSelectBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.delStudentBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // classSelectBox
            // 
            this.classSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classSelectBox.FormattingEnabled = true;
            this.classSelectBox.Location = new System.Drawing.Point(200, 163);
            this.classSelectBox.Name = "classSelectBox";
            this.classSelectBox.Size = new System.Drawing.Size(80, 26);
            this.classSelectBox.Sorted = true;
            this.classSelectBox.TabIndex = 17;
            this.classSelectBox.SelectedIndexChanged += new System.EventHandler(this.classSelectBox_SelectedIndexChanged);
            // 
            // studentSelectBox
            // 
            this.studentSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentSelectBox.FormattingEnabled = true;
            this.studentSelectBox.Location = new System.Drawing.Point(308, 163);
            this.studentSelectBox.Name = "studentSelectBox";
            this.studentSelectBox.Size = new System.Drawing.Size(193, 26);
            this.studentSelectBox.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.OrangeRed;
            this.label13.Location = new System.Drawing.Point(178, 47);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(356, 36);
            this.label13.TabIndex = 24;
            this.label13.Text = "Elimina uno studente";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delStudentBtn
            // 
            this.delStudentBtn.Location = new System.Drawing.Point(269, 236);
            this.delStudentBtn.Name = "delStudentBtn";
            this.delStudentBtn.Size = new System.Drawing.Size(165, 32);
            this.delStudentBtn.TabIndex = 25;
            this.delStudentBtn.Text = "Elimina";
            this.delStudentBtn.UseVisualStyleBackColor = true;
            this.delStudentBtn.Click += new System.EventHandler(this.delStudentBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Seleziona classe e nome dello studente che vuoi eliminare";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DelStudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delStudentBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.classSelectBox);
            this.Controls.Add(this.studentSelectBox);
            this.Name = "DelStudentControl";
            this.Size = new System.Drawing.Size(735, 494);
            this.Load += new System.EventHandler(this.DelStudentControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox classSelectBox;
        private System.Windows.Forms.ComboBox studentSelectBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button delStudentBtn;
        private System.Windows.Forms.Label label1;
    }
}
