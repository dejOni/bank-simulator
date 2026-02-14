public class Main 
{
    public static void main(string[] args)
    {
        BankingServices bs = new BankingServices();
        BankingView bv = new BankingView();
        
        while(true)
        {
            switch(options)
            {
                case "A":
                    bs.Balance();
                break;
                
                case"B":
                    bs.deposit(depositAmount);
                break;
                
                case"C":
                    bs.withdraw(withdrawAmount);
                break;
                
                case"E":
                    break;
                BankingView.Run();
            }
        }
    }
}
