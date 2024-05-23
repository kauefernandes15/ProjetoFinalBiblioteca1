﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
//Nome:Taína Carvalho 3 fase

namespace ProjetoFinalBiblioteca
{
    public class Emprestimo
    {
        public string LeitorOrigem { get; set; }
        public string LeitorDestino { get; set; }
        public string ExemplarItem { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }

        public Emprestimo()
        {
        }

        public Emprestimo(string leitorOrigem, string leitorDestino, string exemplarItem, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            LeitorOrigem = leitorOrigem;
            LeitorDestino = leitorDestino;
            ExemplarItem = exemplarItem;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
        }
    }
}