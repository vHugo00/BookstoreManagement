# 📚 API - Gestão de Livraria (ASP.NET Core)

Este projeto é uma API RESTful desenvolvida em **C# com ASP.NET Core**, como parte de um desafio prático da Rocketseat. A API permite gerenciar um catálogo de livros com funcionalidades de criação, leitura, atualização e remoção (CRUD).

## 🚀 Tecnologias Utilizadas

- ASP.NET Core
- C#
- .NET 8
- Swagger
- Ferramentas REST (Postman, Thunder Client, etc.)

## 📦 Como executar o projeto

1. Clone o repositório:

```
git clone [https://github.com/seu-usuario/nome-do-repo.git](https://github.com/vHugo00/BookstoreManagement.git)
```

2. Acesse a pasta do projeto:

```
cd BookstoreManagement
```

3. Execute o projeto:

```
dotnet run
```

A API estará disponível em `https://localhost:5001` ou `http://localhost:5000`.

## 📌 Endpoints

### 🔍 Listar todos os livros

- **GET** `/api/bookstore`

### 🔍 Buscar livro por ID

- **GET** `/api/bookstore/{id}`

**Respostas:**

- `200 OK` com o livro
- `404 Not Found` se o livro não existir

### ➕ Criar novo livro

- **POST** `/api/bookstore`

**Body:**

```
{
  "title": "A Guerra dos Tronos",
  "author": "George R. R. Martin",
  "price": 79.90,
  "stock": 15
}
```

**Respostas:**

- `201 Created` com os dados do livro criado
- `400 Bad Request` se título ou autor estiverem em branco

### ✏️ Atualizar um livro

- **PUT** `/api/bookstore/{id}`

**Body:**

```
{
  "title": "A Guerra dos Tronos - Atualizado",
  "author": "George R. R. Martin",
  "price": 89.90,
  "stock": 10
}
```

**Respostas:**

- `200 OK` com o livro atualizado
- `404 Not Found` se o livro não existir

### ❌ Remover um livro

- **DELETE** `/api/bookstore/{id}`

**Respostas:**

- `200 OK` com mensagem de sucesso
- `404 Not Found` se o livro não existir

```

## 💡 Aprendizados

```
- Criação de API REST com ASP.NET Core
- Utilização de `ControllerBase` com `[ApiController]`
- Boas práticas com status HTTP apropriados
- Validações básicas e manipulação de listas em memória

```

## 📝 Considerações

```
- Esta API usa uma lista estática em memória (sem banco de dados) apenas para fins didáticos.
---

