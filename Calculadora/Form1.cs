using System;
using System.Data;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double resultado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            tela.Text += " x ";
            
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            tela.Text += " / ";
            
        }

        private void soma_Click(object sender, EventArgs e)
        {
            tela.Text += " + ";
            
        }
        private void subtracao_Click(object sender, EventArgs e)
        {
            tela.Text += " - ";
           
        }

        private void num1_Click(object sender, EventArgs e)
        {
            tela.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            tela.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            tela.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            tela.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            tela.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            tela.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            tela.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            tela.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            tela.Text += "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            tela.Text += "0";        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tela.Text += ",";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            tela.Text = "";
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            try
            {
                string calculo = tela.Text.Replace('x', '*').Replace(',', '.'); 

                if (calculo.Contains(" / 0"))
                {
                    Erro();
                    return;
                }
                
                resultado = Convert.ToDouble(new DataTable().Compute(calculo, null));
                tela.Text = resultado.ToString();

                
            }
            catch
            {
                Erro();
            }
        }

        private void Erro()
        {
            tela.Text = "Erro";
            Timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            tela.Text = "";
            Timer.Stop();
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tela.Text))
            {
                tela.Text = tela.Text.Remove(tela.Text.Length - 1);
                return;
            }
                
        }
    }
}
