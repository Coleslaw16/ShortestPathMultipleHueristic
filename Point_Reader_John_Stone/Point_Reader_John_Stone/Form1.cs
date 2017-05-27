using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Collections;


namespace Point_Reader_John_Stone
{
    public partial class Form1 : Form
    {
        string filename = "";
        private points[] pointLocation;
        private float[,] distanceHolder;
        private int gridSize = 0;
        private bool drawGrid = false;
        private int minX =9000;
        private int minY=9000;
        private int maxX = 0;
        private int maxY = 0;
        private Bitmap aBitMap;
        private float scale;
        private float dotSize;
        private float lineSize;
        private Color Color = Color.Black;
        private bool drawingLines = false;
        private float totalDistance;
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
            scale = float.Parse(textBox.Text);
            dotSize = float.Parse(textBox1.Text);
            lineSize = float.Parse(lineBox.Text);
        }

        private void readFile()
        {
            try
            {
                StreamReader st = new StreamReader(filename);
                int arraySize = File.ReadLines(filename).Count();
                pointLocation = new points[arraySize];
                for (int i = 0; i < arraySize; i++)
                {
                    string[] temp = st.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    int x = int.Parse(temp[0]);
                    if(x < minX)
                    {
                        minX = x;
                    }
                    if(x > maxX)
                    {
                        maxX = x;
                    }
                    int y = int.Parse(temp[1]);
                    if(y < minY)
                    {
                        minY = y; 
                    }
                    if(y > maxY)
                    {
                        maxY = y;
                    }
                    pointLocation[i] = (new points(x, y, dotSize, Color));
                }
                st.Close();
                getTotalDistance();
                drawPoints();
            }
            catch (Exception e)
            {
                MessageBox.Show("You messed up somewhere");
            }
        }

        private void resetFrameBuffer()
        {
            Graphics g = CreateGraphics();
            if (aBitMap != null)
                aBitMap.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            aBitMap = new Bitmap(picBox.Width, picBox.Height, g);
        }
        private void drawPoints()
        {
            resetFrameBuffer();
            Graphics g = Graphics.FromImage(aBitMap);
            System.Drawing.SolidBrush aBrsh = new System.Drawing.SolidBrush(Color.Black);
            if(drawGrid == true)
            {
                Pen drawingPens = new Pen(Brushes.Green, lineSize);
                float x = minX;
   //             Console.WriteLine(x);
                while(x <= maxX)
                {
                    g.DrawLine(drawingPens, x, minY, x, maxY);
                    x += gridSize;
                }
//                g.DrawLine(drawingPens, x, minY, x, maxY);
                float y = minY;
  //              Console.WriteLine(y);
                while(y <= maxY)
                {
                    g.DrawLine(drawingPens, minX, y, maxX, y);
                    y += gridSize;
                }
 //               g.DrawLine(drawingPens, minX, y, maxX, y);
                drawingPens.Dispose();
            }
            if (drawingLines == true)
            {
                Pen drawingPen = new Pen(Brushes.Crimson, lineSize);
                for (int i = 0; i < pointLocation.Length - 1; i++)
                {
                    g.DrawLine(drawingPen, pointLocation[i].X * scale, pointLocation[i].Y * scale, pointLocation[i + 1].X * scale, pointLocation[i + 1].Y * scale);
                }
                drawingPen.Dispose();
            }
            for (int i = 0; i < pointLocation.GetLength(0); i++)
            {
                g.FillEllipse(aBrsh, (float)(pointLocation[i].X*scale) - dotSize / 2.0F, (float)(pointLocation[i].Y*scale) - dotSize / 2.0F, dotSize, dotSize);
            }
            picBox.Image = aBitMap;
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
 //           drawPoints();
        }

        private void getFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filename = dlg.FileName;
                readFile();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scale = float.Parse(textBox.Text);
            drawPoints();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dotSize = float.Parse(textBox1.Text);
            drawPoints();
        }

        private void lineCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(lineCheck.Checked == true)
            {
                drawingLines = true;
            }
            else
            {
                drawingLines = false;
            }
            drawPoints();
        }

        private void drawLine_Click(object sender, EventArgs e)
        {
            lineSize = float.Parse(lineBox.Text);
        }

        private void nnButton_Click(object sender, EventArgs e)
        {
            for(int i=0;i<pointLocation.Length-1;i++)
            {
                float minDist = float.MaxValue;
                for(int j = i+1;j<pointLocation.Length;j++)
                {
                    float distance = (float)(Math.Sqrt(Math.Pow(pointLocation[i].X - pointLocation[j].X, 2) + Math.Pow(pointLocation[i].Y - pointLocation[j].Y, 2)));
                    if( distance < minDist && distance > 0)
                    {
                        minDist = distance;
                        swap(i+1, j);
                    }
                }
            }
            getTotalDistance();
        }

        private void swap(int i, int j)
        {
            points temp = pointLocation[i];
            pointLocation[i] = pointLocation[j];
            pointLocation[j] = temp;
        }

        private void hButton_Click(object sender, EventArgs e)
        {
            bool done = false;
            while (!done)
            {
                done = true;
                for(int i=0;i<(pointLocation.Length-4);i++)
                {
                    for(int j = i+3;j<(pointLocation.Length-1);j++)
                    {
                        if(dist(i,j) + dist(j,(i+1)) + dist((j-1),(j+1)) < dist(i,(i+1)) + dist((j-1),j) + dist(j,(j+1)))
                        {
                            move(j, i);
                            done = false;
                        }
                    }
                }
            }
            getTotalDistance();
        }

        private float dist(int i, int j)
        {
            return (float)(Math.Sqrt(Math.Pow(pointLocation[i].X - pointLocation[j].X, 2) + Math.Pow(pointLocation[i].Y - pointLocation[j].Y, 2)));
        }

        private void move(int j, int i)
        {
            points temp = pointLocation[j];
            for(int k = j; k>i+1; k--)
            {
                pointLocation[k] = pointLocation[k - 1];
            }
            pointLocation[i + 1] = temp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool done = false;
            while (!done)
            {
                done = true;
                for (int i = 0; i < (pointLocation.Length - 3); i++)
                {
                    for (int j = i + 2; j < (pointLocation.Length-1); j++)
                    {
                        if (dist(i, i+1) + dist(j, (j + 1))  > dist((i+1), (j + 1)) + dist(i, j))
                        {
                            reverse(j, i+1);
                            done = false;
                        }
                    }
                }
            }
            getTotalDistance();
        }

        private void reverse(int i, int j)
        {
            int big = Math.Max(i, j);
            int small = Math.Min(i, j);
            while(big >= small)
            {
                swap(big, small);
                big--;
                small++;
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.FilterIndex = 1;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter w = new StreamWriter(saveFile.OpenFile());
                //               w.Write(pointLocation.Length + "\r\n");
                for (int i = 0; i < pointLocation.Length; i++)
                {
                    w.Write(pointLocation[i].X + " " + pointLocation[i].Y + "\r\n");
                }
                w.Close();
            }
        }

        private void convexHull_Click(object sender, EventArgs e)
        {
            if(pointLocation.Length<3)
            {
                throw new ArgumentException("You need at least 3 points");
            }
            points min = pointLocation[0];
            foreach(points x in pointLocation)
            {
                if(x.X < min.X)
                {
                    min = x;
                }
            }

            List<points> hull = new List<points>();
            points vEndpoint;
            points vpointOnHull = min;
            do
            {
                hull.Add(vpointOnHull);
                vEndpoint = pointLocation[0];

                for(int j=1;j<pointLocation.Length;j++)
                {
                    if(vpointOnHull == vEndpoint  || Orientation(vpointOnHull,vEndpoint,pointLocation[j]) == -1)
                    {
                        vEndpoint = pointLocation[j];
                    }
                }
                vpointOnHull = vEndpoint;
            } while (vEndpoint != hull[0]);
            
            Pen drawingPen = new Pen(Brushes.Crimson, lineSize);
            points[] tempCH = new points[hull.Count];
            int count = 0;
            foreach(points x in hull)
            {
                tempCH[count] = x;
                count++;
            }
            resetFrameBuffer();
            Graphics g = Graphics.FromImage(aBitMap);
            System.Drawing.SolidBrush aBrsh = new System.Drawing.SolidBrush(Color.Black);
            for (int i = 0; i < tempCH.Length - 1; i++)
            {
                g.DrawLine(drawingPen, tempCH[i].X * scale, tempCH[i].Y * scale, tempCH[i+1].X * scale, tempCH[i + 1].Y * scale);
            }
            g.DrawLine(drawingPen, tempCH[tempCH.Length-1].X * scale, tempCH[tempCH.Length-1].Y * scale, tempCH[0].X * scale, tempCH[0].Y * scale);
            drawingPen.Dispose();
            for (int i = 0; i < pointLocation.GetLength(0); i++)
            {
                g.FillEllipse(aBrsh, (float)(pointLocation[i].X * scale) - dotSize / 2.0F, (float)(pointLocation[i].Y * scale) - dotSize / 2.0F, dotSize, dotSize);
            }
            picBox.Image = aBitMap;
        }

        private int Orientation(points p1, points p2, points p)
        {
            int orin = (int)((p2.X - p1.X) * (p.Y - p1.Y) - (p.X - p1.X) * (p2.Y - p1.Y));

            if (orin > 0)
                return -1;
            if (orin < 0)
                return 1;

            return 0;
        }

        private void randAlg_Click(object sender, EventArgs e)
        {
            Random rand1 = new Random();
            ArrayList temp = new ArrayList();
            foreach(points x in pointLocation)
            {
                temp.Add(x);
            }

            ArrayList shortest = new ArrayList();
            float length = 0;
            while(temp.Count > 1)
            {
                int grab = rand1.Next() % temp.Count;
 //               Console.WriteLine(grab);
                points tempPoint = (points)(temp[grab]);
                temp.RemoveAt(grab);
                shortest.Add(tempPoint);
                if(shortest.Count >= 3)
                {
                    points[] temp1 = new points[shortest.Count];
                    points[] temp2 = new points[shortest.Count];
                    shortest.CopyTo(temp1);
                    shortest.CopyTo(temp2);
                    length = getLocalDistance(temp1);
                    for(int i=shortest.Count-1;i>0;i--)
                    {
                        swap1(temp1, i, i - 1);
                        float tempLength = 0;
                        tempLength = getLocalDistance(temp1);
                        if(tempLength < length)
                        {
                            Array.Copy(temp1, temp2,temp1.Length);
                            length = tempLength;
                        }
                    }
                    shortest = new ArrayList();
                    shortest.AddRange(temp2);
                }
            }
            Console.WriteLine("Got Here");
            shortest.Add(temp[0]);
            points[] temp11 = new points[shortest.Count];
            points[] temp21 = new points[shortest.Count];
            shortest.CopyTo(temp11);
            shortest.CopyTo(temp21);
            length = getLocalDistance(temp11);
            for (int i = shortest.Count - 1; i > 0; i--)
            {
                swap1(temp11, i, i - 1);
                float tempLength = 0;
                tempLength = getLocalDistance(temp11);
                if (tempLength < length)
                {
                    Array.Copy(temp11, temp21, temp11.Length);
                    length = tempLength;
                }
            }
            shortest = new ArrayList();
            shortest.AddRange(temp21);
            Console.WriteLine(shortest.Count + " " + pointLocation.Length);
            pointLocation = new points[shortest.Count];
            pointLocation = (points[]) shortest.ToArray(typeof(points));
            getTotalDistance();
        }

        private void getTotalDistance()
        {
            totalDistance = 0;
            for (int i = 0; i < pointLocation.Length - 1; i++)
            {
                totalDistance += dist(i, i + 1);
            }
            totalDistBox.Text = Convert.ToString(totalDistance);
        }

        private float getLocalDistance(points[] a)
        {
            float x = 0;
            for(int i=0; i< a.Length - 1;i++)
            {
                x += dist1(a,i,i+1);
            }
            return x;
        }

        private float dist1(points[] a, int i, int j)
        {
            return (float)(Math.Sqrt(Math.Pow(a[i].X - a[j].X, 2) + Math.Pow(a[i].Y - a[j].Y, 2)));
        }
       
        private void swap1(points[] a, int i, int j)
        {
            points temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            drawGrid = true;
            gridSize = int.Parse(gridBox.Text);
            drawPoints();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float numOfBoxX = (maxX - minX)/gridSize;
            float numOfBoxY = (maxY - minY)/gridSize;
            if (numOfBoxX % 10 != 0)
                numOfBoxX++;
            if (numOfBoxY % 10 != 0)
                numOfBoxY++;
            int inumOfBoxX = (int)numOfBoxX + 1;
            int inumOfBoxY = (int)numOfBoxY + 1;

            ArrayList[,] holder = new ArrayList[inumOfBoxX, inumOfBoxY];

            int boundingx = minX;
            int boundingy = minY;
            for(int i=0;i<holder.GetLength(0);i++)
            {
                for (int j = 0; j < holder.GetLength(1); j++)
                {
                    ArrayList c = new ArrayList();
                    foreach (points p in pointLocation)
                    {
                        if (p.X >= boundingx && p.X < boundingx + gridSize && p.Y >= boundingy && p.Y < boundingy + gridSize)
                        {
                            c.Add(p);
                        }
                        holder[i, j] = c;
                    }
                    boundingx += gridSize;
                }
                boundingx = minX;
                boundingy += gridSize;
            }
//            ArrayList[,] copyArrayList = new ArrayList[inumOfBoxX,inumOfBoxY];
//            Array.Copy(holder,copyArrayList,inumOfBoxX*inumOfBoxY);
            for(int i=0;i<holder.GetLength(0);i++)
            {
                for(int j=0;j<holder.GetLength(1);j++)
                {
                    holder[i, j] = nearestneighbor(holder[i, j]);
                }
            }
            ArrayList eh = new ArrayList();
            foreach(ArrayList c in holder)
            {
                foreach(points p in c)
                {
                    eh.Add(p);
                }
            }
            Console.WriteLine(eh.Count + " " + pointLocation.Length);
            points[] q = new points[pointLocation.Length];
            for (int i = 0; i < q.Length;i++)
            {
                q[i] = (points)eh[i];
            }
                pointLocation = q;
            getTotalDistance();
        }

        private ArrayList nearestneighbor(ArrayList gridArray)
        {
            for (int i = 0; i < gridArray.Count - 1; i++)
            {
                float minDist = float.MaxValue;
                for (int j = i + 1; j < gridArray.Count; j++)
                {
                    points point1 = (points)gridArray[i];
                    points point2 = (points)gridArray[j];
                    float distance = (float)(Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2)));
                    if (distance < minDist && distance > 0)
                    {
                        minDist = distance;
                        points temp = (points) gridArray[i];
                        gridArray[i] = gridArray[j];
                        gridArray[j] = temp;
                    }
                }
            }
            return gridArray;
        }
    }
}
