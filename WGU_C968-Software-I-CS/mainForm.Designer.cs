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
        label1 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        ExitButton = new System.Windows.Forms.Button();
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
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 20F);
        label1.Location = new System.Drawing.Point(12, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(388, 39);
        label1.TabIndex = 9;
        label1.Text = "Inventory Management System";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(282, 237);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 23);
        button1.TabIndex = 10;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(201, 237);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(75, 23);
        button2.TabIndex = 11;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(632, 237);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(75, 23);
        button3.TabIndex = 13;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(713, 237);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(75, 23);
        button4.TabIndex = 12;
        button4.Text = "button4";
        button4.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        ExitButton.Location = new System.Drawing.Point(713, 281);
        ExitButton.Name = "ExitButton";
        ExitButton.Size = new System.Drawing.Size(75, 23);
        ExitButton.TabIndex = 14;
        ExitButton.Text = "Exit";
        ExitButton.UseVisualStyleBackColor = true;
        ExitButton.Click += ExitButton_Click;
        // 
        // mainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(ExitButton);
        Controls.Add(button3);
        Controls.Add(button4);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label1);
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

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
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