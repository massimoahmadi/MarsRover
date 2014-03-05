using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover
{
	[TestClass]
	public class CombinedCommandUnitTests
	{
		[TestMethod]
		public void When_A_New_Rover_Is_Given_The_Command_FF_The_Position_Should_Be_0_2_N()
		{
			var rover = new MarsRover();

			rover.Move("FF");

			Assert.AreEqual("0, 2, N", rover.CurrentPosition);
		}
	}
}
