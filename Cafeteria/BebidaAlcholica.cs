using pryCafeteria2.Cafeteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCafeteria.Cafeteria
{
    internal class BebidaAlcholica : Bebida
    {
        private float GradosAlcohol;

        public float gradosAlcohol
        {
            get { return GradosAlcohol; }
            set { GradosAlcohol = value; }
        }

        //constructor en cuando heredamos parametrizado
        public BebidaAlcholica(string _nombre, string _tamaño, float _precio, float _gradosA) : base(_nombre, _tamaño, _precio)
        {
            GradosAlcohol = _gradosA;
        }

        //metodo sobreescrito(Polimorfismo)
        public override string Preparar()
        {
            return "Preparando un: " + Nombre + " con " + " grados de alchol " + " de tamaño: " + Tamaño;
        }
        public string Listar()
        {
            return "Un/a " + Nombre + " de " + gradosAlcohol + " con grados de alcohol";
        }
    }
}
