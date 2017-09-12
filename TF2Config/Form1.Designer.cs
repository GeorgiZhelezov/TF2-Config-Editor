namespace TF2Config
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.FileSelectTab = new System.Windows.Forms.TabPage();
            this.ButtonOpenSelected = new System.Windows.Forms.Button();
            this.ButtonAddCFG = new System.Windows.Forms.Button();
            this.ListBoxCFGcontainer = new System.Windows.Forms.ListBox();
            this.EditorTab = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            this.FileSelectTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.FileSelectTab);
            this.TabControl.Controls.Add(this.EditorTab);
            this.TabControl.Location = new System.Drawing.Point(12, 3);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(429, 369);
            this.TabControl.TabIndex = 0;
            // 
            // FileSelectTab
            // 
            this.FileSelectTab.BackColor = System.Drawing.Color.Transparent;
            this.FileSelectTab.Controls.Add(this.ButtonOpenSelected);
            this.FileSelectTab.Controls.Add(this.ButtonAddCFG);
            this.FileSelectTab.Controls.Add(this.ListBoxCFGcontainer);
            this.FileSelectTab.Location = new System.Drawing.Point(4, 22);
            this.FileSelectTab.Name = "FileSelectTab";
            this.FileSelectTab.Padding = new System.Windows.Forms.Padding(3);
            this.FileSelectTab.Size = new System.Drawing.Size(421, 343);
            this.FileSelectTab.TabIndex = 0;
            this.FileSelectTab.Text = "Select";
            // 
            // ButtonOpenSelected
            // 
            this.ButtonOpenSelected.Location = new System.Drawing.Point(319, 43);
            this.ButtonOpenSelected.Name = "ButtonOpenSelected";
            this.ButtonOpenSelected.Size = new System.Drawing.Size(96, 23);
            this.ButtonOpenSelected.TabIndex = 2;
            this.ButtonOpenSelected.Text = "Open selected";
            this.ButtonOpenSelected.UseVisualStyleBackColor = true;
            this.ButtonOpenSelected.Click += new System.EventHandler(this.ButtonOpenSelected_Click);
            // 
            // ButtonAddCFG
            // 
            this.ButtonAddCFG.Location = new System.Drawing.Point(319, 14);
            this.ButtonAddCFG.Name = "ButtonAddCFG";
            this.ButtonAddCFG.Size = new System.Drawing.Size(96, 23);
            this.ButtonAddCFG.TabIndex = 1;
            this.ButtonAddCFG.Text = "Add cfg";
            this.ButtonAddCFG.UseVisualStyleBackColor = true;
            this.ButtonAddCFG.Click += new System.EventHandler(this.ButtonOpenCFGfile_Click);
            // 
            // ListBoxCFGcontainer
            // 
            this.ListBoxCFGcontainer.FormattingEnabled = true;
            this.ListBoxCFGcontainer.Location = new System.Drawing.Point(6, 14);
            this.ListBoxCFGcontainer.Name = "ListBoxCFGcontainer";
            this.ListBoxCFGcontainer.Size = new System.Drawing.Size(194, 316);
            this.ListBoxCFGcontainer.TabIndex = 0;
            this.ListBoxCFGcontainer.SelectedIndexChanged += new System.EventHandler(this.ListBoxCFGcontainer_SelectedIndexChanged);
            // 
            // EditorTab
            // 
            this.EditorTab.BackColor = System.Drawing.Color.Transparent;
            this.EditorTab.Location = new System.Drawing.Point(4, 22);
            this.EditorTab.Name = "EditorTab";
            this.EditorTab.Padding = new System.Windows.Forms.Padding(3);
            this.EditorTab.Size = new System.Drawing.Size(421, 343);
            this.EditorTab.TabIndex = 1;
            this.EditorTab.Text = "Editor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 384);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.FileSelectTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage FileSelectTab;
        private System.Windows.Forms.TabPage EditorTab;
        private System.Windows.Forms.ListBox ListBoxCFGcontainer;
        private System.Windows.Forms.Button ButtonOpenSelected;
        private System.Windows.Forms.Button ButtonAddCFG;
    }
}

