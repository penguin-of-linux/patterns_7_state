using System.Collections.Generic;

namespace Example_07.Homework.DocumentProvider
{
	// ReSharper disable once InconsistentNaming
	public class USBDevice : IDocumentProvider
	{
		public string GetDocument(string documentName)
		{
			if (values.ContainsKey(documentName))
			{
				return values[documentName];
			}

			return null;
		}

		public string[] GetDocumentNames() => new[] {"doc1", "doc2"};

		private readonly IDictionary<string, string> values = new Dictionary<string, string>
		{
			{"doc1", "the earth do not deserve to touch my feet"},
			{"doc2", "death is my feed, terror my wine"}
		};
	}
}