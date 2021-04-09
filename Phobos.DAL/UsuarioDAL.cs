using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phobos.DTO;
using System.Data.SqlClient;

namespace Phobos.DAL
{
    public class UsuarioDAL : Conexao
    {
        public void Cadastrar(UsuarioDTO usuarioDTO)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("INSERT INTO USUARIO (NomeUsuario, CpfUsuario, SenhaUsuario, DataNascUsuario, TipoUsuario) VALUES (@Nome, @Cpf, @Senha, @Data, @Tipo)", Conn);
                Cmd.Parameters.AddWithValue("@Nome", usuarioDTO.Nome);
                Cmd.Parameters.AddWithValue("@Cpf", usuarioDTO.Cpf);
                Cmd.Parameters.AddWithValue("@Senha", usuarioDTO.Senha);
                Cmd.Parameters.AddWithValue("@Data", usuarioDTO.DataNasc);
                Cmd.Parameters.AddWithValue("@Tipo", usuarioDTO.TipoUsuario);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao cadastrar usuário "+ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Editar(UsuarioDTO usuarioDTO)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("UPDATE Usuario SET NomeUsuario = @Nome, CpfUsuario = @Cpf, SenhaUsuario = @Senha, DataNascUsuario = @Data, TipoUsuario = @Tipo WHERE IdUsuario = @Id", Conn);
                Cmd.Parameters.AddWithValue("@Nome", usuarioDTO.Nome);
                Cmd.Parameters.AddWithValue("@Cpf", usuarioDTO.Cpf);
                Cmd.Parameters.AddWithValue("@Senha", usuarioDTO.Senha);
                Cmd.Parameters.AddWithValue("@Data", usuarioDTO.DataNasc);
                Cmd.Parameters.AddWithValue("@Tipo", usuarioDTO.TipoUsuario);
                Cmd.Parameters.AddWithValue("@Id", usuarioDTO.Id);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao editar usuário "+ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        public void Deletar(int Id)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("DELETE FROM Usuario WHERE IdUsuario = @Id", Conn);
                Cmd.Parameters.AddWithValue("@Id", Id);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao deletar usuário "+ex.Message);
            }
            finally { 
                FecharConexao();
            }
        }
        public UsuarioDTO Buscar(int Id)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT NomeUsuario, CpfUsuario, SenhaUsuario, DataNascUsuario, DescricaoTipoUsuario FROM Usuario AS U JOIN TipoUsuario AS T ON U.TipoUsuario = T.IdTipoUsuario WHERE IdUsuario = @Id", Conn);

                Cmd.Parameters.AddWithValue("@Id", Id);
                Dr = Cmd.ExecuteReader();


                UsuarioDTO usuarioDTO = null;
                if (Dr.Read())
                {
                    usuarioDTO = new UsuarioDTO();
                    usuarioDTO.Nome = Convert.ToString(Dr["NomeUsuario"]);
                    usuarioDTO.Cpf = Convert.ToString(Dr["CpfUsuario"]);
                    usuarioDTO.Senha = Convert.ToString(Dr["SenhaUsuario"]);
                    usuarioDTO.DataNasc = Convert.ToString(Dr["DataNascUsuario"]);
                    usuarioDTO.TipoUsuario = Convert.ToString(Dr["DescricaoTipoUsuario"]);
                 }
                return usuarioDTO;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar usuário "+ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        public List<UsuarioDTO> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT IdUsuario, NomeUsuario, CpfUsuario, SenhaUsuario, DataNascUsuario, DescricaoTipoUsuario FROM Usuario AS U JOIN TipoUsuario AS T ON U.TipoUsuario = T.IdTipoUsuario", Conn);
                Dr = Cmd.ExecuteReader();

                List<UsuarioDTO> lista = new List<UsuarioDTO>();

                while (Dr.Read())
                {
                    UsuarioDTO usuarioDTO = new UsuarioDTO();
                    usuarioDTO.Id = Convert.ToInt32(Dr["IdUsuario"]);
                    usuarioDTO.Nome = Convert.ToString(Dr["NomeUsuario"]);
                    usuarioDTO.Cpf = Convert.ToString(Dr["CpfUsuario"]);
                    usuarioDTO.Senha = Convert.ToString(Dr["SenhaUsuario"]);
                    usuarioDTO.DataNasc = Convert.ToString(Dr["DataNascUsuario"]);
                    usuarioDTO.TipoUsuario = Convert.ToString(Dr["DescricaoTipoUsuario"]);
                    lista.Add(usuarioDTO);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar usuários "+ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        public UsuarioDTO Autentica(string usuario, string senha)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Usuario WHERE NomeUsuario = @User AND SenhaUsuario = @Senha", Conn);
                Cmd.Parameters.AddWithValue("@User", usuario);
                Cmd.Parameters.AddWithValue("@Senha", senha);
                Dr = Cmd.ExecuteReader();

                UsuarioDTO usuarioDTO = null;
                if (Dr.Read())
                {
                    usuarioDTO = new UsuarioDTO();
                    usuarioDTO.Id = Convert.ToInt32(Dr["IdUsuario"]);
                    usuarioDTO.Nome = Convert.ToString(Dr["NomeUsuario"]);
                    usuarioDTO.Cpf = Convert.ToString(Dr["CpfUsuario"]);
                    usuarioDTO.Senha = Convert.ToString(Dr["SenhaUsuario"]);
                    usuarioDTO.DataNasc = Convert.ToString(Dr["DataNascUsuario"]);
                    usuarioDTO.TipoUsuario = Convert.ToString(Dr["TipoUsuario"]);
                }
                return usuarioDTO;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao autenticar usuário "+ex.Message);
            }
            finally
            {
                FecharConexao();
            }

        }
    }
}
