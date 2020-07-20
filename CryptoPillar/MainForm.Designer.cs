namespace CryptoPillar
{
    partial class MainForm
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
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.pillar1 = new System.Windows.Forms.TextBox();
            this.pillar2 = new System.Windows.Forms.TextBox();
            this.pillar3 = new System.Windows.Forms.TextBox();
            this.pillar4 = new System.Windows.Forms.TextBox();
            this.pillar5 = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.controlBox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.timeBar = new System.Windows.Forms.ProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(12, 9);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(65, 13);
            this.minLabel.TabIndex = 0;
            this.minLabel.Text = "Min number:";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(153, 9);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(68, 13);
            this.maxLabel.TabIndex = 0;
            this.maxLabel.Text = "Max number:";
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(83, 6);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(64, 20);
            this.minBox.TabIndex = 1;
            this.minBox.Text = "1";
            this.minBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minBox_KeyPress);
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(227, 6);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(68, 20);
            this.maxBox.TabIndex = 2;
            this.maxBox.Text = "102";
            this.maxBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxBox_KeyPress);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(301, 9);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(41, 13);
            this.speedLabel.TabIndex = 3;
            this.speedLabel.Text = "Speed:";
            // 
            // speedBox
            // 
            this.speedBox.Location = new System.Drawing.Point(348, 6);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(100, 20);
            this.speedBox.TabIndex = 4;
            this.speedBox.Text = "100";
            this.speedBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.speedBox_KeyPress);
            // 
            // pillar1
            // 
            this.pillar1.Location = new System.Drawing.Point(15, 32);
            this.pillar1.Multiline = true;
            this.pillar1.Name = "pillar1";
            this.pillar1.ReadOnly = true;
            this.pillar1.Size = new System.Drawing.Size(82, 318);
            this.pillar1.TabIndex = 5;
            this.pillar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pillar2
            // 
            this.pillar2.Location = new System.Drawing.Point(103, 32);
            this.pillar2.Multiline = true;
            this.pillar2.Name = "pillar2";
            this.pillar2.ReadOnly = true;
            this.pillar2.Size = new System.Drawing.Size(82, 318);
            this.pillar2.TabIndex = 5;
            this.pillar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pillar3
            // 
            this.pillar3.Location = new System.Drawing.Point(191, 32);
            this.pillar3.Multiline = true;
            this.pillar3.Name = "pillar3";
            this.pillar3.ReadOnly = true;
            this.pillar3.Size = new System.Drawing.Size(82, 318);
            this.pillar3.TabIndex = 5;
            this.pillar3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pillar4
            // 
            this.pillar4.Location = new System.Drawing.Point(279, 32);
            this.pillar4.Multiline = true;
            this.pillar4.Name = "pillar4";
            this.pillar4.ReadOnly = true;
            this.pillar4.Size = new System.Drawing.Size(82, 318);
            this.pillar4.TabIndex = 5;
            this.pillar4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pillar5
            // 
            this.pillar5.Location = new System.Drawing.Point(367, 32);
            this.pillar5.Multiline = true;
            this.pillar5.Name = "pillar5";
            this.pillar5.ReadOnly = true;
            this.pillar5.Size = new System.Drawing.Size(82, 318);
            this.pillar5.TabIndex = 5;
            this.pillar5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(454, 6);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(318, 373);
            this.logBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Prime";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Prime";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Prime";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(279, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Prime";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(366, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Prime";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // controlBox
            // 
            this.controlBox.Location = new System.Drawing.Point(15, 414);
            this.controlBox.Multiline = true;
            this.controlBox.Name = "controlBox";
            this.controlBox.ReadOnly = true;
            this.controlBox.Size = new System.Drawing.Size(757, 116);
            this.controlBox.TabIndex = 8;
            this.controlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(96, 539);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(42, 13);
            this.answerLabel.TabIndex = 9;
            this.answerLabel.Text = "Answer";
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(144, 536);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(547, 20);
            this.answerBox.TabIndex = 10;
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Location = new System.Drawing.Point(697, 536);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 536);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timeBar
            // 
            this.timeBar.Location = new System.Drawing.Point(15, 385);
            this.timeBar.Name = "timeBar";
            this.timeBar.Size = new System.Drawing.Size(757, 23);
            this.timeBar.TabIndex = 13;
            this.timeBar.Value = 100;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.timeBar);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.pillar5);
            this.Controls.Add(this.pillar4);
            this.Controls.Add(this.pillar3);
            this.Controls.Add(this.pillar2);
            this.Controls.Add(this.pillar1);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CryptoPillar by Kaze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox speedBox;
        private System.Windows.Forms.TextBox pillar1;
        private System.Windows.Forms.TextBox pillar2;
        private System.Windows.Forms.TextBox pillar3;
        private System.Windows.Forms.TextBox pillar4;
        private System.Windows.Forms.TextBox pillar5;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox controlBox;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ProgressBar timeBar;
        private System.Windows.Forms.Timer gameTimer;
    }
}

