using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCafeteria2.Cafeteria
{
    internal class BebidaCaliente:Bebida //poner el nombre de la clase para indicar la herencia
    {
        private float Temperatura;

        public float temperatura
        {
            get { return Temperatura; }
            set { Temperatura = value; }
        }

        //constructor en cuando heredamos parametrizado
        public BebidaCaliente(string _nombre, string _tamaño, float _precio, float _temperatura) : base(_nombre, _tamaño, _precio)
        {
            Temperatura = _temperatura;
        }

        //metodo sobreescrito(Polimorfismo)
        public override string Preparar()
        {
            return "Preparando un: " + Nombre + " Caliente de tamaño: " + Tamaño;
        }
        public string Listar()
        {
            return "Un/a " + Nombre + " caliente";
        }
    }
}
