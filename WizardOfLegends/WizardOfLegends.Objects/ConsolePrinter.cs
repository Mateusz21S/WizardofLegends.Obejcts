namespace WizardOfLegends.Objects
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string v)
        {
            throw new NotImplementedException();
        }

        public void PrintInfo(string message) {
            Console.WriteLine(message);

            
        }
    }
}
