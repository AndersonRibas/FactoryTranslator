namespace TraslaterBeta
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textoEntrada = new System.Windows.Forms.RichTextBox();
            this.textoSaida = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEntrada = new System.Windows.Forms.ComboBox();
            this.cbSaida = new System.Windows.Forms.ComboBox();
            this.btTraduz = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textoSaida);
            this.groupBox1.Controls.Add(this.textoEntrada);
            this.groupBox1.Location = new System.Drawing.Point(149, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSaida);
            this.groupBox2.Controls.Add(this.cbEntrada);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(149, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btLimpar);
            this.groupBox3.Controls.Add(this.btTraduz);
            this.groupBox3.Location = new System.Drawing.Point(366, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // textoEntrada
            // 
            this.textoEntrada.Location = new System.Drawing.Point(16, 35);
            this.textoEntrada.Name = "textoEntrada";
            this.textoEntrada.Size = new System.Drawing.Size(506, 107);
            this.textoEntrada.TabIndex = 0;
            this.textoEntrada.Text = "";
            this.textoEntrada.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // textoSaida
            // 
            this.textoSaida.Location = new System.Drawing.Point(16, 170);
            this.textoSaida.Name = "textoSaida";
            this.textoSaida.ReadOnly = true;
            this.textoSaida.Size = new System.Drawing.Size(506, 112);
            this.textoSaida.TabIndex = 1;
            this.textoSaida.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saída";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Saída";
            // 
            // cbEntrada
            // 
            this.cbEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntrada.FormattingEnabled = true;
            this.cbEntrada.Items.AddRange(new object[] {
            "de",
            "en",
            "pt"});
            this.cbEntrada.Location = new System.Drawing.Point(57, 30);
            this.cbEntrada.Name = "cbEntrada";
            this.cbEntrada.Size = new System.Drawing.Size(80, 21);
            this.cbEntrada.TabIndex = 4;
            this.cbEntrada.SelectedIndexChanged += new System.EventHandler(this.CbEntrada_SelectedIndexChanged);
            // 
            // cbSaida
            // 
            this.cbSaida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSaida.Items.AddRange(new object[] {
            "de",
            "en",
            "pt"});
            this.cbSaida.Location = new System.Drawing.Point(57, 63);
            this.cbSaida.Name = "cbSaida";
            this.cbSaida.Size = new System.Drawing.Size(80, 21);
            this.cbSaida.TabIndex = 5;
            // 
            // btTraduz
            // 
            this.btTraduz.Location = new System.Drawing.Point(6, 23);
            this.btTraduz.Name = "btTraduz";
            this.btTraduz.Size = new System.Drawing.Size(308, 33);
            this.btTraduz.TabIndex = 0;
            this.btTraduz.Text = "Traduzir";
            this.btTraduz.UseVisualStyleBackColor = true;
            this.btTraduz.Click += new System.EventHandler(this.BtTraduz_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(6, 61);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(308, 33);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "Limpar Consulta";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.BtLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox textoSaida;
        private System.Windows.Forms.RichTextBox textoEntrada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSaida;
        private System.Windows.Forms.ComboBox cbEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btTraduz;
    }
}

