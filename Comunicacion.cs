using EIDS.Instrumentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EIDS
{
    class ComunicacionClienteEids
    {
        private InstrumentosEIDS Instrumentos;
        private static byte[] result = new byte[1024];
        static Socket clientSocket;
        public ComunicacionClienteEids()
        {
            Instrumentos = new InstrumentosEIDS();
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(new IPEndPoint(ip, 8000));
                Console.WriteLine("Successfully connected to the server");
                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start();

            }
            catch
            {
                Console.WriteLine("Connection failure，Please press enter to exit！");
            }
        } 
        public InstrumentosEIDS GetInstrumentos
        {
            get { return Instrumentos; }    
        }
        private  void ReceiveMessage()
        {
            while (clientSocket.Connected)
            {
                try
                {
                    int receiveLength = clientSocket.Receive(result);
                    if (receiveLength > 0)
                    {
                        string MsgRecibido = Encoding.ASCII.GetString(result, 0, receiveLength);
                        Console.WriteLine(MsgRecibido);
                        string[] splitmsgGeneral = MsgRecibido.Split("::".ToCharArray());

                        foreach (string item in splitmsgGeneral)
                        {

                            string[] SplitMsg = item.Split(';');
                            if (SplitMsg.Length >= 8)
                            {

                                string Senal = SplitMsg[0];
                                string valor = SplitMsg[1];
                                string mensaje = SplitMsg[2];
                                string valor2 = SplitMsg[3];
                                string valor3 = SplitMsg[4];
                                string valor4 = SplitMsg[5];
                                string valor5 = SplitMsg[6];
                                string valor6 = SplitMsg[7];
                                double valordouble = 0d;

                                if (double.TryParse(valor, out valordouble))
                                {
                                    switch (Senal)
                                    {
                                        case "OH_7_2_MN_1_AS":
                                            Instrumentos._OH_7_2_MN_1_76.Valor = valor;
                                            break;
                                        case "OH_7_1_MN_2_AS":
                                            Instrumentos._OH_7_1_MN_2_75.Valor = valor;
                                            break;
                                        case "EI_1_19_DN_1_AS":
                                            Instrumentos._EI_1_19_DN_1.Valor = valor;
                                            Instrumentos._EI_1_19_DN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_20_DN_1_AS":
                                            Instrumentos._EI_1_20_DN_1.Valor = valor;
                                            Instrumentos._EI_1_20_DN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_21_DN_1_AS":
                                            Instrumentos._EI_1_21_DN_1.Valor = valor;
                                            Instrumentos._EI_1_21_DN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_22_DN_1_AS":
                                            Instrumentos._EI_1_22_DN_1.Valor = valor;
                                            Instrumentos._EI_1_22_DN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_23_MN_1_AS":
                                            Instrumentos._EI_1_23_MN_1.Valor = valor;
                                            Instrumentos._EI_1_23_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_25_MN_1_AS":
                                            Instrumentos._EI_1_25_MN_1.Valor = valor;
                                            Instrumentos._EI_1_25_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_27_MN_1_AS":
                                            Instrumentos._EI_1_27_MN_1.Valor = valor;
                                            Instrumentos._EI_1_27_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_29_MN_1_AS":
                                            Instrumentos._EI_1_29_MN_1.Valor = valor;
                                            Instrumentos._EI_1_29_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_24_MN_1_AS":
                                            Instrumentos._EI_1_24_MN_1.Valor = valor;
                                            Instrumentos._EI_1_24_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_26_MN_1_AS":
                                            Instrumentos._EI_1_26_MN_1.Valor = valor;
                                            Instrumentos._EI_1_26_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_28_MN_1_AS":
                                            Instrumentos._EI_1_28_MN_1.Valor = valor;
                                            Instrumentos._EI_1_28_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_30_MN_1_AS":
                                            Instrumentos._EI_1_30_MN_1.Valor = valor;
                                            Instrumentos._EI_1_30_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_31_DN_1_AS":
                                            Instrumentos._EI_1_31_DN_1.Valor = valor;
                                            Instrumentos._EI_1_31_DN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_32_DN_1_AS":
                                            Instrumentos._EI_1_32_DN_1.Valor = valor;
                                            Instrumentos._EI_1_32_DN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_33_DN_1_AS":
                                            Instrumentos._EI_1_33_DN_1.Valor = valor;
                                            Instrumentos._EI_1_33_DN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_34_DN_1_AS":
                                            Instrumentos._EI_1_34_DN_1.Valor = valor;
                                            Instrumentos._EI_1_34_DN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_35_DN_1_AS":
                                            Instrumentos._EI_1_35_DN_1.Valor = valor;
                                            Instrumentos._EI_1_35_DN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_36_DN_1_AS":
                                            Instrumentos._EI_1_36_DN_1.Valor = valor;
                                            Instrumentos._EI_1_36_DN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_37_DN_1_AS":
                                            Instrumentos._EI_1_37_DN_1.Valor = valor;
                                            Instrumentos._EI_1_37_DN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_38_DN_1_AS":
                                            Instrumentos._EI_1_38_DN_1.Valor = valor;
                                            Instrumentos._EI_1_38_DN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_39_MN_1_AS":
                                            Instrumentos._EI_1_39_MN_1.Valor = valor;
                                            Instrumentos._EI_1_39_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_40_MN_1_AS":
                                            Instrumentos._EI_1_40_MN_1.Valor1 = valor;
                                            Instrumentos._EI_1_40_MN_1.Valor2 = valor2;
                                            Instrumentos._EI_1_40_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_41_MN_1_AS":
                                            Instrumentos._EI_1_41_MN_1.Valor = valor;
                                            Instrumentos._EI_1_41_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_46_MN_1_AS":
                                            Instrumentos._EI_1_46_MN_1.Valor = valor;
                                            Instrumentos._EI_1_46_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_47_DN_1_AS":
                                            Instrumentos._EI_1_47_DN_1.Valor1 = valor;
                                            Instrumentos._EI_1_47_DN_1.Valor2 = valor2;
                                            Instrumentos._EI_1_47_DN_1.Valor3 = valor3;
                                            Instrumentos._EI_1_47_DN_1.Valor4 = valor4;
                                            break;
                                        case "EI_1_42_MN_1_AS":
                                            Instrumentos._EI_1_42_MN_1.Valor = valor;
                                            Instrumentos._EI_1_42_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_43_MN_1_AS":
                                            Instrumentos._EI_1_43_MN_1.Valor = valor;
                                            Instrumentos._EI_1_43_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_48_MN_1_AS":
                                            Instrumentos._EI_1_48_MN_1.Valor = valor;
                                            Instrumentos._EI_1_48_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_44_MN_1_AS":
                                            Instrumentos._EI_1_44_MN_1.Valor1 = valor;
                                            Instrumentos._EI_1_44_MN_1.Valor2 = valor2;
                                            Instrumentos._EI_1_44_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_45_MN_1_AS":
                                            Instrumentos._EI_1_45_MN_1.Valor1 = valor;
                                            Instrumentos._EI_1_45_MN_1.Valor2 = valor2;
                                            Instrumentos._EI_1_45_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_1_MN_1_AS":
                                            Instrumentos._EI_1_1_MN_1.Valor = valor;
                                            Instrumentos._EI_1_1_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_2_MN_1_AS":
                                            Instrumentos._EI_1_2_MN_1.Valor = valor;
                                            Instrumentos._EI_1_2_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_3_MN_1_AS":
                                            Instrumentos._EI_1_3_MN_1.Valor = valor;
                                            Instrumentos._EI_1_3_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_4_MN_1_AS":
                                            Instrumentos._EI_1_4_MN_1.Valor = valor;
                                            Instrumentos._EI_1_4_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_5_MN_1_AS":
                                            Instrumentos._EI_1_5_MN_1.Valor = valor;
                                            Instrumentos._EI_1_5_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_6_MN_1_AS":
                                            Instrumentos._EI_1_6_MN_1.Valor = valor;
                                            Instrumentos._EI_1_6_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_7_MN_1_AS":
                                            Instrumentos._EI_1_7_MN_1.Valor = valor;
                                            Instrumentos._EI_1_7_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_8_MN_1_AS":
                                            Instrumentos._EI_1_8_MN_1.Valor = valor;
                                            Instrumentos._EI_1_8_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_9_MN_1_AS":
                                            Instrumentos._EI_1_9_MN_1.Valor = valor;
                                            Instrumentos._EI_1_9_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_10_MN_1_AS":
                                            Instrumentos._EI_1_10_MN_1.Valor = valor;
                                            Instrumentos._EI_1_10_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_11_MN_1_AS":
                                            Instrumentos._EI_1_11_MN_1.Valor = valor;
                                            Instrumentos._EI_1_11_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_12_MN_1_AS":
                                            Instrumentos._EI_1_12_MN_1.Valor = valor;
                                            Instrumentos._EI_1_12_MN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_13_DN_1_AS":
                                            Instrumentos._EI_1_13_DN_1.Valor = valor;
                                            Instrumentos._EI_1_13_DN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_15_DN_1_AS":
                                            Instrumentos._EI_1_15_DN_1.Valor = valor;
                                            Instrumentos._EI_1_15_DN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_16_DN_1_AS":
                                            Instrumentos._EI_1_16_DN_1.Valor = valor;
                                            Instrumentos._EI_1_16_DN_1.Mensaje = mensaje;
                                            break;
                                        case "EI_1_18_DN_1_AS":
                                            Instrumentos._EI_1_18_DN_1.Valor = valor;
                                            Instrumentos._EI_1_18_DN_1.Mensaje = mensaje;
                                            break;
                                    }

                                }
                                else
                                {

                                }
                            }
                            else
                            {


                            }


                            receiveLength = 0;
                        }


                    }
                }
                catch (Exception)
                {


                }


            }
            clientSocket.Close();
        }
    }
}
