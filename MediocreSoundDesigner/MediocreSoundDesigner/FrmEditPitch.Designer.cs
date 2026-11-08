namespace MediocreSoundDesigner {
  partial class FrmEditPitch {
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
            nudSemitones = new NumericUpDown();
            lblSemitones = new Label();
            btnApply = new Button();
            btnCancel = new Button();
            lblArrow = new Label();
            lblPostKey = new Label();
            lblPreKey = new Label();
            pnlLayout = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)nudSemitones).BeginInit();
            pnlLayout.SuspendLayout();
            SuspendLayout();
            // 
            // nudSemitones
            // 
            nudSemitones.Anchor = AnchorStyles.None;
            pnlLayout.SetColumnSpan(nudSemitones, 2);
            nudSemitones.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudSemitones.Location = new Point(229, 11);
            nudSemitones.Margin = new Padding(7);
            nudSemitones.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nudSemitones.Minimum = new decimal(new int[] { 12, 0, 0, int.MinValue });
            nudSemitones.Name = "nudSemitones";
            nudSemitones.Size = new Size(98, 39);
            nudSemitones.TabIndex = 0;
            nudSemitones.TextAlign = HorizontalAlignment.Center;
            nudSemitones.ValueChanged += nudSemitones_ValueChanged;
            // 
            // lblSemitones
            // 
            lblSemitones.Anchor = AnchorStyles.None;
            lblSemitones.AutoSize = true;
            pnlLayout.SetColumnSpan(lblSemitones, 3);
            lblSemitones.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemitones.Location = new Point(41, 12);
            lblSemitones.Margin = new Padding(7, 0, 7, 0);
            lblSemitones.Name = "lblSemitones";
            lblSemitones.Size = new Size(158, 37);
            lblSemitones.TabIndex = 1;
            lblSemitones.Text = "Semitones:";
            lblSemitones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.Black;
            btnApply.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApply.ForeColor = Color.Lime;
            btnApply.Location = new Point(234, 162);
            btnApply.Margin = new Padding(7);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(125, 47);
            btnApply.TabIndex = 2;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.Black;
            btnCancel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(37, 162);
            btnCancel.Margin = new Padding(7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 47);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblArrow
            // 
            lblArrow.Anchor = AnchorStyles.None;
            lblArrow.AutoSize = true;
            lblArrow.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblArrow.Location = new Point(176, 67);
            lblArrow.Name = "lblArrow";
            lblArrow.Size = new Size(29, 30);
            lblArrow.TabIndex = 4;
            lblArrow.Text = "→";
            lblArrow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPostKey
            // 
            lblPostKey.Anchor = AnchorStyles.None;
            lblPostKey.AutoSize = true;
            lblPostKey.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPostKey.Location = new Point(216, 69);
            lblPostKey.Name = "lblPostKey";
            lblPostKey.Size = new Size(34, 25);
            lblPostKey.TabIndex = 5;
            lblPostKey.Text = "C4";
            lblPostKey.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPreKey
            // 
            lblPreKey.Anchor = AnchorStyles.None;
            lblPreKey.AutoSize = true;
            lblPreKey.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPreKey.Location = new Point(133, 69);
            lblPreKey.Name = "lblPreKey";
            lblPreKey.Size = new Size(34, 25);
            lblPreKey.TabIndex = 6;
            lblPreKey.Text = "C4";
            lblPreKey.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLayout
            // 
            pnlLayout.ColumnCount = 7;
            pnlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.392247F));
            pnlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1564255F));
            pnlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.7920742F));
            pnlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.31801F));
            pnlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.020833F));
            pnlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.697916F));
            pnlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.391484F));
            pnlLayout.Controls.Add(lblPreKey, 2, 1);
            pnlLayout.Controls.Add(lblArrow, 3, 1);
            pnlLayout.Controls.Add(lblPostKey, 4, 1);
            pnlLayout.Controls.Add(lblSemitones, 1, 0);
            pnlLayout.Controls.Add(nudSemitones, 4, 0);
            pnlLayout.Location = new Point(0, 39);
            pnlLayout.Name = "pnlLayout";
            pnlLayout.RowCount = 2;
            pnlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            pnlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            pnlLayout.Size = new Size(384, 103);
            pnlLayout.TabIndex = 7;
            // 
            // FrmEditPitch
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(381, 231);
            Controls.Add(pnlLayout);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Margin = new Padding(16, 17, 16, 17);
            Name = "FrmEditPitch";
            Text = "FrmEditPitch";
            ((System.ComponentModel.ISupportInitialize)nudSemitones).EndInit();
            pnlLayout.ResumeLayout(false);
            pnlLayout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudSemitones;
    private Label lblSemitones;
    private Button btnApply;
    private Button btnCancel;
        private Label lblArrow;
        private Label lblPostKey;
        private Label lblPreKey;
        private TableLayoutPanel pnlLayout;
    }
}