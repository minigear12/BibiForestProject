using BibiBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OwnerDAO
    {
        private static OwnerDAO instance;
        private OwnerDAO() { }
        public static OwnerDAO getInstance()
        {
            if (instance == null)
            {
                instance = new OwnerDAO();
            }

            return instance;
        }

        public List<Owner> findAll()
        {
            using BibiForestContext context = new BibiForestContext();
            return context.Owners.ToList();

        }
    }
}
