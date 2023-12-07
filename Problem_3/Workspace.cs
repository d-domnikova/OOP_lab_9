class Workspace
{
    static void Main(String[] args)
    {
        Stack<int> stack = new Stack<int>();

        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input[0].ToLower().Contains("end")) break;

            switch (input[0].ToLower())
            {
                case "push":
                    string[] arr = input.Skip(1).ToArray();
                    int[] converted = Array.ConvertAll(arr, int.Parse);
                    stack.push(converted);
                    break;
                case "pop":
                    stack.pop();
                    break;
            }
        }
        for (int i = 0; i<2; i++) { 
            foreach (int j in stack)
            {
                Console.WriteLine(j);
            }
        }
    }
}