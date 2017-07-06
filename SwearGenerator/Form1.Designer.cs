namespace SwearGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkMultiple = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkClipboard = new System.Windows.Forms.CheckBox();
            this.numericMultiple = new System.Windows.Forms.NumericUpDown();
            this.checkDebug = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMultiple)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ammount";
            // 
            // checkMultiple
            // 
            this.checkMultiple.AutoSize = true;
            this.checkMultiple.Location = new System.Drawing.Point(273, 21);
            this.checkMultiple.Name = "checkMultiple";
            this.checkMultiple.Size = new System.Drawing.Size(96, 17);
            this.checkMultiple.TabIndex = 11;
            this.checkMultiple.Text = "Multiple Words";
            this.checkMultiple.UseVisualStyleBackColor = true;
            this.checkMultiple.CheckedChanged += new System.EventHandler(this.checkMultiple_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 82);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(372, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel1.Text = "statusLabel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 59);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkClipboard
            // 
            this.checkClipboard.AutoSize = true;
            this.checkClipboard.Location = new System.Drawing.Point(151, 21);
            this.checkClipboard.Name = "checkClipboard";
            this.checkClipboard.Size = new System.Drawing.Size(109, 17);
            this.checkClipboard.TabIndex = 7;
            this.checkClipboard.Text = "Copy to Clipboard";
            this.checkClipboard.UseVisualStyleBackColor = true;
            // 
            // numericMultiple
            // 
            this.numericMultiple.Enabled = false;
            this.numericMultiple.Location = new System.Drawing.Point(273, 43);
            this.numericMultiple.Name = "numericMultiple";
            this.numericMultiple.Size = new System.Drawing.Size(34, 20);
            this.numericMultiple.TabIndex = 12;
            this.numericMultiple.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericMultiple.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkDebug
            // 
            this.checkDebug.AutoSize = true;
            this.checkDebug.Location = new System.Drawing.Point(151, 44);
            this.checkDebug.Name = "checkDebug";
            this.checkDebug.Size = new System.Drawing.Size(88, 17);
            this.checkDebug.TabIndex = 9;
            this.checkDebug.Text = "Debug Mode";
            this.checkDebug.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 104);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkMultiple);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkClipboard);
            this.Controls.Add(this.numericMultiple);
            this.Controls.Add(this.checkDebug);
            this.Name = "Form1";
            this.Text = "SwearWord Generator";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMultiple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkMultiple;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkClipboard;
        private System.Windows.Forms.NumericUpDown numericMultiple;
        private System.Windows.Forms.CheckBox checkDebug;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

