namespace WGU_C968_Software_I_CS;

partial class mainForm
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        PartsListView = new System.Windows.Forms.ListView();
        SuspendLayout();
        // 
        // PartsListView
        // 
        PartsListView.FullRowSelect = true;
        PartsListView.GridLines = true;
        PartsListView.Location = new System.Drawing.Point(12, 12);
        PartsListView.Name = "PartsListView";
        PartsListView.Size = new System.Drawing.Size(345, 141);
        PartsListView.TabIndex = 1;
        PartsListView.UseCompatibleStateImageBehavior = false;
        PartsListView.View = System.Windows.Forms.View.Details;
        
        PartsListView.Columns.Add("ID", -2, HorizontalAlignment.Center);
        PartsListView.Columns.Add("Name", -2, HorizontalAlignment.Center);
        PartsListView.Columns.Add("Price", -2, HorizontalAlignment.Center);
        PartsListView.Columns.Add("InStock", -2, HorizontalAlignment.Center);
        PartsListView.Columns.Add("Minimum", -2, HorizontalAlignment.Center);
        PartsListView.Columns.Add("Maximum", -2, HorizontalAlignment.Center);
        // 
        // mainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(PartsListView);
        Text = "Inventory Management System";
        ResumeLayout(false);
    }

    private System.Windows.Forms.ListView PartsListView;

    #endregion
}