namespace CoordinateProjectionExample {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.staticMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.staticMap)).BeginInit();
            this.SuspendLayout();
            // 
            // staticMap
            // 
            this.staticMap.Image = global::CoordinateProjectionExample.Properties.Resources.static_map;
            this.staticMap.Location = new System.Drawing.Point(0, 0);
            this.staticMap.Margin = new System.Windows.Forms.Padding(2);
            this.staticMap.Name = "staticMap";
            this.staticMap.Size = new System.Drawing.Size(975, 390);
            this.staticMap.TabIndex = 0;
            this.staticMap.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 667);
            this.Controls.Add(this.staticMap);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.staticMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox staticMap;
    }
}