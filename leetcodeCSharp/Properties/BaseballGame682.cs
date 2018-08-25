using System;
using System.Collections.Generic;

namespace leetcodeCSharp
{
    public class BaseballGame682
    {
        public int CalPoints(string[] ops) {
            var stack = new Stack<int>();
        
            foreach(var op in ops)
            {
                switch (op)
                {
                    case "C":
                        stack.Pop();
                        break;
                    case "D":
                        stack.Push(2 * stack.Peek());
                        break;
                    case "+":
                        int top = stack.Pop();
                        int newTop = top + stack.Peek();
                        stack.Push(top);
                        stack.Push(newTop);
                        break;
                    default:
                        stack.Push(int.Parse(op));
                        break;
                }
            }
        
            var sum = 0;
        
            while(stack.Count > 0)
            {
                sum += stack.Pop();
            }
        
            return sum;
        }
    }
}