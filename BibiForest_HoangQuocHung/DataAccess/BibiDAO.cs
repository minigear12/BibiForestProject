using BibiBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Runtime.InteropServices;

namespace DataAccess
{
    public class BibiDAO
    {
        private static BibiDAO instance = null;


        private BibiDAO()
        {

        }

        public static BibiDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BibiDAO();
                }
                return instance;
            }

        }

        public void create(Bibi bibi)
        {
            try
            {
                using BibiForestContext context = new BibiForestContext();
                context.Bibis.Add(bibi);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }


        }

        public void update(Bibi bibi)
        {
            try
            {
                using BibiForestContext context = new BibiForestContext();
                context.Entry(bibi).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void delete(int id)
        {
            try
            {
                using BibiForestContext context = new BibiForestContext();
                var bibi = context.Bibis.SingleOrDefault(a => a.BibiId == id);
                context.Bibis.Remove(bibi);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Bibi> findAll()
        {
            List<Bibi> bibiList;
            IQueryable<Bibi>? bibis = null;
            try
            {
                using BibiForestContext context = new BibiForestContext();
                bibis = context.Bibis.Include(bibi => bibi.Owner);
                bibiList = bibis.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);

            }

            return bibiList;

        }

        public Bibi findById(int? id)
        {
            Bibi bibi = null;
            try
            {
                using BibiForestContext context = new BibiForestContext();
                bibi = context.Bibis.SingleOrDefault(a => a.BibiId == id);
                

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);

            }

            return bibi;
        }

        public Owner findOwnerByBibi(string OwnerID)
        {
            using BibiForestContext context = new BibiForestContext();

            var Owner = context.Owners.ToList().Find(sup => sup.OwnerId.Equals(OwnerID));
            return Owner;
        }
    }
}