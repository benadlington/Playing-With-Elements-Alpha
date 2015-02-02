namespace Playing_With_Fire___Alpha_0._1.Map_Editor
{
    partial class Form_MapEditor
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
            this.cmb_Texture = new System.Windows.Forms.ComboBox();
            this.textb_MapName = new System.Windows.Forms.TextBox();
            this.btn_SelectTexture = new System.Windows.Forms.Button();
            this.btn_SaveMap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_Texture
            // 
            this.cmb_Texture.FormattingEnabled = true;
            this.cmb_Texture.Items.AddRange(new object[] {
            "Wall",
            "Crate"});
            this.cmb_Texture.Location = new System.Drawing.Point(12, 53);
            this.cmb_Texture.Name = "cmb_Texture";
            this.cmb_Texture.Size = new System.Drawing.Size(121, 21);
            this.cmb_Texture.TabIndex = 0;
            // 
            // textb_MapName
            // 
            this.textb_MapName.Location = new System.Drawing.Point(94, 12);
            this.textb_MapName.Name = "textb_MapName";
            this.textb_MapName.Size = new System.Drawing.Size(100, 20);
            this.textb_MapName.TabIndex = 1;
            // 
            // btn_SelectTexture
            // 
            this.btn_SelectTexture.Location = new System.Drawing.Point(150, 51);
            this.btn_SelectTexture.Name = "btn_SelectTexture";
            this.btn_SelectTexture.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectTexture.TabIndex = 2;
            this.btn_SelectTexture.Text = "Select";
            this.btn_SelectTexture.UseVisualStyleBackColor = true;
            // 
            // btn_SaveMap
            // 
            this.btn_SaveMap.Location = new System.Drawing.Point(197, 353);
            this.btn_SaveMap.Name = "btn_SaveMap";
            this.btn_SaveMap.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveMap.TabIndex = 3;
            this.btn_SaveMap.Text = "Save";
            this.btn_SaveMap.UseVisualStyleBackColor = true;
            // 
            // Form_MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 388);
            this.Controls.Add(this.btn_SaveMap);
            this.Controls.Add(this.btn_SelectTexture);
            this.Controls.Add(this.textb_MapName);
            this.Controls.Add(this.cmb_Texture);
            this.Enabled = false;
            this.Name = "Form_MapEditor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Texture;
        private System.Windows.Forms.TextBox textb_MapName;
        private System.Windows.Forms.Button btn_SelectTexture;
        private System.Windows.Forms.Button btn_SaveMap;
    }
}