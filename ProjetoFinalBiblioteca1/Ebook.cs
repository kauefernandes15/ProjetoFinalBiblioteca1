using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalBiblioteca
{
    public class Ebook : Livro
    {
        public decimal Tamanho { get; set; }
        public string Url { get; set; }
        public string Formato { get; set; }
        public Ebook(string titulo,string subTitulo, string escritor,string editora, int anoPublicacao,string genero,int status, int paginas, string tipoCapa, string isbn,string formato, decimal tamanho, string url) : base(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status, paginas, tipoCapa, isbn)
        {
            Tamanho = tamanho;
            Url = url;
            Formato = formato;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
