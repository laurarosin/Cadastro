using CadastroVeículo.Model;
using CadastroVeículo.View;
using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroVeículo
{
    public partial class Form : System.Windows.Forms.Form
    {
        Veículo vi;
        Carro ca;
        public Form()
        {

            InitializeComponent();
        }

       public void btnIncluir_Click(object sender, EventArgs e)
        {
          
        }

        private void Form_Load(object sender, EventArgs e)
        {
            vi = new Veículo();

            limpaControles();
            carregarGrid("");
        }

        void limpaControles()
        {
            txtCódigo.Clear();
            txtCor.Clear();
            txtChassi.Clear();
            txtModelo.Clear();
            txtObs.Clear();  
        }

        void carregarGrid(string pesquisa)
        {
            vi = new Veículo()
            {
                obs = pesquisa
            };
         
        }
    }
}
