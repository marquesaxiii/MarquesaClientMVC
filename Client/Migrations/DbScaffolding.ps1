dotnet ef dbcontext scaffold "Host=localhost;Database=MarquesaSystem;Username=postgres;Password=postgres" Npgsql.EntityFrameworkCore.PostgreSQL -o DataTransferObjects -f --project ../Client.csproj

pause