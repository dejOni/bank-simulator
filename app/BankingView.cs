using ATMApp.Services;

namespace ATMApp.View
{
    public static class BankingView
    {
        public static void Run()
        {
            BankingServices bs = new BankingServices();
            BankingView bv = new BankingView();
        
            double balance = 1000.00;
            
            Console.WriteLine ("Simple ATM System");
            Console.WriteLine ();
            Console.WriteLine ("ATM MENU");
        
            Console.WriteLine ("A.Check Balance");
            Console.WriteLine ("B.Deposit Money");
            Console.WriteLine ("C.Withdraw Money");
            Console.WriteLine ("D.Print Mini Statement");
            Console.WriteLine ("E.Exit");
                String options = Console.ReadLine();
    
            if(options != "A" && options != "B" && options != "C" && options != "D" && options != "E" )
            {
                Console.WriteLine("Invalid Input!!!");
                
                    return null;
            }
                if(options == "A") 
                {
                    Console.WriteLine(balance);
                }
                if(options == "B")
                {
                    Console.WriteLine("Enter amount to deposit: ");
                        double amountDeposit = Convert.ToDouble(Console.ReadLine());
                }
                    else if(amountDeposit >= 0)
                    {
                        Console.WriteLine("This amount is negative");
                    }
                    else
                    {
                        Console.WriteLine("This amount is positive");
                    }
                if(options == "D")
                {
                    Console.WriteLine("--- Mini Statement ---");
                    Console.WriteLine("Current Balance : ₱" + balance);
                    Console.WriteLine("Last Transaction : ₱" + amount);
                    Console.WriteLine("----------------------");
                }
        }
    }
}
