# ToDoMVC - Sistema de Gerenciamento de Tarefas

O ToDoMVC é um aplicativo web simples para gerenciamento de tarefas, onde os usuários podem adicionar, editar, excluir e marcar tarefas como concluídas. Feito como projeto pessoal, para efeito de treino, ainda virão outras features ainda não pensadas 😄😄😄

## Pré-requisitos
* [.NET framework 6.0](https://dotnet.microsoft.com/pt-br/download/dotnet/6.0) ou superior
* [MS-SQL Server 2022](https://www.microsoft.com/en-us/sql-server/sql-server-downloads/)

## Tecnologias utilizadas

* ASP.NET Core e MVC
* Razor
* MS-SQL Server 2022
## Configuração do Ambiente

1. **Clone este repositório:**

   ```bash
   git clone https://github.com/seu-usuario/TodoMVC.git
   cd TodoMVC
2. **Configure o banco de dados:**
    Altere a string de conexão no arquivo appsettings.json para refletir suas configurações:
   ```bash
   "ConnectionStrings": {
    "DefaultConnection": "sua-string-de-conexao"
    }
3. **Aplique as migrações para criar o banco de dados:**
   ```bash
   dotnet ef database update
4. **Execute a aplicação:**
   ```bash
   dotnet run

5. **Acesse a aplicação em http://localhost:5240 no seu navegador ou mude a configuração da porta no arquivo *LauchSettings.json*:**
   ```bash
   "launchBrowser": true,
       "applicationUrl": "http://localhost:5240"(altere para a porta desejada)



## Estrutura do Projeto

  * Controllers: Controladores da aplicação.
  * Context: Classes relacionadas a dados e contexto do banco de dados.
  * Models: Definição de modelos de dados.
  * Repository: Implementação de repositórios para acesso a dados.
  * Migrations: Arquivos gerados pela ferramenta _*dotnet ef*_ referentes à criação das tabelas no banco de dados.
  * Views: Arquivos relacionados às views da aplicação.

## Contribuições

  Contribuições são bem-vindas! Sinta-se à vontade para abrir issues, propor melhorias ou enviar pull requests.

## Licença
  Este projeto é licenciado sob a MIT License.
