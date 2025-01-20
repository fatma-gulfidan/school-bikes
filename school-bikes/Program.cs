using Spectre.Console;


class Program
{
static void Main (string[] args)
{

    AnsiConsole.Write(
    new FigletText("Bike Sales")
     .LeftJustified()
     .Color(Color.Red));

    AnsiConsole.Write(
        new BarChart()
        .Width(60)
        .CenterLabel()
        .AddItem("Mountain-Bikes",50,Color.Yellow)
         .AddItem("E-Bikes",54,Color.Green)
          .AddItem("Velos",12,Color.Red)

    );
    
}
}