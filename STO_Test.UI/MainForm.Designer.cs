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
            this.buttonWorksComplete = new System.Windows.Forms.Button();
            this.buttonWorks = new System.Windows.Forms.Button();
            this.buttonCars = new System.Windows.Forms.Button();
            this.panelLeftMenuHeader = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelMainHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCarCounter = new System.Windows.Forms.Label();
            this.panelMainFrame = new System.Windows.Forms.Panel();
            this.buttonEployees = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.labelWorksToDo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLeftMenu.SuspendLayout();
            this.panelLeftMenuHeader.SuspendLayout();
            this.panelMainHeader.SuspendLayout();
            this.panelMainFrame.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panelLeftMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeftMenu.Controls.Add(this.buttonEployees);
            this.panelLeftMenu.Controls.Add(this.buttonWorksComplete);
            this.panelLeftMenu.Controls.Add(this.buttonWorks);
            this.panelLeftMenu.Controls.Add(this.buttonCars);
            this.panelLeftMenu.Controls.Add(this.panelLeftMenuHeader);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(220, 462);
            this.panelLeftMenu.TabIndex = 0;
            // 
            // buttonWorksComplete
            // 
            this.buttonWorksComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.buttonWorksComplete.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWorksComplete.FlatAppearance.BorderSize = 0;
            this.buttonWorksComplete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.buttonWorksComplete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonWorksComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorksComplete.Location = new System.Drawing.Point(0, 214);
            this.buttonWorksComplete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonWorksComplete.Name = "buttonWorksComplete";
            this.buttonWorksComplete.Size = new System.Drawing.Size(218, 50);
            this.buttonWorksComplete.TabIndex = 3;
            this.buttonWorksComplete.Text = "Список выполненных работ";
            this.buttonWorksComplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWorksComplete.UseVisualStyleBackColor = false;
            // 
            // buttonWorks
            // 
            this.buttonWorks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.buttonWorks.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWorks.FlatAppearance.BorderSize = 0;
            this.buttonWorks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.buttonWorks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonWorks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorks.Location = new System.Drawing.Point(0, 164);
            this.buttonWorks.Margin = new System.Windows.Forms.Padding(0);
            this.buttonWorks.Name = "buttonWorks";
            this.buttonWorks.Size = new System.Drawing.Size(218, 50);
            this.buttonWorks.TabIndex = 2;
            this.buttonWorks.Text = "Список предстоящих работ";
            this.buttonWorks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWorks.UseVisualStyleBackColor = false;
            // 
            // buttonCars
            // 
            this.buttonCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.buttonCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCars.FlatAppearance.BorderSize = 0;
            this.buttonCars.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.buttonCars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCars.Location = new System.Drawing.Point(0, 114);
            this.buttonCars.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCars.Name = "buttonCars";
            this.buttonCars.Size = new System.Drawing.Size(218, 50);
            this.buttonCars.TabIndex = 1;
            this.buttonCars.Text = "Автомобили на станции";
            this.buttonCars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCars.UseVisualStyleBackColor = false;
            // 
            // panelLeftMenuHeader
            // 
            this.panelLeftMenuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelLeftMenuHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeftMenuHeader.Controls.Add(this.labelLogo);
            this.panelLeftMenuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenuHeader.Name = "panelLeftMenuHeader";
            this.panelLeftMenuHeader.Size = new System.Drawing.Size(218, 114);
            this.panelLeftMenuHeader.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogo.AutoSize = true;
            this.labelLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.Location = new System.Drawing.Point(47, 24);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(111, 51);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "Logo";
            // 
            // panelMainHeader
            // 
            this.panelMainHeader.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelMainHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainHeader.Controls.Add(this.label1);
            this.panelMainHeader.Controls.Add(this.labelCarCounter);
            this.panelMainHeader.Location = new System.Drawing.Point(220, 0);
            this.panelMainHeader.Name = "panelMainHeader";
            this.panelMainHeader.Size = new System.Drawing.Size(564, 50);
            this.panelMainHeader.TabIndex = 1;
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
            // labelCarCounter
            // 
            this.labelCarCounter.AutoSize = true;
            this.labelCarCounter.Location = new System.Drawing.Point(6, 9);
            this.labelCarCounter.Name = "labelCarCounter";
            this.labelCarCounter.Size = new System.Drawing.Size(96, 15);
            this.labelCarCounter.TabIndex = 0;
            this.labelCarCounter.Text = "Машин в СТО: х";
            // 
            // panelMainFrame
            // 
            this.panelMainFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainFrame.Controls.Add(this.panelTopBar);
            this.panelMainFrame.Controls.Add(this.label2);
            this.panelMainFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainFrame.Location = new System.Drawing.Point(220, 0);
            this.panelMainFrame.Name = "panelMainFrame";
            this.panelMainFrame.Size = new System.Drawing.Size(564, 462);
            this.panelMainFrame.TabIndex = 2;
            // 
            // buttonEployees
            // 
            this.buttonEployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.buttonEployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEployees.FlatAppearance.BorderSize = 0;
            this.buttonEployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.buttonEployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonEployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEployees.Location = new System.Drawing.Point(0, 264);
            this.buttonEployees.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEployees.Name = "buttonEployees";
            this.buttonEployees.Size = new System.Drawing.Size(218, 50);
            this.buttonEployees.TabIndex = 4;
            this.buttonEployees.Text = "Сотрудники";
            this.buttonEployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEployees.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(132, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logo Main Page";
            // 
            // panelTopBar
            // 
            this.panelTopBar.Controls.Add(this.label3);
            this.panelTopBar.Controls.Add(this.labelWorksToDo);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(562, 55);
            this.panelTopBar.TabIndex = 2;
            // 
            // labelWorksToDo
            // 
            this.labelWorksToDo.AutoSize = true;
            this.labelWorksToDo.Location = new System.Drawing.Point(7, 8);
            this.labelWorksToDo.Name = "labelWorksToDo";
            this.labelWorksToDo.Size = new System.Drawing.Size(109, 15);
            this.labelWorksToDo.TabIndex = 0;
            this.labelWorksToDo.Text = "Работ предстоит: х";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Машин на станции: у";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.panelMainFrame);
            this.Controls.Add(this.panelMainHeader);
            this.Controls.Add(this.panelLeftMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelLeftMenu.ResumeLayout(false);
            this.panelLeftMenuHeader.ResumeLayout(false);
            this.panelLeftMenuHeader.PerformLayout();
            this.panelMainHeader.ResumeLayout(false);
            this.panelMainHeader.PerformLayout();
            this.panelMainFrame.ResumeLayout(false);
            this.panelMainFrame.PerformLayout();
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Button buttonWorksComplete;
        private System.Windows.Forms.Button buttonWorks;
        private System.Windows.Forms.Button buttonCars;
        private System.Windows.Forms.Panel panelLeftMenuHeader;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panelMainHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCarCounter;
        private System.Windows.Forms.Panel panelMainFrame;
        private System.Windows.Forms.Button buttonEployees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWorksToDo;
    }
}