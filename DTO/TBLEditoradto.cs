using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Linq ;
usando o  sistema . Web ;

namespace  POO3B10207 . DTO
{
     classe  pública TBLEditoradto
    {
        private  int  ideditora ;
         string  privado nomeeditora , enderecoeditora , ufeditora ;

        public  int  IdEditora { get  =>  ideditora ; definir  =>  ideditora  =  valor ; }

        public  string  NomeEditora
        {
            get { return  nomeeditora ; }
            conjunto
            {
                if ( valor  ! =  string . Vazio )
                {
                    nomeeditora  =  valor ;
                }
                outro
                {
                    lançar  nova  exceção ( " É obrigatorio preencher o campo email. " );
                }
            }
        }

        public  string  EnderecoEditora
        {
            get { return  enderecoeditora ; }
            conjunto
            {
                if ( valor  ! =  string . Vazio )
                {
                    enderecoeditora  =  valor ;
                }
                outro
                {
                    lançar  nova  Exceção ( " É obrigatorio preencher o campo endereço. " );
                }
            }
        }

        public  string  UFEditora
        {
            get { return  ufeditora ; }
            conjunto
            {
                if ( valor  ! =  string . Vazio )
                {
                    ufeditora  =  valor ;
                }
                outro
                {
                    lançar  nova  Exceção ( " É obrigatorio preencher o campo UF " );
                }
            }
        }
    }
}
