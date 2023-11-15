using BibiBusiness.Models;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibiBusiness.DTO;

namespace DataAccess
{
    public interface IBibiRepository
    {
        public List<Bibi> findAll();

        public Bibi findById(int id);

        public void create(Bibi bibi);

        public void update(Bibi bibi);
        public void delete(int id);
        public Owner findOwnerByBibi(string id);
        
    }
}
