namespace PasswordGenerator
{
    partial class Top
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
            this.tbDisplay = new System.Windows.Forms.RichTextBox();
            this.tbThis = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.rbPronouncable = new System.Windows.Forms.RadioButton();
            this.rbXkcd = new System.Windows.Forms.RadioButton();
            this.cbNumber = new System.Windows.Forms.CheckBox();
            this.cbCap = new System.Windows.Forms.CheckBox();
            this.cbSpecial = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplay.Location = new System.Drawing.Point(28, 37);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(466, 196);
            this.tbDisplay.TabIndex = 0;
            this.tbDisplay.Text = "";
            // 
            // tbThis
            // 
            this.tbThis.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThis.Location = new System.Drawing.Point(28, 265);
            this.tbThis.Name = "tbThis";
            this.tbThis.Size = new System.Drawing.Size(466, 28);
            this.tbThis.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(418, 467);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 35);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(336, 467);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 35);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Location = new System.Drawing.Point(28, 306);
            this.rbSimple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(82, 24);
            this.rbSimple.TabIndex = 6;
            this.rbSimple.TabStop = true;
            this.rbSimple.Text = "Simple";
            this.rbSimple.UseVisualStyleBackColor = true;
            // 
            // rbPronouncable
            // 
            this.rbPronouncable.AutoSize = true;
            this.rbPronouncable.Location = new System.Drawing.Point(28, 342);
            this.rbPronouncable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPronouncable.Name = "rbPronouncable";
            this.rbPronouncable.Size = new System.Drawing.Size(132, 24);
            this.rbPronouncable.TabIndex = 7;
            this.rbPronouncable.TabStop = true;
            this.rbPronouncable.Text = "Pronouncable";
            this.rbPronouncable.UseVisualStyleBackColor = true;
            // 
            // rbXkcd
            // 
            this.rbXkcd.AutoSize = true;
            this.rbXkcd.Location = new System.Drawing.Point(28, 377);
            this.rbXkcd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbXkcd.Name = "rbXkcd";
            this.rbXkcd.Size = new System.Drawing.Size(66, 24);
            this.rbXkcd.TabIndex = 8;
            this.rbXkcd.TabStop = true;
            this.rbXkcd.Text = "xkcd";
            this.rbXkcd.UseVisualStyleBackColor = true;
            // 
            // cbNumber
            // 
            this.cbNumber.AutoSize = true;
            this.cbNumber.Checked = true;
            this.cbNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNumber.Location = new System.Drawing.Point(336, 317);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(143, 24);
            this.cbNumber.TabIndex = 9;
            this.cbNumber.Text = "include number";
            this.cbNumber.UseVisualStyleBackColor = true;
            // 
            // cbCap
            // 
            this.cbCap.AutoSize = true;
            this.cbCap.Checked = true;
            this.cbCap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCap.Location = new System.Drawing.Point(336, 348);
            this.cbCap.Name = "cbCap";
            this.cbCap.Size = new System.Drawing.Size(135, 24);
            this.cbCap.TabIndex = 10;
            this.cbCap.Text = "include capitol";
            this.cbCap.UseVisualStyleBackColor = true;
            // 
            // cbSpecial
            // 
            this.cbSpecial.AutoSize = true;
            this.cbSpecial.Checked = true;
            this.cbSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpecial.Location = new System.Drawing.Point(336, 379);
            this.cbSpecial.Name = "cbSpecial";
            this.cbSpecial.Size = new System.Drawing.Size(138, 24);
            this.cbSpecial.TabIndex = 11;
            this.cbSpecial.Text = "include special";
            this.cbSpecial.UseVisualStyleBackColor = true;
            // 
            // Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 525);
            this.Controls.Add(this.cbSpecial);
            this.Controls.Add(this.cbCap);
            this.Controls.Add(this.cbNumber);
            this.Controls.Add(this.rbXkcd);
            this.Controls.Add(this.rbPronouncable);
            this.Controls.Add(this.rbSimple);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbThis);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Top";
            this.Text = "PasswordGenerator";
            this.Load += new System.EventHandler(this.Top_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbDisplay;
        private System.Windows.Forms.TextBox tbThis;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.RadioButton rbPronouncable;
        private System.Windows.Forms.RadioButton rbXkcd;
        private System.Windows.Forms.CheckBox cbNumber;
        private System.Windows.Forms.CheckBox cbCap;
        private System.Windows.Forms.CheckBox cbSpecial;
    }
}

