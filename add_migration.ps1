param ($migrationname)

dotnet dotnet-ef migrations add $migrationname -p .\EfDAL\EfDAL.csproj -s .\EfDemoWeb\EfDemoWeb.csproj -v