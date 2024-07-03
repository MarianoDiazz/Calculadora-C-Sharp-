namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        // Instancias de las clases
        Clases.Suma obj = new Clases.Suma();
        Clases.Resta obj2 = new Clases.Resta();
        Clases.Multiplicacion obj3 = new Clases.Multiplicacion();
        Clases.Division obj4 = new Clases.Division();

        private void button6_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "8";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "6";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtScreen.Text, out primero))
            {
                operador = "+";
                txtScreen.Clear();
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtScreen.Text, out primero))
            {
                operador = "-";
                txtScreen.Clear();
            }
            else
            {
                txtScreen.Text = "-";
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtScreen.Text, out primero))
            {
                operador = "*";
                txtScreen.Clear();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtScreen.Text, out primero))
            {
                operador = "/";
                txtScreen.Clear();
            }
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtScreen.Text, out double numero))
            {
                numero = -numero;
                txtScreen.Text = numero.ToString();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtScreen.Text, out segundo))
            {
                double resultado = 0;

                switch (operador)
                {
                    case "+":
                        resultado = obj.Sumar(primero, segundo);
                        break;
                    case "-":
                        resultado = obj2.Restar(primero, segundo);
                        break;
                    case "*":
                        resultado = obj3.Multiplicar(primero, segundo);
                        break;
                    case "/":
                        resultado = obj4.Dividir(primero, segundo);
                        break;
                }
                txtScreen.Text = resultado.ToString();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtScreen.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length == 1)
                txtScreen.Text = "";
            else
                txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);
        }

    }
}
