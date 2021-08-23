using System;
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
    }
}
