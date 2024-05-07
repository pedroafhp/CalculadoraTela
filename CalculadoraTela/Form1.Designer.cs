namespace CalculadoraTela
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeroUm = new System.Windows.Forms.TextBox();
            this.numeroDois = new System.Windows.Forms.TextBox();
            this.somar = new System.Windows.Forms.Button();
            this.subtrair = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero:";
            // 
            // numeroUm
            // 
            this.numeroUm.Location = new System.Drawing.Point(153, 110);
            this.numeroUm.Name = "numeroUm";
            this.numeroUm.Size = new System.Drawing.Size(286, 38);
            this.numeroUm.TabIndex = 3;
            this.numeroUm.TextChanged += new System.EventHandler(this.numeroUm_TextChanged);
            // 
            // numeroDois
            // 
            this.numeroDois.Location = new System.Drawing.Point(152, 171);
            this.numeroDois.Name = "numeroDois";
            this.numeroDois.Size = new System.Drawing.Size(287, 38);
            this.numeroDois.TabIndex = 4;
            this.numeroDois.TextChanged += new System.EventHandler(this.numeroDois_TextChanged);
            // 
            // somar
            // 
            this.somar.BackColor = System.Drawing.Color.Black;
            this.somar.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somar.ForeColor = System.Drawing.SystemColors.Window;
            this.somar.Location = new System.Drawing.Point(15, 249);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(168, 56);
            this.somar.TabIndex = 5;
            this.somar.Text = "Somar";
            this.somar.UseVisualStyleBackColor = false;
            this.somar.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtrair
            // 
            this.subtrair.BackColor = System.Drawing.Color.Black;
            this.subtrair.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtrair.ForeColor = System.Drawing.SystemColors.Window;
            this.subtrair.Location = new System.Drawing.Point(197, 249);
            this.subtrair.Name = "subtrair";
            this.subtrair.Size = new System.Drawing.Size(172, 56);
            this.subtrair.TabIndex = 6;
            this.subtrair.Text = "Subtrair";
            this.subtrair.UseVisualStyleBackColor = false;
            this.subtrair.Click += new System.EventHandler(this.subtrair_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.BackColor = System.Drawing.Color.Black;
            this.multiplicar.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.ForeColor = System.Drawing.SystemColors.Window;
            this.multiplicar.Location = new System.Drawing.Point(15, 311);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(168, 58);
            this.multiplicar.TabIndex = 7;
            this.multiplicar.Text = "Multiplicar";
            this.multiplicar.UseVisualStyleBackColor = false;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // dividir
            // 
            this.dividir.BackColor = System.Drawing.Color.Black;
            this.dividir.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.ForeColor = System.Drawing.SystemColors.Window;
            this.dividir.Location = new System.Drawing.Point(197, 311);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(172, 58);
            this.dividir.TabIndex = 8;
            this.dividir.Text = "Dividir";
            this.dividir.UseVisualStyleBackColor = false;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // limpar
            // 
            this.limpar.BackColor = System.Drawing.Color.Black;
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.ForeColor = System.Drawing.SystemColors.Window;
            this.limpar.Location = new System.Drawing.Point(375, 249);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(64, 120);
            this.limpar.TabIndex = 9;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = false;
            this.limpar.Click += new System.EventHandler(this.button5_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(15, 383);
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.Size = new System.Drawing.Size(424, 38);
            this.resultado.TabIndex = 10;
            this.resultado.TextChanged += new System.EventHandler(this.resultado_TextChanged);
            // 
            // Form1
            // 
            this.AccessibleDescription = "Software destinado a realizar calculos basicos";
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(470, 522);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.subtrair);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.numeroDois);
            this.Controls.Add(this.numeroUm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.MaximumSize = new System.Drawing.Size(486, 561);
            this.MinimumSize = new System.Drawing.Size(486, 561);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numeroUm;
        private System.Windows.Forms.TextBox numeroDois;
        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.Button subtrair;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.TextBox resultado;
    }
}

