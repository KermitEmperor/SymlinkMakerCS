

namespace SymlinkMaker {
    public partial class SymlinkMakerForm : Form {
        public SymlinkMakerForm() {
            InitializeComponent();
            cbo_filetype.Text = "Folder";
        }
        public static string[] fj = { "Folder", "Junction" };

        private void OKError(string errorMessage, string errorTitle) {
            MessageBox.Show(errorMessage, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_browse_original_Click(object sender, EventArgs e) {

            if (cbo_filetype.Text == "File") {
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    tb_original.Text = openFileDialog.FileName;
                }
            } else {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                    tb_original.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btn_browse_target_Click(object sender, EventArgs e) {
            if ((File.Exists(tb_original.Text) && cbo_filetype.Text == "File") || (Directory.Exists(tb_original.Text) &&  fj.Contains(cbo_filetype.Text))) {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                    tb_target.Text = folderBrowserDialog.SelectedPath + "\\" + tb_original.Text.Split("\\").Last();
                }
            } else {
                OKError("Incorrect original File or Folder location", "Incorrect Path");
            }
        }

        private void btn_work_Click(object sender, EventArgs e) {
            if (!((File.Exists(tb_original.Text) && cbo_filetype.Text == "File") || (Directory.Exists(tb_original.Text) && fj.Contains(cbo_filetype.Text)))) {
                OKError("Incorrect original File or Folder location \n\n(Possibly the Filetype doesn't match the originaly selected File/Folder?)", "Incorrect Path");
                return;
            }


            try {
                switch (cbo_filetype.Text) {
                    case "File":
                        File.CreateSymbolicLink(tb_target.Text, tb_original.Text);
                        MessageBox.Show("Symbolic link succesfully done", "Done!");
                        break;
                    case "Folder":
                        Directory.CreateSymbolicLink(tb_target.Text, tb_original.Text);
                        MessageBox.Show("Symbolic link succesfully done", "Done!");
                        break;
                    case "Junction":
                        OKError("Junctions are not supported yet in NET 6.0", "not implemented function");
                        break;
                }                
            } catch (Exception ex) {
                OKError($"There was an error while trying to make the symlink:\n{ex}", "Unexpected Error");
            }

        }
    }
}