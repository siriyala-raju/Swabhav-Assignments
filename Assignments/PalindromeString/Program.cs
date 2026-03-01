namespace PalindromeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String: ");
            string input = Console.ReadLine();

            string word = input.ToLower();
            bool isPalindrome = true;

            for (int i = 0; i < word.Length / 2 ; i++)
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            if (isPalindrome)
            {
                Console.WriteLine($"{word} is a Palindrome String");
            }
            else 
            {
                Console.WriteLine($"{word} is not a Palindrome String");
            }

        }
    }
}
