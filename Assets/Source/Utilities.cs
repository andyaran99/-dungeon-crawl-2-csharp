using System;

namespace DungeonCrawl
{
    public enum Direction : byte
    {
        Up,
        Down,
        Left,
        Right
    }

    public static class Utilities
    {
        public static (int x, int y) ToVector(this Direction dir)
        {
            switch (dir)
            {
                case Direction.Up:
                    return (0, 1);
                case Direction.Down:
                    return (0, -1);
                case Direction.Left:
                    return (-1, 0);
                case Direction.Right:
                    return (1, 0);
                default:
                    throw new ArgumentOutOfRangeException(nameof(dir), dir, null);
            }
        }

        public static int PickRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public static Direction PickDirection()
        {
            var faceDirection = Direction.Up;
            var direction = faceDirection;
            
            if ((int)direction == 3)
            {
                faceDirection = Direction.Up;
                return faceDirection;
            }
            else
            {
                faceDirection = (Direction)((int)direction + 1);
                return faceDirection;
            }
        }
    }
}
