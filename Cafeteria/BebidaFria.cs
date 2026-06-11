using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCafeteria2.Cafeteria
{
    internal class BebidaFria: Bebida//poner el nombre de la clase para indicar la herencia
    {
        private float CantidadHielo;

        public float cantidadHielo
        {
            get { return CantidadHielo; }
            set { CantidadHielo = value; }
        }
        //contructor parametrizado
        public BebidaFria(string _nombre, string _tamaño, float _precio, float _cantidadHielo) : base(_nombre, _tamaño, _precio)
        {
            CantidadHielo = _cantidadHielo;
        }

        //metodo sobreescrito(Polimorfismo)
        public override string Preparar()
        {
            return "Preparando un: " + Nombre + " Frio con: " + cantidadHielo +" cubos de hielo de tamaño: " + Tamaño;
        }
        public string Listar()
        {
            return "Un/a " + Nombre + " fria";
        }
    }
}
