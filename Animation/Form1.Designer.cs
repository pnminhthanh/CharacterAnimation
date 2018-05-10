namespace Animation
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
            this.animationCtrl1 = new Animation.AnimationCtrl();
            this.animationCtrl2 = new Animation.AnimationCtrl();
            this.SuspendLayout();
            // 
            // animationCtrl1
            // 
            this.animationCtrl1.BackColor = System.Drawing.SystemColors.Control;
            this.animationCtrl1.Location = new System.Drawing.Point(76, 51);
            this.animationCtrl1.Name = "animationCtrl1";
            this.animationCtrl1.Size = new System.Drawing.Size(150, 150);
            this.animationCtrl1.TabIndex = 0;
            this.animationCtrl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.animationCtrl1_KeyDown);
            this.animationCtrl1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.animationCtrl1_PreviewKeyDown);
            // 
            // animationCtrl2
            // 
            this.animationCtrl2.Location = new System.Drawing.Point(178, 68);
            this.animationCtrl2.Name = "animationCtrl2";
            this.animationCtrl2.Size = new System.Drawing.Size(150, 150);
            this.animationCtrl2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 392);
            this.Controls.Add(this.animationCtrl1);
            this.Controls.Add(this.animationCtrl2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private AnimationCtrl animationCtrl1;
        private AnimationCtrl animationCtrl2;
    }
}

