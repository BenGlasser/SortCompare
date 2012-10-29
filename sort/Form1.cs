using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
namespace sort
{
    public partial class SortCompare : Form 
    {
        const int _gSZ = 100;
        Random myRan = new Random();
        private Rectangle[] myRects = new Rectangle[_gSZ];
        private int comparisons = 0;
        private bool busy = false;

        public SortCompare()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            InitializeComponent();
            buildArr();
            pictureBox.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < _gSZ; i++)
            {
                g.FillRectangle(Brushes.Black, myRects[i]);
            }

        }
        private void buildArr()
        {
            for (int i = 0; i < _gSZ; i++ )
            {
                myRects[i] = new Rectangle(new Point(5, (i+1) * 5), new Size((i+1) * 5, 4));
            }
        }

        private void mixUpButton_Click(object sender, EventArgs e)
        {
            int index1, index2;
            Point temp;
            bool[] chosen = new bool[_gSZ];
            for (int i = 0; i < _gSZ; i++)
            {
                index1 = myRan.Next(_gSZ);
                index2 = myRan.Next(_gSZ);
                while (chosen[index1]) { index1 = myRan.Next(_gSZ); }
                if(!(chosen[index1] && chosen[index2]))
                {
                    chosen[index1] = true;
                    temp = myRects[index1].Location;
                    myRects[index1].Location = myRects[index2].Location;
                    myRects[index2].Location = temp;
                }
                pictureBox.Invalidate();
            }

        }

        private void insertionSort()
        {
            comparisons = 0;
            DateTime start = DateTime.Now;
            for (int i = 1; i < _gSZ; i++)
            {
                for (int j = i; j > 0 && myRects[j].Location.Y < myRects[j-1].Location.Y && addCompare(); j--)
                {
                    swap(j, j - 1);
                    pictureBox.Invalidate();
                    Thread.Sleep(5);
                }
            }
            DateTime end = DateTime.Now;
            if (outBox.InvokeRequired)
            {
                outBox.Invoke(
                  new ThreadStart(delegate
                  {
                      outBox.Items.Insert(0, "Insertion Sort Finished In: " + (end - start).TotalSeconds + " Seconds and Made " + comparisons + " Comparisons");
                }));
            }
            else
            {
                outBox.Items.Insert(0, "Insertion Sort Finished In: " + (end - start).TotalSeconds + " Seconds and Made " + comparisons + " Comparisons");
            }
        }
        private void selectionSort()
        {
            comparisons = 0;
            DateTime start = DateTime.Now;
            for (int i = 0; i < _gSZ; i++)
            {
                int k = i;
                for (int j = i + 1; j < _gSZ; j++)
                {
                    if (myRects[j].Location.Y < myRects[k].Location.Y && addCompare())
                    {
                        k = j;
                        pictureBox.Invalidate();
                        Thread.Sleep(5);
                    }
                }
                swap(i, k);
                pictureBox.Invalidate();
            }
            DateTime end = DateTime.Now;
            if (outBox.InvokeRequired)
            {
                outBox.Invoke(
                  new ThreadStart(delegate
                  {
                      outBox.Items.Insert(0, "Selection Sort Finished In: " + (end - start).TotalSeconds + " Seconds and Made " + comparisons + " Comparisons");
                  }));
            }
            else
            {
                outBox.Items.Insert(0, "Selection Sort Finished In: " + (end - start).TotalSeconds + " Seconds and Made " + comparisons + " Comparisons");
            }
        }
        private void bubble()
        {
            comparisons = 0;
            DateTime start = DateTime.Now;
            for (int i = -1; i < _gSZ; i++)
            {
                bool swapped = false;
                for (int j = _gSZ-1; j > i + 1; j--)
                {
                    if (myRects[j].Location.Y < myRects[j-1].Location.Y && addCompare())
                    {
                        swap(j, j - 1);
                        pictureBox.Invalidate();
                        Thread.Sleep(5);
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
            DateTime end = DateTime.Now;
            if (outBox.InvokeRequired)
            {
                outBox.Invoke(
                  new ThreadStart(delegate
                  {
                      outBox.Items.Insert(0, "Bubble Sort Finished In: " + (end - start).TotalSeconds + " Seconds and Made " + comparisons + " Comparisons");
                  }));
            }
            else
            {
                outBox.Items.Insert(0, "Bubble Sort Finished In: " + (end - start).TotalSeconds + " Seconds and Made " + comparisons + " Comparisons");
            }
        }
        private void merge(int[] myArr)
        {
            comparisons = 0;
            DateTime start = DateTime.Now;
            //split in half
        }
        private void binary()
        {
            DateTime start = DateTime.Now;
            comparisons = 0;
            for (int i = 1; i < myRects.Length; ++i)
            {
                Rectangle temp = myRects[i];
                int left = 0;
                int right = i;
                while (left < right)
                {
                    int middle = (left + right) / 2;
                    if (temp.Location.Y > myRects[middle].Location.Y && addCompare())
                        left = middle + 1;
                    else
                        right = middle;
                }// end while
                for (int j = i; j > left; j--)
                {
                    swap(j, j - 1);
                    pictureBox.Invalidate();
                    Thread.Sleep(5);

                }
            }//end for
            DateTime end = DateTime.Now;
            if (outBox.InvokeRequired)
            {
                outBox.Invoke(
                  new ThreadStart(delegate
                  {
                      outBox.Items.Insert(0, "Binary Sort Finished In: " + (end - start).TotalSeconds + " Seconds and Made " + comparisons + " Comparisons");
                  }));
            }
            else
            {
                outBox.Items.Insert(0, "Binary Sort Finished In: " + (end - start).TotalSeconds + " Seconds and Made " + comparisons + " Comparisons");
            }
        }// end binary
        private void swap(int i, int j)
        {
            Point temp;
            temp = myRects[i].Location;
            myRects[i].Location = myRects[j].Location;
            myRects[j].Location = temp;
            
        }
        private bool addCompare()
        {
            comparisons++;
            return true;
        }

        private void insertionButton_Click(object sender, EventArgs e)
        {
            if (!busy)
            {
                busy = true;
                Thread t = new Thread(new ThreadStart(this.insertionSort));
                t.Start();
            }
            busy = false;
        }
        private void selectionButton_Click(object sender, EventArgs e)
        {
            if (!busy)
            {
                busy = true;
                Thread t = new Thread(new ThreadStart(this.selectionSort));
                t.Start();
            }
            busy = false;
        }

        private void bubbleButton_Click(object sender, EventArgs e)
        {
            if (!busy)
            {
                busy = true;
                Thread t = new Thread(new ThreadStart(this.bubble));
                t.Start();
            }
            busy = false;
        }

        private void binaryButton_Click(object sender, EventArgs e)
        {
            if (!busy)
            {
                busy = true;
                Thread t = new Thread(new ThreadStart(this.binary));
                t.Start();
            }
            busy = false;
        }

    }

}
