

using StackandQueueProblem;
class Program
{
    static void Main(string[] args)
    {
        Stack_Ex stack_ = new Stack_Ex();
        stack_.push(70);
        stack_.push(30);
        stack_.push(56);
        stack_.peek();
        stack_.Display();

        stack_.Pop();

        stack_.Display();
        stack_.Pop();

        stack_.Display();
        stack_.Pop();

        stack_.Display();
        stack_.Pop();
    }
}
