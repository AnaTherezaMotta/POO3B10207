using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3B10207.DTO
{
    public class tblAutorDTO
    {
        private int idautor, idadeautor;
        private string nomeautor;

        public int IdAutor { get => idautor; set => idautor = value; }

        public string NomeAutor
        {
            get { return nomeautor; }
            set
            {
                if (value != string.Empty)
                {
                    nomeautor = value;
                }
                else
                {
                    throw new Exception("É obrigatorio preencher o nome do autor!!!");
                }
            }
        }

        public int IdadeAutor { 
            get { return idadeautor; }
            set
            {
                if(value >= 0)
                {
                    idadeautor = value;
                }
                else
                {
                    throw new Exception("A idade do autor que você colocou é invalida!!!");
                }
            }
        }
    }
}
