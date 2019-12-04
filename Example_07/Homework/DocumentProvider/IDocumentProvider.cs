namespace Example_07.Homework.DocumentProvider
{
	public interface IDocumentProvider
	{
		string GetDocument(string documentName);
		string[] GetDocumentNames();
	}
}