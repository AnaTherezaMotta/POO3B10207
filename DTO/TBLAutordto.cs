using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Linq ;
usando o  sistema . Web ;

namespace  POO3B10207 . DTO
{
     class  public   TBLAutordto
    {
         private int idautor, idadeautor ;
         private string nomeautor;

        public  int  IdAutor { get  =>  idautor ; definir  =>  idautor  =  valor ; }

        public  string  NomeAutor
        {
            get { return  nomeautor ; }
            conjunto
            {
                if ( valor  ! =  string . Vazio )
                {
                    nomeautor  =  valor ;
                }
                outro
                {
                    lançar  nova  Exceção ( " É obrigatorio preencher o nome do autor !!! " );
                }
            }
        }

        public  int  IdadeAutor {
            get { return  idadeautor ; }
            conjunto
            {
                if ( valor  > =  0 )
                {
                    idadeautor  =  valor ;
                }
                outro
                {
                    lançar  novo  Exception ( " A idade do autor que você colocou é invalida !!! " );
                }
            }
        }
    }
}
