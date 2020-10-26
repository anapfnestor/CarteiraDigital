using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarteiraDigital
{
    public class MDISingleton
    {
        private MDISingleton() { }

        private static mdiTelaInicial instanceMDIPrincipal;

        public static mdiTelaInicial instanciaMDI()
        {
            if (instanceMDIPrincipal == null)
            {
                instanceMDIPrincipal = new mdiTelaInicial();
                return instanceMDIPrincipal;
            }
            return instanceMDIPrincipal;
        }

        
    }
}
