using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTests
{
	[TestClass]
	public class MoveBackwardObstacleUnitTests
	{
		[TestMethod]
		[ExpectedException(typeof(ObstacleDetectedException))]
		public void When_A_New_Rover_Is_Given_The_Command_B_And_An_Obstacle_Is_At_0_9_An_Exception_Should_Be_Thrown()
		{
			var rover = new MarsRover(new MarsWithObstacles(new[]
				{
					new Obstacle(0, 9) // Obstacle at (0, 9)
				}));

			Assert.AreEqual("0, 0, N", rover.CurrentPosition);

			rover.Move("B");
		}

		[TestMethod]
		public void When_A_New_Rover_Is_Given_The_Command_B_And_An_Obstacle_Is_At_0_9_The_Rover_Should_Stay_At_0_0()
		{
			var rover = new MarsRover(new MarsWithObstacles(new[]
				{
					new Obstacle(0, 9) // Obstacle at (0, 9)
				}));

			Assert.AreEqual("0, 0, N", rover.CurrentPosition);

			try
			{
				rover.Move("B");
			}
			catch (ObstacleDetectedException)
			{
				
			}
			finally
			{
				Assert.AreEqual("0, 0, N", rover.CurrentPosition);
			}
		}

		[TestMethod]
		[ExpectedException(typeof(ObstacleDetectedException))]
		public void When_A_Rover_Facing_East_At_0_0_Is_Given_The_Command_B_And_An_Obstacle_Is_At_9_0_An_Exception_Should_Be_Thrown()
		{
			var rover = new MarsRover(new MarsWithObstacles(new[]
				{
					new Obstacle(9, 0) // Obstacle at (9, 0)
				}));

			rover.Move("R");
			Assert.AreEqual("0, 0, E", rover.CurrentPosition);

			rover.Move("B");
		}

		[TestMethod]
		public void When_A_Rover_Facing_East_At_0_0_Is_Given_The_Command_B_And_An_Obstacle_Is_At_9_0_The_Rover_Should_Stay_At_0_0()
		{
			var rover = new MarsRover(new MarsWithObstacles(new[]
				{
					new Obstacle(9, 0) // Obstacle at (9, 0)
				}));

			rover.Move("R");
			Assert.AreEqual("0, 0, E", rover.CurrentPosition);

			try
			{
				rover.Move("B");
			}
			catch (ObstacleDetectedException)
			{

			}
			finally
			{
				Assert.AreEqual("0, 0, E", rover.CurrentPosition);
			}
		}

		[TestMethod]
		[ExpectedException(typeof(ObstacleDetectedException))]
		public void When_A_Rover_Facing_South_At_0_0_Is_Given_The_Command_B_And_An_Obstacle_Is_At_0_1_An_Exception_Should_Be_Thrown()
		{
			var rover = new MarsRover(new MarsWithObstacles(new[]
				{
					new Obstacle(0, 1) // Obstacle at (0, 1)
				}));

			rover.Move("RR");
			Assert.AreEqual("0, 0, S", rover.CurrentPosition);

			rover.Move("B");
		}

		[TestMethod]
		public void When_A_Rover_Facing_South_At_0_0_Is_Given_The_Command_B_And_An_Obstacle_Is_At_0_1_The_Rover_Should_Stay_At_0_0()
		{
			var rover = new MarsRover(new MarsWithObstacles(new[]
				{
					new Obstacle(0, 1) // Obstacle at (0, 1)
				}));

			rover.Move("RR");
			Assert.AreEqual("0, 0, S", rover.CurrentPosition);

			try
			{
				rover.Move("B");
			}
			catch (ObstacleDetectedException)
			{

			}
			finally
			{
				Assert.AreEqual("0, 0, S", rover.CurrentPosition);
			}
		}

		[TestMethod]
		[ExpectedException(typeof(ObstacleDetectedException))]
		public void When_A_Rover_Facing_West_At_0_0_Is_Given_The_Command_B_And_An_Obstacle_Is_At_1_0_An_Exception_Should_Be_Thrown()
		{
			var rover = new MarsRover(new MarsWithObstacles(new[]
				{
					new Obstacle(1, 0) // Obstacle at (1, 0)
				}));

			rover.Move("L");
			Assert.AreEqual("0, 0, W", rover.CurrentPosition);

			rover.Move("B");
		}

		[TestMethod]
		public void When_A_Rover_Facing_West_At_0_0_Is_Given_The_Command_B_And_An_Obstacle_Is_At_1_0_The_Rover_Should_Stay_At_0_0()
		{
			var rover = new MarsRover(new MarsWithObstacles(new[]
				{
					new Obstacle(1, 0) // Obstacle at (1, 0)
				}));

			rover.Move("L");
			Assert.AreEqual("0, 0, W", rover.CurrentPosition);

			try
			{
				rover.Move("B");
			}
			catch (ObstacleDetectedException)
			{

			}
			finally
			{
				Assert.AreEqual("0, 0, W", rover.CurrentPosition);
			}
		}
	}
}
