# CrudDapper

## Projeto CRUD com Dapper, Web API .NET 8 e SQL Server

Este projeto foi desenvolvido com base no tutorial do vídeo do YouTube: [Curso Completo | CRUD com DAPPER | WEB API com .NET 8 e SQL Server | CRUD + Repository Pattern 💻](https://www.youtube.com/watch?v=mmFw3OXlouo). O objetivo do projeto é implementar um CRUD (Create, Read, Update, Delete) de usuários, utilizando o Dapper como ORM, o padrão Repository Pattern e a biblioteca AutoMapper para mapear objetos.

### Tecnologias Utilizadas: 
- .NET 8
- SQL Server
- Dapper: Biblioteca ORM (Object Relational Mapper) para facilitar a interação com o banco de dados SQL Server.
- AutoMapper: Biblioteca para mapeamento de objetos, facilitando a conversão de entidades para DTOs (Data Transfer Objects) e vice-versa.
- Repository Pattern: Padrão de projeto para abstrair o acesso aos dados, tornando o código mais modular e fácil de manter.
  
#### Funcionalidades
- Create: Criar novos usuários no banco de dados.
- Read: Consultar informações dos usuários cadastrados.
- Update: Atualizar as informações de um usuário existente.
- Delete: Remover um usuário do banco de dados.

#### Estrutura do Projeto
A aplicação é organizada em camadas, seguindo o padrão Repository Pattern:
- Controllers: Contém os endpoints da Web API para expor as funcionalidades CRUD.
- Models: Contém as classes de entidades que representam os dados no banco.
- DTOs: Objetos de transferência de dados (DTOs) usados para mapear os dados entre as camadas.
- Services: Camada de lógica de negócios, comunicação com o banco de dados utilizando o Dapper e executa as operações.
- AutoMapper Profiles: Configurações para mapear entidades para DTOs e vice-versa.

#### Como Rodar o Projeto
1. Clonar o Repositório
Primeiro, clone este repositório em sua máquina:

```bash
git clone https://github.com/gabriela-ncmt/CrudDapper.git
```
3. Configurar o Banco de Dados
Crie um banco de dados no SQL Server com o nome de *CrudDapper*.

Importe ou crie a tabela de usuários com o seguinte esquema:

```bash
CREATE TABLE Users (
	ID INT IDENTITY(1,1),
	FullName VARCHAR(100),
	Email VARCHAR(100),
	Position VARCHAR (100),
	CPF VARCHAR(11),
	Salary DECIMAL,
	Situation BIT, 
	Password VARCHAR(100)
)
```
4. Configurar o arquivo appsettings.json
Abra o arquivo appsettings.json e configure a string de conexão com o seu banco de dados:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=UserDb;Trusted_Connection=True;"
  }
}
```
4. Restaurar Pacotes NuGet
Execute o seguinte comando para restaurar os pacotes NuGet necessários:

```bash
dotnet restore
```
5. Executar a Aplicação
Por fim, inicie a aplicação com o comando:

```bash
dotnet run
```
A aplicação estará disponível em http://localhost:7169 (ou em outra porta configurada).

#### Endpoints da API
A aplicação oferece os seguintes endpoints para o gerenciamento de usuários:

- POST /api/User: Cria um novo usuário.
- GET /api/User: Retorna todos os usuários.
- GET /api/User/{userId}: Retorna um usuário específico pelo ID.
- PUT /api/User: Atualiza as informações de um usuário.
- DELETE /api/User: Deleta um usuário pelo ID.
