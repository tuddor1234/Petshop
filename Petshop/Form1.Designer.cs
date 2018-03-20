namespace Petshop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.petShop_Label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // petShop_Label
            // 
            this.petShop_Label.AutoSize = true;
            this.petShop_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.petShop_Label.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.petShop_Label.Location = new System.Drawing.Point(120, 255);
            this.petShop_Label.Name = "petShop_Label";
            this.petShop_Label.Size = new System.Drawing.Size(113, 34);
            this.petShop_Label.TabIndex = 0;
            this.petShop_Label.Text = "Petshop";
            this.petShop_Label.LocationChanged += new System.EventHandler(this.petShop_Label_LocationChanged);
            this.petShop_Label.Paint += new System.Windows.Forms.PaintEventHandler(this.petShop_Label_Paint);
            this.petShop_Label.ParentChanged += new System.EventHandler(this.petShop_Label_ParentChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(344, 577);
            this.Controls.Add(this.petShop_Label);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petshop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label petShop_Label;
        private System.Windows.Forms.Timer timer1;
    }
}

