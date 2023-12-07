class Workspace
{
    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(", "), int.Parse);
        Lake lake = new Lake(input);
        Console.WriteLine(string.Join(", ", lake));
    }
}