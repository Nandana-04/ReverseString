namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string : ");
            string input = Console.ReadLine();
            char[] charArray = new char[input.Length];
            int j = input.Length - 1;
            for (int i = 0; i < input.Length; i++)
            { 
                charArray[i] = input[j];
                j--; 
            }
            string reversed = new string(charArray);
          
            Console.WriteLine("Reversed string is :" + reversed);
        }
    }
}
    
