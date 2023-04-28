namespace Day8_Generics_Assignment
{
    class MyStack<T>
    {
        public int count;
        public T[] array;
        public MyStack()
        {
            array = new T[10];
            count = 0;
        }

        public void push(T obj)
        {
            array[count] = obj;
            count++;
        }

        public T pop()
        {
            T item = array[count - 1];
            count--;
            return item;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0;

            int p = 0;
            MyStack<int> myStack = new MyStack<int>();
            myStack.push(1);
            myStack.push(2);
            myStack.push(3);

            foreach (int i in myStack.array)
            {
           
                  
                Console.WriteLine($"Pushed element{++p} : {i}");
            }
            Console.WriteLine($"Number of objects in the stack = {myStack.count}");

            Console.WriteLine($"Poped item {++j} is {myStack.pop()}");
            Console.WriteLine($"Poped item {++j} is {myStack.pop()}");


           
        }
    }
}