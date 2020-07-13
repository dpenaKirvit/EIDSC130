using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace EIDS.Instrumentos
{
    /*public class VM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChange(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        public VM()
        {
            Thread valor = new Thread(Valor);
            valor.Start();
        }
        
        //Variable ins2
        private float val;
        public float Val
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
                RaisePropertyChange("Val");
            }
        }
        //Variable ins1
        private float val2;
        public float Val2
        {
            get
            {
                return val2;
            }
            set
            {
                val2 = value;
                RaisePropertyChange("Val2");
            }
        }
        //Variable ins3
        private float val3;
        public float Val3
        {
            get
            {
                return val3;
            }
            set
            {
                val3 = value;
                RaisePropertyChange("Val3");
            }
        }
        
        private void Valor()
        {
            ComunicacionClienteEids com = new ComunicacionClienteEids();
            while (true)
            {
                string valor = com.GetInstrumentos._OH_7_2_MN_1_76.Valor;
                Val = float.Parse(valor);
                string valor2 = com.GetInstrumentos._OH_7_1_MN_2_75.Valor;
                Val2 = float.Parse(valor2);
                Val3 = Val2 % 10;
            }
        }
    }*/
}