using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIDS.Instrumentos
{
    public class EI_1_18_DN_1
    {
        string _nombre_senal;
        string _valor;
        string _mensaje;
        public string Nombre_Senal
        {
            get { return _nombre_senal; }
            set { _nombre_senal = value; }
        }
        public string Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        public EI_1_18_DN_1()
        {
            Nombre_Senal = "EI_1_18_DN_1_AS";
            _valor = "1500";
            _mensaje = "";
        }
    }
}
