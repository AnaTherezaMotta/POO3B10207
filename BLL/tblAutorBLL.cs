using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using POO3B10924.DAL;
using POO3B10924.DTO;

namespace POO3B10924.BLL
{
    public class tblAutorBLL
    {
        private DALMysql daoBanco = new DALMysql();
        public DataTable listarAutores()
        {
            string sql = string.Format($@"SELECT * FROM TBL_Autor");
            return daoBanco.executarConsulta(sql);
        }

        public void criarAutor(tblAutorDTO dados)
        {
            string sql = string.Format($@"INSERT INTO TBL_Autor VALUES (NULL, '{dados.Nome_autor}', '{dados.Idade_autor}');");
            daoBanco.executarComando(sql);
        }

        public void deletarAutor(tblAutorDTO dados)
        {
            string sql = string.Format($@"DELETE FROM TBL_Autor where id = {dados.Id_autor};");
            daoBanco.executarComando(sql);
        }

        public void atualizarAutor(tblAutorDTO dados)
        {
            string sql = string.Format($@"UPDATE TBL_Autor SET nome = '{dados.Nome_autor}', idade = '{dados.Idade_autor}' ) WHERE id = {dados.Id_autor};");
            daoBanco.executarComando(sql);
        }
    }
}