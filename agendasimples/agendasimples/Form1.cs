using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendasimples
{
    public partial class Form1 : Form
    {
        private contato[]listaDeContatos = new contato[0];
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sobrenome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {
            contato objContato = new contato(txtNome.Text, txtSobrenome.Text, txtEmail.text, txtTelefone.Text);
            lstContatos.Items.Add(objContato.ToString();
        }
        private void Escrever (contato contato)
        {
            StreamWriter escritorDeArquivos = new StreamWriter("contato.txt");
            escritorDeArquivos.WriteLine(listaDeContatos.Length + 1);
            escritorDeArquivos.WriteLine(contato.PrimeiroNome);
            escritorDeArquivos.WriteLine(contato.Sobrenome);
            escritorDeArquivos.WriteLine(contato.Telefone);
            escritorDeArquivos.WriteLine(contato.Email);

            for(int i = 0; i < listaDeContatos.Length;i ++) 
            {
              
                escritorDeArquivos.WriteLine(contato.PrimeiroNome);
                escritorDeArquivos.WriteLine(contato.Sobrenome);
                escritorDeArquivos.WriteLine(contato.Telefone);
                escritorDeArquivos.WriteLine(contato.Email);
            }
            escritorDeArquivos.Close();
        }
        private void Ler()
        {
            StreamReader LeitorDeArquivos = new StreamReader("Contatos.txt");
            listaDeContatos = new contato[Convert.ToInt32(LeitorDeArquivos.ReadLine())];
            for (int i = 0; i < listaDeContatos.Length; i ++) 
            {
                listaDeContatos[i] = new contato();
                listaDeContatos[i].PrimeiroNome= LeitorDeArquivos.ReadLine();
                listaDeContatos[i].Sobrenome = LeitorDeArquivos.ReadLine();
                listaDeContatos[i].Telefone = LeitorDeArquivos.ReadLine();
                listaDeContatos[i].Email = LeitorDeArquivos.ReadLine();
            }

        }
    }
}
