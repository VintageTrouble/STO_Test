namespace STO_Test.UI
{
    partial class MainForm
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
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.panelLeftMenuHeader = new System.Windows.Forms.Panel();
            this.labelLogj = new System.Windows.Forms.Label();
            this.panelMainHeader = new System.Windows.Forms.Panel();
            this.panelMainFrame = new System.Windows.Forms.Panel();
            this.buttonCars = new System.Windows.Forms.Button();
            this.buttonWorks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCarCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeftMenu.SuspendLayout();
            this.panelLeftMenuHeader.SuspendLayout();
            this.panelMainHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Controls.Add(this.button1);
            this.panelLeftMenu.Controls.Add(this.buttonWorks);
            this.panelLeftMenu.Controls.Add(this.buttonCars);
            this.panelLeftMenu.Controls.Add(this.panelLeftMenuHeader);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(220, 462);
            this.panelLeftMenu.TabIndex = 0;
            // 
            // panelLeftMenuHeader
            // 
            this.panelLeftMenuHeader.Controls.Add(this.labelLogj);
            this.panelLeftMenuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenuHeader.Name = "panelLeftMenuHeader";
            this.panelLeftMenuHeader.Size = new System.Drawing.Size(220, 114);
            this.panelLeftMenuHeader.TabIndex = 0;
            // 
            // labelLogj
            // 
            this.labelLogj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogj.AutoSize = true;
            this.labelLogj.Location = new System.Drawing.Point(84, 58);
            this.labelLogj.Name = "labelLogj";
            this.labelLogj.Size = new System.Drawing.Size(34, 15);
            this.labelLogj.TabIndex = 0;
            this.labelLogj.Text = "Logo";
            // 
            // panelMainHeader
            // 
            this.panelMainHeader.Controls.Add(this.label1);
            this.panelMainHeader.Controls.Add(this.labelCarCounter);
            this.panelMainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainHeader.Location = new System.Drawing.Point(220, 0);
            this.panelMainHeader.Name = "panelMainHeader";
            this.panelMainHeader.Size = new System.Drawing.Size(564, 50);
            this.panelMainHeader.TabIndex = 1;
            // 
            // panelMainFrame
            // 
            this.panelMainFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainFrame.Location = new System.Drawing.Point(220, 50);
            this.panelMainFrame.Name = "panelMainFrame";
            this.panelMainFrame.Size = new System.Drawing.Size(564, 412);
            this.panelMainFrame.TabIndex = 2;
            // 
            // buttonCars
            // 
            this.buttonCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCars.Location = new System.Drawing.Point(0, 114);
            this.buttonCars.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.buttonCars.Name = "buttonCars";
            this.buttonCars.Size = new System.Drawing.Size(220, 50);
            this.buttonCars.TabIndex = 1;
            this.buttonCars.Text = "Автомобили на станции";
            this.buttonCars.UseVisualStyleBackColor = true;
            // 
            // buttonWorks
            // 
            this.buttonWorks.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWorks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorks.Location = new System.Drawing.Point(0, 164);
            this.buttonWorks.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.buttonWorks.Name = "buttonWorks";
            this.buttonWorks.Size = new System.Drawing.Size(220, 50);
            this.buttonWorks.TabIndex = 2;
            this.buttonWorks.Text = "Список предстоящих работ";
            this.buttonWorks.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 214);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Список выполненных работ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelCarCounter
            // 
            this.labelCarCounter.AutoSize = true;
            this.labelCarCounter.Location = new System.Drawing.Point(6, 9);
            this.labelCarCounter.Name = "labelCarCounter";
            this.labelCarCounter.Size = new System.Drawing.Size(96, 15);
            this.labelCarCounter.TabIndex = 0;
            this.labelCarCounter.Text = "Машин в СТО: х";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Работ предстоит: у";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.panelMainFrame);
            this.Controls.Add(this.panelMainHeader);
            this.Controls.Add(this.panelLeftMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelLeftMenu.ResumeLayout(false);
            this.panelLeftMenuHeader.ResumeLayout(false);
            this.panelLeftMenuHeader.PerformLayout();
            this.panelMainHeader.ResumeLayout(false);
            this.panelMainHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonWorks;
        private System.Windows.Forms.Button buttonCars;
        private System.Windows.Forms.Panel panelLeftMenuHeader;
        private System.Windows.Forms.Label labelLogj;
        private System.Windows.Forms.Panel panelMainHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCarCounter;
        private System.Windows.Forms.Panel panelMainFrame;
    }
}