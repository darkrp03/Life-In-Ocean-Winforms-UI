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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameField = new System.Windows.Forms.DataGridView();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonResetGame = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.buttonSpeakerOff = new System.Windows.Forms.Button();
            this.buttonSpeakerOn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameField)).BeginInit();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 500;
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
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.BackColor = System.Drawing.Color.Gold;
            this.buttonStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonStop.FlatAppearance.BorderSize = 2;
            this.buttonStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.ForeColor = System.Drawing.Color.Black;
            this.buttonStop.Location = new System.Drawing.Point(721, 26);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(159, 36);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonContinue.BackColor = System.Drawing.Color.Gold;
            this.buttonContinue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonContinue.FlatAppearance.BorderSize = 2;
            this.buttonContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Location = new System.Drawing.Point(721, 26);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(159, 36);
            this.buttonContinue.TabIndex = 3;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BackColor = System.Drawing.Color.Gold;
            this.buttonBack.Enabled = false;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBack.FlatAppearance.BorderSize = 2;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(1134, 26);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(159, 36);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonResetGame
            // 
            this.buttonResetGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetGame.BackColor = System.Drawing.Color.Gold;
            this.buttonResetGame.Enabled = false;
            this.buttonResetGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonResetGame.FlatAppearance.BorderSize = 2;
            this.buttonResetGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetGame.Location = new System.Drawing.Point(929, 26);
            this.buttonResetGame.Name = "buttonResetGame";
            this.buttonResetGame.Size = new System.Drawing.Size(159, 36);
            this.buttonResetGame.TabIndex = 5;
            this.buttonResetGame.Text = "Reset game";
            this.buttonResetGame.UseVisualStyleBackColor = false;
            // 
            // navigationPanel
            // 
            this.navigationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationPanel.Controls.Add(this.buttonSpeakerOff);
            this.navigationPanel.Controls.Add(this.buttonSpeakerOn);
            this.navigationPanel.Controls.Add(this.labelInfo);
            this.navigationPanel.Controls.Add(this.buttonResetGame);
            this.navigationPanel.Controls.Add(this.buttonContinue);
            this.navigationPanel.Controls.Add(this.buttonBack);
            this.navigationPanel.Controls.Add(this.buttonStop);
            this.navigationPanel.Location = new System.Drawing.Point(22, 37);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(1318, 95);
            this.navigationPanel.TabIndex = 6;
            // 
            // buttonSpeakerOff
            // 
            this.buttonSpeakerOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSpeakerOff.BackColor = System.Drawing.Color.Gold;
            this.buttonSpeakerOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSpeakerOff.BackgroundImage")));
            this.buttonSpeakerOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpeakerOff.Enabled = false;
            this.buttonSpeakerOff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSpeakerOff.FlatAppearance.BorderSize = 2;
            this.buttonSpeakerOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSpeakerOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpeakerOff.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSpeakerOff.Location = new System.Drawing.Point(664, 26);
            this.buttonSpeakerOff.Name = "buttonSpeakerOff";
            this.buttonSpeakerOff.Size = new System.Drawing.Size(38, 36);
            this.buttonSpeakerOff.TabIndex = 7;
            this.buttonSpeakerOff.UseVisualStyleBackColor = false;
            this.buttonSpeakerOff.Visible = false;
            // 
            // buttonSpeakerOn
            // 
            this.buttonSpeakerOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSpeakerOn.BackColor = System.Drawing.Color.Gold;
            this.buttonSpeakerOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSpeakerOn.BackgroundImage")));
            this.buttonSpeakerOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpeakerOn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSpeakerOn.FlatAppearance.BorderSize = 2;
            this.buttonSpeakerOn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSpeakerOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpeakerOn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSpeakerOn.Location = new System.Drawing.Point(664, 26);
            this.buttonSpeakerOn.Name = "buttonSpeakerOn";
            this.buttonSpeakerOn.Size = new System.Drawing.Size(38, 36);
            this.buttonSpeakerOn.TabIndex = 6;
            this.buttonSpeakerOn.UseVisualStyleBackColor = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1360, 646);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.gameField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GameForm";
            this.Text = "Life In Ocean";
            ((System.ComponentModel.ISupportInitialize)(this.gameField)).EndInit();
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.DataGridView gameField;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonResetGame;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonSpeakerOn;
        private System.Windows.Forms.Button buttonSpeakerOff;
    }
}