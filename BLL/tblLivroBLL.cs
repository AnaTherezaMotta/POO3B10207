using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using POO3B10924.DAL;
using POO3B10924.DTO;

namespace POO3B10924.BLL
{
    public class tblLivroBLL
    {
        private DALMysql daoBanco = new DALMysql();
        public DataTable listarLivros()
        {
            string sql = string.Format($@"SELECT * FROM TBL_Livro");
            return daoBanco.executarConsulta(sql);
        }

        public void criarLivro(tblLivroDTO dados)
        {
            string sql = string.Format($@"INSERT INTO TBL_Livro VALUES(NULL, '{dados.Id_autor}', '{dados.Id_editora}', '{dados.Titulo_livro}', '{dados.Data_cadastro.ToString("yyyy-MM-dd")}', '{dados.Num_paginas}', '{dados.Valor_livro}');");
            daoBanco.executarComando(sql);
        }

        public void deletarLivro(tblLivroDTO dados)
        {
            string sql = string.Format($@"DELETE FROM TBL_Livro where idLivro = {dados.Id_livro};");
            daoBanco.executarComando(sql);
        }

        public void atualizarLivro(tblLivroDTO dados)
        {
            string sql = string.Format($@"UPDATE TBL_Livro SET idAutor = '{dados.Id_autor}', idEditora = '{dados.Id_editora}', titulo = '{dados.Titulo_livro}', dataCadastro = '{dados.Data_cadastro.ToString("yyyy-MM-dd")}', numPaginas = '{dados.Num_paginas}', valor = '{dados.Valor_livro}' WHERE idLivro = '{dados.Id_livro}';");
            daoBanco.executarComando(sql);
        }
    }
}