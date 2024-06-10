using System;
using System.Drawing;
using System.Collections.Generic;

namespace Figures
{
    public sealed class FigureBuilder
    {
        public Color color;

        private Queue<Point> _points = new Queue<Point>();
        private Graphics _graphics;
        private Bitmap _bitmap;

        public FigureBuilder(Graphics graphics, Size size, Color newColor)
        {
            _graphics = graphics;
            _bitmap = new Bitmap(size.Width, size.Height);
            color = newColor;
        }

        public void AddPoint(Point point) => _points.Enqueue(point);
        public void ClearPoints() => _points.Clear();
        
        public void Draw(DrawingModes mode)
        {
            if (_points.Count < 2)
                return;

            Point point1 = _points.Dequeue(),
                point2 = _points.Dequeue();

            switch (mode)
            {
                case DrawingModes.Line:
                    DrawLine(point1, point2);
                    break;
                case DrawingModes.Pentagon:
                    DrawPentagon(point1, point2);
                    break;
                case DrawingModes.Ellipse:
                    DrawEllipse(point1, point2);
                    break;
            }

            UpdateBitmap();
        }

        private void DrawLine(Point point1, Point point2)
        {
            float difX = point2.X - point1.X,
                difY = point2.Y - point1.Y;

            if (difX == 0 && difY == 0)
                return;

            int dx = (int)Math.Abs(difX),
                dy = (int)Math.Abs(difY),

                d = 2 * dy - dx,
                
                xStep = Math.Sign(difX),
                yStep = Math.Sign(difY);
           
            if(Math.Abs(difX) >= Math.Abs(difY))
            {
                while (point1.X != point2.X)
                {
                    DrawPoint(point1);
                    if(d >= 0)
                    {
                        d += 2*(dy-dx);
                        point1.Y += yStep;
                    }
                    else
                    {
                        d += 2*dy;
                    }

                    point1.X += xStep;
                }
            }
            else
            {
                while (point1.Y != point2.Y)
                {
                    DrawPoint(point1);
                    if (d >= 0)
                    {
                        d += 2*(dx-dy);
                        point1.X += xStep;
                    }
                    else
                    {
                        d += 2*dx;
                    }

                    point1.Y += yStep;
                }
            }
        }
        private void DrawEllipse(Point center, Point diagonal)
        {
            int a = Math.Abs(diagonal.X - center.X),
                b = Math.Abs(diagonal.Y - center.Y),
                
                x = 0,
                y = b,
                
                p = 4*b*b + a*a - 4*a*a*b;

            void DrawPoints()
            {
                DrawPoint(new Point(center.X + x, center.Y + y));
                DrawPoint(new Point(center.X - x, center.Y + y));
                DrawPoint(new Point(center.X + x, center.Y - y));
                DrawPoint(new Point(center.X - x, center.Y - y));
            }

            while (x*b*b < y*a*a)
            {
                DrawPoints();

                int prevY = y;

                if (p >= 0)
                    y--;

                p += b*b + 2*(x + 1)*b*b + a*a*(y*y - prevY*prevY) - a*a*(y - prevY); 
                x++;
            }

            while(y >= 0)
            {
                DrawPoints();

                int prevX = x;
                
                if (p < 0)
                    x++;

                p += a*a - 2*(y - 1)*a*a + b*b*( x*x - prevX*prevX) + b*b*(x - prevX);
                y--;
            }
        }
        private void DrawPentagon(Point center, Point diagonal)
        {
            List<Point> points = new List<Point>(5);
            double angle = 72;
            int sides = 5;

            int difX = diagonal.X - center.X,
                difY = diagonal.Y - center.Y;

            int size = (int)Math.Sqrt(difX*difX + difY*difY);

            float tg = (float)difY / difX,
                offset = (float)(Math.Atan(tg)*180/Math.PI);

            for (int i = 0; i < sides; i++)
            {
                double rad = Math.PI / 180 * (i * angle + offset);
                int x = (int)(center.X + size * Math.Cos(rad));
                int y = (int)(center.Y + size * Math.Sin(rad));
   
                points.Add(new Point(x, y));
            }

            for (int i = 0; i < sides; i++)
            {
                DrawLine(points[i], points[(i + 1) % 5]);
            }
        }

        public void FillFigure()
        {
            if (_points.Count < 1)
                return;

            Point center = _points.Dequeue();

            Stack<Point> stack = new Stack<Point>();
            stack.Push(center);
            
            while (stack.Count > 0)
            {
                Point p = stack.Pop();
                if (p.X > 0 && p.X < _bitmap.Width && p.Y > 0 && p.Y < _bitmap.Height)
                {
                    Color readColor = _bitmap.GetPixel(p.X, p.Y);

                    if (readColor.ToArgb() != color.ToArgb())
                    {
                        DrawPoint(p);

                        stack.Push(new Point(p.X + 1, p.Y));
                        stack.Push(new Point(p.X - 1, p.Y));
                        stack.Push(new Point(p.X, p.Y + 1));
                        stack.Push(new Point(p.X, p.Y - 1));
                    }
                }
            }
            UpdateBitmap();
        }

        private void DrawPoint(Point point)
        {
            int x = point.X,
                y = point.Y;

            if (x > 0 && x < _bitmap.Width && y > 0 && y < _bitmap.Height)
                _bitmap.SetPixel(point.X, point.Y, color);
        }

        public void ClearFigure(Color color)
        {
            for(int i = 0; i < _bitmap.Width; i++)
                for (int j = 0; j < _bitmap.Height; j++)
                    _bitmap.SetPixel(i, j, color);

            UpdateBitmap();
        }
        private void UpdateBitmap() => _graphics.DrawImage(_bitmap, new Point(0, 0));
    }
}