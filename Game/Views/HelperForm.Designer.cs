namespace Game.Views
{
    partial class HelperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelperForm));
            this.panelHelper = new System.Windows.Forms.Panel();
            this.labelobstacleInfo = new System.Windows.Forms.Label();
            this.pictureBoxObstacle = new System.Windows.Forms.PictureBox();
            this.labelKillerWhaleInfo = new System.Windows.Forms.Label();
            this.pictureBoxKillerWhale = new System.Windows.Forms.PictureBox();
            this.labelPredatorInfo = new System.Windows.Forms.Label();
            this.pictureBoxPredator = new System.Windows.Forms.PictureBox();
            this.labelPreyInfo = new System.Windows.Forms.Label();
            this.pictureBoxPrey = new System.Windows.Forms.PictureBox();
            this.labelGameInfo = new System.Windows.Forms.Label();
            this.panelHelper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKillerWhale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPredator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrey)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHelper
            // 
            this.panelHelper.Controls.Add(this.labelobstacleInfo);
            this.panelHelper.Controls.Add(this.pictureBoxObstacle);
            this.panelHelper.Controls.Add(this.labelKillerWhaleInfo);
            this.panelHelper.Controls.Add(this.pictureBoxKillerWhale);
            this.panelHelper.Controls.Add(this.labelPredatorInfo);
            this.panelHelper.Controls.Add(this.pictureBoxPredator);
            this.panelHelper.Controls.Add(this.labelPreyInfo);
            this.panelHelper.Controls.Add(this.pictureBoxPrey);
            this.panelHelper.Controls.Add(this.labelGameInfo);
            this.panelHelper.Location = new System.Drawing.Point(12, 12);
            this.panelHelper.Name = "panelHelper";
            this.panelHelper.Size = new System.Drawing.Size(411, 385);
            this.panelHelper.TabIndex = 0;
            // 
            // labelobstacleInfo
            // 
            this.labelobstacleInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelobstacleInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelobstacleInfo.ForeColor = System.Drawing.Color.White;
            this.labelobstacleInfo.Location = new System.Drawing.Point(46, 328);
            this.labelobstacleInfo.Name = "labelobstacleInfo";
            this.labelobstacleInfo.Size = new System.Drawing.Size(366, 78);
            this.labelobstacleInfo.TabIndex = 8;
            this.labelobstacleInfo.Text = "- obstacle.";
            // 
            // pictureBoxObstacle
            // 
            this.pictureBoxObstacle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxObstacle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxObstacle.Image")));
            this.pictureBoxObstacle.Location = new System.Drawing.Point(4, 318);
            this.pictureBoxObstacle.Name = "pictureBoxObstacle";
            this.pictureBoxObstacle.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxObstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxObstacle.TabIndex = 7;
            this.pictureBoxObstacle.TabStop = false;
            // 
            // labelKillerWhaleInfo
            // 
            this.labelKillerWhaleInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelKillerWhaleInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKillerWhaleInfo.ForeColor = System.Drawing.Color.White;
            this.labelKillerWhaleInfo.Location = new System.Drawing.Point(46, 245);
            this.labelKillerWhaleInfo.Name = "labelKillerWhaleInfo";
            this.labelKillerWhaleInfo.Size = new System.Drawing.Size(366, 78);
            this.labelKillerWhaleInfo.TabIndex = 6;
            this.labelKillerWhaleInfo.Text = "- killer whale. She can move and eat prey and predator.\r\n";
            // 
            // pictureBoxKillerWhale
            // 
            this.pictureBoxKillerWhale.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxKillerWhale.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKillerWhale.Image")));
            this.pictureBoxKillerWhale.Location = new System.Drawing.Point(1, 246);
            this.pictureBoxKillerWhale.Name = "pictureBoxKillerWhale";
            this.pictureBoxKillerWhale.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxKillerWhale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKillerWhale.TabIndex = 5;
            this.pictureBoxKillerWhale.TabStop = false;
            // 
            // labelPredatorInfo
            // 
            this.labelPredatorInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelPredatorInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPredatorInfo.ForeColor = System.Drawing.Color.White;
            this.labelPredatorInfo.Location = new System.Drawing.Point(46, 127);
            this.labelPredatorInfo.Name = "labelPredatorInfo";
            this.labelPredatorInfo.Size = new System.Drawing.Size(366, 100);
            this.labelPredatorInfo.TabIndex = 4;
            this.labelPredatorInfo.Text = "\r\n- predator. He can move and reproduce. Also it can eat prey. Will die if he doe" +
    "sn\'t eat\r\n";
            // 
            // pictureBoxPredator
            // 
            this.pictureBoxPredator.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPredator.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPredator.Image")));
            this.pictureBoxPredator.Location = new System.Drawing.Point(3, 156);
            this.pictureBoxPredator.Name = "pictureBoxPredator";
            this.pictureBoxPredator.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxPredator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPredator.TabIndex = 3;
            this.pictureBoxPredator.TabStop = false;
            // 
            // labelPreyInfo
            // 
            this.labelPreyInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelPreyInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPreyInfo.ForeColor = System.Drawing.Color.White;
            this.labelPreyInfo.Location = new System.Drawing.Point(44, 69);
            this.labelPreyInfo.Name = "labelPreyInfo";
            this.labelPreyInfo.Size = new System.Drawing.Size(366, 58);
            this.labelPreyInfo.TabIndex = 2;
            this.labelPreyInfo.Text = "\r\n- prey. She can move and reproduce.";
            // 
            // pictureBoxPrey
            // 
            this.pictureBoxPrey.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPrey.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrey.Image")));
            this.pictureBoxPrey.Location = new System.Drawing.Point(3, 86);
            this.pictureBoxPrey.Name = "pictureBoxPrey";
            this.pictureBoxPrey.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxPrey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPrey.TabIndex = 1;
            this.pictureBoxPrey.TabStop = false;
            // 
            // labelGameInfo
            // 
            this.labelGameInfo.AutoSize = true;
            this.labelGameInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelGameInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGameInfo.ForeColor = System.Drawing.Color.White;
            this.labelGameInfo.Location = new System.Drawing.Point(3, 10);
            this.labelGameInfo.Name = "labelGameInfo";
            this.labelGameInfo.Size = new System.Drawing.Size(366, 50);
            this.labelGameInfo.TabIndex = 0;
            this.labelGameInfo.Text = "This is a simulation game that showcases \r\nlife in the ocean.";
            // 
            // HelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 410);
            this.Controls.Add(this.panelHelper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Life In Ocean";
            this.panelHelper.ResumeLayout(false);
            this.panelHelper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKillerWhale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPredator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHelper;
        private System.Windows.Forms.Label labelPreyInfo;
        private System.Windows.Forms.PictureBox pictureBoxPrey;
        private System.Windows.Forms.Label labelGameInfo;
        private System.Windows.Forms.Label labelPredatorInfo;
        private System.Windows.Forms.PictureBox pictureBoxPredator;
        private System.Windows.Forms.Label labelKillerWhaleInfo;
        private System.Windows.Forms.PictureBox pictureBoxKillerWhale;
        private System.Windows.Forms.Label labelobstacleInfo;
        private System.Windows.Forms.PictureBox pictureBoxObstacle;
    }
}