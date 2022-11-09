
namespace Bloco_de_Notas_do_Lucas
{
    partial class F_main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_make = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_unmake = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_customize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_bold = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_italic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_underline = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_alingment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_left = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_center = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_right = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_newFile = new System.Windows.Forms.ToolStripButton();
            this.tsb_openFile = new System.Windows.Forms.ToolStripButton();
            this.tsb_copy = new System.Windows.Forms.ToolStripButton();
            this.tsb_paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_print = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file,
            this.tsmi_edit,
            this.tsmi_customize});
            this.menuStrip1.Location = new System.Drawing.Point(10, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(192, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_file
            // 
            this.tsmi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_newFile,
            this.tsmi_openFile,
            this.tsmi_save,
            this.tsmi_print,
            this.toolStripMenuItem1,
            this.tsmi_exit});
            this.tsmi_file.Name = "tsmi_file";
            this.tsmi_file.Size = new System.Drawing.Size(43, 22);
            this.tsmi_file.Text = "File";
            // 
            // tsmi_newFile
            // 
            this.tsmi_newFile.Name = "tsmi_newFile";
            this.tsmi_newFile.Size = new System.Drawing.Size(139, 22);
            this.tsmi_newFile.Text = "New File";
            this.tsmi_newFile.Click += new System.EventHandler(this.tsmi_newFile_Click);
            // 
            // tsmi_openFile
            // 
            this.tsmi_openFile.Name = "tsmi_openFile";
            this.tsmi_openFile.Size = new System.Drawing.Size(139, 22);
            this.tsmi_openFile.Text = "Open File";
            this.tsmi_openFile.Click += new System.EventHandler(this.tsmi_openFile_Click);
            // 
            // tsmi_save
            // 
            this.tsmi_save.Name = "tsmi_save";
            this.tsmi_save.Size = new System.Drawing.Size(139, 22);
            this.tsmi_save.Text = "Save";
            this.tsmi_save.Click += new System.EventHandler(this.tsmi_save_Click);
            // 
            // tsmi_print
            // 
            this.tsmi_print.Name = "tsmi_print";
            this.tsmi_print.Size = new System.Drawing.Size(180, 22);
            this.tsmi_print.Text = "Print";
            this.tsmi_print.Click += new System.EventHandler(this.tsmi_print_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 6);
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.Size = new System.Drawing.Size(139, 22);
            this.tsmi_exit.Text = "Exit";
            // 
            // tsmi_edit
            // 
            this.tsmi_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_copy,
            this.tsmi_paste,
            this.tsmi_make,
            this.tsmi_unmake});
            this.tsmi_edit.Name = "tsmi_edit";
            this.tsmi_edit.Size = new System.Drawing.Size(45, 22);
            this.tsmi_edit.Text = "Edit";
            // 
            // tsmi_copy
            // 
            this.tsmi_copy.Name = "tsmi_copy";
            this.tsmi_copy.Size = new System.Drawing.Size(132, 22);
            this.tsmi_copy.Text = "Copy";
            this.tsmi_copy.Click += new System.EventHandler(this.tsmi_copy_Click);
            // 
            // tsmi_paste
            // 
            this.tsmi_paste.Name = "tsmi_paste";
            this.tsmi_paste.Size = new System.Drawing.Size(132, 22);
            this.tsmi_paste.Text = "Paste";
            this.tsmi_paste.Click += new System.EventHandler(this.tsmi_paste_Click);
            // 
            // tsmi_make
            // 
            this.tsmi_make.Name = "tsmi_make";
            this.tsmi_make.Size = new System.Drawing.Size(132, 22);
            this.tsmi_make.Text = "Make";
            // 
            // tsmi_unmake
            // 
            this.tsmi_unmake.Name = "tsmi_unmake";
            this.tsmi_unmake.Size = new System.Drawing.Size(132, 22);
            this.tsmi_unmake.Text = "Unmake";
            // 
            // tsmi_customize
            // 
            this.tsmi_customize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_bold,
            this.tsmi_italic,
            this.tsmi_underline,
            this.tsmi_alingment});
            this.tsmi_customize.Name = "tsmi_customize";
            this.tsmi_customize.Size = new System.Drawing.Size(92, 22);
            this.tsmi_customize.Text = "Customize";
            // 
            // tsmi_bold
            // 
            this.tsmi_bold.Name = "tsmi_bold";
            this.tsmi_bold.Size = new System.Drawing.Size(180, 22);
            this.tsmi_bold.Text = "Bold";
            this.tsmi_bold.Click += new System.EventHandler(this.tsmi_bold_Click);
            // 
            // tsmi_italic
            // 
            this.tsmi_italic.Name = "tsmi_italic";
            this.tsmi_italic.Size = new System.Drawing.Size(180, 22);
            this.tsmi_italic.Text = "Italic";
            this.tsmi_italic.Click += new System.EventHandler(this.tsmi_italic_Click);
            // 
            // tsmi_underline
            // 
            this.tsmi_underline.Name = "tsmi_underline";
            this.tsmi_underline.Size = new System.Drawing.Size(180, 22);
            this.tsmi_underline.Text = "Underline";
            this.tsmi_underline.Click += new System.EventHandler(this.tsmi_underline_Click);
            // 
            // tsmi_alingment
            // 
            this.tsmi_alingment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_left,
            this.tsmi_center,
            this.tsmi_right});
            this.tsmi_alingment.Name = "tsmi_alingment";
            this.tsmi_alingment.Size = new System.Drawing.Size(180, 22);
            this.tsmi_alingment.Text = "Alingment";
            // 
            // tsmi_left
            // 
            this.tsmi_left.Name = "tsmi_left";
            this.tsmi_left.Size = new System.Drawing.Size(180, 22);
            this.tsmi_left.Text = "Left";
            this.tsmi_left.Click += new System.EventHandler(this.tsmi_left_Click);
            // 
            // tsmi_center
            // 
            this.tsmi_center.Name = "tsmi_center";
            this.tsmi_center.Size = new System.Drawing.Size(180, 22);
            this.tsmi_center.Text = "Center";
            this.tsmi_center.Click += new System.EventHandler(this.tsmi_center_Click);
            // 
            // tsmi_right
            // 
            this.tsmi_right.Name = "tsmi_right";
            this.tsmi_right.Size = new System.Drawing.Size(180, 22);
            this.tsmi_right.Text = "Right";
            this.tsmi_right.Click += new System.EventHandler(this.tsmi_right_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_newFile,
            this.tsb_openFile,
            this.tsb_copy,
            this.tsb_paste,
            this.toolStripSeparator1,
            this.tsb_print,
            this.tsb_save});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(13, 45);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(156, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_newFile
            // 
            this.tsb_newFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_newFile.Image = ((System.Drawing.Image)(resources.GetObject("tsb_newFile.Image")));
            this.tsb_newFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_newFile.Name = "tsb_newFile";
            this.tsb_newFile.Size = new System.Drawing.Size(23, 22);
            this.tsb_newFile.Text = "New File";
            this.tsb_newFile.Click += new System.EventHandler(this.tsb_newFile_Click);
            // 
            // tsb_openFile
            // 
            this.tsb_openFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_openFile.Image = ((System.Drawing.Image)(resources.GetObject("tsb_openFile.Image")));
            this.tsb_openFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_openFile.Name = "tsb_openFile";
            this.tsb_openFile.Size = new System.Drawing.Size(23, 22);
            this.tsb_openFile.Text = "Open File";
            this.tsb_openFile.Click += new System.EventHandler(this.tsb_openFile_Click);
            // 
            // tsb_copy
            // 
            this.tsb_copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_copy.Image = ((System.Drawing.Image)(resources.GetObject("tsb_copy.Image")));
            this.tsb_copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_copy.Name = "tsb_copy";
            this.tsb_copy.Size = new System.Drawing.Size(23, 22);
            this.tsb_copy.Text = "Copy";
            this.tsb_copy.Click += new System.EventHandler(this.tsb_copy_Click);
            // 
            // tsb_paste
            // 
            this.tsb_paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_paste.Image = ((System.Drawing.Image)(resources.GetObject("tsb_paste.Image")));
            this.tsb_paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_paste.Name = "tsb_paste";
            this.tsb_paste.Size = new System.Drawing.Size(23, 22);
            this.tsb_paste.Text = "Paste";
            this.tsb_paste.Click += new System.EventHandler(this.tsb_paste_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_print
            // 
            this.tsb_print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_print.Image = ((System.Drawing.Image)(resources.GetObject("tsb_print.Image")));
            this.tsb_print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_print.Name = "tsb_print";
            this.tsb_print.Size = new System.Drawing.Size(23, 22);
            this.tsb_print.Text = "Print File";
            this.tsb_print.Click += new System.EventHandler(this.tsb_print_Click);
            // 
            // tsb_save
            // 
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save.Image")));
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(23, 22);
            this.tsb_save.Text = "Save File";
            this.tsb_save.Click += new System.EventHandler(this.tsb_save_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(9, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(650, 365);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.DefaultExt = "txt";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // F_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloco de Notas do Lucas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file;
        private System.Windows.Forms.ToolStripMenuItem tsmi_newFile;
        private System.Windows.Forms.ToolStripMenuItem tsmi_openFile;
        private System.Windows.Forms.ToolStripMenuItem tsmi_save;
        private System.Windows.Forms.ToolStripMenuItem tsmi_print;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_copy;
        private System.Windows.Forms.ToolStripMenuItem tsmi_paste;
        private System.Windows.Forms.ToolStripMenuItem tsmi_make;
        private System.Windows.Forms.ToolStripMenuItem tsmi_unmake;
        private System.Windows.Forms.ToolStripMenuItem tsmi_customize;
        private System.Windows.Forms.ToolStripMenuItem tsmi_bold;
        private System.Windows.Forms.ToolStripMenuItem tsmi_italic;
        private System.Windows.Forms.ToolStripMenuItem tsmi_underline;
        private System.Windows.Forms.ToolStripMenuItem tsmi_alingment;
        private System.Windows.Forms.ToolStripMenuItem tsmi_left;
        private System.Windows.Forms.ToolStripMenuItem tsmi_center;
        private System.Windows.Forms.ToolStripMenuItem tsmi_right;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_newFile;
        private System.Windows.Forms.ToolStripButton tsb_openFile;
        private System.Windows.Forms.ToolStripButton tsb_copy;
        private System.Windows.Forms.ToolStripButton tsb_paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_print;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

