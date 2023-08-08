namespace Курсова_робота_v2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UndirectedUnweighted = new System.Windows.Forms.TabPage();
            this.ExportCycleToTxtUndirected = new System.Windows.Forms.Button();
            this.ExportGraphToTxtUndirected = new System.Windows.Forms.Button();
            this.ImportGraphUndirectUnweighted = new System.Windows.Forms.Button();
            this.GraphImageUndirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.GraphImageUndirectedUnweightedPB = new System.Windows.Forms.PictureBox();
            this.NumberOfVerticesUndirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.PastGraphImageUndirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.PastGraphImageUndirectedUnweightedPB = new System.Windows.Forms.PictureBox();
            this.NumberOfVerticesUndirectedUnweightedTB = new System.Windows.Forms.TextBox();
            this.VertexNumberUndirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.VertexNumberUndirectedUnweightedTB = new System.Windows.Forms.TextBox();
            this.CyclesUndirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.PastCyclesUndirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.UpdateUndirectedUnweighted = new System.Windows.Forms.Button();
            this.CyclesUndirectedUnweightedLB = new System.Windows.Forms.ListBox();
            this.PastCyclesUndirectedUnweightedLB = new System.Windows.Forms.ListBox();
            this.MainMethodUndirectedUnweighted = new System.Windows.Forms.Button();
            this.AdjacencyMatrixUndirectedUnweightedDGV = new System.Windows.Forms.DataGridView();
            this.AdjacencyMatrixUndirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.CreateCompleteUndirectedUnweighted = new System.Windows.Forms.Button();
            this.TimerUndirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.CreateEmptyUndirectedUnweighted = new System.Windows.Forms.Button();
            this.DirectedUnweighted = new System.Windows.Forms.TabPage();
            this.ImportGraphDirectUnweighted = new System.Windows.Forms.Button();
            this.GraphImageDirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.GraphImageDirectedUnweightedPB = new System.Windows.Forms.PictureBox();
            this.NumberOfVerticesDirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.PastGraphImageDirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.PastGraphImageDirectedUnweightedPB = new System.Windows.Forms.PictureBox();
            this.NumberOfVerticesDirectedUnweightedTB = new System.Windows.Forms.TextBox();
            this.VertexNumberDirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.VertexNumberDirectedUnweightedTB = new System.Windows.Forms.TextBox();
            this.CyclesDirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.PastCyclesDirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.UpdateDirectedUnweighted = new System.Windows.Forms.Button();
            this.CyclesDirectedUnweightedLB = new System.Windows.Forms.ListBox();
            this.PastCyclesDirectedUnweightedLB = new System.Windows.Forms.ListBox();
            this.MainMethodDirectedUnweighted = new System.Windows.Forms.Button();
            this.AdjacencyMatrixDirectedUnweightedDGV = new System.Windows.Forms.DataGridView();
            this.AdjacencyMatrixDirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.CreateCompleteDirectedUnweighted = new System.Windows.Forms.Button();
            this.TimerDirectedUnweightedLbl = new System.Windows.Forms.Label();
            this.CreateEmptyDirectedUnweighted = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.CreateRandomGraphUndirected = new System.Windows.Forms.Button();
            this.CreateRandomGraphDirected = new System.Windows.Forms.Button();
            this.ExportCycleToTxtDirected = new System.Windows.Forms.Button();
            this.ExportGraphToTxtDirected = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.UndirectedUnweighted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphImageUndirectedUnweightedPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PastGraphImageUndirectedUnweightedPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdjacencyMatrixUndirectedUnweightedDGV)).BeginInit();
            this.DirectedUnweighted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphImageDirectedUnweightedPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PastGraphImageDirectedUnweightedPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdjacencyMatrixDirectedUnweightedDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UndirectedUnweighted);
            this.tabControl1.Controls.Add(this.DirectedUnweighted);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1528, 806);
            this.tabControl1.TabIndex = 0;
            // 
            // UndirectedUnweighted
            // 
            this.UndirectedUnweighted.Controls.Add(this.CreateRandomGraphUndirected);
            this.UndirectedUnweighted.Controls.Add(this.ExportCycleToTxtUndirected);
            this.UndirectedUnweighted.Controls.Add(this.ExportGraphToTxtUndirected);
            this.UndirectedUnweighted.Controls.Add(this.ImportGraphUndirectUnweighted);
            this.UndirectedUnweighted.Controls.Add(this.GraphImageUndirectedUnweightedLbl);
            this.UndirectedUnweighted.Controls.Add(this.GraphImageUndirectedUnweightedPB);
            this.UndirectedUnweighted.Controls.Add(this.NumberOfVerticesUndirectedUnweightedLbl);
            this.UndirectedUnweighted.Controls.Add(this.PastGraphImageUndirectedUnweightedLbl);
            this.UndirectedUnweighted.Controls.Add(this.PastGraphImageUndirectedUnweightedPB);
            this.UndirectedUnweighted.Controls.Add(this.NumberOfVerticesUndirectedUnweightedTB);
            this.UndirectedUnweighted.Controls.Add(this.VertexNumberUndirectedUnweightedLbl);
            this.UndirectedUnweighted.Controls.Add(this.VertexNumberUndirectedUnweightedTB);
            this.UndirectedUnweighted.Controls.Add(this.CyclesUndirectedUnweightedLbl);
            this.UndirectedUnweighted.Controls.Add(this.PastCyclesUndirectedUnweightedLbl);
            this.UndirectedUnweighted.Controls.Add(this.UpdateUndirectedUnweighted);
            this.UndirectedUnweighted.Controls.Add(this.CyclesUndirectedUnweightedLB);
            this.UndirectedUnweighted.Controls.Add(this.PastCyclesUndirectedUnweightedLB);
            this.UndirectedUnweighted.Controls.Add(this.MainMethodUndirectedUnweighted);
            this.UndirectedUnweighted.Controls.Add(this.AdjacencyMatrixUndirectedUnweightedDGV);
            this.UndirectedUnweighted.Controls.Add(this.AdjacencyMatrixUndirectedUnweightedLbl);
            this.UndirectedUnweighted.Controls.Add(this.CreateCompleteUndirectedUnweighted);
            this.UndirectedUnweighted.Controls.Add(this.TimerUndirectedUnweightedLbl);
            this.UndirectedUnweighted.Controls.Add(this.CreateEmptyUndirectedUnweighted);
            this.UndirectedUnweighted.Location = new System.Drawing.Point(4, 34);
            this.UndirectedUnweighted.Name = "UndirectedUnweighted";
            this.UndirectedUnweighted.Padding = new System.Windows.Forms.Padding(3);
            this.UndirectedUnweighted.Size = new System.Drawing.Size(1520, 768);
            this.UndirectedUnweighted.TabIndex = 0;
            this.UndirectedUnweighted.Text = "Неорієнтовний Незважений";
            this.UndirectedUnweighted.UseVisualStyleBackColor = true;
            // 
            // ExportCycleToTxtUndirected
            // 
            this.ExportCycleToTxtUndirected.Location = new System.Drawing.Point(755, 543);
            this.ExportCycleToTxtUndirected.Name = "ExportCycleToTxtUndirected";
            this.ExportCycleToTxtUndirected.Size = new System.Drawing.Size(179, 92);
            this.ExportCycleToTxtUndirected.TabIndex = 69;
            this.ExportCycleToTxtUndirected.Text = "Експортувати цикли до txt файла";
            this.ExportCycleToTxtUndirected.UseVisualStyleBackColor = true;
            this.ExportCycleToTxtUndirected.Click += new System.EventHandler(this.ExportCycleToTxtUndirected_Click);
            // 
            // ExportGraphToTxtUndirected
            // 
            this.ExportGraphToTxtUndirected.Location = new System.Drawing.Point(755, 641);
            this.ExportGraphToTxtUndirected.Name = "ExportGraphToTxtUndirected";
            this.ExportGraphToTxtUndirected.Size = new System.Drawing.Size(179, 92);
            this.ExportGraphToTxtUndirected.TabIndex = 68;
            this.ExportGraphToTxtUndirected.Text = "Експортувати граф до txt файла";
            this.ExportGraphToTxtUndirected.UseVisualStyleBackColor = true;
            this.ExportGraphToTxtUndirected.Click += new System.EventHandler(this.ExportGraphToTxtUndirected_Click);
            // 
            // ImportGraphUndirectUnweighted
            // 
            this.ImportGraphUndirectUnweighted.Location = new System.Drawing.Point(755, 445);
            this.ImportGraphUndirectUnweighted.Name = "ImportGraphUndirectUnweighted";
            this.ImportGraphUndirectUnweighted.Size = new System.Drawing.Size(179, 92);
            this.ImportGraphUndirectUnweighted.TabIndex = 67;
            this.ImportGraphUndirectUnweighted.Text = "Імпортувати граф з txt файла";
            this.ImportGraphUndirectUnweighted.UseVisualStyleBackColor = true;
            this.ImportGraphUndirectUnweighted.Click += new System.EventHandler(this.ImportGraphUndirectUnweighted_Click);
            // 
            // GraphImageUndirectedUnweightedLbl
            // 
            this.GraphImageUndirectedUnweightedLbl.AutoSize = true;
            this.GraphImageUndirectedUnweightedLbl.Location = new System.Drawing.Point(1252, 10);
            this.GraphImageUndirectedUnweightedLbl.Name = "GraphImageUndirectedUnweightedLbl";
            this.GraphImageUndirectedUnweightedLbl.Size = new System.Drawing.Size(191, 25);
            this.GraphImageUndirectedUnweightedLbl.TabIndex = 61;
            this.GraphImageUndirectedUnweightedLbl.Text = "Зображення графу";
            // 
            // GraphImageUndirectedUnweightedPB
            // 
            this.GraphImageUndirectedUnweightedPB.Location = new System.Drawing.Point(1167, 38);
            this.GraphImageUndirectedUnweightedPB.Name = "GraphImageUndirectedUnweightedPB";
            this.GraphImageUndirectedUnweightedPB.Size = new System.Drawing.Size(350, 350);
            this.GraphImageUndirectedUnweightedPB.TabIndex = 60;
            this.GraphImageUndirectedUnweightedPB.TabStop = false;
            // 
            // NumberOfVerticesUndirectedUnweightedLbl
            // 
            this.NumberOfVerticesUndirectedUnweightedLbl.AutoSize = true;
            this.NumberOfVerticesUndirectedUnweightedLbl.Location = new System.Drawing.Point(10, 10);
            this.NumberOfVerticesUndirectedUnweightedLbl.Name = "NumberOfVerticesUndirectedUnweightedLbl";
            this.NumberOfVerticesUndirectedUnweightedLbl.Size = new System.Drawing.Size(171, 25);
            this.NumberOfVerticesUndirectedUnweightedLbl.TabIndex = 49;
            this.NumberOfVerticesUndirectedUnweightedLbl.Text = "Кількість вершин";
            // 
            // PastGraphImageUndirectedUnweightedLbl
            // 
            this.PastGraphImageUndirectedUnweightedLbl.AutoSize = true;
            this.PastGraphImageUndirectedUnweightedLbl.Location = new System.Drawing.Point(1270, 391);
            this.PastGraphImageUndirectedUnweightedLbl.Name = "PastGraphImageUndirectedUnweightedLbl";
            this.PastGraphImageUndirectedUnweightedLbl.Size = new System.Drawing.Size(146, 25);
            this.PastGraphImageUndirectedUnweightedLbl.TabIndex = 64;
            this.PastGraphImageUndirectedUnweightedLbl.Text = "Минулий граф";
            // 
            // PastGraphImageUndirectedUnweightedPB
            // 
            this.PastGraphImageUndirectedUnweightedPB.Location = new System.Drawing.Point(1160, 416);
            this.PastGraphImageUndirectedUnweightedPB.Name = "PastGraphImageUndirectedUnweightedPB";
            this.PastGraphImageUndirectedUnweightedPB.Size = new System.Drawing.Size(350, 350);
            this.PastGraphImageUndirectedUnweightedPB.TabIndex = 62;
            this.PastGraphImageUndirectedUnweightedPB.TabStop = false;
            // 
            // NumberOfVerticesUndirectedUnweightedTB
            // 
            this.NumberOfVerticesUndirectedUnweightedTB.Location = new System.Drawing.Point(43, 38);
            this.NumberOfVerticesUndirectedUnweightedTB.Name = "NumberOfVerticesUndirectedUnweightedTB";
            this.NumberOfVerticesUndirectedUnweightedTB.Size = new System.Drawing.Size(100, 30);
            this.NumberOfVerticesUndirectedUnweightedTB.TabIndex = 51;
            // 
            // VertexNumberUndirectedUnweightedLbl
            // 
            this.VertexNumberUndirectedUnweightedLbl.AutoSize = true;
            this.VertexNumberUndirectedUnweightedLbl.Location = new System.Drawing.Point(234, 10);
            this.VertexNumberUndirectedUnweightedLbl.Name = "VertexNumberUndirectedUnweightedLbl";
            this.VertexNumberUndirectedUnweightedLbl.Size = new System.Drawing.Size(161, 25);
            this.VertexNumberUndirectedUnweightedLbl.TabIndex = 54;
            this.VertexNumberUndirectedUnweightedLbl.Text = "Номер вершини";
            // 
            // VertexNumberUndirectedUnweightedTB
            // 
            this.VertexNumberUndirectedUnweightedTB.Location = new System.Drawing.Point(267, 38);
            this.VertexNumberUndirectedUnweightedTB.Name = "VertexNumberUndirectedUnweightedTB";
            this.VertexNumberUndirectedUnweightedTB.Size = new System.Drawing.Size(100, 30);
            this.VertexNumberUndirectedUnweightedTB.TabIndex = 59;
            // 
            // CyclesUndirectedUnweightedLbl
            // 
            this.CyclesUndirectedUnweightedLbl.AutoSize = true;
            this.CyclesUndirectedUnweightedLbl.Location = new System.Drawing.Point(6, 110);
            this.CyclesUndirectedUnweightedLbl.Name = "CyclesUndirectedUnweightedLbl";
            this.CyclesUndirectedUnweightedLbl.Size = new System.Drawing.Size(318, 25);
            this.CyclesUndirectedUnweightedLbl.TabIndex = 57;
            this.CyclesUndirectedUnweightedLbl.Text = "Цикли, яким належить вершина ";
            // 
            // PastCyclesUndirectedUnweightedLbl
            // 
            this.PastCyclesUndirectedUnweightedLbl.AutoSize = true;
            this.PastCyclesUndirectedUnweightedLbl.Location = new System.Drawing.Point(353, 110);
            this.PastCyclesUndirectedUnweightedLbl.Name = "PastCyclesUndirectedUnweightedLbl";
            this.PastCyclesUndirectedUnweightedLbl.Size = new System.Drawing.Size(136, 25);
            this.PastCyclesUndirectedUnweightedLbl.TabIndex = 65;
            this.PastCyclesUndirectedUnweightedLbl.Text = "Минулі цикли";
            // 
            // UpdateUndirectedUnweighted
            // 
            this.UpdateUndirectedUnweighted.Location = new System.Drawing.Point(385, 641);
            this.UpdateUndirectedUnweighted.Name = "UpdateUndirectedUnweighted";
            this.UpdateUndirectedUnweighted.Size = new System.Drawing.Size(179, 92);
            this.UpdateUndirectedUnweighted.TabIndex = 66;
            this.UpdateUndirectedUnweighted.Text = "Оновити граф";
            this.UpdateUndirectedUnweighted.UseVisualStyleBackColor = true;
            this.UpdateUndirectedUnweighted.Click += new System.EventHandler(this.UpdateUndirectedUnweighted_Click);
            // 
            // CyclesUndirectedUnweightedLB
            // 
            this.CyclesUndirectedUnweightedLB.FormattingEnabled = true;
            this.CyclesUndirectedUnweightedLB.ItemHeight = 25;
            this.CyclesUndirectedUnweightedLB.Location = new System.Drawing.Point(28, 153);
            this.CyclesUndirectedUnweightedLB.Name = "CyclesUndirectedUnweightedLB";
            this.CyclesUndirectedUnweightedLB.Size = new System.Drawing.Size(166, 379);
            this.CyclesUndirectedUnweightedLB.TabIndex = 56;
            // 
            // PastCyclesUndirectedUnweightedLB
            // 
            this.PastCyclesUndirectedUnweightedLB.FormattingEnabled = true;
            this.PastCyclesUndirectedUnweightedLB.ItemHeight = 25;
            this.PastCyclesUndirectedUnweightedLB.Location = new System.Drawing.Point(324, 153);
            this.PastCyclesUndirectedUnweightedLB.Name = "PastCyclesUndirectedUnweightedLB";
            this.PastCyclesUndirectedUnweightedLB.Size = new System.Drawing.Size(165, 379);
            this.PastCyclesUndirectedUnweightedLB.TabIndex = 63;
            // 
            // MainMethodUndirectedUnweighted
            // 
            this.MainMethodUndirectedUnweighted.Location = new System.Drawing.Point(940, 641);
            this.MainMethodUndirectedUnweighted.Name = "MainMethodUndirectedUnweighted";
            this.MainMethodUndirectedUnweighted.Size = new System.Drawing.Size(179, 92);
            this.MainMethodUndirectedUnweighted.TabIndex = 53;
            this.MainMethodUndirectedUnweighted.Text = "Знайти цикли, яким належить вершина";
            this.MainMethodUndirectedUnweighted.UseVisualStyleBackColor = true;
            this.MainMethodUndirectedUnweighted.Click += new System.EventHandler(this.MainMethodUndirectedUnweighted_Click);
            // 
            // AdjacencyMatrixUndirectedUnweightedDGV
            // 
            this.AdjacencyMatrixUndirectedUnweightedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdjacencyMatrixUndirectedUnweightedDGV.Location = new System.Drawing.Point(570, 38);
            this.AdjacencyMatrixUndirectedUnweightedDGV.Name = "AdjacencyMatrixUndirectedUnweightedDGV";
            this.AdjacencyMatrixUndirectedUnweightedDGV.RowHeadersWidth = 51;
            this.AdjacencyMatrixUndirectedUnweightedDGV.RowTemplate.Height = 24;
            this.AdjacencyMatrixUndirectedUnweightedDGV.Size = new System.Drawing.Size(537, 400);
            this.AdjacencyMatrixUndirectedUnweightedDGV.TabIndex = 52;
            // 
            // AdjacencyMatrixUndirectedUnweightedLbl
            // 
            this.AdjacencyMatrixUndirectedUnweightedLbl.AutoSize = true;
            this.AdjacencyMatrixUndirectedUnweightedLbl.Location = new System.Drawing.Point(732, 10);
            this.AdjacencyMatrixUndirectedUnweightedLbl.Name = "AdjacencyMatrixUndirectedUnweightedLbl";
            this.AdjacencyMatrixUndirectedUnweightedLbl.Size = new System.Drawing.Size(205, 25);
            this.AdjacencyMatrixUndirectedUnweightedLbl.TabIndex = 50;
            this.AdjacencyMatrixUndirectedUnweightedLbl.Text = "Матриця суміжності";
            // 
            // CreateCompleteUndirectedUnweighted
            // 
            this.CreateCompleteUndirectedUnweighted.Location = new System.Drawing.Point(200, 641);
            this.CreateCompleteUndirectedUnweighted.Name = "CreateCompleteUndirectedUnweighted";
            this.CreateCompleteUndirectedUnweighted.Size = new System.Drawing.Size(179, 92);
            this.CreateCompleteUndirectedUnweighted.TabIndex = 55;
            this.CreateCompleteUndirectedUnweighted.Text = "Створення повного графу";
            this.CreateCompleteUndirectedUnweighted.UseVisualStyleBackColor = true;
            this.CreateCompleteUndirectedUnweighted.Click += new System.EventHandler(this.CreateCompleteUndirectedUnweighted_Click);
            // 
            // TimerUndirectedUnweightedLbl
            // 
            this.TimerUndirectedUnweightedLbl.AutoSize = true;
            this.TimerUndirectedUnweightedLbl.Location = new System.Drawing.Point(23, 577);
            this.TimerUndirectedUnweightedLbl.Name = "TimerUndirectedUnweightedLbl";
            this.TimerUndirectedUnweightedLbl.Size = new System.Drawing.Size(252, 25);
            this.TimerUndirectedUnweightedLbl.TabIndex = 58;
            this.TimerUndirectedUnweightedLbl.Text = "Час виконання програми: ";
            // 
            // CreateEmptyUndirectedUnweighted
            // 
            this.CreateEmptyUndirectedUnweighted.Location = new System.Drawing.Point(15, 641);
            this.CreateEmptyUndirectedUnweighted.Name = "CreateEmptyUndirectedUnweighted";
            this.CreateEmptyUndirectedUnweighted.Size = new System.Drawing.Size(179, 92);
            this.CreateEmptyUndirectedUnweighted.TabIndex = 48;
            this.CreateEmptyUndirectedUnweighted.Text = "Створення незаповненого графу";
            this.CreateEmptyUndirectedUnweighted.UseVisualStyleBackColor = true;
            this.CreateEmptyUndirectedUnweighted.Click += new System.EventHandler(this.CreateEmptyUndirectedUnweighted_Click);
            // 
            // DirectedUnweighted
            // 
            this.DirectedUnweighted.Controls.Add(this.ExportGraphToTxtDirected);
            this.DirectedUnweighted.Controls.Add(this.ExportCycleToTxtDirected);
            this.DirectedUnweighted.Controls.Add(this.CreateRandomGraphDirected);
            this.DirectedUnweighted.Controls.Add(this.ImportGraphDirectUnweighted);
            this.DirectedUnweighted.Controls.Add(this.GraphImageDirectedUnweightedLbl);
            this.DirectedUnweighted.Controls.Add(this.GraphImageDirectedUnweightedPB);
            this.DirectedUnweighted.Controls.Add(this.NumberOfVerticesDirectedUnweightedLbl);
            this.DirectedUnweighted.Controls.Add(this.PastGraphImageDirectedUnweightedLbl);
            this.DirectedUnweighted.Controls.Add(this.PastGraphImageDirectedUnweightedPB);
            this.DirectedUnweighted.Controls.Add(this.NumberOfVerticesDirectedUnweightedTB);
            this.DirectedUnweighted.Controls.Add(this.VertexNumberDirectedUnweightedLbl);
            this.DirectedUnweighted.Controls.Add(this.VertexNumberDirectedUnweightedTB);
            this.DirectedUnweighted.Controls.Add(this.CyclesDirectedUnweightedLbl);
            this.DirectedUnweighted.Controls.Add(this.PastCyclesDirectedUnweightedLbl);
            this.DirectedUnweighted.Controls.Add(this.UpdateDirectedUnweighted);
            this.DirectedUnweighted.Controls.Add(this.CyclesDirectedUnweightedLB);
            this.DirectedUnweighted.Controls.Add(this.PastCyclesDirectedUnweightedLB);
            this.DirectedUnweighted.Controls.Add(this.MainMethodDirectedUnweighted);
            this.DirectedUnweighted.Controls.Add(this.AdjacencyMatrixDirectedUnweightedDGV);
            this.DirectedUnweighted.Controls.Add(this.AdjacencyMatrixDirectedUnweightedLbl);
            this.DirectedUnweighted.Controls.Add(this.CreateCompleteDirectedUnweighted);
            this.DirectedUnweighted.Controls.Add(this.TimerDirectedUnweightedLbl);
            this.DirectedUnweighted.Controls.Add(this.CreateEmptyDirectedUnweighted);
            this.DirectedUnweighted.Location = new System.Drawing.Point(4, 34);
            this.DirectedUnweighted.Name = "DirectedUnweighted";
            this.DirectedUnweighted.Padding = new System.Windows.Forms.Padding(3);
            this.DirectedUnweighted.Size = new System.Drawing.Size(1520, 768);
            this.DirectedUnweighted.TabIndex = 1;
            this.DirectedUnweighted.Text = "Орієнтовний Незважений";
            this.DirectedUnweighted.UseVisualStyleBackColor = true;
            // 
            // ImportGraphDirectUnweighted
            // 
            this.ImportGraphDirectUnweighted.Location = new System.Drawing.Point(757, 441);
            this.ImportGraphDirectUnweighted.Name = "ImportGraphDirectUnweighted";
            this.ImportGraphDirectUnweighted.Size = new System.Drawing.Size(179, 92);
            this.ImportGraphDirectUnweighted.TabIndex = 86;
            this.ImportGraphDirectUnweighted.Text = "Імпортувати граф з txt файла";
            this.ImportGraphDirectUnweighted.UseVisualStyleBackColor = true;
            this.ImportGraphDirectUnweighted.Click += new System.EventHandler(this.ImportGraphDirectUnweighted_Click);
            // 
            // GraphImageDirectedUnweightedLbl
            // 
            this.GraphImageDirectedUnweightedLbl.AutoSize = true;
            this.GraphImageDirectedUnweightedLbl.Location = new System.Drawing.Point(1251, 6);
            this.GraphImageDirectedUnweightedLbl.Name = "GraphImageDirectedUnweightedLbl";
            this.GraphImageDirectedUnweightedLbl.Size = new System.Drawing.Size(191, 25);
            this.GraphImageDirectedUnweightedLbl.TabIndex = 80;
            this.GraphImageDirectedUnweightedLbl.Text = "Зображення графу";
            // 
            // GraphImageDirectedUnweightedPB
            // 
            this.GraphImageDirectedUnweightedPB.Location = new System.Drawing.Point(1166, 34);
            this.GraphImageDirectedUnweightedPB.Name = "GraphImageDirectedUnweightedPB";
            this.GraphImageDirectedUnweightedPB.Size = new System.Drawing.Size(350, 350);
            this.GraphImageDirectedUnweightedPB.TabIndex = 79;
            this.GraphImageDirectedUnweightedPB.TabStop = false;
            // 
            // NumberOfVerticesDirectedUnweightedLbl
            // 
            this.NumberOfVerticesDirectedUnweightedLbl.AutoSize = true;
            this.NumberOfVerticesDirectedUnweightedLbl.Location = new System.Drawing.Point(9, 6);
            this.NumberOfVerticesDirectedUnweightedLbl.Name = "NumberOfVerticesDirectedUnweightedLbl";
            this.NumberOfVerticesDirectedUnweightedLbl.Size = new System.Drawing.Size(171, 25);
            this.NumberOfVerticesDirectedUnweightedLbl.TabIndex = 68;
            this.NumberOfVerticesDirectedUnweightedLbl.Text = "Кількість вершин";
            // 
            // PastGraphImageDirectedUnweightedLbl
            // 
            this.PastGraphImageDirectedUnweightedLbl.AutoSize = true;
            this.PastGraphImageDirectedUnweightedLbl.Location = new System.Drawing.Point(1269, 387);
            this.PastGraphImageDirectedUnweightedLbl.Name = "PastGraphImageDirectedUnweightedLbl";
            this.PastGraphImageDirectedUnweightedLbl.Size = new System.Drawing.Size(146, 25);
            this.PastGraphImageDirectedUnweightedLbl.TabIndex = 83;
            this.PastGraphImageDirectedUnweightedLbl.Text = "Минулий граф";
            // 
            // PastGraphImageDirectedUnweightedPB
            // 
            this.PastGraphImageDirectedUnweightedPB.Location = new System.Drawing.Point(1159, 412);
            this.PastGraphImageDirectedUnweightedPB.Name = "PastGraphImageDirectedUnweightedPB";
            this.PastGraphImageDirectedUnweightedPB.Size = new System.Drawing.Size(350, 350);
            this.PastGraphImageDirectedUnweightedPB.TabIndex = 81;
            this.PastGraphImageDirectedUnweightedPB.TabStop = false;
            // 
            // NumberOfVerticesDirectedUnweightedTB
            // 
            this.NumberOfVerticesDirectedUnweightedTB.Location = new System.Drawing.Point(42, 34);
            this.NumberOfVerticesDirectedUnweightedTB.Name = "NumberOfVerticesDirectedUnweightedTB";
            this.NumberOfVerticesDirectedUnweightedTB.Size = new System.Drawing.Size(100, 30);
            this.NumberOfVerticesDirectedUnweightedTB.TabIndex = 70;
            // 
            // VertexNumberDirectedUnweightedLbl
            // 
            this.VertexNumberDirectedUnweightedLbl.AutoSize = true;
            this.VertexNumberDirectedUnweightedLbl.Location = new System.Drawing.Point(233, 6);
            this.VertexNumberDirectedUnweightedLbl.Name = "VertexNumberDirectedUnweightedLbl";
            this.VertexNumberDirectedUnweightedLbl.Size = new System.Drawing.Size(161, 25);
            this.VertexNumberDirectedUnweightedLbl.TabIndex = 73;
            this.VertexNumberDirectedUnweightedLbl.Text = "Номер вершини";
            // 
            // VertexNumberDirectedUnweightedTB
            // 
            this.VertexNumberDirectedUnweightedTB.Location = new System.Drawing.Point(266, 34);
            this.VertexNumberDirectedUnweightedTB.Name = "VertexNumberDirectedUnweightedTB";
            this.VertexNumberDirectedUnweightedTB.Size = new System.Drawing.Size(100, 30);
            this.VertexNumberDirectedUnweightedTB.TabIndex = 78;
            // 
            // CyclesDirectedUnweightedLbl
            // 
            this.CyclesDirectedUnweightedLbl.AutoSize = true;
            this.CyclesDirectedUnweightedLbl.Location = new System.Drawing.Point(5, 106);
            this.CyclesDirectedUnweightedLbl.Name = "CyclesDirectedUnweightedLbl";
            this.CyclesDirectedUnweightedLbl.Size = new System.Drawing.Size(318, 25);
            this.CyclesDirectedUnweightedLbl.TabIndex = 76;
            this.CyclesDirectedUnweightedLbl.Text = "Цикли, яким належить вершина ";
            // 
            // PastCyclesDirectedUnweightedLbl
            // 
            this.PastCyclesDirectedUnweightedLbl.AutoSize = true;
            this.PastCyclesDirectedUnweightedLbl.Location = new System.Drawing.Point(352, 106);
            this.PastCyclesDirectedUnweightedLbl.Name = "PastCyclesDirectedUnweightedLbl";
            this.PastCyclesDirectedUnweightedLbl.Size = new System.Drawing.Size(136, 25);
            this.PastCyclesDirectedUnweightedLbl.TabIndex = 84;
            this.PastCyclesDirectedUnweightedLbl.Text = "Минулі цикли";
            // 
            // UpdateDirectedUnweighted
            // 
            this.UpdateDirectedUnweighted.Location = new System.Drawing.Point(384, 637);
            this.UpdateDirectedUnweighted.Name = "UpdateDirectedUnweighted";
            this.UpdateDirectedUnweighted.Size = new System.Drawing.Size(179, 92);
            this.UpdateDirectedUnweighted.TabIndex = 85;
            this.UpdateDirectedUnweighted.Text = "Оновити граф";
            this.UpdateDirectedUnweighted.UseVisualStyleBackColor = true;
            this.UpdateDirectedUnweighted.Click += new System.EventHandler(this.UpdateDirectedUnweighted_Click);
            // 
            // CyclesDirectedUnweightedLB
            // 
            this.CyclesDirectedUnweightedLB.FormattingEnabled = true;
            this.CyclesDirectedUnweightedLB.ItemHeight = 25;
            this.CyclesDirectedUnweightedLB.Location = new System.Drawing.Point(27, 149);
            this.CyclesDirectedUnweightedLB.Name = "CyclesDirectedUnweightedLB";
            this.CyclesDirectedUnweightedLB.Size = new System.Drawing.Size(166, 379);
            this.CyclesDirectedUnweightedLB.TabIndex = 75;
            // 
            // PastCyclesDirectedUnweightedLB
            // 
            this.PastCyclesDirectedUnweightedLB.FormattingEnabled = true;
            this.PastCyclesDirectedUnweightedLB.ItemHeight = 25;
            this.PastCyclesDirectedUnweightedLB.Location = new System.Drawing.Point(323, 149);
            this.PastCyclesDirectedUnweightedLB.Name = "PastCyclesDirectedUnweightedLB";
            this.PastCyclesDirectedUnweightedLB.Size = new System.Drawing.Size(165, 379);
            this.PastCyclesDirectedUnweightedLB.TabIndex = 82;
            // 
            // MainMethodDirectedUnweighted
            // 
            this.MainMethodDirectedUnweighted.Location = new System.Drawing.Point(942, 637);
            this.MainMethodDirectedUnweighted.Name = "MainMethodDirectedUnweighted";
            this.MainMethodDirectedUnweighted.Size = new System.Drawing.Size(179, 92);
            this.MainMethodDirectedUnweighted.TabIndex = 72;
            this.MainMethodDirectedUnweighted.Text = "Знайти цикли, яким належить вершина";
            this.MainMethodDirectedUnweighted.UseVisualStyleBackColor = true;
            this.MainMethodDirectedUnweighted.Click += new System.EventHandler(this.MainMethodDirectedUnweighted_Click);
            // 
            // AdjacencyMatrixDirectedUnweightedDGV
            // 
            this.AdjacencyMatrixDirectedUnweightedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdjacencyMatrixDirectedUnweightedDGV.Location = new System.Drawing.Point(569, 34);
            this.AdjacencyMatrixDirectedUnweightedDGV.Name = "AdjacencyMatrixDirectedUnweightedDGV";
            this.AdjacencyMatrixDirectedUnweightedDGV.RowHeadersWidth = 51;
            this.AdjacencyMatrixDirectedUnweightedDGV.RowTemplate.Height = 24;
            this.AdjacencyMatrixDirectedUnweightedDGV.Size = new System.Drawing.Size(537, 400);
            this.AdjacencyMatrixDirectedUnweightedDGV.TabIndex = 71;
            // 
            // AdjacencyMatrixDirectedUnweightedLbl
            // 
            this.AdjacencyMatrixDirectedUnweightedLbl.AutoSize = true;
            this.AdjacencyMatrixDirectedUnweightedLbl.Location = new System.Drawing.Point(731, 6);
            this.AdjacencyMatrixDirectedUnweightedLbl.Name = "AdjacencyMatrixDirectedUnweightedLbl";
            this.AdjacencyMatrixDirectedUnweightedLbl.Size = new System.Drawing.Size(205, 25);
            this.AdjacencyMatrixDirectedUnweightedLbl.TabIndex = 69;
            this.AdjacencyMatrixDirectedUnweightedLbl.Text = "Матриця суміжності";
            // 
            // CreateCompleteDirectedUnweighted
            // 
            this.CreateCompleteDirectedUnweighted.Location = new System.Drawing.Point(199, 637);
            this.CreateCompleteDirectedUnweighted.Name = "CreateCompleteDirectedUnweighted";
            this.CreateCompleteDirectedUnweighted.Size = new System.Drawing.Size(179, 92);
            this.CreateCompleteDirectedUnweighted.TabIndex = 74;
            this.CreateCompleteDirectedUnweighted.Text = "Створення повного графу";
            this.CreateCompleteDirectedUnweighted.UseVisualStyleBackColor = true;
            this.CreateCompleteDirectedUnweighted.Click += new System.EventHandler(this.CreateCompleteDirectedUnweighted_Click);
            // 
            // TimerDirectedUnweightedLbl
            // 
            this.TimerDirectedUnweightedLbl.AutoSize = true;
            this.TimerDirectedUnweightedLbl.Location = new System.Drawing.Point(22, 573);
            this.TimerDirectedUnweightedLbl.Name = "TimerDirectedUnweightedLbl";
            this.TimerDirectedUnweightedLbl.Size = new System.Drawing.Size(252, 25);
            this.TimerDirectedUnweightedLbl.TabIndex = 77;
            this.TimerDirectedUnweightedLbl.Text = "Час виконання програми: ";
            // 
            // CreateEmptyDirectedUnweighted
            // 
            this.CreateEmptyDirectedUnweighted.Location = new System.Drawing.Point(14, 637);
            this.CreateEmptyDirectedUnweighted.Name = "CreateEmptyDirectedUnweighted";
            this.CreateEmptyDirectedUnweighted.Size = new System.Drawing.Size(179, 92);
            this.CreateEmptyDirectedUnweighted.TabIndex = 67;
            this.CreateEmptyDirectedUnweighted.Text = "Створення незаповненого графу";
            this.CreateEmptyDirectedUnweighted.UseVisualStyleBackColor = true;
            this.CreateEmptyDirectedUnweighted.Click += new System.EventHandler(this.CreateEmptyDirectedUnweighted_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CreateRandomGraphUndirected
            // 
            this.CreateRandomGraphUndirected.Location = new System.Drawing.Point(570, 641);
            this.CreateRandomGraphUndirected.Name = "CreateRandomGraphUndirected";
            this.CreateRandomGraphUndirected.Size = new System.Drawing.Size(179, 92);
            this.CreateRandomGraphUndirected.TabIndex = 70;
            this.CreateRandomGraphUndirected.Text = "Створення випадкового графу";
            this.CreateRandomGraphUndirected.UseVisualStyleBackColor = true;
            this.CreateRandomGraphUndirected.Click += new System.EventHandler(this.CreateRandomGraphUndirected_Click);
            // 
            // CreateRandomGraphDirected
            // 
            this.CreateRandomGraphDirected.Location = new System.Drawing.Point(572, 637);
            this.CreateRandomGraphDirected.Name = "CreateRandomGraphDirected";
            this.CreateRandomGraphDirected.Size = new System.Drawing.Size(179, 92);
            this.CreateRandomGraphDirected.TabIndex = 87;
            this.CreateRandomGraphDirected.Text = "Створення випадкового графу";
            this.CreateRandomGraphDirected.UseVisualStyleBackColor = true;
            this.CreateRandomGraphDirected.Click += new System.EventHandler(this.CreateRandomGraphDirected_Click);
            // 
            // ExportCycleToTxtDirected
            // 
            this.ExportCycleToTxtDirected.Location = new System.Drawing.Point(757, 539);
            this.ExportCycleToTxtDirected.Name = "ExportCycleToTxtDirected";
            this.ExportCycleToTxtDirected.Size = new System.Drawing.Size(179, 92);
            this.ExportCycleToTxtDirected.TabIndex = 88;
            this.ExportCycleToTxtDirected.Text = "Експорувати цикло до txt файлу";
            this.ExportCycleToTxtDirected.UseVisualStyleBackColor = true;
            this.ExportCycleToTxtDirected.Click += new System.EventHandler(this.ExportCycleToTxtDirected_Click);
            // 
            // ExportGraphToTxtDirected
            // 
            this.ExportGraphToTxtDirected.Location = new System.Drawing.Point(757, 637);
            this.ExportGraphToTxtDirected.Name = "ExportGraphToTxtDirected";
            this.ExportGraphToTxtDirected.Size = new System.Drawing.Size(179, 92);
            this.ExportGraphToTxtDirected.TabIndex = 89;
            this.ExportGraphToTxtDirected.Text = "Експорувати граф до txt файлу";
            this.ExportGraphToTxtDirected.UseVisualStyleBackColor = true;
            this.ExportGraphToTxtDirected.Click += new System.EventHandler(this.ExportGraphToTxtDirected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 802);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсова робота";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.UndirectedUnweighted.ResumeLayout(false);
            this.UndirectedUnweighted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphImageUndirectedUnweightedPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PastGraphImageUndirectedUnweightedPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdjacencyMatrixUndirectedUnweightedDGV)).EndInit();
            this.DirectedUnweighted.ResumeLayout(false);
            this.DirectedUnweighted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphImageDirectedUnweightedPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PastGraphImageDirectedUnweightedPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdjacencyMatrixDirectedUnweightedDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UndirectedUnweighted;
        private System.Windows.Forms.TabPage DirectedUnweighted;
        private System.Windows.Forms.PictureBox GraphImageUndirectedUnweightedPB;
        private System.Windows.Forms.Button UpdateUndirectedUnweighted;
        private System.Windows.Forms.Label PastCyclesUndirectedUnweightedLbl;
        private System.Windows.Forms.Label PastGraphImageUndirectedUnweightedLbl;
        private System.Windows.Forms.ListBox PastCyclesUndirectedUnweightedLB;
        private System.Windows.Forms.PictureBox PastGraphImageUndirectedUnweightedPB;
        private System.Windows.Forms.Label GraphImageUndirectedUnweightedLbl;
        private System.Windows.Forms.TextBox VertexNumberUndirectedUnweightedTB;
        private System.Windows.Forms.Label TimerUndirectedUnweightedLbl;
        private System.Windows.Forms.Label CyclesUndirectedUnweightedLbl;
        private System.Windows.Forms.ListBox CyclesUndirectedUnweightedLB;
        private System.Windows.Forms.Button CreateCompleteUndirectedUnweighted;
        private System.Windows.Forms.Label VertexNumberUndirectedUnweightedLbl;
        private System.Windows.Forms.Button MainMethodUndirectedUnweighted;
        private System.Windows.Forms.DataGridView AdjacencyMatrixUndirectedUnweightedDGV;
        private System.Windows.Forms.TextBox NumberOfVerticesUndirectedUnweightedTB;
        private System.Windows.Forms.Label AdjacencyMatrixUndirectedUnweightedLbl;
        private System.Windows.Forms.Label NumberOfVerticesUndirectedUnweightedLbl;
        private System.Windows.Forms.Button CreateEmptyUndirectedUnweighted;
        private System.Windows.Forms.Label GraphImageDirectedUnweightedLbl;
        private System.Windows.Forms.PictureBox GraphImageDirectedUnweightedPB;
        private System.Windows.Forms.Label NumberOfVerticesDirectedUnweightedLbl;
        private System.Windows.Forms.Label PastGraphImageDirectedUnweightedLbl;
        private System.Windows.Forms.PictureBox PastGraphImageDirectedUnweightedPB;
        private System.Windows.Forms.TextBox NumberOfVerticesDirectedUnweightedTB;
        private System.Windows.Forms.Label VertexNumberDirectedUnweightedLbl;
        private System.Windows.Forms.TextBox VertexNumberDirectedUnweightedTB;
        private System.Windows.Forms.Label CyclesDirectedUnweightedLbl;
        private System.Windows.Forms.Label PastCyclesDirectedUnweightedLbl;
        private System.Windows.Forms.Button UpdateDirectedUnweighted;
        private System.Windows.Forms.ListBox CyclesDirectedUnweightedLB;
        private System.Windows.Forms.ListBox PastCyclesDirectedUnweightedLB;
        private System.Windows.Forms.Button MainMethodDirectedUnweighted;
        private System.Windows.Forms.DataGridView AdjacencyMatrixDirectedUnweightedDGV;
        private System.Windows.Forms.Label AdjacencyMatrixDirectedUnweightedLbl;
        private System.Windows.Forms.Button CreateCompleteDirectedUnweighted;
        private System.Windows.Forms.Label TimerDirectedUnweightedLbl;
        private System.Windows.Forms.Button CreateEmptyDirectedUnweighted;
        private System.Windows.Forms.Button ImportGraphUndirectUnweighted;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ImportGraphDirectUnweighted;
        private System.Windows.Forms.Button ExportCycleToTxtUndirected;
        private System.Windows.Forms.Button ExportGraphToTxtUndirected;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button CreateRandomGraphUndirected;
        private System.Windows.Forms.Button ExportGraphToTxtDirected;
        private System.Windows.Forms.Button ExportCycleToTxtDirected;
        private System.Windows.Forms.Button CreateRandomGraphDirected;
    }
}

