namespace Hitman
{
    partial class Hitman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hitman));
            this.hitmanLabel = new System.Windows.Forms.Label();
            this.eventOutput = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eventpicOutput = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventpicOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // hitmanLabel
            // 
            this.hitmanLabel.BackColor = System.Drawing.SystemColors.Control;
            this.hitmanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.hitmanLabel.Location = new System.Drawing.Point(0, -3);
            this.hitmanLabel.Name = "hitmanLabel";
            this.hitmanLabel.Size = new System.Drawing.Size(960, 43);
            this.hitmanLabel.TabIndex = 0;
            this.hitmanLabel.Text = "Hitman";
            this.hitmanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // eventOutput
            // 
            this.eventOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.eventOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventOutput.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.eventOutput.Location = new System.Drawing.Point(28, 53);
            this.eventOutput.Name = "eventOutput";
            this.eventOutput.Size = new System.Drawing.Size(255, 383);
            this.eventOutput.TabIndex = 1;
            this.eventOutput.Text = "You are an infamous hitman and have been tasked to hunt down a target somewhere o" +
    "ut here in the woods. Word has it he is never alone, so think twice about your d" +
    "ecisions... Go North or South?";
            // 
            // redLabel
            // 
            this.redLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.redLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.redLabel.Location = new System.Drawing.Point(379, 124);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(212, 23);
            this.redLabel.TabIndex = 3;
            this.redLabel.Text = "Go South";
            // 
            // blueLabel
            // 
            this.blueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blueLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.blueLabel.Location = new System.Drawing.Point(379, 230);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(212, 23);
            this.blueLabel.TabIndex = 4;
            this.blueLabel.Text = "Go North";
            // 
            // greenLabel
            // 
            this.greenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.greenLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.greenLabel.Location = new System.Drawing.Point(379, 340);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(212, 23);
            this.greenLabel.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(296, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(296, 319);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(296, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // eventpicOutput
            // 
            this.eventpicOutput.BackgroundImage = global::Hitman.Properties.Resources.forest;
            this.eventpicOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eventpicOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.eventpicOutput.Location = new System.Drawing.Point(597, 53);
            this.eventpicOutput.Name = "eventpicOutput";
            this.eventpicOutput.Size = new System.Drawing.Size(351, 393);
            this.eventpicOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eventpicOutput.TabIndex = 11;
            this.eventpicOutput.TabStop = false;
            // 
            // Hitman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(960, 478);
            this.Controls.Add(this.eventpicOutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.eventOutput);
            this.Controls.Add(this.hitmanLabel);
            this.Name = "Hitman";
            this.Text = "Hitman";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventpicOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hitmanLabel;
        private System.Windows.Forms.Label eventOutput;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox eventpicOutput;
    }
}

