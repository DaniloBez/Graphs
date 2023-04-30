using System;
using System.Drawing;
using System.Windows.Forms;

namespace Курсова_робота
{
    internal class Visualization
    {
        Bitmap bitmap;
        Graphics graphics;
        Point[] coordinaties;


        public void StartVisualization(int numberOfVertices, int[,] adjacencyMatrix, PictureBox pictureBox)
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
            coordinaties = new Point[numberOfVertices];
            FindingСoordinates(numberOfVertices);
            DrawLines(numberOfVertices, adjacencyMatrix);
            DrawVertices(numberOfVertices);
            pictureBox.Image = bitmap;
        }


        public void FindingСoordinates(int numberOfVertices)
        {
            int angle = 0, radius = 155, coefficient = Convert.ToInt32(360 / numberOfVertices);
            for (int i = 0; i < numberOfVertices; i++)
            {
                coordinaties[i].X = radius + Convert.ToInt32(radius * Math.Cos(Radians(angle)));
                coordinaties[i].Y = radius + Convert.ToInt32(radius * Math.Sin(Radians(angle)));
                angle += coefficient;
            }
        }

        public void DrawVertices(int numberOfVertices)
        {
            Font drawFont = new Font("Arial", 14);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            for (int i = 0; i < numberOfVertices; i++)
            {
                graphics.FillEllipse(Brushes.White, coordinaties[i].X, coordinaties[i].Y, 30, 30);
                graphics.DrawEllipse(Pens.Black, coordinaties[i].X, coordinaties[i].Y, 30, 30);
                graphics.DrawString(i.ToString(), drawFont, drawBrush, coordinaties[i].X + 2, coordinaties[i].Y + 4);
            }
        }

        double Radians(int angle) => Math.PI / 180 * angle;

        void DrawLines(int numberOfVertices, int[,] adjacencyMatrix)
        {
            for (int i = 1; i < numberOfVertices; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (adjacencyMatrix[i, j] == 1)
                        graphics.DrawLine(Pens.Red, coordinaties[i].X + 15, coordinaties[i].Y + 15, coordinaties[j].X + 15, coordinaties[j].Y + 15);
                }
            }
        }
    }
}
