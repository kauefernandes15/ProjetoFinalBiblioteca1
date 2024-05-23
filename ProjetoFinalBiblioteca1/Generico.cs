using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalBiblioteca
{
    public class Generico : Exemplar
    {
        public int Tipo { get; set; }
        public Generico()
        {
        }
        public Generico(string titulo, string subTitulo, string escritor, string editora, int anoPublicacao, string genero,int status, int tipo) : base(titulo,subTitulo ,escritor, editora, anoPublicacao, genero, status)
        {
            Tipo = tipo;
        }
        public override string ToString()
        {
            return "";
        }
    }
    
}
