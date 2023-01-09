using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Superheroes.Clases
{
    internal class Superheroe : ObservableObject
    {
        private bool heroe;
        private bool xmen;
        private bool vengador;
        private string imagen;
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }

        public string Imagen
        {
            get { return imagen; }
            set { SetProperty(ref imagen, value); }
        }
        public bool Vengador
        {
            get { return vengador; }
            set { SetProperty(ref vengador, value); }
        }
        public bool Xmen
        {
            get { return xmen; }
            set { SetProperty(ref xmen, value); }
        }
        public bool Heroe
        {
            get { return heroe; }
            set { SetProperty(ref heroe, value); }
        }

        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }

        public static ObservableCollection<Superheroe> GetSamples()
        {
            ObservableCollection<Superheroe> ejemplos = new ObservableCollection<Superheroe>();

            Superheroe ironman = new Superheroe("Ironman", @"https://dossierinteractivo.com/wp-content/uploads/2021/01/Iron-Man.png", true, false, true);
            Superheroe kingpin = new Superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false);
            Superheroe spiderman = new Superheroe("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true, true);

            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);

            return ejemplos;
        }
    }
}
