using System;
using System.Collections.Generic;
using System.Text;

namespace Matheus_Pacheco
{
    class PlenaTest
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string input = Console.ReadLine();

            PlenaTest myImplementation = new PlenaTest();
            myImplementation.ProcessString(input);

        }

        public void ProcessString(string input)
        {
            // Create and populate Dictionary to keep track of how many times each letter is in the string
            Dictionary<char,int> occurances_dict = new Dictionary<char,int>();
            for (int i = 0; i < input.Length; i++)
            {
                if(occurances_dict.ContainsKey(Char.ToLower(input[i])))
                {
                    occurances_dict[input[i]] = occurances_dict[input[i]] + 1;
                }
                else
                    occurances_dict.Add(Char.ToLower(input[i]), 1);   
            }
            
            // For each character of the input string, insert it at its correct location as per occurances_dict data
            StringBuilder result = new StringBuilder();    
            for (int i = 0; i < input.Length; i++)
            {
                int index = 0;

                for (int j = 0; j < result.Length; j++)
                {
                    if(occurances_dict[Char.ToLower(input[i])] >= occurances_dict[Char.ToLower(result[j])])
                        index++;
                    else
                        break;
                }
                
                result.Insert(index, input[i]);
            }
            
            //Print final result
            Console.WriteLine(result.ToString());
            Console.Write("Press any key to close...");
            Console.ReadKey();
        }
    
    }
}
