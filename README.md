# fav-choons-csharp

We forget our favourite music 🎵. Listening happens over multiple platforms making it hard to track. People enjoy the nostalgia of listening to their old music, but there isn’t a personalised way of doing this.

Built using .net, entity framework, postgres

## Development

### Required tools

1. Postgres 
2. .NET command line tools
3.  [EF CLI tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet) (e.g. `dotnet tool install --global dotnet-ef`)

### Setup local db

1. Run postgres locally (e.g. `psql postgres`)
2. Create a database (e.g. in psql prompt: `CREATE DATABASE fav-choons`)
3. Add a [user secret](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets) for `ConnectionStrings.WebApiDatabase`, e.g. your secrets.json will look something like
```{
    "ConnectionStrings": {
        "WebApiDatabase": "Host=localhost; Database=YOUR_DATABASE_NAME; Username=YOUR_USERNAME; Password=YOUR_PASSWORD"
    }
}```

### Watch
`dotnet watch --project fav-choons-csharp`


### Database schema changes
1. Make code chagnes
2. Create a migration: `dotnet ef migrations add [MIGRATION_NAME]`
3. Run the migration: `dotnet ef database update`