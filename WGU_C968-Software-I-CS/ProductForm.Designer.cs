using System.ComponentModel;

namespace WGU_C968_Software_I_CS;

partial class ProductForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        AllPartsListView = new System.Windows.Forms.ListView();
        AllPartsLabel = new System.Windows.Forms.Label();
        AssociatedPartsLabel = new System.Windows.Forms.Label();
        AssociatedPartsListView = new System.Windows.Forms.ListView();
        AllPartsSearchTextbox = new System.Windows.Forms.TextBox();
        AllPartsSearchButton = new System.Windows.Forms.Button();
        TitleLabel = new System.Windows.Forms.Label();
        RemovePartButton = new System.Windows.Forms.Button();
        CancelButton2 = new System.Windows.Forms.Button();
        AddPartButton = new System.Windows.Forms.Button();
        IDLabel = new System.Windows.Forms.Label();
        IDTextbox = new System.Windows.Forms.TextBox();
        NameTextbox = new System.Windows.Forms.TextBox();
        NameLabel = new System.Windows.Forms.Label();
        InventoryTextbox = new System.Windows.Forms.TextBox();
        InventoryLabel = new System.Windows.Forms.Label();
        PriceTextbox = new System.Windows.Forms.TextBox();
        PriceLabel = new System.Windows.Forms.Label();
        MinLabel = new System.Windows.Forms.Label();
        MaxTextbox = new System.Windows.Forms.TextBox();
        MinTextbox = new System.Windows.Forms.TextBox();
        SaveButton = new System.Windows.Forms.Button();
        MaxLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // AllPartsListView
        // 
        AllPartsListView.FullRowSelect = true;
        AllPartsListView.GridLines = true;
        AllPartsListView.Location = new System.Drawing.Point(443, 90);
        AllPartsListView.Name = "AllPartsListView";
        AllPartsListView.Size = new System.Drawing.Size(345, 141);
        AllPartsListView.TabIndex = 17;
        AllPartsListView.UseCompatibleStateImageBehavior = false;
        AllPartsListView.View = System.Windows.Forms.View.Details;
        // 
        // AllPartsLabel
        // 
        AllPartsLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
        AllPartsLabel.Location = new System.Drawing.Point(443, 51);
        AllPartsLabel.Name = "AllPartsLabel";
        AllPartsLabel.Size = new System.Drawing.Size(100, 36);
        AllPartsLabel.TabIndex = 14;
        AllPartsLabel.Text = "All Parts:";
        // 
        // AssociatedPartsLabel
        // 
        AssociatedPartsLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
        AssociatedPartsLabel.Location = new System.Drawing.Point(443, 260);
        AssociatedPartsLabel.Name = "AssociatedPartsLabel";
        AssociatedPartsLabel.Size = new System.Drawing.Size(167, 36);
        AssociatedPartsLabel.TabIndex = 19;
        AssociatedPartsLabel.Text = "Associated Parts:";
        AssociatedPartsLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // AssociatedPartsListView
        // 
        AssociatedPartsListView.FullRowSelect = true;
        AssociatedPartsListView.GridLines = true;
        AssociatedPartsListView.Location = new System.Drawing.Point(443, 299);
        AssociatedPartsListView.Name = "AssociatedPartsListView";
        AssociatedPartsListView.Size = new System.Drawing.Size(345, 141);
        AssociatedPartsListView.TabIndex = 20;
        AssociatedPartsListView.UseCompatibleStateImageBehavior = false;
        AssociatedPartsListView.View = System.Windows.Forms.View.Details;
        // 
        // AllPartsSearchTextbox
        // 
        AllPartsSearchTextbox.Location = new System.Drawing.Point(688, 61);
        AllPartsSearchTextbox.Name = "AllPartsSearchTextbox";
        AllPartsSearchTextbox.PlaceholderText = "Search...";
        AllPartsSearchTextbox.Size = new System.Drawing.Size(100, 23);
        AllPartsSearchTextbox.TabIndex = 15;
        // 
        // AllPartsSearchButton
        // 
        AllPartsSearchButton.Location = new System.Drawing.Point(607, 61);
        AllPartsSearchButton.Name = "AllPartsSearchButton";
        AllPartsSearchButton.Size = new System.Drawing.Size(75, 23);
        AllPartsSearchButton.TabIndex = 16;
        AllPartsSearchButton.Text = "Search Parts";
        AllPartsSearchButton.UseVisualStyleBackColor = true;
        AllPartsSearchButton.Click += AllPartsSearchButtonClick;
        // 
        // TitleLabel
        // 
        TitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
        TitleLabel.Location = new System.Drawing.Point(12, 9);
        TitleLabel.Name = "TitleLabel";
        TitleLabel.Size = new System.Drawing.Size(388, 39);
        TitleLabel.TabIndex = 1;
        TitleLabel.Text = "Inventory Management System";
        // 
        // RemovePartButton
        // 
        RemovePartButton.Location = new System.Drawing.Point(688, 446);
        RemovePartButton.Name = "RemovePartButton";
        RemovePartButton.Size = new System.Drawing.Size(100, 23);
        RemovePartButton.TabIndex = 21;
        RemovePartButton.Text = "Remove Part";
        RemovePartButton.UseVisualStyleBackColor = true;
        RemovePartButton.Click += RemovePartButton_Click;
        // 
        // CancelButton2
        // 
        CancelButton2.Location = new System.Drawing.Point(713, 486);
        CancelButton2.Name = "CancelButton2";
        CancelButton2.Size = new System.Drawing.Size(75, 23);
        CancelButton2.TabIndex = 23;
        CancelButton2.Text = "Cancel";
        CancelButton2.UseVisualStyleBackColor = true;
        CancelButton2.Click += CancelButton_Click;
        // 
        // AddPartButton
        // 
        AddPartButton.Location = new System.Drawing.Point(713, 237);
        AddPartButton.Name = "AddPartButton";
        AddPartButton.Size = new System.Drawing.Size(75, 23);
        AddPartButton.TabIndex = 18;
        AddPartButton.Text = "Add";
        AddPartButton.UseVisualStyleBackColor = true;
        AddPartButton.Click += AddPartButton_Click;
        // 
        // IDLabel
        // 
        IDLabel.Location = new System.Drawing.Point(29, 95);
        IDLabel.Name = "IDLabel";
        IDLabel.Size = new System.Drawing.Size(100, 26);
        IDLabel.TabIndex = 2;
        IDLabel.Text = "ID";
        // 
        // IDTextbox
        // 
        IDTextbox.Location = new System.Drawing.Point(135, 95);
        IDTextbox.Name = "IDTextbox";
        IDTextbox.ReadOnly = true;
        IDTextbox.Size = new System.Drawing.Size(100, 23);
        IDTextbox.TabIndex = 3;
        // 
        // NameTextbox
        // 
        NameTextbox.Location = new System.Drawing.Point(135, 123);
        NameTextbox.Name = "NameTextbox";
        NameTextbox.Size = new System.Drawing.Size(100, 23);
        NameTextbox.TabIndex = 5;
        // 
        // NameLabel
        // 
        NameLabel.Location = new System.Drawing.Point(29, 123);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new System.Drawing.Size(100, 26);
        NameLabel.TabIndex = 4;
        NameLabel.Text = "Name";
        // 
        // InventoryTextbox
        // 
        InventoryTextbox.Location = new System.Drawing.Point(135, 151);
        InventoryTextbox.Name = "InventoryTextbox";
        InventoryTextbox.Size = new System.Drawing.Size(100, 23);
        InventoryTextbox.TabIndex = 7;
        // 
        // InventoryLabel
        // 
        InventoryLabel.Location = new System.Drawing.Point(29, 151);
        InventoryLabel.Name = "InventoryLabel";
        InventoryLabel.Size = new System.Drawing.Size(100, 26);
        InventoryLabel.TabIndex = 6;
        InventoryLabel.Text = "Inventory";
        // 
        // PriceTextbox
        // 
        PriceTextbox.Location = new System.Drawing.Point(135, 179);
        PriceTextbox.Name = "PriceTextbox";
        PriceTextbox.Size = new System.Drawing.Size(100, 23);
        PriceTextbox.TabIndex = 9;
        // 
        // PriceLabel
        // 
        PriceLabel.Location = new System.Drawing.Point(29, 179);
        PriceLabel.Name = "PriceLabel";
        PriceLabel.Size = new System.Drawing.Size(100, 26);
        PriceLabel.TabIndex = 8;
        PriceLabel.Text = "Price";
        // 
        // MinLabel
        // 
        MinLabel.Location = new System.Drawing.Point(29, 207);
        MinLabel.Name = "MinLabel";
        MinLabel.Size = new System.Drawing.Size(46, 26);
        MinLabel.TabIndex = 10;
        MinLabel.Text = "Min";
        // 
        // MaxTextbox
        // 
        MaxTextbox.Location = new System.Drawing.Point(191, 207);
        MaxTextbox.Name = "MaxTextbox";
        MaxTextbox.Size = new System.Drawing.Size(44, 23);
        MaxTextbox.TabIndex = 13;
        // 
        // MinTextbox
        // 
        MinTextbox.Location = new System.Drawing.Point(81, 207);
        MinTextbox.Name = "MinTextbox";
        MinTextbox.Size = new System.Drawing.Size(44, 23);
        MinTextbox.TabIndex = 11;
        // 
        // SaveButton
        // 
        SaveButton.Location = new System.Drawing.Point(632, 486);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new System.Drawing.Size(75, 23);
        SaveButton.TabIndex = 22;
        SaveButton.Text = "Save";
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;
        // 
        // MaxLabel
        // 
        MaxLabel.Location = new System.Drawing.Point(139, 207);
        MaxLabel.Name = "MaxLabel";
        MaxLabel.Size = new System.Drawing.Size(46, 26);
        MaxLabel.TabIndex = 12;
        MaxLabel.Text = "Max";
        // 
        // ProductForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 605);
        Controls.Add(MaxLabel);
        Controls.Add(MinTextbox);
        Controls.Add(MaxTextbox);
        Controls.Add(MinLabel);
        Controls.Add(PriceTextbox);
        Controls.Add(PriceLabel);
        Controls.Add(InventoryTextbox);
        Controls.Add(InventoryLabel);
        Controls.Add(NameTextbox);
        Controls.Add(NameLabel);
        Controls.Add(IDTextbox);
        Controls.Add(IDLabel);
        Controls.Add(SaveButton);
        Controls.Add(AddPartButton);
        Controls.Add(CancelButton2);
        Controls.Add(RemovePartButton);
        Controls.Add(TitleLabel);
        Controls.Add(AllPartsSearchButton);
        Controls.Add(AllPartsSearchTextbox);
        Controls.Add(AssociatedPartsLabel);
        Controls.Add(AssociatedPartsListView);
        Controls.Add(AllPartsLabel);
        Controls.Add(AllPartsListView);
        Text = "Inventory Management System";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button SaveButton;

    private System.Windows.Forms.Button AddPartButton;

    private System.Windows.Forms.Label TitleLabel;
    private System.Windows.Forms.Button RemovePartButton;
    private System.Windows.Forms.Button CancelButton2;

    private System.Windows.Forms.TextBox AllPartsSearchTextbox;
    private System.Windows.Forms.Button AllPartsSearchButton;

    private System.Windows.Forms.Label AssociatedPartsLabel;
    private System.Windows.Forms.ListView AssociatedPartsListView;

    private System.Windows.Forms.Label AllPartsLabel;

    private System.Windows.Forms.ListView AllPartsListView;
    
    private System.Windows.Forms.Label MaxLabel;
    private System.Windows.Forms.Label IDLabel;
    private System.Windows.Forms.TextBox IDTextbox;
    private System.Windows.Forms.TextBox NameTextbox;
    private System.Windows.Forms.Label NameLabel;
    private System.Windows.Forms.TextBox InventoryTextbox;
    private System.Windows.Forms.Label InventoryLabel;
    private System.Windows.Forms.TextBox PriceTextbox;
    private System.Windows.Forms.Label PriceLabel;
    private System.Windows.Forms.TextBox MinTextbox;
    private System.Windows.Forms.Label MinLabel;
    private System.Windows.Forms.TextBox MaxTextbox;

    #endregion
}