using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTests
{
	[TestClass]
	public class AtomicCommandUnitTests
	{
		[TestMethod]
		public void When_A_New_Rover_Is_Created_The_Position_Should_Be_0_0_N()
		{
			var rover = new MarsRover(new Mars());

			Assert.AreEqual("0, 0, N", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_New_Rover_Is_Given_The_Command_F_The_Position_Should_Be_0_1_N()
		{
			var rover = new MarsRover(new Mars());

			rover.Move("F");

			Assert.AreEqual("0, 1, N", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_New_Rover_Is_Given_The_Command_R_The_Position_Should_Be_0_0_E()
		{
			var rover = new MarsRover(new Mars());

			rover.Move("R");

			Assert.AreEqual("0, 0, E", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_New_Rover_Is_Given_The_Command_L_The_Position_Should_Be_0_0_W()
		{
			var rover = new MarsRover(new Mars());

			rover.Move("L");

			Assert.AreEqual("0, 0, W", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_New_Rover_Is_Given_The_Command_L_Four_Times_The_Position_Should_Be_0_0_N()
		{
			var rover = new MarsRover(new Mars());

			rover.Move("L");
			Assert.AreEqual("0, 0, W", rover.CurrentPosition);

			rover.Move("L");
			Assert.AreEqual("0, 0, S", rover.CurrentPosition);

			rover.Move("L");
			Assert.AreEqual("0, 0, E", rover.CurrentPosition);

			rover.Move("L");
			Assert.AreEqual("0, 0, N", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_New_Rover_Is_Given_The_Command_R_Four_Times_The_Position_Should_Be_0_0_N()
		{
			var rover = new MarsRover(new Mars());

			rover.Move("R");
			Assert.AreEqual("0, 0, E", rover.CurrentPosition);

			rover.Move("R");
			Assert.AreEqual("0, 0, S", rover.CurrentPosition);

			rover.Move("R");
			Assert.AreEqual("0, 0, W", rover.CurrentPosition);

			rover.Move("R");
			Assert.AreEqual("0, 0, N", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_Rover_Is_Facing_North_And_Given_The_Command_F_The_Position_Should_Be_0_1_N()
		{
			var rover = new MarsRover(new Mars());

			Assert.AreEqual("0, 0, N", rover.CurrentPosition);

			rover.Move("F");
			Assert.AreEqual("0, 1, N", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_Rover_Is_Facing_East_And_Given_The_Command_F_The_Position_Should_Be_1_0_E()
		{
			var rover = new MarsRover(new Mars());

			rover.Move("R");
			Assert.AreEqual("0, 0, E", rover.CurrentPosition);

			rover.Move("F");
			Assert.AreEqual("1, 0, E", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_Rover_Is_Facing_South_And_Given_The_Command_B_The_Position_Should_Be_0_1_S()
		{
			var rover = new MarsRover(new Mars());

			rover.Move("R");
			rover.Move("R");
			Assert.AreEqual("0, 0, S", rover.CurrentPosition);

			rover.Move("B");
			Assert.AreEqual("0, 1, S", rover.CurrentPosition);
		}

		[TestMethod]
		public void When_A_Rover_Is_Facing_West_And_Given_The_Command_B_The_Position_Should_Be_1_0_E()
		{
			var rover = new MarsRover(new Mars());

			rover.Move("L");
			Assert.AreEqual("0, 0, W", rover.CurrentPosition);

			rover.Move("B");
			Assert.AreEqual("1, 0, W", rover.CurrentPosition);
		}
	}
}
