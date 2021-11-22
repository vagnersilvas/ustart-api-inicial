# Api - Projeto UStart

## AVISO!

Esse é o projeto inicial do curso UStart .net o repositório com o projeto final está no endereço https://github.com/silvagpe/ustart-api



## EF Core

Instalar a ferramenta do EF no CLI
```
dotnet tool install --global dotnet-ef
```
https://docs.microsoft.com/pt-br/ef/core/cli/dotnet

### Migrations

Antes de criar a migrations é necessário adicionar a referência do para a biblioteca do EF Design
```bash
cd Infrastructure 
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.2

cd API
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.2

dotnet clean && dotnet build
```

Como criar as migrations
```bash
cd API
dotnet ef migrations add imovel_v4 -c UStartContext --project ../Infrastructure/Infrastructure.csproj
dotnet ef migrations add cliente_v2 -c UStartContext --project ../Infrastructure/Infrastructure.csproj
```