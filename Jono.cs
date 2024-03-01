using System.Collections.Specialized;
using System.Reflection.Metadata;

class StringQueue
{
	public List<string> strings {get; private set;} = new List<string>();
	
	public int Count {get; private set;} 
	
	private string stringreturn = "";
	public StringQueue() 
	{
		
	}
	
	public void Enqueue(string enqueue)
	{
		strings.Add(enqueue);
		Count++;
	}
	
	public string Dequeue()
	{
		
		if(strings.Count > 0)
		{
			stringreturn = strings.ElementAt(0);
			strings.RemoveAt(0);
			Count--;
			return stringreturn;
		} 
		else
		{
			stringreturn = "QUEUE EMPTY";
			return stringreturn;
		}
	}
	public string Peek()
	{
		if(strings.Count > 0)
		{
			stringreturn = strings.ElementAt(0);
			return stringreturn;
		} 
		else
		{
			stringreturn = "QUEUE EMPTY";
			return stringreturn;
		}
		
	}
	
	public void Print()
	{
		foreach (var item in strings)
		{
			Console.WriteLine(item);
		}
	}
}