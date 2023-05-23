namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input number for create array");
            int lengthArray = int.Parse(Console.ReadLine());

            int[] intArray = new int[lengthArray];

            intArray = GetRandomNumbers(intArray);

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }

        private static int[] GetRandomNumbers(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 500);
            }

            return array;
        }
    }
}