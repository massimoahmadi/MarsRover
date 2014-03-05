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
			}
		}

		private void MoveForward()
		{
			_y++;
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