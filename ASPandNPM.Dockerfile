FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY --from=frontend . .
COPY ["myProject.WebUi/myProject.WebUi.csproj", "myProject.WebUi/"]
COPY ["myProject.SearchIndex/myProject.SearchIndex.csproj", "myProject.SearchIndex/"]
COPY ["myProject.SearchIndex.Common/myProject.SearchIndex.Common.csproj", "myProject.SearchIndex.Common/"]

RUN dotnet restore "myProject.WebUi/myProject.WebUi.csproj"
COPY . .
WORKDIR "/src/myProject.WebUi"
RUN apt-get update -yq && apt-get upgrade -yq && apt-get install -yq curl git nano
RUN curl -sL https://deb.nodesource.com/setup_8.x | bash - && apt-get install -yq nodejs build-essential
RUN npm install -g npm
RUN npm install
RUN dotnet build "myProject.WebUi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "myProject.WebUi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "myProject.WebUi.dll"]
