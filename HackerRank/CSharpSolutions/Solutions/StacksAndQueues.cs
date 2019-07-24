using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Solutions
{
    class StacksAndQueues
    {
        /*
            Each open bracket must have a corresponding closing bracket
            if everything is fine we call the sequence balanced and return "YES".
            Otherwise the sequence is unbalanced and we return "NO".

            {[()]} - balanced
            {[(])} - unbalanced
            {{[[(())]]}} - balanced
        */
        public static string BalancedBrackets(string sequence)
        {
            // if the first one is closing the sequence it's automatically unbalanced
            if(sequence[0] == ')' || sequence[0] == ']' || sequence[0] == '}')
                return "NO";

            var stack = new Stack<char>();

            // we go one by one
            for(int i = 0; i < sequence.Length; i++)
            {
                char current = sequence[i];

                // opening bracket
                if(current == '(' || current == '[' || current == '{')
                {
                    stack.Push(current);
                }
                // closing bracket
                else
                {
                    if (stack.Count == 0)
                        return "NO";

                    char last = stack.Pop();
                    if ((last == '(' && current == ')') 
                        || (last == '[' && current == ']') 
                        || (last == '{' && current == '}'))
                    {
                        // it's ok both of them cancel each other out
                    }
                    else
                        return "NO";
                }
            }

            return stack.Count == 0 ? "YES" : "NO";
        }
    }
}
