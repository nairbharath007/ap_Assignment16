using BankAccountAppWithState.Model;

namespace BankAccountAppWithState
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountController controller = new AccountController();
            controller.Start();
        }
    }
}