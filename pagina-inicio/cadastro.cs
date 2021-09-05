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
    public class cadastro
    {
        Conexao conexao = new Conexao();
        MySqlCommand execute = new MySqlCommand();
       

        public cadastro(string tipo_pessoa, string cod_cliente, string cpf, string cnpj, string nome, string sexo, string sobrenome, string data_nasc, string EMAIL, string rua, string num, string cep, string complemento, string bairro, string cidade, string estado, string limite_cred, string informacoes)
        {
            execute.CommandText = "INSERT INTO FORM_CADASTRO_CLIENTE (tipo_pessoa,cod_cliente,cpf,cnpj,nome,sexo,sobrenome,data_nasc,email,rua,num,cep,complemento,bairro,cidade,estado,limite_cred,informacoes)VALUES( '" + tipo_pessoa + "','" + cod_cliente + "','" + cpf + "','" + cnpj + "','" + nome + "', '" + sexo + "','" + sobrenome + "','" + data_nasc + "','" +EMAIL+ "', " +
                  "'" + rua + "','" + num + "','" + cep + "','" + complemento + "','" + bairro+ "','" + cidade+ "','" + estado+ "','" + limite_cred+ "','" + informacoes+ "')";
        
            try
            {
                execute.Connection = conexao.Conectar();                                               
                execute.ExecuteNonQuery();
                MessageBox.Show("CLIENTE CADASTRADO COM SUCESSO!");
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally           
            {
                conexao.Desconectar();
                execute = null;
            }

        }
    }
}


      


            

