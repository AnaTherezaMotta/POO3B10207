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
         DALMysql  daoBanco  privado =  novo  DALMysql ();
        public  DataTable  listarEditora ()
        {
            string  sql  =  string . Format ( $ @ " SELECT * FROM TBL_Editora " );
            voltar  daoBanco . executarConsulta ( sql );
        }

        public  void  criarEditora ( TBLEditoradto  dados )
        {
            string  sql  =  string . Format ( $ @ " INSERT INTO TBL_Editora VALUES (NULL, '{ dados . NomeEditora }', '{ dados . EnderecoEditora }', '{ dados . UFEditora }'); " );
            daoBanco . executarConsulta ( sql );
        }

        public  void  apagarEditora ( TBLEditoradto  dados )
        {
            string  query  =  string . Format ( $ @ " DELETE FROM TBL_Editora where id = { dados . IdEditora }; " );
            daoBanco . executarComando ( consulta );
        }

        public  void  atualizarEditora ( TBLEditoradto  dados )
        {
            string  query  =  string . Format ( $ @ " UPDATE TBL_Editora SET nome = '{ dados . NomeEditora }', endereco = '{ dados . EnderecoEditora }', UF = '{ dados . UFEditora }') WHERE id = { dados . IdEditora }; " );
            daoBanco . executarComando ( consulta );
        }
    }   
}
