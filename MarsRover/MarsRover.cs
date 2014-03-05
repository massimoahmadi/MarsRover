using System;
using System.Linq;

namespace MarsRover
{
	public class MarsRover
	{
		// Could use properties if public access required.
		private int currentX;
		private int currentY;
		private Direction direction;
		private readonly IPlanet planet;

		public MarsRover(IPlanet planet)
		{
			this.planet = planet;
		}

		public void Move(string commands)
		{
			foreach (var command in commands.ToCharArray())
			{
				switch (command)
				{
					case 'F':
						MoveForward();
						break;
					case 'B':
						MoveBackward();
						break;
					case 'R':
						TurnRight();
						break;
					case 'L':
						TurnLeft();
						break;
				}
			}
		}

		private void MoveForward()
		{
			switch (direction)
			{
				case Direction.N:
					IncrementY();
					break;
				case Direction.E:
					IncrementX();
					break;
				case Direction.S:
					DecrementY();
					break;
				case Direction.W:
					DecrementX();
					break;
			}
		}

		private void MoveBackward()
		{
			switch (direction)
			{
				case Direction.N:
					DecrementY();
					break;
				case Direction.E:
					DecrementX();
					break;
				case Direction.S:
					IncrementY();
					break;
				case Direction.W:
					IncrementX();
					break;
			}
		}

		private void TurnRight()
		{
			direction = direction == Direction.W ? Direction.N : direction + 1;
		}

		private void TurnLeft()
		{
			direction = direction == Direction.N ? Direction.W : direction - 1;
		}

		private void IncrementY()
		{
			var newY = currentY == (planet.GridHeight - 1) ? 0 : currentY + 1;

			if (planet.Obstacles.Any(o => o.X == currentX & o.Y == newY))
			{
				throw new ObstacleDetectedException(string.Format("{0}, {1}", currentX, newY), CurrentPosition);
			}

			currentY = newY;
		}

		private void IncrementX()
		{
			var newX = currentX == (planet.GridWidth - 1) ? 0 : currentX + 1;

			if (planet.Obstacles.Any(o => o.X == newX & o.Y == currentY))
			{
				throw new ObstacleDetectedException(string.Format("{0}, {1}", newX, currentY), CurrentPosition);
			}

			currentX = newX;
		}

		private void DecrementY()
		{
			var newY = currentY == 0 ? (planet.GridHeight - 1) : currentY - 1;

			if (planet.Obstacles.Any(o => o.X == currentX & o.Y == newY))
			{
				throw new ObstacleDetectedException(string.Format("{0}, {1}", currentX, newY), CurrentPosition);
			}

			currentY = newY;
		}

		private void DecrementX()
		{
			var newX = currentX == 0 ? (planet.GridWidth - 1) : currentX - 1;

			if (planet.Obstacles.Any(o => o.X == newX & o.Y == currentY))
			{
				throw new ObstacleDetectedException(string.Format("{0}, {1}", newX, currentY), CurrentPosition);
			}

			currentX = newX;
		}

		public string CurrentPosition
		{
			get
			{
				{
					return string.Format("{0}, {1}, {2}", currentX, currentY, direction);
				}
			}
		}
	}
}