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
            this.label2 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.obstaclesLabel = new System.Windows.Forms.Label();
            this.predatorsLabel = new System.Windows.Forms.Label();
            this.preyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.iterationsTextBox = new System.Windows.Forms.TextBox();
            this.predatorsTextBox = new System.Windows.Forms.TextBox();
            this.obstaclesTextBox = new System.Windows.Forms.TextBox();
            this.preyTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.warningLabel);
            this.panel1.Controls.Add(this.iterationsLabel);
            this.panel1.Controls.Add(this.obstaclesLabel);
            this.panel1.Controls.Add(this.predatorsLabel);
            this.panel1.Controls.Add(this.preyLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.applyButton);
            this.panel1.Controls.Add(this.iterationsTextBox);
            this.panel1.Controls.Add(this.predatorsTextBox);
            this.panel1.Controls.Add(this.obstaclesTextBox);
            this.panel1.Controls.Add(this.preyTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 418);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(208, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 50);
            this.label2.TabIndex = 12;
            this.label2.Text = "The max number of \r\ngame objects -> 1500";
            // 
            // warningLabel
            // 
            this.warningLabel.BackColor = System.Drawing.Color.Transparent;
            this.warningLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(195, 194);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(215, 169);
            this.warningLabel.TabIndex = 11;
            this.warningLabel.Text = "Wrong data!";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.warningLabel.Visible = false;
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.iterationsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iterationsLabel.ForeColor = System.Drawing.Color.White;
            this.iterationsLabel.Location = new System.Drawing.Point(4, 274);
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
            this.obstaclesLabel.Location = new System.Drawing.Point(5, 215);
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
            this.predatorsLabel.Location = new System.Drawing.Point(2, 146);
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
            this.preyLabel.Location = new System.Drawing.Point(18, 87);
            this.preyLabel.Name = "preyLabel";
            this.preyLabel.Size = new System.Drawing.Size(143, 25);
            this.preyLabel.TabIndex = 7;
            this.preyLabel.Text = "Amount of prey";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Game settings";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(18, 366);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(104, 26);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(299, 366);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(104, 26);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.Location = new System.Drawing.Point(22, 302);
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.Size = new System.Drawing.Size(131, 23);
            this.iterationsTextBox.TabIndex = 3;
            // 
            // predatorsTextBox
            // 
            this.predatorsTextBox.Location = new System.Drawing.Point(22, 174);
            this.predatorsTextBox.Name = "predatorsTextBox";
            this.predatorsTextBox.Size = new System.Drawing.Size(131, 23);
            this.predatorsTextBox.TabIndex = 2;
            // 
            // obstaclesTextBox
            // 
            this.obstaclesTextBox.Location = new System.Drawing.Point(22, 243);
            this.obstaclesTextBox.Name = "obstaclesTextBox";
            this.obstaclesTextBox.Size = new System.Drawing.Size(131, 23);
            this.obstaclesTextBox.TabIndex = 1;
            // 
            // preyTextBox
            // 
            this.preyTextBox.Location = new System.Drawing.Point(22, 115);
            this.preyTextBox.Name = "preyTextBox";
            this.preyTextBox.Size = new System.Drawing.Size(131, 23);
            this.preyTextBox.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(441, 454);
            this.Controls.Add(this.panel1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox iterationsTextBox;
        private System.Windows.Forms.TextBox predatorsTextBox;
        private System.Windows.Forms.TextBox obstaclesTextBox;
        private System.Windows.Forms.TextBox preyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label preyLabel;
        private System.Windows.Forms.Label iterationsLabel;
        private System.Windows.Forms.Label obstaclesLabel;
        private System.Windows.Forms.Label predatorsLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label label2;
    }
}