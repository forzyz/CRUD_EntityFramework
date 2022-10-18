
namespace CRUD_EntityFramework
{
    partial class Form_UpdateBook
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
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.updateBox = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.OKbtn = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            this.updateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksGridView
            // 
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGridView.Location = new System.Drawing.Point(298, 28);
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.Size = new System.Drawing.Size(318, 369);
            this.booksGridView.TabIndex = 0;
            this.booksGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksGridView_CellClick);
            // 
            // updateBox
            // 
            this.updateBox.Controls.Add(this.button3);
            this.updateBox.Controls.Add(this.OKbtn);
            this.updateBox.Controls.Add(this.titleBox);
            this.updateBox.Controls.Add(this.Title);
            this.updateBox.Enabled = false;
            this.updateBox.Location = new System.Drawing.Point(29, 122);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(231, 120);
            this.updateBox.TabIndex = 6;
            this.updateBox.TabStop = false;
            this.updateBox.Text = "Update Book";
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(133, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // OKbtn
            // 
            this.OKbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbtn.Location = new System.Drawing.Point(6, 67);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(87, 36);
            this.OKbtn.TabIndex = 11;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(47, 31);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(167, 20);
            this.titleBox.TabIndex = 4;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(3, 31);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(35, 13);
            this.Title.TabIndex = 3;
            this.Title.Text = "Name";
            // 
            // Form_UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 421);
            this.Controls.Add(this.updateBox);
            this.Controls.Add(this.booksGridView);
            this.Name = "Form_UpdateBook";
            this.Text = "Form_UpdateBook";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_UpdateBook_FormClosed);
            this.Load += new System.EventHandler(this.Form_UpdateBook_Load);
            this.Shown += new System.EventHandler(this.Form_UpdateBook_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            this.updateBox.ResumeLayout(false);
            this.updateBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booksGridView;
        private System.Windows.Forms.GroupBox updateBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label Title;
    }
}