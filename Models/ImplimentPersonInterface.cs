using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WomenWorld.Models
{
    public class ImplimentPersonInterface : IPersonRepository
    {

        private List<Persons> _personsList;
        public ImplimentPersonInterface()
        {
            _personsList = new List<Persons>()
            {
                new Persons() {PersonID =1,PersonName = "Dhing Express - Hima Das" ,PersonImage="~/images/Himadas1.jpg"},
                new Persons() {PersonID =2,PersonName = "Sky Warrior - Avani Chathurvedhi" ,PersonImage="~/images/Avani1.jpg" },
                new Persons() {PersonID =3,PersonName = "Ms. Knock-out - Mary Kom" ,PersonImage="~/images/marykom1.jpg" },
                new Persons() {PersonID =4,PersonName = "Pepsi Queen - Indra Nooyi" ,PersonImage="~/images/indranooyi1.jpg" },
                new Persons() {PersonID =5,PersonName = "Kiran Bedi" ,PersonImage="~/images/kiranbedi1.jpg" },
                new Persons() {PersonID =6,PersonName = "Wonder Women - Seema Rao" ,PersonImage="~/images/seemarao1.png" },



            };

        }

       

        public IEnumerable<Persons> GetAllEmployees()
        {
            return _personsList;
        }
    }
}
