using System;

namespace Example_07.Homework.PrinterState
{
	public class InputMoneyState : IPrinterState
	{
		public IPrinterState Handle(Printer printer)
		{
			do
			{
				Console.WriteLine("Input money");
				var input = Console.ReadLine();
				if (int.TryParse(input, out var number))
				{
					printer.UserMoney = number;
					break;
				}

				Console.WriteLine("Please input real money");
			} while (true);


			return new ChooseDeviceState();
		}
	}
}