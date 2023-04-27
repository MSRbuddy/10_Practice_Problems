namespace PersonAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to PersonAge Determination Problem!*****");
            Console.WriteLine("--------------------------------------------------------\n");

            try
            {
                Console.Write("Enter person age: ");
                int age = int.Parse(Console.ReadLine());
                string category = GetAgeCategory(age);
                Console.WriteLine("\nPerson category: " + category);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid age: Age must be an integer.");
            }
            catch (AgeOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid age: Age cannot be null or empty.");
            }
        }

        static string GetAgeCategory(int age)
        {
            if (age < 1 || age > 100)
            {
                throw new AgeOutOfRangeException();
            }
            else if (age <= 14)
            {
                return "Children";
            }
            else if (age <= 24)
            {
                return "Youth";
            }
            else if (age <= 64)
            {
                return "Adults";
            }
            else
            {
                return "Seniors";
            }
        }
    }

    class AgeOutOfRangeException : Exception
    {
        public AgeOutOfRangeException() : base("Invalid age: Age must be between 1 and 100.") { }
    }
}