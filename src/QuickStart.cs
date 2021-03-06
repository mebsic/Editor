using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TextEditor {
    public partial class QuickStart : Form {

        public static String FileTypes = "Text File (*.txt)|*.txt|YAML File (*.yml)|*.yml|XML File (*.xml)|*.xml|HTML File (*.html)|*.html|CSS File (*.css)|*.css|JavaScript File (*.js)|*.js|Markdown File (*.md)|*.md";
        private bool btnBlankDocClicked = false;
        public static OpenFileDialog ofd = new OpenFileDialog();
        public static SaveFileDialog sfd = new SaveFileDialog();

        public static SaveFileDialog GetSaveFileDialog() {
            return sfd;
        }

        public static OpenFileDialog GetFileDialog() {
            return ofd;
        }

        public QuickStart() {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e) {
            new AboutMenu().Show();
        }

        private void btnMin_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e) {
            btnClose.ForeColor = System.Drawing.Color.LightGray;
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

        private void panelTop_MouseUp(object sender, MouseEventArgs e) {
            Program.mouseDown = false;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
            Environment.Exit(0);
        }

        private void QuickStart_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
            Environment.Exit(0);
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e) {

            Program.offset.X = e.X;
            Program.offset.Y = e.Y;
            Program.mouseDown = true;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e) {

            if (Program.mouseDown == true) {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - Program.offset.X, currentScreenPos.Y - Program.offset.Y);
            }
        }

        private void QuickStart_Load(object sender, EventArgs e) {

            btnContinue.Enabled = false;
            btnBlankDoc.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e) {

            ofd.Filter = FileTypes;

            if (ofd.ShowDialog() == DialogResult.OK) {
                AppContainer cont = new AppContainer();

                cont.Text = Path.GetFileName(ofd.FileName);
                cont.lblOpened.Text = Path.GetFileName(ofd.FileName);

                AppContainer.reader = new StreamReader(ofd.FileName);
                cont.richTxtBox.Text = AppContainer.reader.ReadToEnd();

                AppContainer.reader.Close();
                cont.IsFileSaved = false;

                cont.Show();
                this.Hide();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e) {

            btnNewDocument.Enabled = false;
            btnBrowse.Enabled = false;
            btnCancel.Enabled = false;
            btnBlankDoc.Enabled = false;

            AppContainer cont = new AppContainer();

            cont.Text = Path.GetFileName("Blank document");
            cont.lblOpened.Text = Path.GetFileName("Blank document");

            cont.IsFileSaved = false;
            cont.Show();
            this.Hide();
        }

        private void btnNewDocument_Click(object sender, EventArgs e) {

            btnCancel.Enabled = true;
            btnBlankDoc.Enabled = true;
            btnNewDocument.Enabled = false;
            btnBlankDocClicked = false;

            if (btnBlankDocClicked == true) {
                btnContinue.Enabled = true;
                btnCancel.Enabled = true;
                lblTemplate.ForeColor = System.Drawing.Color.White;
            }
            else {
                btnContinue.Enabled = false;
                btnCancel.Enabled = true;
                lblTemplate.ForeColor = System.Drawing.Color.White;
            }
        }

        private void btnBlankDoc_Click(object sender, EventArgs e) {

            btnBlankDocClicked = true;
            btnContinue.Enabled = true;
            btnCancel.Enabled = true;

            btnBlankDoc.Enabled = false;
            btnNewDocument.Enabled = false;
            lblTemplate.ForeColor = System.Drawing.Color.Gray;

        }

        private void btnCancel_Click(object sender, EventArgs e) {

            btnBlankDoc.Enabled = false;
            btnContinue.Enabled = false;
            btnCancel.Enabled = false;

            btnNewDocument.Enabled = true;
            lblTemplate.ForeColor = System.Drawing.Color.Gray;
        }
    }
}
