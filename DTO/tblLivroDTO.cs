using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3B10207.DTO
{
    public class tblLivroDTO
    {
        private int id_livro, id_autor, id_editora, num_paginas;
        private double valor_livro;
        private DateTime data_cadastro;
        private string titulo_livro;

        public string TituloLivro
        {
            get { return titulo_livro; }
            set
            {
                if(value != string.Empty)
                {
                    titulo_livro = value;
                }
                else
                {
                    throw new Exception("Título do Livro é obrigatório!");
                }
            }
        }

        public DateTime DataCadastro { get => data_cadastro; set => data_cadastro = value; }
        public int IdLivro { get => id_livro; set => id_livro = value; }
        public int IdAutor { get => id_autor; set => id_autor = value; }
        public int IdEditora { get => id_editora; set => id_editora = value; }

        public double ValorLivro { 
            get { return valor_livro; }
            set
            {
                if(value != 0)
                {
                    valor_livro = value;
                }
                else
                {
                    throw new Exception("É necessario preencher o valor do livro!");
                }
            }
        }

        public int NumeroPaginas
        {
            get { return num_paginas; }
            set
            {
                if (value != 0)
                {
                    num_paginas = value;
                }
                else
                {
                    throw new Exception("É necessário preencher o número de páginas!");
                }
            }
        }

    }
}
