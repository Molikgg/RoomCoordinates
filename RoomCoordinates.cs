Console.Write("Enter Number of Coordinates: ");
int size = Convert.ToInt32(Console.ReadLine());
Coordinate[] coordinateArray = Coordinate.GetCoordinate(size);// size 

for(int i = 0; i < coordinateArray.Length; i++)
{
     Console.WriteLine($"{coordinateArray[i].IsAdjacent()} ({coordinateArray[i].Row},{coordinateArray[i].Column})");
}
readonly struct Coordinate
{
   public int Row { get;}
   public int Column { get; }
   
   public readonly bool IsAdjacent() //Checks if Adjacent on a specific instance, didn't felt to put static as its not THAT general method
    {
        if (Math.Abs(Column - Row) == 1) { Console.ForegroundColor = ConsoleColor.Green; return true; }
        else { Console.ForegroundColor = ConsoleColor.White; return false; } 
    }
    public static Coordinate[] GetCoordinate(int size)
    {
        Coordinate[] coordinates = new Coordinate[size];
        for (int i = 0; i < coordinates.Length; i++)
            coordinates[i] = new Coordinate(GenerateNumber(),GenerateNumber());
        return coordinates;
    }
    public Coordinate(int row = 0, int column = 0)
    {
        Row = row;
        Column = column;
    }

    public static int GenerateNumber()
    {
            Random random = new ();
            return random.Next(-2, 3);
    }
}
//Since all instance are nearly identical and do the same job i didn't implement interface
