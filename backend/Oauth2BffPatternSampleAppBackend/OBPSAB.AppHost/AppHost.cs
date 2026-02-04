var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.OBPSAB_API>("obpsab-api");

builder.AddProject<Projects.OBPSAB_BFF>("obpsab-bff");

builder.Build().Run();
