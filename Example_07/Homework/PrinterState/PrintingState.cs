using System;
using System.Threading.Tasks;

namespace Example_07.Homework.PrinterState
{
	public class PrintingState : IPrinterState
	{
		public IPrinterState Handle(Printer printer)
		{
			Console.WriteLine("Printing...");
			Task.Delay(2000).Wait();
			var content = printer.Device.GetDocument(printer.DocumentName);
			Console.WriteLine(content);
			Console.WriteLine("Ready");
			return new ChooseDocumentState();
		}
	}
}