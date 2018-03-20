using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Threading;


namespace Petshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (petShop_Label != null)
            {
                int frames = 10;

                for (int i = 1; i <= frames; i++)
                {
                    if (i % 2 == 0)
                    {
                        Point p = petShop_Label.Location;
                        p.Y -= 5;
                        petShop_Label.Location = p;
                    }
                    WAIT(0.01f);

                }

                if (petShop_Label.Location.Y <= -petShop_Label.Size.Height)
                    {
                        petShop_Label.Parent = null;
                        WAIT(0.1f);
                    }
            }
            else timer1.Enabled = false;
        }


        private void petShop_Label_LocationChanged(object sender, EventArgs e)
        {
            if (petShop_Label.Location.Y <= -petShop_Label.Size.Height)
            {
                CreateSpaceForItems();
            }
        }

        public void WAIT(float amountOfSeconds)
        {
            int miliseconds = (int)amountOfSeconds * 1000;
            Thread.Sleep(miliseconds);
        }

        public void CreateSpaceForItems()
        {
            FlowLayoutPanel flp = new FlowLayoutPanel();
            Form1.ActiveForm.Controls.Add(flp);
            flp.Dock = DockStyle.Fill;
            flp.AutoScroll = true;
            flp.FlowDirection = FlowDirection.LeftToRight;
            flp.BackColor = Color.Transparent;

            for (int i = 1; i <= 10; i++)
            {
                Category cat = new Category();

                cat.categoryPanel.Parent = flp;
                flp.Controls.Add(cat.categoryPanel);
             
                ModifyClassForFitting(cat);
            }

        }

        public void ModifyClassForFitting(Category cat)
        {
            cat.categoryPanel.Size = new Size(310, 100);
            cat.categoryPanel.BorderStyle = BorderStyle.FixedSingle;
   
            cat.categoryPanel.BackColor = Color.LightYellow;
         
        }



        private void petShop_Label_Paint(object sender, PaintEventArgs e)
        {
            // ADD A 2 SECONDS SOUND FOR translation 

        }

        private void petShop_Label_ParentChanged(object sender, EventArgs e)
        {
            if(petShop_Label.Parent == null)
            {
                Form1.ActiveForm.Controls.Remove(petShop_Label);
            }
        }
    }
    

}
