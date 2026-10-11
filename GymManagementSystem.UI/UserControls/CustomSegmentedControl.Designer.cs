
namespace GymManagementSystem.UI.Controls
{
    partial class CustomSegmentedControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel segmentsPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.segmentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();

            // segmentsPanel
            this.segmentsPanel.AutoScroll = false;
            this.segmentsPanel.BackColor = System.Drawing.Color.Transparent;
            this.segmentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.segmentsPanel.FlowDirection =
                System.Windows.Forms.FlowDirection.LeftToRight;
            this.segmentsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.segmentsPanel.Padding = new System.Windows.Forms.Padding(3);
            this.segmentsPanel.WrapContents = false;
            this.segmentsPanel.Name = "segmentsPanel";
            this.segmentsPanel.TabIndex = 0;
            this.segmentsPanel.Size =
                new System.Drawing.Size(400, 46);


            // CustomSegmentedControl
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.segmentsPanel);
            this.Name = "CustomSegmentedControl";
            this.Size = new System.Drawing.Size(400, 46);
            this.ResumeLayout(false);
        }
    }
}
