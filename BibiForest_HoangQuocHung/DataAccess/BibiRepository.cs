using BibiBusiness.DTO;
using BibiBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BibiRepository : IBibiRepository
    {
        public void create(Bibi bibi)
        {
            BibiDAO.Instance.create(bibi);
        }

        public void delete(int id)
        {
            BibiDAO.Instance.delete(id);
        }

        public List<Bibi> findAll()
        {
            return BibiDAO.Instance.findAll();
        }

        public Bibi findById(int id)
        {
            return BibiDAO.Instance.findById(id);
        }

        public void update(Bibi bibi)
        {
            BibiDAO.Instance.update(bibi);
        }

        public Owner findOwnerByBibi(string OwnerID)
        {
           return BibiDAO.Instance.findOwnerByBibi(OwnerID);
        }

        
    }
}
