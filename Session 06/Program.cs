namespace Session_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st q
            double[] Prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(Prices[1]);

            #endregion

            #region 2nd q

            int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };

            Console.WriteLine(shelfCopies[1,0]);

            #endregion

            #region 3rd q

            static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }

            PrintWelcomeMessage();
            #endregion
        }
    }
}
