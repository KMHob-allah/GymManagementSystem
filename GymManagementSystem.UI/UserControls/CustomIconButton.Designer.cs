namespace GymManagementSystem.UI.UserControls
{
    partial class CustomIconButton
    {
        private System.ComponentModel.IContainer components = null;

        private FontAwesome.Sharp.IconButton btnInner;

        private void InitializeComponent()
        {
            this.btnInner = new FontAwesome.Sharp.IconButton();

            this.SuspendLayout();

            // btnInner
            this.btnInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInner.FlatAppearance.BorderSize = 0;
            this.btnInner.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInner.IconColor = System.Drawing.Color.Black;
            this.btnInner.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInner.IconSize = 24;
            this.btnInner.Location = new System.Drawing.Point(0, 0);
            this.btnInner.Name = "btnInner";
            this.btnInner.Size = new System.Drawing.Size(150, 40);
            this.btnInner.TabIndex = 0;
            this.btnInner.Text = "Button";
            this.btnInner.UseVisualStyleBackColor = false;

            // CustomIconButton
            this.Controls.Add(this.btnInner);
            this.Name = "CustomIconButton";
            this.Size = new System.Drawing.Size(150, 40);

            this.ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }
    }
}