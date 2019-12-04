using System;

namespace Example_07.Homework.PrinterState
{
	public class GetChangeState : IPrinterState
	{
		public IPrinterState Handle(Printer printer)
		{
			Console.WriteLine($"Take change: {printer.UserMoney}");
			return new FiniteLaComediaState();
		}
	}
}