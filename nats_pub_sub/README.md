# Nats basic project with C#

This a simple project to understand the concepts about producer and consument using Nats.

## install on ubuntu

- install nats using docker:
```sh
$ docker pull nats:latest
```

- run the image:
```sh
$ docker run -p 4222:4222 -p 8222:8222 -p 6222:6222 --name nats-server -ti nats:latest
```

- create a folder called NATS_PUB_SUB and create a new sln:
```sh
$ mkdir NATS_PUB_SUB
$ cd NATS_PUB_SUB
$ dotnet new sln --output nats_pub_sub
$ cd nats_pub_sub
```

- create a new console project for publisher:
```sh
$ dotnet new console --output publisher
```

- create a new console project for subscriber:
```sh
$ dotnet new console --output subscriber
```

- add the projects to your one os projetos a solução
```sh
$ dotnet sln add ./publisher/publisher.csproj
$ dotnet sln add ./subscriber/subscriber.csproj
```

- add the nats package in your solution:
```sh
$ cd NATS_PUB_SUB
$ dotnet add package NATS.Client --version 0.14.1
```