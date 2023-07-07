namespace Try_and_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);

            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception , the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNull exception , the number was too long or too short for an int32");
            }
            finally
            {
                Console.WriteLine("");
            }


            Console.ReadKey();
        }
    }
}