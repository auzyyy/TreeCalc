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
            this.label_appLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Press in the area to drop a Node";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select a node, and select another node to add a path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "INSTRUCTIONS";
            // 
            // panel_TreeArea
            // 
            this.panel_TreeArea.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_TreeArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_TreeArea.Location = new System.Drawing.Point(365, 12);
            this.panel_TreeArea.Name = "panel_TreeArea";
            this.panel_TreeArea.Size = new System.Drawing.Size(561, 590);
            this.panel_TreeArea.TabIndex = 4;
            this.panel_TreeArea.Click += new System.EventHandler(this.panel_TreeArea_Click);
            // 
            // label_appLabel
            // 
            this.label_appLabel.AutoSize = true;
            this.label_appLabel.ForeColor = System.Drawing.Color.Red;
            this.label_appLabel.Location = new System.Drawing.Point(13, 589);
            this.label_appLabel.Name = "label_appLabel";
            this.label_appLabel.Size = new System.Drawing.Size(0, 13);
            this.label_appLabel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Right click on a node to remove it";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(284, 578);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 7;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 614);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_appLabel);
            this.Controls.Add(this.panel_TreeArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

