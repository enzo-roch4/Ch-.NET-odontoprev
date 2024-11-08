Odontoprev

Odontoprev é um sistema de análise odontológica desenvolvido com .NET Core e Entity Framework. Ele utiliza Machine Learning para analisar fotos odontológicas e identificar problemas, auxiliando no processo de aprovação ou reprovação de sinistros de seguro dental.

Funcionalidades:

**Cadastro de Usuários**: Possível cadastrar usuários que podem fazer upload de fotos odontológicas.
- **Análise de Imagens**: O sistema utiliza Machine Learning para analisar as imagens enviadas e detectar possíveis problemas odontológicos.
- **Gestão de Sinistros**: Auxilia na aprovação ou rejeição de sinistros de seguro odontológico com base nos resultados da análise.

  **Requisitos Não Funcionais**:
  - Desempenho aceitável para a análise de imagens.
  - Segurança adequada no armazenamento e tratamento dos dados dos usuários.

**Requisitos Funcionais**:

.NET 6 SDK ou superior
SQL Server (ou outro banco de dados compatível com o Entity Framework Core)
Visual Studio 2022 ou outro editor compatível com .NET Core
Entity Framework Core

Configuração do Projeto:

Clone o repositório:
bash

Copiar código
git clone https://github.com/enzo-roch4/CH-Odontoprev.git

Navegue até o diretório do projeto:
bash

Copiar código
cd CH-Odontoprev

Configure a conexão com o banco de dados no arquivo appsettings.json:
json
Copiar código
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;"
  }
}

Restaure os pacotes NuGet:
bash

Copiar código
dotnet restore

Execute as migrações para criar a base de dados:
bash

Copiar código
dotnet ef database update

Execute o projeto:
bash
Copiar código
dotnet run

Estrutura do Projet:

/Odontoprev.Domain: Contém os modelos (entidades) do domínio, como Usuario, Foto, e Notificacao.
/Odontoprev.Services: Contém a lógica de negócios, como o serviço de usuários (UsuarioService).
/Odontoprev.Controllers: Contém as controllers para lidar com as requisições HTTP.
/Odontoprev.Data: Contém a implementação do repositório (UsuarioRepository) e o contexto do banco de dados (ApplicationDbContext).

Tecnologias Utilizadas:
ASP.NET Core MVC: Framework principal utilizado para desenvolver a aplicação.
Entity Framework Core: Utilizado para o mapeamento objeto-relacional (ORM) e interação com o banco de dados.
Oracke Server: Banco de dados utilizado para armazenar as informações.
Machine Learning: Integração com modelos de ML para análise de imagens odontológicas.

Se tudo ocorrer conforme esperado, aparecerá a lista de usuários que planejamos.
