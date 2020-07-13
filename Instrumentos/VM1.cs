using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EIDS.Instrumentos
{/*
    public class VM1 : INotifyPropertyChanged
    {
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
        public VM1()
        {
            Thread valor = new Thread(Valor);
            valor.Start();
        }
        #endregion

        /////////////////////////////////////////////////////////////////////VARIABLES BINDING////////////////////////////////////////////////////////
        #region
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
        #endregion

        /////////////////////////////////////////////////////////////////////LOGICA////////////////////////////////////////////////////////
        #region
        private void Valor()
        {
            ComunicacionClienteEids com = new ComunicacionClienteEids();
            while (true)
            {
                //////////////////TORQUE1
                string valor1 = com.GetInstrumentos._EI_1_1_MN_1.Valor;
                string mensaje1 = com.GetInstrumentos._EI_1_1_MN_1.Mensaje;
                float torque1 = float.Parse(valor1);
                if(torque1 >= 0 && torque1 <= 20 && mensaje1 == "")
                {
                    Tq1 = valor1;
                    Atq1 = torque1;
                    B1tq1 = 0;
                    B2tq1 = 0;
                    Ctq1 = "White";
                    Mtq1 = "Hidden";
                    Vtq1 = "true";
                }
                if(torque1 < 0 && mensaje1 == "")
                {
                    Tq1 = valor1;
                    Atq1 = torque1;
                    B1tq1 = 0;
                    B2tq1 = torque1;
                    Ctq1 = "Yellow";
                    Mtq1 = "Hidden";
                    Vtq1 = "true";
                }
                if(torque1 > 20 && mensaje1 == "")
                {
                    Tq1 = valor1;
                    Atq1 = torque1;
                    B1tq1 = torque1;
                    B2tq1 = 0;
                    Ctq1 = "Red";
                    Mtq1 = "Hidden";
                    Vtq1 = "true";
                }
                if(mensaje1 == "NCD" && torque1 < 50)
                {
                    Tq1 = "---";
                    Ctq1 = "White";
                    Mtq1 = "Hidden";
                    Vtq1 = "false";
                }
                if (mensaje1 == "FAIL" && torque1 < 50)
                {
                    Mtq1 = "Visible";
                }
                //////////////////TORQUE1
                //////////////////TORQUE2
                string valor2 = com.GetInstrumentos._EI_1_2_MN_1.Valor;
                string mensaje2 = com.GetInstrumentos._EI_1_2_MN_1.Mensaje;
                float torque2 = float.Parse(valor2);
                if (torque2 >= 0 && torque2 <= 20 && mensaje2 == "")
                {
                    Tq2 = valor2;
                    Atq2 = torque2;
                    B1tq2 = 0;
                    B2tq2 = 0;
                    Ctq2 = "White";
                    Mtq2 = "Hidden";
                    Vtq2 = "true";
                }
                if (torque2 < 0 && mensaje2 == "")
                {
                    Tq2 = valor2;
                    Atq2 = torque2;
                    B1tq2 = 0;
                    B2tq2 = torque2;
                    Ctq2 = "Yellow";
                    Mtq2 = "Hidden";
                    Vtq2 = "true";
                }
                if (torque2 > 20 && mensaje2 == "")
                {
                    Tq2 = valor2;
                    Atq2 = torque2;
                    B1tq2 = torque2;
                    B2tq2 = 0;
                    Ctq2 = "Red";
                    Mtq2 = "Hidden";
                    Vtq2 = "true";
                }
                if (mensaje2 == "NCD" && torque2 < 50)
                {
                    Tq2 = "---";
                    Ctq2 = "White";
                    Mtq2 = "Hidden";
                    Vtq2 = "false";
                }
                if (mensaje2 == "FAIL" && torque2 < 50)
                {
                    Mtq2 = "Visible";
                }
                //////////////////TORQUE2
                //////////////////TORQUE3
                string valor3 = com.GetInstrumentos._EI_1_3_MN_1.Valor;
                string mensaje3 = com.GetInstrumentos._EI_1_3_MN_1.Mensaje;
                float torque3 = float.Parse(valor3);
                if (torque3 >= 0 && torque3 <= 20 && mensaje3 == "")
                {
                    Tq3 = valor3;
                    Atq3 = torque3;
                    B1tq3 = 0;
                    B2tq3 = 0;
                    Ctq3 = "White";
                    Mtq3 = "Hidden";
                    Vtq3 = "true";
                }
                if (torque3 < 0 && mensaje3 == "")
                {
                    Tq3 = valor3;
                    Atq3 = torque3;
                    B1tq3 = 0;
                    B2tq3 = torque3;
                    Ctq3 = "Yellow";
                    Mtq3 = "Hidden";
                    Vtq3 = "true";
                }
                if (torque3 > 20 && mensaje3 == "")
                {
                    Tq3 = valor3;
                    Atq3 = torque3;
                    B1tq3 = torque3;
                    B2tq3 = 0;
                    Ctq3 = "Red";
                    Mtq3 = "Hidden";
                    Vtq3 = "true";
                }
                if (mensaje3 == "NCD" && torque3 < 50)
                {
                    Tq3 = "---";
                    Ctq3 = "White";
                    Mtq3 = "Hidden";
                    Vtq3 = "false";
                }
                if (mensaje3 == "FAIL" && torque3 < 50)
                {
                    Mtq3 = "Visible";
                }
                //////////////////TORQUE3
                //////////////////TORQUE4
                string valor4 = com.GetInstrumentos._EI_1_4_MN_1.Valor;
                string mensaje4 = com.GetInstrumentos._EI_1_4_MN_1.Mensaje;
                float torque4 = float.Parse(valor4);
                if (torque4 >= 0 && torque4 <= 20 && mensaje4 == "")
                {
                    Tq4 = valor4;
                    Atq4 = torque4;
                    B1tq4 = 0;
                    B2tq4 = 0;
                    Ctq4 = "White";
                    Mtq4 = "Hidden";
                    Vtq4 = "true";
                }
                if (torque4 < 0 && mensaje4 == "")
                {
                    Tq4 = valor4;
                    Atq4 = torque4;
                    B1tq4 = 0;
                    B2tq4 = torque4;
                    Ctq4 = "Yellow";
                    Mtq4 = "Hidden";
                    Vtq4 = "true";
                }
                if (torque4 > 20 && mensaje4 == "")
                {
                    Tq4 = valor4;
                    Atq4 = torque4;
                    B1tq4 = torque4;
                    B2tq4 = 0;
                    Ctq4 = "Red";
                    Mtq4 = "Hidden";
                    Vtq4 = "true";
                }
                if (mensaje4 == "NCD" && torque4 < 50)
                {
                    Tq4 = "---";
                    Ctq4 = "White";
                    Mtq4 = "Hidden";
                    Vtq4 = "false";
                }
                if (mensaje4 == "FAIL" && torque4 < 50)
                {
                    Mtq4 = "Visible";
                }
                //////////////////TORQUE4
                //////////////////RPM1
                string valor5 = com.GetInstrumentos._EI_1_5_MN_1.Valor;
                string mensaje5 = com.GetInstrumentos._EI_1_5_MN_1.Mensaje;
                float rpm1 = float.Parse(valor5);
                if (rpm1 >= 98 && rpm1 <= 102 && mensaje5 == "")
                {
                    Rp1 = valor5;
                    Arp1 = rpm1;
                    B1rp1 = 0;
                    Crp1 = "White";
                    Mrp1 = "Hidden";
                    Vrp1 = "true";
                }
                if(rpm1 < 98 || rpm1 > 102 && mensaje5 == "")
                {
                    Rp1 = valor5;
                    Arp1 = rpm1;
                    B1rp1 = rpm1;
                    Crp1 = "Red";
                    Mrp1 = "Hidden";
                    Vrp1 = "true";
                }
                if (mensaje5 == "NCD" && rpm1 < 150)
                {
                    Rp1 = "---";
                    Crp1 = "White";
                    Mrp1 = "Hidden";
                    Vrp1 = "false";
                }
                if (mensaje5 == "FAIL" && rpm1 < 150)
                {
                    Mrp1 = "Visible";
                }
                //////////////////RPM1
                //////////////////RPM2
                string valor6 = com.GetInstrumentos._EI_1_6_MN_1.Valor;
                string mensaje6 = com.GetInstrumentos._EI_1_6_MN_1.Mensaje;
                float rpm2 = float.Parse(valor6);
                if (rpm2 >= 98 && rpm2 <= 102 && mensaje6 == "")
                {
                    Rp2 = valor6;
                    Arp2 = rpm2;
                    B1rp2 = 0;
                    Crp2 = "White";
                    Mrp2 = "Hidden";
                    Vrp2 = "true";
                }
                if (rpm2 < 98 || rpm2 > 102 && mensaje6 == "")
                {
                    Rp2 = valor6;
                    Arp2 = rpm2;
                    B1rp2 = rpm2;
                    Crp2 = "Red";
                    Mrp2 = "Hidden";
                    Vrp2 = "true";
                }
                if (mensaje6 == "NCD" && rpm2 < 150)
                {
                    Rp2 = "---";
                    Crp2 = "White";
                    Mrp2 = "Hidden";
                    Vrp2 = "false";
                }
                if (mensaje6 == "FAIL" && rpm2 < 150)
                {
                    Mrp2 = "Visible";
                }
                //////////////////RPM2
                //////////////////RPM3
                string valor7 = com.GetInstrumentos._EI_1_7_MN_1.Valor;
                string mensaje7 = com.GetInstrumentos._EI_1_7_MN_1.Mensaje;
                float rpm3 = float.Parse(valor7);
                if (rpm3 >= 98 && rpm3 <= 102 && mensaje7 == "")
                {
                    Rp3 = valor7;
                    Arp3 = rpm3;
                    B1rp3 = 0;
                    Crp3 = "White";
                    Mrp3 = "Hidden";
                    Vrp3 = "true";
                }
                if (rpm3 < 98 || rpm3 > 102 && mensaje7 == "")
                {
                    Rp3 = valor7;
                    Arp3 = rpm3;
                    B1rp3 = rpm3;
                    Crp3 = "Red";
                    Mrp3 = "Hidden";
                    Vrp3 = "true";
                }
                if (mensaje7 == "NCD" && rpm3 < 150)
                {
                    Rp3 = "---";
                    Crp3 = "White";
                    Mrp3 = "Hidden";
                    Vrp3 = "false";
                }
                if (mensaje7 == "FAIL" && rpm3 < 150)
                {
                    Mrp3 = "Visible";
                }
                //////////////////RPM3
                //////////////////RPM4
                string valor8 = com.GetInstrumentos._EI_1_8_MN_1.Valor;
                string mensaje8 = com.GetInstrumentos._EI_1_8_MN_1.Mensaje;
                float rpm4 = float.Parse(valor8);
                if (rpm4 >= 98 && rpm4 <= 102 && mensaje8 == "")
                {
                    Rp4 = valor8;
                    Arp4 = rpm4;
                    B1rp4 = 0;
                    Crp4 = "White";
                    Mrp4 = "Hidden";
                    Vrp4 = "true";
                }
                if (rpm4 < 98 || rpm4 > 102 && mensaje8 == "")
                {
                    Rp4 = valor8;
                    Arp4 = rpm4;
                    B1rp4 = rpm4;
                    Crp4 = "Red";
                    Mrp4 = "Hidden";
                    Vrp4 = "true";
                }
                if (mensaje8 == "NCD" && rpm4 < 150)
                {
                    Rp4 = "---";
                    Crp4 = "White";
                    Mrp4 = "Hidden";
                    Vrp4 = "false";
                }
                if (mensaje8 == "FAIL" && rpm4 < 150)
                {
                    Mrp4 = "Visible";
                }
                //////////////////RPM4
                //////////////////TIT1
                string valor9 = com.GetInstrumentos._EI_1_9_MN_1.Valor;
                string mensaje9 = com.GetInstrumentos._EI_1_9_MN_1.Mensaje;
                float tit1 = float.Parse(valor9);
                if (tit1 >= 0 && tit1 <= 1083 && mensaje9 == "")
                {
                    Ti1 = valor9;
                    Ati1 = tit1/100;
                    B1ti1 = 0;
                    Cti1 = "White";
                    Mti1 = "Hidden";
                    Vti1 = "true";
                }
                if (tit1 > 1083 && mensaje9 == "")
                {
                    Ti1 = valor9;
                    Ati1 = tit1/100;
                    B1ti1 = tit1/100;
                    Cti1 = "Red";
                    Mti1 = "Hidden";
                    Vti1 = "true";
                }
                if (mensaje9 == "NCD" && tit1 < 1500)
                {
                    Ti1 = "---";
                    Cti1 = "White";
                    Mti1 = "Hidden";
                    Vti1 = "false";
                }
                if (mensaje9 == "FAIL" && tit1 < 1500)
                {
                    Mti1 = "Visible";
                }
                //////////////////TIT1
                //////////////////TIT2
                string valor10 = com.GetInstrumentos._EI_1_10_MN_1.Valor;
                string mensaje10 = com.GetInstrumentos._EI_1_10_MN_1.Mensaje;
                float tit2 = float.Parse(valor10);
                if (tit2 >= 0 && tit2 <= 1083 && mensaje10 == "")
                {
                    Ti2 = valor10;
                    Ati2 = tit2 / 100;
                    B1ti2 = 0;
                    Cti2 = "White";
                    Mti2 = "Hidden";
                    Vti2 = "true";
                }
                if (tit2 > 1083 && mensaje10 == "")
                {
                    Ti2 = valor10;
                    Ati2 = tit2 / 100;
                    B1ti2 = tit2 / 100;
                    Cti2 = "Red";
                    Mti2 = "Hidden";
                    Vti2 = "true";
                }
                if (mensaje10 == "NCD" && tit2 < 1500)
                {
                    Ti2 = "---";
                    Cti2 = "White";
                    Mti2 = "Hidden";
                    Vti2 = "false";
                }
                if (mensaje10 == "FAIL" && tit2 < 1500)
                {
                    Mti2 = "Visible";
                }
                //////////////////TIT2
                //////////////////TIT3
                string valor11 = com.GetInstrumentos._EI_1_11_MN_1.Valor;
                string mensaje11 = com.GetInstrumentos._EI_1_11_MN_1.Mensaje;
                float tit3 = float.Parse(valor11);
                if (tit3 >= 0 && tit3 <= 1083 && mensaje11 == "")
                {
                    Ti3 = valor11;
                    Ati3 = tit3 / 100;
                    B1ti3 = 0;
                    Cti3 = "White";
                    Mti3 = "Hidden";
                    Vti3 = "true";
                }
                if (tit3 > 1083 && mensaje11 == "")
                {
                    Ti3 = valor11;
                    Ati3 = tit3 / 100;
                    B1ti3 = tit3 / 100;
                    Cti3 = "Red";
                    Mti3 = "Hidden";
                    Vti3 = "true";
                }
                if (mensaje11 == "NCD" && tit3 < 1500)
                {
                    Ti3 = "---";
                    Cti3 = "White";
                    Mti3 = "Hidden";
                    Vti3 = "false";
                }
                if (mensaje11 == "FAIL" && tit3 < 1500)
                {
                    Mti3 = "Visible";
                }
                //////////////////TIT3
                //////////////////TIT4
                string valor12 = com.GetInstrumentos._EI_1_12_MN_1.Valor;
                string mensaje12 = com.GetInstrumentos._EI_1_12_MN_1.Mensaje;
                float tit4 = float.Parse(valor12);
                if (tit4 >= 0 && tit4 <= 1083 && mensaje12 == "")
                {
                    Ti4 = valor12;
                    Ati4 = tit4 / 100;
                    B1ti4 = 0;
                    Cti4 = "White";
                    Mti4 = "Hidden";
                    Vti4 = "true";
                }
                if (tit4 > 1083 && mensaje12 == "")
                {
                    Ti4 = valor12;
                    Ati4 = tit4 / 100;
                    B1ti4 = tit4 / 100;
                    Cti4 = "Red";
                    Mti4 = "Hidden";
                    Vti4 = "true";
                }
                if (mensaje12 == "NCD" && tit4 < 1500)
                {
                    Ti4 = "---";
                    Cti4 = "White";
                    Mti4 = "Hidden";
                    Vti4 = "false";
                }
                if (mensaje12 == "FAIL" && tit4 < 1500)
                {
                    Mti4 = "Visible";
                }
                //////////////////TIT4
                //////////////////FF1
                string valor13 = com.GetInstrumentos._EI_1_13_DN_1.Valor;
                string mensaje13 = com.GetInstrumentos._EI_1_13_DN_1.Mensaje;
                if (mensaje13 == "" && float.Parse(valor13) >= 0)
                {
                    Ff1 = valor13;
                    Mff1 = "Hidden";
                }
                if(mensaje13 == "NCD" && float.Parse(valor13) >= 0)
                {
                    Ff1 = "---";
                    Mff1 = "Hidden";
                }
                if (mensaje13 == "FAIL" && float.Parse(valor13) >= 0)
                {
                    Mff1 = "Visible";
                }
                //////////////////FF1
                //////////////////FF2
                string valor14 = com.GetInstrumentos._EI_1_15_DN_1.Valor;
                string mensaje14 = com.GetInstrumentos._EI_1_15_DN_1.Mensaje;
                if (mensaje14 == "" && float.Parse(valor14) >= 0)
                {
                    Ff2 = valor14;
                    Mff2 = "Hidden";
                }
                if (mensaje14 == "NCD" && float.Parse(valor14) >= 0)
                {
                    Ff2 = "---";
                    Mff2 = "Hidden";
                }
                if (mensaje14 == "FAIL" && float.Parse(valor14) >= 0)
                {
                    Mff2 = "Visible";
                }
                //////////////////FF2
                //////////////////FF1
                string valor15 = com.GetInstrumentos._EI_1_16_DN_1.Valor;
                string mensaje15 = com.GetInstrumentos._EI_1_16_DN_1.Mensaje;
                if (mensaje15 == "" && float.Parse(valor15) >= 0)
                {
                    Ff3 = valor15;
                    Mff3 = "Hidden";
                }
                if (mensaje15 == "NCD" && float.Parse(valor15) >= 0)
                {
                    Ff3 = "---";
                    Mff3 = "Hidden";
                }
                if (mensaje15 == "FAIL" && float.Parse(valor15) >= 0)
                {
                    Mff3 = "Visible";
                }
                //////////////////FF3
                //////////////////FF1
                string valor16 = com.GetInstrumentos._EI_1_18_DN_1.Valor;
                string mensaje16 = com.GetInstrumentos._EI_1_18_DN_1.Mensaje;
                if (mensaje16 == "" && float.Parse(valor16) >= 0)
                {
                    Ff4 = valor16;
                    Mff4 = "Hidden";
                }
                if (mensaje16 == "NCD" && float.Parse(valor16) >= 0)
                {
                    Ff4 = "---";
                    Mff4 = "Hidden";
                }
                if (mensaje16 == "FAIL" && float.Parse(valor16) >= 0)
                {
                    Mff4 = "Visible";
                }
                //////////////////FF4
                //////////////////LABEL1
                string valor17 = com.GetInstrumentos._EI_1_14_DN_1.Valor1;
                string valor18 = com.GetInstrumentos._EI_1_14_DN_1.Valor2;
                string valor19 = com.GetInstrumentos._EI_1_14_DN_1.Valor3;
                string valor20 = com.GetInstrumentos._EI_1_14_DN_1.Valor4;
                string valor21 = com.GetInstrumentos._EI_1_14_DN_1.Valor5;
                string valor22 = com.GetInstrumentos._EI_1_14_DN_1.Valor6;
                if (valor17 == "0" && valor18 == "0") { Flb1 = "ENRICH"; }
                if (valor17 == "1" && valor18 == "0") { Flb1 = "1" + "ENRICH"; }
                if (valor17 == "0" && valor18 == "1") { Flb1 = "ENRICH" + "2"; }
                if (valor17 == "1" && valor18 == "1") { Flb1 = "1" + "ENRICH" + "2"; }
                if (valor19 == "0" && valor20 == "0") { Elb1 = "EFC"; }
                if (valor19 == "1" && valor20 == "0") { Elb1 = "1" + "EFC"; }
                if (valor19 == "0" && valor20 == "1") { Elb1 = "EFC" + "2"; }
                if (valor19 == "1" && valor20 == "1") { Elb1 = "1" + "EFC" + "2"; }
                if (valor21 == "0" && valor22 == "0") { Slb1 = "SEC PUMP"; }
                if (valor21 == "1" && valor22 == "0") { Slb1 = "1" + "SEC PUMP"; }
                if (valor21 == "0" && valor22 == "1") { Slb1 = "SEC PUMP" + "2"; }
                if (valor21 == "1" && valor22 == "1") { Slb1 = "1" + "SEC PUMP" + "2"; }
                //////////////////LABEL1
                //////////////////LABEL2
                string valor23 = com.GetInstrumentos._EI_1_17_DN_1.Valor1;
                string valor24 = com.GetInstrumentos._EI_1_17_DN_1.Valor2;
                string valor25 = com.GetInstrumentos._EI_1_17_DN_1.Valor3;
                string valor26 = com.GetInstrumentos._EI_1_17_DN_1.Valor4;
                string valor27 = com.GetInstrumentos._EI_1_17_DN_1.Valor5;
                string valor28 = com.GetInstrumentos._EI_1_17_DN_1.Valor6;
                if (valor23 == "0" && valor24 == "0") { Flb2 = "ENRICH"; }
                if (valor23 == "1" && valor24 == "0") { Flb2 = "3" + "ENRICH"; }
                if (valor23 == "0" && valor24 == "1") { Flb2 = "ENRICH" + "4"; }
                if (valor23 == "1" && valor24 == "1") { Flb2 = "3" + "ENRICH" + "4"; }
                if (valor25 == "0" && valor26 == "0") { Elb2 = "EFC"; }
                if (valor25 == "1" && valor26 == "0") { Elb2 = "3" + "EFC"; }
                if (valor25 == "0" && valor26 == "1") { Elb2 = "EFC" + "4"; }
                if (valor25 == "1" && valor26 == "1") { Elb2 = "3" + "EFC" + "4"; }
                if (valor27 == "0" && valor28 == "0") { Slb2 = "SEC PUMP"; }
                if (valor27 == "1" && valor28 == "0") { Slb2 = "3" + "SEC PUMP"; }
                if (valor27 == "0" && valor28 == "1") { Slb2 = "SEC PUMP" + "4"; }
                if (valor27 == "1" && valor28 == "1") { Slb2 = "3" + "SEC PUMP" + "4"; }
                //////////////////LABEL2
            }
        }
        #endregion
    }
*/}
