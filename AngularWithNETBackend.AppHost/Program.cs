var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AngularWithNETBackend_Server>("angularwithnetbackend-server");

builder.Build().Run();
