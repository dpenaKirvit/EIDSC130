using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIDS.Instrumentos
{
    public class OH_7_2_MN_1_76
    {
        string _nombre_senal;
        string _valor;
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
        public OH_7_2_MN_1_76()
        {
            Nombre_Senal = "OH_7_2_MN_1_AS";
            _valor = "0";
        }

    }
}
