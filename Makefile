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
open-go:
	docker compose $(COMPOSE_FILES) exec go sh

open-rust:
	docker compose $(COMPOSE_FILES) exec rust bash

open-react:
	docker compose $(COMPOSE_FILES) exec react sh

open-redis:
	docker compose $(COMPOSE_FILES) exec redis sh

open-postgres:
	docker compose $(COMPOSE_FILES) exec postgres sh

# ───────────────────────────────
# ✅ restart
# ───────────────────────────────
restart-go:
	docker compose $(COMPOSE_FILES) restart go

restart-rust:
	docker compose $(COMPOSE_FILES) restart rust

restart-react:
	docker compose $(COMPOSE_FILES) restart react

restart-redis:
	docker compose $(COMPOSE_FILES) restart redis

restart-postgres:
	docker compose $(COMPOSE_FILES) restart postgres

# ───────────────────────────────
# ✅  stop(down)
# ───────────────────────────────
down-go:
	docker compose $(COMPOSE_FILES) stop go

down-rust:
	docker compose $(COMPOSE_FILES) stop rust

down-react:
	docker compose $(COMPOSE_FILES) stop react

down-redis:
	docker compose $(COMPOSE_FILES) stop redis

down-postgres:
	docker compose $(COMPOSE_FILES) stop postgres

# ───────────────────────────────
# ✅ up
up-go:
	docker compose $(COMPOSE_FILES) up --build -d go

up-rust:
	docker compose $(COMPOSE_FILES) up --build -d rust

up-react:
	docker compose $(COMPOSE_FILES) up --build -d react

up-redis:
	docker compose $(COMPOSE_FILES) up --build -d redis

up-postgres:
	docker compose $(COMPOSE_FILES) up --build -d postgres

# ───────────────────────────────
# ✅ remove
# ───────────────────────────────
rm-go:
	docker compose $(COMPOSE_FILES) rm -f go

rm-rust:
	docker compose $(COMPOSE_FILES) rm -f rust

rm-react:
	docker compose $(COMPOSE_FILES) rm -f react

rm-redis:
	docker compose $(COMPOSE_FILES) rm -f redis

rm-postgres:
	docker compose $(COMPOSE_FILES) rm -f postgres

# ───────────────────────────────
# ✅ re-build
# ───────────────────────────────
reup-go:
	make down-go && make rm-go && make up-go

reup-rust:
	make down-rust && make rm-rust && make up-rust

reup-react:
	make down-react && make rm-react && make up-react

reup-redis:
	make down-redis && make rm-redis && make up-redis

reup-postgres:
	make down-postgres && make rm-postgres && make up-postgres
