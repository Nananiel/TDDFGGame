// See https://aka.ms/new-console-template for more information


using System.Text;

static void Main()
{

}


public interface IFGGame
{
	void Print(string message);
	string FizzOrBuzz(int input);
}

public class FGGame : IFGGame
{
	public string FizzOrBuzz(int input)
	{
		StringBuilder answer = new StringBuilder();
		if(input % 3 == 0)
		{
			answer.Append("Fizz");
		}

		if(input % 5 == 0) 
		{
			answer.Append("Buzz");
		}

		if(answer.Length == 0)
		{
			answer.Clear();
			answer.Append(input);
		}
		return answer.ToString();
	}

	public void Print(string message)
	{
		Console.WriteLine(message);
	}
}