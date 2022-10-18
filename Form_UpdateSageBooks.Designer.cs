
namespace CRUD_EntityFramework
{
    partial class Form_UpdateSageBooks
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
            this.components = new System.ComponentModel.Container();
            this.sageBooksGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.booksIdBox = new System.Windows.Forms.TextBox();
            this.sageIdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.OKbtn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sageBooksGridView)).BeginInit();
            this.updateBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sageBooksGridView
            // 
            this.sageBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sageBooksGridView.Location = new System.Drawing.Point(388, 30);
            this.sageBooksGridView.Name = "sageBooksGridView";
            this.sageBooksGridView.Size = new System.Drawing.Size(372, 376);
            this.sageBooksGridView.TabIndex = 0;
            this.sageBooksGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sageBooksGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sage_Id";
            // 
            // booksIdBox
            // 
            this.booksIdBox.Location = new System.Drawing.Point(72, 93);
            this.booksIdBox.Name = "booksIdBox";
            this.booksIdBox.Size = new System.Drawing.Size(151, 20);
            this.booksIdBox.TabIndex = 2;
            // 
            // sageIdBox
            // 
            this.sageIdBox.Location = new System.Drawing.Point(72, 33);
            this.sageIdBox.Name = "sageIdBox";
            this.sageIdBox.Size = new System.Drawing.Size(151, 20);
            this.sageIdBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Books_Id";
            // 
            // updateBox
            // 
            this.updateBox.Controls.Add(this.button2);
            this.updateBox.Controls.Add(this.OKbtn);
            this.updateBox.Controls.Add(this.sageIdBox);
            this.updateBox.Controls.Add(this.booksIdBox);
            this.updateBox.Controls.Add(this.label2);
            this.updateBox.Controls.Add(this.label1);
            this.updateBox.Enabled = false;
            this.updateBox.Location = new System.Drawing.Point(55, 120);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(241, 206);
            this.updateBox.TabIndex = 5;
            this.updateBox.TabStop = false;
            this.updateBox.Text = "Update SageBooks";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(138, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OKbtn
            // 
            this.OKbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbtn.Location = new System.Drawing.Point(19, 143);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(84, 41);
            this.OKbtn.TabIndex = 5;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // Form_UpdateSageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateBox);
            this.Controls.Add(this.sageBooksGridView);
            this.Name = "Form_UpdateSageBooks";
            this.Text = "Form_UpdateSageBooks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_UpdateSageBooks_FormClosed);
            this.Shown += new System.EventHandler(this.Form_UpdateSageBooks_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.sageBooksGridView)).EndInit();
            this.updateBox.ResumeLayout(false);
            this.updateBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sageBooksGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox booksIdBox;
        private System.Windows.Forms.TextBox sageIdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox updateBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}