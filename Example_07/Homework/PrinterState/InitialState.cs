using Example_07.Homework.DocumentProvider;

namespace Example_07.Homework.PrinterState
{
	public class InitialState : IPrinterState
	{
		public IPrinterState Handle(Printer printer)
		{
			return new InputMoneyState();
		}
	}
}