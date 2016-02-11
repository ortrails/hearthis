namespace HearThis.UI
{
	partial class RecordInPartsDlg
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._audioButtonsFirst = new HearThis.UI.AudioButtonsControl();
			this._audioButtonsSecond = new HearThis.UI.AudioButtonsControl();
			this._audioButtonsBoth = new HearThis.UI.AudioButtonsControl();
			this._firstLabel = new System.Windows.Forms.Label();
			this.labelSecond = new System.Windows.Forms.Label();
			this.labelBoth = new System.Windows.Forms.Label();
			this._cancelButton = new System.Windows.Forms.Button();
			this._useRecordingsButton = new System.Windows.Forms.Button();
			this._instructionsLabel = new System.Windows.Forms.Label();
			this._recordTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// _audioButtonsFirst
			// 
			this._audioButtonsFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._audioButtonsFirst.BackColor = System.Drawing.Color.Transparent;
			this._audioButtonsFirst.ButtonHighlightMode = HearThis.UI.AudioButtonsControl.ButtonHighlightModes.Default;
			this._audioButtonsFirst.Location = new System.Drawing.Point(563, 197);
			this._audioButtonsFirst.Name = "_audioButtonsFirst";
			this._audioButtonsFirst.RecordingDevice = null;
			this._audioButtonsFirst.Size = new System.Drawing.Size(77, 43);
			this._audioButtonsFirst.TabIndex = 21;
			// 
			// _audioButtonsSecond
			// 
			this._audioButtonsSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._audioButtonsSecond.BackColor = System.Drawing.Color.Transparent;
			this._audioButtonsSecond.ButtonHighlightMode = HearThis.UI.AudioButtonsControl.ButtonHighlightModes.Default;
			this._audioButtonsSecond.Location = new System.Drawing.Point(563, 263);
			this._audioButtonsSecond.Name = "_audioButtonsSecond";
			this._audioButtonsSecond.RecordingDevice = null;
			this._audioButtonsSecond.Size = new System.Drawing.Size(77, 43);
			this._audioButtonsSecond.TabIndex = 22;
			// 
			// _audioButtonsBoth
			// 
			this._audioButtonsBoth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._audioButtonsBoth.BackColor = System.Drawing.Color.Transparent;
			this._audioButtonsBoth.ButtonHighlightMode = HearThis.UI.AudioButtonsControl.ButtonHighlightModes.Default;
			this._audioButtonsBoth.Location = new System.Drawing.Point(563, 326);
			this._audioButtonsBoth.Name = "_audioButtonsBoth";
			this._audioButtonsBoth.RecordingDevice = null;
			this._audioButtonsBoth.Size = new System.Drawing.Size(37, 43);
			this._audioButtonsBoth.TabIndex = 23;
			// 
			// _firstLabel
			// 
			this._firstLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._firstLabel.AutoSize = true;
			this._firstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this._firstLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
			this._firstLabel.Location = new System.Drawing.Point(538, 203);
			this._firstLabel.Name = "_firstLabel";
			this._firstLabel.Size = new System.Drawing.Size(26, 29);
			this._firstLabel.TabIndex = 24;
			this._firstLabel.Text = "1";
			// 
			// labelSecond
			// 
			this.labelSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSecond.AutoSize = true;
			this.labelSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.labelSecond.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelSecond.Location = new System.Drawing.Point(538, 269);
			this.labelSecond.Name = "labelSecond";
			this.labelSecond.Size = new System.Drawing.Size(26, 29);
			this.labelSecond.TabIndex = 25;
			this.labelSecond.Text = "2";
			// 
			// labelBoth
			// 
			this.labelBoth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelBoth.AutoSize = true;
			this.labelBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.labelBoth.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelBoth.Location = new System.Drawing.Point(511, 332);
			this.labelBoth.Name = "labelBoth";
			this.labelBoth.Size = new System.Drawing.Size(53, 29);
			this.labelBoth.TabIndex = 26;
			this.labelBoth.Text = "1+2";
			// 
			// _cancelButton
			// 
			this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._cancelButton.Location = new System.Drawing.Point(377, 411);
			this._cancelButton.Name = "_cancelButton";
			this._cancelButton.Size = new System.Drawing.Size(75, 23);
			this._cancelButton.TabIndex = 27;
			this._cancelButton.Text = "Cancel";
			this._cancelButton.UseVisualStyleBackColor = true;
			// 
			// _useRecordingsButton
			// 
			this._useRecordingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._useRecordingsButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._useRecordingsButton.Location = new System.Drawing.Point(489, 411);
			this._useRecordingsButton.Name = "_useRecordingsButton";
			this._useRecordingsButton.Size = new System.Drawing.Size(151, 23);
			this._useRecordingsButton.TabIndex = 28;
			this._useRecordingsButton.Text = "&Use These Recordings";
			this._useRecordingsButton.UseVisualStyleBackColor = true;
			// 
			// _instructionsLabel
			// 
			this._instructionsLabel.AutoSize = true;
			this._instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this._instructionsLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
			this._instructionsLabel.Location = new System.Drawing.Point(23, 25);
			this._instructionsLabel.Name = "_instructionsLabel";
			this._instructionsLabel.Size = new System.Drawing.Size(575, 17);
			this._instructionsLabel.TabIndex = 29;
			this._instructionsLabel.Text = "You can divide the line wherever you want. Just record the first part, then the s" +
    "econd part.";
			// 
			// _recordTextBox
			// 
			this._recordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._recordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this._recordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._recordTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this._recordTextBox.Location = new System.Drawing.Point(27, 73);
			this._recordTextBox.Name = "_recordTextBox";
			this._recordTextBox.Size = new System.Drawing.Size(478, 317);
			this._recordTextBox.TabIndex = 30;
			this._recordTextBox.Text = "";
			// 
			// RecordInPartsDlg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this.ClientSize = new System.Drawing.Size(685, 469);
			this.Controls.Add(this._recordTextBox);
			this.Controls.Add(this._instructionsLabel);
			this.Controls.Add(this._useRecordingsButton);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this.labelBoth);
			this.Controls.Add(this.labelSecond);
			this.Controls.Add(this._firstLabel);
			this.Controls.Add(this._audioButtonsBoth);
			this.Controls.Add(this._audioButtonsSecond);
			this.Controls.Add(this._audioButtonsFirst);
			this.Name = "RecordInPartsDlg";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Record Long Line in Parts";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private AudioButtonsControl _audioButtonsFirst;
		private AudioButtonsControl _audioButtonsSecond;
		private AudioButtonsControl _audioButtonsBoth;
		private System.Windows.Forms.Label _firstLabel;
		private System.Windows.Forms.Label labelSecond;
		private System.Windows.Forms.Label labelBoth;
		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.Button _useRecordingsButton;
		private System.Windows.Forms.Label _instructionsLabel;
		private System.Windows.Forms.RichTextBox _recordTextBox;
	}
}