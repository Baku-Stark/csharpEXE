namespace Exercises.Exers;

public class Ex015: IEx
{
    public void ShowEx()
    {
        bool system = true;
        double money = 0;
        
        while (system)
        {
            Console.WriteLine("Choice a option \n[1] Deposit\n[2] Withdrawal\n[3] Show Amount\n[4>] EXIT");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("=== DEPOSIT ===");
                    Console.WriteLine("Enter amount to deposit: ");
                    double amountDeposit = Convert.ToDouble(Console.ReadLine());
                    money += amountDeposit;

                    Console.WriteLine($"[-] Money (${amountDeposit.ToString("F2")}) deposited successfully");
                    break;
                
                case 2:
                    Console.WriteLine("=== WITHDRAWAL ===");
                    Console.WriteLine("Enter amount to deposit: ");
                    double amountWithdrawal = Convert.ToDouble(Console.ReadLine());
                    money -= amountWithdrawal;

                    Console.WriteLine($"[-] The money was successfully withdrawn. (${amountWithdrawal.ToString("F2")})");
                    break;
                
                case 3:
                    Console.WriteLine("=== SHOW AMOUNT ===");
                    Console.WriteLine($"Your CURRENT amount: ${money.ToString("F2")}");
                    break;
                
                default:
                    system = false;
                    break;
            }
        }
    }
}