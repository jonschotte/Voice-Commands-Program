namespace Voice_Commands_Program
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.WhatB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HowB = new System.Windows.Forms.Button();
            this.WhereB = new System.Windows.Forms.Button();
            this.WhenB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WhatB
            // 
            this.WhatB.BackColor = System.Drawing.SystemColors.Window;
            this.WhatB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhatB.Location = new System.Drawing.Point(287, 179);
            this.WhatB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WhatB.Name = "WhatB";
            this.WhatB.Size = new System.Drawing.Size(330, 34);
            this.WhatB.TabIndex = 2;
            this.WhatB.Text = "What is it?";
            this.WhatB.UseVisualStyleBackColor = false;
            this.WhatB.Click += new System.EventHandler(this.WhatIsIt);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(889, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Say one of the phrases below in order to learn about speech recognition technolog" +
    "y!   \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HowB
            // 
            this.HowB.BackColor = System.Drawing.SystemColors.Window;
            this.HowB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowB.Location = new System.Drawing.Point(287, 237);
            this.HowB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HowB.Name = "HowB";
            this.HowB.Size = new System.Drawing.Size(330, 34);
            this.HowB.TabIndex = 7;
            this.HowB.Text = "How does it work?";
            this.HowB.UseVisualStyleBackColor = false;
            this.HowB.Click += new System.EventHandler(this.HowDoesItWork);
            // 
            // WhereB
            // 
            this.WhereB.BackColor = System.Drawing.SystemColors.Window;
            this.WhereB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhereB.Location = new System.Drawing.Point(287, 292);
            this.WhereB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WhereB.Name = "WhereB";
            this.WhereB.Size = new System.Drawing.Size(330, 34);
            this.WhereB.TabIndex = 8;
            this.WhereB.Text = "Where is it used?";
            this.WhereB.UseVisualStyleBackColor = false;
            this.WhereB.Click += new System.EventHandler(this.WhereB_Click);
            // 
            // WhenB
            // 
            this.WhenB.BackColor = System.Drawing.SystemColors.Window;
            this.WhenB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhenB.Location = new System.Drawing.Point(287, 351);
            this.WhenB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WhenB.Name = "WhenB";
            this.WhenB.Size = new System.Drawing.Size(330, 34);
            this.WhenB.TabIndex = 9;
            this.WhenB.Text = "When did it begin?";
            this.WhenB.UseVisualStyleBackColor = false;
            this.WhenB.Click += new System.EventHandler(this.WhenB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 41);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome!";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(963, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WhenB);
            this.Controls.Add(this.WhereB);
            this.Controls.Add(this.HowB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WhatB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.Text = "Speech Recognition Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button WhatB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HowB;
        private System.Windows.Forms.Button WhereB;
        private System.Windows.Forms.Button WhenB;
        private System.Windows.Forms.Label label2;
    }
}

