FROM golang:1.21

WORKDIR /workspace/app/go
COPY . .
RUN go mod init example.com/app || true
RUN go mod tidy