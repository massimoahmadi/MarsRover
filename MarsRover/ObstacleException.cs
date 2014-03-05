using System;

namespace MarsRover
{
	public class ObstacleDetectedException : Exception
	{
		public ObstacleDetectedException(string obstaclePosition, string roverRosition)
			: base(string.Format("An obstacle was detected at {0}. Rover has stopped at {1}.", obstaclePosition, roverRosition))
		{
		}
	}
}
