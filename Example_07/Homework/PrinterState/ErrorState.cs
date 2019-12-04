using System;

namespace Example_07.Homework.PrinterState
{
	public class ErrorState : IPrinterState
	{
		public ErrorState(string errorText)
		{
			this.errorText = errorText;
		}

		public IPrinterState Handle(Printer printer)
		{
			Console.WriteLine($"Error: {errorText}");
			return new FiniteLaComediaState();
		}

		private readonly string errorText;
	}
}