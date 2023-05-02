using System;
using System.Drawing;
using System.Windows.Forms;

namespace Курсова_робота
{
    internal class Visualization
    {
        Bitmap bitmap;  // змінна для збереження зображення
        Graphics graphics;  // об'єкт для малювання
        Point[] coordinaties;  // масив точок, що визначають координати вершин

        // Метод для початку візуалізації
        public void StartVisualization(int numberOfVertices, int[,] adjacencyMatrix, PictureBox pictureBox)
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);  // створення бітмапу з розмірами віджету
            graphics = Graphics.FromImage(bitmap);  // отримання графічного контексту зображення
            coordinaties = new Point[numberOfVertices];  // створення масиву точок з координатами вершин

            FindingСoordinates(numberOfVertices);  // отримання координат вершин
            DrawLines(numberOfVertices, adjacencyMatrix);  // малювання ребер
            DrawVertices(numberOfVertices);  // малювання вершин

            pictureBox.Image = bitmap;  // відображення зображення в віджеті
        }

        // Метод для знаходження координат вершин
        private void FindingСoordinates(int numberOfVertices)
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
        private void DrawVertices(int numberOfVertices)
        {
            Font drawFont = new Font("Arial", 14);  // шрифт тексту
            SolidBrush drawBrush = new SolidBrush(Color.Black);  // кисть для малювання

            // Обходження всіх вершин
            for (int i = 0; i < numberOfVertices; i++)
            {
                graphics.FillEllipse(Brushes.White, coordinaties[i].X, coordinaties[i].Y, 30, 30);  // малювання заповненого кола
                graphics.DrawEllipse(Pens.Black, coordinaties[i].X, coordinaties[i].Y, 30, 30);  // малювання контуру кола
                graphics.DrawString(i.ToString(), drawFont, drawBrush, coordinaties[i].X + 2, coordinaties[i].Y + 4);  // малювання номеру вершини
            }
        }

        // Метод для перетворення градусів в радіани
        private double Radians(int angle) => Math.PI / 180 * angle;

        //Метод для малюваня ребр графа
        private void DrawLines(int numberOfVertices, int[,] adjacencyMatrix)
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
