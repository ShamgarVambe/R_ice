using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using R_ice.Services;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Function1
{
    private readonly ILogger<Function1> _logger;
    private readonly string _storageConnectionString;
    private readonly TableStorageService _tableStorageService;

    public Function1(ILogger<Function1> logger, TableStorageService tableStorageService)
    {
        _logger = logger;
        _storageConnectionString = Environment.GetEnvironmentVariable("connection");
        _tableStorageService = tableStorageService;
    }

    [Function(nameof(sendMe))]
    public async Task sendMe ([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");

        try
        {

        }
    }
    [Function(nameof(receiveMe))]
    public async Task receiveMe([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");

        try
        {

        }
    }

}

