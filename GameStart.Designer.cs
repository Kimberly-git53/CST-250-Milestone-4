namespace MineSweeperGUI
{
    partial class FrmGameStart
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
            grpChooseLevel = new GroupBox();
            rbtnDifficult = new RadioButton();
            rbtnMedium = new RadioButton();
            rbtnEasy = new RadioButton();
            btnPlay = new Button();
            grpChooseLevel.SuspendLayout();
            SuspendLayout();
            // 
            // grpChooseLevel
            // 
            grpChooseLevel.BackColor = Color.RosyBrown;
            grpChooseLevel.Controls.Add(rbtnDifficult);
            grpChooseLevel.Controls.Add(rbtnMedium);
            grpChooseLevel.Controls.Add(rbtnEasy);
            grpChooseLevel.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            grpChooseLevel.ForeColor = Color.DarkRed;
            grpChooseLevel.Location = new Point(45, 56);
            grpChooseLevel.Name = "grpChooseLevel";
            grpChooseLevel.Size = new Size(182, 200);
            grpChooseLevel.TabIndex = 0;
            grpChooseLevel.TabStop = false;
            grpChooseLevel.Text = "Choose a level";
            // 
            // rbtnDifficult
            // 
            rbtnDifficult.AutoSize = true;
            rbtnDifficult.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnDifficult.ForeColor = Color.Brown;
            rbtnDifficult.Location = new Point(41, 135);
            rbtnDifficult.Name = "rbtnDifficult";
            rbtnDifficult.Size = new Size(115, 39);
            rbtnDifficult.TabIndex = 2;
            rbtnDifficult.TabStop = true;
            rbtnDifficult.Text = "Difficult";
            rbtnDifficult.UseVisualStyleBackColor = true;
            // 
            // rbtnMedium
            // 
            rbtnMedium.AutoSize = true;
            rbtnMedium.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            rbtnMedium.ForeColor = Color.Brown;
            rbtnMedium.Location = new Point(41, 90);
            rbtnMedium.Name = "rbtnMedium";
            rbtnMedium.Size = new Size(116, 39);
            rbtnMedium.TabIndex = 1;
            rbtnMedium.TabStop = true;
            rbtnMedium.Text = "Medium";
            rbtnMedium.UseVisualStyleBackColor = true;
            // 
            // rbtnEasy
            // 
            rbtnEasy.AutoSize = true;
            rbtnEasy.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            rbtnEasy.ForeColor = Color.Brown;
            rbtnEasy.Location = new Point(43, 45);
            rbtnEasy.Name = "rbtnEasy";
            rbtnEasy.Size = new Size(82, 39);
            rbtnEasy.TabIndex = 0;
            rbtnEasy.TabStop = true;
            rbtnEasy.Text = "Easy";
            rbtnEasy.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.CornflowerBlue;
            btnPlay.FlatStyle = FlatStyle.Popup;
            btnPlay.Font = new Font("Snap ITC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay.ForeColor = Color.DarkRed;
            btnPlay.Location = new Point(86, 273);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(94, 37);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // FrmGameStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(278, 349);
            Controls.Add(btnPlay);
            Controls.Add(grpChooseLevel);
            Name = "FrmGameStart";
            Text = "Start Game";
            grpChooseLevel.ResumeLayout(false);
            grpChooseLevel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpChooseLevel;
        private RadioButton rbtnDifficult;
        private RadioButton rbtnMedium;
        private RadioButton rbtnEasy;
        private Button btnPlay;
    }
}