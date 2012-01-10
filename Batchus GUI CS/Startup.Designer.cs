using System;
using System.Windows.Forms;
using System.Threading;
namespace BatchusGUICS
{
    public partial class Startup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer ComponentsStartupForm = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (ComponentsStartupForm != null))
            {
                ComponentsStartupForm.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.StartupGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenDesignerButton = new System.Windows.Forms.Button();
            this.OpenTutorialsButton = new System.Windows.Forms.Button();
            this.OpenTemplateButton = new System.Windows.Forms.Button();
            this.AboutBatchusButton = new System.Windows.Forms.Button();
            this.CloseBatchusButton = new System.Windows.Forms.Button();
            //this.IsMdiContainer = true;
            this.StartupGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.StartupGroupBox.Controls.Add(this.OpenDesignerButton);
            this.StartupGroupBox.Controls.Add(this.OpenTutorialsButton);
            this.StartupGroupBox.Controls.Add(this.OpenTemplateButton);
            this.StartupGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartupGroupBox.Location = new System.Drawing.Point(12, 12);
            this.StartupGroupBox.Name = "GroupBox1";
            this.StartupGroupBox.Size = new System.Drawing.Size(134, 229);
            this.StartupGroupBox.TabIndex = 6;
            this.StartupGroupBox.TabStop = false;
            this.StartupGroupBox.Text = "I want to";
            // 
            // Button2
            // 
            this.OpenDesignerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenDesignerButton.Location = new System.Drawing.Point(6, 19);
            this.OpenDesignerButton.Name = "OpenDesignerButton";
            this.OpenDesignerButton.Size = new System.Drawing.Size(121, 23);
            this.OpenDesignerButton.TabIndex = 2;
            this.OpenDesignerButton.Text = "Open the Designer";
            this.OpenDesignerButton.UseVisualStyleBackColor = true;
            this.OpenDesignerButton.Click += new EventHandler((object sender, EventArgs e) =>
            {
                GUIDesignerForm F1 = new GUIDesignerForm();
                F1.Show();
                F1.Update();
                this.Refresh();
                //this.Close();
                
            });
            // 
            // Button4
            // 
            this.OpenTutorialsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTutorialsButton.Location = new System.Drawing.Point(6, 77);
            this.OpenTutorialsButton.Name = "OpenTutorialsButton";
            this.OpenTutorialsButton.Size = new System.Drawing.Size(121, 23);
            this.OpenTutorialsButton.TabIndex = 4;
            this.OpenTutorialsButton.Text = "Open Tutorials";
            this.OpenTutorialsButton.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.OpenTemplateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTemplateButton.Location = new System.Drawing.Point(6, 48);
            this.OpenTemplateButton.Name = "OpenTemplateButton";
            this.OpenTemplateButton.Size = new System.Drawing.Size(121, 23);
            this.OpenTemplateButton.TabIndex = 1;
            this.OpenTemplateButton.Text = "Open a Template";
            this.OpenTemplateButton.UseVisualStyleBackColor = true;
            // 
            // Button6
            // 
            this.AboutBatchusButton.Location = new System.Drawing.Point(86, 247);
            this.AboutBatchusButton.Name = "AboutBatchusButton";
            this.AboutBatchusButton.Size = new System.Drawing.Size(100, 23);
            this.AboutBatchusButton.TabIndex = 8;
            this.AboutBatchusButton.Text = "About Batchus";
            this.AboutBatchusButton.UseVisualStyleBackColor = true;
            this.AboutBatchusButton.Click += new System.EventHandler((object sender, EventArgs e) =>
            {
            });
            // 
            // Button3
            // 
            this.CloseBatchusButton.Location = new System.Drawing.Point(192, 247);
            this.CloseBatchusButton.Name = "CloseBatchusButton";
            this.CloseBatchusButton.Size = new System.Drawing.Size(100, 23);
            this.CloseBatchusButton.TabIndex = 7;
            this.CloseBatchusButton.Text = "Close Batchus";
            this.CloseBatchusButton.UseVisualStyleBackColor = true;
            this.CloseBatchusButton.Click += new System.EventHandler((object sender, EventArgs e) => this.Close());
           
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 282);
            this.Controls.Add(this.AboutBatchusButton);
            this.Controls.Add(this.CloseBatchusButton);
            this.Controls.Add(this.StartupGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Startup";
            this.Text = "Startup";
            this.StartupGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox StartupGroupBox;
        public System.Windows.Forms.Button OpenDesignerButton;
        public System.Windows.Forms.Button OpenTutorialsButton;
        public System.Windows.Forms.Button OpenTemplateButton;
        public System.Windows.Forms.Button AboutBatchusButton;
        public System.Windows.Forms.Button CloseBatchusButton;
    }
}