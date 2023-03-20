using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoorioRepaso6
{
    internal class Vehiculo
        // Las clases tienen que ir en singular para que nuestra lista sea en plural
        // y se nos sea mas facil de entender en el codigo.
    {
        string placa;
        string marca;
        int modelo;
        string color;
        double precioKilometro;
        // Las variables no se tienen que llamar igual que la clase.
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public double PrecioKilometro { get => precioKilometro; set => precioKilometro = value; }
    }
}
