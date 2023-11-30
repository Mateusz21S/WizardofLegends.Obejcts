namespace WizardOfLegends.Objects
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string v)
        {
            Console.WriteLine(v);
        }
       
    }
}
