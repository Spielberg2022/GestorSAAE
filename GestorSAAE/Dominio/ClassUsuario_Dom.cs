using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestorSAAE.Dominio
{
    class ClassUsuario_Dom
    {
        private int codigo;
        private string nome;
        private string identificador;
        private string senha;
        private string autenticacao;
        private string situacao;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Identificador { get => identificador; set => identificador = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Autenticacao { get => autenticacao; set => autenticacao = value; }
        public string Situacao { get => situacao;
            set
            {
                autenticacao = value;
                if (autenticacao == "A")
                {
                    autenticacao = "Ativo";
                }
                else
                {
                    autenticacao = "Cancelado";
                }
            }
        }
    }
}
