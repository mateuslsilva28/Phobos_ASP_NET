using Phobos.DLL;
using Phobos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phobos.UI.Pages
{
    public partial class EditaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ResetarCaixas();
        }

        protected void ResetarCaixas()
        {
            txtNome.Enabled =
            txtCpf.Enabled =
            txtSenha.Enabled =
            txtDataNasc.Enabled =
            txtTipoUsuario.Enabled =
            pnlTipoUsuario.Visible =
            btnConfirmar.Enabled =
            btnEditar.Enabled =
            btnConfirmar.Visible =
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled =
            txtId.Enabled = true;
        }
        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            UsuarioDTO usuarioDTO = usuarioBLL.Buscar(Convert.ToInt32(txtId.Text));

            if(usuarioDTO != null)
            {
                txtNome.Text = usuarioDTO.Nome;
                txtCpf.Text = usuarioDTO.Cpf;
                txtSenha.Text = usuarioDTO.Senha;
                txtDataNasc.Text = usuarioDTO.DataNasc;
                txtTipoUsuario.Text = usuarioDTO.TipoUsuario;

                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
            }
            else
            {
                lblMensagem.Text = "Usuário não cadastrado";
            }
        }
        protected void Limpar()
        {
            txtId.Text =
            txtNome.Text =
            txtCpf.Text =
            txtSenha.Text =
            txtDataNasc.Text = String.Empty;
            rblTipo.ClearSelection();
            SetFocus(txtId);
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBLL.DeletarBLL(Convert.ToInt32(txtId.Text));
            Limpar();
            ResetarCaixas();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled =
            txtCpf.Enabled =
            txtSenha.Enabled =
            pnlTipoUsuario.Visible =
            btnConfirmar.Visible =
            btnConfirmar.Enabled =
            txtDataNasc.Enabled = true;
            txtTipoUsuario.Visible =
            lblTituloSumir.Visible = false;
            btnPesquisar.Enabled =
            txtId.Enabled = true;
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            UsuarioDTO usuarioDTO = new UsuarioDTO();
            usuarioDTO.Id = Convert.ToInt32(txtId.Text);
            usuarioDTO.Nome = txtNome.Text;
            usuarioDTO.Cpf = txtCpf.Text;
            usuarioDTO.Senha = txtSenha.Text;
            usuarioDTO.DataNasc = txtDataNasc.Text;
            usuarioDTO.TipoUsuario = rblTipo.SelectedValue;
            usuarioBLL.EditarBLL(usuarioDTO);
            Limpar();
            ResetarCaixas();
            lblMensagem.Text = "Usuário editado com sucesso";
        }
    }
}