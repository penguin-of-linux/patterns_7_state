using Example_07.Homework.DocumentProvider;
using Example_07.Homework.PrinterState;

namespace Example_07.Homework
{
	public class Printer
	{
		internal IPrinterState State { get; set; } = new InitialState();

		internal int UserMoney { get; set; }
		internal IDocumentProvider Device { get; set; }
		internal string DocumentName { get; set; }

		public int Price => 10;

		public void Do()
		{
			while (State != null)
			{
				State = State.Handle(this);
			}
		}
	}
}