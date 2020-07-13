using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIDS.Instrumentos
{
    public class EI_1_40_MN_1
    {
        string _nombre_senal;
        string _valor1;
        string _valor2;
        string _mensaje;
        public string Nombre_Senal
        {
            get { return _nombre_senal; }
            set { _nombre_senal = value; }
        }
        public string Valor1
        {
            get { return _valor1; }
            set { _valor1 = value; }
        }
        public string Valor2
        {
            get { return _valor2; }
            set { _valor2 = value; }
        }
        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        public EI_1_40_MN_1()
        {
            Nombre_Senal = "EI_1_40_MN_1_AS";
            _valor1 = "0";
            _valor2 = "0";
            _mensaje = "";
        }
    }
}
