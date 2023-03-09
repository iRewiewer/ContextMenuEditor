namespace ContextMenuEditor
{
    partial class CME
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
            this.panel = new System.Windows.Forms.DataGridView();
            this.KeyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.keyNameTextBox = new System.Windows.Forms.TextBox();
            this.iconTextBox = new System.Windows.Forms.TextBox();
            this.commandLabel = new System.Windows.Forms.Label();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.iconLabel = new System.Windows.Forms.Label();
            this.iconPreview = new System.Windows.Forms.PictureBox();
            this.keyNameLabel = new System.Windows.Forms.Label();
            this.keyHeaderLabel = new System.Windows.Forms.Label();
            this.keyHeaderTextBox = new System.Windows.Forms.TextBox();
            this.panelItems = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPreview)).BeginInit();
            this.panelItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KeyName,
            this.KeyHeader,
            this.Icon,
            this.Command});
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.RowTemplate.Height = 27;
            this.panel.Size = new System.Drawing.Size(440, 487);
            this.panel.TabIndex = 0;
            // 
            // KeyName
            // 
            this.KeyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KeyName.HeaderText = "Key Name";
            this.KeyName.Name = "KeyName";
            this.KeyName.ReadOnly = true;
            // 
            // KeyHeader
            // 
            this.KeyHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KeyHeader.HeaderText = "Key Header";
            this.KeyHeader.Name = "KeyHeader";
            this.KeyHeader.ReadOnly = true;
            // 
            // Icon
            // 
            this.Icon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Icon.HeaderText = "Icon";
            this.Icon.Name = "Icon";
            this.Icon.ReadOnly = true;
            // 
            // Command
            // 
            this.Command.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Command.HeaderText = "Command";
            this.Command.Name = "Command";
            this.Command.ReadOnly = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.AutoSize = true;
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveButton.Location = new System.Drawing.Point(0, 452);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(440, 35);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(0, 417);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(440, 35);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // keyNameTextBox
            // 
            this.keyNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyNameTextBox.Location = new System.Drawing.Point(115, 10);
            this.keyNameTextBox.Name = "keyNameTextBox";
            this.keyNameTextBox.Size = new System.Drawing.Size(310, 25);
            this.keyNameTextBox.TabIndex = 1;
            // 
            // iconTextBox
            // 
            this.iconTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconTextBox.Location = new System.Drawing.Point(115, 72);
            this.iconTextBox.Name = "iconTextBox";
            this.iconTextBox.Size = new System.Drawing.Size(279, 25);
            this.iconTextBox.TabIndex = 3;
            this.iconTextBox.TextChanged += new System.EventHandler(this.iconTextBox_TextChanged);
            // 
            // commandLabel
            // 
            this.commandLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandLabel.AutoSize = true;
            this.commandLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.commandLabel.Location = new System.Drawing.Point(20, 103);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(89, 21);
            this.commandLabel.TabIndex = 0;
            this.commandLabel.Text = "Command:";
            // 
            // commandTextBox
            // 
            this.commandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandTextBox.Location = new System.Drawing.Point(115, 103);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(310, 25);
            this.commandTextBox.TabIndex = 4;
            // 
            // iconLabel
            // 
            this.iconLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconLabel.AutoSize = true;
            this.iconLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconLabel.Location = new System.Drawing.Point(63, 72);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(46, 21);
            this.iconLabel.TabIndex = 0;
            this.iconLabel.Text = "Icon:";
            // 
            // iconPreview
            // 
            this.iconPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPreview.Location = new System.Drawing.Point(400, 72);
            this.iconPreview.Name = "iconPreview";
            this.iconPreview.Size = new System.Drawing.Size(25, 25);
            this.iconPreview.TabIndex = 10;
            this.iconPreview.TabStop = false;
            // 
            // keyNameLabel
            // 
            this.keyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyNameLabel.AutoSize = true;
            this.keyNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.keyNameLabel.Location = new System.Drawing.Point(21, 10);
            this.keyNameLabel.Name = "keyNameLabel";
            this.keyNameLabel.Size = new System.Drawing.Size(88, 21);
            this.keyNameLabel.TabIndex = 0;
            this.keyNameLabel.Text = "Key Name:";
            // 
            // keyHeaderLabel
            // 
            this.keyHeaderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyHeaderLabel.AutoSize = true;
            this.keyHeaderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.keyHeaderLabel.Location = new System.Drawing.Point(9, 41);
            this.keyHeaderLabel.Name = "keyHeaderLabel";
            this.keyHeaderLabel.Size = new System.Drawing.Size(100, 21);
            this.keyHeaderLabel.TabIndex = 0;
            this.keyHeaderLabel.Text = "Key Header:";
            // 
            // keyHeaderTextBox
            // 
            this.keyHeaderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyHeaderTextBox.Location = new System.Drawing.Point(115, 41);
            this.keyHeaderTextBox.Name = "keyHeaderTextBox";
            this.keyHeaderTextBox.Size = new System.Drawing.Size(310, 25);
            this.keyHeaderTextBox.TabIndex = 2;
            // 
            // panelItems
            // 
            this.panelItems.Controls.Add(this.keyNameLabel);
            this.panelItems.Controls.Add(this.keyHeaderLabel);
            this.panelItems.Controls.Add(this.keyNameTextBox);
            this.panelItems.Controls.Add(this.keyHeaderTextBox);
            this.panelItems.Controls.Add(this.iconTextBox);
            this.panelItems.Controls.Add(this.commandLabel);
            this.panelItems.Controls.Add(this.iconPreview);
            this.panelItems.Controls.Add(this.commandTextBox);
            this.panelItems.Controls.Add(this.iconLabel);
            this.panelItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelItems.Location = new System.Drawing.Point(0, 274);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(440, 143);
            this.panelItems.TabIndex = 13;
            // 
            // CME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 487);
            this.Controls.Add(this.panelItems);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.panel);
            this.Name = "CME";
            this.Text = "Context Menu Editor";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPreview)).EndInit();
            this.panelItems.ResumeLayout(false);
            this.panelItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView panel;
        private Button RemoveButton;
        private Button AddButton;
        private TextBox keyNameTextBox;
        private TextBox iconTextBox;
        private Label commandLabel;
        private TextBox commandTextBox;
        private Label iconLabel;
        private PictureBox iconPreview;
        private Label keyNameLabel;
        private DataGridViewTextBoxColumn KeyName;
        private DataGridViewTextBoxColumn KeyHeader;
        private DataGridViewTextBoxColumn Icon;
        private DataGridViewTextBoxColumn Command;
        private Label keyHeaderLabel;
        private TextBox keyHeaderTextBox;
        private Panel panelItems;
    }
}