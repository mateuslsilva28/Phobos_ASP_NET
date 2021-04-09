using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Phobos.DLL;
using Phobos.DTO;


namespace Phobos.UI.Pages
{
    public partial class CadastraFilme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Limpar()
        {
            txtTitulo.Text =
            txtGenero.Text =
            txtProdutora.Text = String.Empty;
            rblClassificacao.ClearSelection();
            SetFocus(txtTitulo);
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            FilmeDTO filmeDTO = new FilmeDTO();
            filmeDTO.Titulo = txtTitulo.Text;
            filmeDTO.Genero = txtGenero.Text;
            filmeDTO.Produtora = txtProdutora.Text;
            filmeDTO.Classificacao = rblClassificacao.SelectedValue;

            if (flp1.HasFile)
            {
                string str = flp1.FileName;
                flp1.PostedFile.SaveAs(Server.MapPath("~/Imagens" + "/" + str));
                string CaminhoImg = "~/Imagens" + "/" + str.ToString();
                filmeDTO.UrlImg = CaminhoImg;

                FilmeBLL filmeBLL = new FilmeBLL();
                filmeBLL.CadastrarBLL(filmeDTO);

                Limpar();
                lblMensagem.Text = "Filme " + filmeDTO.Titulo + " cadastrado com sucesso";
            }
            else
            {
                lblMensagem.Text = "Deu merda bro";
            }
        }
    }
}