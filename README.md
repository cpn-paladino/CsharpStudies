# CsharpStudies

This project is a brief study about C# using Linux with .Net core 5.0 using Microsoft references.

## How to install .Net on Ubuntu 18.04

These steps allow you install the .net Core on your Linux Ubuntu 18, you can find more details here:[Microsoft docs!](https://docs.microsoft.com/pt-br/dotnet/core/install/)

1. Add the Microsoft signing key in to your local Linux list of trusted keys:

```sh
$ wget https://packages.microsoft.com/config/ubuntu/17.10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
$ sudo dpkg -i packages-microsoft-prod.deb
$ rm packages-microsoft-prod.deb
```

1. Just install the .Net Core SDK:

```sh
$ sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-2.1
```

1. Check the version:
```sh
$ dotnet --version
```