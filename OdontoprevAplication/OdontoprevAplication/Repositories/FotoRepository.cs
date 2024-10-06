using Odontoprev.Data;
using Odontoprev.Domain;

namespace Odontoprev.Repositories
{
    public class FotoRepository : IFotoRepository
    {
        private readonly AppDbContext _context;

        public FotoRepository(AppDbContext context)
        {
            _context = context;
        }

        public Foto GetById(int id)
        {
            return _context.Fotos.Find(id);
        }

        public void Add(Foto foto)
        {
            _context.Fotos.Add(foto);
            _context.SaveChanges();
        }

        //public void Update(Foto foto)
        //{
        //    object value = _context.Fotos.(foto);
        //    _context.SaveChanges();
        //}

        public void Delete(int id)
        {
            var foto = _context.Fotos.Find(id);
            if (foto != null)
            {
                _context.Fotos.Remove(foto);
                _context.SaveChanges();
            }
        }

        public void Update(Foto foto)
        {
            throw new NotImplementedException();
        }
    }
}
