using Design_Patterns_Assignment.Observer.Subject;

namespace Design_Patterns_Assignment
{
    internal interface IObserverMenu
    {
        IEmail Email { get; set; }

        void Run();
    }
}