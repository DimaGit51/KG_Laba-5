using System.Drawing.Drawing2D;
using System.Drawing;

namespace LaboratoryWork_5
{
    public partial class Form1 : Form
    {
        double R = 15;
        double K = 6 * 0.5;
        double A = 6;
        public Form1()
        {
            InitializeComponent();

            DrawChes();
        }


        /*
         * 0.1pi < t < 1.4pi && 0 < q < 1.5pi
         */
        private double getX(double a, double b, double R, double K)
        {
            //return (1 + t - Math.Sin(t)) * Math.Cos(q);
            return R*Math.Sin(a) * Math.Cos(b)*(1+0.5*Math.Abs(Math.Sin(K*b)));
        }

        private double getY(double t, double q, double R, double K)
        {
            //return 1 - Math.Cos(t);
            return R * Math.Sin(t) * Math.Sin(q) * (1 + 0.5 * Math.Abs(Math.Sin(K * q)));

        }

        private double getZ(double t, double q, double R, double A)
        {
            return -R * Math.Sqrt(A*Math.Pow(Math.Sin(0.5*t),1.5)) + (1.5 * R);
            //return -(1 + t - Math.Sin(t)) * Math.Sin(q);
        }

        private void DrawChes()
        {
            int countPoint = 25; // Можно менять без страха

            double[,,] screenPoints = new double[countPoint, countPoint, 4];
            double stepT = (1 - 0) * Math.PI / countPoint;
            double stepQ = (2 - 0) * Math.PI / countPoint;

            //угол проекции
            double angleF = trackBarAngleF.Value * Math.PI / 180;
            double angleQ = trackBarAngleQ.Value * Math.PI / 180;

            int k = trackBarKF.Value;
            int R = trackBarR.Value;
            double K = trackBarK.Value*0.5;
            int A = Math.Abs(trackBarA.Value);

            //МАТРИЦЫ
            double[,] matrixA = {
                {Math.Cos(angleF), Math.Sin(angleF), 0, 0 },
                {-Math.Sin(angleF), Math.Cos(angleF), 0, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 1 } };
            double[,] matrixB = {
                {1, 0, 0, 0 },
                {0, Math.Cos(angleQ), Math.Sin(angleQ), 0 },
                {0, -Math.Sin(angleQ), Math.Cos(angleQ), 0},
                {0, 0, 0, 1}
            };
            double shift = 2;
            double[,] matrixShift = { 
                {1, 0, 0, shift * trackBarOX.Value},
                {0, 1, 0, shift * trackBarOY.Value},
                {0, 0, 1, 0},
                {0, 0, 0, 1 } };

            double[,] matrAXEONOM = MyMultiplyMatrices(matrixB, matrixA);

            //Цикл
            for (int t1 = 0; t1 < countPoint; t1++)
            {
                for (int q1 = 0; q1 < countPoint; q1++)
                {
                    
                    double mirX = getX(t1 * stepT, q1 * stepQ, R, K);
                    double mirY = getY(t1 * stepT, q1 * stepQ, R, K);
                    double mirZ = getZ(t1 * stepT, q1 * stepQ, R, A);

                    double[,] mirPoint = { { k * mirX }, { k * mirY }, { k * mirZ }, { 1 } };

                    double[,] projectionPoint = MyMultiplyMatrices(matrixShift, matrAXEONOM);
                    projectionPoint = MyMultiplyMatrices(projectionPoint, mirPoint );

                    screenPoints[t1, q1, 0] = projectionPoint[0, 0];
                    screenPoints[t1, q1, 1] = projectionPoint[1, 0];
                    screenPoints[t1, q1, 2] = projectionPoint[2, 0];
                    screenPoints[t1, q1, 3] = projectionPoint[3, 0];
                }
            }

            DrawStraightLines(screenPoints);
        }

        private void DrawStraightLines(double[,,] screenPoints)
        {
            Bitmap _bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics _graphics = Graphics.FromImage(_bitmap);
            //_graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Pen p = new Pen(Color.Black, 1);
            //Матрицы
            double[,] goMid = new double[,] { { 1f, 0f, (int)(pictureBox.Width / 2) }, { 0f, 1f, (int)(pictureBox.Height / 2) }, { 0f, 0f, 1f } };

            for (int i = 1; i < screenPoints.GetLength(0); i++)
            {
                for (int j = 1; j < screenPoints.GetLength(1); j++)
                {
                    double x1_1 = screenPoints[i - 1, j, 0];
                    double y1_1 = screenPoints[i - 1, j, 1];
                    double z1_1 = screenPoints[i - 1, j, 2];

                    double x1_2 = screenPoints[i, j - 1, 0];
                    double y1_2 = screenPoints[i, j - 1, 1];
                    double z1_2 = screenPoints[i, j - 1, 2];

                    double x2 = screenPoints[i, j, 0];
                    double y2 = screenPoints[i, j, 1];
                    double z2 = screenPoints[i, j, 2];

                    double[,] v1_1 = MyMultiplyMatrices(goMid, new double[,] { { x1_1 }, { y1_1 }, { 1 } });
                    double[,] v1_2 = MyMultiplyMatrices(goMid, new double[,] { { x1_2 }, { y1_2 }, { 1 } });
                    double[,] v2 = MyMultiplyMatrices(goMid, new double[,] { { x2 }, { y2 }, { 1 } });


                    _graphics.DrawLine(p, (int)v1_1[0, 0], (int)v1_1[1, 0], (int)v2[0, 0], (int)v2[1, 0]);
                    _graphics.DrawLine(p, (int)v1_2[0, 0], (int)v1_2[1, 0], (int)v2[0, 0], (int)v2[1, 0]);
                }
                double x1_11 = screenPoints[i, 0, 0];
                double y1_11 = screenPoints[i, 0, 1];
                double z1_11 = screenPoints[i, 0, 2];


                double x21 = screenPoints[i, screenPoints.GetLength(1) - 1, 0];
                double y21 = screenPoints[i, screenPoints.GetLength(1) - 1, 1];
                double z21 = screenPoints[i, screenPoints.GetLength(1) - 1, 2];

                double[,] v1_11 = MyMultiplyMatrices(goMid, new double[,] { { x1_11 }, { y1_11 }, { 1 } });
                double[,] v21 = MyMultiplyMatrices(goMid, new double[,] { { x21 }, { y21 }, { 1 } });


                _graphics.DrawLine(p, (int)v21[0, 0], (int)v21[1, 0], (int)v1_11[0, 0], (int)v1_11[1, 0]);
            }



            for (int i = 1; i < screenPoints.GetLength(1); i++)
            {
                double x1_1 = screenPoints[2, i - 1, 0];
                double y1_1 = screenPoints[2, i - 1, 1];
                double z1_1 = screenPoints[2, i - 1, 2];


                double x2 = screenPoints[2, i, 0];
                double y2 = screenPoints[2, i, 1];
                double z2 = screenPoints[2, i, 2];

                double[,] v1_1 = MyMultiplyMatrices(goMid, new double[,] { { x1_1 }, { y1_1 }, { 1 } });
                double[,] v2 = MyMultiplyMatrices(goMid, new double[,] { { x2 }, { y2 }, { 1 } });


                _graphics.DrawLine(p, (int)v1_1[0, 0], (int)v1_1[1, 0], (int)v2[0, 0], (int)v2[1, 0]);
            }

            for (int i = 1; i < screenPoints.GetLength(1); i++)
            {
                double x1_1 = screenPoints[2, i - 1, 0];
                double y1_1 = screenPoints[2, i - 1, 1];
                double z1_1 = screenPoints[2, i - 1, 2];


                double x2 = screenPoints[2, i, 0];
                double y2 = screenPoints[2, i, 1];
                double z2 = screenPoints[2, i, 2];

                double[,] v1_1 = MyMultiplyMatrices(goMid, new double[,] { { x1_1 }, { y1_1 }, { 1 } });
                double[,] v2 = MyMultiplyMatrices(goMid, new double[,] { { x2 }, { y2 }, { 1 } });


                _graphics.DrawLine(p, (int)v2[0, 0], (int)v2[1, 0], (int)v1_1[0, 0], (int)v1_1[1, 0]);
            }




            for (int i = 1; i < screenPoints.GetLength(1); i++)
            {
                double x1_1 = screenPoints[0, i - 1, 0];
                double y1_1 = screenPoints[0, i - 1, 1];
                double z1_1 = screenPoints[0, i - 1, 2];


                double x2 = screenPoints[0, i, 0];
                double y2 = screenPoints[0, i, 1];
                double z2 = screenPoints[0, i, 2];

                double[,] v1_1 = MyMultiplyMatrices(goMid, new double[,] { { x1_1 }, { y1_1 }, { 1 } });
                double[,] v2 = MyMultiplyMatrices(goMid, new double[,] { { x2 }, { y2 }, { 1 } });


                _graphics.DrawLine(p, (int)v1_1[0, 0], (int)v1_1[1, 0], (int)v2[0, 0], (int)v2[1, 0]);
            }
            pictureBox.Image = _bitmap;
        }

        private double[,] MyMultiplyMatrices(double[,] matrix1, double[,] matrix2)
        {
            double[,] matrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        matrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return matrix;
        }

        private void trackBarKF_Scroll(object sender, EventArgs e)
        {
            DrawChes();
        }

        private void trackBarAngleF_Scroll(object sender, EventArgs e)
        {
            DrawChes();
        }

        private void trackBarAngleQ_Scroll(object sender, EventArgs e)
        {
            DrawChes();
        }

        private void trackBarOX_Scroll(object sender, EventArgs e)
        {
            DrawChes();
        }

        private void trackBarOY_Scroll(object sender, EventArgs e)
        {
            DrawChes();
        }

        private void trackBarOZ_Scroll(object sender, EventArgs e)
        {
            DrawChes();
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {
            DrawChes();
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            DrawChes();
        }

        private void trackBarK_Scroll(object sender, EventArgs e)
        {
            DrawChes();
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            DrawChes();

        }
    }
}