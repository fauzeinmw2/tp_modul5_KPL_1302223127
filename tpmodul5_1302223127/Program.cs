internal class Program
{

    class HaloGeneric
    {
        public static void sapaUser<T>(T X)
        {
            Console.WriteLine($"Halo user {X}");
        }
    }
       
    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang Tersimpan Adalah: {data}");
        }

    }

    private static void Main(string[] args)
    {
        HaloGeneric.sapaUser<string>("Fauzein Mulya Warman");

        DataGeneric<string> objStr = new DataGeneric<string>("1302223127");
        objStr.PrintData();

        DataGeneric<int> objInt = new DataGeneric<int>(1302223127);
        objInt.PrintData();
    }
}