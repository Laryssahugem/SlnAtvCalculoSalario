using System;

namespace PJtAtvCalculoSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal bruto, vt = 0, convenio = 0, imposto, resultado, liquido;

            bruto = decimal.Parse(textBruto.Text);


            if (CkbVt.Checked == true)
            {
                vt = bruto * 00.6m;

            }
            if (CkbConvenio.Checked == true)
            {
                convenio = bruto - 20;

            }
            if (bruto < 980)
            {
                imposto = bruto * 0.08m;

            }
            else if (bruto >= 980 && bruto <= 1449.99m)
            {
                imposto = bruto * 0.09m;
            }
            else if (bruto >= 1450 && bruto <= 2119.99m)
            {
                imposto = bruto * 0.10m;
            }
            else
            {
                imposto = bruto * 0.11m;
            } 
            resultado = vt - convenio - imposto;
            liquido = bruto - resultado;
            textLiquido.Text = resultado.ToString();
        }
    }
}