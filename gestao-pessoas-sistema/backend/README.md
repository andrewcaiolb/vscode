# Conteúdo do arquivo: /gestao-pessoas-sistema/gestao-pessoas-sistema/backend/README.md

# Sistema de Gestão de Pessoas

Este projeto é um sistema de gestão de pessoas que inclui funcionalidades para gerenciamento de feedbacks e desenvolvimento de Planos de Desenvolvimento Individual (PDI).

## Estrutura do Projeto

O projeto é dividido em duas partes principais: **backend** e **frontend**.

### Backend

O backend é construído utilizando C# e ASP.NET Core. A estrutura do backend é a seguinte:

- **Controllers**: Contém os controladores que gerenciam as requisições.
  - `FeedbackController.cs`: Gerencia feedbacks.
  - `PdiController.cs`: Gerencia PDIs.
  - `UserController.cs`: Gerencia usuários.

- **Models**: Define as classes de modelo utilizadas no sistema.
  - `Feedback.cs`: Representa um feedback.
  - `Pdi.cs`: Representa um PDI.
  - `User.cs`: Representa um usuário.

- **Services**: Contém a lógica de negócios do sistema.
  - `FeedbackService.cs`: Manipula feedbacks.
  - `PdiService.cs`: Manipula PDIs.
  - `UserService.cs`: Manipula usuários.

- **Program.cs**: Ponto de entrada da aplicação.

### Frontend

O frontend é construído utilizando React. A estrutura do frontend é a seguinte:

- **Components**: Contém os componentes reutilizáveis.
  - `Feedback`: Componentes relacionados a feedbacks.
  - `Pdi`: Componentes relacionados a PDIs.
  - `User`: Componentes relacionados a usuários.

- **Pages**: Contém as páginas principais da aplicação.
  - `Dashboard.tsx`: Página principal.
  - `Feedbacks.tsx`: Exibe a lista de feedbacks.
  - `Pdis.tsx`: Exibe a lista de PDIs.

- **Services**: Contém funções para interagir com a API do backend.
  - `api.ts`: Funções para chamadas à API.

## Como Executar o Projeto

1. Clone o repositório.
2. Navegue até a pasta `backend` e execute o projeto utilizando o comando:
   ```
   dotnet run
   ```
3. Navegue até a pasta `frontend` e instale as dependências com:
   ```
   npm install
   ```
4. Inicie o frontend com:
   ```
   npm start
   ```

## Contribuição

Sinta-se à vontade para contribuir com melhorias e correções.