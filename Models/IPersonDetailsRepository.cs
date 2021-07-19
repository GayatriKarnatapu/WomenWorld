using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WomenWorld.Models
{
    public interface IPersonDetailsRepository
    {
        public Persons GetPersonDetails(int id);
        public string ContentPath(int id);

        public string Links(int id);
    }
}
