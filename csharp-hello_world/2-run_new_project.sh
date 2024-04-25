#!/usr/bin/env bash
dotnet new console -o 2-new_project
cd 2-new_project/
dotnet build
dotnet run 2-new_project.csproj

