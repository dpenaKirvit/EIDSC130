using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIDS.Instrumentos
{
    public class EI_1_47_DN_1
    {
        string _nombre_senal;
        string _valor1;
        string _valor2;
        string _valor3;
        string _valor4;
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
        public string Valor3
        {
            get { return _valor3; }
            set { _valor3 = value; }
        }
        public string Valor4
        {
            get { return _valor4; }
            set { _valor4 = value; }
        }
        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        public EI_1_47_DN_1()
        {
            Nombre_Senal = "EI_1_47_DN_1_AS";
            _valor1 = "0";
            _valor2 = "0";
            _valor3 = "0";
            _valor4 = "0";
            _mensaje = "";
        }
    }
}
