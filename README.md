# Teste Ubicua Back

Api de registro de dados no banco de dados.

## Índice

- [Sobre](#sobre)
- [Começando](#começando)
- [Instalação](#instalação)
- [Uso](#uso)
- [Contribuição](#contribuição)
- [Licença](#licença)

## Sobre

A API CRUD em ASP.NET é uma interface de programação de aplicativos desenvolvida para fornecer operações básicas de criação, leitura, atualização e exclusão (CRUD) em um banco de dados. Ela oferece endpoints RESTful para interagir com recursos específicos, permitindo que os clientes executem operações CRUD por meio de solicitações HTTP.

### Funcionalidades Principais
Criação (Create): permite que os clientes criem novos registros enviando dados para um endpoint específico, tando enviando um registro ou um conjunto de registros.
Leitura (Read): permite que os clientes recuperem registros existentes consultando endpoints específicos, recebendo todos os registro do banco de dados ou pesquisando por um nome em específico.
Atualização (Update): permite que os clientes atualizem registros existentes enviando dados atualizados para um endpoint específico.
Exclusão (Delete): permite que os clientes excluam registros existentes por meio de solicitações a um endpoint específico.

## Começando

Para começar a usar a API CRUD em ASP.NET, siga estas etapas:

1. Obtenha um token de acesso válido por meio do endpoint de autenticação.
2. Use o token de acesso para autenticar suas solicitações aos endpoints da API.
3. Explore os diferentes endpoints disponíveis para realizar operações CRUD em recursos específicos.

## Exemplos de Uso

### Criando um Novo Usuário

```http
POST /api/usuarios
Content-Type: application/json
Authorization: Bearer {seu-token-de-acesso}

{
  "nome": "John Doe",
  "email": "john@example.com",
  "idade": 30,
  "cpf": "12312345567"
}
```

### Atualizando um Usuário Existente

```http
PUT /api/usuarios/{id}
Content-Type: application/json
Authorization: Bearer {seu-token-de-acesso}

{
  "nome": "John Doe",
  "email": "john.doe@example.com",
  "idade": 35,
  "cpf": "12312345567"
}
```

### Excluindo um Usuário Existente

```http
DELETE /api/usuarios/{id}
Authorization: Bearer {seu-token-de-acesso}
```

## Requisitos de Instalação

- SDK do .NET Core
- Visual Studio ou Visual Studio Code
- Postman ou outra ferramenta para testar requisições HTTP
