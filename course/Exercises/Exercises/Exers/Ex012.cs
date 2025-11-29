namespace Exercises.Exers;

public class Ex012: IEx
{
    public void ShowEx()
    {
        Random rand = new Random();
        
        string[] words = { "CSHARP", "JAVA", "FLAMENGO" };
        string secretWord = words[rand.Next(words.Length)].ToUpper();
        HashSet<char> userLetters = new HashSet<char>();
        
        int choiceTimes = 6;
        while (true)
        {
            string wordVerify = "";
            Console.Write($"WORD: ");
            foreach (var letter in secretWord)
            {
                if (userLetters.Contains(letter))
                {
                    Console.Write($"{letter} ");
                    wordVerify += letter;
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine(".");

            if (secretWord.Equals(wordVerify))
            {
                Console.WriteLine("CONGRATULATIONS!!!");
                break;
            }
            
            Console.WriteLine($"Try to guess the letter. You have {choiceTimes} chances");
            char userLetter = Convert.ToChar(Convert.ToString(Console.ReadLine()!).Trim().ToUpper());
            //Console.WriteLine(CapitalizeFirstLetter(userSentence));

            if (userLetters.Contains(userLetter))
            {
                Console.WriteLine("[x] You have already tried this letter. Choose another one!");
            }
            else if (secretWord.Contains(userLetter))
            {
                Console.WriteLine($"[+] Letter '{userLetter}' found!");
                userLetters.Add(userLetter);
            }
            else
            {
                Console.WriteLine("[=] This letter does not exist in the chosen word");
                choiceTimes--;
            }
            
            if (choiceTimes == 0)
                break;
            
            for (int i = 0; i < 20; i++)
            {
                Console.Write("==");
            }
            Console.WriteLine();
        }

        Console.WriteLine("DONE");
        Console.WriteLine($"Sentence: {secretWord}");
    }
}