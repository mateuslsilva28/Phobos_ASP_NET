using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Phobos.DLL;

namespace Phobos.UI.Pages
{
    public partial class ConsultaFilme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FilmeBLL filmeBLL = new FilmeBLL();
            dgvUsuario.DataSource = filmeBLL.Listar();
            dgvUsuario.DataBind();
        }
    }
}