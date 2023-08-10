namespace SimCard
{

    public class SimCard
    {
        public string CarrierName { get; set; }
        public string Number { get; set; }
        public decimal Balance { get; private set; }

        public decimal Tariff
        {
            get
            {
                decimal tariff = 0.4m;
                return tariff;

                
            }
        }
         public   void  IncreaseBalance(decimal amount)
        {
            if (amount <= 0) 
            { 
                Console.WriteLine($"Balance not increased."); 
            }

            else
            {


                Balance += amount;

                Console.WriteLine($"Your balance increased by {amount}");
            }
        }

       public void  Call()
        {
           
            if (Tariff > Balance)
            {
                Console.WriteLine($"Not enough balance ");

                Console.Write($"Your balance  { Balance}");



            }
            else
            {
                Balance -= Tariff;
                Console.WriteLine(  $"Call successful and your balance {Balance}");
            }


        }
    }



    public class Program

    {
        static void Main(string[] args)
        {
            SimCard simCard=new SimCard();
            simCard.CarrierName = "Azercell";
            simCard.Number= "050-123-56-56";


            simCard.IncreaseBalance(100);

            simCard.Call();

          
        }
    }
}