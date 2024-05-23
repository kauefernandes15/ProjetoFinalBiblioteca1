using ProjetoFinalBiblioteca1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalBiblioteca
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {


            // see https://aka.ms/applicationconfiguration.


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}