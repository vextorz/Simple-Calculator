namespace Calculator
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
            this.display = new System.Windows.Forms.TextBox();
            this.clearEntryBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.backSpaceBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.numBtn7 = new System.Windows.Forms.Button();
            this.numBtn8 = new System.Windows.Forms.Button();
            this.numBtn9 = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.numBtn4 = new System.Windows.Forms.Button();
            this.numBtn5 = new System.Windows.Forms.Button();
            this.numBtn6 = new System.Windows.Forms.Button();
            this.subtractBtn = new System.Windows.Forms.Button();
            this.plusMinusBtn = new System.Windows.Forms.Button();
            this.numBtn0 = new System.Windows.Forms.Button();
            this.decimalBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.numBtn1 = new System.Windows.Forms.Button();
            this.numBtn2 = new System.Windows.Forms.Button();
            this.numBtn3 = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Margin = new System.Windows.Forms.Padding(2);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(355, 44);
            this.display.TabIndex = 1;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clearEntryBtn
            // 
            this.clearEntryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearEntryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntryBtn.Location = new System.Drawing.Point(2, 66);
            this.clearEntryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearEntryBtn.Name = "clearEntryBtn";
            this.clearEntryBtn.Size = new System.Drawing.Size(84, 69);
            this.clearEntryBtn.TabIndex = 0;
            this.clearEntryBtn.Text = "CE";
            this.clearEntryBtn.UseVisualStyleBackColor = true;
            this.clearEntryBtn.Click += new System.EventHandler(this.clearEntryBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(90, 66);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(84, 69);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // backSpaceBtn
            // 
            this.backSpaceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backSpaceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backSpaceBtn.Location = new System.Drawing.Point(178, 66);
            this.backSpaceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backSpaceBtn.Name = "backSpaceBtn";
            this.backSpaceBtn.Size = new System.Drawing.Size(84, 69);
            this.backSpaceBtn.TabIndex = 6;
            this.backSpaceBtn.Text = "<<";
            this.backSpaceBtn.UseVisualStyleBackColor = true;
            this.backSpaceBtn.Click += new System.EventHandler(this.backSpaceBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBtn.Location = new System.Drawing.Point(266, 66);
            this.divideBtn.Margin = new System.Windows.Forms.Padding(2);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(87, 69);
            this.divideBtn.TabIndex = 7;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.mathOpBtn_Click);
            // 
            // numBtn7
            // 
            this.numBtn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBtn7.Location = new System.Drawing.Point(2, 139);
            this.numBtn7.Margin = new System.Windows.Forms.Padding(2);
            this.numBtn7.Name = "numBtn7";
            this.numBtn7.Size = new System.Drawing.Size(84, 69);
            this.numBtn7.TabIndex = 8;
            this.numBtn7.Text = "7";
            this.numBtn7.UseVisualStyleBackColor = true;
            this.numBtn7.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // numBtn8
            // 
            this.numBtn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBtn8.Location = new System.Drawing.Point(90, 139);
            this.numBtn8.Margin = new System.Windows.Forms.Padding(2);
            this.numBtn8.Name = "numBtn8";
            this.numBtn8.Size = new System.Drawing.Size(84, 69);
            this.numBtn8.TabIndex = 9;
            this.numBtn8.Text = "8";
            this.numBtn8.UseVisualStyleBackColor = true;
            this.numBtn8.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // numBtn9
            // 
            this.numBtn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBtn9.Location = new System.Drawing.Point(178, 139);
            this.numBtn9.Margin = new System.Windows.Forms.Padding(2);
            this.numBtn9.Name = "numBtn9";
            this.numBtn9.Size = new System.Drawing.Size(84, 69);
            this.numBtn9.TabIndex = 10;
            this.numBtn9.Text = "9";
            this.numBtn9.UseVisualStyleBackColor = true;
            this.numBtn9.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyBtn.Location = new System.Drawing.Point(266, 139);
            this.multiplyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(87, 69);
            this.multiplyBtn.TabIndex = 11;
            this.multiplyBtn.Text = "x";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.mathOpBtn_Click);
            // 
            // numBtn4
            // 
            this.numBtn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBtn4.Location = new System.Drawing.Point(2, 212);
            this.numBtn4.Margin = new System.Windows.Forms.Padding(2);
            this.numBtn4.Name = "numBtn4";
            this.numBtn4.Size = new System.Drawing.Size(84, 69);
            this.numBtn4.TabIndex = 12;
            this.numBtn4.Text = "4";
            this.numBtn4.UseVisualStyleBackColor = true;
            this.numBtn4.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // numBtn5
            // 
            this.numBtn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBtn5.Location = new System.Drawing.Point(90, 212);
            this.numBtn5.Margin = new System.Windows.Forms.Padding(2);
            this.numBtn5.Name = "numBtn5";
            this.numBtn5.Size = new System.Drawing.Size(84, 69);
            this.numBtn5.TabIndex = 13;
            this.numBtn5.Text = "5";
            this.numBtn5.UseVisualStyleBackColor = true;
            this.numBtn5.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // numBtn6
            // 
            this.numBtn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBtn6.Location = new System.Drawing.Point(178, 212);
            this.numBtn6.Margin = new System.Windows.Forms.Padding(2);
            this.numBtn6.Name = "numBtn6";
            this.numBtn6.Size = new System.Drawing.Size(84, 69);
            this.numBtn6.TabIndex = 14;
            this.numBtn6.Text = "6";
            this.numBtn6.UseVisualStyleBackColor = true;
            this.numBtn6.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // subtractBtn
            // 
            this.subtractBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtractBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractBtn.Location = new System.Drawing.Point(266, 212);
            this.subtractBtn.Margin = new System.Windows.Forms.Padding(2);
            this.subtractBtn.Name = "subtractBtn";
            this.subtractBtn.Size = new System.Drawing.Size(87, 69);
            this.subtractBtn.TabIndex = 15;
            this.subtractBtn.Text = "-";
            this.subtractBtn.UseVisualStyleBackColor = true;
            this.subtractBtn.Click += new System.EventHandler(this.mathOpBtn_Click);
            // 
            // plusMinusBtn
            // 
            this.plusMinusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusMinusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusMinusBtn.Location = new System.Drawing.Point(2, 358);
            this.plusMinusBtn.Margin = new System.Windows.Forms.Padding(2);
            this.plusMinusBtn.Name = "plusMinusBtn";
            this.plusMinusBtn.Size = new System.Drawing.Size(84, 71);
            this.plusMinusBtn.TabIndex = 16;
            this.plusMinusBtn.Text = "+/-";
            this.plusMinusBtn.UseVisualStyleBackColor = true;
            this.plusMinusBtn.Click += new System.EventHandler(this.plusMinusBtn_Click);
            // 
            // numBtn0
            // 
            this.numBtn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBtn0.Location = new System.Drawing.Point(90, 358);
            this.numBtn0.Margin = new System.Windows.Forms.Padding(2);
            this.numBtn0.Name = "numBtn0";
            this.numBtn0.Size = new System.Drawing.Size(84, 71);
            this.numBtn0.TabIndex = 18;
            this.numBtn0.Text = "0";
            this.numBtn0.UseVisualStyleBackColor = true;
            this.numBtn0.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // decimalBtn
            // 
            this.decimalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decimalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalBtn.Location = new System.Drawing.Point(178, 358);
            this.decimalBtn.Margin = new System.Windows.Forms.Padding(2);
            this.decimalBtn.Name = "decimalBtn";
            this.decimalBtn.Size = new System.Drawing.Size(84, 71);
            this.decimalBtn.TabIndex = 19;
            this.decimalBtn.Text = ".";
            this.decimalBtn.UseVisualStyleBackColor = true;
            this.decimalBtn.Click += new System.EventHandler(this.decimalBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.Location = new System.Drawing.Point(266, 358);
            this.equalBtn.Margin = new System.Windows.Forms.Padding(2);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(87, 71);
            this.equalBtn.TabIndex = 20;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // numBtn1
            // 
            this.numBtn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBtn1.Location = new System.Drawing.Point(2, 285);
            this.numBtn1.Margin = new System.Windows.Forms.Padding(2);
            this.numBtn1.Name = "numBtn1";
            this.numBtn1.Size = new System.Drawing.Size(84, 69);
            this.numBtn1.TabIndex = 21;
            this.numBtn1.Text = "1";
            this.numBtn1.UseVisualStyleBackColor = true;
            this.numBtn1.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // numBtn2
            // 
            this.numBtn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBtn2.Location = new System.Drawing.Point(90, 285);
            this.numBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.numBtn2.Name = "numBtn2";
            this.numBtn2.Size = new System.Drawing.Size(84, 69);
            this.numBtn2.TabIndex = 22;
            this.numBtn2.Text = "2";
            this.numBtn2.UseVisualStyleBackColor = true;
            this.numBtn2.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // numBtn3
            // 
            this.numBtn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBtn3.Location = new System.Drawing.Point(178, 285);
            this.numBtn3.Margin = new System.Windows.Forms.Padding(2);
            this.numBtn3.Name = "numBtn3";
            this.numBtn3.Size = new System.Drawing.Size(84, 69);
            this.numBtn3.TabIndex = 23;
            this.numBtn3.Text = "3";
            this.numBtn3.UseVisualStyleBackColor = true;
            this.numBtn3.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Location = new System.Drawing.Point(266, 285);
            this.plusBtn.Margin = new System.Windows.Forms.Padding(2);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(87, 69);
            this.plusBtn.TabIndex = 24;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.mathOpBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.plusBtn, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.numBtn3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.numBtn2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.numBtn1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.equalBtn, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.decimalBtn, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.numBtn0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.plusMinusBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.subtractBtn, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.numBtn6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.numBtn5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numBtn4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.multiplyBtn, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.numBtn9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.numBtn8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numBtn7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.divideBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.backSpaceBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.clearBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.clearEntryBtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 431);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 431);
            this.Controls.Add(this.display);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimumSize = new System.Drawing.Size(315, 410);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TINFO 200 Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button clearEntryBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button backSpaceBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button numBtn7;
        private System.Windows.Forms.Button numBtn8;
        private System.Windows.Forms.Button numBtn9;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button numBtn4;
        private System.Windows.Forms.Button numBtn5;
        private System.Windows.Forms.Button numBtn6;
        private System.Windows.Forms.Button subtractBtn;
        private System.Windows.Forms.Button plusMinusBtn;
        private System.Windows.Forms.Button numBtn0;
        private System.Windows.Forms.Button decimalBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button numBtn1;
        private System.Windows.Forms.Button numBtn2;
        private System.Windows.Forms.Button numBtn3;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

