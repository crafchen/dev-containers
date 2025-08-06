include compose/.env
export

COMPOSE_FILES = -f compose/docker-compose.yml -f compose/dev-net.yml
PROJECT_NAME=dev-containers

.PHONY: up down restart logs exec-go exec-react build rebuild clean

up:
	docker compose -f $(COMPOSE_FILE)  up -d

down:
	docker compose -f $(COMPOSE_FILE)  down

restart: down up

logs:
	docker compose -f $(COMPOSE_FILE)  logs -f

exec-go:
	docker compose -f $(COMPOSE_FILE) exec go bash

exec-react:
	docker compose -f $(COMPOSE_FILE) exec react bash

build:
	docker compose -f $(COMPOSE_FILE) build

rebuild:
	docker compose -f $(COMPOSE_FILE) build --no-cache

clean:
	docker compose -f $(COMPOSE_FILE) down -v --remove-orphans
	docker system prune -f
