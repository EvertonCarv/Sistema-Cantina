using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public partial class Form1 : Form
    {
        String[] produtos = new string[10];
        String[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;
         /*Declaração de 3 arrays para armazenar 10 produtos, e seus respectivos códigos e valores.
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 3)
          
            /*Inicia com a condição, se o usuário digitar um código com 5 caracteres (length),
             * esse código é adicionado ao listBox.
             * A propriedade length retorna a quantidade de caracteres.
             * Após o conteúdo ser enviado para o listBox, o textbox será limpo e o Focus posiciona
             * o cursor para o TextBox para uma nova digitação.
             */
            {
                int indice = 0;
                for (int produto = 1; produto < codigo.Length; produto++)
                // Faça enquanto o prod for menor igual a qtde de itens do array
                {
                    if (txtCodigo.Text == codigo[produto])
                    {
                        indice = produto;
                    }
                }
                if (indice == 0)
                {
                    MessageBox.Show("Produto não encontrado");
                    /*Condição, se foi encontrado o produto ele retorna as informações de acordo
                     * com o índice
                     * Caso não encontre aparecerá a mensagem, Produto não encontrado*/
                }
                else 
                {
                    lstCaixa.Items.Add(txtCodigo.Text + "--" + produtos[indice] + "-- R$" + valor[indice]);
                    /*Conteúdo adicionado no ListBox, concatena (+) as informações (código/nome/valor)*/
                    soma = soma + valor[indice];
                    label3.Text = ("Valor Total R$ " + soma);
                    picImagem.ImageLocation = "Imagens\\" + codigo[indice] + ".jpg";
                    txtCodigo.Text = "";
                    txtCodigo.Focus();
                    /*localização da imagem que deve ser colocada em uma pasta em c: em uma pasta imagens
                     * o textbox será limpo e o Focus posiciona o cursor para o TextBox para uma nova digitação*/
                }
            }
           
            
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarArray();
            soma = 0;
        }
        /*Ao entrar no Form Load será chamado o método*/
        private void carregarArray()
        //Criação do Método para ser chamado quando necessário, isso evita repetir várias vezes o mesmo código
        {
            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";

            produtos[1] = "Pastel";
            produtos[2] = "Coxinha";
            produtos[3] = "Hot Dog";
            produtos[4] = "Chocolate";
            produtos[5] = "Suco";

            valor[1] = 6.00;
            valor[2] = 5.00;
            valor[3] = 12.00;
            valor[4] = 3.50;
            valor[5] = 8.00;
            //Código, Produtos e Valores ref. os arrays que foram declarados
        }
    }
}
