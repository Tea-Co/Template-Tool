using System.Text;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var agentUrl = Environment.GetEnvironmentVariable("AGENT_URL");
var registration = new
{
    name = "template",
    description = "Example tool for template",
    parameters = new Dictionary<string, object>
    {
        { "prompt", new { type = "string", description = "Example parameter" } }
    },
    required = new[] { "prompt" },
    endpoint = "http://template-tool/execute"
};

var client = new HttpClient();
var content = new StringContent(JsonSerializer.Serialize(registration), Encoding.UTF8, "application/json");
var result = await client.PostAsync(agentUrl, content);

app.MapGet("/health", () => Results.Ok("Healthy"));

app.MapPost("/execute", async (JsonElement arguments) =>
{
    var prompt = arguments.GetProperty("prompt").GetString();

    return prompt;
});

app.Run("http://0.0.0.0");
