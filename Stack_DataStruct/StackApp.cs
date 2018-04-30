using System;


namespace Stack_DataStruct
{
    class StackApp
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
