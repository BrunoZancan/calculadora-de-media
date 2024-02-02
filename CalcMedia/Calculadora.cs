using System;
using System.Drawing;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace CalcMedia
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e) // botão de calcular
        {
            double soma = 0, media, valor, numsVazios = 0, numsErrados = 0; // Cria as variáveis necessárias

            foreach (Control controle in this.Controls) // Para cada objeto do formulário faça:
            {
                if (controle is TextBox) // Verifica se o campo é um TextBox
                {
                    controle.Text = controle.Text.ToString().Replace(".", ","); // Formata o texto do TextBox trocando ponto por vírgula, já que estamos no Brasil, utilizamos vírgula ao invés de ponto

                    try // Tente fazer isso:
                    {
                        valor = double.Parse(((TextBox)controle).Text); // O valor vai ser igual ao texto (string) que está no TextBox convertido para um número real (double). Não usei "Convert.ToSingle" porque dava muitos bugs
                        soma += valor; // Acrescenta o valor na variável soma
                    }

                    catch (Exception) // Se der algum erro, provavelmente FormatException (erro na hora de transformar um valor string em um valor double) faça:
                    {
                        if (controle.Text == "") // Verifica se é vazio:
                        {
                            numsVazios++; // Se o texto for vazio adicione +1 na variável de números vazios
                        }
                        else // Se não for vazio:
                        {
                            numsErrados++; // Adicione +1 na variável de números errados para depois mostrar um erro na tela
                        }
                    }
                }
            }

            this.media.Text = "...."; // Depois de fazer toda essa verificação, defino o texto da média como "...." para garantir e ter certeza que se der algum erro, os pontos continuarão lá, em vez de dar 0 ou algum bug do tipo

            if (numsErrados >= 1) // Se tiver algum número errado faça:
            {
                MessageBox.Show("Digite um número válido!", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Mensagem de alerta avisando que o número está inválido
            }

            else if (numsVazios == 4) // Se a pessoa apertar o botão de calcular sem ter digitado nada, faça:
            {
                MessageBox.Show("Você não digitou nenhum número!\nResultado é igual à 0", "Nenhum número digitado", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Mensagem de alerta avisando que a pessoa não digitou nenhum número
            }
            else // Se não ouver erros faça:
            {
                media = soma / (4 - numsVazios); // Atribuir a média do cálculo na variável "media", se a pessoa digitar apenas 2 números, será somado os 2 números e dividido por 2, fazendo assim a média aritmética

                var resultado = String.Format("{0:F2}", media); // Atribui na variável "resultado" a média formatada com 2 casas decimais (0,00)

                if (resultado.Length < 8) // Verifica se o resultado tem um tamanho menor que 8
                {
                    this.media.Font = new Font(this.media.Font.FontFamily, 16); // Se o tamanho for menor que 8, deixe a letra com tamanho 16
                }
                else if (resultado.Length < 11) // Verifica se o resultado tem um tamanho menor que 11 e maior que 8
                {
                    this.media.Font = new Font(this.media.Font.FontFamily, 15); // Se o tamanho for menor que 11 e maior que 8, deixe a letra com tamanho 15
                }
                else // Se não for nenhuma dessas opções:
                {
                    this.media.Font = new Font(this.media.Font.FontFamily, 14); // Deixe a letra com tamanho 14
                }

                this.media.Text = resultado; // Deixa o texto do campo chamado média igual a variável "resultado"
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) // botão de limpar
        {

            foreach (Control controle in this.Controls) // Para cada objeto do formulário faça:
            {
                if (controle is TextBox) // Verifica se o campo é um TextBox
                {
                    ((TextBox)controle).Text = ""; // Se for TextBox deixe o texto dele vazio
                }

                this.media.Text = "...."; // Deixa o texto da média com "...."
            }

            /*
            # Também dava para utilizar:
                nota1.Text = ""; // Deixa o texto da nota1 vazio
                nota2.Text = ""; // Deixa o texto da nota2 vazio
                nota3.Text = ""; // Deixa o texto da nota3 vazio
                nota4.Text = ""; // Deixa o texto da nota4 vazio
                media.Text = "...."; Deixa o texto da média com "...."
            */
        }

        private void btnGerarNumsAleatorios_Click(object sender, EventArgs e) // botão de gerar números aleatórios
        {
            Random aleatorio = new Random();

            foreach (Control controle in this.Controls) // Para cada objeto do formulário faça:
            {
                if (controle is TextBox) // Verifica se o campo é um TextBox
                {
                    int numero = aleatorio.Next(0, 100); // Se for TextBox, gera um número de 0 à 100 e guarda na variável "numero"
                    ((TextBox)controle).Text = numero.ToString(); // Depois o texto do TextBox será igual ao número que foi sorteado 
                }
            }
        }

        private void btnCompletarComNums_Click(object sender, EventArgs e) // botão de completar com números aleatórios
        {
            Random aleatorio = new Random();

            foreach (Control controle in this.Controls) // Para cada objeto do formulário faça:
            {
                if (controle is TextBox) // Verifica se o campo é um TextBox
                {
                    if (controle.Text is "") // Se for TextBox e o texto do TextBox for vazio faça:
                    {
                        int numero = aleatorio.Next(0, 100); // Gera um número de 0 à 100 e guarda na variável "numero"
                        ((TextBox)controle).Text = numero.ToString(); // Depois o texto do TextBox será igual ao número que foi sorteado
                    }
                }
            }
        }
    }
}
