using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3B10207.DTO
{
    public class tblLivroDTO
    {
        private int idlivro, idautor, ideditora, numeropaginas;
        private double valorlivro;
        private DateTime datacadastro;
        private string titulolivro;

        public string TituloLivro
        {
            get { return titulolivro; }
            set
            {
                if(value != string.Empty)
                {
                    titulolivro = value;
                }
                else
                {
                    throw new Exception("Título do Livro é obrigatório!");
                }
            }
        }

        public DateTime DataCadastro { get => datacadastro; set => datacadastro = value; }
        public int IdLivro { get => idlivro; set => idlivro = value; }
        public int IdAutor { get => id_autor; set => idautor = value; }
        public int IdEditora { get => ideditora; set => ideditora = value; }

        public double ValorLivro { 
            get { return valorlivro; }
            set
            {
                if(value != 0)
                {
                    valorlivro = value;
                }
                else
                {
                    throw new Exception("É necessario preencher o valor do livro!");
                }
            }
        }

        public int NumeroPaginas
        {
            get { return numeropaginas; }
            set
            {
                if (value != 0)
                {
                    numeropaginas = value;
                }
                else
                {
                    throw new Exception("É necessário preencher o número de páginas!");
                }
            }
        }

    }
}
