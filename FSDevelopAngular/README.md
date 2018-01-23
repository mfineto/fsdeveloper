Listagem de Produtos

Projeto Angular que faz acesso a API .Net com MongoDB.
Utiliza token para validação de acesso a API, somento sendo acessível quando realizado previamente um login.
Token possui tempo de expiração de 1 minuto que pode ser configurável.


Instalação e Execução

Necessário

.Net Core - https://www.microsoft.com/net/download/
MongoDB - https://docs.mongodb.com/manual/administration/install-community/ ou https://hub.docker.com/_/mongo/
NodeJs - https://nodejs.org

1 - Inicialização do Banco de Dados

- Após instalado o MongoDB, acessar a pasta FSDevelopCarga.
- Alterar o appsettings.json para o endereço que o Mongo esteja instalado.
- Ainda dentro da mesma pasta, executar "dotnet run" pelo Terminal/Console para que o projeto seja executado.
- Após executado o banco de dados já está inicializado.

2 - Inicialização das APIs

- Acessar a pasta FSDevelop pelo Terminal/Console, e executar "dotnet run".
- Você receberá uma mensagem parecida com essa, "Now listening on: http://localhost:5000".
- É o endereço que o Kestrel estará respondendo as requisições.
- Caso queira testar a API, existe um projeto do Postman dentro da pasta com o mesmo nome.

3 - Inicialização do Frontend

- Acessar a pasta FSDevelopAngular pelo terminal
- Executar o npm install
- Instalar o servidor http "npm install -g http-server"
- Executar o comando "http-server"
- Vocë deverá receber uma mensagem igual a essa.
"Available on:
  http://127.0.0.1:8080
  http://192.168.15.6:8080""
- Basta acessar o endereço para navegar
- O usuário que está cadastrado no mongo é 'USER01' / '123456' é possível alterar no projeto de inicialização.