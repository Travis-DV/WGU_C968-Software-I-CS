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
        PartsLabel = new System.Windows.Forms.Label();
        ProductsLabel = new System.Windows.Forms.Label();
        ProductsListView = new System.Windows.Forms.ListView();
        PartsSearchTextbox = new System.Windows.Forms.TextBox();
        PartsSearchButton = new System.Windows.Forms.Button();
        ProductsSearchButton = new System.Windows.Forms.Button();
        ProductsSearchTextbox = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // PartsListView
        // 
        PartsListView.FullRowSelect = true;
        PartsListView.GridLines = true;
        PartsListView.Location = new System.Drawing.Point(12, 67);
        PartsListView.Name = "PartsListView";
        PartsListView.Size = new System.Drawing.Size(345, 141);
        PartsListView.TabIndex = 1;
        PartsListView.UseCompatibleStateImageBehavior = false;
        PartsListView.View = System.Windows.Forms.View.Details;
        // 
        // PartsLabel
        // 
        PartsLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
        PartsLabel.Location = new System.Drawing.Point(12, 28);
        PartsLabel.Name = "PartsLabel";
        PartsLabel.Size = new System.Drawing.Size(100, 36);
        PartsLabel.TabIndex = 2;
        PartsLabel.Text = "Parts:";
        // 
        // ProductsLabel
        // 
        ProductsLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
        ProductsLabel.Location = new System.Drawing.Point(443, 28);
        ProductsLabel.Name = "ProductsLabel";
        ProductsLabel.Size = new System.Drawing.Size(138, 36);
        ProductsLabel.TabIndex = 4;
        ProductsLabel.Text = "Products:";
        // 
        // ProductsListView
        // 
        ProductsListView.FullRowSelect = true;
        ProductsListView.GridLines = true;
        ProductsListView.Location = new System.Drawing.Point(443, 67);
        ProductsListView.Name = "ProductsListView";
        ProductsListView.Size = new System.Drawing.Size(345, 141);
        ProductsListView.TabIndex = 3;
        ProductsListView.UseCompatibleStateImageBehavior = false;
        ProductsListView.View = System.Windows.Forms.View.Details;
        // 
        // PartsSearchTextbox
        // 
        PartsSearchTextbox.Location = new System.Drawing.Point(257, 38);
        PartsSearchTextbox.Name = "PartsSearchTextbox";
        PartsSearchTextbox.PlaceholderText = "Search...";
        PartsSearchTextbox.Size = new System.Drawing.Size(100, 23);
        PartsSearchTextbox.TabIndex = 5;
        // 
        // PartsSearchButton
        // 
        PartsSearchButton.Location = new System.Drawing.Point(176, 38);
        PartsSearchButton.Name = "PartsSearchButton";
        PartsSearchButton.Size = new System.Drawing.Size(75, 23);
        PartsSearchButton.TabIndex = 6;
        PartsSearchButton.Text = "Search Parts";
        PartsSearchButton.UseVisualStyleBackColor = true;
        PartsSearchButton.Click += PartsSearchButton_Click;
        // 
        // ProductSearchButton
        // 
        ProductsSearchButton.Location = new System.Drawing.Point(607, 38);
        ProductsSearchButton.Name = "ProductsSearchButton";
        ProductsSearchButton.Size = new System.Drawing.Size(75, 23);
        ProductsSearchButton.TabIndex = 8;
        ProductsSearchButton.Text = "Search Products";
        ProductsSearchButton.UseVisualStyleBackColor = true;
        ProductsSearchButton.Click += ProductsSearchButtonClick;
        // 
        // ProductSearchTextbox
        // 
        ProductsSearchTextbox.Location = new System.Drawing.Point(688, 38);
        ProductsSearchTextbox.Name = "ProductsSearchTextbox";
        ProductsSearchTextbox.PlaceholderText = "Search...";
        ProductsSearchTextbox.Size = new System.Drawing.Size(100, 23);
        ProductsSearchTextbox.TabIndex = 7;
        // 
        // mainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(ProductsSearchButton);
        Controls.Add(ProductsSearchTextbox);
        Controls.Add(PartsSearchButton);
        Controls.Add(PartsSearchTextbox);
        Controls.Add(ProductsLabel);
        Controls.Add(ProductsListView);
        Controls.Add(PartsLabel);
        Controls.Add(PartsListView);
        Text = "Inventory Management System";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button ProductsSearchButton;
    private System.Windows.Forms.TextBox ProductsSearchTextbox;

    private System.Windows.Forms.TextBox PartsSearchTextbox;
    private System.Windows.Forms.Button PartsSearchButton;

    private System.Windows.Forms.Label ProductsLabel;
    private System.Windows.Forms.ListView ProductsListView;

    private System.Windows.Forms.Label PartsLabel;

    private System.Windows.Forms.ListView PartsListView;

    #endregion
}