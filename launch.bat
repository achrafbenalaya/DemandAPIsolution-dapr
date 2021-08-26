

start dapr run --app-id demandeclient --app-port 5001  --dapr-http-port 50001 dotnet run -- dotnet run --project "./DemandeClient/DemandeClient.csproj"

start dapr run --app-id demandapi --app-port 5002  --dapr-http-port 50002 dotnet run -- dotnet run --project "./DemandAPI/DemandAPI.csproj"

