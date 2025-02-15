using ToDo.Controller;

internal class Program
{
    private static void Main(string[] args)
    {
        LoginModule loginModule = new LoginModule();
        if (loginModule.UserLogin())
        {
            Console.WriteLine("Working");
        }
    }
}