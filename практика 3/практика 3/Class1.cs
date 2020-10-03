using System;
using System.Drawing;
public abstract class Hill
{
	protected int x, y, r;
	public Hill(int X, int Y, int R)
	{
		x = X; y = Y; r = R;
	}
	public int height
	{ 
		get ; set ; 
	}
    public int width
	{
		get ; set ;
	}
	abstract public void DrawFigure(Graphics graf);
}
public class Square:Hill
{
	SolidBrush br = new SolidBrush(Color.Gray);
	public Square(int x, int y, int r) : base(x, y, r)
	{ }
    public override void DrawFigure(Graphics graf)
    {
		graf.FillRectangle(br, x, y, r * 2, r * 2);
    }
}
public class Circle : Hill
{
	SolidBrush br = new SolidBrush(Color.Gray);
	public Circle(int x, int y, int r) : base(x, y, r)
	{ }
	public override void DrawFigure(Graphics graf)
	{
		graf.FillEllipse(br, x, y, r * 2, r * 2);
	}
}
public class Triangle : Hill
{
	SolidBrush br = new SolidBrush(Color.Gray);
	public Triangle(int x, int y, int r) : base(x, y, r)
	{ }
	public override void DrawFigure(Graphics graf)
	{
		graf.FillEllipse(br, x, y, r * 2, r * 2);
	}
}
