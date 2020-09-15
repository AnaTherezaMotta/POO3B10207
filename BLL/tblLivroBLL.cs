using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using POO3B102207.DAL;
using POO3B10207.DTO;

namespace POO3B10207.BLL
{
    public class tblLivroBLL
    {
        private DALMysql daoBanco = new DALMysql();
        public DataTable listarLivro()
        {
            string sql = string.Format($@"SELECT * FROM TBL_Livro");
            return daoBanco.executarConsulta(sql);
        }

        public void criarLivro(tblLivroDTO dados)
        {
            string sql = string.Format($@"INSERT INTO TBL_Livro VALUES(NULL, '{dados.IdAutor}', '{dados.IdEditora}', '{dados.TituloLivro}', '{dados.DataCadastro.ToString("yyyy-MM-dd")}', '{dados.NumeroPaginas}', '{dados.ValorLivro}');");
            daoBanco.executarComando(sql);
        }

        public void apagarLivro(tblLivroDTO dados)
        {
            string sql = string.Format($@"DELETE FROM TBL_Livro where idLivro = {dados.IdLivro};");
            daoBanco.executarComando(sql);
        }

        public void atualizarLivro(tblLivroDTO dados)
        {
            string sql = string.Format($@"UPDATE TBL_Livro SET idAutor = '{dados.IdAutor}', idEditora = '{dados.IdEditora}', titulo = '{dados.TituloLivro}', dataCadastro = '{dados.DataCadastro.ToString("yyyy-MM-dd")}', numeroPaginas = '{dados.NumeroPaginas}', valor = '{dados.ValorLivro}' WHERE idLivro = '{dados.Id\livro}';");
            daoBanco.executarComando(sql);
        }
    }
}
