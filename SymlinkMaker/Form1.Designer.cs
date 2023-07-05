namespace SymlinkMaker {
    partial class SymlinkMakerForm {
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SymlinkMakerForm));
            lb_original = new Label();
            lb_target = new Label();
            tb_original = new TextBox();
            tb_target = new TextBox();
            tt_original = new ToolTip(components);
            btn_browse_original = new Button();
            btn_browse_target = new Button();
            btn_file_type = new Label();
            openFileDialog = new OpenFileDialog();
            folderBrowserDialog = new FolderBrowserDialog();
            cbo_filetype = new ComboBox();
            btn_work = new Button();
            SuspendLayout();
            // 
            // lb_original
            // 
            lb_original.AutoSize = true;
            lb_original.Location = new Point(12, 15);
            lb_original.Name = "lb_original";
            lb_original.Size = new Size(133, 15);
            lb_original.TabIndex = 0;
            lb_original.Text = "Original Folder/File (?) : ";
            tt_original.SetToolTip(lb_original, "The original Folder/File location");
            // 
            // lb_target
            // 
            lb_target.AutoSize = true;
            lb_target.Location = new Point(12, 44);
            lb_target.Name = "lb_target";
            lb_target.Size = new Size(97, 15);
            lb_target.TabIndex = 1;
            lb_target.Text = "Target Folder (?) :";
            tt_original.SetToolTip(lb_target, "Where the symlink should be placed and how it will be named (The original folder/file name is automatically added to the path). You can rename what the symlink by editing what is after the last \"/\".");
            // 
            // tb_original
            // 
            tb_original.Location = new Point(161, 7);
            tb_original.Name = "tb_original";
            tb_original.Size = new Size(232, 23);
            tb_original.TabIndex = 2;
            // 
            // tb_target
            // 
            tb_target.Location = new Point(161, 36);
            tb_target.Name = "tb_target";
            tb_target.Size = new Size(232, 23);
            tb_target.TabIndex = 3;
            // 
            // btn_browse_original
            // 
            btn_browse_original.Location = new Point(409, 7);
            btn_browse_original.Name = "btn_browse_original";
            btn_browse_original.Size = new Size(33, 23);
            btn_browse_original.TabIndex = 4;
            btn_browse_original.Text = "[...]";
            tt_original.SetToolTip(btn_browse_original, "Browse Files");
            btn_browse_original.UseVisualStyleBackColor = true;
            btn_browse_original.Click += btn_browse_original_Click;
            // 
            // btn_browse_target
            // 
            btn_browse_target.Location = new Point(409, 36);
            btn_browse_target.Name = "btn_browse_target";
            btn_browse_target.Size = new Size(33, 23);
            btn_browse_target.TabIndex = 5;
            btn_browse_target.Text = "[...]";
            tt_original.SetToolTip(btn_browse_target, "Browse Files");
            btn_browse_target.UseVisualStyleBackColor = true;
            btn_browse_target.Click += btn_browse_target_Click;
            // 
            // btn_file_type
            // 
            btn_file_type.AutoSize = true;
            btn_file_type.Location = new Point(12, 73);
            btn_file_type.Name = "btn_file_type";
            btn_file_type.Size = new Size(116, 15);
            btn_file_type.TabIndex = 6;
            btn_file_type.Text = "Choose File type (?) :";
            tt_original.SetToolTip(btn_file_type, "What is the tpye of the symlink should be");
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // cbo_filetype
            // 
            cbo_filetype.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_filetype.FormattingEnabled = true;
            cbo_filetype.Items.AddRange(new object[] { "Folder", "File", "Junction" });
            cbo_filetype.Location = new Point(161, 65);
            cbo_filetype.Name = "cbo_filetype";
            cbo_filetype.Size = new Size(121, 23);
            cbo_filetype.TabIndex = 7;
            // 
            // btn_work
            // 
            btn_work.Location = new Point(288, 64);
            btn_work.Name = "btn_work";
            btn_work.Size = new Size(154, 25);
            btn_work.TabIndex = 8;
            btn_work.Text = "Make Symlink";
            btn_work.UseVisualStyleBackColor = true;
            btn_work.Click += btn_work_Click;
            // 
            // SymlinkMakerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(459, 99);
            Controls.Add(btn_work);
            Controls.Add(cbo_filetype);
            Controls.Add(btn_file_type);
            Controls.Add(btn_browse_target);
            Controls.Add(btn_browse_original);
            Controls.Add(tb_target);
            Controls.Add(tb_original);
            Controls.Add(lb_target);
            Controls.Add(lb_original);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SymlinkMakerForm";
            Text = "SymlinkMaker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_original;
        private Label lb_target;
        private TextBox tb_original;
        private TextBox tb_target;
        private ToolTip tt_original;
        private Button btn_browse_original;
        private Button btn_browse_target;
        private OpenFileDialog openFileDialog;
        private FolderBrowserDialog folderBrowserDialog;
        private Label btn_file_type;
        private ComboBox cbo_filetype;
        private Button btn_work;
    }
}