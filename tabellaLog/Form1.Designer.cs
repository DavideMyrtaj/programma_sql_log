namespace tabellaLog
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.azione1 = new System.Windows.Forms.Button();
            this.azione2 = new System.Windows.Forms.Button();
            this.azione3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(40, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "crea tabella log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.EnabledChanged += new System.EventHandler(this.button1_EnabledChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(666, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accesso";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(6, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 22);
            this.button3.TabIndex = 3;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Log In";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.EnabledChanged += new System.EventHandler(this.button2_EnabledChanged);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(508, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(508, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 5;
            // 
            // azione1
            // 
            this.azione1.Enabled = false;
            this.azione1.Location = new System.Drawing.Point(62, 223);
            this.azione1.Name = "azione1";
            this.azione1.Size = new System.Drawing.Size(143, 36);
            this.azione1.TabIndex = 6;
            this.azione1.Text = "ciao";
            this.azione1.UseVisualStyleBackColor = true;
            this.azione1.Click += new System.EventHandler(this.azione1_Click);
            // 
            // azione2
            // 
            this.azione2.Enabled = false;
            this.azione2.Location = new System.Drawing.Point(294, 223);
            this.azione2.Name = "azione2";
            this.azione2.Size = new System.Drawing.Size(143, 36);
            this.azione2.TabIndex = 7;
            this.azione2.Text = "Numero randomico 1-2000";
            this.azione2.UseVisualStyleBackColor = true;
            this.azione2.Click += new System.EventHandler(this.azione2_Click);
            // 
            // azione3
            // 
            this.azione3.Enabled = false;
            this.azione3.Location = new System.Drawing.Point(508, 223);
            this.azione3.Name = "azione3";
            this.azione3.Size = new System.Drawing.Size(143, 36);
            this.azione3.TabIndex = 8;
            this.azione3.Text = ":)";
            this.azione3.UseVisualStyleBackColor = true;
            this.azione3.Click += new System.EventHandler(this.azione3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.azione3);
            this.Controls.Add(this.azione2);
            this.Controls.Add(this.azione1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button azione1;
        private System.Windows.Forms.Button azione2;
        private System.Windows.Forms.Button azione3;
    }
}

