using Odontoprev.Domain;
using Odontoprev.Repositories;

namespace Odontoprev.Services
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IFotoRepository _fotoRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository, IFotoRepository fotoRepository)
        {
            _usuarioRepository = usuarioRepository;
            _fotoRepository = fotoRepository;
        }

        public Usuario Login(string cpf, string senha)
        {
            var usuario = _usuarioRepository.FindByCpf(cpf);
            if (usuario == null || usuario.Senha != senha)
            {
                throw new UnauthorizedAccessException("CPF ou senha inválidos.");
            }
            return usuario;
        }

        public void UploadFoto(int usuarioId, string caminhoFoto)
        {
            var foto = new Foto { UsuarioId = usuarioId, CaminhoFoto = caminhoFoto, DataEnvio = DateTime.Now };
            _fotoRepository.Add(foto);
        }

        public void UpdadeFoto(int usuarioId, string caminhoFoto)
        {
            var foto = new Foto { UsuarioId = usuarioId, CaminhoFoto = caminhoFoto, DataEnvio = DateTime.Now };
            _fotoRepository.Add(foto);
        }

        public void Add(Usuario usuario)
        {
            _usuarioRepository.Add(usuario);
        }
    }
}
