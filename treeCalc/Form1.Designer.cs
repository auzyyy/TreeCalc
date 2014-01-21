namespace treeCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_TreeArea = new System.Windows.Forms.Panel();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label_appLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_Paths = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Panel_EditPath = new System.Windows.Forms.Panel();
            this.Button_SavePath = new System.Windows.Forms.Button();
            this.Button_DeletePath = new System.Windows.Forms.Button();
            this.TextBox_PathWeight = new System.Windows.Forms.TextBox();
            this.TextBox_EndNode = new System.Windows.Forms.TextBox();
            this.TextBox_StartNode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_TreeArea.SuspendLayout();
            this.Panel_EditPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Press in the area to drop a Node";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select a node, and select another node to add a path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "INSTRUCTIONS";
            // 
            // panel_TreeArea
            // 
            this.panel_TreeArea.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_TreeArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_TreeArea.Controls.Add(this.button_Clear);
            this.panel_TreeArea.Location = new System.Drawing.Point(365, 12);
            this.panel_TreeArea.Name = "panel_TreeArea";
            this.panel_TreeArea.Size = new System.Drawing.Size(561, 590);
            this.panel_TreeArea.TabIndex = 4;
            this.panel_TreeArea.Click += new System.EventHandler(this.panel_TreeArea_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(-2, -2);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 7;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label_appLabel
            // 
            this.label_appLabel.AutoSize = true;
            this.label_appLabel.ForeColor = System.Drawing.Color.Red;
            this.label_appLabel.Location = new System.Drawing.Point(12, 413);
            this.label_appLabel.Name = "label_appLabel";
            this.label_appLabel.Size = new System.Drawing.Size(0, 13);
            this.label_appLabel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Right click on a node to remove it";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Select an Algorithm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "When you are finished, select an algorithm and hit run";
            // 
            // listBox_Paths
            // 
            this.listBox_Paths.FormattingEnabled = true;
            this.listBox_Paths.Location = new System.Drawing.Point(932, 42);
            this.listBox_Paths.Name = "listBox_Paths";
            this.listBox_Paths.Size = new System.Drawing.Size(231, 264);
            this.listBox_Paths.TabIndex = 11;
            this.listBox_Paths.SelectedValueChanged += new System.EventHandler(this.listBox_Paths_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1017, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Paths";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Select a path in the paths table to edit or delete that path";
            // 
            // Panel_EditPath
            // 
            this.Panel_EditPath.Controls.Add(this.Button_SavePath);
            this.Panel_EditPath.Controls.Add(this.Button_DeletePath);
            this.Panel_EditPath.Controls.Add(this.TextBox_PathWeight);
            this.Panel_EditPath.Controls.Add(this.TextBox_EndNode);
            this.Panel_EditPath.Controls.Add(this.TextBox_StartNode);
            this.Panel_EditPath.Controls.Add(this.label10);
            this.Panel_EditPath.Controls.Add(this.label9);
            this.Panel_EditPath.Controls.Add(this.label8);
            this.Panel_EditPath.Location = new System.Drawing.Point(933, 313);
            this.Panel_EditPath.Name = "Panel_EditPath";
            this.Panel_EditPath.Size = new System.Drawing.Size(230, 113);
            this.Panel_EditPath.TabIndex = 14;
            this.Panel_EditPath.Visible = false;
            // 
            // Button_SavePath
            // 
            this.Button_SavePath.Location = new System.Drawing.Point(147, 81);
            this.Button_SavePath.Name = "Button_SavePath";
            this.Button_SavePath.Size = new System.Drawing.Size(75, 23);
            this.Button_SavePath.TabIndex = 7;
            this.Button_SavePath.Text = "Save";
            this.Button_SavePath.UseVisualStyleBackColor = true;
            this.Button_SavePath.Click += new System.EventHandler(this.Button_SavePath_Click);
            // 
            // Button_DeletePath
            // 
            this.Button_DeletePath.Location = new System.Drawing.Point(7, 81);
            this.Button_DeletePath.Name = "Button_DeletePath";
            this.Button_DeletePath.Size = new System.Drawing.Size(75, 23);
            this.Button_DeletePath.TabIndex = 6;
            this.Button_DeletePath.Text = "Delete";
            this.Button_DeletePath.UseVisualStyleBackColor = true;
            this.Button_DeletePath.Click += new System.EventHandler(this.Button_DeletePath_Click);
            // 
            // TextBox_PathWeight
            // 
            this.TextBox_PathWeight.Location = new System.Drawing.Point(68, 55);
            this.TextBox_PathWeight.Name = "TextBox_PathWeight";
            this.TextBox_PathWeight.Size = new System.Drawing.Size(100, 20);
            this.TextBox_PathWeight.TabIndex = 5;
            // 
            // TextBox_EndNode
            // 
            this.TextBox_EndNode.Enabled = false;
            this.TextBox_EndNode.Location = new System.Drawing.Point(68, 29);
            this.TextBox_EndNode.Name = "TextBox_EndNode";
            this.TextBox_EndNode.Size = new System.Drawing.Size(100, 20);
            this.TextBox_EndNode.TabIndex = 4;
            // 
            // TextBox_StartNode
            // 
            this.TextBox_StartNode.Enabled = false;
            this.TextBox_StartNode.Location = new System.Drawing.Point(68, 3);
            this.TextBox_StartNode.Name = "TextBox_StartNode";
            this.TextBox_StartNode.Size = new System.Drawing.Size(100, 20);
            this.TextBox_StartNode.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Weight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "End Node";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Start Node";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 614);
            this.Controls.Add(this.Panel_EditPath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox_Paths);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_appLabel);
            this.Controls.Add(this.panel_TreeArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_TreeArea.ResumeLayout(false);
            this.Panel_EditPath.ResumeLayout(false);
            this.Panel_EditPath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_TreeArea;
        private System.Windows.Forms.Label label_appLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_Paths;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Panel_EditPath;
        private System.Windows.Forms.Button Button_SavePath;
        private System.Windows.Forms.Button Button_DeletePath;
        private System.Windows.Forms.TextBox TextBox_PathWeight;
        private System.Windows.Forms.TextBox TextBox_EndNode;
        private System.Windows.Forms.TextBox TextBox_StartNode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

