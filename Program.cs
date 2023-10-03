// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using NLog;

// See https://aka.ms/new-console-template for more information
string path = Directory.GetCurrentDirectory() + "\\nlog.config";

// create instance of Logger
var logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();
logger.Info("Program started");

Console.WriteLine("Hello World!");

logger.Info("Program ended");

//Create instance of Movie Class
Movie movie = new Movie
{
  movieId = 1,
  title = "Jeff's Killer Movie (2019)",
  genres = new List<string> { "Action", "Romance", "Comedy" }
};
