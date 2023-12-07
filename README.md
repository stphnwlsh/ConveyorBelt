# Conveyor Belt

## Description

A sample project to calculate the number of shipping boxes required to handle a collection of products coming off a conveyor belt.  Each shipping box has a maximum of 10 items and a maximum weight of 20kg.  Each product can be 1, 2 or 3kg in weight.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)

## Installation

### Dependencies

Building and running the application requires Git to retrieve and .NET 8 to build and run the application. You can choose to use Docker to avoid installing the .NET SDK on your machine or to run it natively via the .NET 8 SDK.

- Download [Git](https://git-scm.com/downloads) here
- Download [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) here

or 

- Download [Git](https://git-scm.com/downloads) here
- Download [Docker Desktop](https://www.docker.com/products/docker-desktop/) here

### Docker Instructions

```bash
# Clone the repository
git clone https://github.com/stphnwlsh/ConveryorBelt.git

# Navigate to the project directory
cd ConveryorBelt

# Build the project
docker build . -t converyorbelt
```

### .NET Instructions

```bash
# Clone the repository
git clone https://github.com/stphnwlsh/ConveryorBelt.git

# Navigate to the project directory
cd ConveryorBelt

# Build the project
dotnet build
```

## Usage

### Docker Instructions

```bash
# Run the application with default settings
docker run converyorbelt
```

### .NET Instructions

```bash
# Run the application with default settings
dotnet run
```
