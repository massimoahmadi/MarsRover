﻿using System;
using System.Linq;

namespace MarsRover
{
	public class MarsRover
	{
		// Could use properties if public access required.
		private int _x;
		private int _y;
		private Direction _direction;
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
			switch (_direction)
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
			switch (_direction)
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
			_direction = _direction == Direction.W ? Direction.N : _direction + 1;
		}

		private void TurnLeft()
		{
			_direction = _direction == Direction.N ? Direction.W : _direction - 1;
		}

		private void IncrementY()
		{
			var newY = _y == (planet.GridHeight - 1) ? 0 : _y + 1;

			if (planet.Obstacles.Any(o => o.X == _x & o.Y == newY))
			{
				throw new ObstacleDetectedException(string.Format("{0}, {1}", _x, newY), CurrentPosition);
			}

			_y = newY;
		}

		private void IncrementX()
		{
			var newX = _x == (planet.GridWidth - 1) ? 0 : _x + 1;

			if (planet.Obstacles.Any(o => o.X == newX & o.Y == _y))
			{
				throw new ObstacleDetectedException(string.Format("{0}, {1}", newX, _y), CurrentPosition);
			}

			_x = newX;
		}

		private void DecrementY()
		{
			var newY = _y == 0 ? (planet.GridHeight - 1) : _y - 1;

			if (planet.Obstacles.Any(o => o.X == _x & o.Y == newY))
			{
				throw new ObstacleDetectedException(string.Format("{0}, {1}", _x, newY), CurrentPosition);
			}

			_y = newY;
		}

		private void DecrementX()
		{
			var newX = _x == 0 ? (planet.GridWidth - 1) : _x - 1;

			if (planet.Obstacles.Any(o => o.X == newX & o.Y == _y))
			{
				throw new ObstacleDetectedException(string.Format("{0}, {1}", newX, _y), CurrentPosition);
			}

			_x = newX;
		}

		public string CurrentPosition
		{
			get
			{
				{
					return string.Format("{0}, {1}, {2}", _x, _y, _direction);
				}
			}
		}
	}
}