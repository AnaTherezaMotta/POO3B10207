using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3B10207.DTO
{
    public class tblAutorDTO
    {
        private int id_autor, idade_autor;
        private string nome_autor;

        public int IdAutor { get => id_autor; set => id_autor = value; }

        public string NomeAutor
        {
            get { return nome_autor; }
            set
            {
                if (value != string.Empty)
                {
                    nome_autor = value;
                }
                else
                {
                    throw new Exception("É obrigatorio preecher o nome do autor!!!");
                }
            }
        }

        public int IdadeAutor { 
            get { return idade_autor; }
            set
            {
                if(value >= 0)
                {
                    idade_autor = value;
                }
                else
                {
                    throw new Exception("A idade do autor é invalida!!!");
                }
            }
        }
    }
}