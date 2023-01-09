using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Superheroes.Clases;
using SuperheroesMVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.VistaModelo
{
    class MainWindowVM : ObservableObject
    {
        private Superheroe heroeActual;

        public Superheroe HeroeActual
        {
            get { return heroeActual; }
            set { SetProperty(ref heroeActual, value); }
        }

        private int actual;

        public int Actual
        {
            get { return actual; }
            set { SetProperty(ref actual, value); }
        }

        private int total;

        public int Total
        {
            get { return total; }
            set { SetProperty(ref total, value); }
        }
        public RelayCommand SiguienteCommand { get; }
        public RelayCommand AnteriorCommand { get; }

        private ServicioSuperheroes servicioSuperheroes;

        ObservableCollection<Superheroe> listaSuperheroes;
        public MainWindowVM()
        {
            servicioSuperheroes = new ServicioSuperheroes();
            listaSuperheroes = servicioSuperheroes.GetSuperheroes();
            SiguienteCommand = new RelayCommand(Avanzar);
            AnteriorCommand = new RelayCommand(Retroceder);

            this.HeroeActual = listaSuperheroes[0];
            this.Actual = 1;
            this.Total = listaSuperheroes.Count;
        }
        public void Avanzar()
        {
            if (Actual < Total)
            {
                Actual++;
                HeroeActual = listaSuperheroes[Actual - 1];
            }

        }
        public void Retroceder()
        {
            if (Actual > 1)
            {
                Actual--;
                HeroeActual = listaSuperheroes[Actual - 1];
            }
        }
    }
}
