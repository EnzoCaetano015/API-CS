# MinhaApiCrudAPI-C#
Este projeto é uma API RESTful desenvolvida com .NET 8 e C#. Ela implementa operações CRUD (Create, Read, Update, Delete) para gerenciar produtos utilizando o Entity Framework Core e se conecta a um banco de dados MySQL (utilizando o XAMPP) por meio do pacote Pomelo.EntityFrameworkCore.MySql.

Tecnologias Utilizadas
.NET 8

C#

ASP.NET Core Web API

Entity Framework Core

Pomelo.EntityFrameworkCore.MySql

MySQL (XAMPP)

Swagger para documentação e testes da API

Funcionalidades
CRUD de Produtos:

GET: Listar todos os produtos e obter um produto específico.

POST: Criar um novo produto.

PUT: Atualizar um produto existente.

DELETE: Excluir um produto.

Pré-requisitos
.NET 8 SDK

Visual Studio 2022 ou outro editor de sua preferência

XAMPP com MySQL configurado

Pomelo.EntityFrameworkCore.MySql (instalado via NuGet)

Como Executar o Projeto
1. Configuração do Banco de Dados
Criação da Base de Dados:
Crie um banco de dados no MySQL (por exemplo, MinhaApiCrudDB).

Script SQL para criação da tabela:
Caso deseje criar a tabela manualmente, utilize o seguinte script:

sql
Copiar
CREATE TABLE Produtos (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  Nome VARCHAR(255) NOT NULL,
  Preco DECIMAL(10,2) NOT NULL
);
Você pode executar esse script no phpMyAdmin (fornecido pelo XAMPP) ou em outro cliente MySQL.

Migrations com EF Core:
Se preferir que o Entity Framework crie a estrutura do banco, abra o Package Manager Console no Visual Studio e execute:

pgsql
Copiar
Add-Migration InitialCreate
Update-Database
2. Configuração da Connection String
No arquivo appsettings.json, configure a string de conexão com o seu banco MySQL. Exemplo:

json
Copiar
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;port=3306;database=MinhaApiCrudDB;user=root;password=senha_do_mysql"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
Observação: Ajuste os parâmetros (server, port, database, user e password) conforme sua configuração do MySQL no XAMPP.

3. Executando a Aplicação
Abra o projeto no Visual Studio 2022.

Selecione a opção "Executar" (F5 ou Ctrl+F5) para iniciar a aplicação.

Se o Swagger estiver habilitado, a interface de testes será aberta automaticamente no navegador (por exemplo, https://localhost:7071/swagger).

Estrutura do Projeto
Models: Contém as classes de modelo (ex.: Produto.cs).

Data: Contém o DbContext (ProdutoContext.cs) para gerenciar a conexão e mapeamento com o banco de dados.

Controllers: Contém os Controllers com os endpoints da API (ex.: ProdutosController.cs).

appsettings.json: Arquivo de configuração com a connection string e outras definições.

Testando a API
Você pode testar os endpoints utilizando:

A interface do Swagger (gerada automaticamente).

Ferramentas como o Postman.

Contribuição
Contribuições são bem-vindas! Se você deseja melhorar o projeto, sinta-se à vontade para abrir issues ou enviar pull requests.

Licença
Este projeto está licenciado sob a MIT License.
