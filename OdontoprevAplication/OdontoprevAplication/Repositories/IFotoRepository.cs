using Odontoprev.Domain;


namespace Odontoprev.Repositories
{
    public interface IFotoRepository
    {
        Foto GetById(int id);
        void Add(Foto foto);
        void Update(Foto foto);
        void Delete(int id);
    }
}
