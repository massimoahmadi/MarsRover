using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover
{
	[TestClass]
	public class UnitTests
	{
		[TestMethod]
		public void When_A_New_Rover_Is_Created_The_Position_Should_Be_0_0_N()
		{
			var rover = new MarsRover();

			Assert.AreEqual("0, 0, N", rover.CurrentPosition);
		}
	}
}
