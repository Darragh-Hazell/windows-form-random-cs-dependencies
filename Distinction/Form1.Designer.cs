namespace Distinction
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
            this.GENERATE = new System.Windows.Forms.Button();
            this.baconText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.smInput = new System.Windows.Forms.TextBox();
            this.smOutput = new System.Windows.Forms.TextBox();
            this.smHint = new System.Windows.Forms.Label();
            this.EVALUATE = new System.Windows.Forms.Button();
            this.smOutputHint = new System.Windows.Forms.Label();
            this.matrix1_00 = new System.Windows.Forms.TextBox();
            this.matrix1_01 = new System.Windows.Forms.TextBox();
            this.matrix1_10 = new System.Windows.Forms.TextBox();
            this.matrix1_11 = new System.Windows.Forms.TextBox();
            this.matrix2_00 = new System.Windows.Forms.TextBox();
            this.matrix2_10 = new System.Windows.Forms.TextBox();
            this.matrix2_11 = new System.Windows.Forms.TextBox();
            this.matrix2_01 = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.matrixR_00 = new System.Windows.Forms.TextBox();
            this.matrixR_01 = new System.Windows.Forms.TextBox();
            this.matrixR_10 = new System.Windows.Forms.TextBox();
            this.matrixR_11 = new System.Windows.Forms.TextBox();
            this.MULTIPLY = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GENERATE
            // 
            this.GENERATE.Location = new System.Drawing.Point(542, 44);
            this.GENERATE.Name = "GENERATE";
            this.GENERATE.Size = new System.Drawing.Size(259, 23);
            this.GENERATE.TabIndex = 0;
            this.GENERATE.Text = "GENERATE";
            this.GENERATE.UseVisualStyleBackColor = true;
            this.GENERATE.Click += new System.EventHandler(this.button1_Click);
            // 
            // baconText
            // 
            this.baconText.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.baconText.Location = new System.Drawing.Point(542, 73);
            this.baconText.Margin = new System.Windows.Forms.Padding(9);
            this.baconText.Multiline = true;
            this.baconText.Name = "baconText";
            this.baconText.ReadOnly = true;
            this.baconText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.baconText.Size = new System.Drawing.Size(259, 202);
            this.baconText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "baconipsum";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Math.NET";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "StringMath";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smInput
            // 
            this.smInput.Location = new System.Drawing.Point(16, 73);
            this.smInput.Name = "smInput";
            this.smInput.Size = new System.Drawing.Size(255, 20);
            this.smInput.TabIndex = 5;
            this.smInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smOutput
            // 
            this.smOutput.Location = new System.Drawing.Point(16, 200);
            this.smOutput.Name = "smOutput";
            this.smOutput.ReadOnly = true;
            this.smOutput.Size = new System.Drawing.Size(255, 20);
            this.smOutput.TabIndex = 6;
            this.smOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smHint
            // 
            this.smHint.Location = new System.Drawing.Point(16, 44);
            this.smHint.Name = "smHint";
            this.smHint.Size = new System.Drawing.Size(255, 23);
            this.smHint.TabIndex = 7;
            this.smHint.Text = "Enter expression:";
            this.smHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EVALUATE
            // 
            this.EVALUATE.Location = new System.Drawing.Point(16, 116);
            this.EVALUATE.Name = "EVALUATE";
            this.EVALUATE.Size = new System.Drawing.Size(255, 23);
            this.EVALUATE.TabIndex = 8;
            this.EVALUATE.Text = "EVALUATE";
            this.EVALUATE.UseVisualStyleBackColor = true;
            this.EVALUATE.Click += new System.EventHandler(this.EVALUATE_Click);
            // 
            // smOutputHint
            // 
            this.smOutputHint.Location = new System.Drawing.Point(16, 159);
            this.smOutputHint.Name = "smOutputHint";
            this.smOutputHint.Size = new System.Drawing.Size(255, 23);
            this.smOutputHint.TabIndex = 9;
            this.smOutputHint.Text = "Output:";
            this.smOutputHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matrix1_00
            // 
            this.matrix1_00.Location = new System.Drawing.Point(313, 73);
            this.matrix1_00.Name = "matrix1_00";
            this.matrix1_00.Size = new System.Drawing.Size(33, 20);
            this.matrix1_00.TabIndex = 10;
            // 
            // matrix1_01
            // 
            this.matrix1_01.Location = new System.Drawing.Point(352, 73);
            this.matrix1_01.Name = "matrix1_01";
            this.matrix1_01.Size = new System.Drawing.Size(33, 20);
            this.matrix1_01.TabIndex = 11;
            // 
            // matrix1_10
            // 
            this.matrix1_10.Location = new System.Drawing.Point(313, 99);
            this.matrix1_10.Name = "matrix1_10";
            this.matrix1_10.Size = new System.Drawing.Size(33, 20);
            this.matrix1_10.TabIndex = 12;
            // 
            // matrix1_11
            // 
            this.matrix1_11.Location = new System.Drawing.Point(352, 99);
            this.matrix1_11.Name = "matrix1_11";
            this.matrix1_11.Size = new System.Drawing.Size(33, 20);
            this.matrix1_11.TabIndex = 13;
            // 
            // matrix2_00
            // 
            this.matrix2_00.Location = new System.Drawing.Point(425, 73);
            this.matrix2_00.Name = "matrix2_00";
            this.matrix2_00.Size = new System.Drawing.Size(33, 20);
            this.matrix2_00.TabIndex = 14;
            // 
            // matrix2_10
            // 
            this.matrix2_10.Location = new System.Drawing.Point(425, 99);
            this.matrix2_10.Name = "matrix2_10";
            this.matrix2_10.Size = new System.Drawing.Size(33, 20);
            this.matrix2_10.TabIndex = 15;
            // 
            // matrix2_11
            // 
            this.matrix2_11.Location = new System.Drawing.Point(464, 99);
            this.matrix2_11.Name = "matrix2_11";
            this.matrix2_11.Size = new System.Drawing.Size(33, 20);
            this.matrix2_11.TabIndex = 16;
            // 
            // matrix2_01
            // 
            this.matrix2_01.Location = new System.Drawing.Point(464, 73);
            this.matrix2_01.Name = "matrix2_01";
            this.matrix2_01.Size = new System.Drawing.Size(33, 20);
            this.matrix2_01.TabIndex = 17;
            // 
            // X
            // 
            this.X.Enabled = false;
            this.X.Location = new System.Drawing.Point(391, 73);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(28, 46);
            this.X.TabIndex = 18;
            this.X.Text = "X";
            this.X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matrixR_00
            // 
            this.matrixR_00.Location = new System.Drawing.Point(370, 210);
            this.matrixR_00.Name = "matrixR_00";
            this.matrixR_00.ReadOnly = true;
            this.matrixR_00.Size = new System.Drawing.Size(33, 20);
            this.matrixR_00.TabIndex = 19;
            // 
            // matrixR_01
            // 
            this.matrixR_01.Location = new System.Drawing.Point(409, 210);
            this.matrixR_01.Name = "matrixR_01";
            this.matrixR_01.ReadOnly = true;
            this.matrixR_01.Size = new System.Drawing.Size(33, 20);
            this.matrixR_01.TabIndex = 20;
            // 
            // matrixR_10
            // 
            this.matrixR_10.Location = new System.Drawing.Point(370, 236);
            this.matrixR_10.Name = "matrixR_10";
            this.matrixR_10.ReadOnly = true;
            this.matrixR_10.Size = new System.Drawing.Size(33, 20);
            this.matrixR_10.TabIndex = 21;
            // 
            // matrixR_11
            // 
            this.matrixR_11.Location = new System.Drawing.Point(409, 236);
            this.matrixR_11.Name = "matrixR_11";
            this.matrixR_11.ReadOnly = true;
            this.matrixR_11.Size = new System.Drawing.Size(33, 20);
            this.matrixR_11.TabIndex = 22;
            // 
            // MULTIPLY
            // 
            this.MULTIPLY.Location = new System.Drawing.Point(353, 135);
            this.MULTIPLY.Name = "MULTIPLY";
            this.MULTIPLY.Size = new System.Drawing.Size(105, 23);
            this.MULTIPLY.TabIndex = 23;
            this.MULTIPLY.Text = "MULTIPLY";
            this.MULTIPLY.UseVisualStyleBackColor = true;
            this.MULTIPLY.Click += new System.EventHandler(this.MULTIPLY_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(313, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Matrix 1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(425, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Matrix 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(353, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Output:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(281, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Any non-entered inputs are treated as 0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 294);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MULTIPLY);
            this.Controls.Add(this.matrixR_11);
            this.Controls.Add(this.matrixR_10);
            this.Controls.Add(this.matrixR_01);
            this.Controls.Add(this.matrixR_00);
            this.Controls.Add(this.X);
            this.Controls.Add(this.matrix2_01);
            this.Controls.Add(this.matrix2_11);
            this.Controls.Add(this.matrix2_10);
            this.Controls.Add(this.matrix2_00);
            this.Controls.Add(this.matrix1_11);
            this.Controls.Add(this.matrix1_10);
            this.Controls.Add(this.matrix1_01);
            this.Controls.Add(this.matrix1_00);
            this.Controls.Add(this.smOutputHint);
            this.Controls.Add(this.EVALUATE);
            this.Controls.Add(this.smHint);
            this.Controls.Add(this.smOutput);
            this.Controls.Add(this.smInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baconText);
            this.Controls.Add(this.GENERATE);
            this.Name = "Form1";
            this.Text = "RandomDependencies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GENERATE;
        private System.Windows.Forms.TextBox baconText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox smInput;
        private System.Windows.Forms.TextBox smOutput;
        private System.Windows.Forms.Label smHint;
        private System.Windows.Forms.Button EVALUATE;
        private System.Windows.Forms.Label smOutputHint;
        private System.Windows.Forms.TextBox matrix1_00;
        private System.Windows.Forms.TextBox matrix1_01;
        private System.Windows.Forms.TextBox matrix1_10;
        private System.Windows.Forms.TextBox matrix1_11;
        private System.Windows.Forms.TextBox matrix2_00;
        private System.Windows.Forms.TextBox matrix2_10;
        private System.Windows.Forms.TextBox matrix2_11;
        private System.Windows.Forms.TextBox matrix2_01;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.TextBox matrixR_00;
        private System.Windows.Forms.TextBox matrixR_01;
        private System.Windows.Forms.TextBox matrixR_10;
        private System.Windows.Forms.TextBox matrixR_11;
        private System.Windows.Forms.Button MULTIPLY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

