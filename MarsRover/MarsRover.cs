namespace MarsRover
{
	public class MarsRover
	{
		// Could use properties if public access required.
		private int _x;
		private int _y;
		private Direction _direction;

		public void Move(string command)
		{
			switch (command)
			{
				case "F":
					MoveForward();
					break;
				case "B":
					MoveBackward();
					break;
				case "R":
					TurnRight();
					break;
				case "L":
					TurnLeft();
					break;
			}
		}

		private void MoveForward()
		{
			_y++;
		}

		private void MoveBackward()
		{
			_y--;
		}

		private void TurnRight()
		{
			_direction = _direction == Direction.W ? Direction.N : _direction + 1;
		}

		private void TurnLeft()
		{
			_direction = _direction == Direction.N ? Direction.W : _direction - 1;
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