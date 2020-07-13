using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EIDS.Instrumentos
{
    public class VM2 : INotifyPropertyChanged
    {
        private ComunicacionClienteEids com;
        /////////////////////////////////////////////////////////////////////METODOS////////////////////////////////////////////////////////
        #region
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChange(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        public float Map(float value, float fromSource, float toSource, float fromTarget, float toTarget)
        {
            return (value - fromSource) * (toTarget - fromTarget) / (toSource - fromSource) + fromTarget;
        }
        public VM2()
        {
            Thread valor = new Thread(Valor);
            valor.Start();
        }
        #endregion

        /////////////////////////////////////////////////////////////////////VARIABLES BINDING////////////////////////////////////////////////////////
        #region
        ///////////////////////////////////////////////////EOT1

        /////////Valor
        private string eot1; public string Eot1 { get { return eot1; } set { eot1 = value; RaisePropertyChange("Eot1"); } }
        /////////Color
        private string ceot1; public string Ceot1 { get { return ceot1; } set { ceot1 = value; RaisePropertyChange("Ceot1"); } }
        /////////Foreground
        private string feot1; public string Feot1 { get { return feot1; } set { feot1 = value; RaisePropertyChange("Feot1"); } }
        /////////Background
        private string beot1; public string Beot1 { get { return beot1; } set { beot1 = value; RaisePropertyChange("Beot1"); } }

        ///////////////////////////////////////////////////EOT1
        ///////////////////////////////////////////////////EOT2

        /////////Valor
        private string eot2; public string Eot2 { get { return eot2; } set { eot2 = value; RaisePropertyChange("Eot2"); } }
        /////////Color
        private string ceot2; public string Ceot2 { get { return ceot2; } set { ceot2 = value; RaisePropertyChange("Ceot2"); } }
        /////////Foreground
        private string feot2; public string Feot2 { get { return feot2; } set { feot2 = value; RaisePropertyChange("Feot2"); } }
        /////////Background
        private string beot2; public string Beot2 { get { return beot2; } set { beot2 = value; RaisePropertyChange("Beot2"); } }

        ///////////////////////////////////////////////////EOT2
        ///////////////////////////////////////////////////EOT3

        /////////Valor
        private string eot3; public string Eot3 { get { return eot3; } set { eot3 = value; RaisePropertyChange("Eot3"); } }
        /////////Color
        private string ceot3; public string Ceot3 { get { return ceot3; } set { ceot3 = value; RaisePropertyChange("Ceot3"); } }
        /////////Foreground
        private string feot3; public string Feot3 { get { return feot3; } set { feot3 = value; RaisePropertyChange("Feot3"); } }
        /////////Background
        private string beot3; public string Beot3 { get { return beot3; } set { beot3 = value; RaisePropertyChange("Beot3"); } }

        ///////////////////////////////////////////////////EOT3
        ///////////////////////////////////////////////////EOT4

        /////////Valor
        private string eot4; public string Eot4 { get { return eot4; } set { eot4 = value; RaisePropertyChange("Eot4"); } }
        /////////Color
        private string ceot4; public string Ceot4 { get { return ceot4; } set { ceot4 = value; RaisePropertyChange("Ceot4"); } }
        /////////Foreground
        private string feot4; public string Feot4 { get { return feot4; } set { feot4 = value; RaisePropertyChange("Feot4"); } }
        /////////Background
        private string beot4; public string Beot4 { get { return beot4; } set { beot4 = value; RaisePropertyChange("Beot4"); } }

        ///////////////////////////////////////////////////EOT4
        ///////////////////////////////////////////////////EOP1

        /////////Valor
        private string eop1; public string Eop1 { get { return eop1; } set { eop1 = value; RaisePropertyChange("Eop1"); } }
        /////////Valor Aguja
        private float aeop1; public float Aeop1 { get { return aeop1; } set { aeop1 = value; RaisePropertyChange("Aeop1"); } }
        /////////Barra1
        private float b1eop1; public float B1eop1 { get { return b1eop1; } set { b1eop1 = value; RaisePropertyChange("B1eop1"); } }
        /////////Barra2
        private float b2eop1; public float B2eop1 { get { return b2eop1; } set { b2eop1 = value; RaisePropertyChange("B2eop1"); } }
        /////////Color
        private string ceop1; public string Ceop1 { get { return ceop1; } set { ceop1 = value; RaisePropertyChange("Ceop1"); } }
        /////////Foreground
        private string feop1; public string Feop1 { get { return feop1; } set { feop1 = value; RaisePropertyChange("Feop1"); } }
        /////////Background
        private string beop1; public string Beop1 { get { return beop1; } set { beop1 = value; RaisePropertyChange("Beop1"); } }

        ///////////////////////////////////////////////////EOP1
        ///////////////////////////////////////////////////EOP2

        /////////Valor
        private string eop2; public string Eop2 { get { return eop2; } set { eop2 = value; RaisePropertyChange("Eop2"); } }
        /////////Valor Aguja
        private float aeop2; public float Aeop2 { get { return aeop2; } set { aeop2 = value; RaisePropertyChange("Aeop2"); } }
        /////////Barra1
        private float b1eop2; public float B1eop2 { get { return b1eop2; } set { b1eop2 = value; RaisePropertyChange("B1eop2"); } }
        /////////Barra2
        private float b2eop2; public float B2eop2 { get { return b2eop2; } set { b2eop2 = value; RaisePropertyChange("B2eop2"); } }
        /////////Color
        private string ceop2; public string Ceop2 { get { return ceop2; } set { ceop2 = value; RaisePropertyChange("Ceop2"); } }
        /////////Foreground
        private string feop2; public string Feop2 { get { return feop2; } set { feop2 = value; RaisePropertyChange("Feop2"); } }
        /////////Background
        private string beop2; public string Beop2 { get { return beop2; } set { beop2 = value; RaisePropertyChange("Beop2"); } }

        ///////////////////////////////////////////////////EOP2
        ///////////////////////////////////////////////////EOP3

        /////////Valor
        private string eop3; public string Eop3 { get { return eop3; } set { eop3 = value; RaisePropertyChange("Eop3"); } }
        /////////Valor Aguja
        private float aeop3; public float Aeop3 { get { return aeop3; } set { aeop3 = value; RaisePropertyChange("Aeop3"); } }
        /////////Barra1
        private float b1eop3; public float B1eop3 { get { return b1eop3; } set { b1eop3 = value; RaisePropertyChange("B1eop3"); } }
        /////////Barra2
        private float b2eop3; public float B2eop3 { get { return b2eop3; } set { b2eop3 = value; RaisePropertyChange("B2eop3"); } }
        /////////Color
        private string ceop3; public string Ceop3 { get { return ceop3; } set { ceop3 = value; RaisePropertyChange("Ceop3"); } }
        /////////Foreground
        private string feop3; public string Feop3 { get { return feop3; } set { feop3 = value; RaisePropertyChange("Feop3"); } }
        /////////Background
        private string beop3; public string Beop3 { get { return beop3; } set { beop3 = value; RaisePropertyChange("Beop3"); } }

        ///////////////////////////////////////////////////EOP3
        ///////////////////////////////////////////////////EOP4

        /////////Valor
        private string eop4; public string Eop4 { get { return eop4; } set { eop4 = value; RaisePropertyChange("Eop4"); } }
        /////////Valor Aguja
        private float aeop4; public float Aeop4 { get { return aeop4; } set { aeop4 = value; RaisePropertyChange("Aeop4"); } }
        /////////Barra1
        private float b1eop4; public float B1eop4 { get { return b1eop4; } set { b1eop4 = value; RaisePropertyChange("B1eop4"); } }
        /////////Barra2
        private float b2eop4; public float B2eop4 { get { return b2eop4; } set { b2eop4 = value; RaisePropertyChange("B2eop4"); } }
        /////////Color
        private string ceop4; public string Ceop4 { get { return ceop4; } set { ceop4 = value; RaisePropertyChange("Ceop4"); } }
        /////////Foreground
        private string feop4; public string Feop4 { get { return feop4; } set { feop4 = value; RaisePropertyChange("Feop4"); } }
        /////////Background
        private string beop4; public string Beop4 { get { return beop4; } set { beop4 = value; RaisePropertyChange("Beop4"); } }

        ///////////////////////////////////////////////////EOP4
        ///////////////////////////////////////////////////GBOP1

        /////////Valor
        private string gbop1; public string Gbop1 { get { return gbop1; } set { gbop1 = value; RaisePropertyChange("Gbop1"); } }
        /////////Valor Aguja
        private float agbop1; public float Agbop1 { get { return agbop1; } set { agbop1 = value; RaisePropertyChange("Agbop1"); } }
        /////////Barra1
        private float b1gbop1; public float B1gbop1 { get { return b1gbop1; } set { b1gbop1 = value; RaisePropertyChange("B1gbop1"); } }
        /////////Barra2
        private float b2gbop1; public float B2gbop1 { get { return b2gbop1; } set { b2gbop1 = value; RaisePropertyChange("B2gbop1"); } }
        /////////Color
        private string cgbop1; public string Cgbop1 { get { return cgbop1; } set { cgbop1 = value; RaisePropertyChange("Cgbop1"); } }
        /////////Foreground
        private string fgbop1; public string Fgbop1 { get { return fgbop1; } set { fgbop1 = value; RaisePropertyChange("Fgbop1"); } }
        /////////Background
        private string bgbop1; public string Bgbop1 { get { return bgbop1; } set { bgbop1 = value; RaisePropertyChange("Bgbop1"); } }

        ///////////////////////////////////////////////////GBOP1
        ///////////////////////////////////////////////////GBOP2

        /////////Valor
        private string gbop2; public string Gbop2 { get { return gbop2; } set { gbop2 = value; RaisePropertyChange("Gbop2"); } }
        /////////Valor Aguja
        private float agbop2; public float Agbop2 { get { return agbop2; } set { agbop2 = value; RaisePropertyChange("Agbop2"); } }
        /////////Barra1
        private float b1gbop2; public float B1gbop2 { get { return b1gbop2; } set { b1gbop2 = value; RaisePropertyChange("B1gbop2"); } }
        /////////Barra2
        private float b2gbop2; public float B2gbop2 { get { return b2gbop2; } set { b2gbop2 = value; RaisePropertyChange("B2gbop2"); } }
        /////////Color
        private string cgbop2; public string Cgbop2 { get { return cgbop2; } set { cgbop2 = value; RaisePropertyChange("Cgbop2"); } }
        /////////Foreground
        private string fgbop2; public string Fgbop2 { get { return fgbop2; } set { fgbop2 = value; RaisePropertyChange("Fgbop2"); } }
        /////////Background
        private string bgbop2; public string Bgbop2 { get { return bgbop2; } set { bgbop2 = value; RaisePropertyChange("Bgbop2"); } }

        ///////////////////////////////////////////////////GBOP2
        ///////////////////////////////////////////////////GBOP3

        /////////Valor
        private string gbop3; public string Gbop3 { get { return gbop3; } set { gbop3 = value; RaisePropertyChange("Gbop3"); } }
        /////////Valor Aguja
        private float agbop3; public float Agbop3 { get { return agbop3; } set { agbop3 = value; RaisePropertyChange("Agbop3"); } }
        /////////Barra1
        private float b1gbop3; public float B1gbop3 { get { return b1gbop3; } set { b1gbop3 = value; RaisePropertyChange("B1gbop3"); } }
        /////////Barra2
        private float b2gbop3; public float B2gbop3 { get { return b2gbop3; } set { b2gbop3 = value; RaisePropertyChange("B2gbop3"); } }
        /////////Color
        private string cgbop3; public string Cgbop3 { get { return cgbop3; } set { cgbop3 = value; RaisePropertyChange("Cgbop3"); } }
        /////////Foreground
        private string fgbop3; public string Fgbop3 { get { return fgbop3; } set { fgbop3 = value; RaisePropertyChange("Fgbop3"); } }
        /////////Background
        private string bgbop3; public string Bgbop3 { get { return bgbop3; } set { bgbop3 = value; RaisePropertyChange("Bgbop3"); } }

        ///////////////////////////////////////////////////GBOP3
        ///////////////////////////////////////////////////GBOP4

        /////////Valor
        private string gbop4; public string Gbop4 { get { return gbop4; } set { gbop4 = value; RaisePropertyChange("Gbop4"); } }
        /////////Valor Aguja
        private float agbop4; public float Agbop4 { get { return agbop4; } set { agbop4 = value; RaisePropertyChange("Agbop4"); } }
        /////////Barra1
        private float b1gbop4; public float B1gbop4 { get { return b1gbop4; } set { b1gbop4 = value; RaisePropertyChange("B1gbop4"); } }
        /////////Barra2
        private float b2gbop4; public float B2gbop4 { get { return b2gbop4; } set { b2gbop4 = value; RaisePropertyChange("B2gbop4"); } }
        /////////Color
        private string cgbop4; public string Cgbop4 { get { return cgbop4; } set { cgbop4 = value; RaisePropertyChange("Cgbop4"); } }
        /////////Foreground
        private string fgbop4; public string Fgbop4 { get { return fgbop4; } set { fgbop4 = value; RaisePropertyChange("Fgbop4"); } }
        /////////Background
        private string bgbop4; public string Bgbop4 { get { return bgbop4; } set { bgbop4 = value; RaisePropertyChange("Bgbop4"); } }

        ///////////////////////////////////////////////////GBOP4
        ///////////////////////////////////////////////////ELP1
        
        /////////Color
        private string celp1; public string Celp1 { get { return celp1; } set { celp1 = value; RaisePropertyChange("Celp1"); } }
        /////////Foreground
        private string felp1; public string Felp1 { get { return felp1; } set { felp1 = value; RaisePropertyChange("Felp1"); } }

        ///////////////////////////////////////////////////ELP1
        ///////////////////////////////////////////////////ELP2

        /////////Color
        private string celp2; public string Celp2 { get { return celp2; } set { celp2 = value; RaisePropertyChange("Celp2"); } }
        /////////Foreground
        private string felp2; public string Felp2 { get { return felp2; } set { felp2 = value; RaisePropertyChange("Felp2"); } }

        ///////////////////////////////////////////////////ELP2
        ///////////////////////////////////////////////////ELP3

        /////////Color
        private string celp3; public string Celp3 { get { return celp3; } set { celp3 = value; RaisePropertyChange("Celp3"); } }
        /////////Foreground
        private string felp3; public string Felp3 { get { return felp3; } set { felp3 = value; RaisePropertyChange("Felp3"); } }

        ///////////////////////////////////////////////////ELP3
        ///////////////////////////////////////////////////ELP4

        /////////Color
        private string celp4; public string Celp4 { get { return celp4; } set { celp4 = value; RaisePropertyChange("Celp4"); } }
        /////////Foreground
        private string felp4; public string Felp4 { get { return felp4; } set { felp4 = value; RaisePropertyChange("Felp4"); } }

        ///////////////////////////////////////////////////ELP4
        ///////////////////////////////////////////////////EOQ1

        /////////Valor
        private string eoq1; public string Eoq1 { get { return eoq1; } set { eoq1 = value; RaisePropertyChange("Eoq1"); } }
        /////////Valor Instrumento
        private float veoq1; public float Veoq1 { get { return veoq1; } set { veoq1 = value; RaisePropertyChange("Veoq1"); } }
        /////////Color
        private string ceoq1; public string Ceoq1 { get { return ceoq1; } set { ceoq1 = value; RaisePropertyChange("Ceoq1"); } }
        /////////Foreground
        private string feoq1; public string Feoq1 { get { return feoq1; } set { feoq1 = value; RaisePropertyChange("Feoq1"); } }
        /////////Background
        private string beoq1; public string Beoq1 { get { return beoq1; } set { beoq1 = value; RaisePropertyChange("Beoq1"); } }

        ///////////////////////////////////////////////////EOQ1
        ///////////////////////////////////////////////////EOQ2
        
        /////////Valor
        private string eoq2; public string Eoq2 { get { return eoq2; } set { eoq2 = value; RaisePropertyChange("Eoq2"); } }
        /////////Valor Instrumento
        private float veoq2; public float Veoq2 { get { return veoq2; } set { veoq2 = value; RaisePropertyChange("Veoq2"); } }
        /////////Color
        private string ceoq2; public string Ceoq2 { get { return ceoq2; } set { ceoq2 = value; RaisePropertyChange("Ceoq2"); } }
        /////////Foreground
        private string feoq2; public string Feoq2 { get { return feoq2; } set { feoq2 = value; RaisePropertyChange("Feoq2"); } }
        /////////Background
        private string beoq2; public string Beoq2 { get { return beoq2; } set { beoq2 = value; RaisePropertyChange("Beoq2"); } }

        ///////////////////////////////////////////////////EOQ2
        ///////////////////////////////////////////////////EOQ3

        /////////Valor
        private string eoq3; public string Eoq3 { get { return eoq3; } set { eoq3 = value; RaisePropertyChange("Eoq3"); } }
        /////////Valor Instrumento
        private float veoq3; public float Veoq3 { get { return veoq3; } set { veoq3 = value; RaisePropertyChange("Veoq3"); } }
        /////////Color
        private string ceoq3; public string Ceoq3 { get { return ceoq3; } set { ceoq3 = value; RaisePropertyChange("Ceoq3"); } }
        /////////Foreground
        private string feoq3; public string Feoq3 { get { return feoq3; } set { feoq3 = value; RaisePropertyChange("Feoq3"); } }
        /////////Background
        private string beoq3; public string Beoq3 { get { return beoq3; } set { beoq3 = value; RaisePropertyChange("Beoq3"); } }

        ///////////////////////////////////////////////////EOQ3
        ///////////////////////////////////////////////////EOQ4

        /////////Valor
        private string eoq4; public string Eoq4 { get { return eoq4; } set { eoq4 = value; RaisePropertyChange("Eoq4"); } }
        /////////Valor Instrumento
        private float veoq4; public float Veoq4 { get { return veoq4; } set { veoq4 = value; RaisePropertyChange("Veoq4"); } }
        /////////Color
        private string ceoq4; public string Ceoq4 { get { return ceoq4; } set { ceoq4 = value; RaisePropertyChange("Ceoq4"); } }
        /////////Foreground
        private string feoq4; public string Feoq4 { get { return feoq4; } set { feoq4 = value; RaisePropertyChange("Feoq4"); } }
        /////////Background
        private string beoq4; public string Beoq4 { get { return beoq4; } set { beoq4 = value; RaisePropertyChange("Beoq4"); } }

        ///////////////////////////////////////////////////EOQ4
        ///////////////////////////////////////////////////EOQW1
        
        /////////Color
        private string eoqw1; public string Eoqw1 { get { return eoqw1; } set { eoqw1 = value; RaisePropertyChange("Eoqw1"); } }
        /////////Foreground
        private string feoqw1; public string Feoqw1 { get { return feoqw1; } set { feoqw1 = value; RaisePropertyChange("Feoqw1"); } }
        /////////Texto
        private string teoqw1; public string Teoqw1 { get { return teoqw1; } set { teoqw1 = value; RaisePropertyChange("Teoqw1"); } }

        ///////////////////////////////////////////////////EOQW1
        ///////////////////////////////////////////////////EOQW2

        /////////Color
        private string eoqw2; public string Eoqw2 { get { return eoqw2; } set { eoqw2 = value; RaisePropertyChange("Eoqw2"); } }
        /////////Foreground
        private string feoqw2; public string Feoqw2 { get { return feoqw2; } set { feoqw2 = value; RaisePropertyChange("Feoqw2"); } }
        /////////Texto
        private string teoqw2; public string Teoqw2 { get { return teoqw2; } set { teoqw2 = value; RaisePropertyChange("Teoqw2"); } }

        ///////////////////////////////////////////////////EOQW2
        ///////////////////////////////////////////////////OCFP1

        /////////Valor
        private float ocfp1; public float Ocfp1 { get { return ocfp1; } set { ocfp1 = value; RaisePropertyChange("Ocfp1"); } }
        /////////Markers
        private string mocfp1; public string Mocfp1 { get { return mocfp1; } set { mocfp1 = value; RaisePropertyChange("Mocfp1"); } }
        /////////Label0
        private string l0ocfp1; public string L0ocfp1 { get { return l0ocfp1; } set { l0ocfp1 = value; RaisePropertyChange("L0ocfp1"); } }
        /////////Label1
        private string l1ocfp1; public string L1ocfp1 { get { return l1ocfp1; } set { l1ocfp1 = value; RaisePropertyChange("L1ocfp1"); } }
        /////////Celements
        private string cocfp1; public string Cocfp1 { get { return cocfp1; } set { cocfp1 = value; RaisePropertyChange("Cocfp1"); } }
        
        ///////////////////////////////////////////////////OCFP1
        ///////////////////////////////////////////////////OCFP2

        /////////Valor
        private float ocfp2; public float Ocfp2 { get { return ocfp2; } set { ocfp2 = value; RaisePropertyChange("Ocfp2"); } }
        /////////Markers
        private string mocfp2; public string Mocfp2 { get { return mocfp2; } set { mocfp2 = value; RaisePropertyChange("Mocfp2"); } }
        /////////Label0
        private string l0ocfp2; public string L0ocfp2 { get { return l0ocfp2; } set { l0ocfp2 = value; RaisePropertyChange("L0ocfp2"); } }
        /////////Label1
        private string l1ocfp2; public string L1ocfp2 { get { return l1ocfp2; } set { l1ocfp2 = value; RaisePropertyChange("L1ocfp2"); } }
        /////////Celements
        private string cocfp2; public string Cocfp2 { get { return cocfp2; } set { cocfp2 = value; RaisePropertyChange("Cocfp2"); } }
        
        ///////////////////////////////////////////////////OCFP2
        ///////////////////////////////////////////////////OCFP3

        /////////Valor
        private float ocfp3; public float Ocfp3 { get { return ocfp3; } set { ocfp3 = value; RaisePropertyChange("Ocfp3"); } }
        /////////Markers
        private string mocfp3; public string Mocfp3 { get { return mocfp3; } set { mocfp3 = value; RaisePropertyChange("Mocfp3"); } }
        /////////Label0
        private string l0ocfp3; public string L0ocfp3 { get { return l0ocfp3; } set { l0ocfp3 = value; RaisePropertyChange("L0ocfp3"); } }
        /////////Label1
        private string l1ocfp3; public string L1ocfp3 { get { return l1ocfp3; } set { l1ocfp3 = value; RaisePropertyChange("L1ocfp3"); } }
        /////////Celements
        private string cocfp3; public string Cocfp3 { get { return cocfp3; } set { cocfp3 = value; RaisePropertyChange("Cocfp3"); } }
        
        ///////////////////////////////////////////////////OCFP3
        ///////////////////////////////////////////////////OCFP4

        /////////Valor
        private float ocfp4; public float Ocfp4 { get { return ocfp4; } set { ocfp4 = value; RaisePropertyChange("Ocfp4"); } }
        /////////Markers
        private string mocfp4; public string Mocfp4 { get { return mocfp4; } set { mocfp4 = value; RaisePropertyChange("Mocfp4"); } }
        /////////Label0
        private string l0ocfp4; public string L0ocfp4 { get { return l0ocfp4; } set { l0ocfp4 = value; RaisePropertyChange("L0ocfp4"); } }
        /////////Label1
        private string l1ocfp4; public string L1ocfp4 { get { return l1ocfp4; } set { l1ocfp4 = value; RaisePropertyChange("L1ocfp4"); } }
        /////////Celements
        private string cocfp4; public string Cocfp4 { get { return cocfp4; } set { cocfp4 = value; RaisePropertyChange("Cocfp4"); } }

        ///////////////////////////////////////////////////OCFP4
        ///////////////////////////////////////////////////RUDDER

        /////////Valor
        private float rud; public float Rud { get { return rud; } set { rud = value; RaisePropertyChange("Rud"); } }
        /////////Aguja
        private string arud; public string Arud { get { return arud; } set { arud = value; RaisePropertyChange("Arud"); } }
        /////////Msj
        private string mrud; public string Mrud { get { return mrud; } set { mrud = value; RaisePropertyChange("Mrud"); } }

        ///////////////////////////////////////////////////RUDDER
        ///////////////////////////////////////////////////AILERON

        /////////Valor1
        private float ail1; public float Ail1 { get { return ail1; } set { ail1 = value; RaisePropertyChange("Ail1"); } }
        /////////Aguja1
        private string nail1; public string Nail1 { get { return nail1; } set { nail1 = value; RaisePropertyChange("Nail1"); } }
        /////////Valor2
        private float ail2; public float Ail2 { get { return ail2; } set { ail2 = value; RaisePropertyChange("Ail2"); } }
        /////////Aguja2
        private string nail2; public string Nail2 { get { return nail2; } set { nail2 = value; RaisePropertyChange("Nail2"); } }
        /////////Msj
        private string mail; public string Mail { get { return mail; } set { mail = value; RaisePropertyChange("Mail"); } }

        ///////////////////////////////////////////////////AILERON
        ///////////////////////////////////////////////////ELV

        /////////Valor
        private float elv; public float Elv { get { return elv; } set { elv = value; RaisePropertyChange("Elv"); } }
        /////////Aguja
        private string aelv; public string Aelv { get { return aelv; } set { aelv = value; RaisePropertyChange("Aelv"); } }
        /////////Msj
        private string melv; public string Melv { get { return melv; } set { melv = value; RaisePropertyChange("Melv"); } }

        ///////////////////////////////////////////////////ELV
        ///////////////////////////////////////////////////FLAPS

        /////////Valor
        private float fps; public float Fps { get { return fps; } set { fps = value; RaisePropertyChange("Fps"); } }
        /////////Aguja
        private string afps; public string Afps { get { return afps; } set { afps = value; RaisePropertyChange("Afps"); } }
        /////////Msj
        private string mfps; public string Mfps { get { return mfps; } set { mfps = value; RaisePropertyChange("Mfps"); } }

        ///////////////////////////////////////////////////FLAPS
        ///////////////////////////////////////////////////FFLP

        /////////Msj
        private string fflp; public string Fflp { get { return fflp; } set { fflp = value; RaisePropertyChange("Fflp"); } }

        ///////////////////////////////////////////////////FFLP
        ///////////////////////////////////////////////////BRAKES
        
        /////////Valor
        private string bks; public string Bks { get { return bks; } set { bks = value; RaisePropertyChange("Bks"); } }
        /////////Aguja
        private float abks; public float Abks { get { return abks; } set { abks = value; RaisePropertyChange("Abks"); } }
        /////////Barra1
        private float b1bks; public float B1bks { get { return b1bks; } set { b1bks = value; RaisePropertyChange("B1bks"); } }
        /////////Barra2
        private float b2bks; public float B2bks { get { return b2bks; } set { b2bks = value; RaisePropertyChange("B2bks"); } }
        /////////Norm
        private string nbks; public string Nbks { get { return nbks; } set { nbks = value; RaisePropertyChange("Nbks"); } }
        /////////Color
        private string cbks; public string Cbks { get { return cbks; } set { cbks = value; RaisePropertyChange("Cbks"); } }
        /////////Msj
        private string mbks; public string Mbks { get { return mbks; } set { mbks = value; RaisePropertyChange("Mbks"); } }
        /////////Visible
        private string vbks; public string Vbks { get { return vbks; } set { vbks = value; RaisePropertyChange("Vbks"); } }

        ///////////////////////////////////////////////////BRAKES
        ///////////////////////////////////////////////////EMERGENCY

        /////////Valor
        private string emc; public string Emc { get { return emc; } set { emc = value; RaisePropertyChange("Emc"); } }
        /////////Aguja
        private float aemc; public float Aemc { get { return aemc; } set { aemc = value; RaisePropertyChange("Aemc"); } }
        /////////Barra1
        private float b1emc; public float B1emc { get { return b1emc; } set { b1emc = value; RaisePropertyChange("B1emc"); } }
        /////////Barra2
        private float b2emc; public float B2emc { get { return b2emc; } set { b2emc = value; RaisePropertyChange("B2emc"); } }
        /////////Norm
        private string nemc; public string Nemc { get { return nemc; } set { nemc = value; RaisePropertyChange("Nemc"); } }
        /////////Color
        private string cemc; public string Cemc { get { return cemc; } set { cemc = value; RaisePropertyChange("Cemc"); } }
        /////////Msj
        private string memc; public string Memc { get { return memc; } set { memc = value; RaisePropertyChange("Memc"); } }
        /////////Visible
        private string vemc; public string Vemc { get { return vemc; } set { vemc = value; RaisePropertyChange("Vemc"); } }

        ///////////////////////////////////////////////////EMERGENCY
        ///////////////////////////////////////////////////AUX

        /////////Valor
        private string aux; public string Aux { get { return aux; } set { aux = value; RaisePropertyChange("Aux"); } }
        /////////Aguja
        private float aaux; public float Aaux { get { return aaux; } set { aaux = value; RaisePropertyChange("Aaux"); } }
        /////////Barra1
        private float b1aux; public float B1aux { get { return b1aux; } set { b1aux = value; RaisePropertyChange("B1aux"); } }
        /////////Color
        private string caux; public string Caux { get { return caux; } set { caux = value; RaisePropertyChange("Caux"); } }
        /////////Msj
        private string maux; public string Maux { get { return maux; } set { maux = value; RaisePropertyChange("Maux"); } }
        /////////Visible
        private string vaux; public string Vaux { get { return vaux; } set { vaux = value; RaisePropertyChange("Vaux"); } }

        ///////////////////////////////////////////////////AUX
        ///////////////////////////////////////////////////SYS

        /////////Valor1
        private string sys1; public string Sys1 { get { return sys1; } set { sys1 = value; RaisePropertyChange("Sys1"); } }
        /////////Valor2
        private string sys2; public string Sys2 { get { return sys2; } set { sys2 = value; RaisePropertyChange("Sys2"); } }
        /////////Aguja1
        private float a1sys; public float A1sys { get { return a1sys; } set { a1sys = value; RaisePropertyChange("A1sys"); } }
        /////////Aguja2
        private float a2sys; public float A2sys { get { return a2sys; } set { a2sys = value; RaisePropertyChange("A2sys"); } }
        /////////Barra1
        private float b1sys; public float B1sys { get { return b1sys; } set { b1sys = value; RaisePropertyChange("B1sys"); } }
        /////////Color
        private string csys; public string Csys { get { return csys; } set { csys = value; RaisePropertyChange("Csys"); } }
        /////////Msj
        private string msys; public string Msys { get { return msys; } set { msys = value; RaisePropertyChange("Msys"); } }
        /////////Visible
        private string vsys; public string Vsys { get { return vsys; } set { vsys = value; RaisePropertyChange("Vsys"); } }

        ///////////////////////////////////////////////////SYS
        ///////////////////////////////////////////////////BRUD

        /////////Valor1
        private string brud1; public string Brud1 { get { return brud1; } set { brud1 = value; RaisePropertyChange("Brud1"); } }
        /////////Valor2
        private string brud2; public string Brud2 { get { return brud2; } set { brud2 = value; RaisePropertyChange("Brud2"); } }
        /////////Aguja1
        private float a1brud; public float A1brud { get { return a1brud; } set { a1brud = value; RaisePropertyChange("A1brud"); } }
        /////////Aguja2
        private float a2brud; public float A2brud { get { return a2brud; } set { a2brud = value; RaisePropertyChange("A2brud"); } }
        /////////Barra1
        private float b1brud; public float B1brud { get { return b1brud; } set { b1brud = value; RaisePropertyChange("B1brud"); } }
        /////////Color
        private string cbrud; public string Cbrud { get { return cbrud; } set { cbrud = value; RaisePropertyChange("Cbrud"); } }
        /////////Msj
        private string mbrud; public string Mbrud { get { return mbrud; } set { mbrud = value; RaisePropertyChange("Mbrud"); } }
        /////////Visible
        private string vbrud; public string Vbrud { get { return vbrud; } set { vbrud = value; RaisePropertyChange("Vbrud"); } }

        ///////////////////////////////////////////////////BRUD
        ///////////////////////////////////////////////////TORQUE1

        /////////Valor
        private string tq1; public string Tq1 { get { return tq1; } set { tq1 = value; RaisePropertyChange("Tq1"); } }
        /////////Aguja
        private float atq1; public float Atq1 { get { return atq1; } set { atq1 = value; RaisePropertyChange("Atq1"); } }
        /////////Barra1
        private float b1tq1; public float B1tq1 { get { return b1tq1; } set { b1tq1 = value; RaisePropertyChange("B1tq1"); } }
        /////////Barra2
        private float b2tq1; public float B2tq1 { get { return b2tq1; } set { b2tq1 = value; RaisePropertyChange("B2tq1"); } }
        /////////Color
        private string ctq1; public string Ctq1 { get { return ctq1; } set { ctq1 = value; RaisePropertyChange("Ctq1"); } }
        /////////Msj
        private string mtq1; public string Mtq1 { get { return mtq1; } set { mtq1 = value; RaisePropertyChange("Mtq1"); } }
        /////////Visible
        private string vtq1; public string Vtq1 { get { return vtq1; } set { vtq1 = value; RaisePropertyChange("Vtq1"); } }

        ///////////////////////////////////////////////////TORQUE1
        ///////////////////////////////////////////////////TORQUE2

        /////////Valor
        private string tq2; public string Tq2 { get { return tq2; } set { tq2 = value; RaisePropertyChange("Tq2"); } }
        /////////Aguja
        private float atq2; public float Atq2 { get { return atq2; } set { atq2 = value; RaisePropertyChange("Atq2"); } }
        /////////Barra1
        private float b1tq2; public float B1tq2 { get { return b1tq2; } set { b1tq2 = value; RaisePropertyChange("B1tq2"); } }
        /////////Barra2
        private float b2tq2; public float B2tq2 { get { return b2tq2; } set { b2tq2 = value; RaisePropertyChange("B2tq2"); } }
        /////////Color
        private string ctq2; public string Ctq2 { get { return ctq2; } set { ctq2 = value; RaisePropertyChange("Ctq2"); } }
        /////////Msj
        private string mtq2; public string Mtq2 { get { return mtq2; } set { mtq2 = value; RaisePropertyChange("Mtq2"); } }
        /////////Visible
        private string vtq2; public string Vtq2 { get { return vtq2; } set { vtq2 = value; RaisePropertyChange("Vtq2"); } }

        ///////////////////////////////////////////////////TORQUE2
        ///////////////////////////////////////////////////TORQUE3

        /////////Valor
        private string tq3; public string Tq3 { get { return tq3; } set { tq3 = value; RaisePropertyChange("Tq3"); } }
        /////////Aguja
        private float atq3; public float Atq3 { get { return atq3; } set { atq3 = value; RaisePropertyChange("Atq3"); } }
        /////////Barra1
        private float b1tq3; public float B1tq3 { get { return b1tq3; } set { b1tq3 = value; RaisePropertyChange("B1tq3"); } }
        /////////Barra2
        private float b2tq3; public float B2tq3 { get { return b2tq3; } set { b2tq3 = value; RaisePropertyChange("B2tq3"); } }
        /////////Color
        private string ctq3; public string Ctq3 { get { return ctq3; } set { ctq3 = value; RaisePropertyChange("Ctq3"); } }
        /////////Msj
        private string mtq3; public string Mtq3 { get { return mtq3; } set { mtq3 = value; RaisePropertyChange("Mtq3"); } }
        /////////Visible
        private string vtq3; public string Vtq3 { get { return vtq3; } set { vtq3 = value; RaisePropertyChange("Vtq3"); } }

        ///////////////////////////////////////////////////TORQUE3
        ///////////////////////////////////////////////////TORQUE4

        /////////Valor
        private string tq4; public string Tq4 { get { return tq4; } set { tq4 = value; RaisePropertyChange("Tq4"); } }
        /////////Aguja
        private float atq4; public float Atq4 { get { return atq4; } set { atq4 = value; RaisePropertyChange("Atq4"); } }
        /////////Barra1
        private float b1tq4; public float B1tq4 { get { return b1tq4; } set { b1tq4 = value; RaisePropertyChange("B1tq4"); } }
        /////////Barra2
        private float b2tq4; public float B2tq4 { get { return b2tq4; } set { b2tq4 = value; RaisePropertyChange("B2tq4"); } }
        /////////Color
        private string ctq4; public string Ctq4 { get { return ctq4; } set { ctq4 = value; RaisePropertyChange("Ctq4"); } }
        /////////Msj
        private string mtq4; public string Mtq4 { get { return mtq4; } set { mtq4 = value; RaisePropertyChange("Mtq4"); } }
        /////////Visible
        private string vtq4; public string Vtq4 { get { return vtq4; } set { vtq4 = value; RaisePropertyChange("Vtq4"); } }

        ///////////////////////////////////////////////////TORQUE4
        ///////////////////////////////////////////////////RPM1

        /////////Valor
        private string rp1; public string Rp1 { get { return rp1; } set { rp1 = value; RaisePropertyChange("Rp1"); } }
        /////////Aguja
        private float arp1; public float Arp1 { get { return arp1; } set { arp1 = value; RaisePropertyChange("Arp1"); } }
        /////////Barra1
        private float b1rp1; public float B1rp1 { get { return b1rp1; } set { b1rp1 = value; RaisePropertyChange("B1rp1"); } }
        /////////Color
        private string crp1; public string Crp1 { get { return crp1; } set { crp1 = value; RaisePropertyChange("Crp1"); } }
        /////////Msj
        private string mrp1; public string Mrp1 { get { return mrp1; } set { mrp1 = value; RaisePropertyChange("Mrp1"); } }
        /////////Visible
        private string vrp1; public string Vrp1 { get { return vrp1; } set { vrp1 = value; RaisePropertyChange("Vrp1"); } }

        ///////////////////////////////////////////////////RPM1
        ///////////////////////////////////////////////////RPM2

        /////////Valor
        private string rp2; public string Rp2 { get { return rp2; } set { rp2 = value; RaisePropertyChange("Rp2"); } }
        /////////Aguja
        private float arp2; public float Arp2 { get { return arp2; } set { arp2 = value; RaisePropertyChange("Arp2"); } }
        /////////Barra1
        private float b1rp2; public float B1rp2 { get { return b1rp2; } set { b1rp2 = value; RaisePropertyChange("B1rp2"); } }
        /////////Color
        private string crp2; public string Crp2 { get { return crp2; } set { crp2 = value; RaisePropertyChange("Crp2"); } }
        /////////Msj
        private string mrp2; public string Mrp2 { get { return mrp2; } set { mrp2 = value; RaisePropertyChange("Mrp2"); } }
        /////////Visible
        private string vrp2; public string Vrp2 { get { return vrp2; } set { vrp2 = value; RaisePropertyChange("Vrp2"); } }

        ///////////////////////////////////////////////////RPM2
        ///////////////////////////////////////////////////RPM3

        /////////Valor
        private string rp3; public string Rp3 { get { return rp3; } set { rp3 = value; RaisePropertyChange("Rp3"); } }
        /////////Aguja
        private float arp3; public float Arp3 { get { return arp3; } set { arp3 = value; RaisePropertyChange("Arp3"); } }
        /////////Barra1
        private float b1rp3; public float B1rp3 { get { return b1rp3; } set { b1rp3 = value; RaisePropertyChange("B1rp3"); } }
        /////////Color
        private string crp3; public string Crp3 { get { return crp3; } set { crp3 = value; RaisePropertyChange("Crp3"); } }
        /////////Msj
        private string mrp3; public string Mrp3 { get { return mrp3; } set { mrp3 = value; RaisePropertyChange("Mrp3"); } }
        /////////Visible
        private string vrp3; public string Vrp3 { get { return vrp3; } set { vrp3 = value; RaisePropertyChange("Vrp3"); } }

        ///////////////////////////////////////////////////RPM3
        ///////////////////////////////////////////////////RPM4

        /////////Valor
        private string rp4; public string Rp4 { get { return rp4; } set { rp4 = value; RaisePropertyChange("Rp4"); } }
        /////////Aguja
        private float arp4; public float Arp4 { get { return arp4; } set { arp4 = value; RaisePropertyChange("Arp4"); } }
        /////////Barra1
        private float b1rp4; public float B1rp4 { get { return b1rp4; } set { b1rp4 = value; RaisePropertyChange("B1rp4"); } }
        /////////Color
        private string crp4; public string Crp4 { get { return crp4; } set { crp4 = value; RaisePropertyChange("Crp4"); } }
        /////////Msj
        private string mrp4; public string Mrp4 { get { return mrp4; } set { mrp4 = value; RaisePropertyChange("Mrp4"); } }
        /////////Visible
        private string vrp4; public string Vrp4 { get { return vrp4; } set { vrp4 = value; RaisePropertyChange("Vrp4"); } }

        ///////////////////////////////////////////////////RPM4
        ///////////////////////////////////////////////////TIT1

        /////////Valor
        private string ti1; public string Ti1 { get { return ti1; } set { ti1 = value; RaisePropertyChange("Ti1"); } }
        /////////Aguja
        private float ati1; public float Ati1 { get { return ati1; } set { ati1 = value; RaisePropertyChange("Ati1"); } }
        /////////Barra1
        private float b1ti1; public float B1ti1 { get { return b1ti1; } set { b1ti1 = value; RaisePropertyChange("B1ti1"); } }
        /////////Color
        private string cti1; public string Cti1 { get { return cti1; } set { cti1 = value; RaisePropertyChange("Cti1"); } }
        /////////Msj
        private string mti1; public string Mti1 { get { return mti1; } set { mti1 = value; RaisePropertyChange("Mti1"); } }
        /////////Visible
        private string vti1; public string Vti1 { get { return vti1; } set { vti1 = value; RaisePropertyChange("Vti1"); } }

        ///////////////////////////////////////////////////TIT1
        ///////////////////////////////////////////////////TIT2

        /////////Valor
        private string ti2; public string Ti2 { get { return ti2; } set { ti2 = value; RaisePropertyChange("Ti2"); } }
        /////////Aguja
        private float ati2; public float Ati2 { get { return ati2; } set { ati2 = value; RaisePropertyChange("Ati2"); } }
        /////////Barra1
        private float b1ti2; public float B1ti2 { get { return b1ti2; } set { b1ti2 = value; RaisePropertyChange("B1ti2"); } }
        /////////Color
        private string cti2; public string Cti2 { get { return cti2; } set { cti2 = value; RaisePropertyChange("Cti2"); } }
        /////////Msj
        private string mti2; public string Mti2 { get { return mti2; } set { mti2 = value; RaisePropertyChange("Mti2"); } }
        /////////Visible
        private string vti2; public string Vti2 { get { return vti2; } set { vti2 = value; RaisePropertyChange("Vti2"); } }

        ///////////////////////////////////////////////////TIT2
        ///////////////////////////////////////////////////TIT3

        /////////Valor
        private string ti3; public string Ti3 { get { return ti3; } set { ti3 = value; RaisePropertyChange("Ti3"); } }
        /////////Aguja
        private float ati3; public float Ati3 { get { return ati3; } set { ati3 = value; RaisePropertyChange("Ati3"); } }
        /////////Barra1
        private float b1ti3; public float B1ti3 { get { return b1ti3; } set { b1ti3 = value; RaisePropertyChange("B1ti3"); } }
        /////////Color
        private string cti3; public string Cti3 { get { return cti3; } set { cti3 = value; RaisePropertyChange("Cti3"); } }
        /////////Msj
        private string mti3; public string Mti3 { get { return mti3; } set { mti3 = value; RaisePropertyChange("Mti3"); } }
        /////////Visible
        private string vti3; public string Vti3 { get { return vti3; } set { vti3 = value; RaisePropertyChange("Vti3"); } }

        ///////////////////////////////////////////////////TIT3
        ///////////////////////////////////////////////////TIT4

        /////////Valor
        private string ti4; public string Ti4 { get { return ti4; } set { ti4 = value; RaisePropertyChange("Ti4"); } }
        /////////Aguja
        private float ati4; public float Ati4 { get { return ati4; } set { ati4 = value; RaisePropertyChange("Ati4"); } }
        /////////Barra1
        private float b1ti4; public float B1ti4 { get { return b1ti4; } set { b1ti4 = value; RaisePropertyChange("B1ti4"); } }
        /////////Color
        private string cti4; public string Cti4 { get { return cti4; } set { cti4 = value; RaisePropertyChange("Cti4"); } }
        /////////Msj
        private string mti4; public string Mti4 { get { return mti4; } set { mti4 = value; RaisePropertyChange("Mti4"); } }
        /////////Visible
        private string vti4; public string Vti4 { get { return vti4; } set { vti4 = value; RaisePropertyChange("Vti4"); } }

        ///////////////////////////////////////////////////TIT4
        ///////////////////////////////////////////////////FF1

        /////////Valor
        private string ff1; public string Ff1 { get { return ff1; } set { ff1 = value; RaisePropertyChange("Ff1"); } }
        /////////Msj
        private string mff1; public string Mff1 { get { return mff1; } set { mff1 = value; RaisePropertyChange("Mff1"); } }

        ///////////////////////////////////////////////////FF1
        ///////////////////////////////////////////////////FF2

        /////////Valor
        private string ff2; public string Ff2 { get { return ff2; } set { ff2 = value; RaisePropertyChange("Ff2"); } }
        /////////Msj
        private string mff2; public string Mff2 { get { return mff2; } set { mff2 = value; RaisePropertyChange("Mff2"); } }

        ///////////////////////////////////////////////////FF2
        ///////////////////////////////////////////////////FF3

        /////////Valor
        private string ff3; public string Ff3 { get { return ff3; } set { ff3 = value; RaisePropertyChange("Ff3"); } }
        /////////Msj
        private string mff3; public string Mff3 { get { return mff3; } set { mff3 = value; RaisePropertyChange("Mff3"); } }

        ///////////////////////////////////////////////////FF3
        ///////////////////////////////////////////////////FF1

        /////////Valor
        private string ff4; public string Ff4 { get { return ff4; } set { ff4 = value; RaisePropertyChange("Ff4"); } }
        /////////Msj
        private string mff4; public string Mff4 { get { return mff4; } set { mff4 = value; RaisePropertyChange("Mff4"); } }

        ///////////////////////////////////////////////////FF4
        ///////////////////////////////////////////////////LABEL1

        /////////Msj1
        private string flb1; public string Flb1 { get { return flb1; } set { flb1 = value; RaisePropertyChange("Flb1"); } }
        /////////Msj2
        private string elb1; public string Elb1 { get { return elb1; } set { elb1 = value; RaisePropertyChange("Elb1"); } }
        /////////Msj3
        private string slb1; public string Slb1 { get { return slb1; } set { slb1 = value; RaisePropertyChange("Slb1"); } }

        ///////////////////////////////////////////////////LABEL1
        ///////////////////////////////////////////////////LABEL2

        /////////Msj1
        private string flb2; public string Flb2 { get { return flb2; } set { flb2 = value; RaisePropertyChange("Flb2"); } }
        /////////Msj2
        private string elb2; public string Elb2 { get { return elb2; } set { elb2 = value; RaisePropertyChange("Elb2"); } }
        /////////Msj3
        private string slb2; public string Slb2 { get { return slb2; } set { slb2 = value; RaisePropertyChange("Slb2"); } }

        ///////////////////////////////////////////////////LABEL2
        
        //Variable ins2
        private float val;public float Val{get{return val;}set{val = value;RaisePropertyChange("Val");}}
        //Variable ins2
        //Variable ins1
        private float val2;public float Val2{get{return val2;}set{val2 = value;RaisePropertyChange("Val2");}}
        //Variable ins1
        //Variable ins3
        private float val3;public float Val3{get{return val3;}set{val3 = value;RaisePropertyChange("Val3");}}
        //Variable ins3
        #endregion

        /////////////////////////////////////////////////////////////////////LOGICA////////////////////////////////////////////////////////
        #region
        private void Valor()
        {
            if (com == null)
            {
                com = new ComunicacionClienteEids();
            }
            while (true)
            {
                //////////////////EOT1
                string valor = com.GetInstrumentos._EI_1_19_DN_1.Valor;
                string mensaje = com.GetInstrumentos._EI_1_19_DN_1.Mensaje;
                float ot1 = float.Parse(valor);
                if (ot1 <= 85 && ot1 >= 60 && mensaje == "")
                {
                    Eot1 = valor;
                    Ceot1 = "White";
                    Feot1 = "White";
                    Beot1 = "Black";
                }
                if ((ot1 < 60 && ot1 > 40) || (ot1 < 100 && ot1 > 85) && mensaje == "")
                {
                    Eot1 = valor;
                    Ceot1 = "Yellow";
                    Feot1 = "White";
                    Beot1 = "Black";
                }
                if (ot1 >= 100 || ot1 <= 40 && mensaje == "")
                {
                    Eot1 = valor;
                    Ceot1 = "Red";
                    Feot1 = "White";
                    Beot1 = "Black";
                }
                if (mensaje == "NCD" && ot1 >= -100)
                {
                    Eot1 = "---";
                    Ceot1 = "White";
                    Feot1 = "White";
                    Beot1 = "Black";
                }
                if (mensaje == "FAIL" && ot1 >= -100)
                {
                    Eot1 = "TEMP";
                    Feot1 = "Black";
                    Beot1 = "Red";
                    Ceot1 = "Black";
                }
                //////////////////EOT1
                //////////////////EOT2
                string valor2 = com.GetInstrumentos._EI_1_20_DN_1.Valor;
                string mensaje2 = com.GetInstrumentos._EI_1_20_DN_1.Mensaje;
                float ot2 = float.Parse(valor2);
                if (ot2 <= 85 && ot2 >= 60 && mensaje2 == "")
                {
                    Eot2 = valor2;
                    Ceot2 = "White";
                    Feot2 = "White";
                    Beot2 = "Black";
                }
                if ((ot2 < 60 && ot2 > 40) || (ot2 < 100 && ot2 > 85) && mensaje2 == "")
                {
                    Eot2 = valor2;
                    Ceot2 = "Yellow";
                    Feot2 = "White";
                    Beot2 = "Black";
                }
                if (ot2 >= 100 || ot2 <= 40 && mensaje2 == "")
                {
                    Eot2 = valor2;
                    Ceot2 = "Red";
                    Feot2 = "White";
                    Beot2 = "Black";
                }
                if (mensaje2 == "NCD" && ot2 >= -100)
                {
                    Eot2 = "---";
                    Ceot2 = "White";
                    Feot2 = "White";
                    Beot2 = "Black";
                }
                if (mensaje2 == "FAIL" && ot2 >= -100)
                {
                    Eot2 = "TEMP";
                    Feot2 = "Black";
                    Beot2 = "Red";
                    Ceot2 = "Black";
                }
                //////////////////EOT2
                //////////////////EOT3
                string valor3 = com.GetInstrumentos._EI_1_21_DN_1.Valor;
                string mensaje3 = com.GetInstrumentos._EI_1_21_DN_1.Mensaje;
                float ot3 = float.Parse(valor3);
                if (ot3 <= 85 && ot3 >= 60 && mensaje3 == "")
                {
                    Eot3 = valor3;
                    Ceot3 = "White";
                    Feot3 = "White";
                    Beot3 = "Black";
                }
                if ((ot3 < 60 && ot3 > 40) || (ot3 < 100 && ot3 > 85) && mensaje3 == "")
                {
                    Eot3 = valor3;
                    Ceot3 = "Yellow";
                    Feot3 = "White";
                    Beot3 = "Black";
                }
                if (ot3 >= 100 || ot3 <= 40 && mensaje3 == "")
                {
                    Eot3 = valor3;
                    Ceot3 = "Red";
                    Feot3 = "White";
                    Beot3 = "Black";
                }
                if (mensaje3 == "NCD" && ot3 >= -100)
                {
                    Eot3 = "---";
                    Ceot3 = "White";
                    Feot3 = "White";
                    Beot3 = "Black";
                }
                if (mensaje3 == "FAIL" && ot3 >= -100)
                {
                    Eot3 = "TEMP";
                    Feot3 = "Black";
                    Beot3 = "Red";
                    Ceot3 = "Black";
                }
                //////////////////EOT3
                //////////////////EOT4
                string valor4 = com.GetInstrumentos._EI_1_22_DN_1.Valor;
                string mensaje4 = com.GetInstrumentos._EI_1_22_DN_1.Mensaje;
                float ot4 = float.Parse(valor4);
                if (ot4 <= 85 && ot4 >= 60 && mensaje4 == "")
                {
                    Eot4 = valor4;
                    Ceot4 = "White";
                    Feot4 = "White";
                    Beot4 = "Black";
                }
                if ((ot4 < 60 && ot4 > 40) || (ot4 < 100 && ot4 > 85) && mensaje4 == "")
                {
                    Eot4 = valor4;
                    Ceot4 = "Yellow";
                    Feot4 = "White";
                    Beot4 = "Black";
                }
                if (ot4 >= 100 || ot4 <= 40 && mensaje4 == "")
                {
                    Eot4 = valor4;
                    Ceot4 = "Red";
                    Feot4 = "White";
                    Beot4 = "Black";
                }
                if (mensaje4 == "NCD" && ot4 >= -100)
                {
                    Eot4 = "---";
                    Ceot4 = "White";
                    Feot4 = "White";
                    Beot4 = "Black";
                }
                if (mensaje4 == "FAIL" && ot4 >= -100)
                {
                    Eot4 = "TEMP";
                    Feot4 = "Black";
                    Beot4 = "Red";
                    Ceot4 = "Black";
                }
                //////////////////EOT4
                //////////////////EOP1
                string valor5 = com.GetInstrumentos._EI_1_23_MN_1.Valor;
                string mensaje5 = com.GetInstrumentos._EI_1_23_MN_1.Mensaje;
                float op1 = float.Parse(valor5);              
                if (op1 >= 0 && op1 <= 45 && mensaje5 == "")
                {
                    Eop1 = valor5;
                    Feop1 = "White";
                    Beop1 = "Transparent";
                    float eop1 = Map(op1, 0, 45, 0, 24);
                    Aeop1 = eop1;
                    if ((op1 > 1 && op1 < 50) || (op1 > 60 && op1 < 100))
                    {
                        Ceop1 = "Yellow";
                        B1eop1 = eop1;
                        B2eop1 = 0;
                    }
                    if (op1 <= 40 || op1 >= 100)
                    {
                        Ceop1 = "Red";
                        B1eop1 = 0;
                        B2eop1 = eop1;
                    }
                }
                if (op1 > 45 && op1 <= 55 && mensaje5 == "")
                {
                    Eop1 = valor5;
                    Feop1 = "White";
                    Beop1 = "Transparent";
                    float eop1 = Map(op1, 45, 55, 24, 60);
                    Aeop1 = eop1;
                    if ((op1 > 1 && op1 < 50) || (op1 > 60 && op1 < 100))
                    {
                        Ceop1 = "Yellow";
                        B1eop1 = eop1;
                        B2eop1 = 0;
                    }
                    if (op1 <= 40 || op1 >= 100)
                    {
                        Ceop1 = "Red";
                        B1eop1 = 0;
                        B2eop1 = eop1;
                    }
                }
                if (op1 > 55 && op1 <= 65 && mensaje5 == "")
                {
                    Eop1 = valor5;
                    Feop1 = "White";
                    Beop1 = "Transparent";
                    float eop1 = Map(op1, 55, 65, 60, 96);
                    Aeop1 = eop1;
                    if ((op1 > 1 && op1 < 50) || (op1 > 60 && op1 < 100))
                    {
                        Ceop1 = "Yellow";
                        B1eop1 = eop1;
                        B2eop1 = 0;
                    }
                    if (op1 <= 40 || op1 >= 100)
                    {
                        Ceop1 = "Red";
                        B1eop1 = 0;
                        B2eop1 = eop1;
                    }
                }
                if (op1 > 65 && op1 <= 120 && mensaje5 == "")
                {
                    Eop1 = valor5;
                    Feop1 = "White";
                    Beop1 = "Transparent";
                    float eop1 = Map(op1, 65, 120, 96, 120);
                    Aeop1 = eop1;
                    if ((op1 > 1 && op1 < 50) || (op1 > 60 && op1 < 100))
                    {
                        Ceop1 = "Yellow";
                        B1eop1 = eop1;
                        B2eop1 = 0;
                    }
                    if (op1 <= 40 || op1 >= 100)
                    {
                        Ceop1 = "Red";
                        B1eop1 = 0;
                        B2eop1 = eop1;
                    }
                }
                if (op1 <= 60 && op1 >= 50 && mensaje5 == "")
                {
                    Eop1 = valor5;
                    Feop1 = "White";
                    Beop1 = "Transparent";
                    Ceop1 = "White";
                    B1eop1 = 0;
                    B2eop1 = 0;
                }
                if (mensaje5 == "NCD" && op1 >= 0)
                {
                    Eop1 = "---";
                    Ceop1 = "White";
                    B1eop1 = 0;
                    B2eop1 = 0;
                    Aeop1 = 0;
                }
                if (mensaje5 == "FAIL" && op1 >= 0)
                {
                    Eop1 = "ENG";
                    Feop1 = "Black";
                    Beop1 = "Red";
                    Ceop1 = "Black";
                    B1eop1 = 0;
                    B2eop1 = 0;
                    Aeop1 = 0;
                }
                //////////////////EOP1
                //////////////////EOP2
                string valor6 = com.GetInstrumentos._EI_1_25_MN_1.Valor;
                string mensaje6 = com.GetInstrumentos._EI_1_25_MN_1.Mensaje;
                float op2 = float.Parse(valor6);
                if (op2 >= 0 && op2 <= 45 && mensaje6 == "")
                {
                    Eop2 = valor6;
                    Feop2 = "White";
                    Beop2 = "Transparent";
                    float eop2 = Map(op2, 0, 45, 0, 24);
                    Aeop2 = eop2;
                    if ((op2 > 1 && op2 < 50) || (op2 > 60 && op2 < 100))
                    {
                        Ceop2 = "Yellow";
                        B1eop2 = eop2;
                        B2eop2 = 0;
                    }
                    if (op2 <= 40 || op2 >= 100)
                    {
                        Ceop2 = "Red";
                        B1eop2 = 0;
                        B2eop2 = eop2;
                    }
                }
                if (op2 > 45 && op2 <= 55 && mensaje6 == "")
                {
                    Eop2 = valor6;
                    Feop2 = "White";
                    Beop2 = "Transparent";
                    float eop2 = Map(op2, 45, 55, 24, 60);
                    Aeop2 = eop2;
                    if ((op2 > 1 && op2 < 50) || (op2 > 60 && op2 < 100))
                    {
                        Ceop2 = "Yellow";
                        B1eop2 = eop2;
                        B2eop2 = 0;
                    }
                    if (op2 <= 40 || op2 >= 100)
                    {
                        Ceop2 = "Red";
                        B1eop2 = 0;
                        B2eop2 = eop2;
                    }
                }
                if (op2 > 55 && op2 <= 65 && mensaje6 == "")
                {
                    Eop2 = valor6;
                    Feop2 = "White";
                    Beop2 = "Transparent";
                    float eop2 = Map(op2, 55, 65, 60, 96);
                    Aeop2 = eop2;
                    if ((op2 > 1 && op2 < 50) || (op2 > 60 && op2 < 100))
                    {
                        Ceop2 = "Yellow";
                        B1eop2 = eop2;
                        B2eop2 = 0;
                    }
                    if (op2 <= 40 || op2 >= 100)
                    {
                        Ceop2 = "Red";
                        B1eop2 = 0;
                        B2eop2 = eop2;
                    }
                }
                if (op2 > 65 && op2 <= 120 && mensaje6 == "")
                {
                    Eop2 = valor6;
                    Feop2 = "White";
                    Beop2 = "Transparent";
                    float eop2 = Map(op2, 65, 120, 96, 120);
                    Aeop2 = eop2;
                    if ((op2 > 1 && op2 < 50) || (op2 > 60 && op2 < 100))
                    {
                        Ceop2 = "Yellow";
                        B1eop2 = eop2;
                        B2eop2 = 0;
                    }
                    if (op2 <= 40 || op2 >= 100)
                    {
                        Ceop2 = "Red";
                        B1eop2 = 0;
                        B2eop2 = eop2;
                    }
                }
                if (op2 <= 60 && op2 >= 50 && mensaje6 == "")
                {
                    Eop2 = valor6;
                    Feop2 = "White";
                    Beop2 = "Transparent";
                    Ceop2 = "White";
                    B1eop2 = 0;
                    B2eop2 = 0;
                }
                if (mensaje6 == "NCD" && op2 >= 0)
                {
                    Eop2 = "---";
                    Ceop2 = "White";
                    B1eop2 = 0;
                    B2eop2 = 0;
                    Aeop2 = 0;
                }
                if (mensaje6 == "FAIL" && op2 >= 0)
                {
                    Eop2 = "ENG";
                    Feop2 = "Black";
                    Beop2 = "Red";
                    Ceop2 = "Black";
                    B1eop2 = 0;
                    B2eop2 = 0;
                    Aeop2 = 0;
                }
                //////////////////EOP2
                //////////////////EOP3
                string valor7 = com.GetInstrumentos._EI_1_27_MN_1.Valor;
                string mensaje7 = com.GetInstrumentos._EI_1_27_MN_1.Mensaje;
                float op3 = float.Parse(valor7);
                if (op3 >= 0 && op3 <= 45 && mensaje7 == "")
                {
                    Eop3 = valor7;
                    Feop3 = "White";
                    Beop3 = "Transparent";
                    float eop3 = Map(op3, 0, 45, 0, 24);
                    Aeop3 = eop3;
                    if ((op3 > 1 && op3 < 50) || (op3 > 60 && op3 < 100))
                    {
                        Ceop3 = "Yellow";
                        B1eop3 = eop3;
                        B2eop3 = 0;
                    }
                    if (op3 <= 40 || op3 >= 100)
                    {
                        Ceop3 = "Red";
                        B1eop3 = 0;
                        B2eop3 = eop3;
                    }
                }
                if (op3 > 45 && op3 <= 55 && mensaje7 == "")
                {
                    Eop3 = valor7;
                    Feop3 = "White";
                    Beop3 = "Transparent";
                    float eop3 = Map(op3, 45, 55, 24, 60);
                    Aeop3 = eop3;
                    if ((op3 > 1 && op3 < 50) || (op3 > 60 && op3 < 100))
                    {
                        Ceop3 = "Yellow";
                        B1eop3 = eop3;
                        B2eop3 = 0;
                    }
                    if (op3 <= 40 || op3 >= 100)
                    {
                        Ceop3 = "Red";
                        B1eop3 = 0;
                        B2eop3 = eop3;
                    }
                }
                if (op3 > 55 && op3 <= 65 && mensaje7 == "")
                {
                    Eop3 = valor7;
                    Feop3 = "White";
                    Beop3 = "Transparent";
                    float eop3 = Map(op3, 55, 65, 60, 96);
                    Aeop3 = eop3;
                    if ((op3 > 1 && op3 < 50) || (op3 > 60 && op3 < 100))
                    {
                        Ceop3 = "Yellow";
                        B1eop3 = eop3;
                        B2eop3 = 0;
                    }
                    if (op3 <= 40 || op3 >= 100)
                    {
                        Ceop3 = "Red";
                        B1eop3 = 0;
                        B2eop3 = eop3;
                    }
                }
                if (op3 > 65 && op3 <= 120 && mensaje7 == "")
                {
                    Eop3 = valor7;
                    Feop3 = "White";
                    Beop3 = "Transparent";
                    float eop3 = Map(op3, 65, 120, 96, 120);
                    Aeop3 = eop3;
                    if ((op3 > 1 && op3 < 50) || (op3 > 60 && op3 < 100))
                    {
                        Ceop3 = "Yellow";
                        B1eop3 = eop3;
                        B2eop3 = 0;
                    }
                    if (op3 <= 40 || op3 >= 100)
                    {
                        Ceop3 = "Red";
                        B1eop3 = 0;
                        B2eop3 = eop3;
                    }
                }
                if (op3 <= 60 && op3 >= 50 && mensaje7 == "")
                {
                    Eop3 = valor7;
                    Feop3 = "White";
                    Beop3 = "Transparent";
                    Ceop3 = "White";
                    B1eop3 = 0;
                    B2eop3 = 0;
                }
                if (mensaje7 == "NCD" && op3 >= 0)
                {
                    Eop3 = "---";
                    Ceop3 = "White";
                    B1eop3 = 0;
                    B2eop3 = 0;
                    Aeop3 = 0;
                }
                if (mensaje7 == "FAIL" && op3 >= 0)
                {
                    Eop3 = "ENG";
                    Feop3 = "Black";
                    Beop3 = "Red";
                    Ceop3 = "Black";
                    B1eop3 = 0;
                    B2eop3 = 0;
                    Aeop3 = 0;
                }
                //////////////////EOP3
                //////////////////EOP3
                string valor8 = com.GetInstrumentos._EI_1_29_MN_1.Valor;
                string mensaje8 = com.GetInstrumentos._EI_1_29_MN_1.Mensaje;
                float op4 = float.Parse(valor8);
                if (op4 >= 0 && op4 <= 45 && mensaje8 == "")
                {
                    Eop4 = valor8;
                    Feop4 = "White";
                    Beop4 = "Transparent";
                    float eop4 = Map(op4, 0, 45, 0, 24);
                    Aeop4 = eop4;
                    if ((op4 > 1 && op4 < 50) || (op4 > 60 && op4 < 100))
                    {
                        Ceop4 = "Yellow";
                        B1eop4 = eop4;
                        B2eop4 = 0;
                    }
                    if (op4 <= 40 || op4 >= 100)
                    {
                        Ceop4 = "Red";
                        B1eop4 = 0;
                        B2eop4 = eop4;
                    }
                }
                if (op4 > 45 && op4 <= 55 && mensaje8 == "")
                {
                    Eop4 = valor8;
                    Feop4 = "White";
                    Beop4 = "Transparent";
                    float eop4 = Map(op4, 45, 55, 24, 60);
                    Aeop4 = eop4;
                    if ((op4 > 1 && op4 < 50) || (op4 > 60 && op4 < 100))
                    {
                        Ceop4 = "Yellow";
                        B1eop4 = eop4;
                        B2eop4 = 0;
                    }
                    if (op4 <= 40 || op4 >= 100)
                    {
                        Ceop4 = "Red";
                        B1eop4 = 0;
                        B2eop4 = eop4;
                    }
                }
                if (op4 > 55 && op4 <= 65 && mensaje8 == "")
                {
                    Eop4 = valor8;
                    Feop4 = "White";
                    Beop4 = "Transparent";
                    float eop4 = Map(op4, 55, 65, 60, 96);
                    Aeop4 = eop4;
                    if ((op4 > 1 && op4 < 50) || (op4 > 60 && op4 < 100))
                    {
                        Ceop4 = "Yellow";
                        B1eop4 = eop4;
                        B2eop4 = 0;
                    }
                    if (op4 <= 40 || op4 >= 100)
                    {
                        Ceop4 = "Red";
                        B1eop4 = 0;
                        B2eop4 = eop4;
                    }
                }
                if (op4 > 65 && op4 <= 120 && mensaje8 == "")
                {
                    Eop4 = valor8;
                    Feop4 = "White";
                    Beop4 = "Transparent";
                    float eop4 = Map(op4, 65, 120, 96, 120);
                    Aeop4 = eop4;
                    if ((op4 > 1 && op4 < 50) || (op4 > 60 && op4 < 100))
                    {
                        Ceop4 = "Yellow";
                        B1eop4 = eop4;
                        B2eop4 = 0;
                    }
                    if (op4 <= 40 || op4 >= 100)
                    {
                        Ceop4 = "Red";
                        B1eop4 = 0;
                        B2eop4 = eop4;
                    }
                }
                if (op4 <= 60 && op4 >= 50 && mensaje8 == "")
                {
                    Eop4 = valor8;
                    Feop4 = "White";
                    Beop4 = "Transparent";
                    Ceop4 = "White";
                    B1eop4 = 0;
                    B2eop4 = 0;
                }
                if (mensaje8 == "NCD" && op4 >= 0)
                {
                    Eop4 = "---";
                    Ceop4 = "White";
                    B1eop4 = 0;
                    B2eop4 = 0;
                    Aeop4 = 0;
                }
                if (mensaje8 == "FAIL" && op4 >= 0)
                {
                    Eop4 = "ENG";
                    Feop4 = "Black";
                    Beop4 = "Red";
                    Ceop4 = "Black";
                    B1eop4 = 0;
                    B2eop4 = 0;
                    Aeop4 = 0;
                }
                //////////////////EOP4
                //////////////////GBOP1
                string valor9 = com.GetInstrumentos._EI_1_24_MN_1.Valor;
                string mensaje9 = com.GetInstrumentos._EI_1_24_MN_1.Mensaje;
                float gbp1 = float.Parse(valor9);
                if (gbp1 >= 0 && gbp1 <= 140 && mensaje9 == "")
                {
                    Gbop1 = valor9;
                    Fgbop1 = "White";
                    Bgbop1 = "Transparent";
                    float gbop1 = Map(gbp1, 0, 140, 0, 60);
                    Agbop1 = gbop1;
                    if (gbp1 > 130 && gbp1 < 150)
                    {
                        Cgbop1 = "Yellow";
                        B1gbop1 = gbop1;
                        B2gbop1 = 0;
                    }
                    if (gbp1 <= 130 || gbp1 >= 250)
                    {
                        Cgbop1 = "Red";
                        B1gbop1 = 0;
                        B2gbop1 = gbop1;
                    }
                }
                if (gbp1 > 140 && gbp1 <= 200 && mensaje9 == "")
                {
                    Gbop1 = valor9;
                    Fgbop1 = "White";
                    Bgbop1 = "Transparent";
                    float gbop1 = Map(gbp1, 140, 200, 60, 150);
                    Agbop1 = gbop1;
                    if (gbp1 > 130 && gbp1 < 150)
                    {
                        Cgbop1 = "Yellow";
                        B1gbop1 = gbop1;
                        B2gbop1 = 0;
                    }
                    if (gbp1 <= 130 || gbp1 >= 250)
                    {
                        Cgbop1 = "Red";
                        B1gbop1 = 0;
                        B2gbop1 = gbop1;
                    }
                }
                if (gbp1 > 200 && gbp1 <= 260 && mensaje9 == "")
                {
                    Gbop1 = valor9;
                    Fgbop1 = "White";
                    Bgbop1 = "Transparent";
                    float gbop1 = Map(gbp1, 200, 260, 150, 240);
                    Agbop1 = gbop1;
                    if (gbp1 > 130 && gbp1 < 150)
                    {
                        Cgbop1 = "Yellow";
                        B1gbop1 = gbop1;
                        B2gbop1 = 0;
                    }
                    if (gbp1 <= 130 || gbp1 >= 250)
                    {
                        Cgbop1 = "Red";
                        B1gbop1 = 0;
                        B2gbop1 = gbop1;
                    }
                }
                if (gbp1 > 260 && gbp1 <= 300 && mensaje9 == "")
                {
                    Gbop1 = valor9;
                    Fgbop1 = "White";
                    Bgbop1 = "Transparent";
                    float gbop1 = Map(gbp1, 260, 300, 240, 300);
                    Agbop1 = gbop1;
                    if (gbp1 > 130 && gbp1 < 150)
                    {
                        Cgbop1 = "Yellow";
                        B1gbop1 = gbop1;
                        B2gbop1 = 0;
                    }
                    if (gbp1 <= 130 || gbp1 >= 250)
                    {
                        Cgbop1 = "Red";
                        B1gbop1 = 0;
                        B2gbop1 = gbop1;
                    }
                }
                if (gbp1 <= 250 && gbp1 >= 150 && mensaje9 == "")
                {
                    Gbop1 = valor9;
                    Fgbop1 = "White";
                    Bgbop1 = "Transparent";
                    Cgbop1 = "White";
                    B1gbop1 = 0;
                    B2gbop1 = 0;
                }
                if (mensaje9 == "NCD" && gbp1 >= 0)
                {
                    Gbop1 = "---";
                    Cgbop1 = "White";
                    Fgbop1 = "White";
                    B1gbop1 = 0;
                    B2gbop1 = 0;
                    Agbop1 = 0;
                }
                if (mensaje9 == "FAIL" && gbp1 >= 0)
                {
                    Gbop1 = "ENG";
                    Fgbop1 = "Black";
                    Bgbop1 = "Red";
                    Cgbop1 = "Black";
                    B1gbop1 = 0;
                    B2gbop1 = 0;
                    Agbop1 = 0;
                }
                //////////////////GBOP1
                //////////////////GBOP1
                string valor10 = com.GetInstrumentos._EI_1_26_MN_1.Valor;
                string mensaje10 = com.GetInstrumentos._EI_1_26_MN_1.Mensaje;
                float gbp2 = float.Parse(valor10);
                if (gbp2 >= 0 && gbp2 <= 140 && mensaje10 == "")
                {
                    Gbop2 = valor10;
                    Fgbop2 = "White";
                    Bgbop2 = "Transparent";
                    float gbop2 = Map(gbp2, 0, 140, 0, 60);
                    Agbop2 = gbop2;
                    if (gbp2 > 130 && gbp2 < 150)
                    {
                        Cgbop2 = "Yellow";
                        B1gbop2 = gbop2;
                        B2gbop2 = 0;
                    }
                    if (gbp2 <= 130 || gbp2 >= 250)
                    {
                        Cgbop2 = "Red";
                        B1gbop2 = 0;
                        B2gbop2 = gbop2;
                    }
                }
                if (gbp2 > 140 && gbp2 <= 200 && mensaje10 == "")
                {
                    Gbop2 = valor10;
                    Fgbop2 = "White";
                    Bgbop2 = "Transparent";
                    float gbop2 = Map(gbp2, 140, 200, 60, 150);
                    Agbop2 = gbop2;
                    if (gbp2 > 130 && gbp2 < 150)
                    {
                        Cgbop2 = "Yellow";
                        B1gbop2 = gbop2;
                        B2gbop2 = 0;
                    }
                    if (gbp2 <= 130 || gbp2 >= 250)
                    {
                        Cgbop2 = "Red";
                        B1gbop2 = 0;
                        B2gbop2 = gbop2;
                    }
                }
                if (gbp2 > 200 && gbp2 <= 260 && mensaje10 == "")
                {
                    Gbop2 = valor10;
                    Fgbop2 = "White";
                    Bgbop2 = "Transparent";
                    float gbop2 = Map(gbp2, 200, 260, 150, 240);
                    Agbop2 = gbop2;
                    if (gbp2 > 130 && gbp2 < 150)
                    {
                        Cgbop2 = "Yellow";
                        B1gbop2 = gbop2;
                        B2gbop2 = 0;
                    }
                    if (gbp2 <= 130 || gbp2 >= 250)
                    {
                        Cgbop2 = "Red";
                        B1gbop2 = 0;
                        B2gbop2 = gbop2;
                    }
                }
                if (gbp2 > 260 && gbp2 <= 300 && mensaje10 == "")
                {
                    Gbop2 = valor10;
                    Fgbop2 = "White";
                    Bgbop2 = "Transparent";
                    float gbop2 = Map(gbp2, 260, 300, 240, 300);
                    Agbop2 = gbop2;
                    if (gbp2 > 130 && gbp2 < 150)
                    {
                        Cgbop2 = "Yellow";
                        B1gbop2 = gbop2;
                        B2gbop2 = 0;
                    }
                    if (gbp2 <= 130 || gbp2 >= 250)
                    {
                        Cgbop2 = "Red";
                        B1gbop2 = 0;
                        B2gbop2 = gbop2;
                    }
                }
                if (gbp2 <= 250 && gbp2 >= 150 && mensaje10 == "")
                {
                    Gbop2 = valor10;
                    Fgbop2 = "White";
                    Bgbop2 = "Transparent";
                    Cgbop2 = "White";
                    B1gbop2 = 0;
                    B2gbop2 = 0;
                }
                if (mensaje10 == "NCD" && gbp2 >= 0)
                {
                    Gbop2 = "---";
                    Cgbop2 = "White";
                    Fgbop2 = "White";
                    B1gbop2 = 0;
                    B2gbop2 = 0;
                    Agbop2 = 0;
                }
                if (mensaje10 == "FAIL" && gbp2 >= 0)
                {
                    Gbop2 = "ENG";
                    Fgbop2 = "Black";
                    Bgbop2 = "Red";
                    Cgbop2 = "Black";
                    B1gbop2 = 0;
                    B2gbop2 = 0;
                    Agbop2 = 0;
                }
                //////////////////GBOP2
                //////////////////GBOP3
                string valor11 = com.GetInstrumentos._EI_1_28_MN_1.Valor;
                string mensaje11 = com.GetInstrumentos._EI_1_28_MN_1.Mensaje;
                float gbp3 = float.Parse(valor11);
                if (gbp3 >= 0 && gbp3 <= 140 && mensaje11 == "")
                {
                    Gbop3 = valor11;
                    Fgbop3 = "White";
                    Bgbop3 = "Transparent";
                    float gbop3 = Map(gbp3, 0, 140, 0, 60);
                    Agbop3 = gbop3;
                    if (gbp3 > 130 && gbp3 < 150)
                    {
                        Cgbop3 = "Yellow";
                        B1gbop3 = gbop3;
                        B2gbop3 = 0;
                    }
                    if (gbp3 <= 130 || gbp3 >= 250)
                    {
                        Cgbop3 = "Red";
                        B1gbop3 = 0;
                        B2gbop3 = gbop3;
                    }
                }
                if (gbp3 > 140 && gbp3 <= 200 && mensaje11 == "")
                {
                    Gbop3 = valor11;
                    Fgbop3 = "White";
                    Bgbop3 = "Transparent";
                    float gbop3 = Map(gbp3, 140, 200, 60, 150);
                    Agbop3 = gbop3;
                    if (gbp3 > 130 && gbp3 < 150)
                    {
                        Cgbop3 = "Yellow";
                        B1gbop3 = gbop3;
                        B2gbop3 = 0;
                    }
                    if (gbp3 <= 130 || gbp3 >= 250)
                    {
                        Cgbop3 = "Red";
                        B1gbop3 = 0;
                        B2gbop3 = gbop3;
                    }
                }
                if (gbp3 > 200 && gbp3 <= 260 && mensaje11 == "")
                {
                    Gbop3 = valor11;
                    Fgbop3 = "White";
                    Bgbop3 = "Transparent";
                    float gbop3 = Map(gbp3, 200, 260, 150, 240);
                    Agbop3 = gbop3;
                    if (gbp3 > 130 && gbp3 < 150)
                    {
                        Cgbop3 = "Yellow";
                        B1gbop3 = gbop3;
                        B2gbop3 = 0;
                    }
                    if (gbp3 <= 130 || gbp3 >= 250)
                    {
                        Cgbop3 = "Red";
                        B1gbop3 = 0;
                        B2gbop3 = gbop3;
                    }
                }
                if (gbp3 > 260 && gbp3 <= 300 && mensaje11 == "")
                {
                    Gbop3 = valor11;
                    Fgbop3 = "White";
                    Bgbop3 = "Transparent";
                    float gbop3 = Map(gbp3, 260, 300, 240, 300);
                    Agbop3 = gbop3;
                    if (gbp3 > 130 && gbp3 < 150)
                    {
                        Cgbop3 = "Yellow";
                        B1gbop3 = gbop3;
                        B2gbop3 = 0;
                    }
                    if (gbp3 <= 130 || gbp3 >= 250)
                    {
                        Cgbop3 = "Red";
                        B1gbop3 = 0;
                        B2gbop3 = gbop3;
                    }
                }
                if (gbp3 <= 250 && gbp3 >= 150 && mensaje11 == "")
                {
                    Gbop3 = valor11;
                    Fgbop3 = "White";
                    Bgbop3 = "Transparent";
                    Cgbop3 = "White";
                    B1gbop3 = 0;
                    B2gbop3 = 0;
                }
                if (mensaje11 == "NCD" && gbp3 >= 0)
                {
                    Gbop3 = "---";
                    Cgbop3 = "White";
                    Fgbop3 = "White";
                    B1gbop3 = 0;
                    B2gbop3 = 0;
                    Agbop3 = 0;
                }
                if (mensaje11 == "FAIL" && gbp3 >= 0)
                {
                    Gbop3 = "ENG";
                    Fgbop3 = "Black";
                    Bgbop3 = "Red";
                    Cgbop3 = "Black";
                    B1gbop3 = 0;
                    B2gbop3 = 0;
                    Agbop3 = 0;
                }
                //////////////////GBOP3
                //////////////////GBOP4
                string valor12 = com.GetInstrumentos._EI_1_30_MN_1.Valor;
                string mensaje12 = com.GetInstrumentos._EI_1_30_MN_1.Mensaje;
                float gbp4 = float.Parse(valor12);
                if (gbp4 >= 0 && gbp4 <= 140 && mensaje12 == "")
                {
                    Gbop4 = valor12;
                    Fgbop4 = "White";
                    Bgbop4 = "Transparent";
                    float gbop4 = Map(gbp4, 0, 140, 0, 60);
                    Agbop4 = gbop4;
                    if (gbp4 > 130 && gbp4 < 150)
                    {
                        Cgbop4 = "Yellow";
                        B1gbop4 = gbop4;
                        B2gbop4 = 0;
                    }
                    if (gbp4 <= 130 || gbp4 >= 250)
                    {
                        Cgbop4 = "Red";
                        B1gbop4 = 0;
                        B2gbop4 = gbop4;
                    }
                }
                if (gbp4 > 140 && gbp4 <= 200 && mensaje12 == "")
                {
                    Gbop4 = valor12;
                    Fgbop4 = "White";
                    Bgbop4 = "Transparent";
                    float gbop4 = Map(gbp4, 140, 200, 60, 150);
                    Agbop4 = gbop4;
                    if (gbp4 > 130 && gbp4 < 150)
                    {
                        Cgbop4 = "Yellow";
                        B1gbop4 = gbop4;
                        B2gbop4 = 0;
                    }
                    if (gbp4 <= 130 || gbp4 >= 250)
                    {
                        Cgbop4 = "Red";
                        B1gbop4 = 0;
                        B2gbop4 = gbop4;
                    }
                }
                if (gbp4 > 200 && gbp4 <= 260 && mensaje12 == "")
                {
                    Gbop4 = valor12;
                    Fgbop4 = "White";
                    Bgbop4 = "Transparent";
                    float gbop4 = Map(gbp4, 200, 260, 150, 240);
                    Agbop4 = gbop4;
                    if (gbp4 > 130 && gbp4 < 150)
                    {
                        Cgbop4 = "Yellow";
                        B1gbop4 = gbop4;
                        B2gbop4 = 0;
                    }
                    if (gbp4 <= 130 || gbp4 >= 250)
                    {
                        Cgbop4 = "Red";
                        B1gbop4 = 0;
                        B2gbop4 = gbop4;
                    }
                }
                if (gbp4 > 260 && gbp4 <= 300 && mensaje12 == "")
                {
                    Gbop4 = valor12;
                    Fgbop4 = "White";
                    Bgbop4 = "Transparent";
                    float gbop4 = Map(gbp4, 260, 300, 240, 300);
                    Agbop4 = gbop4;
                    if (gbp4 > 130 && gbp4 < 150)
                    {
                        Cgbop4 = "Yellow";
                        B1gbop4 = gbop4;
                        B2gbop4 = 0;
                    }
                    if (gbp4 <= 130 || gbp4 >= 250)
                    {
                        Cgbop4 = "Red";
                        B1gbop4 = 0;
                        B2gbop4 = gbop4;
                    }
                }
                if (gbp4 <= 250 && gbp4 >= 150 && mensaje12 == "")
                {
                    Gbop4 = valor12;
                    Fgbop4 = "White";
                    Bgbop4 = "Transparent";
                    Cgbop4 = "White";
                    B1gbop4 = 0;
                    B2gbop4 = 0;
                }
                if (mensaje12 == "NCD" && gbp4 >= 0)
                {
                    Gbop4 = "---";
                    Cgbop4 = "White";
                    Fgbop4 = "White";
                    B1gbop4 = 0;
                    B2gbop4 = 0;
                    Agbop4 = 0;
                }
                if (mensaje12 == "FAIL" && gbp4 >= 0)
                {
                    Gbop4 = "ENG";
                    Fgbop4 = "Black";
                    Bgbop4 = "Red";
                    Cgbop4 = "Black";
                    B1gbop4 = 0;
                    B2gbop4 = 0;
                    Agbop4 = 0;
                }
                //////////////////GBOP4
                //////////////////ELP1
                Celp1 = "Black";
                Felp1 = "Black";
                if(op1 < 50 || gbp1 < 150)
                {
                    Celp1 = "Yellow";
                    Felp1 = "Yellow";
                }
                //////////////////ELP1
                //////////////////ELP2
                Celp2 = "Black";
                Felp2 = "Black";
                if (op2 < 50 || gbp2 < 150)
                {
                    Celp2 = "Yellow";
                    Felp2 = "Yellow";
                }
                //////////////////ELP2
                //////////////////ELP3
                Celp3 = "Black";
                Felp3 = "Black";
                if (op3 < 50 || gbp3 < 150)
                {
                    Celp3 = "Yellow";
                    Felp3 = "Yellow";
                }
                //////////////////ELP3
                //////////////////ELP4
                Celp4 = "Black";
                Felp4 = "Black";
                if (op4 < 50 || gbp4 < 150)
                {
                    Celp4 = "Yellow";
                    Felp4 = "Yellow";
                }
                //////////////////ELP4
                //////////////////EOQ1
                string valor13 = com.GetInstrumentos._EI_1_31_DN_1.Valor;
                string mensaje13 = com.GetInstrumentos._EI_1_31_DN_1.Mensaje;
                float eq1 = float.Parse(valor13);
                Eoq1 = valor13;
                Veoq1 = eq1;
                Ceoq1 = "White";
                Feoq1 = "White";
                if (eq1 <= 4 && mensaje13 == "")
                {
                    Ceoq1 = "Red";
                }
                if (mensaje13 == "NCD" && eq1 >= 0)
                {
                    Eoq1 = "---";
                    Ceoq1 = "White";
                    Veoq1 = 0;
                }
                if (mensaje13 == "FAIL" && eq1 >= 0)
                {
                    Beoq1 = "Red";
                    Feoq1 = "Black";
                    Eoq1 = "QTY";
                    Ceoq1 = "White";
                    Veoq1 = 0;
                }
                //////////////////EOQ1
                //////////////////EOQ2
                string valor14 = com.GetInstrumentos._EI_1_32_DN_1.Valor;
                string mensaje14 = com.GetInstrumentos._EI_1_32_DN_1.Mensaje;
                float eq2 = float.Parse(valor14);
                Eoq2 = valor14;
                Veoq2 = eq2;
                Ceoq2 = "White";
                Feoq2 = "White";
                if (eq2 <= 4 && mensaje14 == "")
                {
                    Ceoq2 = "Red";
                }
                if (mensaje14 == "NCD" && eq2 >= 0)
                {
                    Eoq2 = "---";
                    Ceoq2 = "White";
                    Veoq2 = 0;
                }
                if (mensaje14 == "FAIL" && eq2 >= 0)
                {
                    Beoq2 = "Red";
                    Feoq2 = "Black";
                    Eoq2 = "QTY";
                    Ceoq2 = "White";
                    Veoq2 = 0;
                }
                //////////////////EOQ2
                //////////////////EOQ3
                string valor15 = com.GetInstrumentos._EI_1_33_DN_1.Valor;
                string mensaje15 = com.GetInstrumentos._EI_1_33_DN_1.Mensaje;
                float eq3 = float.Parse(valor15);
                Eoq3 = valor15;
                Veoq3 = eq3;
                Ceoq3 = "White";
                Feoq3 = "White";
                if (eq3 <= 4 && mensaje15 == "")
                {
                    Ceoq3 = "Red";
                }
                if (mensaje15 == "NCD" && eq3 >= 0)
                {
                    Eoq3 = "---";
                    Ceoq3 = "White";
                    Veoq3 = 0;
                }
                if (mensaje15 == "FAIL" && eq3 >= 0)
                {
                    Beoq3 = "Red";
                    Feoq3 = "Black";
                    Eoq3 = "QTY";
                    Ceoq3 = "White";
                    Veoq3 = 0;
                }
                //////////////////EOQ3
                //////////////////EOQ4
                string valor16 = com.GetInstrumentos._EI_1_34_DN_1.Valor;
                string mensaje16 = com.GetInstrumentos._EI_1_34_DN_1.Mensaje;
                float eq4 = float.Parse(valor16);
                Eoq4 = valor16;
                Veoq4 = eq4;
                Ceoq4 = "White";
                Feoq4 = "White";
                if (eq4 <= 4 && mensaje16 == "")
                {
                    Ceoq4 = "Red";
                }
                if (mensaje16 == "NCD" && eq4 >= 0)
                {
                    Eoq4 = "---";
                    Ceoq4 = "White";
                    Veoq4 = 0;
                }
                if (mensaje16 == "FAIL" && eq4 >= 0)
                {
                    Beoq4 = "Red";
                    Feoq4 = "Black";
                    Eoq4 = "QTY";
                    Ceoq4 = "White";
                    Veoq4 = 0;
                }
                //////////////////EOQ4
                //////////////////EOQW1
                Eoqw1 = "Black";
                Feoqw1 = "Black";
                if (eq1 <= 4 && eq2 > 4)
                {
                    Eoqw1 = "Yellow";
                    Feoqw1 = "Yellow";
                    Teoqw1 = "1 ENG";
                }
                if (eq1 > 4 && eq2 <= 4)
                {
                    Eoqw1 = "Yellow";
                    Feoqw1 = "Yellow";
                    Teoqw1 = "ENG 2";
                }
                if (eq1 <= 4 && eq2 <= 4)
                {
                    Eoqw1 = "Yellow";
                    Feoqw1 = "Yellow";
                    Teoqw1 = "1 ENG 2";
                }
                //////////////////EOQW1
                //////////////////EOQW2
                Eoqw2 = "Black";
                Feoqw2 = "Black";
                if (eq3 <= 4 && eq4 > 4)
                {
                    Eoqw2 = "Yellow";
                    Feoqw2 = "Yellow";
                    Teoqw2 = "3 ENG";
                }
                if (eq3 > 4 && eq4 <= 4)
                {
                    Eoqw2 = "Yellow";
                    Feoqw2 = "Yellow";
                    Teoqw2 = "ENG 4";
                }
                if (eq3 <= 4 && eq4 <= 4)
                {
                    Eoqw2 = "Yellow";
                    Feoqw2 = "Yellow";
                    Teoqw2 = "3 ENG 4";
                }
                //////////////////EOQW2
                //////////////////OCFP1
                string mensaje17 = com.GetInstrumentos._EI_1_35_DN_1.Mensaje;
                if (mensaje17 == "CLOSED")
                {
                    Ocfp1 = 0;
                    Cocfp1 = "false";
                }
                if (mensaje17 == "MID")
                {
                    Ocfp1 = 5;
                    Cocfp1 = "false";
                }
                if (mensaje17 == "OPEN")
                {
                    Ocfp1 = 10;
                    Cocfp1 = "false";
                }
                if (mensaje17 == "NCD")
                {
                    Mocfp1 = "false";
                    Cocfp1 = "false";
                }
                if (mensaje17 == "FAIL")
                {
                    L0ocfp1 = "Hidden";
                    L1ocfp1 = "Hidden";
                    Mocfp1 = "false";
                    Cocfp1 = "true";
                }
                //////////////////OCFP1
                //////////////////OCFP2
                string mensaje18 = com.GetInstrumentos._EI_1_36_DN_1.Mensaje;
                if (mensaje18 == "CLOSED")
                {
                    Ocfp2 = 0;
                    Cocfp2 = "false";
                }
                if (mensaje18 == "MID")
                {
                    Ocfp2 = 5;
                    Cocfp2 = "false";
                }
                if (mensaje18 == "OPEN")
                {
                    Ocfp2 = 10;
                    Cocfp2 = "false";
                }
                if (mensaje18 == "NCD")
                {
                    Mocfp2 = "false";
                    Cocfp2 = "false";
                }
                if (mensaje18 == "FAIL")
                {
                    L0ocfp2 = "Hidden";
                    L1ocfp2 = "Hidden";
                    Mocfp2 = "false";
                    Cocfp2 = "true";
                }
                //////////////////OCFP2
                //////////////////OCFP3
                string mensaje19 = com.GetInstrumentos._EI_1_37_DN_1.Mensaje;
                if (mensaje19 == "CLOSED")
                {
                    Ocfp3 = 0;
                    Cocfp3 = "false";
                }
                if (mensaje19 == "MID")
                {
                    Ocfp3 = 5;
                    Cocfp3 = "false";
                }
                if (mensaje19 == "OPEN")
                {
                    Ocfp3 = 10;
                    Cocfp3 = "false";
                }
                if (mensaje19 == "NCD")
                {
                    Mocfp3 = "false";
                    Cocfp3 = "false";
                }
                if (mensaje19 == "FAIL")
                {
                    L0ocfp3 = "Hidden";
                    L1ocfp3 = "Hidden";
                    Mocfp3 = "false";
                    Cocfp3 = "true";
                }
                //////////////////OCFP3
                //////////////////OCFP4
                string mensaje20 = com.GetInstrumentos._EI_1_38_DN_1.Mensaje;
                if (mensaje20 == "CLOSED")
                {
                    Ocfp4 = 0;
                    Cocfp4 = "false";
                }
                if (mensaje20 == "MID")
                {
                    Ocfp4 = 5;
                    Cocfp4 = "false";
                }
                if (mensaje20 == "OPEN")
                {
                    Ocfp4 = 10;
                    Cocfp4 = "false";
                }
                if (mensaje20 == "NCD")
                {
                    Mocfp4 = "false";
                    Cocfp4 = "false";
                }
                if (mensaje20 == "FAIL")
                {
                    L0ocfp4 = "Hidden";
                    L1ocfp4 = "Hidden";
                    Mocfp4 = "false";
                    Cocfp4 = "true";
                }
                //////////////////OCFP4
                //////////////////RUDDER
                string valor21 = com.GetInstrumentos._EI_1_39_MN_1.Valor;
                string mensaje21 = com.GetInstrumentos._EI_1_39_MN_1.Mensaje;
                float rd = float.Parse(valor21);
                Rud = rd;
                Arud = "true";
                Mrud = "Hidden";
                if(mensaje21 == "NCD" && rd <= 1000)
                {
                    Mrud = "Hidden";
                    Arud = "false";
                }
                if(mensaje21 == "FAIL" && rd <= 1000)
                {
                    Mrud = "Visible";
                }
                //////////////////RUDDER
                //////////////////AILERON
                string valor20 = com.GetInstrumentos._EI_1_40_MN_1.Valor1;
                string valor22 = com.GetInstrumentos._EI_1_40_MN_1.Valor2;
                string mensaje22 = com.GetInstrumentos._EI_1_40_MN_1.Mensaje;
                float al1 = float.Parse(valor20);
                float al2 = float.Parse(valor22);
                Ail1 = al1;
                Ail2 = al2;
                Nail1 = "true";
                Nail2 = "true";
                Mail = "Hidden";
                if (mensaje22 == "NCD" && al1 <= 1000 && al2 <= 1000)
                {
                    Mail = "Hidden";
                    Nail1 = "false";
                    Nail2 = "false";
                }
                if (mensaje22 == "FAIL" && al1 <= 1000 && al2 <= 1000)
                {
                    Mail = "Visible";
                }
                //////////////////AILERON
                //////////////////ELV
                string valor23 = com.GetInstrumentos._EI_1_41_MN_1.Valor;
                string mensaje23 = com.GetInstrumentos._EI_1_41_MN_1.Mensaje;
                float ev = float.Parse(valor23);
                Elv = ev;
                Aelv = "true";
                Melv = "Hidden";
                if (mensaje23 == "NCD" && ev <= 1000)
                {
                    Melv = "Hidden";
                    Aelv = "false";
                }
                if (mensaje23 == "FAIL" && ev <= 1000)
                {
                    Melv = "Visible";
                }
                //////////////////ELV
                //////////////////FLAPS
                string valor24 = com.GetInstrumentos._EI_1_46_MN_1.Valor;
                string mensaje24 = com.GetInstrumentos._EI_1_46_MN_1.Mensaje;
                float fp = float.Parse(valor24);
                Fps = fp;
                Afps = "true";
                Mfps = "Hidden";
                if (mensaje24 == "NCD" && fp <= 1000)
                {
                    Mfps = "Hidden";
                    Afps = "false";
                }
                if (mensaje24 == "FAIL" && fp <= 1000)
                {
                    Mfps = "Visible";
                }
                //////////////////FLAPS
                //////////////////FFLP
                string valor25 = com.GetInstrumentos._EI_1_47_DN_1.Valor1;
                string valor26 = com.GetInstrumentos._EI_1_47_DN_1.Valor2;
                string valor27 = com.GetInstrumentos._EI_1_47_DN_1.Valor3;
                string valor28 = com.GetInstrumentos._EI_1_47_DN_1.Valor4;
                int f1 = int.Parse(valor25);
                int f2 = int.Parse(valor26);
                int f3 = int.Parse(valor27);
                int f4 = int.Parse(valor28);
                if (f1 == 0 && f2 == 0 && f3 == 0 && f4 == 0) { Fflp = "FUEL PRESS"; }
                if (f1 == 0 && f2 == 0 && f3 == 0 && f4 == 1) { Fflp = "FUEL PRESS" + " " + " " + " " + "4"; }
                if (f1 == 0 && f2 == 0 && f3 == 1 && f4 == 0) { Fflp = "FUEL PRESS" + " " + " " + "3" + " "; }
                if (f1 == 0 && f2 == 0 && f3 == 1 && f4 == 1) { Fflp = "FUEL PRESS" + " " + " " + "3" + "4"; }
                if (f1 == 0 && f2 == 1 && f3 == 0 && f4 == 0) { Fflp = "FUEL PRESS" + " " + "2" + " " + " "; }
                if (f1 == 0 && f2 == 1 && f3 == 0 && f4 == 1) { Fflp = "FUEL PRESS" + " " + "2" + " " + "4"; }
                if (f1 == 0 && f2 == 1 && f3 == 1 && f4 == 0) { Fflp = "FUEL PRESS" + " " + "2" + "3" + " "; }
                if (f1 == 0 && f2 == 1 && f3 == 1 && f4 == 1) { Fflp = "FUEL PRESS" + " " + "2" + "3" + "4"; }
                if (f1 == 1 && f2 == 0 && f3 == 0 && f4 == 0) { Fflp = "FUEL PRESS" + "1" + " " + " " + " "; }
                if (f1 == 1 && f2 == 0 && f3 == 0 && f4 == 1) { Fflp = "FUEL PRESS" + "1" + " " + " " + "4"; }
                if (f1 == 1 && f2 == 0 && f3 == 1 && f4 == 0) { Fflp = "FUEL PRESS" + "1" + " " + "3" + " "; }
                if (f1 == 1 && f2 == 0 && f3 == 1 && f4 == 1) { Fflp = "FUEL PRESS" + "1" + " " + "3" + "4"; }
                if (f1 == 1 && f2 == 1 && f3 == 0 && f4 == 0) { Fflp = "FUEL PRESS" + "1" + "2" + " " + " "; }
                if (f1 == 1 && f2 == 1 && f3 == 0 && f4 == 1) { Fflp = "FUEL PRESS" + "1" + "2" + " " + "4"; }
                if (f1 == 1 && f2 == 1 && f3 == 1 && f4 == 0) { Fflp = "FUEL PRESS" + "1" + "2" + "3" + " "; }
                if (f1 == 1 && f2 == 1 && f3 == 1 && f4 == 1) { Fflp = "FUEL PRESS" + "1" + "2" + "3" + "4"; }
                //////////////////FFLP
                //////////////////BRAKES
                string valor29 = com.GetInstrumentos._EI_1_42_MN_1.Valor;
                string mensaje29 = com.GetInstrumentos._EI_1_42_MN_1.Mensaje;
                float bk = float.Parse(valor29);
                if(bk >= 2200 && bk <= 2900 && mensaje29 == "")
                {
                    Bks = valor29;
                    float brakes = Map(bk, 2200, 2900, 750, 2500);
                    Abks = brakes;
                    B1bks = 0;
                    B2bks = 0;
                    Nbks = "GreenYellow";
                    Cbks = "White";
                    Mbks = "Hidden";
                    Vbks = "true";
                }
                if (bk > 2900 && bk <= 3200 && mensaje29 == "")
                {
                    Bks = valor29;
                    float brakes = Map(bk, 2900, 3200, 2500, 4250);
                    Abks = brakes;
                    B1bks = 0;
                    B2bks = 0;
                    Nbks = "GreenYellow";
                    Cbks = "White";
                    Mbks = "Hidden";
                    Vbks = "true";
                }
                if (bk >= 0 && bk < 2200 && mensaje29 == "")
                {
                    Bks = valor29;
                    float brakes = Map(bk, 0, 2200, 0, 750);
                    Abks = brakes;
                    B1bks = brakes;
                    B2bks = 0;
                    Nbks = "GreenYellow";
                    Cbks = "Yellow";
                    Mbks = "Hidden";
                    Vbks = "true";
                }
                if(bk >3200 && bk <= 5000 && mensaje29 == "")
                {
                    Bks = valor29;
                    float brakes = Map(bk, 3200, 5000, 4250, 5000);
                    Abks = brakes;
                    B1bks = 0;
                    B2bks = brakes;
                    Nbks = "GreenYellow";
                    Cbks = "Red";
                    Mbks = "Hidden";
                    Vbks = "true";
                }
                if(mensaje29 == "NCD" && bk >= 0)
                {
                    Bks = "---";
                    Vbks = "false";
                    Nbks = "Black";
                    Cbks = "White";
                    Mbks = "Hidden";
                }
                if (mensaje29 == "FAIL" && bk >= 0)
                {
                    Mbks = "Visible";
                    Vbks = "false";
                }
                //////////////////BRAKES
                //////////////////EMERGENCY
                string valor30 = com.GetInstrumentos._EI_1_43_MN_1.Valor;
                string mensaje30 = com.GetInstrumentos._EI_1_43_MN_1.Mensaje;
                float ec = float.Parse(valor30);
                if (ec >= 2900 && ec <= 3050 && mensaje30 == "")
                {
                    Emc = valor30;
                    float emer = Map(ec, 2900, 3050, 750, 2500);
                    Aemc = emer;
                    B1emc = 0;
                    B2emc = 0;
                    Nemc = "GreenYellow";
                    Cemc = "White";
                    Memc = "Hidden";
                    Vemc = "true";
                }
                if (ec > 3050 && ec <= 3200 && mensaje30 == "")
                {
                    Emc = valor30;
                    float emer = Map(ec, 3050, 3200, 2500, 4250);
                    Aemc = emer;
                    B1emc = 0;
                    B2emc = 0;
                    Nemc = "GreenYellow";
                    Cemc = "White";
                    Memc = "Hidden";
                    Vemc = "true";
                }
                if (ec >= 0 && ec < 2900 && mensaje30 == "")
                {
                    Emc = valor30;
                    float emer = Map(ec, 0, 2900, 0, 750);
                    Aemc = emer;
                    B1emc = emer;
                    B2emc = 0;
                    Nemc = "GreenYellow";
                    Cemc = "Yellow";
                    Memc = "Hidden";
                    Vemc = "true";
                }
                if (ec > 3200 && ec <= 5000 && mensaje30 == "")
                {
                    Emc = valor30;
                    float emer = Map(ec, 3200, 5000, 4250, 5000);
                    Aemc = emer;
                    B1emc = 0;
                    B2emc = emer;
                    Nemc = "GreenYellow";
                    Cemc = "Red";
                    Memc = "Hidden";
                    Vemc = "true";
                }
                if (mensaje30 == "NCD" && ec >= 0)
                {
                    Emc = "---";
                    Vemc = "false";
                    Nemc = "Black";
                    Cemc = "White";
                    Memc = "Hidden";
                }
                if (mensaje30 == "FAIL" && ec >= 0)
                {
                    Memc = "Visible";
                    Vemc = "false";
                }
                //////////////////EMERGENCY
                //////////////////AUX
                string valor31 = com.GetInstrumentos._EI_1_48_MN_1.Valor;
                string mensaje31 = com.GetInstrumentos._EI_1_48_MN_1.Mensaje;
                float ax = float.Parse(valor31);
                if(ax >= 0 && ax <= 3500 && mensaje31 == "")
                {
                    Aux = valor31;
                    Aaux = ax;
                    B1aux = 0;
                    Caux = "White";
                    Maux = "Hidden";
                    Vaux = "true";
                }
                if(ax > 3500 && ax <= 4000 && mensaje31 == "")
                {
                    Aux = valor31;
                    Aaux = ax;
                    B1aux = ax;
                    Caux = "Red";
                    Maux = "Hidden";
                    Vaux = "true";
                }
                if(mensaje31 == "NCD" && ax >= 0)
                {
                    Aux = "---";
                    Vaux = "false";
                    Caux = "White";
                    Maux = "Hidden";
                }
                if(mensaje31 == "FAIL" && ax >= 0)
                {
                    Maux = "Visible";
                    Vaux = "false";
                }
                //////////////////AUX
                //////////////////SYS
                string valor32 = com.GetInstrumentos._EI_1_44_MN_1.Valor1;
                string valor33 = com.GetInstrumentos._EI_1_44_MN_1.Valor2;
                string mensaje32 = com.GetInstrumentos._EI_1_44_MN_1.Mensaje;
                float su = float.Parse(valor32);
                float sb = float.Parse(valor33);
                if(0 <= su && su <= 3500 && 0 <= sb && sb <= 3500 && mensaje32 == "")
                {
                    Sys1 = valor32;
                    Sys2 = valor33;
                    A1sys = su;
                    A2sys = sb;
                    B1sys = 0;
                    Csys = "White";
                    Msys = "Hidden";
                    Vsys = "true";
                }
                if (0 <= su && su <= 3500 && 3500 < sb && sb <= 4000 && mensaje32 == "")
                {
                    Sys1 = valor32;
                    Sys2 = valor33;
                    A1sys = su;
                    A2sys = sb;
                    B1sys = sb;
                    Csys = "Red";
                    Msys = "Hidden";
                    Vsys = "true";
                }
                if (3500 < su && su <= 4000 && 0 <= sb && sb <= 3500 && mensaje32 == "")
                {
                    Sys1 = valor32;
                    Sys2 = valor33;
                    A1sys = su;
                    A2sys = sb;
                    B1sys = su;
                    Csys = "Red";
                    Msys = "Hidden";
                    Vsys = "true";
                }
                if (3500 < su && su <= 4000 && 3500 < sb && sb <= 4000 && mensaje32 == "")
                {
                    Sys1 = valor32;
                    Sys2 = valor33;
                    A1sys = su;
                    A2sys = sb;
                    if (su > sb) { B1sys = su; }
                    if (sb > su) { B1sys = sb; }
                    Csys = "Red";
                    Msys = "Hidden";
                    Vsys = "true";
                }
                if(mensaje32 == "NCD" && su >= 0 && sb >=0)
                {
                    Sys1 = "---";
                    Sys2 = "---";
                    Vsys = "false";
                    Csys = "White";
                    Msys = "Hidden";
                }
                if (mensaje32 == "FAIL" && su >= 0 && sb >= 0)
                {
                    Msys = "Visible";
                    Vsys = "false";
                }
                //////////////////SYS
                //////////////////BRUD
                string valor34 = com.GetInstrumentos._EI_1_45_MN_1.Valor1;
                string valor35 = com.GetInstrumentos._EI_1_45_MN_1.Valor2;
                string mensaje34 = com.GetInstrumentos._EI_1_45_MN_1.Mensaje;
                float bu = float.Parse(valor34);
                float bb = float.Parse(valor35);
                if (0 <= bu && bu <= 3500 && 0 <= bb && bb <= 3500 && mensaje34 == "")
                {
                    Brud1 = valor34;
                    Brud2 = valor35;
                    A1brud = bu;
                    A2brud = bb;
                    B1brud = 0;
                    Cbrud = "White";
                    Mbrud = "Hidden";
                    Vbrud = "true";
                }
                if (0 <= bu && bu <= 3500 && 3500 < bb && bb <= 4000 && mensaje34 == "")
                {
                    Brud1 = valor34;
                    Brud2 = valor35;
                    A1brud = bu;
                    A2brud = bb;
                    B1brud = bb;
                    Cbrud = "Red";
                    Mbrud = "Hidden";
                    Vbrud = "true";
                }
                if (3500 < bu && bu <= 4000 && 0 <= bb && bb <= 3500 && mensaje34 == "")
                {
                    Brud1 = valor34;
                    Brud2 = valor35;
                    A1brud = bu;
                    A2brud = bb;
                    B1brud = bu;
                    Cbrud = "Red";
                    Mbrud = "Hidden";
                    Vbrud = "true";
                }
                if (3500 < bu && bu <= 4000 && 3500 < bb && bb <= 4000 && mensaje34 == "")
                {
                    Brud1 = valor34;
                    Brud2 = valor35;
                    A1brud = bu;
                    A2brud = bb;
                    if (bu > bb) { B1brud = bu; }
                    if (bb > bu) { B1brud = bb; }
                    Cbrud = "Red";
                    Mbrud = "Hidden";
                    Vbrud = "true";
                }
                if (mensaje34 == "NCD" && bu >= 0 && bb >= 0)
                {
                    Brud1 = "---";
                    Brud2 = "---";
                    Vbrud = "false";
                    Cbrud = "White";
                    Mbrud = "Hidden";
                }
                if (mensaje34 == "FAIL" && bu >= 0 && bb >= 0)
                {
                    Mbrud =  "Visible";
                    Vbrud = "false";
                }
                //////////////////BRUD
                //////////////////TORQUE1
                string valor1i = com.GetInstrumentos._EI_1_1_MN_1.Valor;
                string mensaje1i = com.GetInstrumentos._EI_1_1_MN_1.Mensaje;
                float torque1i = float.Parse(valor1i);
                if (torque1i >= 0 && torque1i <= 20 && mensaje1i == "")
                {
                    Tq1 = valor1i;
                    Atq1 = torque1i;
                    B1tq1 = 0;
                    B2tq1 = 0;
                    Ctq1 = "White";
                    Mtq1 = "Hidden";
                    Vtq1 = "true";
                }
                if (torque1i < 0 && mensaje1i == "")
                {
                    Tq1 = valor1i;
                    Atq1 = torque1i;
                    B1tq1 = 0;
                    B2tq1 = torque1i;
                    Ctq1 = "Yellow";
                    Mtq1 = "Hidden";
                    Vtq1 = "true";
                }
                if (torque1i > 20 && mensaje1i == "")
                {
                    Tq1 = valor1i;
                    Atq1 = torque1i;
                    B1tq1 = torque1i;
                    B2tq1 = 0;
                    Ctq1 = "Red";
                    Mtq1 = "Hidden";
                    Vtq1 = "true";
                }
                if (mensaje1i == "NCD" && torque1i < 50)
                {
                    Tq1 = "---";
                    Ctq1 = "White";
                    Mtq1 = "Hidden";
                    Vtq1 = "false";
                }
                if (mensaje1i == "FAIL" && torque1i < 50)
                {
                    Mtq1 = "Visible";
                }
                //////////////////TORQUE1
                //////////////////TORQUE2
                string valor2i = com.GetInstrumentos._EI_1_2_MN_1.Valor;
                string mensaje2i = com.GetInstrumentos._EI_1_2_MN_1.Mensaje;
                float torque2i = float.Parse(valor2i);
                if (torque2i >= 0 && torque2i <= 20 && mensaje2i == "")
                {
                    Tq2 = valor2i;
                    Atq2 = torque2i;
                    B1tq2 = 0;
                    B2tq2 = 0;
                    Ctq2 = "White";
                    Mtq2 = "Hidden";
                    Vtq2 = "true";
                }
                if (torque2i < 0 && mensaje2i == "")
                {
                    Tq2 = valor2i;
                    Atq2 = torque2i;
                    B1tq2 = 0;
                    B2tq2 = torque2i;
                    Ctq2 = "Yellow";
                    Mtq2 = "Hidden";
                    Vtq2 = "true";
                }
                if (torque2i > 20 && mensaje2i == "")
                {
                    Tq2 = valor2i;
                    Atq2 = torque2i;
                    B1tq2 = torque2i;
                    B2tq2 = 0;
                    Ctq2 = "Red";
                    Mtq2 = "Hidden";
                    Vtq2 = "true";
                }
                if (mensaje2i == "NCD" && torque2i < 50)
                {
                    Tq2 = "---";
                    Ctq2 = "White";
                    Mtq2 = "Hidden";
                    Vtq2 = "false";
                }
                if (mensaje2i == "FAIL" && torque2i < 50)
                {
                    Mtq2 = "Visible";
                }
                //////////////////TORQUE2
                //////////////////TORQUE3
                string valor3i = com.GetInstrumentos._EI_1_3_MN_1.Valor;
                string mensaje3i = com.GetInstrumentos._EI_1_3_MN_1.Mensaje;
                float torque3i = float.Parse(valor3i);
                if (torque3i >= 0 && torque3i <= 20 && mensaje3i == "")
                {
                    Tq3 = valor3i;
                    Atq3 = torque3i;
                    B1tq3 = 0;
                    B2tq3 = 0;
                    Ctq3 = "White";
                    Mtq3 = "Hidden";
                    Vtq3 = "true";
                }
                if (torque3i < 0 && mensaje3i == "")
                {
                    Tq3 = valor3i;
                    Atq3 = torque3i;
                    B1tq3 = 0;
                    B2tq3 = torque3i;
                    Ctq3 = "Yellow";
                    Mtq3 = "Hidden";
                    Vtq3 = "true";
                }
                if (torque3i > 20 && mensaje3i == "")
                {
                    Tq3 = valor3i;
                    Atq3 = torque3i;
                    B1tq3 = torque3i;
                    B2tq3 = 0;
                    Ctq3 = "Red";
                    Mtq3 = "Hidden";
                    Vtq3 = "true";
                }
                if (mensaje3i == "NCD" && torque3i < 50)
                {
                    Tq3 = "---";
                    Ctq3 = "White";
                    Mtq3 = "Hidden";
                    Vtq3 = "false";
                }
                if (mensaje3i == "FAIL" && torque3i < 50)
                {
                    Mtq3 = "Visible";
                }
                //////////////////TORQUE3
                //////////////////TORQUE4
                string valor4i = com.GetInstrumentos._EI_1_4_MN_1.Valor;
                string mensaje4i = com.GetInstrumentos._EI_1_4_MN_1.Mensaje;
                float torque4i = float.Parse(valor4i);
                if (torque4i >= 0 && torque4i <= 20 && mensaje4i == "")
                {
                    Tq4 = valor4i;
                    Atq4 = torque4i;
                    B1tq4 = 0;
                    B2tq4 = 0;
                    Ctq4 = "White";
                    Mtq4 = "Hidden";
                    Vtq4 = "true";
                }
                if (torque4i < 0 && mensaje4i == "")
                {
                    Tq4 = valor4i;
                    Atq4 = torque4i;
                    B1tq4 = 0;
                    B2tq4 = torque4i;
                    Ctq4 = "Yellow";
                    Mtq4 = "Hidden";
                    Vtq4 = "true";
                }
                if (torque4i > 20 && mensaje4i == "")
                {
                    Tq4 = valor4i;
                    Atq4 = torque4i;
                    B1tq4 = torque4i;
                    B2tq4 = 0;
                    Ctq4 = "Red";
                    Mtq4 = "Hidden";
                    Vtq4 = "true";
                }
                if (mensaje4i == "NCD" && torque4i < 50)
                {
                    Tq4 = "---";
                    Ctq4 = "White";
                    Mtq4 = "Hidden";
                    Vtq4 = "false";
                }
                if (mensaje4i == "FAIL" && torque4i < 50)
                {
                    Mtq4 = "Visible";
                }
                //////////////////TORQUE4
                //////////////////RPM1
                string valor5i = com.GetInstrumentos._EI_1_5_MN_1.Valor;
                string mensaje5i = com.GetInstrumentos._EI_1_5_MN_1.Mensaje;
                float rpm1i = float.Parse(valor5i);
                if (rpm1i >= 98 && rpm1i <= 102 && mensaje5i == "")
                {
                    Rp1 = valor5i;
                    Arp1 = rpm1i;
                    B1rp1 = 0;
                    Crp1 = "White";
                    Mrp1 = "Hidden";
                    Vrp1 = "true";
                }
                if (rpm1i < 98 || rpm1i > 102 && mensaje5i == "")
                {
                    Rp1 = valor5i;
                    Arp1 = rpm1i;
                    B1rp1 = rpm1i;
                    Crp1 = "Red";
                    Mrp1 = "Hidden";
                    Vrp1 = "true";
                }
                if (mensaje5i == "NCD" && rpm1i < 150)
                {
                    Rp1 = "---";
                    Crp1 = "White";
                    Mrp1 = "Hidden";
                    Vrp1 = "false";
                }
                if (mensaje5i == "FAIL" && rpm1i < 150)
                {
                    Mrp1 = "Visible";
                }
                //////////////////RPM1
                //////////////////RPM2
                string valor6i = com.GetInstrumentos._EI_1_6_MN_1.Valor;
                string mensaje6i = com.GetInstrumentos._EI_1_6_MN_1.Mensaje;
                float rpm2i = float.Parse(valor6i);
                if (rpm2i >= 98 && rpm2i <= 102 && mensaje6i == "")
                {
                    Rp2 = valor6i;
                    Arp2 = rpm2i;
                    B1rp2 = 0;
                    Crp2 = "White";
                    Mrp2 = "Hidden";
                    Vrp2 = "true";
                }
                if (rpm2i < 98 || rpm2i > 102 && mensaje6i == "")
                {
                    Rp2 = valor6i;
                    Arp2 = rpm2i;
                    B1rp2 = rpm2i;
                    Crp2 = "Red";
                    Mrp2 = "Hidden";
                    Vrp2 = "true";
                }
                if (mensaje6i == "NCD" && rpm2i < 150)
                {
                    Rp2 = "---";
                    Crp2 = "White";
                    Mrp2 = "Hidden";
                    Vrp2 = "false";
                }
                if (mensaje6i == "FAIL" && rpm2i < 150)
                {
                    Mrp2 = "Visible";
                }
                //////////////////RPM2
                //////////////////RPM3
                string valor7i = com.GetInstrumentos._EI_1_7_MN_1.Valor;
                string mensaje7i = com.GetInstrumentos._EI_1_7_MN_1.Mensaje;
                float rpm3i = float.Parse(valor7i);
                if (rpm3i >= 98 && rpm3i <= 102 && mensaje7i == "")
                {
                    Rp3 = valor7i;
                    Arp3 = rpm3i;
                    B1rp3 = 0;
                    Crp3 = "White";
                    Mrp3 = "Hidden";
                    Vrp3 = "true";
                }
                if (rpm3i < 98 || rpm3i > 102 && mensaje7i == "")
                {
                    Rp3 = valor7i;
                    Arp3 = rpm3i;
                    B1rp3 = rpm3i;
                    Crp3 = "Red";
                    Mrp3 = "Hidden";
                    Vrp3 = "true";
                }
                if (mensaje7i == "NCD" && rpm3i < 150)
                {
                    Rp3 = "---";
                    Crp3 = "White";
                    Mrp3 = "Hidden";
                    Vrp3 = "false";
                }
                if (mensaje7i == "FAIL" && rpm3i < 150)
                {
                    Mrp3 = "Visible";
                }
                //////////////////RPM3
                //////////////////RPM4
                string valor8i = com.GetInstrumentos._EI_1_8_MN_1.Valor;
                string mensaje8i = com.GetInstrumentos._EI_1_8_MN_1.Mensaje;
                float rpm4i = float.Parse(valor8i);
                if (rpm4i >= 98 && rpm4i <= 102 && mensaje8i == "")
                {
                    Rp4 = valor8i;
                    Arp4 = rpm4i;
                    B1rp4 = 0;
                    Crp4 = "White";
                    Mrp4 = "Hidden";
                    Vrp4 = "true";
                }
                if (rpm4i < 98 || rpm4i > 102 && mensaje8i == "")
                {
                    Rp4 = valor8i;
                    Arp4 = rpm4i;
                    B1rp4 = rpm4i;
                    Crp4 = "Red";
                    Mrp4 = "Hidden";
                    Vrp4 = "true";
                }
                if (mensaje8i == "NCD" && rpm4i < 150)
                {
                    Rp4 = "---";
                    Crp4 = "White";
                    Mrp4 = "Hidden";
                    Vrp4 = "false";
                }
                if (mensaje8i == "FAIL" && rpm4i < 150)
                {
                    Mrp4 = "Visible";
                }
                //////////////////RPM4
                //////////////////TIT1
                string valor9i = com.GetInstrumentos._EI_1_9_MN_1.Valor;
                string mensaje9i = com.GetInstrumentos._EI_1_9_MN_1.Mensaje;
                float tit1i = float.Parse(valor9i);
                if (tit1i >= 0 && tit1i <= 1083 && mensaje9i == "")
                {
                    Ti1 = valor9i;
                    Ati1 = tit1i / 100;
                    B1ti1 = 0;
                    Cti1 = "White";
                    Mti1 = "Hidden";
                    Vti1 = "true";
                }
                if (tit1i > 1083 && mensaje9i == "")
                {
                    Ti1 = valor9i;
                    Ati1 = tit1i / 100;
                    B1ti1 = tit1i / 100;
                    Cti1 = "Red";
                    Mti1 = "Hidden";
                    Vti1 = "true";
                }
                if (mensaje9i == "NCD" && tit1i < 1500)
                {
                    Ti1 = "---";
                    Cti1 = "White";
                    Mti1 = "Hidden";
                    Vti1 = "false";
                }
                if (mensaje9i == "FAIL" && tit1i < 1500)
                {
                    Mti1 = "Visible";
                }
                //////////////////TIT1
                //////////////////TIT2
                string valor10i = com.GetInstrumentos._EI_1_10_MN_1.Valor;
                string mensaje10i = com.GetInstrumentos._EI_1_10_MN_1.Mensaje;
                float tit2i = float.Parse(valor10i);
                if (tit2i >= 0 && tit2i <= 1083 && mensaje10i == "")
                {
                    Ti2 = valor10i;
                    Ati2 = tit2i / 100;
                    B1ti2 = 0;
                    Cti2 = "White";
                    Mti2 = "Hidden";
                    Vti2 = "true";
                }
                if (tit2i > 1083 && mensaje10i == "")
                {
                    Ti2 = valor10i;
                    Ati2 = tit2i / 100;
                    B1ti2 = tit2i / 100;
                    Cti2 = "Red";
                    Mti2 = "Hidden";
                    Vti2 = "true";
                }
                if (mensaje10i == "NCD" && tit2i < 1500)
                {
                    Ti2 = "---";
                    Cti2 = "White";
                    Mti2 = "Hidden";
                    Vti2 = "false";
                }
                if (mensaje10i == "FAIL" && tit2i < 1500)
                {
                    Mti2 = "Visible";
                }
                //////////////////TIT2
                //////////////////TIT3
                string valor11i = com.GetInstrumentos._EI_1_11_MN_1.Valor;
                string mensaje11i = com.GetInstrumentos._EI_1_11_MN_1.Mensaje;
                float tit3i = float.Parse(valor11i);
                if (tit3i >= 0 && tit3i <= 1083 && mensaje11i == "")
                {
                    Ti3 = valor11i;
                    Ati3 = tit3i / 100;
                    B1ti3 = 0;
                    Cti3 = "White";
                    Mti3 = "Hidden";
                    Vti3 = "true";
                }
                if (tit3i > 1083 && mensaje11i == "")
                {
                    Ti3 = valor11i;
                    Ati3 = tit3i / 100;
                    B1ti3 = tit3i / 100;
                    Cti3 = "Red";
                    Mti3 = "Hidden";
                    Vti3 = "true";
                }
                if (mensaje11i == "NCD" && tit3i < 1500)
                {
                    Ti3 = "---";
                    Cti3 = "White";
                    Mti3 = "Hidden";
                    Vti3 = "false";
                }
                if (mensaje11i == "FAIL" && tit3i < 1500)
                {
                    Mti3 = "Visible";
                }
                //////////////////TIT3
                //////////////////TIT4
                string valor12i = com.GetInstrumentos._EI_1_12_MN_1.Valor;
                string mensaje12i = com.GetInstrumentos._EI_1_12_MN_1.Mensaje;
                float tit4i = float.Parse(valor12i);
                if (tit4i >= 0 && tit4i <= 1083 && mensaje12i == "")
                {
                    Ti4 = valor12i;
                    Ati4 = tit4i / 100;
                    B1ti4 = 0;
                    Cti4 = "White";
                    Mti4 = "Hidden";
                    Vti4 = "true";
                }
                if (tit4i > 1083 && mensaje12i == "")
                {
                    Ti4 = valor12i;
                    Ati4 = tit4i / 100;
                    B1ti4 = tit4i / 100;
                    Cti4 = "Red";
                    Mti4 = "Hidden";
                    Vti4 = "true";
                }
                if (mensaje12i == "NCD" && tit4i < 1500)
                {
                    Ti4 = "---";
                    Cti4 = "White";
                    Mti4 = "Hidden";
                    Vti4 = "false";
                }
                if (mensaje12i == "FAIL" && tit4i < 1500)
                {
                    Mti4 = "Visible";
                }
                //////////////////TIT4
                //////////////////FF1
                string valor13i = com.GetInstrumentos._EI_1_13_DN_1.Valor;
                string mensaje13i = com.GetInstrumentos._EI_1_13_DN_1.Mensaje;
                if (mensaje13i == "" && float.Parse(valor13i) >= 0)
                {
                    Ff1 = valor13i;
                    Mff1 = "Hidden";
                }
                if (mensaje13i == "NCD" && float.Parse(valor13i) >= 0)
                {
                    Ff1 = "---";
                    Mff1 = "Hidden";
                }
                if (mensaje13i == "FAIL" && float.Parse(valor13i) >= 0)
                {
                    Mff1 = "Visible";
                }
                //////////////////FF1
                //////////////////FF2
                string valor14i = com.GetInstrumentos._EI_1_15_DN_1.Valor;
                string mensaje14i = com.GetInstrumentos._EI_1_15_DN_1.Mensaje;
                if (mensaje14i == "" && float.Parse(valor14i) >= 0)
                {
                    Ff2 = valor14i;
                    Mff2 = "Hidden";
                }
                if (mensaje14i == "NCD" && float.Parse(valor14i) >= 0)
                {
                    Ff2 = "---";
                    Mff2 = "Hidden";
                }
                if (mensaje14i == "FAIL" && float.Parse(valor14i) >= 0)
                {
                    Mff2 = "Visible";
                }
                //////////////////FF2
                //////////////////FF1
                string valor15i = com.GetInstrumentos._EI_1_16_DN_1.Valor;
                string mensaje15i = com.GetInstrumentos._EI_1_16_DN_1.Mensaje;
                if (mensaje15i == "" && float.Parse(valor15i) >= 0)
                {
                    Ff3 = valor15i;
                    Mff3 = "Hidden";
                }
                if (mensaje15i == "NCD" && float.Parse(valor15i) >= 0)
                {
                    Ff3 = "---";
                    Mff3 = "Hidden";
                }
                if (mensaje15i == "FAIL" && float.Parse(valor15i) >= 0)
                {
                    Mff3 = "Visible";
                }
                //////////////////FF3
                //////////////////FF4
                string valor16i = com.GetInstrumentos._EI_1_18_DN_1.Valor;
                string mensaje16i = com.GetInstrumentos._EI_1_18_DN_1.Mensaje;
                if (mensaje16i == "" && float.Parse(valor16i) >= 0)
                {
                    Ff4 = valor16i;
                    Mff4 = "Hidden";
                }
                if (mensaje16i == "NCD" && float.Parse(valor16i) >= 0)
                {
                    Ff4 = "---";
                    Mff4 = "Hidden";
                }
                if (mensaje16i == "FAIL" && float.Parse(valor16i) >= 0)
                {
                    Mff4 = "Visible";
                }
                //////////////////FF4
                //////////////////LABEL1
                string valor17i = com.GetInstrumentos._EI_1_14_DN_1.Valor1;
                string valor18i = com.GetInstrumentos._EI_1_14_DN_1.Valor2;
                string valor19i = com.GetInstrumentos._EI_1_14_DN_1.Valor3;
                string valor20i = com.GetInstrumentos._EI_1_14_DN_1.Valor4;
                string valor21i = com.GetInstrumentos._EI_1_14_DN_1.Valor5;
                string valor22i = com.GetInstrumentos._EI_1_14_DN_1.Valor6;
                if (valor17i == "0" && valor18i == "0") { Flb1 = "ENRICH"; }
                if (valor17i == "1" && valor18i == "0") { Flb1 = "1" + "ENRICH"; }
                if (valor17i == "0" && valor18i == "1") { Flb1 = "ENRICH" + "2"; }
                if (valor17i == "1" && valor18i == "1") { Flb1 = "1" + "ENRICH" + "2"; }
                if (valor19i == "0" && valor20i == "0") { Elb1 = "EFC"; }
                if (valor19i == "1" && valor20i == "0") { Elb1 = "1" + "EFC"; }
                if (valor19i == "0" && valor20i == "1") { Elb1 = "EFC" + "2"; }
                if (valor19i == "1" && valor20i == "1") { Elb1 = "1" + "EFC" + "2"; }
                if (valor21i == "0" && valor22i == "0") { Slb1 = "SEC PUMP"; }
                if (valor21i == "1" && valor22i == "0") { Slb1 = "1" + "SEC PUMP"; }
                if (valor21i == "0" && valor22i == "1") { Slb1 = "SEC PUMP" + "2"; }
                if (valor21i == "1" && valor22i == "1") { Slb1 = "1" + "SEC PUMP" + "2"; }
                //////////////////LABEL1
                //////////////////LABEL2
                string valor23i = com.GetInstrumentos._EI_1_17_DN_1.Valor1;
                string valor24i = com.GetInstrumentos._EI_1_17_DN_1.Valor2;
                string valor25i = com.GetInstrumentos._EI_1_17_DN_1.Valor3;
                string valor26i = com.GetInstrumentos._EI_1_17_DN_1.Valor4;
                string valor27i = com.GetInstrumentos._EI_1_17_DN_1.Valor5;
                string valor28i = com.GetInstrumentos._EI_1_17_DN_1.Valor6;
                if (valor23i == "0" && valor24i == "0") { Flb2 = "ENRICH"; }
                if (valor23i == "1" && valor24i == "0") { Flb2 = "3" + "ENRICH"; }
                if (valor23i == "0" && valor24i == "1") { Flb2 = "ENRICH" + "4"; }
                if (valor23i == "1" && valor24i == "1") { Flb2 = "3" + "ENRICH" + "4"; }
                if (valor25i == "0" && valor26i == "0") { Elb2 = "EFC"; }
                if (valor25i == "1" && valor26i == "0") { Elb2 = "3" + "EFC"; }
                if (valor25i == "0" && valor26i == "1") { Elb2 = "EFC" + "4"; }
                if (valor25i == "1" && valor26i == "1") { Elb2 = "3" + "EFC" + "4"; }
                if (valor27i == "0" && valor28i == "0") { Slb2 = "SEC PUMP"; }
                if (valor27i == "1" && valor28i == "0") { Slb2 = "3" + "SEC PUMP"; }
                if (valor27i == "0" && valor28i == "1") { Slb2 = "SEC PUMP" + "4"; }
                if (valor27i == "1" && valor28i == "1") { Slb2 = "3" + "SEC PUMP" + "4"; }
                //////////////////LABEL2
                //////////////////APU
                string valoro = com.GetInstrumentos._OH_7_2_MN_1_76.Valor;
                Val = float.Parse(valoro);
                string valor2o = com.GetInstrumentos._OH_7_1_MN_2_75.Valor;
                Val2 = float.Parse(valor2o);
                Val3 = Val2 % 10;
                //////////////////APU
            }
        }
        #endregion
    }
}
