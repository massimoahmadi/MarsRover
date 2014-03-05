using System;

namespace MarsRover
{
	public class MarsWithObstacles : IPlanet
	{
		public int GridWidth { get; private set; }
		public int GridHeight { get; private set; }
		public Obstacle[] Obstacles { get; private set; }

		public MarsWithObstacles(Obstacle[] obstacles)
		{
			GridWidth = 10;
			GridHeight = 10;

			Obstacles = obstacles;
		}
	}
}
