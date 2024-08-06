# Adrilbank

### Basic Structure DDD + CQRS + EventSourcing of Bank implementation


Caso não tenha criado ainda o banco de dados, na pasta principal do pojeto (composelead-auth) execute:

```
docker-compose up -d
```

# Migrations

Os comandos devem ser executados na pasta principal do solution (src\AdrilBank.Api):

#### Criar Migration

```
dotnet ef migrations add "InitialMigration" --project AdrilBank.Infra.Data --startup-project AdrilBank.Api --output-dir Migrations
```

#### Atualizar Database

```
dotnet ef database update --project AdrilBank.Infra.Data --startup-project AdrilBank.Api
```