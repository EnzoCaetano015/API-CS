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
