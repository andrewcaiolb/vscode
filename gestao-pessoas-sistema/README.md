# README.md

# Sistema de Gestão de Pessoas

Este projeto é um sistema de gestão de pessoas que inclui funcionalidades para gerenciamento de feedbacks e desenvolvimento de Planos de Desenvolvimento Individual (PDI). O sistema é dividido em duas partes principais: o backend e o frontend.

## Estrutura do Projeto

### Backend

O backend é construído utilizando C# e ASP.NET Core. Ele é responsável por gerenciar as operações relacionadas a usuários, feedbacks e PDIs. A estrutura do backend é a seguinte:

- **controllers**: Contém os controladores que gerenciam as requisições e respostas da API.
  - `FeedbackController.cs`: Gerencia feedbacks.
  - `PdiController.cs`: Gerencia PDIs.
  - `UserController.cs`: Gerencia usuários.

- **models**: Contém as definições das classes que representam os dados.
  - `Feedback.cs`: Define a estrutura de um feedback.
  - `Pdi.cs`: Define a estrutura de um PDI.
  - `User.cs`: Define a estrutura de um usuário.

- **services**: Contém a lógica de negócios e manipulação dos dados.
  - `FeedbackService.cs`: Manipula feedbacks.
  - `PdiService.cs`: Manipula PDIs.
  - `UserService.cs`: Manipula usuários.

- `Program.cs`: Ponto de entrada da aplicação.

- `tests`: Contém testes unitários para garantir a qualidade do código.

### Frontend

O frontend é construído utilizando React e TypeScript. Ele é responsável pela interface do usuário e interação com o backend. A estrutura do frontend é a seguinte:

- **components**: Contém os componentes reutilizáveis da aplicação.
  - `Feedback`: Componentes relacionados a feedbacks.
  - `Pdi`: Componentes relacionados a PDIs.
  - `User`: Componentes relacionados a usuários.

- **pages**: Contém as páginas principais da aplicação.
  - `Dashboard.tsx`: Página principal do sistema.
  - `Feedbacks.tsx`: Exibe a lista de feedbacks.
  - `Pdis.tsx`: Exibe a lista de PDIs.

- **services**: Contém funções para interagir com a API do backend.
  - `api.ts`: Funções para chamadas à API.

- `App.tsx`: Ponto de entrada do frontend, onde as rotas e componentes principais são configurados.

## Como Executar o Projeto

1. Clone o repositório.
2. Navegue até a pasta do backend e execute `dotnet run` para iniciar o servidor.
3. Navegue até a pasta do frontend e execute `npm start` para iniciar a aplicação frontend.

## Contribuição

Sinta-se à vontade para contribuir com melhorias e correções. Para isso, crie um fork do repositório e envie um pull request com suas alterações.

## Licença

Este projeto está licenciado sob a MIT License.