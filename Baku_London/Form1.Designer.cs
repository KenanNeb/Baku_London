
namespace Baku_London
{
    partial class Form1
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
            this.btn_London = new Baku_London.KNControls.KNButtons();
            this.btn_Baku = new Baku_London.KNControls.KNButtons();
            this.pictureBox_Baku = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_London = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Baku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_London)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_London
            // 
            this.btn_London.BackColor = System.Drawing.Color.Indigo;
            this.btn_London.BackgroundColor = System.Drawing.Color.Indigo;
            this.btn_London.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_London.BorderRadius = 40;
            this.btn_London.BorderSize = 0;
            this.btn_London.FlatAppearance.BorderSize = 0;
            this.btn_London.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_London.ForeColor = System.Drawing.Color.White;
            this.btn_London.Location = new System.Drawing.Point(39, 248);
            this.btn_London.Name = "btn_London";
            this.btn_London.Size = new System.Drawing.Size(150, 40);
            this.btn_London.TabIndex = 0;
            this.btn_London.Text = "London";
            this.btn_London.TextColor = System.Drawing.Color.White;
            this.btn_London.UseVisualStyleBackColor = false;
            this.btn_London.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_London_MouseClick);
            // 
            // btn_Baku
            // 
            this.btn_Baku.BackColor = System.Drawing.Color.Crimson;
            this.btn_Baku.BackgroundColor = System.Drawing.Color.Crimson;
            this.btn_Baku.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Baku.BorderRadius = 40;
            this.btn_Baku.BorderSize = 0;
            this.btn_Baku.FlatAppearance.BorderSize = 0;
            this.btn_Baku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Baku.ForeColor = System.Drawing.Color.White;
            this.btn_Baku.Location = new System.Drawing.Point(413, 248);
            this.btn_Baku.Name = "btn_Baku";
            this.btn_Baku.Size = new System.Drawing.Size(150, 40);
            this.btn_Baku.TabIndex = 1;
            this.btn_Baku.Text = "Baku";
            this.btn_Baku.TextColor = System.Drawing.Color.White;
            this.btn_Baku.UseVisualStyleBackColor = false;
            this.btn_Baku.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Baku_MouseClick);
            // 
            // pictureBox_Baku
            // 
            this.pictureBox_Baku.Image = global::Baku_London.Properties.Resources.Baku;
            this.pictureBox_Baku.Location = new System.Drawing.Point(-6, -3);
            this.pictureBox_Baku.Name = "pictureBox_Baku";
            this.pictureBox_Baku.Size = new System.Drawing.Size(629, 430);
            this.pictureBox_Baku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Baku.TabIndex = 2;
            this.pictureBox_Baku.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(239, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "lbl_Time";
            // 
            // pictureBox_London
            // 
            this.pictureBox_London.Image = global::Baku_London.Properties.Resources.London;
            this.pictureBox_London.Location = new System.Drawing.Point(-6, -3);
            this.pictureBox_London.Name = "pictureBox_London";
            this.pictureBox_London.Size = new System.Drawing.Size(630, 450);
            this.pictureBox_London.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_London.TabIndex = 4;
            this.pictureBox_London.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Baku);
            this.Controls.Add(this.btn_London);
            this.Controls.Add(this.pictureBox_Baku);
            this.Controls.Add(this.pictureBox_London);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Baku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_London)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KNControls.KNButtons btn_London;
        private KNControls.KNButtons btn_Baku;
        private System.Windows.Forms.PictureBox pictureBox_Baku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_London;
    }
}

