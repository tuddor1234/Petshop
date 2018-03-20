using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Petshop
{
   public class Category
    {
       public Panel categoryPanel = new Panel();
       public OvalPictureBox ovalPicture = new OvalPictureBox();
        
        public Category()
        {
            ovalPicture.Parent = categoryPanel;
           
          //  ovalPicture.Image = Image.FromFile();
           // categoryPanel.Size = new Size(60, 100);
           // categoryPanel.BackColor = Color.Aqua;
        }


        public void ItemAdded()
        {

        }
       
    }
}
