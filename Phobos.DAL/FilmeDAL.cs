using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phobos.DTO;
using System.Data.SqlClient;

namespace Phobos.DAL
{
    public class FilmeDAL : Conexao
    {
        public void Cadastrar(FilmeDTO filmeDTO)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("INSERT INTO Filme (TituloFilme, GeneroFilme, ProdutoraFillme, UrlImgFilme, ClassificacaoFilme) VALUES (@Titulo, @Genero, @Produtora, @Img, @Classificacao)", Conn);
                Cmd.Parameters.AddWithValue("@Titulo", filmeDTO.Titulo);
                Cmd.Parameters.AddWithValue("@Genero", filmeDTO.Genero);
                Cmd.Parameters.AddWithValue("@Produtora", filmeDTO.Produtora);
                Cmd.Parameters.AddWithValue("@Img", filmeDTO.UrlImg);
                Cmd.Parameters.AddWithValue("@Classificacao", Convert.ToInt32(filmeDTO.Classificacao));
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao cadastrar filme "+ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        public void Editar(FilmeDTO filmeDTO)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("UPDATE FILME SET TituloFilme = @Titulo, GeneroFilme = @Genero, ProdutoraFilme = @Produtora, UrlImgFilme = @Img, ClassificacaoFilme = @Classificacao WHERE IdFilme = @Id", Conn);
                Cmd.Parameters.AddWithValue("@Id", filmeDTO.Id);
                Cmd.Parameters.AddWithValue("@Titulo", filmeDTO.Titulo);
                Cmd.Parameters.AddWithValue("@Genero", filmeDTO.Genero);
                Cmd.Parameters.AddWithValue("@Produtora", filmeDTO.Produtora);
                Cmd.Parameters.AddWithValue("@Img", filmeDTO.UrlImg);
                Cmd.Parameters.AddWithValue("@Classificacao", Convert.ToInt32(filmeDTO.Classificacao));
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao editar filme " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        public void Deletar(int idFilme)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("DELETE Filme WHERE IdFilme = @Id", Conn);
                Cmd.Parameters.AddWithValue("@Id", idFilme);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao deletar filme " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        public FilmeDTO Buscar(int idFilme)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT IdFilme, TituloFilme, GeneroFilme, ProdutoraFilme, UrlImgFilme, DescricaoClassificacao FROM Filme as F JOIN Classificacao as C ON F.ClassificacaoFilme = C.IdClassificacao WHERE IdFilme = @Id", Conn);
                Cmd.Parameters.AddWithValue("@Id", idFilme);
                Dr = Cmd.ExecuteReader();

                FilmeDTO filmeDTO = null;
                
                if (Dr.Read())
                {
                    filmeDTO.Id = Convert.ToInt32(Dr["IdFilme"]);
                    filmeDTO.Titulo = Convert.ToString(Dr["TituloFilme"]);
                    filmeDTO.Genero = Convert.ToString(Dr["GeneroFilme"]);
                    filmeDTO.Produtora = Convert.ToString(Dr["ProdutoraFilme"]);
                    filmeDTO.Classificacao = Convert.ToString(Dr["DescricaoClassificacao"]);
                }
                return filmeDTO;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar filme " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        public List<FilmeDTO> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT IdFilme, TituloFilme, GeneroFilme, ProdutoraFillme, UrlImgFilme, DescricaoClassificacao FROM Filme as F JOIN Classificacao as C ON F.ClassificacaoFilme = C.IdClassificacao", Conn);
                Dr = Cmd.ExecuteReader();

                List<FilmeDTO> lista = new List<FilmeDTO>();
                FilmeDTO filmeDTO = null;

                while (Dr.Read())
                {
                    filmeDTO = new FilmeDTO();
                    filmeDTO.Id = Convert.ToInt32(Dr["IdFilme"]);
                    filmeDTO.Titulo = Convert.ToString(Dr["TituloFilme"]);
                    filmeDTO.Genero = Convert.ToString(Dr["GeneroFilme"]);
                    filmeDTO.Produtora = Convert.ToString(Dr["ProdutoraFillme"]);
                    filmeDTO.UrlImg = Convert.ToString(Dr["UrlImgFilme"]);
                    filmeDTO.Classificacao = Convert.ToString(Dr["DescricaoClassificacao"]);
                    lista.Add(filmeDTO);
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar filme " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
