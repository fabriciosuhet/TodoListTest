# Todo List API com .NET

## API em .NET para a aplicação: (https://github.com/fabriciosuhet/TodoListVue)

## Requisitos 
 - .NET SDK 8.0

## Passos para rodar o projeto

1. Clone o repositório com HTTPS:
   ```sh
   git clone git@github.com:fabriciosuhet/TodoListTest.git
   cd TodoListTest


  1.1 Clone o repositório com SSH:
   ```sh
   git git@github.com:fabriciosuhet/TodoListTest.git
   cd TodoListTest

```
### Restaure os pacotes NuGet:
dotnet restore

### Compile e execute a aplicação:
dotnet run


## Tecnologias e Padrões Utilizados

### DDD (Domain-Driven Design)
 - O DDD é uma abordagem que prioriza o entendimento e modelagem do domínio do problema. Ele ajuda a criar uma estrutura organizada e flexível para o desenvolvimento, garantindo que as partes do sistema estejam alinhadas com as necessidades do negócio. Em nosso projeto, o DDD foi usado para dividir a aplicação em contextos bem definidos, facilitando a manutenção e evolução do código.

## CQRS (Command Query Responsibility Segregation)
 - O CQRS é um padrão que separa a parte de leitura (queries) da parte de escrita (commands). Isso permite otimizar e escalar cada operação de forma independente, além de facilitar a implementação de diferentes modelos de dados para leitura e escrita, melhorando a performance e a organização do código.

## SQLite
 - O SQLite é um banco de dados leve e autossuficiente, que armazena os dados localmente em um arquivo. Ele é ideal para aplicações pequenas ou de uso local, oferecendo uma boa performance e simplicidade de configuração. Utilizamos o SQLite para persistir os dados de forma eficiente e sem a necessidade de um servidor de banco de dados complexo.

## SOLID
 - O SOLID é um conjunto de princípios para a construção de software orientado a objetos que facilita a manutenção e extensão do código. 

## Padrão Repository
 - O padrão Repository é utilizado para abstrair o acesso a dados e permitir que as operações de leitura e gravação sejam feitas de maneira centralizada e desacoplada. Ele facilita a implementação de testes, a reutilização de código e a modificação da forma como os dados são acessados, sem afetar o restante da aplicação.


 
