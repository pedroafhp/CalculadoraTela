using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTela
{
    public partial class Form1 : Form
    {
        Model modelo;
        public Form1()
        {
            InitializeComponent();
            modelo = new Model();
        }//Fim do Construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os Campos Numéricos";
            }
            else
            {
            int num1 = Convert.ToInt32(numeroUm.Text);
            int num2 = Convert.ToInt32(numeroDois.Text);
            resultado.Text = "" + modelo.Somar(num1,num2);
            }
        }//Fim do Botao Somar

        private void button5_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os Campos Numéricos";
            }
            else
            {
                numeroUm.Text = "";
                numeroDois.Text = "";
                resultado.Text = "";
            }
        }//Fim do Botao Limpar

        private void numeroUm_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Imput de Numero Um

        private void numeroDois_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Imput de Numero Dois

        private void subtrair_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os Campos Numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                resultado.Text = "" + modelo.Subtrair(num1, num2);
            }
        }//Fim do Botao Subtrair

        private void multiplicar_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os Campos Numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                resultado.Text = "" + modelo.Multiplicar(num1, num2);
            }
        }//Fim do Botao Multiplicar

        private void dividir_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os Campos Numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                if (modelo.Dividir(num1, num2) == -1)
                {
                    resultado.Text = "Impossível Dividir";
                }
                else
                {
                    resultado.Text = "" + modelo.Dividir(num1, num2);
                }
            }
        }//Fim do Botao Dividir

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Resultrado
    }//Fim da Classe
}//Fim do Projeto
