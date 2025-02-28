namespace Calculadora_Simples_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static float num1;
        public static float num2;

        public bool Validar()
        {
            if (campo1.Text == "" || campo2.Text == "")
            {
                resultado.Text = "Por favor, preencha todos os campos";
                operador.Text = ":(";
                return false;
            }
            return true;
        }
        public void converter(object sender, EventArgs e)
        {
            num1 = float.Parse(campo1.Text);
            num2 = float.Parse(campo2.Text);
        }
        private void soma_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            converter(sender, e);
            resultado.Text = $"{num1} // {num2}";
        }
    }
}
