# ASP.NET Core MVC Workshop

Este projeto é uma aplicação web desenvolvida em **ASP.NET Core MVC**. Ele tem como objetivo servir como uma introdução prática ao desenvolvimento web utilizando o framework ASP.NET Core, cobrindo as principais operações de CRUD e conceitos de MVC, integração com banco de dados e outras funcionalidades web modernas.

## Tecnologias Utilizadas

- **ASP.NET Core MVC**: Framework para construção de aplicações web.
- **Entity Framework Core**: ORM para acesso a banco de dados e mapeamento de objetos.
- **MySQL**: Banco de dados relacional para armazenamento de dados.
- **Bootstrap**: Biblioteca para estilização de componentes front-end.

## Funcionalidades

- **CRUD de Entidades**: Operações de criação, leitura, atualização e exclusão de registros, incluindo entidades como `Departamentos` e `Vendedores`.
- **Integração com Banco de Dados**: Utilização do Entity Framework Core com abordagem *Code-First*.
- **Migrações e Seed Data**: Criação automática da estrutura de tabelas e inserção de dados iniciais.
- **Validação de Dados**: Validações no lado do cliente e do servidor, com anotações de dados.
- **Formatação de Números e Datas**: Configuração para exibir valores de acordo com a localização.
- **Tratamento de Exceções**: Controle de erros personalizados para operações críticas, como integridade referencial.
- **Funcionalidades Assíncronas**: Operações assíncronas com `async` e `await` para uma experiência mais responsiva.

## Estrutura do Projeto

- `Controllers`: Controladores que gerenciam a interação entre o usuário e a aplicação.
- `Models`: Classes de entidades do domínio e modelos de exibição.
- `Views`: Interfaces de usuário com o uso de Razor Pages.
- `wwwroot`: Recursos estáticos como CSS e imagens.
- `appsettings.json`: Configurações da aplicação, incluindo cadeias de conexão de banco de dados.
- `Startup.cs`: Configuração da aplicação, incluindo injeção de dependências e middlewares.

## Configuração e Execução

1. **Clonar o Repositório**: Clone este repositório para sua máquina local.
2. **Configurar Banco de Dados**:
   - Configure a cadeia de conexão no arquivo `appsettings.json`.
   - Use o MySQL e ajuste os parâmetros de `server`, `userid`, `password` e `database`.
3. **Executar Migrações**:
   - Abra o Console do Gerenciador de Pacotes no Visual Studio.
   - Execute os comandos:
     ```sh
     Add-Migration Initial
     Update-Database
     ```
4. **Executar o Projeto**:
   - Inicie o projeto com `CTRL+F5` para executar sem o modo de depuração.

## Funcionalidades Adicionais

- **Busca Simples e Agrupada**: Realize consultas por registros de vendas filtradas por data.
- **Temas Personalizados**: Integração com Bootstrap para troca de temas.
- **Operações com Chaves Estrangeiras**: Associação entre entidades `Vendedor` e `Departamento`.
  
## Contribuições

Este projeto é de aprendizado e não está aberto para contribuições externas.

## Licença

Este projeto é disponibilizado sem uma licença específica para fins educacionais.

---
