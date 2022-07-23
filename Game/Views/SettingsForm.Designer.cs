namespace Game.Views
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.obstaclesLabel = new System.Windows.Forms.Label();
            this.predatorsLabel = new System.Windows.Forms.Label();
            this.preyLabel = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.iterationsTextBox = new System.Windows.Forms.TextBox();
            this.textBoxPredators = new System.Windows.Forms.TextBox();
            this.textBoxObstacles = new System.Windows.Forms.TextBox();
            this.textBoxPrey = new System.Windows.Forms.TextBox();
            this.labelKillerWhales = new System.Windows.Forms.Label();
            this.textBoxKillerWhales = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.labelKillerWhales);
            this.panel1.Controls.Add(this.textBoxKillerWhales);
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.labelWarning);
            this.panel1.Controls.Add(this.iterationsLabel);
            this.panel1.Controls.Add(this.obstaclesLabel);
            this.panel1.Controls.Add(this.predatorsLabel);
            this.panel1.Controls.Add(this.preyLabel);
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Controls.Add(this.iterationsTextBox);
            this.panel1.Controls.Add(this.textBoxPredators);
            this.panel1.Controls.Add(this.textBoxObstacles);
            this.panel1.Controls.Add(this.textBoxPrey);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 397);
            this.panel1.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(14, 213);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(195, 50);
            this.labelInfo.TabIndex = 12;
            this.labelInfo.Text = "The max number of \r\ngame objects -> 1500";
            // 
            // labelWarning
            // 
            this.labelWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelWarning.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(3, 276);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(411, 74);
            this.labelWarning.TabIndex = 11;
            this.labelWarning.Text = "Wrong data!";
            this.labelWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelWarning.Visible = false;
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.iterationsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iterationsLabel.ForeColor = System.Drawing.Color.White;
            this.iterationsLabel.Location = new System.Drawing.Point(216, 212);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(185, 25);
            this.iterationsLabel.TabIndex = 10;
            this.iterationsLabel.Text = "Amount of iterations";
            // 
            // obstaclesLabel
            // 
            this.obstaclesLabel.AutoSize = true;
            this.obstaclesLabel.BackColor = System.Drawing.Color.Transparent;
            this.obstaclesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.obstaclesLabel.ForeColor = System.Drawing.Color.White;
            this.obstaclesLabel.Location = new System.Drawing.Point(216, 123);
            this.obstaclesLabel.Name = "obstaclesLabel";
            this.obstaclesLabel.Size = new System.Drawing.Size(184, 25);
            this.obstaclesLabel.TabIndex = 9;
            this.obstaclesLabel.Text = "Amount of obstacles";
            // 
            // predatorsLabel
            // 
            this.predatorsLabel.AutoSize = true;
            this.predatorsLabel.BackColor = System.Drawing.Color.Transparent;
            this.predatorsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.predatorsLabel.ForeColor = System.Drawing.Color.White;
            this.predatorsLabel.Location = new System.Drawing.Point(216, 60);
            this.predatorsLabel.Name = "predatorsLabel";
            this.predatorsLabel.Size = new System.Drawing.Size(187, 25);
            this.predatorsLabel.TabIndex = 8;
            this.predatorsLabel.Text = "Amount of predators";
            // 
            // preyLabel
            // 
            this.preyLabel.AutoSize = true;
            this.preyLabel.BackColor = System.Drawing.Color.Transparent;
            this.preyLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.preyLabel.ForeColor = System.Drawing.Color.White;
            this.preyLabel.Location = new System.Drawing.Point(14, 60);
            this.preyLabel.Name = "preyLabel";
            this.preyLabel.Size = new System.Drawing.Size(143, 25);
            this.preyLabel.TabIndex = 7;
            this.preyLabel.Text = "Amount of prey";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(99, 13);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(206, 39);
            this.labelHeader.TabIndex = 6;
            this.labelHeader.Text = "Game settings";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(3, 353);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 26);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(299, 353);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(104, 26);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.Location = new System.Drawing.Point(236, 240);
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.Size = new System.Drawing.Size(131, 23);
            this.iterationsTextBox.TabIndex = 3;
            // 
            // textBoxPredators
            // 
            this.textBoxPredators.Location = new System.Drawing.Point(236, 88);
            this.textBoxPredators.Name = "textBoxPredators";
            this.textBoxPredators.Size = new System.Drawing.Size(131, 23);
            this.textBoxPredators.TabIndex = 2;
            // 
            // textBoxObstacles
            // 
            this.textBoxObstacles.Location = new System.Drawing.Point(236, 162);
            this.textBoxObstacles.Name = "textBoxObstacles";
            this.textBoxObstacles.Size = new System.Drawing.Size(131, 23);
            this.textBoxObstacles.TabIndex = 1;
            // 
            // textBoxPrey
            // 
            this.textBoxPrey.Location = new System.Drawing.Point(18, 88);
            this.textBoxPrey.Name = "textBoxPrey";
            this.textBoxPrey.Size = new System.Drawing.Size(131, 23);
            this.textBoxPrey.TabIndex = 0;
            // 
            // labelKillerWhales
            // 
            this.labelKillerWhales.AutoSize = true;
            this.labelKillerWhales.BackColor = System.Drawing.Color.Transparent;
            this.labelKillerWhales.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKillerWhales.ForeColor = System.Drawing.Color.White;
            this.labelKillerWhales.Location = new System.Drawing.Point(3, 123);
            this.labelKillerWhales.Name = "labelKillerWhales";
            this.labelKillerWhales.Size = new System.Drawing.Size(210, 25);
            this.labelKillerWhales.TabIndex = 14;
            this.labelKillerWhales.Text = "Amount of killer whales";
            // 
            // textBoxKillerWhales
            // 
            this.textBoxKillerWhales.Location = new System.Drawing.Point(18, 162);
            this.textBoxKillerWhales.Name = "textBoxKillerWhales";
            this.textBoxKillerWhales.Size = new System.Drawing.Size(131, 23);
            this.textBoxKillerWhales.TabIndex = 13;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(441, 425);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Life In Ocean";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox iterationsTextBox;
        private System.Windows.Forms.TextBox textBoxPredators;
        private System.Windows.Forms.TextBox textBoxObstacles;
        private System.Windows.Forms.TextBox textBoxPrey;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label preyLabel;
        private System.Windows.Forms.Label iterationsLabel;
        private System.Windows.Forms.Label obstaclesLabel;
        private System.Windows.Forms.Label predatorsLabel;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelKillerWhales;
        private System.Windows.Forms.TextBox textBoxKillerWhales;
    }
}