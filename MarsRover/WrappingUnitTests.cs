using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover
{
	[TestClass]
	public class WrappingUnitTests
	{
		[TestMethod]
		public void When_A_Rover_Is_Facing_North_At_0_9_And_Given_The_Command_F_On_A_10_By_10_Grid_The_Position_Should_Be_0_0_N()
		{
			var rover = new MarsRover(new Mars());
			rover.Move("FFFFFFFFF");
			Assert.AreEqual("0, 9, N", rover.CurrentPosition);

			rover.Move("F");
			Assert.AreEqual("0, 0, N", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_Rover_Is_Facing_East_At_9_0_And_Given_The_Command_F_On_A_10_By_10_Grid_The_Position_Should_Be_0_0_E()
		{
			var rover = new MarsRover(new Mars());

			rover.Move("R");
			rover.Move("FFFFFFFFF");
			Assert.AreEqual("9, 0, E", rover.CurrentPosition);

			rover.Move("F");
			Assert.AreEqual("0, 0, E", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_New_Rover_Is_Facing_South_And_Given_The_Command_F_On_A_10_By_10_Grid_The_Position_Should_Be_0_9_S()
		{
			var rover = new MarsRover(new Mars());

			rover.Move("R");
			rover.Move("R");
			Assert.AreEqual("0, 0, S", rover.CurrentPosition);

			rover.Move("F");
			Assert.AreEqual("0, 9, S", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_New_Rover_Is_Facing_West_And_Given_The_Command_F_On_A_10_By_10_Grid_The_Position_Should_Be_9_0_W()
		{
			var rover = new MarsRover(new Mars());

			rover.Move("L");
			Assert.AreEqual("0, 0, W", rover.CurrentPosition);

			rover.Move("F");
			Assert.AreEqual("9, 0, W", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_New_Rover_Is_Facing_North_And_Given_The_Command_B_On_A_10_By_10_Grid_The_Position_Should_Be_0_9_N()
		{
			var rover = new MarsRover(new Mars());
			Assert.AreEqual("0, 0, N", rover.CurrentPosition);

			rover.Move("B");
			Assert.AreEqual("0, 9, N", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_New_Rover_Is_Facing_East_And_Given_The_Command_B_On_A_10_By_10_Grid_The_Position_Should_Be_9_0_E()
		{
			var rover = new MarsRover(new Mars());

			rover.Move("R");
			Assert.AreEqual("0, 0, E", rover.CurrentPosition);

			rover.Move("B");
			Assert.AreEqual("9, 0, E", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_Rover_Is_Facing_South_At_0_9_And_Given_The_Command_B_On_A_10_By_10_Grid_The_Position_Should_Be_0_0_S()
		{
			var rover = new MarsRover(new Mars());

			rover.Move("RR");
			rover.Move("BBBBBBBBB");
			Assert.AreEqual("0, 9, S", rover.CurrentPosition);

			rover.Move("B");
			Assert.AreEqual("0, 0, S", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_Rover_Is_Facing_West_At_9_0_And_Given_The_Command_B_On_A_10_By_10_Grid_The_Position_Should_Be_0_0_W()
		{
			var rover = new MarsRover(new Mars());

			rover.Move("L");
			rover.Move("BBBBBBBBB");
			Assert.AreEqual("9, 0, W", rover.CurrentPosition);

			rover.Move("B");
			Assert.AreEqual("0, 0, W", rover.CurrentPosition);
		}
	}
}
