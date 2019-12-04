using System;
using System.Linq;

namespace Example_07.Homework.PrinterState
{
	public class ChooseDocumentState : IPrinterState
	{
		public IPrinterState Handle(Printer printer)
		{
			var docs = string.Join(",", printer.Device.GetDocumentNames()
				.Select(p => p.ToString()).ToArray());

			Console.WriteLine("Input doc name or press Enter to exit");
			Console.WriteLine($"Documents: [{docs}]");
			printer.DocumentName = Console.ReadLine();
			if (string.IsNullOrEmpty(printer.DocumentName))
			{
				return new GetChangeState();
			}

			if (!printer.Device.GetDocumentNames().Contains(printer.DocumentName))
			{
				return new ErrorState("Selected document do not exists");
			}

			if (printer.UserMoney >= printer.Price)
			{
				printer.UserMoney -= printer.Price;
				return new PrintingState();
			}

			return new ErrorState("Not enough money");
		}
	}
}