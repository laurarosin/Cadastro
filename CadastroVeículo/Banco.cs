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

    public static void AbrirConexao()
    {
        try
        {

           Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");

            Conexao = Open();


        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    public static void FecharConexao()
    {
        try
        {

            Conexao.Close();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}
