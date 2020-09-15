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
            string sql = string.Format($@"INSERT INTO TBL_Editora VALUES (NULL, '{dados.NomeEditora}', '{dados.EnderecoEditora}', '{dados.UFEditora}');");
            daoBanco.executarConsulta(sql);
        }

        public void apagarEditora(tblEditoraDTO dados)
        {
            string query = string.Format($@"DELETE FROM TBL_Editora where id = {dados.IdEditora};");
            daoBanco.executarComando(query);
        }

        public void atualizarEditora(tblEditoraDTO dados)
        {
            string query = string.Format($@"UPDATE TBL_Editora SET nome = '{dados.NomeEditora}', endereco = '{dados.EnderecoEditora}', UF = '{dados.UFEditora}' ) WHERE id = {dados.IdEditora};");
            daoBanco.executarComando(query);
        }
    }   
}
