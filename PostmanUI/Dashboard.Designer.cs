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
        resultsText = new TextBox();
        resultsLabel = new Label();
        statusStrip = new StatusStrip();
        systemStatus = new ToolStripStatusLabel();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // formHeader
        // 
        formHeader.AutoSize = true;
        formHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        formHeader.Location = new Point(74, 47);
        formHeader.Name = "formHeader";
        formHeader.Size = new Size(155, 47);
        formHeader.TabIndex = 0;
        formHeader.Text = "Postman";
        // 
        // apiLabel
        // 
        apiLabel.AutoSize = true;
        apiLabel.Location = new Point(74, 103);
        apiLabel.Name = "apiLabel";
        apiLabel.Size = new Size(60, 32);
        apiLabel.TabIndex = 1;
        apiLabel.Text = "API :";
        // 
        // apiText
        // 
        apiText.BackColor = Color.White;
        apiText.BorderStyle = BorderStyle.FixedSingle;
        apiText.Location = new Point(140, 103);
        apiText.Name = "apiText";
        apiText.Size = new Size(680, 39);
        apiText.TabIndex = 2;
        // 
        // callApi
        // 
        callApi.Location = new Point(837, 103);
        callApi.Name = "callApi";
        callApi.Size = new Size(85, 39);
        callApi.TabIndex = 3;
        callApi.Text = "Go";
        callApi.UseVisualStyleBackColor = true;
        callApi.Click += callApi_Click;
        // 
        // resultsText
        // 
        resultsText.BackColor = Color.White;
        resultsText.BorderStyle = BorderStyle.FixedSingle;
        resultsText.Location = new Point(74, 212);
        resultsText.Multiline = true;
        resultsText.Name = "resultsText";
        resultsText.ReadOnly = true;
        resultsText.ScrollBars = ScrollBars.Both;
        resultsText.Size = new Size(848, 382);
        resultsText.TabIndex = 4;
        // 
        // resultsLabel
        // 
        resultsLabel.AutoSize = true;
        resultsLabel.Location = new Point(74, 177);
        resultsLabel.Name = "resultsLabel";
        resultsLabel.Size = new Size(88, 32);
        resultsLabel.TabIndex = 5;
        resultsLabel.Text = "Results";
        // 
        // statusStrip
        // 
        statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
        statusStrip.Location = new Point(0, 617);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(1031, 30);
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
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1031, 647);
        Controls.Add(statusStrip);
        Controls.Add(resultsLabel);
        Controls.Add(resultsText);
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
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label formHeader;
    private Label apiLabel;
    private TextBox apiText;
    private Button callApi;
    private TextBox resultsText;
    private Label resultsLabel;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel systemStatus;
}
