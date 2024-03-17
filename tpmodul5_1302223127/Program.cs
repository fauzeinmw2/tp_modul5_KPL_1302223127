internal class Program
{
    class HaloGeneric
    {
        public static void sapaUser<T>(T X)
        {
            Console.WriteLine($"Halo user {X}");
        }
    }

    public static void Main(string[] args)
    {
        HaloGeneric.sapaUser<string>("Fauzein Mulya Warman");
    }
}