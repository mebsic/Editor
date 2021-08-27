using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace TextEditor {
    public partial class AppContainer : Form {

        public static StreamReader reader;
        public static StreamWriter writer;
        public bool IsFileSaved = false;
        public static FontDialog fontDialog = new FontDialog();
        public static ColorDialog colorDialog = new ColorDialog();
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();

        public AppContainer() {
            InitializeComponent();
            document.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
        }

        private void CheckSaveState() {

            if (IsFileSaved == false && richTxtBox.Text.Length > 0) {
                QuickStart.GetSaveFileDialog().Filter = QuickStart.FileTypes;
                QuickStart.GetSaveFileDialog().Title = "Save";

                if (QuickStart.GetSaveFileDialog().ShowDialog() == DialogResult.OK) {

                    this.Text = Path.GetFileName(QuickStart.GetSaveFileDialog().FileName);
                    lblOpened.Text = Path.GetFileName(QuickStart.GetSaveFileDialog().FileName);

                    writer = new StreamWriter(QuickStart.GetSaveFileDialog().FileName);
                    writer.Write(richTxtBox.Text);

                    IsFileSaved = true;
                    writer.Close();
                    RelaunchApp();
                }
                else {
                    IsFileSaved = false;
                    RelaunchApp();
                }
            } else {
                IsFileSaved = true;
                RelaunchApp();
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e) {

            QuickStart.GetFileDialog().Filter = QuickStart.FileTypes;

            if (QuickStart.GetFileDialog().ShowDialog() == DialogResult.OK) {

                this.Text = Path.GetFileName(QuickStart.GetFileDialog().FileName);
                lblOpened.Text = Path.GetFileName(QuickStart.GetFileDialog().FileName);

                reader = new StreamReader(QuickStart.GetFileDialog().FileName);
                richTxtBox.Text = reader.ReadToEnd();

                IsFileSaved = false;
                reader.Close();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e) {

            IsFileSaved = false;
            QuickStart.GetSaveFileDialog().Filter = QuickStart.FileTypes;
            QuickStart.GetSaveFileDialog().Title = "Save";

            if (QuickStart.GetSaveFileDialog().ShowDialog() == DialogResult.OK) {

                this.Text = Path.GetFileName(QuickStart.GetSaveFileDialog().FileName);
                lblOpened.Text = Path.GetFileName(QuickStart.GetSaveFileDialog().FileName);

                writer = new StreamWriter(QuickStart.GetSaveFileDialog().FileName);
                writer.Write(richTxtBox.Text.ToString());

                IsFileSaved = true;
                writer.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {

            QuickStart.GetFileDialog().Filter = QuickStart.FileTypes;

            if (QuickStart.GetFileDialog().ShowDialog() == DialogResult.OK) {

                this.Text = Path.GetFileName(QuickStart.GetFileDialog().FileName);
                lblOpened.Text = Path.GetFileName(QuickStart.GetFileDialog().FileName);

                reader = new StreamReader(QuickStart.GetFileDialog().FileName);
                richTxtBox.Text = reader.ReadToEnd();

                IsFileSaved = false;
                reader.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {

            IsFileSaved = false;
            QuickStart.GetSaveFileDialog().Filter = QuickStart.FileTypes;
            QuickStart.GetSaveFileDialog().Title = "Save";

            if (QuickStart.GetSaveFileDialog().ShowDialog() == DialogResult.OK) {

                this.Text = Path.GetFileName(QuickStart.GetSaveFileDialog().FileName);
                lblOpened.Text = Path.GetFileName(QuickStart.GetSaveFileDialog().FileName);

                writer = new StreamWriter(QuickStart.GetSaveFileDialog().FileName);
                writer.Write(richTxtBox.Text.ToString());

                IsFileSaved = true;
                writer.Close();
            }
        }

        private void btnMax_Click(object sender, System.EventArgs e) {

            if (WindowState == FormWindowState.Normal) {

                WindowState = FormWindowState.Maximized;
            }
            else {
                WindowState = FormWindowState.Normal;
            }
        }

        private void AppContainer_Load(object sender, EventArgs e) {

            Screen screen = Screen.FromControl(this);
            int x = screen.WorkingArea.X - screen.Bounds.X;
            int y = screen.WorkingArea.Y - screen.Bounds.Y;

            this.MaximizedBounds = new Rectangle(x, y, screen.WorkingArea.Width, screen.WorkingArea.Height);
            this.MaximumSize = screen.WorkingArea.Size;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e) {
            dialog.Document = document;

            if (dialog.ShowDialog() == DialogResult.OK) {
                document.Print();
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e) {
            dialog.Document = document;

            if (dialog.ShowDialog() == DialogResult.OK) {
                document.Print();
            }
        }

        private void richTxtBox_KeyPress(object sender, KeyPressEventArgs e) {

            richTxtBox.Multiline = true;
            richTxtBox.AcceptsTab = true;

            if (e.KeyChar == 9) {
                e.Handled = false;
            }
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e) {

            if (colorDialog.ShowDialog() == DialogResult.OK) {
                richTxtBox.SelectionColor = colorDialog.Color;
            }
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e) {

            if (fontDialog.ShowDialog() == DialogResult.OK) {
                richTxtBox.Font = fontDialog.Font;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Text = Path.GetFileName("Blank document");
            lblOpened.Text = Path.GetFileName("Blank document");

            richTxtBox.Clear();
            IsFileSaved = false;
        }

        private void newToolStripButton_Click(object sender, EventArgs e) {
            this.Text = Path.GetFileName("Blank document");
            lblOpened.Text = Path.GetFileName("Blank document");

            richTxtBox.Clear();
            IsFileSaved = false;
        }

        private void RelaunchApp() {
            new QuickStart().Show();
            this.Hide();
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

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e) {
            e.Graphics.DrawString(richTxtBox.Text, new Font(fontDialog.Font.FontFamily, fontDialog.Font.Size, fontDialog.Font.Style), Brushes.Black, 100, 100);
        }

        private void panel_MouseUp(object sender, MouseEventArgs e) {
            Program.mouseDown = false;
        }

        private void AppContainer_FormClosing(object sender, FormClosingEventArgs e) {
            CheckSaveState();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            CheckSaveState();
        }

        private void undoToolStripButton_Click(object sender, EventArgs e) {
            richTxtBox.Undo();
        }

        private void redoToolStripButton_Click(object sender, EventArgs e) {
            richTxtBox.Redo();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) {
            richTxtBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e) {
            richTxtBox.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
            richTxtBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            richTxtBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            richTxtBox.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) {
            richTxtBox.SelectAll();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e) {
            richTxtBox.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e) {
            richTxtBox.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e) {
            richTxtBox.Paste();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            CheckSaveState();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            new AboutMenu().Show();
        }

        private void btnMin_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e) {
            btnClose.ForeColor = System.Drawing.Color.Black;
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

        private void boldTextToolStripMenuItem_Click(object sender, EventArgs e) {
            richTxtBox.SelectionFont = new Font(richTxtBox.Font, richTxtBox.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void italicTextToolStripMenuItem_Click(object sender, EventArgs e) {
            richTxtBox.SelectionFont = new Font(richTxtBox.Font, richTxtBox.SelectionFont.Style ^ FontStyle.Italic);
        }
    }
}
