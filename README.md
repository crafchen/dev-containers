# Job Portal Dev - Development Environment Guide

## Introduction

This project provides a ready-to-use development environment using Docker and Dev Containers, ensuring consistency and ease of setup for all developers.

## Requirements

- [Docker](https://www.docker.com/)
- [Visual Studio Code](https://code.visualstudio.com/)
- [Dev Containers Extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers)

## Getting Started

1. **Clone the repository:**
    ```bash
    git clone <repo-link>
    cd job-portal-dev
    ```

2. **Open with VS Code:**
    - Open the `job-portal-dev` folder in VS Code.
    - Press `F1`, search for and select `Dev Containers: Reopen in Container`.

3. **Work inside the container:**
    - VS Code will automatically build and open the development environment inside the container.
    - You can install additional extensions or configure as needed.

## Project Structure

```
job-portal-dev/
├── .devcontainer/
│   ├── devcontainer.json
│   └── Dockerfile
├── app/
├── composes/
├── script/
├── Makefile
└── README.md
```

- **.devcontainer/**: Dev Containers configuration files.
- **app/**: Application source code and related files.
- **compose/**: Docker Compose configuration files.
- **script/**: Utility and setup scripts.
- **README.md**: Project documentation.

## Customization

- Edit `.devcontainer/devcontainer.json` to change the container configuration.
- Edit `.devcontainer/Dockerfile` to install additional required packages.

## Contribution

Feel free to open an issue or submit a pull request if you want to contribute or report