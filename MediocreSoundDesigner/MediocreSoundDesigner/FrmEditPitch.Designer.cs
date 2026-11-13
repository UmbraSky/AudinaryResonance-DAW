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
            pnlSemitoneLayout = new TableLayoutPanel();
            pnlOptsLayout = new TableLayoutPanel();
            dropOversampling = new ComboBox();
            label4 = new Label();
            dropFFT = new ComboBox();
            lblOversampling = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSemitones).BeginInit();
            pnlSemitoneLayout.SuspendLayout();
            pnlOptsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // nudSemitones
            // 
            nudSemitones.Anchor = AnchorStyles.None;
            pnlSemitoneLayout.SetColumnSpan(nudSemitones, 2);
            nudSemitones.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudSemitones.Location = new Point(264, 8);
            nudSemitones.Margin = new Padding(7);
            nudSemitones.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nudSemitones.Minimum = new decimal(new int[] { 12, 0, 0, int.MinValue });
            nudSemitones.Name = "nudSemitones";
            nudSemitones.Size = new Size(98, 36);
            nudSemitones.TabIndex = 0;
            nudSemitones.TextAlign = HorizontalAlignment.Center;
            nudSemitones.ValueChanged += nudSemitones_ValueChanged;
            // 
            // lblSemitones
            // 
            lblSemitones.Anchor = AnchorStyles.None;
            lblSemitones.AutoSize = true;
            pnlSemitoneLayout.SetColumnSpan(lblSemitones, 3);
            lblSemitones.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemitones.Location = new Point(96, 10);
            lblSemitones.Margin = new Padding(7, 0, 7, 0);
            lblSemitones.Name = "lblSemitones";
            lblSemitones.Size = new Size(139, 32);
            lblSemitones.TabIndex = 1;
            lblSemitones.Text = "Semitones:";
            lblSemitones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.Black;
            btnApply.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApply.ForeColor = Color.Lime;
            btnApply.Location = new Point(264, 280);
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
            btnCancel.Location = new Point(67, 280);
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
            lblArrow.Location = new Point(212, 55);
            lblArrow.Name = "lblArrow";
            lblArrow.Size = new Size(32, 30);
            lblArrow.TabIndex = 4;
            lblArrow.Text = "→";
            lblArrow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPostKey
            // 
            lblPostKey.Anchor = AnchorStyles.None;
            lblPostKey.AutoSize = true;
            lblPostKey.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPostKey.Location = new Point(263, 57);
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
            lblPreKey.Location = new Point(158, 57);
            lblPreKey.Name = "lblPreKey";
            lblPreKey.Size = new Size(34, 25);
            lblPreKey.TabIndex = 6;
            lblPreKey.Text = "C4";
            lblPreKey.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSemitoneLayout
            // 
            pnlSemitoneLayout.ColumnCount = 7;
            pnlSemitoneLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5769215F));
            pnlSemitoneLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4905691F));
            pnlSemitoneLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.8562508F));
            pnlSemitoneLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.1589136F));
            pnlSemitoneLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.8535147F));
            pnlSemitoneLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.48909F));
            pnlSemitoneLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5747471F));
            pnlSemitoneLayout.Controls.Add(lblPreKey, 2, 1);
            pnlSemitoneLayout.Controls.Add(lblArrow, 3, 1);
            pnlSemitoneLayout.Controls.Add(lblPostKey, 4, 1);
            pnlSemitoneLayout.Controls.Add(lblSemitones, 1, 0);
            pnlSemitoneLayout.Controls.Add(nudSemitones, 4, 0);
            pnlSemitoneLayout.Location = new Point(0, 49);
            pnlSemitoneLayout.Name = "pnlSemitoneLayout";
            pnlSemitoneLayout.RowCount = 2;
            pnlSemitoneLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            pnlSemitoneLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            pnlSemitoneLayout.Size = new Size(459, 88);
            pnlSemitoneLayout.TabIndex = 7;
            // 
            // pnlOptsLayout
            // 
            pnlOptsLayout.ColumnCount = 7;
            pnlOptsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5769215F));
            pnlOptsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4905691F));
            pnlOptsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.8562508F));
            pnlOptsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.1589136F));
            pnlOptsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.8535147F));
            pnlOptsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.48909F));
            pnlOptsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5747471F));
            pnlOptsLayout.Controls.Add(dropOversampling, 4, 1);
            pnlOptsLayout.Controls.Add(label4, 1, 0);
            pnlOptsLayout.Controls.Add(dropFFT, 4, 0);
            pnlOptsLayout.Controls.Add(lblOversampling, 1, 1);
            pnlOptsLayout.Location = new Point(0, 153);
            pnlOptsLayout.Name = "pnlOptsLayout";
            pnlOptsLayout.RowCount = 2;
            pnlOptsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            pnlOptsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            pnlOptsLayout.Size = new Size(459, 117);
            pnlOptsLayout.TabIndex = 8;
            // 
            // dropOversampling
            // 
            dropOversampling.Anchor = AnchorStyles.None;
            pnlOptsLayout.SetColumnSpan(dropOversampling, 2);
            dropOversampling.DropDownStyle = ComboBoxStyle.DropDownList;
            dropOversampling.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dropOversampling.FormattingEnabled = true;
            dropOversampling.Items.AddRange(new object[] { "4", "8", "16", "32" });
            dropOversampling.Location = new Point(254, 77);
            dropOversampling.Name = "dropOversampling";
            dropOversampling.Size = new Size(118, 33);
            dropOversampling.TabIndex = 4;
            dropOversampling.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            pnlOptsLayout.SetColumnSpan(label4, 3);
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(121, 22);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 1;
            label4.Text = "FFT Size:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dropFFT
            // 
            dropFFT.Anchor = AnchorStyles.None;
            pnlOptsLayout.SetColumnSpan(dropFFT, 2);
            dropFFT.DropDownStyle = ComboBoxStyle.DropDownList;
            dropFFT.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dropFFT.FormattingEnabled = true;
            dropFFT.Items.AddRange(new object[] { "256", "512", "1024", "2048", "4096" });
            dropFFT.Location = new Point(254, 18);
            dropFFT.Name = "dropFFT";
            dropFFT.Size = new Size(118, 33);
            dropFFT.TabIndex = 2;
            dropFFT.UseWaitCursor = true;
            // 
            // lblOversampling
            // 
            lblOversampling.Anchor = AnchorStyles.None;
            lblOversampling.AutoSize = true;
            pnlOptsLayout.SetColumnSpan(lblOversampling, 3);
            lblOversampling.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOversampling.Location = new Point(105, 72);
            lblOversampling.Margin = new Padding(7, 0, 7, 0);
            lblOversampling.Name = "lblOversampling";
            lblOversampling.Size = new Size(121, 42);
            lblOversampling.TabIndex = 3;
            lblOversampling.Text = "STFT Oversampling:";
            lblOversampling.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmEditPitch
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(459, 343);
            Controls.Add(pnlOptsLayout);
            Controls.Add(pnlSemitoneLayout);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Margin = new Padding(16, 17, 16, 17);
            Name = "FrmEditPitch";
            Text = "FrmEditPitch";
            ((System.ComponentModel.ISupportInitialize)nudSemitones).EndInit();
            pnlSemitoneLayout.ResumeLayout(false);
            pnlSemitoneLayout.PerformLayout();
            pnlOptsLayout.ResumeLayout(false);
            pnlOptsLayout.PerformLayout();
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
        private TableLayoutPanel pnlSemitoneLayout;
        private TableLayoutPanel pnlOptsLayout;
        private Label label4;
        private ComboBox dropFFT;
        private ComboBox dropOversampling;
        private Label lblOversampling;
    }
}