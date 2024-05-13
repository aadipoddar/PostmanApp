namespace PostmanUI;

partial class Dashboard
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		formHeader = new Label();
		apiLabel = new Label();
		apiText = new TextBox();
		callApi = new Button();
		statusStrip = new StatusStrip();
		systemStatus = new ToolStripStatusLabel();
		httpVerbSelection = new ComboBox();
		callData = new TabControl();
		bodyTab = new TabPage();
		bodyText = new TextBox();
		resultsTab = new TabPage();
		resultsText = new TextBox();
		statusStrip.SuspendLayout();
		callData.SuspendLayout();
		bodyTab.SuspendLayout();
		resultsTab.SuspendLayout();
		SuspendLayout();
		// 
		// formHeader
		// 
		formHeader.AutoSize = true;
		formHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
		formHeader.Location = new Point(17, 26);
		formHeader.Name = "formHeader";
		formHeader.Size = new Size(155, 47);
		formHeader.TabIndex = 0;
		formHeader.Text = "Postman";
		// 
		// apiLabel
		// 
		apiLabel.AutoSize = true;
		apiLabel.Location = new Point(17, 84);
		apiLabel.Name = "apiLabel";
		apiLabel.Size = new Size(60, 32);
		apiLabel.TabIndex = 1;
		apiLabel.Text = "API :";
		// 
		// apiText
		// 
		apiText.BackColor = Color.White;
		apiText.BorderStyle = BorderStyle.FixedSingle;
		apiText.Location = new Point(206, 82);
		apiText.Name = "apiText";
		apiText.Size = new Size(659, 39);
		apiText.TabIndex = 2;
		// 
		// callApi
		// 
		callApi.Location = new Point(873, 81);
		callApi.Name = "callApi";
		callApi.Size = new Size(85, 39);
		callApi.TabIndex = 3;
		callApi.Text = "Go";
		callApi.UseVisualStyleBackColor = true;
		callApi.Click += callApi_Click;
		// 
		// statusStrip
		// 
		statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
		statusStrip.Location = new Point(0, 617);
		statusStrip.Name = "statusStrip";
		statusStrip.Size = new Size(988, 30);
		statusStrip.TabIndex = 6;
		statusStrip.Text = "statusStrip1";
		// 
		// systemStatus
		// 
		systemStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
		systemStatus.Name = "systemStatus";
		systemStatus.Size = new Size(62, 25);
		systemStatus.Text = "Ready";
		// 
		// httpVerbSelection
		// 
		httpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
		httpVerbSelection.FormattingEnabled = true;
		httpVerbSelection.Items.AddRange(new object[] { "GET", "POST" });
		httpVerbSelection.Location = new Point(83, 82);
		httpVerbSelection.Name = "httpVerbSelection";
		httpVerbSelection.Size = new Size(104, 40);
		httpVerbSelection.TabIndex = 7;
		// 
		// callData
		// 
		callData.Controls.Add(bodyTab);
		callData.Controls.Add(resultsTab);
		callData.Location = new Point(17, 142);
		callData.Name = "callData";
		callData.SelectedIndex = 0;
		callData.Size = new Size(941, 461);
		callData.TabIndex = 8;
		// 
		// bodyTab
		// 
		bodyTab.Controls.Add(bodyText);
		bodyTab.Location = new Point(4, 41);
		bodyTab.Name = "bodyTab";
		bodyTab.Padding = new Padding(3);
		bodyTab.Size = new Size(933, 416);
		bodyTab.TabIndex = 0;
		bodyTab.Text = "Body";
		bodyTab.UseVisualStyleBackColor = true;
		// 
		// bodyText
		// 
		bodyText.Dock = DockStyle.Fill;
		bodyText.Location = new Point(3, 3);
		bodyText.Multiline = true;
		bodyText.Name = "bodyText";
		bodyText.Size = new Size(927, 410);
		bodyText.TabIndex = 10;
		// 
		// resultsTab
		// 
		resultsTab.Controls.Add(resultsText);
		resultsTab.Location = new Point(4, 24);
		resultsTab.Name = "resultsTab";
		resultsTab.Padding = new Padding(3);
		resultsTab.Size = new Size(933, 433);
		resultsTab.TabIndex = 1;
		resultsTab.Text = "Results";
		resultsTab.UseVisualStyleBackColor = true;
		// 
		// resultsText
		// 
		resultsText.BackColor = Color.White;
		resultsText.BorderStyle = BorderStyle.FixedSingle;
		resultsText.Dock = DockStyle.Fill;
		resultsText.Location = new Point(3, 3);
		resultsText.Multiline = true;
		resultsText.Name = "resultsText";
		resultsText.ReadOnly = true;
		resultsText.ScrollBars = ScrollBars.Both;
		resultsText.Size = new Size(927, 427);
		resultsText.TabIndex = 6;
		// 
		// Dashboard
		// 
		AutoScaleDimensions = new SizeF(13F, 32F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.White;
		ClientSize = new Size(988, 647);
		Controls.Add(callData);
		Controls.Add(httpVerbSelection);
		Controls.Add(statusStrip);
		Controls.Add(callApi);
		Controls.Add(apiText);
		Controls.Add(apiLabel);
		Controls.Add(formHeader);
		Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Margin = new Padding(6);
		Name = "Dashboard";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "Postman";
		statusStrip.ResumeLayout(false);
		statusStrip.PerformLayout();
		callData.ResumeLayout(false);
		bodyTab.ResumeLayout(false);
		bodyTab.PerformLayout();
		resultsTab.ResumeLayout(false);
		resultsTab.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Label formHeader;
    private Label apiLabel;
    private TextBox apiText;
    private Button callApi;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel systemStatus;
	private ComboBox httpVerbSelection;
	private TabControl callData;
	private TabPage bodyTab;
	private TabPage resultsTab;
	private TextBox resultsText;
	private TextBox bodyText;
}
