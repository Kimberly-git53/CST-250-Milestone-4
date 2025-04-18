namespace MineSweeperGUI
{
    partial class FrmBoardGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMineSweeperBoard = new Panel();
            lblStartTime = new Label();
            lblTime = new Label();
            lblScoreValue = new Label();
            lblScore = new Label();
            btnRestart = new Button();
            comboBoxActions = new ComboBox();
            SuspendLayout();
            // 
            // panelMineSweeperBoard
            // 
            panelMineSweeperBoard.Font = new Font("Felix Titling", 10F);
            panelMineSweeperBoard.Location = new Point(24, 25);
            panelMineSweeperBoard.Name = "panelMineSweeperBoard";
            panelMineSweeperBoard.Size = new Size(543, 511);
            panelMineSweeperBoard.TabIndex = 0;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            lblStartTime.ForeColor = Color.Brown;
            lblStartTime.Location = new Point(588, 31);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(131, 35);
            lblStartTime.TabIndex = 1;
            lblStartTime.Text = "Start Time:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            lblTime.ForeColor = Color.Firebrick;
            lblTime.Location = new Point(602, 66);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(76, 35);
            lblTime.TabIndex = 2;
            lblTime.Text = "label1";
            // 
            // lblScoreValue
            // 
            lblScoreValue.AutoSize = true;
            lblScoreValue.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            lblScoreValue.ForeColor = Color.Firebrick;
            lblScoreValue.Location = new Point(602, 151);
            lblScoreValue.Name = "lblScoreValue";
            lblScoreValue.Size = new Size(76, 35);
            lblScoreValue.TabIndex = 3;
            lblScoreValue.Text = "label2";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            lblScore.ForeColor = Color.Firebrick;
            lblScore.Location = new Point(588, 117);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(75, 35);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score:";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.DarkSeaGreen;
            btnRestart.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btnRestart.Location = new Point(631, 203);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(97, 45);
            btnRestart.TabIndex = 6;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click_1;
            // 
            // comboBoxActions
            // 
            comboBoxActions.BackColor = SystemColors.ActiveCaption;
            comboBoxActions.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            comboBoxActions.ForeColor = Color.Indigo;
            comboBoxActions.FormattingEnabled = true;
            comboBoxActions.Items.AddRange(new object[] { "Flag", "Visit", "Use Reward" });
            comboBoxActions.Location = new Point(588, 303);
            comboBoxActions.Name = "comboBoxActions";
            comboBoxActions.Size = new Size(200, 43);
            comboBoxActions.TabIndex = 7;
            comboBoxActions.Text = "Select an Action";
            // 
            // FrmBoardGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 588);
            Controls.Add(comboBoxActions);
            Controls.Add(btnRestart);
            Controls.Add(lblScore);
            Controls.Add(lblScoreValue);
            Controls.Add(lblTime);
            Controls.Add(lblStartTime);
            Controls.Add(panelMineSweeperBoard);
            ForeColor = Color.DarkRed;
            Name = "FrmBoardGame";
            Text = "Minesweeper Board Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMineSweeperBoard;
        private Label lblStartTime;
        private Label lblTime;
        private Label lblScoreValue;
        private Label lblScore;
        private Button btnRestart;
        private ComboBox comboBoxActions;
    }
}
