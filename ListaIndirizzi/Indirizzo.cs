using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    public class Indirizzo
    {
        private string name;
        private string surname;
        private string street;
        private string city;
        private string state;
        private string zip;

        public Indirizzo(string name, string surname, string street, string city, string state, string zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }

        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public string GetString()
        {
            return street;
        }
        public string GetCity()
        {
            return city;
        }
        public string GetState()
        {
            return state;
        }
        public string GetZip()
        {
            return zip;
        }

        public override string ToString()
        {
            return $"L'indirizzo di {name} {surname} è {street} {city} {state} {zip}"; 
        }
    }
}
