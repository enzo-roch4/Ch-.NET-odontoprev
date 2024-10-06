using Odontoprev.Domain;

public interface IUsuarioRepository
{
    Usuario GetById(int id);
    void Add(Usuario usuario);
    void Update(Usuario usuario);
    void Delete(int id);
    Usuario FindByCpf(string cpf);
}