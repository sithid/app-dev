# Use a versatile base image
FROM ubuntu:latest

# Update the system
RUN apt-get update && apt-get upgrade -y

RUN apt-get install -y \
    build-essential \
    git \
    curl \
    wget \
    vim \
    nano \
    unzip \
    zip \
    openjdk-11-jdk \
    default-jdk \
    python3 \
    nodejs \
    npm \
    yarn \
    cargo \
    dotnet-sdk-8.0

RUN apt-get install -y gcc g++ cmake clang

WORKDIR /app