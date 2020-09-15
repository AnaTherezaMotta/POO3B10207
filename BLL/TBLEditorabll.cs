using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using POO3B10207.DAL;
using POO3B10207.DTO;

namespace POO3B10207.BLL
{
    public class tblEditoraBLL
    {
        private DALMysql daoBanco = new DALMysql();
        public DataTable listarEditoras()
        {
            string sql = string.Format($@"SELECT * FROM TBL_Editora");
            return daoBanco.executarConsulta(sql);
        }

        public void criarEditora(tblEditoraDTO dados)
        {
            string sql = string.Format($@"INSERT INTO TBL_Editora VALUES (NULL, '{dados.Nome_editora}', '{dados.Endereco_editora}', '{dados.UF_editora}');");
            daoBanco.executarConsulta(sql);
        }

        public void deletarEditora(tblEditoraDTO dados)
        {
            string query = string.Format($@"DELETE FROM TBL_Editora where id = {dados.Id_editora};");
            daoBanco.executarComando(query);
        }

        public void atualizarEditora(tblEditoraDTO dados)
        {
            string query = string.Format($@"UPDATE TBL_Editora SET nome = '{dados.Nome_editora}', endereco = '{dados.Endereco_editora}', UF = '{dados.UF_editora}' ) WHERE id = {dados.Id_editora};");
            daoBanco.executarComando(query);
        }
    }   
}