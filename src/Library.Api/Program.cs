var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// API kiem tra trang thai he thong
app.MapGet("/", () =>
{
    return Results.Ok(new
    {
        service = "Library.Api",
        project = "Distributed Library System",
        status = "running"
    });
});

// API kiem tra trang thai dich vu
app.MapGet("/api/status", () =>
{
    return Results.Ok(new
    {
        service = "Library.Api",
        status = "OK",
        timestamp = DateTime.UtcNow
    });
});

app.Run();