# test-vps - 🚀 Blazor Server Landing

A Blazor Server application deployed on a VPS with Nginx as a reverse proxy.

## Tech Stack

- **Blazor Server** (.NET 10)
- **Nginx** (reverse proxy)
- **Ubuntu** (VPS)

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### Run locally

```bash
git clone https://github.com/tu-usuario/tu-repo.git
cd tu-repo
dotnet run
```

### Deploy to VPS

```bash
# Clone on server
git clone https://github.com/tu-usuario/tu-repo.git /var/www/blazor-app
cd /var/www/blazor-app

# Build & publish
dotnet publish -c Release -o ./publish

# Restart service
sudo systemctl restart blazor-app
```

> Full deployment guide available on [netmentor.es](https://netmentor.es) and on [YouTube](https://youtube.com/@netmentor).

## License

MIT
