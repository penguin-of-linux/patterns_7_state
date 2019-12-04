using System;
using System.Collections.Generic;
using Example_07.Homework.DocumentProvider;

namespace Example_07.Homework.PrinterState
{
	public class ChooseDeviceState : IPrinterState
	{
		public IPrinterState Handle(Printer printer)
		{
			do
			{
				Console.WriteLine("Input device (wifi if usb)");
				var input = Console.ReadLine();
				if (devices.ContainsKey(input))
				{
					printer.Device = devices[input];
					break;
				}

				Console.WriteLine("Please input wifi or usb");
			} while (true);

			return new ChooseDocumentState();
		}

		private readonly Dictionary<string, IDocumentProvider> devices = new Dictionary<string, IDocumentProvider>
		{
			{"wifi", new WiFiDevice() },
			{"usb", new USBDevice() }
		};
	}
}