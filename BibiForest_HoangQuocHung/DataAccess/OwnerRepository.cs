using BibiBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OwnerRepository : IOwnerRepository
    {
        public List<Owner> GetAll()
        {
            return OwnerDAO.getInstance().findAll();
        }
    }
}
