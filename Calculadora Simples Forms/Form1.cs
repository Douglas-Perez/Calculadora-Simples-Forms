namespace Calculadora_Simples_Forms
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        public static float num1;
        public static float num2;

        public bool Validar()
        {
            bool valido = float.TryParse(campo1.Text, out num1);
            valido = valido && float.TryParse(campo2.Text, out num2);

            if (!valido)
            {
                resultado.Text = "Por favor, preencha todos os campos com valores válidos.";
                operador.Text = ":(";
                return valido;
            }
            return valido;
        }
        private void soma_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            resultado.Text = $"{num1 + num2}";
            operador.Text = "+";
        }
        private void subtracao_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            resultado.Text = $"{num1 - num2}";
            operador.Text = "-";
        }
        private void multiplicacao_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            resultado.Text = $"{num1 * num2}";
            operador.Text = "X";
        }
        private void divisao_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            if (num2 == 0)
            {
                resultado.Text = "Impossível dividir por zero.\nDigite outro valor para o denominador.";
                operador.Text = "???";
                return;
            }
            resultado.Text = $"{num1 / num2}";
            operador.Text = "/";
        }
    }
}
