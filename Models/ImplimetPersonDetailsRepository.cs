using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WomenWorld.Models
{
    public class ImplimetPersonDetailsRepository : IPersonDetailsRepository
    {

        public enum contents { HimaDas = 1, Avani, MaryKom,IndraNooyi,KiranBedi,SeemaRao}
        private List<Persons> _personsList;

        public ImplimetPersonDetailsRepository()
        {
            _personsList = new List<Persons>()
            {
                new Persons() {PersonID =1,PersonName = " Dhing Express - Hima Das" ,PersonImage="~/StaticFiles/himdas3.jpg",WikipediaLinks = "https://en.wikipedia.org/wiki/Hima_Das"},
                new Persons() {PersonID =2,PersonName = "Sky Warrior - Avani Chathurvedhi" ,PersonImage="~/StaticFiles/avani2.jpg" ,WikipediaLinks = "https://en.wikipedia.org/wiki/Avani_Chaturvedi"},
                new Persons() {PersonID =3,PersonName = "Ms. Knock-out - Mary Kom" ,PersonImage="~/StaticFiles/marykom2.jpg" ,WikipediaLinks = "https://en.wikipedia.org/wiki/Mary_Kom"},
                new Persons() {PersonID =4,PersonName = "Pepsi Queen - Indra Nooyi" ,PersonImage="~/StaticFiles/indranooyi2.jpg" ,WikipediaLinks = "https://en.wikipedia.org/wiki/Indra_Nooyi"},
                new Persons() {PersonID =5,PersonName = "Kiran Bedi" ,PersonImage="~/StaticFiles/kiranbedi2.jpg" ,WikipediaLinks = "https://en.wikipedia.org/wiki/Kiran_Bedi"},
                new Persons() {PersonID =6,PersonName = "Commando - Seema Rao" ,PersonImage="~/StaticFiles/seemarao2.jpg" ,WikipediaLinks = "https://en.wikipedia.org/wiki/Seema_Rao"},

            };

        }
        public Persons GetPersonDetails(int PersonID)
        {
            return _personsList.FirstOrDefault(person => person.PersonID == PersonID);
        }

        public string Links(int PersonID)
        {
            var link =  _personsList.FirstOrDefault(person => person.PersonID == PersonID);
            
            return link.WikipediaLinks;
        }

        public string ContentPath(int id)
        {
            string path="";
            
            if(id == (int)contents.HimaDas)
            {
                path = @"StaticFiles/PDFS/himadaspdf.pdf";
            }
            else if(id == (int)contents.Avani)
            {
                path = @"StaticFiles/PDFS/Avani_Chaturvedi.pdf";
            }
            else if (id == (int)contents.MaryKom)
            {
                path = @"StaticFiles/PDFS/MaryKom.pdf";
            }
            else if (id == (int)contents.IndraNooyi)
            {
                path = @"StaticFiles/PDFS/Indra Nooyi.pdf";
            }
            else if (id == (int)contents.KiranBedi)
            {
                path = @"StaticFiles/PDFS/Kiranbedi.pdf";
            }
            else if (id == (int)contents.SeemaRao)
            {
                path = @"StaticFiles/PDFS/SeemaRao.pdf";
            }
            return path;
        }

    }
}
