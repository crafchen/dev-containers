FROM node:20

WORKDIR /workspace/app/react
COPY package*.json ./
RUN npm install

COPY . .
CMD ["npm", "run", "dev"]