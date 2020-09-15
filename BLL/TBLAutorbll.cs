using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Linq ;
usando o  sistema . Web ;
usando o  sistema . Dados ;
usando  POO3B10207 . DAL ;
usando  POO3B10207 . DTO ;

namespace  POO3B10207 . BLL
{
     classe  pública TBLAutorbll
    {
         DALMysql  daoBanco  privado =  novo  DALMysql ();
        public  DataTable  listarAutor ()
        {
            string  sql  =  string . Formato ( $ @ " SELECT * FROM TBL_Autor " );
            voltar  daoBanco . executarConsulta ( sql );
        }

        public  void  criarAutor ( TBLAutordto  dados )
        {
            string  sql  =  string . Formato ( $ @ " INSERT INTO TBL_Autor VALUES (NULL, '{ dados . NomeAutor }', '{ dados . IdadeAutor }'); " );
            daoBanco . executarComando ( sql );
        }

        public  void  apagarAutor ( TBLAutordto  dados )
        {
            string  sql  =  string . Formato ( $ @ " DELETE FROM TBL_Autor where id = { dados . IdAutor }; " );
            daoBanco . executarComando ( sql );
        }

        public  void  atualizarAutor ( TBLAutordto  dados )
        {
            string  sql  =  string . Formato ( $ @ " UPDATE TBL_Autor SET nome = '{ dados . NomeAutor }', idade = '{ dados . IdadeAutor }') WHERE id = { dados . IdAutor }; " );
            daoBanco . executarComando ( sql );
        }
    }
}
