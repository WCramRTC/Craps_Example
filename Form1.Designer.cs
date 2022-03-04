namespace Craps_Example
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.disAmount = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.disTurn = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.disBet = new System.Windows.Forms.Label();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.disPoint = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(683, 18);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(89, 25);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Balance:";
            // 
            // disAmount
            // 
            this.disAmount.AutoSize = true;
            this.disAmount.Location = new System.Drawing.Point(683, 75);
            this.disAmount.Name = "disAmount";
            this.disAmount.Size = new System.Drawing.Size(64, 25);
            this.disAmount.TabIndex = 1;
            this.disAmount.Text = "label2";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Location = new System.Drawing.Point(683, 132);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(53, 25);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.Text = "Turn";
            // 
            // disTurn
            // 
            this.disTurn.AutoSize = true;
            this.disTurn.Location = new System.Drawing.Point(683, 189);
            this.disTurn.Name = "disTurn";
            this.disTurn.Size = new System.Drawing.Size(64, 25);
            this.disTurn.TabIndex = 3;
            this.disTurn.Text = "label4";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Location = new System.Drawing.Point(683, 335);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(41, 25);
            this.lblBet.TabIndex = 4;
            this.lblBet.Text = "Bet";
            // 
            // disBet
            // 
            this.disBet.AutoSize = true;
            this.disBet.Location = new System.Drawing.Point(683, 392);
            this.disBet.Name = "disBet";
            this.disBet.Size = new System.Drawing.Size(64, 25);
            this.disBet.TabIndex = 5;
            this.disBet.Text = "label6";
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(12, 12);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(617, 337);
            this.rtbDisplay.TabIndex = 6;
            this.rtbDisplay.Text = "";
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(42, 372);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(554, 99);
            this.btnRoll.TabIndex = 7;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(649, 432);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(75, 73);
            this.btnDecrease.TabIndex = 8;
            this.btnDecrease.Text = "-";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(762, 432);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(75, 73);
            this.btnIncrease.TabIndex = 9;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // disPoint
            // 
            this.disPoint.AutoSize = true;
            this.disPoint.Location = new System.Drawing.Point(683, 291);
            this.disPoint.Name = "disPoint";
            this.disPoint.Size = new System.Drawing.Size(64, 25);
            this.disPoint.TabIndex = 11;
            this.disPoint.Text = "label4";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(683, 234);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(126, 25);
            this.lblPoint.TabIndex = 10;
            this.lblPoint.Text = "Current Point";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(42, 495);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 39);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 542);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.disPoint);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.disBet);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.disTurn);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.disAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "Form1";
            this.Text = "Craps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label disAmount;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label disTurn;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label disBet;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Label disPoint;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Button btnReset;
    }
}

