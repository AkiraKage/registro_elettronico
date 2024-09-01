namespace registro_elettronico
{
    partial class AdminControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newSurnameBox = new System.Windows.Forms.TextBox();
            this.newNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cognome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newSurnameBox
            // 
            this.newSurnameBox.Location = new System.Drawing.Point(469, 179);
            this.newSurnameBox.Margin = new System.Windows.Forms.Padding(4);
            this.newSurnameBox.Name = "newSurnameBox";
            this.newSurnameBox.Size = new System.Drawing.Size(178, 20);
            this.newSurnameBox.TabIndex = 15;
            // 
            // newNameBox
            // 
            this.newNameBox.Location = new System.Drawing.Point(215, 179);
            this.newNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Size = new System.Drawing.Size(150, 20);
            this.newNameBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Espressione chiave";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(297, 270);
            this.keyBox.Margin = new System.Windows.Forms.Padding(4);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(178, 20);
            this.keyBox.TabIndex = 18;
            // 
            // register_btn
            // 
            this.register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.register_btn.Location = new System.Drawing.Point(546, 265);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(101, 28);
            this.register_btn.TabIndex = 20;
            this.register_btn.Text = "Registra";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Red;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(125, 82);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(577, 41);
            this.label13.TabIndex = 24;
            this.label13.Text = "Aggiungi un nuovo insegnante (accesso privilegiato)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newSurnameBox);
            this.Controls.Add(this.newNameBox);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(843, 539);
            this.Load += new System.EventHandler(this.AdminControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newSurnameBox;
        private System.Windows.Forms.TextBox newNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label label13;
    }
}
