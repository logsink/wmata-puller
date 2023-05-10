# wmata-puller
The Washing Metro Transit Authority is kind enough to have a free realtime data API for the metro and buses. You must sign up on the WMATA website to grab a developer token. 

[https://developer.wmata.com/developer](https://developer.wmata.com/developer)

## Configuration
You must configure the upload endpoint, and the WMATA token.

Example:
```
{
  "LogshipEndpoint": "http://try.logship.ai:5000",
  "AuthToken": "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
}
```

## Docker Compose

An example docker compose file, which mounts the config into the container at /app/application.json.

```
version: "3.9"
services:
    wmata-puller:
    container_name: "wmata-puller"
    image: ghcr.io/logsink/wmata-puller:latest
    restart: always
    network_mode: host
    volumes:
      - ./configs/wmata-puller.json:/app/application.json
```