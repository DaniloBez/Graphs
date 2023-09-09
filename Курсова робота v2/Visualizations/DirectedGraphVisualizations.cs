using System;
using System.Drawing;

namespace Випускна_робота.Visualizations
{
    class DirectedGraphVisualization : UndirectedGraphVisualization
    {
        protected override void DrawLines(int[,] adjacencyMatrix)
        {
            Pen arrowPen = new Pen(Color.Red, 1); // Колір та товщина стрілок
            int radius = 15; // Радіус вершини

            for (int from = 0; from < numberOfVertices; from++)
            {
                for (int to = 0; to < numberOfVertices; to++)
                {
                    if (adjacencyMatrix[from, to] == 1) // Якщо існує зв'язок від вершини from до вершини to
                    {
                        // Координати центра вершини
                        Point centerFrom = new Point(coordinaties[from].X + radius, coordinaties[from].Y + radius);

                        // Координати кінця стрілки (вершини to)
                        Point endPoint = new Point(coordinaties[to].X + radius, coordinaties[to].Y + radius);

                        // Визначаємо напрямок та розмір стрілки
                        float angle = (float)(Math.Atan2(endPoint.Y - centerFrom.Y, endPoint.X - centerFrom.X) * 180 / Math.PI);
                        float arrowSize = 10;

                        // Визначаємо координати вершини стрілки
                        PointF arrowEnd = new PointF(endPoint.X - radius * (float)Math.Cos(angle * Math.PI / 180),
                                                     endPoint.Y - radius * (float)Math.Sin(angle * Math.PI / 180));

                        // Визначаємо координати вершин кончика стрілки
                        PointF arrowStart1 = new PointF(arrowEnd.X - arrowSize * (float)Math.Cos((angle + 30) * Math.PI / 180),
                                                       arrowEnd.Y - arrowSize * (float)Math.Sin((angle + 30) * Math.PI / 180));

                        PointF arrowStart2 = new PointF(arrowEnd.X - arrowSize * (float)Math.Cos((angle - 30) * Math.PI / 180),
                                                       arrowEnd.Y - arrowSize * (float)Math.Sin((angle - 30) * Math.PI / 180));

                        // Малюємо стрілку
                        graphics.DrawLine(arrowPen, centerFrom, arrowEnd);

                        // Малюємо конус стрілки (треугольник)
                        PointF[] arrowPoints = { arrowEnd, arrowStart1, arrowStart2 };
                        graphics.FillPolygon(Brushes.Red, arrowPoints);
                    }
                }
            }
        }
    }
}
