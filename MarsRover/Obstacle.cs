namespace MarsRover
{
	public struct Obstacle
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Obstacle(int x, int y) : this()
		{
			X = x;
			Y = y;
		}
	}
}
