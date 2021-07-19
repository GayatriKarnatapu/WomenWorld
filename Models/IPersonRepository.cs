using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WomenWorld.Models
{
    public interface IPersonRepository
    {
        IEnumerable<Persons> GetAllPersons();
    }
}
