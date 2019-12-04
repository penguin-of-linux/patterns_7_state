using System.Collections.Generic;

namespace Example_07.Homework.DocumentProvider
{
	public class WiFiDevice : IDocumentProvider
	{
		public string GetDocument(string documentName)
		{
			if (values.ContainsKey(documentName))
			{
				return values[documentName];
			}

			return null;
		}

		public string[] GetDocumentNames() => new[] { "doc3", "doc4" };

		private readonly IDictionary<string, string> values = new Dictionary<string, string>
		{
			{"doc3", "even in death I still serf"},
			{"doc4", "the face is my shield"}
		};
	}
}