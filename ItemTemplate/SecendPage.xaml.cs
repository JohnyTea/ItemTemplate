using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=234238

namespace ItemTemplate
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class SecendPage : Page
    {
        private ObservableCollection<model> Models;
        private model selectedModel;
        public SecendPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Models = (ObservableCollection<model>) e.Parameter;
        }

        private void listaCar_GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedModel = (model)listaCar_GridView.SelectedItem;
            ObrazAuta_Image.Source = new BitmapImage(new Uri(selectedModel.Obrazek));
        }

        private void usun()
        {
            if (selectedModel != null)
            {
                Models.Remove((model)listaCar_GridView.SelectedItem);
            }
        }

        private void dodaj(string nazwa, int cena, string obraz)
        {
            model nowySamochod = new model(nazwa, cena, obraz);
            Models.Add(nowySamochod);
        }
    }
}
