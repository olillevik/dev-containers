FROM mcr.microsoft.com/vscode/devcontainers/dotnet:6.0-focal

RUN wget https://packages.microsoft.com/config/debian/10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb && \
    dpkg -i packages-microsoft-prod.deb

RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
    && apt-get install -y --no-install-recommends apt-transport-https dotnet-sdk-3.1
