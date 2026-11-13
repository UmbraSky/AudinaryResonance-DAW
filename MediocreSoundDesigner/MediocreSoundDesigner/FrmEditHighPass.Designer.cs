namespace MediocreSoundDesigner {
  partial class FrmEditHighPass {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
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
            btnCancel = new Button();
            btnApply = new Button();
            nudFreq = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudFreq).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.Black;
            btnCancel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(156, 208);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 47);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnApply
            // 
            btnApply.AutoSize = true;
            btnApply.BackColor = Color.Black;
            btnApply.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApply.ForeColor = Color.Lime;
            btnApply.Location = new Point(387, 208);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(103, 47);
            btnApply.TabIndex = 4;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // nudFreq
            // 
            nudFreq.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            nudFreq.Location = new Point(376, 99);
            nudFreq.Maximum = new decimal(new int[] { 22050, 0, 0, 0 });
            nudFreq.Name = "nudFreq";
            nudFreq.Size = new Size(114, 43);
            nudFreq.TabIndex = 9;
            nudFreq.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 101);
            label1.Name = "label1";
            label1.Size = new Size(237, 37);
            label1.TabIndex = 10;
            label1.Text = "Cutoff Frequency";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 19);
            label3.Name = "label3";
            label3.Size = new Size(0, 37);
            label3.TabIndex = 13;
            // 
            // FrmEditHighPass
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(665, 277);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(nudFreq);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Name = "FrmEditHighPass";
            Text = "FrmEditLowPass";
            ((System.ComponentModel.ISupportInitialize)nudFreq).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
    private Button btnApply;
    private NumericUpDown nudFreq;
    private Label label1;
    private Label label3;
  }
}