using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Phobos.DLL;
using Phobos.DTO;

namespace Phobos.UI.Pages
{
    public partial class CadastraUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Limpar()
        {
            txtNome.Text =
            txtCpf.Text =
            txtDataNasc.Text =
            txtSenha.Text = String.Empty;
            rblTipo.ClearSelection();
            SetFocus(txtNome);
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            UsuarioDTO usuarioDTO = new UsuarioDTO();
            usuarioDTO.Nome = txtNome.Text;
            usuarioDTO.Cpf = txtCpf.Text;
            usuarioDTO.Senha = txtSenha.Text;
            usuarioDTO.DataNasc = txtDataNasc.Text;
            usuarioDTO.TipoUsuario = rblTipo.SelectedValue;

            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBLL.CadastrarBLL(usuarioDTO);

            Limpar();
        }
    }
}