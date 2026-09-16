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

            #region 4th q

            static void PrintBookTitle(string title)
            {
                Console.WriteLine($"Book title : {title}");

            }
            PrintBookTitle("Clean Code");
            #endregion

            #region 5th q
            int pages = 400;
            static void AddBonusPages(int pages)
            {
                int result = pages + 50;

                Console.WriteLine(result);
            }
            AddBonusPages(pages);
            Console.WriteLine(pages);
            /*the value of pages still 400 becuase the parameter is passed by value so the method work on copy object not the original */
         
            #endregion
        }
    }
}
