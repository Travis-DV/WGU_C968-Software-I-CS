using System.ComponentModel;

namespace WGU_C968_Software_I_CS;

partial class PartsForm
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
        TitleLabel = new System.Windows.Forms.Label();
        InHouseRadioButton = new System.Windows.Forms.RadioButton();
        OutsourcedRadioButton = new System.Windows.Forms.RadioButton();
        IDLabel = new System.Windows.Forms.Label();
        IDTextbox = new System.Windows.Forms.TextBox();
        NameTextbox = new System.Windows.Forms.TextBox();
        NameLabel = new System.Windows.Forms.Label();
        InventoryTextbox = new System.Windows.Forms.TextBox();
        InventoryLabel = new System.Windows.Forms.Label();
        VariableTextbox1 = new System.Windows.Forms.TextBox();
        VariableLabel1 = new System.Windows.Forms.Label();
        MinLabel = new System.Windows.Forms.Label();
        MaxTextbox = new System.Windows.Forms.TextBox();
        MinTextbox = new System.Windows.Forms.TextBox();
        VariableTextbox2 = new System.Windows.Forms.TextBox();
        VariableLabel2 = new System.Windows.Forms.Label();
        CancelButton = new System.Windows.Forms.Button();
        SaveButton = new System.Windows.Forms.Button();
        MaxLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // TitleLabel
        // 
        TitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
        TitleLabel.Location = new System.Drawing.Point(12, 12);
        TitleLabel.Name = "TitleLabel";
        TitleLabel.Size = new System.Drawing.Size(121, 38);
        TitleLabel.TabIndex = 1;
        TitleLabel.Text = "Add Part";
        // 
        // InHouseRadioButton
        // 
        InHouseRadioButton.Checked = true;
        InHouseRadioButton.Location = new System.Drawing.Point(29, 58);
        InHouseRadioButton.Name = "InHouseRadioButton";
        InHouseRadioButton.Size = new System.Drawing.Size(104, 24);
        InHouseRadioButton.TabIndex = 2;
        InHouseRadioButton.TabStop = true;
        InHouseRadioButton.Text = "In-House";
        InHouseRadioButton.UseVisualStyleBackColor = true;
        InHouseRadioButton.CheckedChanged += InHouseRadioButton_CheckedChanged;
        // 
        // OutsourcedRadioButton
        // 
        OutsourcedRadioButton.Location = new System.Drawing.Point(145, 58);
        OutsourcedRadioButton.Name = "OutsourcedRadioButton";
        OutsourcedRadioButton.Size = new System.Drawing.Size(104, 24);
        OutsourcedRadioButton.TabIndex = 3;
        OutsourcedRadioButton.Text = "Outsourced";
        OutsourcedRadioButton.UseVisualStyleBackColor = true;
        OutsourcedRadioButton.CheckedChanged += OutsourcedRadioButton_CheckedChanged;
        // 
        // IDLabel
        // 
        IDLabel.Location = new System.Drawing.Point(29, 95);
        IDLabel.Name = "IDLabel";
        IDLabel.Size = new System.Drawing.Size(100, 26);
        IDLabel.TabIndex = 4;
        IDLabel.Text = "ID";
        // 
        // IDTextbox
        // 
        IDTextbox.Location = new System.Drawing.Point(135, 95);
        IDTextbox.Name = "IDTextbox";
        IDTextbox.ReadOnly = true;
        IDTextbox.Size = new System.Drawing.Size(100, 23);
        IDTextbox.TabIndex = 5;
        // 
        // NameTextbox
        // 
        NameTextbox.Location = new System.Drawing.Point(135, 123);
        NameTextbox.Name = "NameTextbox";
        NameTextbox.Size = new System.Drawing.Size(100, 23);
        NameTextbox.TabIndex = 7;
        // 
        // NameLabel
        // 
        NameLabel.Location = new System.Drawing.Point(29, 123);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new System.Drawing.Size(100, 26);
        NameLabel.TabIndex = 6;
        NameLabel.Text = "Name";
        // 
        // InventoryTextbox
        // 
        InventoryTextbox.Location = new System.Drawing.Point(135, 151);
        InventoryTextbox.Name = "InventoryTextbox";
        InventoryTextbox.Size = new System.Drawing.Size(100, 23);
        InventoryTextbox.TabIndex = 9;
        // 
        // InventoryLabel
        // 
        InventoryLabel.Location = new System.Drawing.Point(29, 151);
        InventoryLabel.Name = "InventoryLabel";
        InventoryLabel.Size = new System.Drawing.Size(100, 26);
        InventoryLabel.TabIndex = 8;
        InventoryLabel.Text = "Inventory";
        // 
        // VariableTextbox1
        // 
        VariableTextbox1.Location = new System.Drawing.Point(135, 179);
        VariableTextbox1.Name = "VariableTextbox1";
        VariableTextbox1.Size = new System.Drawing.Size(100, 23);
        VariableTextbox1.TabIndex = 11;
        // 
        // VariableLabel1
        // 
        VariableLabel1.Location = new System.Drawing.Point(29, 179);
        VariableLabel1.Name = "VariableLabel1";
        VariableLabel1.Size = new System.Drawing.Size(100, 26);
        VariableLabel1.TabIndex = 10;
        VariableLabel1.Text = "Cost";
        // 
        // MinLabel
        // 
        MinLabel.Location = new System.Drawing.Point(29, 207);
        MinLabel.Name = "MinLabel";
        MinLabel.Size = new System.Drawing.Size(46, 26);
        MinLabel.TabIndex = 12;
        MinLabel.Text = "Min";
        // 
        // MaxTextbox
        // 
        MaxTextbox.Location = new System.Drawing.Point(191, 207);
        MaxTextbox.Name = "MaxTextbox";
        MaxTextbox.Size = new System.Drawing.Size(44, 23);
        MaxTextbox.TabIndex = 15;
        // 
        // MinTextbox
        // 
        MinTextbox.Location = new System.Drawing.Point(81, 207);
        MinTextbox.Name = "MinTextbox";
        MinTextbox.Size = new System.Drawing.Size(44, 23);
        MinTextbox.TabIndex = 13;
        // 
        // VariableTextbox2
        // 
        VariableTextbox2.Location = new System.Drawing.Point(135, 235);
        VariableTextbox2.Name = "VariableTextbox2";
        VariableTextbox2.Size = new System.Drawing.Size(100, 23);
        VariableTextbox2.TabIndex = 17;
        // 
        // VariableLabel2
        // 
        VariableLabel2.Location = new System.Drawing.Point(29, 235);
        VariableLabel2.Name = "VariableLabel2";
        VariableLabel2.Size = new System.Drawing.Size(100, 26);
        VariableLabel2.TabIndex = 16;
        VariableLabel2.Text = "MachineID";
        // 
        // CancelButton
        // 
        CancelButton.Location = new System.Drawing.Point(160, 272);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new System.Drawing.Size(75, 23);
        CancelButton.TabIndex = 19;
        CancelButton.Text = "Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        CancelButton.Click += CancelButton_Click;
        // 
        // SaveButton
        // 
        SaveButton.Location = new System.Drawing.Point(79, 272);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new System.Drawing.Size(75, 23);
        SaveButton.TabIndex = 18;
        SaveButton.Text = "Save";
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;
        // 
        // MaxLabel
        // 
        MaxLabel.Location = new System.Drawing.Point(139, 207);
        MaxLabel.Name = "MaxLabel";
        MaxLabel.Size = new System.Drawing.Size(46, 26);
        MaxLabel.TabIndex = 14;
        MaxLabel.Text = "Max";
        // 
        // PartsForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(261, 310);
        Controls.Add(MaxLabel);
        Controls.Add(SaveButton);
        Controls.Add(CancelButton);
        Controls.Add(VariableTextbox2);
        Controls.Add(VariableLabel2);
        Controls.Add(MinTextbox);
        Controls.Add(MaxTextbox);
        Controls.Add(MinLabel);
        Controls.Add(VariableTextbox1);
        Controls.Add(VariableLabel1);
        Controls.Add(InventoryTextbox);
        Controls.Add(InventoryLabel);
        Controls.Add(NameTextbox);
        Controls.Add(NameLabel);
        Controls.Add(IDTextbox);
        Controls.Add(IDLabel);
        Controls.Add(OutsourcedRadioButton);
        Controls.Add(InHouseRadioButton);
        Controls.Add(TitleLabel);
        Text = "PartsForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.Label MaxLabel;

    private System.Windows.Forms.Button CancelButton;

    private System.Windows.Forms.Label IDLabel;
    private System.Windows.Forms.TextBox IDTextbox;
    private System.Windows.Forms.TextBox NameTextbox;
    private System.Windows.Forms.Label NameLabel;
    private System.Windows.Forms.TextBox InventoryTextbox;
    private System.Windows.Forms.Label InventoryLabel;
    private System.Windows.Forms.TextBox VariableTextbox1;
    private System.Windows.Forms.Label VariableLabel1;
    private System.Windows.Forms.TextBox MinTextbox;
    private System.Windows.Forms.Label MinLabel;
    private System.Windows.Forms.TextBox MaxTextbox;
    private System.Windows.Forms.TextBox VariableTextbox2;
    private System.Windows.Forms.Label VariableLabel2;

    private System.Windows.Forms.Label TitleLabel;
    private System.Windows.Forms.RadioButton InHouseRadioButton;
    private System.Windows.Forms.RadioButton OutsourcedRadioButton;

    #endregion
}