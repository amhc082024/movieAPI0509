var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Get all movies
app.MapGet("/movies", () => "Return all movies");
//UPDATE:Update a movie
app.MapPut("/movies/{Id}", (int Id) => $"Update movie with id: {Id}");
//CREATE:Adds a mpvoe
app.MapPost("/movies", () => "Add a new movie");
//DELETE: Delete a movie with id
app.MapDelete("/movies/{Id}", (int Id) => $"Delete movie with id: {Id}" );


app.MapGet("/health", () => "hola bitch!!");


app.Run();
