<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmLivros.aspx.cs" Inherits="POO3B10207.UI.FrmLivros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="./Style/global.css" rel="stylesheet" />
    <title>Formulário do Livro</title>
</head>
<body>
    <div class="container">
        <h1>Formulário do Livro</h1>
        <div role="alert" runat="server">
            <asp:Label CssClass="alert alert-danger" ID="messageError" runat="server" Visible="false" />
        </div>
        <div role="alert" runat="server">
            <asp:Label CssClass="alert alert-success" ID="messageSuccess" runat="server" Visible="false" />
        </div>
        <form id="form1" runat="server">
            <div class="form-group">
                <asp:Label runat="server" Text="Título:" for="txtTitulo" />
                <asp:TextBox ID="txtTitulo" runat="server" class="form-control" aria-describedby="emailAjuda" />
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Autor:" for="drpautor" />
                <asp:DropDownList runat="server" ID="drpautor" class="form-control" aria-describedby="emailAjuda" />
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Editora:" for="drpeditora" />
                <asp:DropDownList runat="server" ID="drpeditora"  class="form-control" aria-describedby="emailAjuda" />
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Data de Cadastro:" for="txtDataCadastro" />
                <asp:TextBox ID="txtDataCadastro" runat="server"  class="form-control" aria-describedby="emailAjuda" />
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Numero de paginas:" for="txtNumeroPaginas" />
                <asp:TextBox ID="txtNumeroPaginas" runat="server"  class="form-control" aria-describedby="emailAjuda" />
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Valor:" for="txtValor" />
                <asp:TextBox ID="txtValor" runat="server"  class="form-control" aria-describedby="emailAjuda" />
            </div>
            <div class="form-group">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click"   class="btn btn-success btn-block"/>
            </div>
            <asp:GridView ID="GridLivro" CssClass="table table-striped" runat="server" OnRowDeleting="GridLivro_RowDeleting" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="GridLivro_RowCancelingEdit" OnRowEditing="GridLivro_RowEditing" OnRowUpdating="GridLivro_RowUpdating">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowEditButton="True" headerText="Editar" />
                    <asp:CommandField ShowDeleteButton="True" headerText="Excluir" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </form>
    </div>

</body>
</html>
