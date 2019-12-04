namespace Example_07.Homework.PrinterState
{
	public interface IPrinterState
	{
		IPrinterState Handle(Printer printer);
	}
}