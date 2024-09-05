class Movie
{
    public string Title {get; set;}

    public Movie(string title)
    {
        Title = title;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddSingleton<List<Movie>>(); 
        //Register the list with dependency injection container
        var app = builder.Build();

        // Get all movies
        app.MapGet("/movies", (List<Movie> movies) => movies);
        //UPDATE:Update a movie
        app.MapPut("/movies/{Id}", (int Id) => $"Update movie with id: {Id}");
        //CREATE:Adds a mpvoe
        app.MapPost("/movies", (Movie? movie, List<Movie> movies) () => 
        {   
           if [Movie == null]
           {
            return Results.BadRequest();
           } 
           movies.Add(movie);

           return Results.Created(); 
        });
        //DELETE: Delete a movie with id
        app.MapDelete("/movies/{Id}", (int Id) => $"Delete movie with id: {Id}");


        app.MapGet("/health", () => "hola bitch!!");


        app.Run();
    }
}