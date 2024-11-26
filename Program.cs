namespace YieldKeyWord
{
    internal class Program
    {
        //Yield keyWord behaviour

        static IEnumerable<int> Get10Numbers()
        {
            for (int i = 0; i < 10; i++)
                yield return i;
        }

        static void Main(string[] args)
        {
            #region Example 1

            var numbers = Get10Numbers();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            #endregion



            #region Example 2
            IEnumerable<int> GenerateInfiniteNumbers()
            {
                int i = 0;
                while (true)
                {
                    yield return i++;
                }
            }
            foreach (var num in GenerateInfiniteNumbers())
            {
                if (num > 5) break; // Stop manually to prevent infinite loop.
                Console.WriteLine(num);
            }
            #endregion
        }
    }
}
