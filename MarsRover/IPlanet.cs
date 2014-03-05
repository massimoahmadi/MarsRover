using System;

namespace MarsRover
{
	public interface IPlanet
	{
		int GridWidth { get; }
		int GridHeight { get; }

		Obstacle[] Obstacles { get; }
	}
}
