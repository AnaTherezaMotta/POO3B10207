using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using POO3B10207.BLL;
using POO3B10207.DTO;

namespace POO3B10207.UI
{
    public partial class FrmLivros : System.Web.UI.Page
    {

        readonly tblAutorBLL autorBLL = new tblAutorBLL();
        readonly tblEditoraBLL editoraBLL = new tblEditoraBLL();

        readonly tblLivroBLL livroBLL = new tblLivroBLL();
        readonly tblLivroDTO livroDTO = new tblLivroDTO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                drpautor.DataSource = autorBLL.listarAutor();
                drpautor.DataTextField = "nome";
                drpautor.DataValueField = "idAutor";
                drpautor.DataBind();

                drpeditora.DataSource = editoraBLL.listarEditora();
                drpeditora.DataTextField = "nome";
                drpeditora.DataValueField = "idEditora";
                drpeditora.DataBind();

                renderizarGrid();
            }
        }

        public void renderizarGrid()
        {
            GridLivro.DataSource = livroBLL.listarLivro();
            GridLivro.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                livroDTO.IdAutor = int.Parse(drpautor.SelectedValue.ToString());
                livroDTO.IdEditora= int.Parse(drpeditora.SelectedValue.ToString());
                livroDTO.DataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                livroDTO.TituloLivro = txtTitulo.Text;
                livroDTO.NumeroPaginas = int.Parse(txtNumeroPaginas.Text);
                livroDTO.ValorLivro = double.Parse(txtValor.Text);

                livroBLL.criarLivro(livroDTO);

                messageError.Visible = false;

                renderizarGrid();
                messageSuccess.Visible = true;
                messageSuccess.Text = "Livro salvo com sucesso!!!";
            }
            catch (Exception error)
            {
                messageSuccess.Text = string.Empty;
                messageSuccess.Visible = false;
                messageError.Visible = true;
                messageError.Text = error.Message;
            }
        }

        protected void GridLivro_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                livroDTO.IdLivro = Convert.ToInt32(e.Values[0]);
                livroBLL.apagarLivro(livroDTO);

                messageSuccess.Visible = true;
                messageSuccess.Text = "Livro deletado com sucesso!";

                renderizarGrid();
            }
            catch (Exception ex)
            {
                messageError.Visible = true;
                messageError.Text = ex.Message;
            }
        }

        protected void GridLivro_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridLivro.EditIndex = e.NewEditIndex;
            renderizarGrid();
        }

        protected void GridLivro_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                livroDTO.IdLivro = int.Parse(e.NewValues[0].ToString());
                livroDTO.IdAutor = int.Parse(e.NewValues[1].ToString());
                livroDTO.IdEditora = int.Parse(e.NewValues[2].ToString());
                livroDTO.TituloLivro = e.NewValues[3].ToString();
                livroDTO.Data_cadastro = Convert.ToDateTime(e.NewValues[4]);
                livroDTO.NumeroPaginas = int.Parse(e.NewValues[5].ToString());
                livroDTO.ValorLivro = double.Parse(e.NewValues[6].ToString());

                livroBLL.atualizarLivro(livroDTO);

                GridLivro.EditIndex = -1;
                renderizarGrid();
            }
            catch (Exception ex)
            {
                messageError.Visible = true;
                messageError.Text = ex.Message;
            }
        }

        protected void GridLivro_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridLivro.EditIndex = -1;
            renderizarGrid();
        }
    }
}
