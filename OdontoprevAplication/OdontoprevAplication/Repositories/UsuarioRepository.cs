using Microsoft.EntityFrameworkCore;
using Odontoprev.Data;
using Odontoprev.Domain;
using System.Data.Entity.Migrations;

namespace Odontoprev.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public Usuario GetById(int id)
        {
            return _context.Usuarios.Find(id) ?? throw new Exception("Usuário não encontrado.");
        }

        public void Add(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _context.Usuarios.AddOrUpdate(usuario);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }

        public Usuario FindByCpf(string cpf)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Cpf == cpf)
                   ?? throw new Exception("Usuário não encontrado.");
        }
    }
}

