using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3B10207.DTO
{
    public class tblEditoraDTO
    {
        private int ideditora;
        private string nomeeditora, enderecoeditora, ufeditora;

        public int IdEditora { get => ideditora; set => ideditora = value; }

        public string NomeEditora
        {
            get { return nomeeditora; }
            set
            {
                if (value != string.Empty)
                {
                    nomeeditora = value;
                }
                else
                {
                    throw new Exception("É obrigatorio preencher o campo email.");
                }
            }
        }

        public string EnderecoEditora
        {
            get { return enderecoeditora; }
            set
            {
                if (value != string.Empty)
                {
                    enderecoeditora = value;
                }
                else
                {
                    throw new Exception("É obrigatorio preencher o campo endereço.");
                }
            }
        }

        public string UFEditora
        {
            get { return ufeditora; }
            set
            {
                if (value != string.Empty)
                {
                    ufeditora = value;
                }
                else
                {
                    throw new Exception("É obrigatorio preencher o campo UF");
                }
            }
        }
    }
}
