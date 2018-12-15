using System;

namespace Task1
{

    public sealed class ConsoleReader
    {
        private string input = null;
        public string Input { get { return input; } }

        public void GetConsoleData()
        {
            input = Console.ReadLine();
        }
    }


    public sealed class ParseInput
    {
        private bool isValid;
        public bool IsValid { get { return isValid; } }

        private int inputCount = 0;
        public int InputCount { get { return inputCount; } }

        public void Start(string _input)
        {
            if (int.TryParse(_input, out inputCount) == false || inputCount < 0)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }


        }
    }


    public class Logic
    {
        private long[] array = null;

        public long Result(int stopIndex)
        {
            array = new long [] { 0, 0, 0, 1 };
            int i;
            checked
            {
                for (i = 0; i < stopIndex; i++)
                {
                    //use cyclic memory
                    int index = (i % array.Length);
                    array[index] = 0;

                    for (long a = 1; a < array.Length; a++)
                    {
                        array[index] += array[(index + a) % array.Length];
                    }

                }
            }
            return stopIndex == 0 ? 1 : array[--i % 4];
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var reader = new ConsoleReader();
                var parseInput = new ParseInput();
                var mainLogic = new Logic();

                Console.WriteLine("Enter any integers");

                reader.GetConsoleData();
                parseInput.Start(reader.Input);

                if (parseInput.IsValid)
                {
                    Console.WriteLine(mainLogic.Result(parseInput.InputCount));
                }
                else
                {
                    Console.WriteLine("Not valid input");
                }
            }
            catch (OverflowException exc)
            {
                Console.WriteLine("Sorry overflow!");
            }
            Console.ReadLine();
        }
    }
}
