using DevExpress.Xpf.Gauges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EIDS
{
    /// <summary>
    /// Lógica de interacción para _2.xaml
    /// </summary>
    public partial class _2 : Window
    {
        public _2()
        {
            InitializeComponent();

            ///////////////////////////////////////////////////////////////OIL COOL////////////////////////////////////////////////////////////
            int first = 1;
            int sec = 2;
            int th = 3;
            int fo = 4;
            ////////////////////////OIL COOL 1
            if(first != 1 && sec != 2)
            {

                oilcoolc1.BorderBrush = Brushes.GreenYellow;
                oilcool1.Foreground = Brushes.GreenYellow;
                oilcool1.Text = "AUG";
            }
            if (first == 1 && sec != 2)
            {
                oilcoolc1.BorderBrush = Brushes.GreenYellow;
                oilcool1.Foreground = Brushes.GreenYellow;
                oilcool1.Text = "1 AUG";
            }
            if (first != 1 && sec == 2)
            {
                oilcoolc1.BorderBrush = Brushes.GreenYellow;
                oilcool1.Foreground = Brushes.GreenYellow;
                oilcool1.Text = "AUG 2";
            }
            if (first == 1 && sec == 2)
            {
                oilcoolc1.BorderBrush = Brushes.GreenYellow;
                oilcool1.Foreground = Brushes.GreenYellow;
                oilcool1.Text = "1 AUG 2";
            }
            ////////////////////////OIL COOL 2
            if(th != 3 && fo != 4)
            {
                oilcoolc2.BorderBrush = Brushes.GreenYellow;
                oilcool2.Foreground = Brushes.GreenYellow;
                oilcool2.Text = "AUG";
            }
            if (th == 3 && fo != 4)
            {
                oilcoolc2.BorderBrush = Brushes.GreenYellow;
                oilcool2.Foreground = Brushes.GreenYellow;
                oilcool2.Text = "3 AUG";
            }
            if (th != 3 && fo == 4)
            {
                oilcoolc2.BorderBrush = Brushes.GreenYellow;
                oilcool2.Foreground = Brushes.GreenYellow;
                oilcool2.Text = "AUG 4";
            }
            if (th == 3 && fo == 4)
            {
                oilcoolc2.BorderBrush = Brushes.GreenYellow;
                oilcool2.Foreground = Brushes.GreenYellow;
                oilcool2.Text = "3 AUG 4";
            }

           
            ///////////////////////////////////////////////////////////////EOQ P////////////////////////////////////////////////////////////

            int p1 = 1;
            int p2 = 1;
            int p3 = 1;
            int p4 = 1;
            ////////////////////////EOQ P1
            if (p1 == 1 && p2 != 1)
            {
                eoqpc1.BorderBrush = Brushes.Yellow;
                eoqpt1.Foreground = Brushes.Yellow;
                eoqpt1.Text = "1 PRP";
            }
            if (p1 != 1 && p2 == 1)
            {
                eoqpc1.BorderBrush = Brushes.Yellow;
                eoqpt1.Foreground = Brushes.Yellow;
                eoqpt1.Text = "PRP 2";
            }
            if (p1 == 1 && p2 == 1)
            {
                eoqpc1.BorderBrush = Brushes.Yellow;
                eoqpt1.Foreground = Brushes.Yellow;
                eoqpt1.Text = "1 PRP 2";
            }
            ////////////////////////EOQ P2
            if (p3 == 1 && p4 != 1)
            {
                eoqpc2.BorderBrush = Brushes.Yellow;
                eoqpt2.Foreground = Brushes.Yellow;
                eoqpt2.Text = "3 PRP";
            }
            if (p3 != 1 && p4 == 1)
            {
                eoqpc2.BorderBrush = Brushes.Yellow;
                eoqpt2.Foreground = Brushes.Yellow;
                eoqpt2.Text = "PRP 4";
            }
            if (p3 == 1 && p4 == 1)
            {
                eoqpc2.BorderBrush = Brushes.Yellow;
                eoqpt2.Foreground = Brushes.Yellow;
                eoqpt2.Text = "3 PRP 4";
            }
        }
    }
}
