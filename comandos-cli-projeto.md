# Comandos de Terminal — Referência do Projeto

Este documento reúne, explicado, todo comando de terminal (`dotnet`, `psql`) já utilizado na construção do projeto. Serve como referência rápida — não precisa ler tudo de uma vez, use o índice pra pular direto ao que precisar revisar.

---

## 1. Criação da solução e dos projetos

```bash
mkdir ServiceDeskBot
cd ServiceDeskBot
dotnet new sln -n ServiceDeskBot
```
- `dotnet new sln` cria um arquivo `.sln` (solution) — o "container" que agrupa vários projetos `.csproj` relacionados. Ainda não cria nenhum código, só a estrutura de agrupamento.

```bash
dotnet new webapi -n ServiceDeskBot.Api
dotnet new classlib -n ServiceDeskBot.Domain
dotnet new classlib -n ServiceDeskBot.ChatEngine
dotnet new classlib -n ServiceDeskBot.Infrastructure
dotnet new xunit -n ServiceDeskBot.Tests
```
- `dotnet new webapi` gera um projeto de API web (Controllers, `Program.cs`, suporte a HTTP). Usado só no `Api`, porque é o único projeto que efetivamente expõe endpoints.
- `dotnet new classlib` gera uma **biblioteca de classes** simples, sem nada de web — usada em `Domain`, `ChatEngine` e `Infrastructure`, que não são aplicações executáveis por si só.
- `dotnet new xunit` gera um projeto de testes já configurado com o framework xUnit.

## 2. Adicionando os projetos à solução

```bash
dotnet sln add ServiceDeskBot.Api/ServiceDeskBot.Api.csproj
dotnet sln add ServiceDeskBot.Domain/ServiceDeskBot.Domain.csproj
dotnet sln add ServiceDeskBot.ChatEngine/ServiceDeskBot.ChatEngine.csproj
dotnet sln add ServiceDeskBot.Infrastructure/ServiceDeskBot.Infrastructure.csproj
dotnet sln add ServiceDeskBot.Tests/ServiceDeskBot.Tests.csproj
```
- `dotnet sln add` registra cada projeto dentro do `.sln`. Sem isso, o Visual Studio/`dotnet build` na raiz não saberia que esses projetos existem, mesmo estando na mesma pasta.

## 3. Referências entre projetos (a arquitetura virando regra do compilador)

```bash
dotnet add ServiceDeskBot.Api reference ServiceDeskBot.Domain
dotnet add ServiceDeskBot.Api reference ServiceDeskBot.ChatEngine
dotnet add ServiceDeskBot.Api reference ServiceDeskBot.Infrastructure

dotnet add ServiceDeskBot.ChatEngine reference ServiceDeskBot.Domain

dotnet add ServiceDeskBot.Infrastructure reference ServiceDeskBot.Domain

dotnet add ServiceDeskBot.Tests reference ServiceDeskBot.Domain
dotnet add ServiceDeskBot.Tests reference ServiceDeskBot.ChatEngine
```
- `dotnet add <projeto> reference <outro-projeto>` diz "o primeiro projeto pode usar classes do segundo". É o que fisicamente impede, por exemplo, o `Domain` de referenciar o `Infrastructure` — o compilador barra a dependência circular.
- Note que **nenhum comando referencia o `Domain` a outro projeto** — ele não depende de nada, por design (Dependency Inversion, Fase 2).

## 4. Compilando a solução

```bash
dotnet build
```
- Compila **todos** os projetos da solução, respeitando a ordem de dependência definida pelas referências (item 3). Se `Domain` tiver erro, os projetos que dependem dele nem tentam compilar de verdade.
- Retorna `Build succeeded` com a contagem de erros/warnings ao final.

## 5. Pacotes NuGet do EF Core + PostgreSQL

```bash
dotnet add ServiceDeskBot.Infrastructure package Microsoft.EntityFrameworkCore
dotnet add ServiceDeskBot.Infrastructure package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add ServiceDeskBot.Infrastructure package Microsoft.EntityFrameworkCore.Design
```
- `dotnet add <projeto> package <nome>` baixa e instala um pacote do NuGet (o "gerenciador de pacotes" do .NET, equivalente ao Maven/Gradle do mundo Java) no projeto indicado.
- `Microsoft.EntityFrameworkCore` — o motor do ORM em si.
- `Npgsql.EntityFrameworkCore.PostgreSQL` — o provider que traduz para o dialeto SQL do PostgreSQL.
- `Microsoft.EntityFrameworkCore.Design` — dá suporte às ferramentas de linha de comando `dotnet ef` (Migrations), usadas a partir da próxima etapa do projeto.
- Todos instalados especificamente em `Infrastructure`, nunca em `Domain`.

> **Atenção:** o pacote `.Design` não se propaga automaticamente para quem referencia `Infrastructure` (ele é marcado como `PrivateAssets="all"`, proposital do próprio EF Core). Por isso, ele também precisa ser instalado diretamente no projeto passado em `--startup-project` (no nosso caso, `ServiceDeskBot.Api`):
> ```bash
> dotnet add ServiceDeskBot.Api package Microsoft.EntityFrameworkCore.Design
> ```

## 6. User Secrets (senha do banco fora do código-fonte)

```bash
dotnet user-secrets init --project ServiceDeskBot.Api
```
- Vincula o projeto `Api` a um "cofre" de segredos local, guardado fora da pasta do projeto (no perfil do usuário do Windows). Gera um `UserSecretsId` no `.csproj` — esse identificador pode ir pro Git normalmente, ele não é um segredo em si.

```bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Host=localhost;Port=5432;Database=servicedeskbot;Username=postgres;Password=SUASENHA" --project ServiceDeskBot.Api
```
- Grava a connection string **completa, com senha real**, nesse cofre local. O valor nunca fica em nenhum arquivo do repositório. Em tempo de execução, o ASP.NET Core mescla isso automaticamente com o `appsettings.json` (que tem a mesma estrutura, mas sem a senha).

## 7. PostgreSQL — criação do banco via `psql`

Acesso via o atalho **"SQL Shell (psql)"** do Menu Iniciar (instalado junto com o PostgreSQL), aceitando os valores padrão (`Enter`) até chegar no prompt `postgres=#`:

```sql
CREATE DATABASE servicedeskbot;
```
- Cria um banco de dados vazio chamado `servicedeskbot` — é esse nome que aparece na connection string (`Database=servicedeskbot`).

Alternativa via terminal comum, caso `psql` não esteja no `PATH`:
```bash
cd "C:\Program Files\PostgreSQL\18\bin"
psql -U postgres
```
- Navega até a pasta `bin` da instalação do PostgreSQL antes de rodar `psql`, caso o comando não seja reconhecido diretamente.

---

## Próximos comandos (ainda não executados — adiantamento)

Vamos precisar em breve, quando chegarmos em Migrations:

```bash
dotnet tool install --global dotnet-ef
dotnet ef migrations add NomeDaMigration --project ServiceDeskBot.Infrastructure --startup-project ServiceDeskBot.Api
dotnet ef database update --project ServiceDeskBot.Infrastructure --startup-project ServiceDeskBot.Api
```
Essa seção será detalhada e movida pra cima assim que chegarmos nessa etapa.
