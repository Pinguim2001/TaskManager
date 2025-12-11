# 📝 TaskManager

**TaskManager** é uma aplicação **ASP.NET Core MVC** para gerenciamento de tarefas, permitindo:

- Criar tarefas  
- Editar tarefas  
- Excluir tarefas  
- Marcar tarefas como concluídas  
- Visualizar lista completa de tarefas  

O projeto implementa o padrão **Repository** e utiliza **Entity Framework Core** com **SQL Server LocalDB**.

---

## 🚀 Tecnologias Utilizadas

- **ASP.NET Core 8 / MVC**  
- **Entity Framework Core**  
- **SQL Server (LocalDB)**  
- **C#**  
- **Bootstrap** (para as Views MVC)  
- **Repository Pattern**

---

## 📦 Requisitos

### ✔️ .NET SDK
- Versão recomendada: **.NET 7 ou .NET 8**  
- Download: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

### ✔️ SQL Server
- LocalDB ou SQL Server Express  
- Opcional: **SQL Server Management Studio (SSMS)** para gerenciar o banco  

### ✔️ Git
- Para clonar o repositório  
- Download: [https://git-scm.com/downloads](https://git-scm.com/downloads)

---

## 🛠 Configuração do Banco de Dados

O projeto usa SQL Server LocalDB conforme definido no `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TaskManager;Trusted_Connection=True;MultipleActiveResultSets=true"
}

```
✔️ Criando o banco

No terminal, dentro da pasta do projeto:

```json
dotnet ef database update
```

Se ainda não houver migrations:
```json
dotnet ef migrations add InitialCreate
dotnet ef database update
```

