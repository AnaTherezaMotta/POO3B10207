using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Linq ;
usando o  sistema . Web ;
usando o  sistema . Dados ;
usando  POO3B102207 . DAL ;
usando  POO3B10207 . DTO ;

namespace  POO3B10207 . BLL
{
     classe  pública TBLLivrobll
    {
         DALMysql  daoBanco  privado =  novo  DALMysql ();
        public  DataTable  listarLivro ()
        {
            string  sql  =  string . Formato ( $ @ " SELECT * FROM TBL_Livro " );
            voltar  daoBanco . executarConsulta ( sql );
        }

        public  void  criarLivro ( TBLLivrodto  dados )
        {
            string  sql  =  string . Formato ( $ @ " INSERT INTO TBL_Livro VALUES (NULL, '{ dados . IdAutor }', '{ dados . IdEditora }', '{ dados . TituloLivro }', '{ dados . DataCadastro . ToString ( " yyyy-MM-dd " )} ',' { dados . NumeroPaginas } ',' { dados . ValorLivro } '); " );
            daoBanco . executarComando ( sql );
        }

        public  void  apagarLivro ( TBLLivrodto  dados )
        {
            string  sql  =  string . Formato ( $ @ " DELETE FROM TBL_Livro onde idLivro = { dados . IdLivro }; " );
            daoBanco . executarComando ( sql );
        }

        public  void  atualizarLivro ( TBLLivrodto  dados )
        {
            string  sql  =  string . Format ( $ @ " UPDATE TBL_Livro SET idAutor = '{ dados . IdAutor }', idEditora = '{ dados . IdEditora }', titulo = '{ dados . TituloLivro }', dataCadastro = '{ dados . DataCadastro . ToString ( " yyyy -MM-dd " )} ', numeroPaginas =' { dados . NumeroPaginas } ', valor =' { dados . ValorLivro } 'WHERE idLivro =' { dados .} '; " );
            daoBanco . executarComando ( sql );
        }
    }
}
