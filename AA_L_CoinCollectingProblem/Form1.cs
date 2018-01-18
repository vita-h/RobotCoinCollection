using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AA_L_CoinCollectingProblem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] F;
        int temp, tempI, tempJ;
        List<int> solution;

        private void RobotCoinCollection(int[,] C)
        {
            F = new int[C.GetLength(0) + 1, C.GetLength(1) + 1];

            for (int i = 1; i < F.GetLength(0); i++)
                for (int j = 1; j < F.GetLength(1); j++)
                    F[i, j] = Math.Max(F[i - 1, j], F[i, j - 1]) + C[i - 1, j - 1];
        }

        private void Backtrack()
        {
            if (tempI == 1 && tempJ == 1)
                return;

            if (tempI == 1 || tempJ == 1)
            {
                if (tempJ == 1)
                {
                    tempI = tempI - 1;
                    solution.Add(tempI);
                    solution.Add(tempJ);
                    Backtrack();
                }
                else
                {
                    tempJ = tempJ - 1;
                    solution.Add(tempI);
                    solution.Add(tempJ);
                    Backtrack();
                }
            }
            else
            {
                int left = F[tempI, tempJ - 1];
                int up = F[tempI - 1, tempJ];

                if (left >= up)
                {
                    if (left + 1 == temp)
                    {
                        tempJ = tempJ - 1;
                        solution.Add(tempI);
                        solution.Add(tempJ);
                        temp--;
                    }
                    else if (left == temp)
                    {
                        tempJ = tempJ - 1;
                        solution.Add(tempI);
                        solution.Add(tempJ);
                    }
                }
                else
                {
                    if (up + 1 == temp)
                    {
                        tempI = tempI - 1;
                        solution.Add(tempI);
                        solution.Add(tempJ);
                        temp--;
                    }
                    else if (up == temp)
                    {
                        tempI = tempI - 1;
                        solution.Add(tempI);
                        solution.Add(tempJ);
                    }
                }
                Backtrack();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RobotCoinCollection(C);

            solution = new List<int>();
            temp = F[F.GetLength(0) - 1, F.GetLength(1) - 1]; tempI = F.GetLength(0) - 1; tempJ = F.GetLength(1) - 1;
            solution.Add(tempI);
            solution.Add(tempJ);

            Backtrack();

            DrawSolution();

            MessageBox.Show("Robot can collect maximum number of coins: " + F[N,M].ToString(), "Result");
        }

        int N;
        int M;
        int SizeOfGridTile;
        public Graphics GraphicsObj;
        public Pen BasicPen;
        public int StartX = 10;
        public int StartY = 10;
        public int[,] C;

        private void pnlMain_Click(object sender, EventArgs e)
        {
            //Draw Coin
            Point p = pnlMain.PointToClient(Cursor.Position);
            Point coin = new Point();
            coin.X = ((p.X - StartX) / SizeOfGridTile) * SizeOfGridTile + StartX;
            coin.Y = ((p.Y - StartY) / SizeOfGridTile) * SizeOfGridTile + StartY;

            GraphicsObj.FillEllipse(new SolidBrush(Color.Gold), coin.X + SizeOfGridTile/4, coin.Y+SizeOfGridTile/4, SizeOfGridTile/2, SizeOfGridTile/2);
            GraphicsObj.DrawEllipse(BasicPen, coin.X+SizeOfGridTile/4, coin.Y+SizeOfGridTile/4, SizeOfGridTile/2, SizeOfGridTile/2);

            int j = (p.X - StartX) / SizeOfGridTile, i = (p.Y - StartY) / SizeOfGridTile;
            C[i, j] = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            M = (int)nupM.Value;
            N = (int)nupN.Value;
            SizeOfGridTile = (int)nupSizeOfGridTile.Value;
            BasicPen = new Pen(Color.Black);
            GraphicsObj = pnlMain.CreateGraphics();
            GraphicsObj.Clear(SystemColors.Control);

            //Draw Grid
            GraphicsObj.DrawLine(BasicPen, new Point(StartX, StartY), new Point(M * SizeOfGridTile + StartX, StartY));
            GraphicsObj.DrawLine(BasicPen, new Point(StartX, StartY), new Point(StartX, N * SizeOfGridTile + StartY));

            for (int i = 1; i <= M; i++)
                GraphicsObj.DrawLine(BasicPen, new Point(StartX + i * SizeOfGridTile, StartY), new Point(StartX + i * SizeOfGridTile, N * SizeOfGridTile + StartY));

            for (int j = 1; j <= N; j++)
                GraphicsObj.DrawLine(BasicPen, new Point(StartX, StartY + j * SizeOfGridTile), new Point(M * SizeOfGridTile + StartX, StartY + j * SizeOfGridTile));

            button2.Enabled = true;

            C = new int[N, M];
        } 

        private void DrawSolution()
        {
            // Draw Path
            for (int k = 0; k < solution.Count(); k += 2)
            {
                GraphicsObj.DrawEllipse(new Pen(Color.Red), (solution[k + 1] - 1) * SizeOfGridTile + StartX, (solution[k] - 1) * SizeOfGridTile + StartY, SizeOfGridTile, SizeOfGridTile);
                Thread.Sleep(800);
            }

            // Draw Numbers
            for (int i = 1; i < F.GetLength(0); i++)
                for (int j = 1; j < F.GetLength(1); j++)
                    GraphicsObj.DrawString(F[i, j].ToString(),new Font("Times New Roman", 12.0f), new SolidBrush(Color.Black), (j - 1) * SizeOfGridTile + StartY, (i - 1) * SizeOfGridTile + StartX + SizeOfGridTile/3);
        }
    }
}
