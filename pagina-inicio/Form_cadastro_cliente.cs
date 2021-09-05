using System;
using System.Windows.Forms;

namespace pagina_inicio
{

    public partial class Form_cadastro_cliente : Form

    {
        string tipo_pessoa, sexo;
        public Form_cadastro_cliente()
        {
            InitializeComponent();
        }

        public void Form_cadastro_cliente_Load(object sender, EventArgs e)
        {

        }

        public void btn_salvar_Click(object sender, EventArgs e)
        {
            cadastro cliente = new cadastro(tipo_pessoa, cod_cliente.Text, cpf.Text, cnpj.Text, nome.Text, sexo, sobrenome.Text, data_nasc.Text, EMAIL.Text, rua.Text, num.Text, cep.Text,
                complemento.Text, bairro.Text, cidade.Text, estado.Text, limite_cred.Text, informacoes.Text);

            limpardados();

        }

        public void limpardados()
        {
            cod_cliente.Clear();
            cpf.Clear();
            cnpj.Clear();
            nome.Clear();
            sobrenome.Clear();
            data_nasc.Clear();
            EMAIL.Clear();
            rua.Clear();
            num.Clear();
            cep.Clear();
            complemento.Clear();
            bairro.Clear();
            cidade.Clear();
            estado.Clear();
            limite_cred.Clear();
            informacoes.Clear();
            checkboxsexo_m.Checked = false;
            checkboxsexo_f.Checked = false;
            pessoa_fisica.Checked = false;
            pessoa_juridica.Checked = false;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpardados();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pessoa_fisica_CheckedChanged(object sender, EventArgs e)
        {
            tipo_pessoa = "Pessoa Fisica";
        }

        private void checkboxsexo_f_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Feminino";
        }

        private void tb_cep_TextChanged(object sender, EventArgs e)
        {

        }

        private void sobrenome_Click(object sender, EventArgs e)
        {

        }

        private void tb_complemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void cidade_Click(object sender, EventArgs e)
        {

        }

        private void pessoa_juridica_CheckedChanged(object sender, EventArgs e)
        {
            tipo_pessoa = "Pessoa Jurica";
        }

        private void checkboxsexo_m_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Masculino";
        }
    }
}
