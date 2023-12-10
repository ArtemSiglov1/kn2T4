using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т12кп3
{
    internal class Car
    {
        string marka, model,nom;
        public string Marka
        {
            get { return marka; } set {  marka = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public Car() { }
        public Car(string marka, string model, string nom)
        {
            this.marka = marka;
            this.model = model;
            this.nom = nom;
           
        }
        public override string ToString() 
        {
            return $"Marka-{marka}\tModel-{model}\t nom-{nom}";
        }
        public string Start()
        {
            return $"Машина {marka} {model} завелась";
        }
        public string Stop()
        {
            return $"Машина {marka} {model} остановилась";
        }
    }
}
