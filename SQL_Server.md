# SQL Server Docker

## Docker
Você precisa também do Docker instalado e rodando em sua máquina. Caso ainda não tenha realizado esta instalação, aqui está um artigo que mostro como fazer: https://balta.io/blog/docker-instalacao-configuracao-e-primeiros-passos


## Obtendo a imagem
Certifique-se que o Docker está em execução e abra um novo terminal, no meu caso, a versão do Docker em execução é a mostrada abaixo. Você pode verificar isto executando o comando docker --version no seu terminal.

Docker version 19.03.12, build 48a66213fe
Nosso primeiro passo então é obter a imagem do SQL Server que será o molde para criarmos nossos containers. Para isto, executamos o comando abaixo.

```shell 
docker pull mcr.microsoft.com/mssql/server
```
## Mac com chip M1
No momento o SQL Server ainda não suporta os chips M1 da Apple, desta forma, precisamos rodar o Azure SQL Edge:

```shell
docker pull mcr.microsoft.com/azure-sql-edge
```
Note que a primeira mensagem será Using default tag: latest o que significa que estamos obtendo a última versão desta imagem, provavelmente com a última versão estável do Mongo.

Caso queira baixar alguma versão específica, verifique as [tags disponíveis aqui](https://hub.docker.com/_/microsoft-mssql-server).

## Rodando o SQL Server
Para executar esta imagem você pode usar a linha abaixo. Não se esqueça de mudar o MSSQL_SA_PASSWORD para a senha desejado. Mas atenção! A senha tem um nível mínimo de complexidade, se você definir uma senha muito fácil (ex: 1q2w3e4r) o container vai finalizar sozinho.

```shell
docker run --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=1q2w3e4r@#$" -p 1433:1433 -d mcr.microsoft.com/mssql/server
```
Caso a senha que você escolheu seja fraca demais, você verá Exited(1) e a seguinte mensagem:

ERROR: Unable to set system administrator password: Password validation failed. The password does not meet SQL Server password policy requirements because it is not complex enough. The password must be at least 8 characters long and contain characters from three of the following four sets: Uppercase letters, Lowercase letters, Base 10 digits, and Symbols..
Veja os requisitos para a senha de administrador [aqui](https://docs.microsoft.com/en-us/sql/relational-databases/security/password-policy?view=sql-server-ver16#password-complexity).

## Connection String
Se você utilizou as mesmas configurações deste artigo, sua Connection String será igual abaixo. Caso necessário, modifique as informações que alterou na execução dos containers.

```shell
Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$
```
## Erros comuns
A connection was successfully established with the server, but then an error occurred during the pre-login handshake. (provider: SSL Provider
Nas novas versões da imagem do SQL Server, no Windows, tem ocorrido um problema de SSL. Para resolver este problema, primeiro execute os seguintes comandos:

```shell
dotnet dev-certs https --clean
dotnet dev-certs https --trust
```
Feito isto, os certificados HTTPS do .NET estarão atualizados e funcionais. Desta forma, adicione os parâmetros Trusted_Connection e TrustServerCertificate na sua Connection String como mostrado abaixo:

```shell
Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;
```


## GUI Client for Windows
Caso queira gerenciar seu banco de uma forma visual, você pode utilizar uma das ferramentas gratuitas abaixo:

+ [SQL Server Management Studio](https://docs.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms)

+ [Azure Data Studio](https://docs.microsoft.com/pt-br/sql/azure-data-studio/download-azure-data-studio)