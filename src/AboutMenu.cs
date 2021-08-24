using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextEditor {
    public partial class AboutMenu : Form {
        public AboutMenu() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, System.EventArgs e) {
            this.Hide();
        }

        private void btnClose_MouseLeave(object sender, EventArgs e) {
            btnClose.ForeColor = System.Drawing.Color.DimGray;
        }

        private void btnClose_MouseHover(object sender, EventArgs e) {
            btnClose.ForeColor = System.Drawing.Color.White;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e) {
            btnClose.ForeColor = System.Drawing.Color.White;
        }

        private void btnClose_MouseDown(object sender, MouseEventArgs e) {
            btnClose.ForeColor = System.Drawing.Color.White;
        }

        private void panel_MouseUp(object sender, MouseEventArgs e) {
            Program.mouseDown = false;
        }

        private void panel_MouseDown(object sender, MouseEventArgs e) {

            Program.offset.X = e.X;
            Program.offset.Y = e.Y;
            Program.mouseDown = true;
        }

        private void panel_MouseMove(object sender, MouseEventArgs e) {

            if (Program.mouseDown == true) {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - Program.offset.X, currentScreenPos.Y - Program.offset.Y);
            }
        }
    }
}
