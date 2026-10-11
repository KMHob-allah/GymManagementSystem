
namespace GymManagementSystem.UI.Controls
{
    partial class CustomTextBox
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.txtInner = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            // txtInner
            this.txtInner.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.txtInner.Location =
                new System.Drawing.Point(10, 8);

            this.txtInner.Name = "txtInner";
            this.txtInner.Size =
                new System.Drawing.Size(230, 20);

            this.txtInner.TabIndex = 0;

            // CustomTextBox
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.Controls.Add(this.txtInner);

            this.Name = "CustomTextBox";
            this.Size = new System.Drawing.Size(250, 36);

            this.ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private System.Windows.Forms.TextBox txtInner;
    }
}
