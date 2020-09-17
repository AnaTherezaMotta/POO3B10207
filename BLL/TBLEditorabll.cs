using  System ;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using POO3B10207.DAL;
using POO3B10207.DTO;

namespace  POO3B10207 . BLL
{
    public  class  TBLEditorabll
    {
         private DALMysql daoBanco = new DALMysql();
        public DataTable listarEditora()
        {
            string  sql  =  string . Format ( $ @ " SELECT * FROM TBL_Editora " );
            return  daoBanco . executarConsulta ( sql );
        }

        public  void  criarEditora ( TBLEditoradto  dados )
        {
            string  sql  =  string . Format ( $ @ " INSERT INTO TBL_Editora VALUES (NULL, '{ dados . NomeEditora }', '{ dados . EnderecoEditora }', '{ dados . UFEditora }'); " );
            return daoBanco . executarConsulta ( sql );
        }

        public  void  apagarEditora ( TBLEditoradto  dados )
        {
            string  query  =  string . Format ( $ @ " DELETE FROM TBL_Editora where id = { dados . IdEditora }; " );
            return daoBanco . executarComando ( consulta );
        }

        public  void  atualizarEditora ( TBLEditoradto  dados )
        {
            string  query  =  string . Format ( $ @ " UPDATE TBL_Editora SET nome = '{ dados . NomeEditora }', endereco = '{ dados . EnderecoEditora }', UF = '{ dados . UFEditora }') WHERE id = { dados . IdEditora }; " );
            return daoBanco . executarComando ( consulta );
        }
    }   
}
