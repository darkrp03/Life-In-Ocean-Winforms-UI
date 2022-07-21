namespace Game.Views
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameField = new System.Windows.Forms.DataGridView();
            this.labelInfo = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.resetGameButton = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gameField)).BeginInit();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameField
            // 
            this.gameField.AllowUserToAddRows = false;
            this.gameField.AllowUserToDeleteRows = false;
            this.gameField.AllowUserToResizeColumns = false;
            this.gameField.AllowUserToResizeRows = false;
            this.gameField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameField.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gameField.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.gameField.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gameField.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gameField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gameField.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gameField.DefaultCellStyle = dataGridViewCellStyle6;
            this.gameField.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gameField.Enabled = false;
            this.gameField.EnableHeadersVisualStyles = false;
            this.gameField.GridColor = System.Drawing.Color.White;
            this.gameField.Location = new System.Drawing.Point(22, 178);
            this.gameField.MultiSelect = false;
            this.gameField.Name = "gameField";
            this.gameField.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gameField.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gameField.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            this.gameField.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gameField.RowTemplate.Height = 25;
            this.gameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gameField.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gameField.Size = new System.Drawing.Size(1318, 390);
            this.gameField.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(0, 26);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(642, 74);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Iterations: 0  Prey: 0  Predators: 0  Obstacles: 0\r\n     ";
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.BackColor = System.Drawing.Color.Gold;
            this.stopButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.stopButton.FlatAppearance.BorderSize = 2;
            this.stopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.ForeColor = System.Drawing.Color.Black;
            this.stopButton.Location = new System.Drawing.Point(721, 26);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(159, 36);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            // 
            // continueButton
            // 
            this.continueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.continueButton.BackColor = System.Drawing.Color.Gold;
            this.continueButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.continueButton.FlatAppearance.BorderSize = 2;
            this.continueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Location = new System.Drawing.Point(721, 26);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(159, 36);
            this.continueButton.TabIndex = 3;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.BackColor = System.Drawing.Color.Gold;
            this.backButton.Enabled = false;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backButton.FlatAppearance.BorderSize = 2;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(1134, 26);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(159, 36);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // resetGameButton
            // 
            this.resetGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetGameButton.BackColor = System.Drawing.Color.Gold;
            this.resetGameButton.Enabled = false;
            this.resetGameButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetGameButton.FlatAppearance.BorderSize = 2;
            this.resetGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.resetGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetGameButton.Location = new System.Drawing.Point(929, 26);
            this.resetGameButton.Name = "resetGameButton";
            this.resetGameButton.Size = new System.Drawing.Size(159, 36);
            this.resetGameButton.TabIndex = 5;
            this.resetGameButton.Text = "Reset game";
            this.resetGameButton.UseVisualStyleBackColor = false;
            // 
            // navigationPanel
            // 
            this.navigationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationPanel.Controls.Add(this.labelInfo);
            this.navigationPanel.Controls.Add(this.resetGameButton);
            this.navigationPanel.Controls.Add(this.continueButton);
            this.navigationPanel.Controls.Add(this.backButton);
            this.navigationPanel.Controls.Add(this.stopButton);
            this.navigationPanel.Location = new System.Drawing.Point(22, 37);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(1318, 84);
            this.navigationPanel.TabIndex = 6;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1360, 646);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.gameField);
            this.KeyPreview = true;
            this.Name = "GameForm";
            this.Text = "GameForm";
            ((System.ComponentModel.ISupportInitialize)(this.gameField)).EndInit();
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView gameField;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button resetGameButton;
        private System.Windows.Forms.Panel navigationPanel;
    }
}