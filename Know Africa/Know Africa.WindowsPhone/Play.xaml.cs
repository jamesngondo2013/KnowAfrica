using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Know_Africa
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Play : Page
    {
        DispatcherTimer myDispatcherTimer = new DispatcherTimer();
        List<Action> methods = new List<Action>();
        List<string> fourCountries = new List<string>();
        String countryGuess, country;
        int score, timeLeft;
        Random random = new Random();


        public Play()
        {
            this.InitializeComponent();
            AddMethodsAndTimer();
            newCountry();
        }

        private void AddMethodsAndTimer()
        {
            myDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            myDispatcherTimer.Tick += Each_Tick;
            myDispatcherTimer.Start();

            methods.Add(Algeria);
            methods.Add(Angola);
            methods.Add(Benin);
            methods.Add(Botswana);
            methods.Add(BukinaFaso);
            methods.Add(Burundi);
            methods.Add(Cameroon);
            methods.Add(CapeVerde);
            methods.Add(CentralAfricanRepublic);
            methods.Add(Chad);
            methods.Add(Comoros);
            methods.Add(Congo);
            methods.Add(IvoryCoast);
            methods.Add(Djibouti);
            methods.Add(Egypt);
            methods.Add(EquatorialGuinea);
            methods.Add(Eritrea);
            methods.Add(Ethiopia);
            methods.Add(Gabon);
            methods.Add(Gambia);
            methods.Add(Ghana);
            methods.Add(GuineaBissau);
            methods.Add(Guinea);
            methods.Add(Kenya);
            methods.Add(Lesotho);
            methods.Add(Liberia);
            methods.Add(Libya);
            methods.Add(Madagascar);
            methods.Add(Malawi);
            methods.Add(Mali);
            methods.Add(Mauritania);
            methods.Add(Mauritius);
            methods.Add(Morocco);
            methods.Add(Mozambique);
            methods.Add(Namibia);
            methods.Add(Niger);
            methods.Add(Nigeria);
            methods.Add(Rwanda);
            methods.Add(Senegal);
            methods.Add(Seychelles);
            methods.Add(SierraLeone);
            methods.Add(Somalia);
            methods.Add(SouthAfrica);
            methods.Add(SouthSudan);
            methods.Add(Sudan);
            methods.Add(Swaziland);
            methods.Add(Tanzania);
            methods.Add(Togo);
            methods.Add(Tunisia);
            methods.Add(Uganda);
            methods.Add(WesternSahara);
            methods.Add(Zambia);
            methods.Add(Zimbabwe);
        }

        private void newCountry()
        {
            if (methods.Count == 0)
            {
                String message;
                message = "You have guessed all Flags in Europe. \nWell Done " + "!" +
                            "\nYour score was: " + score.ToString();
                // GlobalVar.newHighScore = score;
                /*
                if (GlobalVar.newHighScore > GlobalVar.HighScoreOne)
                {
                    GlobalVar.HighScoreFive = GlobalVar.HighScoreFour;
                    GlobalVar.HighScoreNameFive = GlobalVar.HighScoreNameFour;
                    GlobalVar.HighScoreFour = GlobalVar.HighScoreThree;
                    GlobalVar.HighScoreNameFour = GlobalVar.HighScoreNameThree;
                    GlobalVar.HighScoreThree = GlobalVar.HighScoreTwo;
                    GlobalVar.HighScoreNameThree = GlobalVar.HighScoreNameTwo;
                    GlobalVar.HighScoreTwo = GlobalVar.HighScoreOne;
                    GlobalVar.HighScoreNameTwo = GlobalVar.HighScoreNameOne;
                    GlobalVar.HighScoreOne = GlobalVar.newHighScore;
                    GlobalVar.HighScoreNameOne = GlobalVar.Username;
                }
                else if (GlobalVar.newHighScore > GlobalVar.HighScoreTwo)
                {
                    GlobalVar.HighScoreFive = GlobalVar.HighScoreFour;
                    GlobalVar.HighScoreNameFive = GlobalVar.HighScoreNameFour;
                    GlobalVar.HighScoreFour = GlobalVar.HighScoreThree;
                    GlobalVar.HighScoreNameFour = GlobalVar.HighScoreNameThree;
                    GlobalVar.HighScoreThree = GlobalVar.HighScoreTwo;
                    GlobalVar.HighScoreNameThree = GlobalVar.HighScoreNameTwo;
                    GlobalVar.HighScoreTwo = GlobalVar.newHighScore;
                    GlobalVar.HighScoreNameTwo = GlobalVar.Username;
                }
                else if (GlobalVar.newHighScore > GlobalVar.HighScoreThree)
                {
                    GlobalVar.HighScoreFive = GlobalVar.HighScoreFour;
                    GlobalVar.HighScoreNameFive = GlobalVar.HighScoreNameFour;
                    GlobalVar.HighScoreFour = GlobalVar.HighScoreThree;
                    GlobalVar.HighScoreNameFour = GlobalVar.HighScoreNameThree;
                    GlobalVar.HighScoreThree = GlobalVar.newHighScore;
                    GlobalVar.HighScoreNameThree = GlobalVar.Username;
                }
                else if (GlobalVar.newHighScore > GlobalVar.HighScoreFour)
                {
                    GlobalVar.HighScoreFive = GlobalVar.HighScoreFour;
                    GlobalVar.HighScoreNameFive = GlobalVar.HighScoreNameFour;
                    GlobalVar.HighScoreFour = GlobalVar.newHighScore;
                    GlobalVar.HighScoreNameFour = GlobalVar.Username;
                }
                else if (GlobalVar.newHighScore > GlobalVar.HighScoreFive)
                {
                    GlobalVar.HighScoreFive = GlobalVar.newHighScore;
                    GlobalVar.HighScoreNameFive = GlobalVar.Username;
                }
                MessageBox.Show(message);
                NavigationService.Navigate(
                    new Uri("/ChooseLevel.xaml",
                        UriKind.RelativeOrAbsolute)
                    );
                */
                myDispatcherTimer.Stop();
            }
            else
            {
                timeLeft = 5;
                List<Action> selectedMethod = new List<Action>();
                int randomMethod;

                if (methods.Count > 0)
                {
                    randomMethod = random.Next(0, methods.Count());
                    selectedMethod.Add(methods[randomMethod]);
                    methods.RemoveAt(randomMethod);
                }

                foreach (Action method in selectedMethod)
                {
                    method();
                }
            }
        }

        private void countryRandom()
        {
            List<string> countryList = new List<string>
            {
                "Algeria",
                "Angola",
                "Benin",
                "Botswana",
                "Bukina Faso",
                "Burundi",
                "Cameroon",
                "Cape Verde",
                "Central African Republic",
                "Chad",
                "Comoros",
                "Congo",
                "Ivory Coast",
                "Djibouti",
                "Egypt",
                "Equatorial Guinea", 
                "Eritrea",
                "Ethiopia",
                "Gabon",
                "Gambia",
                "Ghana",
                "Guinea Bissau",
                "Guinea",
                "Kenya",
                "Lesotho",
                "Liberia",
                "Libya",
                "Madagascar",
                "Malawi",
                "Mali",
                "Mauritania",
                "Mauritius",
                "Morocco",
                "Mozambique",
                "Namibia",
                "Niger",
                "Nigeria",
                "Rwanda",
                "Senegal",
                "Seychelles",
                "Sierra Leone",
                "Somalia",
                "South Africa",
                "South Sudan",
                "Sudan",
                "Swaziland",
                "Tanzania",
                "Togo",
                "Tunisia",
                "Uganda",
                "Western Sahara", 
                "Zambia",
                "Zimbabwe"

            };

            List<string> randomThree = new List<string>();
            int temp;

            for (int i = 0; i < 3; i++)
            {
                temp = random.Next(0, countryList.Count());
                if (fourCountries[0] == countryList[temp])
                {
                    countryList.RemoveAt(temp);
                    temp = random.Next(0, countryList.Count());
                    randomThree.Add(countryList[temp]);
                    fourCountries.Add(randomThree[i]);
                    countryList.RemoveAt(temp);
                }
                else
                {
                    randomThree.Add(countryList[temp]);
                    fourCountries.Add(randomThree[i]);
                    countryList.RemoveAt(temp);
                }
            }// end of for loop
        } // end of Random Countries

        private void Algeria()
        {
            // BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/algeria.png");

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/algeria.png", UriKind.Absolute));
            imgFlag.Source = bitmap;
            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/algeria.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Algeria");
            country = "Algeria";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];

        } // end of Algeria

        private void Angola()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/angola.png");

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/angola.png", UriKind.Absolute));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/angola.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Angola");
            country = "Angola";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];

        } // end of Sweden

        private void Benin()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Benin.png");

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Benin.png", UriKind.Absolute));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Benin.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Benin");
            country = "Benin";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Russia

        private void Botswana()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/botswana.png");

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/botswana.png", UriKind.Absolute));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/botswana.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Botswana");
            country = "Botswana";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Albania

        private void BukinaFaso()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/bukina_faso.png");

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/bukina_faso.png", UriKind.Absolute));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/bukina_faso.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Bukina Faso");
            country = "Bukina Faso";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Andorra

        private void Burundi()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/burundi.png");

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/burundi.png", UriKind.Absolute));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/burundi.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Burundi");
            country = "Burundi";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Austria

        private void Cameroon()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Cameroon.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Cameroon.png", UriKind.Absolute));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Cameroon.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Cameroon");
            country = "Cameroon";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Belarus

        private void CapeVerde()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Cape_Verde.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Cape_Verde.png", UriKind.Absolute));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Cape_Verde.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Cape Verde");
            country = "Cape Verde";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Belgium

        private void CentralAfricanRepublic()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Central_African_Republic.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Central_African_Republic.png", UriKind.Absolute));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Central_African_Republic.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Central African Republic");
            country = "Central African Republic";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Bosnia

        private void Chad()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Chad.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Chad.png", UriKind.Absolute));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Chad.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Chad");
            country = "Chad";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Bulgaria

        private void Comoros()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Comoros.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Comoros.png", UriKind.Absolute));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Comoros.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Comoros");
            country = "Comoros";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Croatia

        private void Congo()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Congo.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Congo.png", UriKind.Absolute));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Congo.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Congo");
            country = "Congo";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Czech

        private void IvoryCoast()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/IvoryCoast.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/IvoryCoast.png", UriKind.Absolute));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/IvoryCoast.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Ivory Coast");
            country = "Ivory Coast";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Denmark

        private void Djibouti()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Djibouti.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Djibouti.png", UriKind.Absolute));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Djibouti.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Djibouti");
            country = "Djibouti";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of England

        private void Egypt()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Egypt.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Egypt.png", UriKind.Absolute));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Egypt.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Egypt");
            country = "Egypt";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Estonia

        private void EquatorialGuinea()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Equatorial_Guinea.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Equatorial_Guinea.png", UriKind.Absolute));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Equatorial_Guinea.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Equatorial Guinea");
            country = "Equatorial Guinea";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Finland

        private void Eritrea()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Eritrea.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Eritrea.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Eritrea.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Eritrea");
            country = "Eritrea";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of France

        private void Ethiopia()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Ethiopia.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Ethiopia.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Ethiopia.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Ethiopia");
            country = "Ethiopia";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Germany

        private void Gabon()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Gabon.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Gabon.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Gabon.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Gabon");
            country = "Gabon";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Greece

        private void Gambia()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Gambia.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Gambia.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Gambia.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Gambia");
            country = "Gambia";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Hungary

        private void Ghana()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Ghana.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Ghana.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Ghana.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Ghana");
            country = "Ghana";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Iceland

        private void GuineaBissau()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Guinea-Bissau.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Guinea-Bissau.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Guinea-Bissau.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Guinea Bissau");
            country = "Guinea Bissau";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Ireland

        private void Guinea()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Guinea.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Guinea.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Guinea.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Guinea");
            country = "Guinea";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Italy

        private void Kenya()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Kenya.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Kenya.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Kenya.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Kenya");
            country = "Kenya";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Kosovo

        private void Lesotho()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Lesotho.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Lesotho.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Lesotho.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Lesotho");
            country = "Lesotho";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Latvia

        private void Liberia()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Liberia.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Liberia.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Liberia.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Liberia");
            country = "Liberia";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];

        } // end of Liechtenstein

        private void Libya()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Libya.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Libya.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Libya.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Libya");
            country = "Libya";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Lithuania

        private void Madagascar()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Madagascar.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Madagascar.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Madagascar.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Madagascar");
            country = "Madagascar";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Luxembourg

        private void Malawi()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Malawi.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Malawi.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Malawi.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Malawi");
            country = "Malawi";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Macedonia

        private void Mali()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Mali.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Mali.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Mali.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Mali");
            country = "Mali";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];

        } // end of Malta

        private void Mauritania()
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.UriSource = new Uri(this.BaseUri, "Assets/Mauritania.png");

            //BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Mauritania.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Mauritania.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Mauritania");
            country = "Mauritania";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Moldova

        private void Mauritius()
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.UriSource = new Uri(this.BaseUri, "Assets/Mauritius.png");

            //BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Mauritius.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Mauritius.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Mauritius");
            country = "Mauritius";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Monaco

        private void Morocco()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Morocco.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Morocco.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Morocco.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Morocco");
            country = "Morocco";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Montenegro

        private void Mozambique()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Mozambique.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Mozambique.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Mozambique.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Mozambique");
            country = "Mozambique";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Netherlands

        private void Namibia()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Namibia.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Namibia.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Namibia.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Namibia");
            country = "Namibia";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of NorthernIreland

        private void Niger()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Niger.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Niger.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Niger.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Niger");
            country = "Niger";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Norway

        private void Nigeria()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Nigeria.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Nigeria.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Nigeria.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Nigeria");
            country = "Nigeria";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Portugal

        private void Rwanda()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Rwanda.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Rwanda.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Rwanda.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Rwanda");
            country = "Rwanda";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Romania

        private void Senegal()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Senegal.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Senegal.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Senegal.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Senegal");
            country = "Senegal";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Sardinia

        private void Seychelles()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Seychelles.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Seychelles.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("/Know Africa;component/Assets/Seychelles.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Seychelles");
            country = "Seychelles";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Sardinia

        private void SierraLeone()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Sierra_Leone.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Sierra_Leone.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("ms-appx:///Assets/Sierra_Leone.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Sierra Leone");
            country = "Sierra Leone";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Scotland

        private void Somalia()
        {
            // BitmapImage bitmap = new BitmapImage();
            // bitmap.UriSource = new Uri(this.BaseUri, "Assets/Somalia.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Somalia.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("ms-appx:///Assets/Somalia.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Somalia");
            country = "Somalia";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Serbia

        private void SouthAfrica()
        {
            // BitmapImage bitmap = new BitmapImage();
            // bitmap.UriSource = new Uri(this.BaseUri, "Assets/South_Africa.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/South_Africa.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("ms-appx:///Assets/South_Africa.jpg", UriKind.RelativeOrAbsolute));
            fourCountries.Add("South Africa");
            country = "South Africa";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Sicily

        private void SouthSudan()
        {
            // BitmapImage bitmap = new BitmapImage();
            // bitmap.UriSource = new Uri(this.BaseUri, "Assets/South_Sudan.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/South_Sudan.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("ms-appx:///Assets/South_Sudan.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("South Sudan");
            country = "South Sudan";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Slovakia

        private void Sudan()
        {
            // BitmapImage bitmap = new BitmapImage();
            // bitmap.UriSource = new Uri(this.BaseUri, "Assets/Sudan.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Sudan.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("ms-appx:///Assets/Sudan.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Sudan");
            country = "Sudan";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Slovenia

        private void Swaziland()
        {
            // BitmapImage bitmap = new BitmapImage();
            // bitmap.UriSource = new Uri(this.BaseUri, "Assets/Swaziland.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Swaziland.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("ms-appx:///Assets/Swaziland.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Swaziland");
            country = "Swaziland";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Spain

        private void Tanzania()
        {
            // BitmapImage bitmap = new BitmapImage();
            // bitmap.UriSource = new Uri(this.BaseUri, "Assets/Tanzania.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Tanzania.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("ms-appx:///Assets/Tanzania.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Tanzania");
            country = "Tanzania";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Switzerland

        private void Togo()
        {
            // BitmapImage bitmap = new BitmapImage();
            // bitmap.UriSource = new Uri(this.BaseUri, "Assets/Togo.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Togo.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("ms-appx:///Assets/Togo.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Togo");
            country = "Togo";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Turkey

        private void Tunisia()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Tunisia.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Tunisia.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("ms-appx:///Assets/Tunisia.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Tunisia");
            country = "Tunisia";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Ukraine

        private void Uganda()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Uganda.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Uganda.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("ms-appx:///Assets/Uganda.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Uganda");
            country = "Uganda";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Wales  46

        private void WesternSahara()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/western_sahara.png"); 

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/western_sahara.png"));
            imgFlag.Source = bitmap;

            // imgFlag.Source = new BitmapImage(new Uri("ms-appx:///Assets/western_sahara.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Western Sahara");
            country = "Western Sahara";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Wales  46

        private void Zambia()
        {
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.UriSource = new Uri(this.BaseUri, "Assets/Zambia.png");

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Zambia.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("ms-appx:///Assets/Zambia.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Zambia");
            country = "Zambia";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Wales  46

        private void Zimbabwe()
        {
            // BitmapImage bitmap = new BitmapImage();
            // bitmap.UriSource = new Uri(this.BaseUri, "Assets/Zimbabwe.png");

            BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Zimbabwe.png"));
            imgFlag.Source = bitmap;

            //imgFlag.Source = new BitmapImage(new Uri("ms-appx:///Assets/Zimbabwe.png", UriKind.RelativeOrAbsolute));
            fourCountries.Add("Zimbabwe");
            country = "Zimbabwe";
            countryRandom();

            List<string> randomFourCountries = new List<string>();

            int randomNum;
            while (fourCountries.Count != 0)
            {
                randomNum = random.Next(0, fourCountries.Count());
                randomFourCountries.Add(fourCountries[randomNum]);
                fourCountries.RemoveAt(randomNum);
            }

            btnOne.Content = randomFourCountries[0];
            btnTwo.Content = randomFourCountries[1];
            btnThree.Content = randomFourCountries[2];
            btnFour.Content = randomFourCountries[3];
        } // end of Wales  46

        private void checkScore()
        {
            if (score < 0)
            {
                score = 0;
                scoreBlock.Text = "Score: 0";
            }
            else
            {
                scoreBlock.Text = "Score: " + score.ToString();
            }
        }

        private void checkAnswer()
        {
            if (countryGuess == country)
            {
                score += 50;
                correctOrWrong.Text = "Correct!";
                pointsBlock.Text = "+50";
                country = "";
                checkScore();
                newCountry();
            }
            else
            {
                score -= 10;
                correctOrWrong.Text = "Try Again!";
                pointsBlock.Text = "-10";
                checkScore();

            }
        }

        //private void btnOne_Click(object sender, RoutedEventArgs e)
        //{
        //    countryGuess = "";
        //    Button temp = (Button)sender;
        //    countryGuess = temp.Content.ToString();

        //    checkAnswer();
        //}

        //private void btnThree_Click(object sender, RoutedEventArgs e)
        //{
        //    countryGuess = "";
        //    Button temp = (Button)sender;
        //    countryGuess = temp.Content.ToString();

        //    checkAnswer();
        //}

        //private void btnTwo_Click(object sender, RoutedEventArgs e)
        //{
        //    countryGuess = "";
        //    Button temp = (Button)sender;
        //    countryGuess = temp.Content.ToString();

        //    checkAnswer();
        //}

        //private void btnFour_Click(object sender, RoutedEventArgs e)
        //{
        //    countryGuess = "";
        //    Button temp = (Button)sender;
        //    countryGuess = temp.Content.ToString();

        //    checkAnswer();
        //}

        // timer
        private void Each_Tick(object sender, object e)
        {
            timer.Text = "Time: " + timeLeft--.ToString();

            if (timeLeft == 4)
            {
                correctOrWrong.Text = "";
                pointsBlock.Text = "";
            }

            if (timeLeft == -1)
            {
                score -= 25;
                checkScore();
                correctOrWrong.Text = "Too Late!";
                pointsBlock.Text = "-25";
                newCountry();
            }

        }
       
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btnThree_Tapped(object sender, TappedRoutedEventArgs e)
        {
            countryGuess = "";
            Button temp = (Button)sender;
            countryGuess = temp.Content.ToString();

            checkAnswer();
        }

        private void btnOne_Tapped(object sender, TappedRoutedEventArgs e)
        {
            countryGuess = "";
            Button temp = (Button)sender;
            countryGuess = temp.Content.ToString();

            checkAnswer();
        }

        private void btnTwo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            countryGuess = "";
            Button temp = (Button)sender;
            countryGuess = temp.Content.ToString();

            checkAnswer();
        }

        private void btnFour_Tapped(object sender, TappedRoutedEventArgs e)
        {
            countryGuess = "";
            Button temp = (Button)sender;
            countryGuess = temp.Content.ToString();

            checkAnswer();
        }
    }
}
