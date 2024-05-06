# open-weather
api de previsão do tempo dos próximos dias

Padrões de projeto aplicado no back end:
DDD, Repository, Microservices Architecture, Application Service Layer

Para rodar no docker:

docker build -t openweather .
ou 
docker-compose up

Foi implementado o swagger, então ta facil de validar a api.
Caso queira apenas ver no swagger sem usar o docker, apertar f5

urls:
https://localhost:5001/index.html
http://localhost:5000/index.html

Colocar a api key do no arquivo appsettings onde esta o XXX