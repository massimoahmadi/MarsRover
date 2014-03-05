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

		[TestMethod]
		public void When_A_New_Rover_Is_Given_The_Command_F_The_Position_Should_Be_0_1_N()
		{
			var rover = new MarsRover();

			rover.Move("F");

			Assert.AreEqual("0, 1, N", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_New_Rover_Is_Given_The_Command_B_The_Position_Should_Be_0_Minus1_N()
		{
			var rover = new MarsRover();

			rover.Move("B");

			Assert.AreEqual("0, -1, N", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_New_Rover_Is_Given_The_Command_R_The_Position_Should_Be_0_0_E()
		{
			var rover = new MarsRover();

			rover.Move("R");

			Assert.AreEqual("0, 0, E", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_New_Rover_Is_Given_The_Command_L_The_Position_Should_Be_0_0_W()
		{
			var rover = new MarsRover();

			rover.Move("L");

			Assert.AreEqual("0, 0, W", rover.CurrentPosition);
		}
	}
}
