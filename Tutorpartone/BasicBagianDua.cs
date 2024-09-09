using System;

namespace Tutorpartone
{
    class BasicBagianDua
    {
        // Instance variable
        private int instanceVariable = 10;

        // Static variable
        private static int staticVariable = 20;

        // Constant variable
        private const double Pi = 3.14159;

        // Read-only variable
        private readonly DateTime creationDate;

        public BasicBagianDua()
        {
            // Initializing read-only variable in constructor
            creationDate = DateTime.Now;
        }

        public void ShowVariables()
        {
            // Local variable
            int localVar = 5;

            Console.WriteLine("Instance Variable: " + instanceVariable);
            Console.WriteLine("Static Variable: " + staticVariable);
            Console.WriteLine("Constant: " + Pi);
            Console.WriteLine("Read-Only Variable: " + creationDate);
            Console.WriteLine("Local Variable: " + localVar);
        }
    }
}
