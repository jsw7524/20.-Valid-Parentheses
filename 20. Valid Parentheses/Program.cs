using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Valid_Parentheses
{

    public class Solution
    {
        Dictionary<char, char> dic = new Dictionary<char, char>() { { ')', '(' }, { '}', '{' }, { ']', '[' } };
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var c in s)
            {
                if (c == '[' || c == '{' || c=='(')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0 || stack.Peek() != dic[c])
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
            if (stack.Count > 0)
                return false;
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
