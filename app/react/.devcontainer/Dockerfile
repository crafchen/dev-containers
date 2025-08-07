FROM node:24-bookworm

WORKDIR /app

RUN apt-get update && apt-get install -y \
    git \
    bash \
    openssh-client \
    && rm -rf /var/lib/apt/lists/*

RUN npm install -g vite pm2

CMD ["tail", "-f", "/dev/null"]
