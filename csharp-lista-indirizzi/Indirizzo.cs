using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Indirizzo
    {
        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private string zip;

        public Indirizzo(string name, string surname, string street, string city, string province, string zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        public string GetStreet()
        {
            return this.street;
        }

        public string GetCity()
        {
            return this.city;
        }

        public string GetProvince()
        {
            return this.province;
        }

        public string GetZip()
        {
            return this.zip;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public void SetStreet(string street)
        {
            this.street = street;
        }

        public void SetCity(string city)
        {
            this.city = city;
        }

        public void SetProvince(string province)
        {
            this.province = province;
        }

        public void SetZip(string zip)
        {
            this.zip = zip;
        }

        public override string ToString()
        {
            return this.GetName() + "," + GetSurname() + "," + GetStreet() + "," + GetCity() + "," + GetProvince() + "," + GetZip();
        }
    }
}
