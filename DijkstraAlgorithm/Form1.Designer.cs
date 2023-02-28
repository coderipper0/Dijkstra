namespace DijkstraAlgorithm
{
    partial class MainForm
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
            this.GraphPanel = new System.Windows.Forms.Panel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.AddCheckBox = new System.Windows.Forms.CheckBox();
            this.RelationsLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.StartLabel = new System.Windows.Forms.Label();
            this.StartComboBox = new System.Windows.Forms.ComboBox();
            this.EndLabel = new System.Windows.Forms.Label();
            this.EndComboBox = new System.Windows.Forms.ComboBox();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GraphPanel
            // 
            this.GraphPanel.Location = new System.Drawing.Point(12, 12);
            this.GraphPanel.Name = "GraphPanel";
            this.GraphPanel.Size = new System.Drawing.Size(678, 420);
            this.GraphPanel.TabIndex = 0;
            this.GraphPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddNode);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Location = new System.Drawing.Point(12, 435);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(678, 37);
            this.ResultLabel.TabIndex = 1;
            // 
            // AddCheckBox
            // 
            this.AddCheckBox.AutoSize = true;
            this.AddCheckBox.Checked = true;
            this.AddCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddCheckBox.Location = new System.Drawing.Point(696, 22);
            this.AddCheckBox.Name = "AddCheckBox";
            this.AddCheckBox.Size = new System.Drawing.Size(134, 19);
            this.AddCheckBox.TabIndex = 3;
            this.AddCheckBox.Text = "Agregar nodo (click)";
            this.AddCheckBox.UseVisualStyleBackColor = true;
            // 
            // RelationsLabel
            // 
            this.RelationsLabel.Location = new System.Drawing.Point(696, 56);
            this.RelationsLabel.Name = "RelationsLabel";
            this.RelationsLabel.Size = new System.Drawing.Size(156, 44);
            this.RelationsLabel.TabIndex = 4;
            this.RelationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Location = new System.Drawing.Point(696, 115);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(156, 40);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Limpiar selección";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearSelection);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(128)))), ((int)(((byte)(100)))));
            this.ExecuteButton.Enabled = false;
            this.ExecuteButton.FlatAppearance.BorderSize = 0;
            this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteButton.Location = new System.Drawing.Point(696, 391);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(156, 40);
            this.ExecuteButton.TabIndex = 6;
            this.ExecuteButton.Text = "Ejecutar";
            this.ExecuteButton.UseVisualStyleBackColor = false;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteAlgorithm);
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(696, 248);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(71, 15);
            this.StartLabel.TabIndex = 7;
            this.StartLabel.Text = "Nodo inicial";
            // 
            // StartComboBox
            // 
            this.StartComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.StartComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartComboBox.Enabled = false;
            this.StartComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartComboBox.FormattingEnabled = true;
            this.StartComboBox.Location = new System.Drawing.Point(696, 275);
            this.StartComboBox.Name = "StartComboBox";
            this.StartComboBox.Size = new System.Drawing.Size(156, 23);
            this.StartComboBox.TabIndex = 8;
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(696, 319);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(63, 15);
            this.EndLabel.TabIndex = 9;
            this.EndLabel.Text = "Nodo final";
            // 
            // EndComboBox
            // 
            this.EndComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.EndComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndComboBox.Enabled = false;
            this.EndComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndComboBox.FormattingEnabled = true;
            this.EndComboBox.Location = new System.Drawing.Point(696, 347);
            this.EndComboBox.Name = "EndComboBox";
            this.EndComboBox.Size = new System.Drawing.Size(156, 23);
            this.EndComboBox.TabIndex = 10;
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(97)))));
            this.ClearAllButton.FlatAppearance.BorderSize = 0;
            this.ClearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllButton.Location = new System.Drawing.Point(696, 170);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(156, 40);
            this.ClearAllButton.TabIndex = 11;
            this.ClearAllButton.Text = "Limpiar todo el panel";
            this.ClearAllButton.UseVisualStyleBackColor = false;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(864, 481);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.EndComboBox);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.StartComboBox);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RelationsLabel);
            this.Controls.Add(this.AddCheckBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.GraphPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dijkstra";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel GraphPanel;
        private Label ResultLabel;
        private CheckBox AddCheckBox;
        private Label RelationsLabel;
        private Button ClearButton;
        private Button ExecuteButton;
        private Label StartLabel;
        private ComboBox StartComboBox;
        private Label EndLabel;
        private ComboBox EndComboBox;
        private Button ClearAllButton;
    }
}