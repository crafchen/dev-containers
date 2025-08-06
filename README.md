# Dev Containers Project Usage Guide

## Introduction

This project provides a development environment using Docker and Dev Containers, making it easy to set up and develop applications in a consistent environment.

## Requirements

- [Docker](https://www.docker.com/)
- [Visual Studio Code](https://code.visualstudio.com/)
- [Dev Containers Extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers)

## How to Use

1. **Clone the repository:**
    ```bash
    git clone <repo-link>
    cd dev-containers
    ```

2. **Open with VS Code:**
    - Select `Open Folder` and open the project directory.
    - Press `F1`, search for and select `Dev Containers: Reopen in Container`.

3. **Work inside the container:**
    - VS Code will automatically build and open the development environment inside the container.
    - You can install additional extensions or configure as needed.

## Folder Structure

```
dev-containers/
├── .devcontainer/
│   ├── devcontainer.json
│   └── Dockerfile
├── src/
└── README.md
```

## Customization

- Edit `.devcontainer/devcontainer.json` to change the container configuration.
- Edit `.devcontainer/Dockerfile` to install additional required packages.

## Contribution

Please create a pull request or issue if you want to contribute or report a bug.
