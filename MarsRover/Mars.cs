﻿using System;

namespace MarsRover
{
	public class Mars : IPlanet
	{
		public int GridWidth { get; private set; }
		public int GridHeight { get; private set; }
		public Obstacle[] Obstacles { get; private set; }

		public Mars()
		{
			GridWidth = 10;
			GridHeight = 10;

			Obstacles = new Obstacle[0];
		}
	}
}
