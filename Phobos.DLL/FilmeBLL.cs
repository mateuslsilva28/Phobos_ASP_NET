using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phobos.DAL;
using Phobos.DTO;

namespace Phobos.DLL
{
    public class FilmeBLL
    {
        FilmeDAL filmeDAL = new FilmeDAL();
        public void CadastrarBLL(FilmeDTO filmeDTO)
        {
            filmeDAL.Cadastrar(filmeDTO);
        }
        public void EditarBLL(FilmeDTO filmeDTO)
        {
            filmeDAL.Editar(filmeDTO);
        }
        public void DeletarBLL(int IdFilme)
        {
            filmeDAL.Deletar(IdFilme);
        }
        public FilmeDTO Buscar(int IdFilme)
        {
            return filmeDAL.Buscar(IdFilme);
        }
        public List<FilmeDTO> Listar()
        {
            return filmeDAL.Listar();
        }
    }
}
