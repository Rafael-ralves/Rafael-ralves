using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnCadastrarcadin_Click(object sender, EventArgs e)
        {
            string strConexao = @"Data Source=NOTEBOOK-PC\SQLRAFAEL;Initial Catalog=projetologin;Integrated Security=True";
            string query = "INSERT INTO Logins (nome, email, usuario, confirmarsenha, senha)"
  + "VALUES ('" + txtnamecadin.Text + "', '" + txtemailcadin.Text + "', '"
  + txtusuario.Text + "', '" + txtconfirmarsenha.Text + "', '" + txtsenha.Text + "') ";

            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(query, conexao);

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();

            conexao.Open();
            MessageBox.Show("Cadastro efetuado com sucesso");
            Close();

        }
    }
}
