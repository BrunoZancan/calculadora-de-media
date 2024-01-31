namespace CalcMedia
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.txtTitulo = new System.Windows.Forms.Label();
            this.nota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.Label();
            this.nota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.Label();
            this.nota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.Label();
            this.nota4 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtMedia = new System.Windows.Forms.Label();
            this.media = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.Label();
            this.btnGerarNumsAleatorios = new System.Windows.Forms.Button();
            this.btnCompletarComNums = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(130, 19);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(160, 20);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Calculadora de Média";
            // 
            // nota1
            // 
            this.nota1.Location = new System.Drawing.Point(94, 60);
            this.nota1.MaxLength = 10;
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(100, 20);
            this.nota1.TabIndex = 0;
            // 
            // txtNota2
            // 
            this.txtNota2.AutoSize = true;
            this.txtNota2.Location = new System.Drawing.Point(43, 99);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(45, 13);
            this.txtNota2.TabIndex = 1;
            this.txtNota2.Text = "Nota 02";
            // 
            // nota2
            // 
            this.nota2.Location = new System.Drawing.Point(94, 97);
            this.nota2.MaxLength = 10;
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(100, 20);
            this.nota2.TabIndex = 1;
            // 
            // txtNota3
            // 
            this.txtNota3.AutoSize = true;
            this.txtNota3.Location = new System.Drawing.Point(43, 136);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(45, 13);
            this.txtNota3.TabIndex = 1;
            this.txtNota3.Text = "Nota 03";
            // 
            // nota3
            // 
            this.nota3.Location = new System.Drawing.Point(94, 134);
            this.nota3.MaxLength = 10;
            this.nota3.Name = "nota3";
            this.nota3.Size = new System.Drawing.Size(100, 20);
            this.nota3.TabIndex = 2;
            // 
            // txtNota4
            // 
            this.txtNota4.AutoSize = true;
            this.txtNota4.Location = new System.Drawing.Point(43, 173);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(45, 13);
            this.txtNota4.TabIndex = 1;
            this.txtNota4.Text = "Nota 04";
            // 
            // nota4
            // 
            this.nota4.Location = new System.Drawing.Point(94, 171);
            this.nota4.MaxLength = 10;
            this.nota4.Name = "nota4";
            this.nota4.Size = new System.Drawing.Size(100, 20);
            this.nota4.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcular.Location = new System.Drawing.Point(272, 57);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(96, 28);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Location = new System.Drawing.Point(272, 168);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 28);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtMedia
            // 
            this.txtMedia.AutoSize = true;
            this.txtMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia.Location = new System.Drawing.Point(265, 102);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(113, 15);
            this.txtMedia.TabIndex = 5;
            this.txtMedia.Text = "A média do aluno é";
            // 
            // media
            // 
            this.media.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.media.AutoEllipsis = true;
            this.media.AutoSize = true;
            this.media.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.media.Location = new System.Drawing.Point(283, 126);
            this.media.Margin = new System.Windows.Forms.Padding(0);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(62, 21);
            this.media.TabIndex = 6;
            this.media.Text = "....";
            this.media.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNota1
            // 
            this.txtNota1.AutoSize = true;
            this.txtNota1.Location = new System.Drawing.Point(43, 62);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(45, 13);
            this.txtNota1.TabIndex = 1;
            this.txtNota1.Text = "Nota 01";
            // 
            // btnGerarNumsAleatorios
            // 
            this.btnGerarNumsAleatorios.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarNumsAleatorios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGerarNumsAleatorios.Location = new System.Drawing.Point(35, 223);
            this.btnGerarNumsAleatorios.Margin = new System.Windows.Forms.Padding(0);
            this.btnGerarNumsAleatorios.Name = "btnGerarNumsAleatorios";
            this.btnGerarNumsAleatorios.Size = new System.Drawing.Size(159, 25);
            this.btnGerarNumsAleatorios.TabIndex = 6;
            this.btnGerarNumsAleatorios.Text = "Gerar Números Aleatórios";
            this.btnGerarNumsAleatorios.UseVisualStyleBackColor = true;
            this.btnGerarNumsAleatorios.Click += new System.EventHandler(this.btnGerarNumsAleatorios_Click);
            // 
            // btnCompletarComNums
            // 
            this.btnCompletarComNums.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletarComNums.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCompletarComNums.Location = new System.Drawing.Point(219, 223);
            this.btnCompletarComNums.Margin = new System.Windows.Forms.Padding(0);
            this.btnCompletarComNums.Name = "btnCompletarComNums";
            this.btnCompletarComNums.Size = new System.Drawing.Size(159, 25);
            this.btnCompletarComNums.TabIndex = 7;
            this.btnCompletarComNums.Text = "Completar com Números";
            this.btnCompletarComNums.UseVisualStyleBackColor = true;
            this.btnCompletarComNums.Click += new System.EventHandler(this.btnCompletarComNums_Click);
            // 
            // Calculadora
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(415, 267);
            this.Controls.Add(this.btnCompletarComNums);
            this.Controls.Add(this.btnGerarNumsAleatorios);
            this.Controls.Add(this.media);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nota4);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.nota3);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.nota1);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.TextBox nota1;
        private System.Windows.Forms.Label txtNota2;
        private System.Windows.Forms.TextBox nota2;
        private System.Windows.Forms.Label txtNota3;
        private System.Windows.Forms.TextBox nota3;
        private System.Windows.Forms.Label txtNota4;
        private System.Windows.Forms.TextBox nota4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label txtMedia;
        private System.Windows.Forms.Label media;
        private System.Windows.Forms.Label txtNota1;
        private System.Windows.Forms.Button btnGerarNumsAleatorios;
        private System.Windows.Forms.Button btnCompletarComNums;
    }
}

