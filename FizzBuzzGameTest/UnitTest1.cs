
namespace FizzBuzzGameTest
{
	[TestClass]
	public class UnitTest1
	{
		private FGGame fgObj = new FGGame();

		[TestMethod]
		public void ShouldPrintFizz()
		{
			//arrange 
			var tiga = 6;

			var result = fgObj.FizzOrBuzz(tiga);
			Assert.AreEqual("fizz", result.ToLower());
		}
		[TestMethod]
		public void ShouldPrintBuzz()
		{
			//arrange 
			var lima = 10;

			var result = fgObj.FizzOrBuzz(lima);
			Assert.AreEqual("buzz", result.ToLower());
		}

		[TestMethod]
		public void ShouldPrintFizzBuzz()
		{
			//arrange 
			var limablas = 15;

			var result = fgObj.FizzOrBuzz(limablas);
			Assert.AreEqual("fizzbuzz", result.ToLower());
		}

		[TestMethod]
		public void ShouldPrintItself()
		{
			//arrange 
			var tujuh = 7;

			var result = fgObj.FizzOrBuzz(tujuh);
			Assert.AreEqual("7", result.ToLower());
		}
	}
}