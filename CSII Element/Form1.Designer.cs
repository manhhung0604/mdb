namespace CSII_Element
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtAccessPath = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbElement = new System.Windows.Forms.GroupBox();
            this.gvElement = new System.Windows.Forms.DataGridView();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.gbElement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvElement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(605, 48);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // txtAccessPath
            // 
            this.txtAccessPath.Location = new System.Drawing.Point(24, 48);
            this.txtAccessPath.Name = "txtAccessPath";
            this.txtAccessPath.Size = new System.Drawing.Size(557, 22);
            this.txtAccessPath.TabIndex = 1;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(58, 104);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(168, 104);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbElement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 412);
            this.panel1.TabIndex = 4;
            // 
            // gbElement
            // 
            this.gbElement.Controls.Add(this.gvElement);
            this.gbElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbElement.Location = new System.Drawing.Point(0, 0);
            this.gbElement.Name = "gbElement";
            this.gbElement.Size = new System.Drawing.Size(809, 412);
            this.gbElement.TabIndex = 0;
            this.gbElement.TabStop = false;
            this.gbElement.Text = "Elements";
            // 
            // gvElement
            // 
            this.gvElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvElement.Location = new System.Drawing.Point(3, 18);
            this.gvElement.Name = "gvElement";
            this.gvElement.RowTemplate.Height = 24;
            this.gvElement.Size = new System.Drawing.Size(803, 391);
            this.gvElement.TabIndex = 0;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtAccessPath);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "Read";
            this.panel1.ResumeLayout(false);
            this.gbElement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtAccessPath;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbElement;
        private System.Windows.Forms.DataGridView gvElement;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

