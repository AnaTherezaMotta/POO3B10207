using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using POO3B10207.DAL;
using POO3B10207.DTO;

namespace POO3B10207.BLL
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
            string sql = string.Format($@"INSERT INTO TBL_Autor VALUES (NULL, '{dados.NomeAutor}', '{dados.IdadeAutor}');");
            daoBanco.executarComando(sql);
        }

        public void deletarAutor(tblAutorDTO dados)
        {
            string sql = string.Format($@"DELETE FROM TBL_Autor where id = {dados.IdAutor};");
            daoBanco.executarComando(sql);
        }

        public void atualizarAutor(tblAutorDTO dados)
        {
            string sql = string.Format($@"UPDATE TBL_Autor SET nome = '{dados.NomeAutor}', idade = '{dados.IdadeAutor}' ) WHERE id = {dados.IdAutor};");
            daoBanco.executarComando(sql);
        }
    }
}
