using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalBiblioteca
{
    public class Revista : Exemplar
    {
        public int Edicao { get; set; }
        public int Paginas { get; set; }
        public Revista()
        {
        }
        public Revista(string titulo,string subtitulo,string autor, string editora,int anoPublicacao,string genero,int status, int edicao, int paginas)
        {
            Edicao = edicao;
            Paginas = paginas;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
