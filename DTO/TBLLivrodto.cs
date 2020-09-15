using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Linq ;
usando o  sistema . Web ;

namespace  POO3B10207 . DTO
{
     classe  pública TBLLivrodto
    {
        privado  int  idlivro , idautor , ideditora , numeropaginas ;
         valorlivro duplo  privado ;
         datacadastro DateTime  privado ;
         titulolivro string  privado ;

        public  string  TituloLivro
        {
            get { return  titulolivro ; }
            conjunto
            {
                if ( valor  ! =  string . Vazio )
                {
                    titulolivro  =  valor ;
                }
                outro
                {
                    lançar uma  nova  Exception ( " Título do Livro é obrigatório! " );
                }
            }
        }

        public  DateTime  DataCadastro { get  =>  datacadastro ; conjunto  =>  datacadastro  =  valor ; }
        público  int  IdLivro { get  =>  idlivro ; definir  =>  idlivro  =  valor ; }
        public  int  IdAutor { get  =>  idautor ; definir  =>  idautor  =  valor ; }
        public  int  IdEditora { get  =>  ideditora ; definir  =>  ideditora  =  valor ; }

        public  double  ValorLivro {
            obter { return  valorlivro ; }
            conjunto
            {
                if ( valor  ! =  0 )
                {
                    valorlivro  =  valor ;
                }
                outro
                {
                    lançar  nova  Exceção ( " É necessário preencher o valor do livro! " );
                }
            }
        }

        public  int  NumeroPaginas
        {
            get { return  numeropaginas ; }
            conjunto
            {
                if ( valor  ! =  0 )
                {
                    numeropaginas  =  valor ;
                }
                outro
                {
                    lançar uma  nova  Exception ( " É necessário preencher o número de páginas! " );
                }
            }
        }

    }
}
