﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Baskervilles
{
    public partial class App : Application
    {
        public App()
        {
            //MainPage = new BaskervillesPage();
            //MainPage = new VariableFormattedTextPage();
            //MainPage = new VariableFormattedParagraphPage();
            MainPage = new NamedFontSizesPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
