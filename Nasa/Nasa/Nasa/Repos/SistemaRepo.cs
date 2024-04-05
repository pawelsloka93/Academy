using Microsoft.EntityFrameworkCore;
using Nasa.Models;

namespace Nasa.Repos
{
    public class SistemaRepo : IRepo<Sistema>
    {
        public Sistema(NasaDbContext context)
        {
            _context = context;
        }
        public bool Create(CorpoCeleste entity)
        {
            try
            {
                _context.CorpoCeleste.Add(entity);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                CorpoCeleste? temp = Get(id);
                if (temp != null)
                {
                    _context.CorpoCeleste.Remove(temp);
                    _context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            return false;
        }

        public CorpoCeleste? Get(int id)
        {
            return _context.CorpoCeleste.Find(id);
        }

        public IEnumerable<CorpoCeleste> GetAll()
        {
            return _context.CorpoCeleste.ToList();
        }

        public bool Update(CorpoCeleste entity)
        {
            try
            {
                _context.CorpoCeleste.Update(entity);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
