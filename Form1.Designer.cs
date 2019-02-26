namespace TicTacToe
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
            this.components = new System.ComponentModel.Container();
            this.A00 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.NGButton = new System.Windows.Forms.Button();
            this.RButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.XWin = new System.Windows.Forms.Label();
            this.OWin = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.PvP = new System.Windows.Forms.Button();
            this.PvE = new System.Windows.Forms.Button();
            this.AImoves = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A00.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A00.Location = new System.Drawing.Point(12, 27);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(76, 74);
            this.A00.TabIndex = 0;
            this.A00.TabStop = false;
            this.A00.Tag = "play";
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.buttonClick);
            // 
            // A10
            // 
            this.A10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A10.Location = new System.Drawing.Point(12, 107);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(76, 74);
            this.A10.TabIndex = 1;
            this.A10.TabStop = false;
            this.A10.Tag = "play";
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.buttonClick);
            // 
            // A20
            // 
            this.A20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A20.Location = new System.Drawing.Point(12, 187);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(76, 74);
            this.A20.TabIndex = 2;
            this.A20.TabStop = false;
            this.A20.Tag = "play";
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A21.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A21.Location = new System.Drawing.Point(94, 187);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(76, 74);
            this.A21.TabIndex = 5;
            this.A21.TabStop = false;
            this.A21.Tag = "play";
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A11.Location = new System.Drawing.Point(94, 107);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(76, 74);
            this.A11.TabIndex = 4;
            this.A11.TabStop = false;
            this.A11.Tag = "play";
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A01
            // 
            this.A01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A01.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A01.Location = new System.Drawing.Point(94, 27);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(76, 74);
            this.A01.TabIndex = 3;
            this.A01.TabStop = false;
            this.A01.Tag = "play";
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.buttonClick);
            // 
            // A22
            // 
            this.A22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A22.Location = new System.Drawing.Point(176, 187);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(76, 74);
            this.A22.TabIndex = 8;
            this.A22.TabStop = false;
            this.A22.Tag = "play";
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A12.Location = new System.Drawing.Point(176, 107);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(76, 74);
            this.A12.TabIndex = 7;
            this.A12.TabStop = false;
            this.A12.Tag = "play";
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // A02
            // 
            this.A02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A02.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A02.Location = new System.Drawing.Point(176, 27);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(76, 74);
            this.A02.TabIndex = 6;
            this.A02.TabStop = false;
            this.A02.Tag = "play";
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.buttonClick);
            // 
            // NGButton
            // 
            this.NGButton.Location = new System.Drawing.Point(13, 292);
            this.NGButton.Name = "NGButton";
            this.NGButton.Size = new System.Drawing.Size(75, 23);
            this.NGButton.TabIndex = 9;
            this.NGButton.TabStop = false;
            this.NGButton.Text = "New Game";
            this.NGButton.UseVisualStyleBackColor = true;
            this.NGButton.Click += new System.EventHandler(this.NGButton_Click);
            // 
            // RButton
            // 
            this.RButton.Location = new System.Drawing.Point(94, 292);
            this.RButton.Name = "RButton";
            this.RButton.Size = new System.Drawing.Size(75, 23);
            this.RButton.TabIndex = 10;
            this.RButton.TabStop = false;
            this.RButton.Text = "Reset";
            this.RButton.UseVisualStyleBackColor = true;
            this.RButton.Click += new System.EventHandler(this.RButton_Click);
            // 
            // EButton
            // 
            this.EButton.Location = new System.Drawing.Point(317, 292);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(75, 23);
            this.EButton.TabIndex = 11;
            this.EButton.TabStop = false;
            this.EButton.Text = "Exit";
            this.EButton.UseVisualStyleBackColor = true;
            this.EButton.Click += new System.EventHandler(this.EButton_Click);
            // 
            // XWin
            // 
            this.XWin.Location = new System.Drawing.Point(292, 58);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(100, 23);
            this.XWin.TabIndex = 12;
            this.XWin.Text = "label1";
            // 
            // OWin
            // 
            this.OWin.Location = new System.Drawing.Point(292, 138);
            this.OWin.Name = "OWin";
            this.OWin.Size = new System.Drawing.Size(100, 23);
            this.OWin.TabIndex = 13;
            this.OWin.Text = "label2";
            // 
            // Draws
            // 
            this.Draws.Location = new System.Drawing.Point(292, 218);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(100, 23);
            this.Draws.TabIndex = 14;
            this.Draws.Text = "label3";
            // 
            // PvP
            // 
            this.PvP.Location = new System.Drawing.Point(13, 351);
            this.PvP.Name = "PvP";
            this.PvP.Size = new System.Drawing.Size(135, 38);
            this.PvP.TabIndex = 15;
            this.PvP.TabStop = false;
            this.PvP.Text = "Player vs Player";
            this.PvP.UseVisualStyleBackColor = true;
            this.PvP.Click += new System.EventHandler(this.PvP_Click);
            // 
            // PvE
            // 
            this.PvE.Location = new System.Drawing.Point(257, 351);
            this.PvE.Name = "PvE";
            this.PvE.Size = new System.Drawing.Size(135, 38);
            this.PvE.TabIndex = 16;
            this.PvE.TabStop = false;
            this.PvE.Text = "Player vs AI";
            this.PvE.UseVisualStyleBackColor = true;
            this.PvE.Click += new System.EventHandler(this.PvE_Click);
            // 
            // AImoves
            // 
            this.AImoves.Interval = 500;
            this.AImoves.Tick += new System.EventHandler(this.AImove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 401);
            this.Controls.Add(this.PvE);
            this.Controls.Add(this.PvP);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.OWin);
            this.Controls.Add(this.XWin);
            this.Controls.Add(this.EButton);
            this.Controls.Add(this.RButton);
            this.Controls.Add(this.NGButton);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A00);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button NGButton;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label OWin;
        private System.Windows.Forms.Label Draws;
        private System.Windows.Forms.Button PvP;
        private System.Windows.Forms.Button PvE;
        private System.Windows.Forms.Timer AImoves;
    }
}

