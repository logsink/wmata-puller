# wmata-puller
Many transit authorities are kind enough to publish a realtime GTFS api.

[https://developer.wmata.com/developer](https://developer.wmata.com/developer)

## Configuration
You must configure the upload endpoint, and the sometimes a token.

Example:
```
{
  "LogshipEndpoint": "http://try.logship.ai:5000",
  "GTFS": {
    "king-county-transit": {
      "VehiclePositionsProtoEndpoint": "https://s3.amazonaws.com/kcm-alerts-realtime-prod/vehiclepositions.pb"
    }
/*
    "wmata-bus": {
      "VehiclePositionsProtoEndpoint": "https://api.wmata.com/gtfs/bus-gtfsrt-vehiclepositions.pb",
      "Headers": {
        "api_key": "<wmata-key>"
      }
    },
    "wmata-rail": {
      "VehiclePositionsProtoEndpoint": "https://api.wmata.com/gtfs/rail-gtfsrt-vehiclepositions.pb",
      "Headers": {
        "api_key": "<wmata-key>"
      }
    },
    "mta-subway-ace": {
      "VehiclePositionsProtoEndpoint": "https://api-endpoint.mta.info/Dataservice/mtagtfsfeeds/nyct%2Fgtfs-ace",
      "Headers": {
        "x-api-key": "<mta-key>"
      }
    }
    */
  }
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