namespace Calculadora
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
            this.components = new System.ComponentModel.Container();
            this.calculadora = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.soma = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.tela = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Deletar = new System.Windows.Forms.Button();
            this.calculadora.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculadora
            // 
            this.calculadora.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.calculadora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculadora.Controls.Add(this.Deletar);
            this.calculadora.Controls.Add(this.clear);
            this.calculadora.Controls.Add(this.num7);
            this.calculadora.Controls.Add(this.num4);
            this.calculadora.Controls.Add(this.num8);
            this.calculadora.Controls.Add(this.num5);
            this.calculadora.Controls.Add(this.button1);
            this.calculadora.Controls.Add(this.num0);
            this.calculadora.Controls.Add(this.num9);
            this.calculadora.Controls.Add(this.num6);
            this.calculadora.Controls.Add(this.multiplicacao);
            this.calculadora.Controls.Add(this.divisao);
            this.calculadora.Controls.Add(this.subtracao);
            this.calculadora.Controls.Add(this.soma);
            this.calculadora.Controls.Add(this.calcular);
            this.calculadora.Controls.Add(this.num3);
            this.calculadora.Controls.Add(this.num2);
            this.calculadora.Controls.Add(this.num1);
            this.calculadora.Controls.Add(this.tela);
            this.calculadora.Location = new System.Drawing.Point(236, 63);
            this.calculadora.Name = "calculadora";
            this.calculadora.Size = new System.Drawing.Size(339, 326);
            this.calculadora.TabIndex = 1;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Red;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(100, 272);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(144, 38);
            this.clear.TabIndex = 2;
            this.clear.Text = "Limpar";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.SystemColors.Info;
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(25, 228);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(69, 38);
            this.num7.TabIndex = 1;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.Info;
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(25, 184);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(69, 38);
            this.num4.TabIndex = 1;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.SystemColors.Info;
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(100, 228);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(69, 38);
            this.num8.TabIndex = 1;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.Info;
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(100, 184);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(69, 38);
            this.num5.TabIndex = 1;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(254, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = ",";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.SystemColors.Info;
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(25, 272);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(69, 38);
            this.num0.TabIndex = 1;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.SystemColors.Info;
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(175, 228);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(69, 38);
            this.num9.TabIndex = 1;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.Info;
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(175, 184);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(69, 38);
            this.num6.TabIndex = 1;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.BackColor = System.Drawing.SystemColors.Info;
            this.multiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacao.Location = new System.Drawing.Point(254, 272);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(58, 38);
            this.multiplicacao.TabIndex = 1;
            this.multiplicacao.Text = "x";
            this.multiplicacao.UseVisualStyleBackColor = false;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // divisao
            // 
            this.divisao.BackColor = System.Drawing.SystemColors.Info;
            this.divisao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisao.Location = new System.Drawing.Point(254, 228);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(58, 38);
            this.divisao.TabIndex = 1;
            this.divisao.Text = "/";
            this.divisao.UseVisualStyleBackColor = false;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // subtracao
            // 
            this.subtracao.BackColor = System.Drawing.SystemColors.Info;
            this.subtracao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtracao.Location = new System.Drawing.Point(254, 140);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(58, 38);
            this.subtracao.TabIndex = 1;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = false;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // soma
            // 
            this.soma.BackColor = System.Drawing.SystemColors.Info;
            this.soma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soma.Location = new System.Drawing.Point(254, 184);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(58, 38);
            this.soma.TabIndex = 1;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = false;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.Green;
            this.calcular.Cursor = System.Windows.Forms.Cursors.Default;
            this.calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.Location = new System.Drawing.Point(25, 96);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(69, 38);
            this.calcular.TabIndex = 1;
            this.calcular.Text = "=";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.Info;
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(175, 140);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(69, 38);
            this.num3.TabIndex = 1;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.Info;
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(100, 140);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(69, 38);
            this.num2.TabIndex = 1;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.Info;
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(25, 140);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(69, 38);
            this.num1.TabIndex = 1;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // tela
            // 
            this.tela.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tela.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tela.ForeColor = System.Drawing.SystemColors.Info;
            this.tela.Location = new System.Drawing.Point(17, 18);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(306, 57);
            this.tela.TabIndex = 0;
            this.tela.Text = " ";
            this.tela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Interval = 1500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Deletar
            // 
            this.Deletar.BackColor = System.Drawing.Color.Orange;
            this.Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletar.Location = new System.Drawing.Point(175, 96);
            this.Deletar.Name = "Deletar";
            this.Deletar.Size = new System.Drawing.Size(69, 38);
            this.Deletar.TabIndex = 3;
            this.Deletar.Text = "Del";
            this.Deletar.UseVisualStyleBackColor = false;
            this.Deletar.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculadora);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.calculadora.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel calculadora;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Label tela;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button Deletar;
    }
}

