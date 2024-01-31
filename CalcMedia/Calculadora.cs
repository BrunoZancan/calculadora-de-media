using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMedia
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e) // btn calcular
        {
            double soma, media, valor, numsVazio, numsErrados;
            soma = 0;
            numsVazio = 0;
            numsErrados = 0;

            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    controle.Text = controle.Text.ToString().Replace(".", ",");

                    try
                    {
                        valor = Convert.ToSingle(((TextBox)controle).Text);
                        soma += valor;
                    }

                    catch (FormatException)
                    {
                        if (controle.Text == "")
                        {
                            numsVazio++;
                        } else
                        {
                            numsErrados++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        numsErrados++;
                    }
                }
            }

            this.media.Text = "....";

            if (numsErrados >= 1)
            {
                MessageBox.Show("Digite um número válido!", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (numsVazio == 4)
            {
                MessageBox.Show("Você não digitou nenhum número!\nResultado é igual à 0", "Nenhum número digitado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                media = soma / (4 - numsVazio);
                this.Controls["media"].Text = String.Format("{0:F2}", media);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) // btn limpar
        {

            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }

                this.Controls["media"].Text = "....";
            }

            /*
            # Também dava para utilizar:
                nota1.Text = "";
                nota2.Text = "";
                nota3.Text = "";
                nota4.Text = "";
                media.Text = "....";
            */
        }

        private void btnGerarNumsAleatorios_Click(object sender, EventArgs e) // btn gerar numeros aleatorios
        {
            Random aleatorio = new Random();

            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    int numero = aleatorio.Next(0, 100);
                    ((TextBox)controle).Text = numero.ToString();
                }
            }
        }

        private void btnCompletarComNums_Click(object sender, EventArgs e) // btn completar com numeros aleatorios
        {
            Random aleatorio = new Random();

            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    if (controle.Text is "")
                    {
                        int numero = aleatorio.Next(0, 100);
                        ((TextBox)controle).Text = numero.ToString();
                    }
                }
            }
        }
    }
}
