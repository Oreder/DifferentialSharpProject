namespace _1__Differential
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
            this.label1 = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.DataGridView();
            this.problemBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtX0 = new System.Windows.Forms.TextBox();
            this.edtY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edtX1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.edtAlpha = new System.Windows.Forms.TextBox();
            this.edtStep = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Given ";
            // 
            // tab
            // 
            this.tab.AllowUserToAddRows = false;
            this.tab.AllowUserToDeleteRows = false;
            this.tab.AllowUserToResizeRows = false;
            this.tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column9,
            this.Column7,
            this.Column8,
            this.Column10});
            this.tab.Location = new System.Drawing.Point(4, 75);
            this.tab.Name = "tab";
            this.tab.ReadOnly = true;
            this.tab.RowHeadersVisible = false;
            this.tab.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tab.Size = new System.Drawing.Size(1005, 278);
            this.tab.TabIndex = 1;
            // 
            // problemBox
            // 
            this.problemBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.problemBox.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemBox.Location = new System.Drawing.Point(4, 5);
            this.problemBox.Name = "problemBox";
            this.problemBox.Size = new System.Drawing.Size(432, 64);
            this.problemBox.TabIndex = 2;
            this.problemBox.Text = "Problem: Solve differential equation with type below\n\t\tdy/dx = f(x, y)\nMethods: P" +
    "icard, Runge-Kutta (2 stages), explicit and implicit schemes. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Begining values:";
            // 
            // fBox
            // 
            this.fBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fBox.FormattingEnabled = true;
            this.fBox.Items.AddRange(new object[] {
            "f(x, y) = x² + y²",
            "f(x, y) = 1 + xy",
            "f(x, y) = 2x(1 + y)"});
            this.fBox.Location = new System.Drawing.Point(486, 6);
            this.fBox.Name = "fBox";
            this.fBox.Size = new System.Drawing.Size(125, 23);
            this.fBox.TabIndex = 4;
            this.fBox.SelectedIndexChanged += new System.EventHandler(this.fBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "to X1 =";
            // 
            // edtX0
            // 
            this.edtX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtX0.Location = new System.Drawing.Point(684, 6);
            this.edtX0.Name = "edtX0";
            this.edtX0.ReadOnly = true;
            this.edtX0.Size = new System.Drawing.Size(34, 20);
            this.edtX0.TabIndex = 6;
            this.edtX0.Text = "0";
            // 
            // edtY
            // 
            this.edtY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtY.Location = new System.Drawing.Point(577, 43);
            this.edtY.Name = "edtY";
            this.edtY.ReadOnly = true;
            this.edtY.Size = new System.Drawing.Size(34, 20);
            this.edtY.TabIndex = 8;
            this.edtY.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y(X0) =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "From X0 =";
            // 
            // edtX1
            // 
            this.edtX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtX1.Location = new System.Drawing.Point(767, 6);
            this.edtX1.Name = "edtX1";
            this.edtX1.Size = new System.Drawing.Size(34, 20);
            this.edtX1.TabIndex = 10;
            this.edtX1.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Steps:";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(823, 5);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(186, 58);
            this.showBtn.TabIndex = 13;
            this.showBtn.Text = "Show table";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(727, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Alpha:";
            // 
            // edtAlpha
            // 
            this.edtAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtAlpha.Location = new System.Drawing.Point(767, 44);
            this.edtAlpha.Name = "edtAlpha";
            this.edtAlpha.Size = new System.Drawing.Size(34, 20);
            this.edtAlpha.TabIndex = 15;
            this.edtAlpha.Text = "0.75";
            // 
            // edtStep
            // 
            this.edtStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtStep.Location = new System.Drawing.Point(670, 43);
            this.edtStep.Name = "edtStep";
            this.edtStep.Size = new System.Drawing.Size(48, 20);
            this.edtStep.TabIndex = 16;
            this.edtStep.Text = "10";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Picard #1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Picard #2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Picard #3";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Picard #4";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Runge–Kutta 2s [1]";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 110;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Runge-Kutta 2s [a]";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 110;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Explicit method";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 110;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Implicit method";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 110;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Modified method";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 354);
            this.Controls.Add(this.edtStep);
            this.Controls.Add(this.edtAlpha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edtX1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtX0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.problemBox);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Differential calculation";
            ((System.ComponentModel.ISupportInitialize)(this.tab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tab;
        private System.Windows.Forms.RichTextBox problemBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtX0;
        private System.Windows.Forms.TextBox edtY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtX1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtAlpha;
        private System.Windows.Forms.TextBox edtStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}

