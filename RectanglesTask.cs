namespace Rectangles
{
	public static class RectanglesTask
	{
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
            return (r1.Top <= r2.Bottom) && (r1.Left <= r2.Right) && (r1.Bottom >= r2.Top) && (r1.Right >= r2.Left); 
        }

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
            if (AreIntersected(r1, r2))
            {
                int left = System.Math.Max(r1.Left, r2.Left);
                int right = System.Math.Min(r1.Right, r2.Right);
                int top = System.Math.Max(r1.Top, r2.Top);
                int bottom = System.Math.Min(r1.Bottom, r2.Bottom);
                return (right - left) * (bottom - top);
            }
			return 0;
		}

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
            if ((r1.Left <= r2.Left) && (r1.Right >= r2.Right) &&
                (r1.Top <= r2.Top) && (r1.Bottom >= r2.Bottom)) return 1;
            if ((r2.Left <= r1.Left) && (r2.Right >= r1.Right) && 
                (r2.Top <= r1.Top) && (r2.Bottom >= r1.Bottom)) return 0;
			return -1;
		}
	}
}