using  System ;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using POO3B10207.DAL;
using POO3B10207.DTO;

namespace  POO3B10207 . BLL
{
     class  public TBLAutorbll
    {
        private DALMysql daoBanco = new DALMysql();
        public DataTable listarAutor()
        {
            string sql = string.Format($@"SELECT * FROM TBL_Autor");
            return daoBanco.executarConsulta(sql);
        }

        public  void  criarAutor ( TBLAutordto  dados )
        {
            string  sql  =  string . Formato ( $ @ " INSERT INTO TBL_Autor VALUES (NULL, '{ dados . NomeAutor }', '{ dados . IdadeAutor }'); " );
            return daoBanco . executarComando ( sql );
        }

        public  void  apagarAutor ( TBLAutordto  dados )
        {
            string  sql  =  string .Format( $ @ " DELETE FROM TBL_Autor where id = { dados . IdAutor }; " );
            return daoBanco . executarComando ( sql );
        }

        public  void  atualizarAutor ( TBLAutordto  dados )
        {
            string  sql  =  string . Format ( $ @ " UPDATE TBL_Autor SET nome = '{ dados . NomeAutor }', idade = '{ dados . IdadeAutor }') WHERE id = { dados . IdAutor }; " );
            return daoBanco . executarComando ( sql );
        }
    }
}
