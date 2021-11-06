using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLogin
{
    public partial class Bem_Vindo : Form
    {
        public Bem_Vindo()
        {
            InitializeComponent();
        }

        private void txtcadlogin_Click(object sender, EventArgs e)
        {
            Form2 cadastro = new Form2();
            cadastro.Show();
        }

        private void txtajuda_Click(object sender, EventArgs e)
        {
            TelaAjuda ta = new TelaAjuda();
            ta.Show();
        }

        private void btn_retornolog_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            
        }
    }
}
