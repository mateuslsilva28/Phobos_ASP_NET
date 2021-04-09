using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phobos.DAL;
using Phobos.DTO;

namespace Phobos.DLL
{
    public class UsuarioBLL
    {
        UsuarioDAL usuarioDAL = new UsuarioDAL();
        public void CadastrarBLL(UsuarioDTO usuarioDTO)
        {
            usuarioDAL.Cadastrar(usuarioDTO);
        }
        public void EditarBLL(UsuarioDTO usuarioDTO)
        {
            usuarioDAL.Editar(usuarioDTO);
        }
        public void DeletarBLL(int IdUsuario)
        {
            usuarioDAL.Deletar(IdUsuario);
        }
        public UsuarioDTO Buscar(int IdUsuario)
        {
            return usuarioDAL.Buscar(IdUsuario);
        }
        public List<UsuarioDTO> Listar()
        {
            return usuarioDAL.Listar();
        }
        public UsuarioDTO Autentica(string login, string senha)
        {
            UsuarioDTO obj = usuarioDAL.Autentica(login, senha);
            if (obj != null) return obj;
            else throw new Exception("Deu merda mano");
        }
    }
}
