namespace UDPListener
{
	partial class UDPListenerForm
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
			UDPListener.ToolStripClickThrough toolStrip1;
			System.Windows.Forms.ToolStripButton separatorToolStripButton;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UDPListenerForm));
			System.Windows.Forms.ToolStripButton clearToolStripButton;
			System.Windows.Forms.ToolStripButton copyToolStripButton;
			System.Windows.Forms.ToolStripButton copyAllToolStripButton;
			System.Windows.Forms.ToolStripButton copyCleartoolStripButton;
			System.Windows.Forms.ToolStripButton toolStripButton1;
			this._outputTextBox = new System.Windows.Forms.TextBox();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this._portTextBox = new System.Windows.Forms.ToolStripTextBox();
			toolStrip1 = new UDPListener.ToolStripClickThrough();
			separatorToolStripButton = new System.Windows.Forms.ToolStripButton();
			clearToolStripButton = new System.Windows.Forms.ToolStripButton();
			copyToolStripButton = new System.Windows.Forms.ToolStripButton();
			copyAllToolStripButton = new System.Windows.Forms.ToolStripButton();
			copyCleartoolStripButton = new System.Windows.Forms.ToolStripButton();
			toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _outputTextBox
			// 
			this._outputTextBox.BackColor = System.Drawing.Color.Black;
			this._outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._outputTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._outputTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this._outputTextBox.Location = new System.Drawing.Point(0, 0);
			this._outputTextBox.MaxLength = 512000;
			this._outputTextBox.Multiline = true;
			this._outputTextBox.Name = "_outputTextBox";
			this._outputTextBox.Size = new System.Drawing.Size(637, 306);
			this._outputTextBox.TabIndex = 1;
			this._outputTextBox.Text = "Test Message";
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this._outputTextBox);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(637, 306);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(637, 331);
			this.toolStripContainer1.TabIndex = 2;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
			// 
			// toolStrip1
			// 
			toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            separatorToolStripButton,
            this.toolStripSeparator3,
            clearToolStripButton,
            this.toolStripSeparator,
            copyToolStripButton,
            copyAllToolStripButton,
            this.toolStripSeparator2,
            copyCleartoolStripButton,
            this.toolStripSeparator1,
            this._portTextBox,
            toolStripButton1});
			toolStrip1.Location = new System.Drawing.Point(3, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new System.Drawing.Size(442, 25);
			toolStrip1.TabIndex = 0;
			// 
			// separatorToolStripButton
			// 
			separatorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			separatorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("separatorToolStripButton.Image")));
			separatorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			separatorToolStripButton.Name = "separatorToolStripButton";
			separatorToolStripButton.Size = new System.Drawing.Size(61, 22);
			separatorToolStripButton.Text = "Separator";
			separatorToolStripButton.Click += new System.EventHandler(this.OnSeparatorClicked);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// clearToolStripButton
			// 
			clearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			clearToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripButton.Image")));
			clearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			clearToolStripButton.Name = "clearToolStripButton";
			clearToolStripButton.Size = new System.Drawing.Size(38, 22);
			clearToolStripButton.Text = "Clear";
			clearToolStripButton.ToolTipText = "Clear";
			clearToolStripButton.Click += new System.EventHandler(this.OnClearClicked);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// copyToolStripButton
			// 
			copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
			copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			copyToolStripButton.Name = "copyToolStripButton";
			copyToolStripButton.Size = new System.Drawing.Size(39, 22);
			copyToolStripButton.Text = "Copy";
			copyToolStripButton.Click += new System.EventHandler(this.OnCopyClicked);
			// 
			// copyAllToolStripButton
			// 
			copyAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			copyAllToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyAllToolStripButton.Image")));
			copyAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			copyAllToolStripButton.Name = "copyAllToolStripButton";
			copyAllToolStripButton.Size = new System.Drawing.Size(53, 22);
			copyAllToolStripButton.Text = "CopyAll";
			copyAllToolStripButton.Click += new System.EventHandler(this.OnCopyAllClicked);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// copyCleartoolStripButton
			// 
			copyCleartoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			copyCleartoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyCleartoolStripButton.Image")));
			copyCleartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			copyCleartoolStripButton.Name = "copyCleartoolStripButton";
			copyCleartoolStripButton.Size = new System.Drawing.Size(66, 22);
			copyCleartoolStripButton.Text = "CopyClear";
			copyCleartoolStripButton.Click += new System.EventHandler(this.OnCopyClearClicked);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// _portTextBox
			// 
			this._portTextBox.Name = "_portTextBox";
			this._portTextBox.Size = new System.Drawing.Size(100, 25);
			this._portTextBox.Text = "11000";
			this._portTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnPortTextValidating);
			// 
			// toolStripButton1
			// 
			toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new System.Drawing.Size(47, 22);
			toolStripButton1.Text = "Restart";
			toolStripButton1.Click += new System.EventHandler(this.OnRestartClicked);
			// 
			// UDPListenerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(637, 331);
			this.Controls.Add(this.toolStripContainer1);
			this.Name = "UDPListenerForm";
			this.Text = "Listener";
			this.TopMost = true;
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ContentPanel.PerformLayout();
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox _outputTextBox;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripTextBox _portTextBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
	}
}

