using Superheroes.Clases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroesMVVM
{
    class ServicioSuperheroes
    {
        public ObservableCollection<Superheroe> GetSuperheroes()
        {
            return Superheroe.GetSamples();
        }
    }
}
