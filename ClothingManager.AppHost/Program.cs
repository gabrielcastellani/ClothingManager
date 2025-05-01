var builder = DistributedApplication.CreateBuilder(args);

var redisCache = builder.AddRedis("redis-cache");
var rabbitMq = builder.AddRabbitMQ("eventbus-rabbitMQ");
var postgresSql = builder.AddPostgres("database-postgresSQL");

var apiService = builder.AddProject<Projects.ClothingManager_ApiService>("apiservice");

builder.AddProject<Projects.ClothingManager_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(redisCache)
    .WaitFor(redisCache)
    .WithReference(rabbitMq)
    .WaitFor(rabbitMq)
    .WithReference(postgresSql)
    .WaitFor(postgresSql)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
