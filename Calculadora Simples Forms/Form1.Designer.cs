namespace Calculadora_Simples_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            campo1 = new TextBox();
            campo2 = new TextBox();
            soma = new Button();
            subtracao = new Button();
            multiplicacao = new Button();
            divisao = new Button();
            operador = new Label();
            resultado = new Label();
            SuspendLayout();
            // 
            // campo1
            // 
            campo1.Location = new Point(12, 22);
            campo1.Name = "campo1";
            campo1.Size = new Size(92, 23);
            campo1.TabIndex = 0;
            // 
            // campo2
            // 
            campo2.Location = new Point(142, 22);
            campo2.Name = "campo2";
            campo2.Size = new Size(90, 23);
            campo2.TabIndex = 1;
            // 
            // soma
            // 
            soma.Location = new Point(12, 82);
            soma.Name = "soma";
            soma.Size = new Size(101, 23);
            soma.TabIndex = 2;
            soma.Text = "Soma";
            soma.UseVisualStyleBackColor = true;
            soma.Click += soma_Click;
            // 
            // subtracao
            // 
            subtracao.Location = new Point(131, 82);
            subtracao.Name = "subtracao";
            subtracao.Size = new Size(101, 23);
            subtracao.TabIndex = 3;
            subtracao.Text = "Subtração";
            subtracao.UseVisualStyleBackColor = true;
            subtracao.Click += subtracao_Click;
            // 
            // multiplicacao
            // 
            multiplicacao.Location = new Point(12, 111);
            multiplicacao.Name = "multiplicacao";
            multiplicacao.Size = new Size(101, 23);
            multiplicacao.TabIndex = 4;
            multiplicacao.Text = "Multiplicação";
            multiplicacao.UseVisualStyleBackColor = true;
            multiplicacao.Click += multiplicacao_Click;
            // 
            // divisao
            // 
            divisao.Location = new Point(131, 111);
            divisao.Name = "divisao";
            divisao.Size = new Size(101, 23);
            divisao.TabIndex = 5;
            divisao.Text = "Divisão";
            divisao.UseVisualStyleBackColor = true;
            divisao.Click += divisao_Click;
            // 
            // operador
            // 
            operador.Location = new Point(105, 16);
            operador.Name = "operador";
            operador.Size = new Size(37, 35);
            operador.TabIndex = 6;
            operador.Text = "?";
            operador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultado
            // 
            resultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultado.Location = new Point(12, 48);
            resultado.Name = "resultado";
            resultado.Size = new Size(220, 31);
            resultado.TabIndex = 7;
            resultado.Text = "Resultado";
            resultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 142);
            Controls.Add(resultado);
            Controls.Add(operador);
            Controls.Add(divisao);
            Controls.Add(multiplicacao);
            Controls.Add(subtracao);
            Controls.Add(soma);
            Controls.Add(campo2);
            Controls.Add(campo1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox campo1;
        private TextBox campo2;
        private Button soma;
        private Button subtracao;
        private Button multiplicacao;
        private Button divisao;
        private Label operador;
        private Label resultado;
    }
}
