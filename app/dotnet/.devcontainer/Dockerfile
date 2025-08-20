FROM mcr.microsoft.com/dotnet/sdk:9.0

WORKDIR /workspace

RUN apt-get update && apt-get install -y \
    git \
    curl \
    vim \
    make \
    && rm -rf /var/lib/apt/lists/*

CMD ["tail", "-f", "/dev/null"]