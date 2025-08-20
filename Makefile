include compose/.env
export

COMPOSE_FILES = -f compose/docker-compose.yml -f compose/dev-net.yml
# ───────────────────────────────
# ✅ dev container
up: 
	docker compose $(COMPOSE_FILES) up --build

down:
	docker compose $(COMPOSE_FILES) down

restart:
	docker compose $(COMPOSE_FILES) restart

logs:
	docker compose $(COMPOSE_FILES) logs -f

pull:
	docker compose $(COMPOSE_FILES) pull

# ───────────────────────────────
# ✅ exec
# ───────────────────────────────
open-react:
	docker compose $(COMPOSE_FILES) exec react sh
open-dotnet:
	docker compose $(COMPOSE_FILES) exec dotnet sh
# ───────────────────────────────
# ✅ restart
# ───────────────────────────────
restart-go:
	docker compose $(COMPOSE_FILES) restart go

restart-react:
	docker compose $(COMPOSE_FILES) restart react
restart-dotnet:
	docker compose $(COMPOSE_FILES) restart dotnet

# ───────────────────────────────
# ✅  stop(down)
# ───────────────────────────────
down-react:
	docker compose $(COMPOSE_FILES) stop react
stop-dotnet:
	docker compose $(COMPOSE_FILES) stop dotnet
# ───────────────────────────────
# ✅ up

up-react:
	docker compose $(COMPOSE_FILES) up --build -d react
up-dotnet:
	docker compose $(COMPOSE_FILES) up --build -d dotnet
# ───────────────────────────────
# ✅ remove
# ───────────────────────────────
rm-react:
	docker compose $(COMPOSE_FILES) rm -f react
rm-dotnet:
	docker compose $(COMPOSE_FILES) rm -f dotnet
# ───────────────────────────────
# ✅ re-build
# ───────────────────────────────
reup-react:
	make down-react && make rm-react && make up-react
reup-dotnet:
	make down-dotnet && make rm-dotnet && make up-dotnet