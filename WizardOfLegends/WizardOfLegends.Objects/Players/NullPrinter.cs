namespace WizardOfLegends.Objects.Players;

public class NullPrinter : IPrinter{
    public void Print(string message) {
        throw new InvalidOperationException("Printer is not initialized. Cannot print information.");
    }
}