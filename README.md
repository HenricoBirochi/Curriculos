# 📄 ASP.NET MVC CRUD Application

![C#](https://img.shields.io/badge/Language-C%23-239120?logo=c-sharp&logoColor=white)
![ASP.NET MVC](https://img.shields.io/badge/ASP.NET-MVC-blue)

## 📋 Visão Geral

Este é um projeto de aplicação web ASP.NET MVC que permite realizar operações CRUD (**Create, Read, Update, Delete**) em um banco de dados **SQL Server**. A aplicação possui uma interface amigável e intuitiva para gerenciar registros de forma eficiente.

---

## 🚀 Funcionalidades

- ✅ Adicionar novos registros
- 📄 Visualizar todos os registros existentes
- ✏️ Atualizar informações dos registros
- 🗑️ Deletar registros permanentemente

---

## 🛠️ Tecnologias Utilizadas

- **ASP.NET MVC** – Framework para desenvolvimento web
- **SQL Server** – Banco de dados relacional
- **Bootstrap** – Estilização e layout responsivo
- **C#** – Linguagem principal da aplicação

---

## 📦 Instalação e Configuração

### 1. Clone o repositório

git clone https://github.com/HenricoBirochi/Curriculos.git

---
### 2. Abra o projeto no Visual Studio

- Navegue até o diretório do projeto e abra o arquivo `.sln`.

### 3. Configure a conexão com o banco de dados

- string connectionString = "Server=SEU_SERVIDOR;Database=SEU_BANCO;Trusted_Connection=True;";

### 4. Execute a aplicação

- Pressione F5 no Visual Studio

---

## 💡 Como Usar

1. Acesse a aplicação via navegador.  
2. Utilize a interface para:
   - Criar novos registros  
   - Visualizar registros existentes  
   - Editar registros  
   - Remover registros  

---

## 🖼️ Capturas de Tela

![image](https://github.com/user-attachments/assets/0150416f-32d3-4880-9ca6-7d63a61af8a5)
![image](https://github.com/user-attachments/assets/0158a135-90ac-43f5-9940-d3b3bd52e3e1)

---
## 📁 Estrutura do Projeto

```
Curriculos/
├── .vs/                          # Arquivos temporários do Visual Studio
├── bin/
│   └── Debug/netcoreapp3.1/      # Saída da build
├── obj/                          # Arquivos intermediários da build
├── Controllers/                  # Controladores da aplicação
├── DAO/                          # Classe de acesso ao banco de dados (ConexaoBD.cs)
├── Models/                       # Modelos de dados
├── Properties/                   # Configurações do projeto
├── Views/                        # Páginas Razor (HTML + C#)
├── wwwroot/                      # Arquivos estáticos (CSS, JS, imagens)
├── Curriculos.csproj             # Arquivo de configuração do projeto (.NET)
├── Curriculos.sln                # Solução do Visual Studio
├── Program.cs                    # Ponto de entrada da aplicação
├── Startup.cs                    # Configuração da aplicação (middlewares, serviços etc.)
├── appsettings.json              # Configurações gerais (ex: connection string)
├── appsettings.Development.json # Configurações para ambiente de desenvolvimento
├── CurriculoDB.sql               # Script SQL do banco de dados
└── README.md                     # Documentação do projeto
```
---

## 👨‍💻 Autor

Desenvolvido por **Henrico Birochi**  
🔗 https://github.com/HenricoBirochi

