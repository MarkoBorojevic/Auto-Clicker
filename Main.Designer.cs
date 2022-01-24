
namespace Auto_Clicker
{
    partial class Main
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
            this.activateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mouseDownMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.mouseDownMin = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mouseUpMax = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.mouseUpMin = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cursorMoveCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseDownMin)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseUpMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseUpMin)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // activateButton
            // 
            this.activateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateButton.Location = new System.Drawing.Point(170, 12);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(269, 219);
            this.activateButton.TabIndex = 0;
            this.activateButton.Text = "ACTIVATE";
            this.activateButton.UseVisualStyleBackColor = true;
            this.activateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marko\'s Awesome Auto Clicker\r\nToggle hotkey = Hold Alt\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mouseDownMax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mouseDownMin);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mouse Down";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max.";
            // 
            // mouseDownMax
            // 
            this.mouseDownMax.Location = new System.Drawing.Point(42, 45);
            this.mouseDownMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.mouseDownMax.Name = "mouseDownMax";
            this.mouseDownMax.Size = new System.Drawing.Size(102, 20);
            this.mouseDownMax.TabIndex = 4;
            this.mouseDownMax.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Min.";
            // 
            // mouseDownMin
            // 
            this.mouseDownMin.Location = new System.Drawing.Point(42, 19);
            this.mouseDownMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.mouseDownMin.Name = "mouseDownMin";
            this.mouseDownMin.Size = new System.Drawing.Size(102, 20);
            this.mouseDownMin.TabIndex = 3;
            this.mouseDownMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.mouseUpMax);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.mouseUpMin);
            this.groupBox2.Location = new System.Drawing.Point(15, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 73);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mouse Up";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Max.";
            // 
            // mouseUpMax
            // 
            this.mouseUpMax.Location = new System.Drawing.Point(42, 45);
            this.mouseUpMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.mouseUpMax.Name = "mouseUpMax";
            this.mouseUpMax.Size = new System.Drawing.Size(102, 20);
            this.mouseUpMax.TabIndex = 4;
            this.mouseUpMax.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Min.";
            // 
            // mouseUpMin
            // 
            this.mouseUpMin.Location = new System.Drawing.Point(42, 19);
            this.mouseUpMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.mouseUpMin.Name = "mouseUpMin";
            this.mouseUpMin.Size = new System.Drawing.Size(102, 20);
            this.mouseUpMin.TabIndex = 3;
            this.mouseUpMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 241);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(451, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // cursorMoveCheckBox
            // 
            this.cursorMoveCheckBox.AutoSize = true;
            this.cursorMoveCheckBox.Location = new System.Drawing.Point(15, 209);
            this.cursorMoveCheckBox.Name = "cursorMoveCheckBox";
            this.cursorMoveCheckBox.Size = new System.Drawing.Size(127, 17);
            this.cursorMoveCheckBox.TabIndex = 5;
            this.cursorMoveCheckBox.Text = "Randomly shift cursor\r\n";
            this.cursorMoveCheckBox.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 263);
            this.Controls.Add(this.cursorMoveCheckBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(467, 302);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marko\'s Awesome Auto Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseDownMin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseUpMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseUpMin)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button activateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown mouseDownMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown mouseDownMin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown mouseUpMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown mouseUpMin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox cursorMoveCheckBox;
    }
}

