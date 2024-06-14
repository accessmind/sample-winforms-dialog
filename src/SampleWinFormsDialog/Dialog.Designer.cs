namespace SampleWinFormsDialog;

partial class Dialog {
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
    private void InitializeComponent() {
        label1 = new Label();
        button1 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(28, 22);
        label1.Name = "label1";
        label1.Size = new Size(259, 15);
        label1.TabIndex = 0;
        label1.AccessibleRole = AccessibleRole.StaticText;
        label1.Text = "This text is not readable when opening the form";
        // 
        // button1
        // 
        button1.Location = new Point(212, 70);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 1;
        button1.Text = "&OK";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form2
        // 
        AcceptButton = button1;
        AccessibleRole = AccessibleRole.Dialog;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = button1;
        ClientSize = new Size(316, 105);
        Controls.Add(button1);
        Controls.Add(label1);
        Name = "Form2";
        Text = "Information";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Button button1;
}
