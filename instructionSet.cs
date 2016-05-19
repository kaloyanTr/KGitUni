using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11InstrurctionSet
{
    class instructionSet
    {
        static void Main(string[] args)
        {
            string[] codeArgs = Console.ReadLine().ToUpper().Split(' ');
            string opCode = string.Empty;

            while (opCode != "end")
            {
                decimal result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        int operandOne = int.Parse(codeArgs[1]);
                        result += operandOne;
                        break;
                    case "DEC":
                        operandOne = int.Parse(codeArgs[1]);
                        result -= operandOne;
                        break;
                    case "ADD":
                        operandOne = int.Parse(codeArgs[1]);
                        int operandTwo = int.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    case "MLA":
                        operandOne = int.Parse(codeArgs[1]);
                        operandTwo = int.Parse(codeArgs[2]);
                        result = (long)operandOne * (long)operandTwo;
                        break;
                    default:
                        break;

                }

                Console.WriteLine(result);
            }
        }
    }
}
