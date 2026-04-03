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
        TitleLabel = new System.Windows.Forms.Label();
        PartsDeleteButton = new System.Windows.Forms.Button();
        PartsModifyButton = new System.Windows.Forms.Button();
        ProductsModifyButton = new System.Windows.Forms.Button();
        ProductsDeleteButton = new System.Windows.Forms.Button();
        ExitButton = new System.Windows.Forms.Button();
        PartsAddButton = new System.Windows.Forms.Button();
        ProductsAddButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // PartsListView
        // 
        PartsListView.FullRowSelect = true;
        PartsListView.GridLines = true;
        PartsListView.Location = new System.Drawing.Point(12, 90);
        PartsListView.Name = "PartsListView";
        PartsListView.Size = new System.Drawing.Size(345, 141);
        PartsListView.TabIndex = 1;
        PartsListView.UseCompatibleStateImageBehavior = false;
        PartsListView.View = System.Windows.Forms.View.Details;
        // 
        // PartsLabel
        // 
        PartsLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
        PartsLabel.Location = new System.Drawing.Point(12, 51);
        PartsLabel.Name = "PartsLabel";
        PartsLabel.Size = new System.Drawing.Size(100, 36);
        PartsLabel.TabIndex = 2;
        PartsLabel.Text = "Parts:";
        // 
        // ProductsLabel
        // 
        ProductsLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
        ProductsLabel.Location = new System.Drawing.Point(443, 51);
        ProductsLabel.Name = "ProductsLabel";
        ProductsLabel.Size = new System.Drawing.Size(138, 36);
        ProductsLabel.TabIndex = 4;
        ProductsLabel.Text = "Products:";
        ProductsLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // ProductsListView
        // 
        ProductsListView.FullRowSelect = true;
        ProductsListView.GridLines = true;
        ProductsListView.Location = new System.Drawing.Point(443, 90);
        ProductsListView.Name = "ProductsListView";
        ProductsListView.Size = new System.Drawing.Size(345, 141);
        ProductsListView.TabIndex = 3;
        ProductsListView.UseCompatibleStateImageBehavior = false;
        ProductsListView.View = System.Windows.Forms.View.Details;
        // 
        // PartsSearchTextbox
        // 
        PartsSearchTextbox.Location = new System.Drawing.Point(257, 61);
        PartsSearchTextbox.Name = "PartsSearchTextbox";
        PartsSearchTextbox.PlaceholderText = "Search...";
        PartsSearchTextbox.Size = new System.Drawing.Size(100, 23);
        PartsSearchTextbox.TabIndex = 5;
        // 
        // PartsSearchButton
        // 
        PartsSearchButton.Location = new System.Drawing.Point(176, 61);
        PartsSearchButton.Name = "PartsSearchButton";
        PartsSearchButton.Size = new System.Drawing.Size(75, 23);
        PartsSearchButton.TabIndex = 6;
        PartsSearchButton.Text = "Search Parts";
        PartsSearchButton.UseVisualStyleBackColor = true;
        PartsSearchButton.Click += PartsSearchButton_Click;
        // 
        // ProductsSearchButton
        // 
        ProductsSearchButton.Location = new System.Drawing.Point(607, 61);
        ProductsSearchButton.Name = "ProductsSearchButton";
        ProductsSearchButton.Size = new System.Drawing.Size(75, 23);
        ProductsSearchButton.TabIndex = 8;
        ProductsSearchButton.Text = "Search Products";
        ProductsSearchButton.UseVisualStyleBackColor = true;
        ProductsSearchButton.Click += ProductsSearchButtonClick;
        // 
        // ProductsSearchTextbox
        // 
        ProductsSearchTextbox.Location = new System.Drawing.Point(688, 61);
        ProductsSearchTextbox.Name = "ProductsSearchTextbox";
        ProductsSearchTextbox.PlaceholderText = "Search...";
        ProductsSearchTextbox.Size = new System.Drawing.Size(100, 23);
        ProductsSearchTextbox.TabIndex = 7;
        // 
        // TitleLabel
        // 
        TitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
        TitleLabel.Location = new System.Drawing.Point(12, 9);
        TitleLabel.Name = "TitleLabel";
        TitleLabel.Size = new System.Drawing.Size(388, 39);
        TitleLabel.TabIndex = 9;
        TitleLabel.Text = "Inventory Management System";
        // 
        // PartsDeleteButton
        // 
        PartsDeleteButton.Location = new System.Drawing.Point(282, 237);
        PartsDeleteButton.Name = "PartsDeleteButton";
        PartsDeleteButton.Size = new System.Drawing.Size(75, 23);
        PartsDeleteButton.TabIndex = 10;
        PartsDeleteButton.Text = "Delete";
        PartsDeleteButton.UseVisualStyleBackColor = true;
        PartsDeleteButton.Click += PartsDeleteButton_Click;
        // 
        // PartsModifyButton
        // 
        PartsModifyButton.Location = new System.Drawing.Point(201, 237);
        PartsModifyButton.Name = "PartsModifyButton";
        PartsModifyButton.Size = new System.Drawing.Size(75, 23);
        PartsModifyButton.TabIndex = 11;
        PartsModifyButton.Text = "Modify";
        PartsModifyButton.UseVisualStyleBackColor = true;
        PartsModifyButton.Click += PartsModifyButton_Click;
        // 
        // ProductsModifyButton
        // 
        ProductsModifyButton.Location = new System.Drawing.Point(632, 237);
        ProductsModifyButton.Name = "ProductsModifyButton";
        ProductsModifyButton.Size = new System.Drawing.Size(75, 23);
        ProductsModifyButton.TabIndex = 13;
        ProductsModifyButton.Text = "Modify";
        ProductsModifyButton.UseVisualStyleBackColor = true;
        ProductsModifyButton.Click += ProductsModifyButton_Click;
        // 
        // ProductsDeleteButton
        // 
        ProductsDeleteButton.Location = new System.Drawing.Point(713, 237);
        ProductsDeleteButton.Name = "ProductsDeleteButton";
        ProductsDeleteButton.Size = new System.Drawing.Size(75, 23);
        ProductsDeleteButton.TabIndex = 12;
        ProductsDeleteButton.Text = "Delete";
        ProductsDeleteButton.UseVisualStyleBackColor = true;
        ProductsDeleteButton.Click += ProductsDeleteButton_Click;
        // 
        // ExitButton
        // 
        ExitButton.Location = new System.Drawing.Point(713, 281);
        ExitButton.Name = "ExitButton";
        ExitButton.Size = new System.Drawing.Size(75, 23);
        ExitButton.TabIndex = 14;
        ExitButton.Text = "Exit";
        ExitButton.UseVisualStyleBackColor = true;
        ExitButton.Click += ExitButton_Click;
        // 
        // PartsAddButton
        // 
        PartsAddButton.Location = new System.Drawing.Point(120, 237);
        PartsAddButton.Name = "PartsAddButton";
        PartsAddButton.Size = new System.Drawing.Size(75, 23);
        PartsAddButton.TabIndex = 15;
        PartsAddButton.Text = "Add";
        PartsAddButton.UseVisualStyleBackColor = true;
        PartsAddButton.Click += PartsAddButton_Click;
        // 
        // ProductsAddButton
        // 
        ProductsAddButton.Location = new System.Drawing.Point(551, 237);
        ProductsAddButton.Name = "ProductsAddButton";
        ProductsAddButton.Size = new System.Drawing.Size(75, 23);
        ProductsAddButton.TabIndex = 16;
        ProductsAddButton.Text = "Add";
        ProductsAddButton.UseVisualStyleBackColor = true;
        ProductsAddButton.Click += ProductsAddButton_Click;
        // 
        // mainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(ProductsAddButton);
        Controls.Add(PartsAddButton);
        Controls.Add(ExitButton);
        Controls.Add(ProductsModifyButton);
        Controls.Add(ProductsDeleteButton);
        Controls.Add(PartsModifyButton);
        Controls.Add(PartsDeleteButton);
        Controls.Add(TitleLabel);
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

    private System.Windows.Forms.Button PartsAddButton;
    private System.Windows.Forms.Button ProductsAddButton;

    private System.Windows.Forms.Label TitleLabel;
    private System.Windows.Forms.Button PartsDeleteButton;
    private System.Windows.Forms.Button PartsModifyButton;
    private System.Windows.Forms.Button ProductsModifyButton;
    private System.Windows.Forms.Button ProductsDeleteButton;
    private System.Windows.Forms.Button ExitButton;

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