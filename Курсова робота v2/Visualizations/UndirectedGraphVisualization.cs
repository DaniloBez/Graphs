using System;
using System.Drawing;

namespace Випускна_робота.Visualizations
{
    internal class UndirectedGraphVisualization : IVizualization
    {
        protected Bitmap bitmap;  // змінна для збереження зображення
        protected Graphics graphics;  // об'єкт для малювання
        protected Point[] coordinaties;  // масив точок, що визначають координати вершин
        protected int numberOfVertices;

        // Метод для початку візуалізації
        public Image DrawGraph(int[,] adjacencyMatrix, int Width, int Height)
        {
            numberOfVertices = (int)Math.Sqrt(adjacencyMatrix.Length);
            bitmap = new Bitmap(Width, Height);  // створення бітмапу з розмірами віджету
            graphics = Graphics.FromImage(bitmap);  // отримання графічного контексту зображення
            coordinaties = new Point[numberOfVertices];  // створення масиву точок з координатами вершин

            FindingСoordinates();  // отримання координат вершин
            DrawLines(adjacencyMatrix);  // малювання ребер
            DrawVertices();  // малювання вершин

            return bitmap;  // відображення зображення в віджеті
        }

        // Метод для знаходження координат вершин
        protected void FindingСoordinates()
        {
            int angle = 0, radius = 155, coefficient = Convert.ToInt32(360 / numberOfVertices);

            // Обходження всіх вершин
            for (int i = 0; i < numberOfVertices; i++)
            {
                coordinaties[i].X = radius + Convert.ToInt32(radius * Math.Cos(Radians(angle)));  // обчислення координати X
                coordinaties[i].Y = radius + Convert.ToInt32(radius * Math.Sin(Radians(angle)));  // обчислення координати Y
                angle += coefficient;  // збільшення кута
            }
        }

        // Метод для малювання вершин
        protected void DrawVertices()
        {
            Font drawFont = new Font("Arial", 14);  // шрифт тексту
            SolidBrush drawBrush = new SolidBrush(Color.Black);  // кисть для малювання

            int textOffsetX = 6;  // зміщення по X для номеру вершини
            int textOffsetY = 5;  // зміщення по Y для номеру вершини

            // Обходження всіх вершин
            for (int i = 0; i < numberOfVertices; i++)
            {
                if (i == 10)
                    textOffsetX = 2;

                int textX = coordinaties[i].X + textOffsetX;
                int textY = coordinaties[i].Y + textOffsetY;

                graphics.FillEllipse(Brushes.White, coordinaties[i].X, coordinaties[i].Y, 30, 30);  // малювання заповненого кола
                graphics.DrawEllipse(Pens.Black, coordinaties[i].X, coordinaties[i].Y, 30, 30);  // малювання контуру кола
                graphics.DrawString(i.ToString(), drawFont, drawBrush, textX, textY);  // малювання номеру вершини
            }
        }

        // Метод для перетворення градусів в радіани
        protected double Radians(int angle) => Math.PI / 180 * angle;

        //Метод для малюваня ребр графа
        protected virtual void DrawLines(int[,] adjacencyMatrix)
        {
            // Перебираємо усі пари вершин
            for (int i = 1; i < numberOfVertices; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (adjacencyMatrix[i, j] == 1) // З'єднуємо, якщо є зв'язок
                        graphics.DrawLine(Pens.Red, coordinaties[i].X + 15, coordinaties[i].Y + 15, coordinaties[j].X + 15, coordinaties[j].Y + 15);
                }
            }
        }
    }
}
