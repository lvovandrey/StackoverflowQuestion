using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


           
                objects = new List<MapObject2>();
                objects.Add(new MapObject2()
                {
                    Name = "Мумия",
                    X = 0,
                    Y = 0,
                    Width = 100,
                    Height = 100
                });

                objects.Add(new MapObject2()
                {
                    Name = "Банка",
                    X = 100,
                    Y = 0,
                    Width = 100,
                    Height = 100
                });

                objects.Add(new MapObject2()
                {
                    Name = "Змеи",
                    X = 200,
                    Y = 0,
                    Width = 100,
                    Height = 100
                });

                objects.Add(new MapObject2()
                {
                    Name = "Царь",
                    X = 300,
                    Y = 0,
                    Width = 100,
                    Height = 100
                });

                objects.Add(new MapObject2()
                {
                    Name = "Колесница",
                    X = 400,
                    Y = 0,
                    Width = 100,
                    Height = 100
                });

                objects.Add(new MapObject2()
                {
                    Name = "Конь",
                    X = 500,
                    Y = 0,
                    Width = 100,
                    Height = 100
                });
            
        }

        List<MapObject2> objects;

       

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int currentX = e.X;
            int currentY = e.Y;
            for (int i = 0; i < objects.Count; i++)
            {
                if (currentX > (objects[i].X - objects[i].Width / 2) & currentX < (objects[i].X + objects[i].Width / 2)
                & currentY > (objects[i].Y - objects[i].Height / 2) & currentY < (objects[i].Y + objects[i].Height / 2))
                {
                    MessageBox.Show("Ты нашел слово: " + objects[i].Name);
                    objects[i].IsClicked = true;
                }
            }

            if (IsAllClicked()) MessageBox.Show("Все объекты прокликаны");
        }

        private bool IsAllClicked()
        {
            bool AllObjectsClicked = true;
            foreach (MapObject2 item in objects)
            {
                if (!item.IsClicked)
                {
                    AllObjectsClicked = false; break;
                }
            }
            return AllObjectsClicked;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           label1.Text = e.X.ToString();


            int find = -1;
            int currentX = e.X;
            int currentY = e.Y;
            for (int i = 0; i < objects.Count; i++)
            {
                if (currentX > (objects[i].X - objects[i].Width / 2) & currentX < (objects[i].X + objects[i].Width / 2)
                & currentY > (objects[i].Y - objects[i].Height / 2) & currentY < (objects[i].Y + objects[i].Height / 2))
                {
                    find = i;
                }
            }
            if (find >= 0) label2.Text = objects[find].Name;
            else label2.Text = "---";

        }


    }
}
