﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Threading;

namespace InfoReaderV2
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {




        enum Der { bmb95, bmb95R2, bmb98, eud, eud1, eud2, eudGold, gasnoUlje };
        public MainWindow()
        {
            InitializeComponent();


        }



        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9,.-]+"); //regex that matches disallowed text
            return !regex.IsMatch(text);
        }

        private static bool IsTextAllowedTemp(string text)
        {
            Regex regex = new Regex("[^0-9-]"); //regex that matches disallowed text
            return !regex.IsMatch(text);
        }




        private void txtIn_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.MaxLength = 7;
            e.Handled = !IsTextAllowed(e.Text);


        }

        private void txtIn_PreviewTextTemp(object sender, TextCompositionEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.MaxLength = 3;
            e.Handled = !IsTextAllowedTemp(e.Text);

        }
        public void CalculatorZapremine(TextBox textBox, int[] tabela, TextBlock result)
        {

            if (textBox.Text.Contains(",") || textBox.Text.Contains("."))
            {
                double inp = Double.Parse(textBox.Text.Replace(",", "."));
                double decimall = (inp - Math.Truncate(inp)) * 10;
                int index = (int)Math.Truncate(inp);
                double test = (tabela[index + 1] - tabela[index]);
                double test2 = test / 10 * decimall + tabela[index];

                result.Text = Math.Round(test2).ToString() + " lit";
            }
            else
            {
                int i = Int32.Parse(textBox.Text);

                result.Text = tabela[i].ToString() + " lit";

            }
        }





      

        private void Kalkulacija(Der goriva,bool prijem)
        {


            switch (goriva)
            {

                case Der.bmb95:
                              
                                  
                        CalculatorZapremine(txtInBmb95, Derivati.litBmb95, outBmb95);
         
                    break;
                case Der.bmb95R2:
                    CalculatorZapremine(txtInBmb95R2, Derivati.litBmb95R2, outBmb95R2);
                    break;
                case Der.bmb98:
                    CalculatorZapremine(txtInBmb98, Derivati.litBmb98, outBmb98);
                    break;
                case Der.eud:
                    CalculatorZapremine(txtInDizel, Derivati.dizel, outDizel);
                    break;
                case Der.eud1:
                    CalculatorZapremine(txtInDizel1, Derivati.dizelR2, outDizel1);
                    break;
                case Der.eud2:
                    CalculatorZapremine(txtInDizel2, Derivati.dizelR3, outDizel2);
                    break;
                case Der.eudGold:
                    CalculatorZapremine(txtInGold, Derivati.eudGold, outGold);
                    break;
                case Der.gasnoUlje:
                    CalculatorZapremine(txtInGasnoUlje, Derivati.gasnoUlje, outGasnoUlje);
                    break;

            }
        }




        private void txtInBmb95_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (txtInBmb95.Text == "")
                {
                    return;
                }
                try
                {
                    Kalkulacija(Der.bmb95,false);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }

        }
        private void txtInBmb95R2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (txtInBmb95R2.Text == "")
                {
                    return;
                }
                try
                {
                    Kalkulacija(Der.bmb95R2,false);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);

            }
        }
        private void txtInBmb98_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (txtInBmb98.Text == "")
                {
                    return;
                }
                try
                {
                    Kalkulacija(Der.bmb98,false);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }

        }
        private void txtInDizel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (txtInDizel.Text == "")
                {
                    return;
                }
                try
                {
                    Kalkulacija(Der.eud,false);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }
        }
        private void txtInDizel1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.MaxLength = 5;

            if (e.Key == Key.Enter)
            {
                if (txtInDizel1.Text == "")
                {
                    return;
                }
                try
                {
                    Kalkulacija(Der.eud1,false);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }

                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }
        private void txtInDizel2_KeyDown(object sender, KeyEventArgs e)
        {

            TextBox box = (TextBox)sender;
            box.MaxLength = 5;

            if (e.Key == Key.Enter)
            {
                if (txtInDizel2.Text == "")
                {
                    return;
                }
                try
                {
                    Kalkulacija(Der.eud2,false);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }

                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }


        }
        private void txtInGold_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.MaxLength = 5;

            if (e.Key == Key.Enter)
            {
                if (txtInGold.Text == "")
                {
                    return;
                }
                try
                {
                    Kalkulacija(Der.eudGold,false);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }

                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }

        private void txtInGasnoUlje_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.MaxLength = 5;

            if (e.Key == Key.Enter)
            {
                if (txtInGasnoUlje.Text == "")
                {
                    return;
                }
                try
                {
                    Kalkulacija(Der.gasnoUlje,false);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                }

                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }




        #region PrijemBMB98

        private void prBmb98_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (prBmb98.Text == "")
                {
                    return;
                }
                if (prBmb98.Text.Contains(",") || prBmb98.Text.Contains("."))
                {
                    try
                    {
                        double inp = Double.Parse(prBmb98.Text.Replace(",", "."));
                        double decimall = (inp - Math.Truncate(inp)) * 10;
                        int index = (int)Math.Truncate(inp);
                        double test = (Derivati.litBmb98[index + 1] - Derivati.litBmb98[index]);
                        double test2 = test / 10 * decimall + Derivati.litBmb98[index];
                        prBmb98out.Text = test2.ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                else
                {
                    int i = Int32.Parse(prBmb98.Text);
                    try
                    {
                        prBmb98out.Text = Derivati.litBmb98[i].ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                double max = Double.Parse(max98.Text);
                double d = max - double.Parse(prBmb98out.Text);
                raspolozivo.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d));
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }
        }

        private void tempBmb98_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (tempBmb98.Text == "")
                {
                    return;
                }
                try
                {
                    koefBmb98.Text = Derivati.korekcijaBmb(tempBmb98.Text).ToString();
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijom.Text = Korekcija(prBmb98out.Text, tempBmb98.Text, koefBmb98.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }


        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (litSipka.Text == "")
                {
                    return;
                }
                sipka.Text = Derivati.litToNiv(Derivati.litBmb98, prBmb98out.Text, litSipka.Text) + "(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            prBmb98.Clear();
            prBmb98out.Text = "0";
            litSaKorekcijom.Text = "0";
            tempBmb98.Clear();
            koefBmb98.Text = "0";
            litSipka.Clear();
            raspolozivo.Text = "";

        }


        #endregion

        #region PrijemBMB95


        private void prBmb95_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (prBmb95.Text == "")
                {
                    return;
                }
                if (prBmb95.Text.Contains(",") || prBmb95.Text.Contains("."))
                {
                    try
                    {
                        double inp = Double.Parse(prBmb95.Text.Replace(",", "."));
                        double decimall = (inp - Math.Truncate(inp)) * 10;
                        int index = (int)Math.Truncate(inp);
                        double test = (Derivati.litBmb95[index + 1] - Derivati.litBmb95[index]);
                        double test2 = test / 10 * decimall + Derivati.litBmb95[index];
                        prBmb95out.Text = test2.ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                else
                {
                    int i = Int32.Parse(prBmb95.Text);
                    try
                    {
                        prBmb95out.Text = Derivati.litBmb95[i].ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }

                CalculatorZapremine(prBmb95, Derivati.litBmb95, prBmb95out);
                //double max = Double.Parse(max95.Text);
                //double d = max - double.Parse(prBmb95out.Text);
                //raspolozivoBmb95.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d).ToString());
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }
        }

        private void tempBmb95_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (tempBmb95.Text == "")
                {
                    return;
                }
                try
                {
                    koefBmb95.Text = Derivati.korekcijaBmb(tempBmb95.Text).ToString();
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijomBmb95.Text = Korekcija(prBmb95out.Text, tempBmb95.Text, koefBmb95.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }


        private void TextBox_KeyDownBmb95(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (litSipkaBmb95.Text == "")
                {
                    return;
                }
                sipkaBmb95.Text = Derivati.litToNiv(Derivati.litBmb95, prBmb95out.Text, litSipkaBmb95.Text) + "(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }

        private void ButtonBmb95_Click(object sender, RoutedEventArgs e)
        {

            prBmb95.Clear();
            prBmb95out.Text = "0";
            litSaKorekcijomBmb95.Text = "0";
            tempBmb95.Clear();
            koefBmb95.Text = "0";
            litSipkaBmb95.Clear();
            raspolozivoBmb95.Text = "";

        }


        #endregion

        #region prijemBMB95R2

        private void prBmb95R2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (prBmb95R2.Text == "")
                {
                    return;
                }
                if (prBmb95R2.Text.Contains(",") || prBmb95R2.Text.Contains("."))
                {
                    try
                    {
                        double inp = Double.Parse(prBmb95R2.Text.Replace(",", "."));
                        double decimall = (inp - Math.Truncate(inp)) * 10;
                        int index = (int)Math.Truncate(inp);
                        double test = (Derivati.litBmb95R2[index + 1] - Derivati.litBmb95R2[index]);
                        double test2 = test / 10 * decimall + Derivati.litBmb95R2[index];
                        prBmb95outR2.Text = test2.ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                else
                {
                    int i = Int32.Parse(prBmb95R2.Text);
                    try
                    {
                        prBmb95outR2.Text = Derivati.litBmb95R2[i].ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                double max = Double.Parse(max95R2.Text);
                double d = max - double.Parse(prBmb95outR2.Text);
                raspolozivoBmb95R2.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d).ToString());
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }

        }

        private void tempBmb95R2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (tempBmb95R2.Text == "")
                {
                    return;
                }
                try
                {
                    koefBmb95R2.Text = Derivati.korekcijaBmb(tempBmb95R2.Text).ToString();
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijomBmb95R2.Text = Korekcija(prBmb95outR2.Text, tempBmb95R2.Text, koefBmb95R2.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }


        private void TextBox_KeyDownBmb95R2(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (litSipkaBmb95R2.Text == "")
                {
                    return;
                }
                sipkaBmb95R2.Text = Derivati.litToNiv(Derivati.litBmb95R2, prBmb95outR2.Text, litSipkaBmb95R2.Text) + "(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }


        private void ButtonBmb95R2_Click(object sender, RoutedEventArgs e)
        {

            prBmb95R2.Clear();
            prBmb95outR2.Text = "0";
            litSaKorekcijomBmb95R2.Text = "0";
            tempBmb95R2.Clear();
            koefBmb95R2.Text = "0";
            litSipkaBmb95R2.Clear();
            raspolozivoBmb95R2.Text = "";


        }



        #endregion


        #region PrijemEUD

        private void prEud_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (prEud.Text == "")
                {
                    return;
                }
                if (prEud.Text.Contains(",") || prEud.Text.Contains("."))
                {
                    try
                    {
                        double inp = Double.Parse(prEud.Text.Replace(",", "."));
                        double decimall = (inp - Math.Truncate(inp)) * 10;
                        int index = (int)Math.Truncate(inp);
                        double test = (Derivati.dizel[index + 1] - Derivati.dizel[index]);
                        double test2 = test / 10 * decimall + Derivati.dizel[index];
                        prEudOut.Text = test2.ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                else
                {
                    int i = Int32.Parse(prEud.Text);
                    try
                    {
                        prEudOut.Text = Derivati.dizel[i].ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                double max = Double.Parse(maxEud.Text);
                double d = max - double.Parse(prEudOut.Text);
                raspolozivoEud.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d).ToString());
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }

        }


        private void tempEud_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (tempEud.Text == "")
                {
                    return;
                }

                try
                {
                    koefEud.Text = Derivati.korekcijaEud(tempEud.Text).ToString();
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijomEud.Text = Korekcija(prEudOut.Text, tempEud.Text, koefEud.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }

        private void TextBox_KeyDownEud(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (litSipkaEud.Text == "")
                {
                    return;
                }
                sipkaEud.Text = Derivati.litToNiv(Derivati.dizel, prEudOut.Text, litSipkaEud.Text) + "(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }

        private void ButtonEud_Click(object sender, RoutedEventArgs e)
        {
            prEud.Clear();
            prEudOut.Text = "0";
            litSaKorekcijomEud.Text = "0";
            tempEud.Clear();
            koefEud.Text = "0";
            litSipkaEud.Clear();
            raspolozivoEud.Text = "";
        }







        #endregion

        #region PrijemEUD2
        private void prEud1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.Key == Key.Enter)
            {
                if (prEud1.Text == "")
                {
                    return;
                }
                if (prEud1.Text.Contains(",") || prEud1.Text.Contains("."))
                {
                    try
                    {
                        double inp = Double.Parse(prEud1.Text.Replace(",", "."));
                        double decimall = (inp - Math.Truncate(inp)) * 10;
                        int index = (int)Math.Truncate(inp);
                        double test = (Derivati.dizelR2[index + 1] - Derivati.dizelR2[index]);
                        double test2 = test / 10 * decimall + Derivati.dizelR2[index];
                        prEudOut1.Text = test2.ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                else
                {
                    int i = Int32.Parse(prEud1.Text);
                    try
                    {
                        prEudOut1.Text = Derivati.dizelR2[i].ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                double max = Double.Parse(maxEud1.Text);
                double d = max - double.Parse(prEudOut1.Text);
                raspolozivoEud1.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d).ToString());
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);





            }




        }

        private void tempEud1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (tempEud1.Text == "")
                {
                    return;
                }

                try
                {
                    koefEud1.Text = Derivati.korekcijaEud(tempEud1.Text).ToString();
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijomEud1.Text = Korekcija(prEudOut1.Text, tempEud1.Text, koefEud1.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }
        private void ButtonEud1_Click(object sender, RoutedEventArgs e)
        {
            prEud1.Clear();
            prEudOut1.Text = "0";
            litSaKorekcijomEud1.Text = "0";
            tempEud1.Clear();
            koefEud1.Text = "0";
            litSipkaEud1.Clear();
            raspolozivoEud1.Text = "";
        }


        private void TextBox_KeyDownEud1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (litSipkaEud1.Text == "")
                {
                    return;
                }
                sipkaEud1.Text = Derivati.litToNiv(Derivati.dizelR2, prEudOut1.Text, litSipkaEud1.Text) + "(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }


        }







        #endregion

        #region prijemEUD3
        private void prEud2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (prEud2.Text == "")
                {
                    return;
                }
                if (prEud2.Text.Contains(",") || prEud2.Text.Contains("."))
                {
                    try
                    {
                        double inp = Double.Parse(prEud2.Text.Replace(",", "."));
                        double decimall = (inp - Math.Truncate(inp)) * 10;
                        int index = (int)Math.Truncate(inp);
                        double test = (Derivati.dizelR3[index + 1] - Derivati.dizelR3[index]);
                        double test2 = test / 10 * decimall + Derivati.dizelR3[index];
                        prEudOut2.Text = test2.ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                else
                {
                    int i = Int32.Parse(prEud2.Text);
                    try
                    {
                        prEudOut2.Text = Derivati.dizelR3[i].ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                double max = Double.Parse(maxEud2.Text);
                double d = max - double.Parse(prEudOut2.Text);
                raspolozivoEud2.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d).ToString());
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);





            }

        }

        private void tempEud2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (tempEud2.Text == "")
                {
                    return;
                }

                try
                {
                    koefEud2.Text = Derivati.korekcijaEud(tempEud2.Text).ToString();
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijomEud2.Text = Korekcija(prEudOut2.Text, tempEud2.Text, koefEud2.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }

        private void ButtonEud2_Click(object sender, RoutedEventArgs e)
        {
            prEud2.Clear();
            prEudOut2.Text = "0";
            litSaKorekcijomEud2.Text = "0";
            tempEud2.Clear();
            koefEud2.Text = "0";
            litSipkaEud2.Clear();
            raspolozivoEud2.Text = "";


        }

        private void TextBox_KeyDownEud2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (litSipkaEud2.Text == "")
                {
                    return;
                }
                sipkaEud2.Text = Derivati.litToNiv(Derivati.dizelR3, prEudOut2.Text, litSipkaEud2.Text) + "(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }


        #endregion


        #region PrijemGOLD
        private void prGold_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.Key == Key.Enter)
            {
                if (prGold.Text == "")
                {
                    return;
                }
                if (prGold.Text.Contains(",") || prGold.Text.Contains("."))
                {
                    try
                    {
                        double inp = Double.Parse(prGold.Text.Replace(",", "."));
                        double decimall = (inp - Math.Truncate(inp)) * 10;
                        int index = (int)Math.Truncate(inp);
                        double test = (Derivati.eudGold[index + 1] - Derivati.eudGold[index]);
                        double test2 = test / 10 * decimall + Derivati.eudGold[index];
                        prGoldOut.Text = test2.ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                else
                {
                    int i = Int32.Parse(prGold.Text);
                    try
                    {
                        prGoldOut.Text = Derivati.eudGold[i].ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                double max = Double.Parse(maxGold.Text);
                double d = max - double.Parse(prGoldOut.Text);
                raspolozivoGold.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d).ToString());
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);


            }
        }
        private void tempGold_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (tempGold.Text == "")
                {
                    return;
                }
                try
                {
                    koefGold.Text = Derivati.korekcijaEud(tempGold.Text).ToString();
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijomGold.Text = Korekcija(prGoldOut.Text, tempGold.Text, koefGold.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }
        private void TextBox_KeyDownGold(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (litSipkaGold.Text == "")
                {
                    return;
                }
                sipkaGold.Text = Derivati.litToNiv(Derivati.eudGold, prGoldOut.Text, litSipkaGold.Text) + "(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }
        private void ButtonGold_Click(object sender, RoutedEventArgs e)
        {
            prGold.Clear();
            prGoldOut.Text = "0";
            litSaKorekcijomGold.Text = "0";
            tempGold.Clear();
            koefGold.Text = "0";
            litSipkaGold.Clear();
            raspolozivoGold.Text = "";
        }










        #endregion



        #region GasnoUlje
        private void prGasnoUlje_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.Key == Key.Enter)
            {
                if (prGasnoUlje.Text == "")
                {
                    return;
                }
                if (prGasnoUlje.Text.Contains(",") || prGasnoUlje.Text.Contains("."))
                {
                    try
                    {
                        double inp = Double.Parse(prGasnoUlje.Text.Replace(",", "."));
                        double decimall = (inp - Math.Truncate(inp)) * 10;
                        int index = (int)Math.Truncate(inp);
                        double test = (Derivati.gasnoUlje[index + 1] - Derivati.gasnoUlje[index]);
                        double test2 = test / 10 * decimall + Derivati.gasnoUlje[index];
                        prGasnoUljeOut.Text = test2.ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                else
                {
                    int i = Int32.Parse(prGasnoUlje.Text);
                    try
                    {
                        prGasnoUljeOut.Text = Derivati.gasnoUlje[i].ToString();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Litraža prevazilazi maksimalnu zapreminu");
                    }

                }
                double max = Double.Parse(maxGasnoUlje.Text);
                double d = max - double.Parse(prGasnoUlje.Text);
                raspolozivoGasnoUlje.Text = string.Format("DOSTUPNO {0} lit", Math.Round(d).ToString());
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);





            }




        }
        private void tempGasnoUlje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (tempGasnoUlje.Text == "")
                {
                    return;
                }

                try
                {
                    koefGasnoUlje.Text = Derivati.korekcijaEud(tempGasnoUlje.Text).ToString();
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                }
                litSaKorekcijomGasnoUlje.Text = Korekcija(prGasnoUljeOut.Text, tempGasnoUlje.Text, koefGasnoUlje.Text).ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }

        private void buttonGasnoUlje_Click(object sender, RoutedEventArgs e)
        {
            prGasnoUlje.Clear();
            prGasnoUljeOut.Text = "0";
            litSaKorekcijomGasnoUlje.Text = "0";
            tempGasnoUlje.Clear();
            koefGasnoUlje.Text = "0";
            litSipkaGasnoUlje.Clear();
            raspolozivoGasnoUlje.Text = "";
        }

        private void TextBox_litSipkaGasnoUlje(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (litSipkaGasnoUlje.Text == "")
                {
                    return;
                }
                sipkaGasnoUlje.Text = Derivati.litToNiv(Derivati.gasnoUlje, prGasnoUljeOut.Text, litSipkaGasnoUlje.Text) + "(cm)".ToString();
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }

        }


        #endregion









        private double Korekcija(string litraza, string temp, string koef)
        {

            double koe = double.Parse(koef);
            double lit = double.Parse(litraza);
            int Temp = int.Parse(temp);
            double result;
            if (Temp < 15)
            {
                result = (lit / 1000 * koe) + lit;

            }
            else
            {
                result = lit - (lit / 1000 * koe);
            }
            return Math.Round(result);
        }



        private void nivo_Click(object sender, RoutedEventArgs e)
        {
            txtInBmb98.Clear();
            txtInBmb95.Clear();
            txtInBmb95R2.Clear();
            txtInDizel.Clear();
            txtInDizel1.Clear();
            txtInGold.Clear();
            txtInDizel2.Clear();
            txtInGasnoUlje.Clear();
            outBmb98.Text = "0 lit";
            outBmb95.Text = "0 lit";
            outBmb95R2.Text = "0 lit";
            outDizel.Text = "0 lit";
            outDizel1.Text = "0 lit";
            outGold.Text = "0 lit";
            outGasnoUlje.Text = "0 lit";
            outDizel2.Text = "0 lit";


        }



        private void TextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string theDir = filePath + @"\TabliceRezervoara";
                string goriva = theDir + @"\programData.txt";

                string[] data = { cene98.Text, cene95.Text, ceneEud.Text, ceneGold.Text, ceneTng.Text, ceneGasnoUlje.Text, max98.Text, max95.Text, maxEud.Text, maxGold.Text, maxEud1.Text, maxEud2.Text, maxGasnoUlje.Text, max95R2.Text };
                File.WriteAllLines(goriva, data);

                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }



        bool bmbCheck = false;
        private void radioBmb_Checked(object sender, RoutedEventArgs e)
        {
            bmbCheck = true;
            dizelCheck = false;
            litVolumetar.Clear();
            tempVolumetar.Clear();
            koefVolumetar.Text = "0";
            litSaKorekcijomVol.Text = "0";
        }
        bool dizelCheck = false;
        private void radioDizel_Checked(object sender, RoutedEventArgs e)
        {
            dizelCheck = true;
            bmbCheck = false;
            litVolumetar.Clear();
            tempVolumetar.Clear();
            koefVolumetar.Text = "0";
            litSaKorekcijomVol.Text = "0";

        }

        private void tempVolumetar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (tempVolumetar.Text == "")
                {
                    return;
                }
                if (bmbCheck == true)
                {

                    try
                    {
                        koefVolumetar.Text = Derivati.korekcijaBmb(tempVolumetar.Text).ToString();
                    }
                    catch (KeyNotFoundException)
                    {
                        MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                    }
                    if (litVolumetar.Text == "")
                    {
                        return;
                    }
                    litSaKorekcijomVol.Text = Korekcija(litVolumetar.Text.Replace(",", "."), tempVolumetar.Text, koefVolumetar.Text).ToString();

                }
                else if (dizelCheck == true)
                {
                    try
                    {
                        koefVolumetar.Text = Derivati.korekcijaEud(tempVolumetar.Text).ToString();
                    }
                    catch (KeyNotFoundException)
                    {
                        MessageBox.Show("KOEFICIJENTI SU IZRAŽENI ZA TEMPERATURE OD -10 DO 40 ⁰C");
                    }
                    if (litVolumetar.Text == "")
                    {
                        return;
                    }
                    litSaKorekcijomVol.Text = Korekcija(litVolumetar.Text.Replace(",", "."), tempVolumetar.Text, koefVolumetar.Text).ToString();
                }



            }
        }

        private void litVolumetar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Right);
                request.Wrapped = true;
                ((TextBox)sender).MoveFocus(request);
            }
        }

        private void Win_Loaded(object sender, RoutedEventArgs e)
        {
            Files.fileCreate();

           
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string theDir = filePath + @"\TabliceRezervoara";
            string goriva = theDir + @"\programData.txt";

            if (File.Exists(goriva))
            {
                string[] data = File.ReadAllLines(goriva);
                try
                {
                    cene98.Text = data[0];
                    cene95.Text = data[1];
                    ceneEud.Text = data[2];
                    ceneGold.Text = data[3];
                    ceneTng.Text = data[4];
                    ceneGasnoUlje.Text = data[5];
                    max98.Text = data[6];
                    max95.Text = data[7];
                    maxEud.Text = data[8];
                    maxGold.Text = data[9];
                    maxEud1.Text = data[10];
                    maxEud2.Text = data[11];
                    maxGasnoUlje.Text = data[12];
                    max95R2.Text = data[13];
                }
                catch (Exception)
                {


                }


            }

            DispatcherTimer dp = new DispatcherTimer();
            dp.Interval = TimeSpan.FromSeconds(1);
            dp.Tick += Dp_Tick;
            dp.Start();

        }


        private void Dp_Tick(object sender, EventArgs e)
        {
            Time.Content = DateTime.Now.ToString("HH:mm");
            datum.Content = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void textBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Kalkulator Zapremine\nDeveloped by Ognjen Ninković\nCopyright(C)Ognjen Ninković\nEmail: Oninkovic5@gmail.com",
                "About", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string theDir = filePath + @"\TabliceRezervoara";
            string goriva = theDir + @"\programData.txt";

            string[] data = { cene98.Text, cene95.Text, ceneEud.Text, ceneGold.Text, ceneTng.Text, ceneGasnoUlje.Text, max98.Text, max95.Text, maxEud.Text, maxGold.Text, maxEud1.Text, maxEud2.Text, maxGasnoUlje.Text };
            File.WriteAllLines(goriva, data);


        }


    }


    public class Files
    {

        public static void fileCreate()
        {
            string TheDir = @"\TabliceRezervoara";
            string curentDir = Directory.GetCurrentDirectory() + TheDir;
            string thePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string theDir = thePath + TheDir;


            string bmb98 = theDir + @"\bmb98.txt";
            string bmb95 = theDir + @"\bmb95.txt";
            string bmb95R2 = theDir + @"\bmb95R2.txt";
            string eud = theDir + @"\eud.txt";
            string eudR2 = theDir + @"\eudR2.txt";
            string eudR3 = theDir + @"\eudR3.txt";
            string eudGold = theDir + @"\eudGold.txt";
            string gasnoUlje = theDir + @"\gasnoUlje.txt";


            if (Directory.Exists(curentDir))
            {
                Directory.Move(curentDir, theDir);
            }
            else if (!Directory.Exists(theDir))
            {
                Directory.CreateDirectory(theDir);
                File.Create(bmb98).Dispose();
                File.Create(bmb95).Dispose();
                File.Create(bmb95R2).Dispose();
                File.Create(eud).Dispose();
                File.Create(eudR2).Dispose();
                File.Create(eudR3).Dispose();
                File.Create(eudGold).Dispose();
                File.Create(gasnoUlje).Dispose();
            }


            Derivati.litBmb98 = GetArray(bmb98);
            Derivati.litBmb95 = GetArray(bmb95);
            Derivati.litBmb95R2 = GetArray(bmb95R2);
            Derivati.dizel = GetArray(eud);
            Derivati.dizelR2 = GetArray(eudR2);
            Derivati.dizelR3 = GetArray(eudR3);
            Derivati.eudGold = GetArray(eudGold);
            Derivati.gasnoUlje = GetArray(gasnoUlje);




        }

        private static int[] GetArray(string filePath)
        {
            List<int> parsedNum = new List<int>();
            if (File.Exists(filePath))
            {
                string[] fileContent = File.ReadAllLines(filePath);
                foreach (string line in fileContent)
                {
                    string[] s = line.Split(',');
                    int num;
                    foreach (string item in s)
                    {
                        if (Int32.TryParse(item, out num))
                        {
                            parsedNum.Add(num);
                        }
                    }

                    parsedNum.Sort();
                }
            }


            return parsedNum.ToArray();
        }
    }

}










