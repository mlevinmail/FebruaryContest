using System;

namespace FebruaryContestEntry
{
	class Program
	{
		const char block = '▓';
		public struct Shape
		{
			public char Block;
			public int Width;
			public int Height;
			public int BorderWidth;
			public ConsoleColor BorderColor;
			public ConsoleColor Color;
		}

		static void DrawShape(Shape shape)
		{
			for (int h = 0; h < shape.Height  + (shape.BorderWidth * 2); h++)
			{
				for (int w = 0; w < shape.Width + (shape.BorderWidth * 2); w++)
				{
					if (w < shape.BorderWidth || w > shape.Width || h < shape.BorderWidth || h > shape.Height)
					{
						Console.ForegroundColor = shape.BorderColor;
					}
					else
					{
						Console.ForegroundColor = shape.Color;
					}
					Console.Write(shape.Block);
				}
				Console.WriteLine();
			}
		}
		
		static void Main(string[] args)
		{
			// The solution implementation goes here

			var shape = new Shape()
			{
				Block = block,
				Width = 30,
				Height = 15,
				BorderWidth = 1,
				BorderColor = ConsoleColor.Green,
				Color = ConsoleColor.Yellow
			};

			DrawShape(shape);

			Console.ResetColor();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Yay, a colorful shape!");
			Console.ReadLine();
		}
	}
}
