using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Phobos.DLL;
using Phobos.DTO;

namespace Phobos.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //pegando informação digitada pelo usuário
                string login = txtUsuario.Text;
                string senha = txtSenha.Text;

                //instanciando o objeto dto
                UsuarioDTO usuarioDTO = new UsuarioDTO();
                UsuarioBLL usuarioBLL = new UsuarioBLL();

                usuarioDTO = usuarioBLL.Autentica(login, senha);

                if (usuarioDTO != null)
                {
                    switch (usuarioDTO.TipoUsuario)
                    {
                        case "1":
                            Session["Usuario"] = txtUsuario.Text.Trim();
                            Response.Redirect("pages/indexADM.aspx");
                            break;
                        case "2":
                            Session["Usuario"] = txtUsuario.Text.Trim();
                            Response.Redirect("pages/indexUser.aspx");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                lblMensagem.Text = "Usuário não cadastrado" + ex.Message;
            }

        }
    }
}