using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_estoque.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";//tudo ok
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login_usuario, String senha_usuario)
        {
            //comando sql que verifica se tem email e senha no bd
            cmd.CommandText = "select * from usuario where login_usuario = @login and senha_usuario = @senha";
            cmd.Parameters.AddWithValue("@login", login_usuario);
            cmd.Parameters.AddWithValue("@senha", senha_usuario);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)//se foi encontrado
                {
                    tem = true; 
                }

                con.desconectar();
                dr.Close();

            }
            catch (SqlException)
            {

                this.mensagem = "Erro com o Banco de Dados";
            }
            return tem;
        }

        public String cadastrar(String nome_usuario, String registro_usuario, String setor_usuario, String login_usuario, String senha_usuario, String confsenha_usuario)
        {
            tem = false;
            //comando para inserir
            if (senha_usuario.Equals(confsenha_usuario))
            {
                cmd.CommandText = "insert into usuario (nome_usuario, registro_usuario, setor_usuario, login_usuario, senha_usuario) values (@nome,@registro,@setor,@login,@senha);";
         
                cmd.Parameters.AddWithValue("@nome", nome_usuario);
                cmd.Parameters.AddWithValue("@registro", registro_usuario);
                cmd.Parameters.AddWithValue("@setor", setor_usuario);
                cmd.Parameters.AddWithValue("@login", login_usuario);
                cmd.Parameters.AddWithValue("@senha", senha_usuario);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;

                }
                catch (SqlException)
                {

                    this.mensagem = "Registro já cadastrado!";
                }

            }
            else
            {
                this.mensagem = "Senhas não correspondem";
            }
            
            return mensagem;
        }
    }
        }
