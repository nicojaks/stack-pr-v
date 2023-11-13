using System.Diagnostics;

namespace stack_prøv
{
    public class MyStack

    {
        private int _top;


        private int[] stack = new int[2];



        public int Pop()
        {
            _top--;
            return stack[_top];
        }

        public void Push(int tal)
        {
            stack[_top] = tal;
            _top++;
        }

        public void StackIsEmpty()
        {
            if (_top >= 0)
            {
                throw new MyStackIsEmptyException("Stack is empty!");
            }
        }

        public void StackIsFull() 
        {
            if (_top <= 2)
            {
                throw new MyStackIsFullException("stack is full!");
            }
        }

    }
    
}
