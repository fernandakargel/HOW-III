using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pagina_inicio
{
    public partial class pag_inicio : Form
    {
        
        public pag_inicio()
        {
            InitializeComponent();
        }

        private void pag_inicio_Load_1(object sender, EventArgs e)
        {
            
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            Form_cadastro_cliente form_Cadastro_Cliente = new Form_cadastro_cliente();
            form_Cadastro_Cliente.ShowDialog();
        }

        private void btn_cadprod_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)

        {
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_conscliente_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_consestq_Click(object sender, EventArgs e)
        {

        }

        private void menu_novo_Click(object sender, EventArgs e)
        {

        }
    }
}