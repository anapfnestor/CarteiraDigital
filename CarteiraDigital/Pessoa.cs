using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDigital
{
    interface Pessoa
    {
        string Nome { get; set; }

        string Sobrenome { get; set; }

        //int Documento { get; set; }

        string Nacionalidade { get; set; }

        DateTime DataNascimento { get; set; }

        string Documento { get; set; }

        void Gravar();

        void Consultar();
    }
}
