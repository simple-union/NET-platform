$BasePath = $PSScriptRoot

Set-Location $BasePath

docker system prune -f
docker-compose up --build --force-recreate --abort-on-container-exit
