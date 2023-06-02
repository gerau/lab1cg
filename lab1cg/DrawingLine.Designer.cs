namespace lab1cg
{
    partial class DrawingLine
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingLine));
            this.DrawingZone = new System.Windows.Forms.PictureBox();
            this.x0 = new System.Windows.Forms.TextBox();
            this.y0 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.x0label = new System.Windows.Forms.Label();
            this.y0label = new System.Windows.Forms.Label();
            this.x1label = new System.Windows.Forms.Label();
            this.y1label = new System.Windows.Forms.Label();
            this.createLineButton = new System.Windows.Forms.Button();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.colorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingZone)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawingZone
            // 
            resources.ApplyResources(this.DrawingZone, "DrawingZone");
            this.DrawingZone.Name = "DrawingZone";
            this.DrawingZone.TabStop = false;
            // 
            // x0
            // 
            resources.ApplyResources(this.x0, "x0");
            this.x0.Name = "x0";
            // 
            // y0
            // 
            resources.ApplyResources(this.y0, "y0");
            this.y0.Name = "y0";
            // 
            // y1
            // 
            resources.ApplyResources(this.y1, "y1");
            this.y1.Name = "y1";
            // 
            // x1
            // 
            resources.ApplyResources(this.x1, "x1");
            this.x1.Name = "x1";
            // 
            // x0label
            // 
            resources.ApplyResources(this.x0label, "x0label");
            this.x0label.Name = "x0label";
            // 
            // y0label
            // 
            resources.ApplyResources(this.y0label, "y0label");
            this.y0label.Name = "y0label";
            // 
            // x1label
            // 
            resources.ApplyResources(this.x1label, "x1label");
            this.x1label.Name = "x1label";
            // 
            // y1label
            // 
            resources.ApplyResources(this.y1label, "y1label");
            this.y1label.Name = "y1label";
            // 
            // createLineButton
            // 
            this.createLineButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.createLineButton, "createLineButton");
            this.createLineButton.Name = "createLineButton";
            this.createLineButton.UseVisualStyleBackColor = false;
            this.createLineButton.Click += new System.EventHandler(this.createLineButton_Click);
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.ColorComboBox, "ColorComboBox");
            this.ColorComboBox.Name = "ColorComboBox";
            // 
            // colorLabel
            // 
            resources.ApplyResources(this.colorLabel, "colorLabel");
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DrawingLine
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.createLineButton);
            this.Controls.Add(this.y1label);
            this.Controls.Add(this.x1label);
            this.Controls.Add(this.y0label);
            this.Controls.Add(this.x0label);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.y0);
            this.Controls.Add(this.x0);
            this.Controls.Add(this.DrawingZone);
            this.Name = "DrawingLine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.DrawingZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox DrawingZone;
        private TextBox x0;
        private TextBox y0;
        private TextBox y1;
        private TextBox x1;
        private Label x0label;
        private Label y0label;
        private Label x1label;
        private Label y1label;
        private Button createLineButton;
        private ComboBox ColorComboBox;
        private Label colorLabel;
    }
}