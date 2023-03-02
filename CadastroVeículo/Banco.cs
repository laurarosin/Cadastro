using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CadastroVeículo
{
    public class Banco
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;


        public static MySqlDataAdapter Adaptador;
    }
 

}
