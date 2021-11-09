# aspnetcoreapp

A just simple example, using Asp core.

## Requirements

- dev certificate trusted

## Trust on .net HTTPS certificate for development in Ubuntu 18.04 and Google Chrome

- run the below command to trust on .net certificate
```sh
$ dotnet dev-certs https --trust
```
- install openssl:
```sh
$ sudo apt update
$ sudo apt install openssl
```
- link certificates:
```sh
$ dotnet dev-certs https
$ sudo -E dotnet dev-certs https -ep /usr/local/share/ca-certificates/aspnet/https.crt --format PEM
$ sudo update-ca-certificates
```
- Install libnss3-tools and link with google chrome:
```sh
$ sudo apt-get install libnss3-tools
$ dotnet dev-certs https
$ sudo -E dotnet dev-certs https -ep /usr/local/share/ca-certificates/aspnet/https.crt --format PEM
```
- Use certutil to associate the certificates:
```sh
$ certutil -d sql:$HOME/.pki/nssdb -A -t "P,," -n localhost -i /usr/local/share/ca-certificates/aspnet/https.crt
$ certutil -d sql:$HOME/.pki/nssdb -A -t "C,," -n localhost -i /usr/local/share/ca-certificates/aspnet/https.crt
```
- Restart your chrome browser typing on Address bar: chrome://restart


## Create a basic Asp Core project


Create an asp project with this comand:
```sh
$ dotnet new webapp -o aspnetcoreapp
```

Run your project:
```sh
$ cd aspnetcoreapp
$ dotnet watch run
```