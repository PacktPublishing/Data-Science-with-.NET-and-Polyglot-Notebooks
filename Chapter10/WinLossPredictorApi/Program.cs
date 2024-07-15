using WinLossPredictorApi;
using Microsoft.Extensions.ML;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddPredictionEnginePool<PredictionRequest, PredictionResult>()
    .FromFile(modelName: "WinLossPredictor", filePath: "WinLossPredictor.zip", watchForChanges: true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.MapPost("/winlosspredictor", (PredictionEnginePool<PredictionRequest, PredictionResult> pool, PredictionRequest request) =>
    {
        PredictionResult result = pool.Predict("WinLossPredictor", request);
        return Results.Ok(result.PredictedLabel);
    })
.WithName("WinLossPredictor")
.WithOpenApi();

app.Run();
