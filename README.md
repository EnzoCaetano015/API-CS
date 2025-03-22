# MinhaApiCrudAPI-C#

Este projeto é uma API RESTful desenvolvida com **.NET 8** e **C#**.  
Ela implementa operações CRUD (Create, Read, Update, Delete) para gerenciar produtos utilizando o **Entity Framework Core** e se conecta a um banco de dados **MySQL (via XAMPP)** por meio do pacote `Pomelo.EntityFrameworkCore.MySql`.

---

## 🚀 Tecnologias Utilizadas

- .NET 8  
- C#  
- ASP.NET Core Web API  
- Entity Framework Core  
- Pomelo.EntityFrameworkCore.MySql  
- MySQL (XAMPP)  
- Swagger (para documentação e testes da API)

---

## ✨ Funcionalidades

### CRUD de Produtos:

- **GET**: Listar todos os produtos e obter um produto específico  
- **POST**: Criar um novo produto  
- **PUT**: Atualizar um produto existente  
- **DELETE**: Excluir um produto

---

## ✅ Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou outro editor de sua preferência  
- [XAMPP](https://www.apachefriends.org/) com MySQL configurado  
- Pacote `Pomelo.EntityFrameworkCore.MySql` instalado via NuGet

---

## ⚙️ Como Executar o Projeto

### 1. Configuração do Banco de Dados

#### Criação da Base de Dados

Crie um banco de dados no MySQL, por exemplo: `MinhaApiCrudDB`.

#### Script SQL para criação da tabela (opcional)

```sql
CREATE TABLE Produtos (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  Nome VARCHAR(255) NOT NULL,
  Preco DECIMAL(10,2) NOT NULL
);

Você pode executar esse script no phpMyAdmin (fornecido pelo XAMPP) ou em outro cliente MySQL.

Migrations com EF Core (alternativa ao script)
No Visual Studio, abra o Package Manager Console e execute:

bash
Copiar
Editar
Add-Migration InitialCreate
Update-Database
2. Configuração da Connection String
No arquivo appsettings.json, configure a string de conexão com o seu banco MySQL:

json
Copiar
Editar
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
⚠️ Ajuste os parâmetros conforme sua configuração do MySQL no XAMPP.

3. Executando a Aplicação
Abra o projeto no Visual Studio 2022

Pressione F5 ou Ctrl+F5 para iniciar a aplicação

O Swagger será aberto automaticamente no navegador
Exemplo: https://localhost:7071/swagger

🗂️ Estrutura do Projeto
bash
Copiar
Editar
├── Controllers         # Contém os endpoints da API (ex.: ProdutosController.cs)
├── Data                # Contém o DbContext (ex.: ProdutoContext.cs)
├── Models              # Contém as classes de modelo (ex.: Produto.cs)
├── appsettings.json    # Arquivo de configuração da aplicação
🧪 Testando a API
Você pode testar os endpoints utilizando:

A interface do Swagger (gerada automaticamente)

Ferramentas como o Postman

🤝 Contribuição
Contribuições são bem-vindas!
Se você deseja melhorar o projeto, sinta-se à vontade para abrir issues ou enviar pull requests.

📄 Licença
Este projeto está licenciado sob a MIT License.

yaml
Copiar
Editar

---

Se quiser, posso salvar isso em um arquivo README.md e te enviar. Deseja que 
