namespace Fifteen
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
            this.panelFishes = new System.Windows.Forms.Panel();
            this.panelUpper = new System.Windows.Forms.Panel();
            this.panelMinimize = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUpper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFishes
            // 
            this.panelFishes.Location = new System.Drawing.Point(5, 25);
            this.panelFishes.Name = "panelFishes";
            this.panelFishes.Size = new System.Drawing.Size(440, 347);
            this.panelFishes.TabIndex = 0;
            this.panelFishes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fishPanel_MouseClick);
            // 
            // panelUpper
            // 
            this.panelUpper.BackColor = System.Drawing.Color.Black;
            this.panelUpper.Controls.Add(this.label1);
            this.panelUpper.Controls.Add(this.panelMinimize);
            this.panelUpper.Controls.Add(this.panelClose);
            this.panelUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpper.Location = new System.Drawing.Point(0, 0);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(608, 20);
            this.panelUpper.TabIndex = 1;
            this.panelUpper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUpper_MouseDown);
            this.panelUpper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUpper_MouseMove);
            this.panelUpper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelUpper_MouseUp);
            // 
            // panelMinimize
            // 
            this.panelMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMinimize.BackColor = System.Drawing.Color.DimGray;
            this.panelMinimize.Location = new System.Drawing.Point(557, 0);
            this.panelMinimize.Name = "panelMinimize";
            this.panelMinimize.Size = new System.Drawing.Size(20, 17);
            this.panelMinimize.TabIndex = 1;
            this.panelMinimize.Click += new System.EventHandler(this.panelMinimize_Click);
            this.panelMinimize.MouseEnter += new System.EventHandler(this.panelMinimize_MouseEnter);
            this.panelMinimize.MouseLeave += new System.EventHandler(this.panelMinimize_MouseLeave);
            // 
            // panelClose
            // 
            this.panelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClose.BackColor = System.Drawing.Color.Maroon;
            this.panelClose.Location = new System.Drawing.Point(583, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(20, 17);
            this.panelClose.TabIndex = 0;
            this.panelClose.Click += new System.EventHandler(this.Pan_Close_Click);
            this.panelClose.MouseEnter += new System.EventHandler(this.Pan_Close_MouseEnter);
            this.panelClose.MouseLeave += new System.EventHandler(this.Pan_Close_MouseLeave);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Black;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 549);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(608, 2);
            this.panelBottom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fifteens";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 551);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelUpper);
            this.Controls.Add(this.panelFishes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelUpper.ResumeLayout(false);
            this.panelUpper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFishes;
        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel panelMinimize;
        private System.Windows.Forms.Label label1;



    }
}

