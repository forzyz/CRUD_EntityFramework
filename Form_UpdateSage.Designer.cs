
namespace CRUD_EntityFramework
{
    partial class Form_UpdateSage
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
            this.sageGridView = new System.Windows.Forms.DataGridView();
            this.updateBox = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.OKbtn = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SIbtn = new System.Windows.Forms.Button();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.sageGridView)).BeginInit();
            this.updateBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sageGridView
            // 
            this.sageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sageGridView.Location = new System.Drawing.Point(356, 26);
            this.sageGridView.Name = "sageGridView";
            this.sageGridView.Size = new System.Drawing.Size(391, 420);
            this.sageGridView.TabIndex = 0;
            this.sageGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sagesGridView_CellClick);
            // 
            // updateBox
            // 
            this.updateBox.Controls.Add(this.button3);
            this.updateBox.Controls.Add(this.OKbtn);
            this.updateBox.Controls.Add(this.imageBox);
            this.updateBox.Controls.Add(this.label3);
            this.updateBox.Controls.Add(this.SIbtn);
            this.updateBox.Controls.Add(this.birthdayPicker);
            this.updateBox.Controls.Add(this.label2);
            this.updateBox.Controls.Add(this.label1);
            this.updateBox.Controls.Add(this.nameBox);
            this.updateBox.Enabled = false;
            this.updateBox.Location = new System.Drawing.Point(30, 26);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(264, 420);
            this.updateBox.TabIndex = 4;
            this.updateBox.TabStop = false;
            this.updateBox.Text = "Update Sage";
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(158, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 36);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // OKbtn
            // 
            this.OKbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbtn.Location = new System.Drawing.Point(25, 359);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(87, 36);
            this.OKbtn.TabIndex = 9;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(57, 117);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(182, 207);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 8;
            this.imageBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Image";
            // 
            // SIbtn
            // 
            this.SIbtn.Location = new System.Drawing.Point(93, 330);
            this.SIbtn.Name = "SIbtn";
            this.SIbtn.Size = new System.Drawing.Size(120, 23);
            this.SIbtn.TabIndex = 6;
            this.SIbtn.Text = "Select Image";
            this.SIbtn.UseVisualStyleBackColor = true;
            this.SIbtn.Click += new System.EventHandler(this.SIbtn_Click);
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Location = new System.Drawing.Point(57, 77);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayPicker.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birthday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(57, 32);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 20);
            this.nameBox.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_UpdateSage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.updateBox);
            this.Controls.Add(this.sageGridView);
            this.Name = "Form_UpdateSage";
            this.Text = "Form_UpdateSage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_UpdateSage_FormClosed);
            this.Load += new System.EventHandler(this.Form_UpdateSage_Load);
            this.Shown += new System.EventHandler(this.Form_UpdateSage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.sageGridView)).EndInit();
            this.updateBox.ResumeLayout(false);
            this.updateBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sageGridView;
        private System.Windows.Forms.GroupBox updateBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SIbtn;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}