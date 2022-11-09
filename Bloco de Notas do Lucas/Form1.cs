using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloco_de_Notas_do_Lucas
{
    public partial class F_main : Form
    {

        public string txt;
        public string contentToPrint;

        public F_main()
        {
            InitializeComponent();
        }

        public void NewFile()
        {
            if(richTextBox1.TextLength != 0)
            {
                richTextBox1.Clear();
                richTextBox1.Focus();
            }
            else
            {
                MessageBox.Show("O arquivo já está vazio!");
            }
        }

        public void SaveFile()
        {
            if(this.SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream file = new FileStream(SaveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(file);
                    writer.Flush();
                    writer.BaseStream.Seek(0, SeekOrigin.Begin);
                    writer.Write(richTextBox1.Text);
                    writer.Flush();
                    writer.Close();
                }catch(Exception e)
                {
                    MessageBox.Show($"Erro: {e.Message}", "ERRO", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void OpenFile()
        {
            this.OpenFileDialog1.InitialDirectory = @"C:\Users\palme\OneDrive\Documentos\";
            this.OpenFileDialog1.Filter = "(*.txt)|*.txt";

            if(this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream file = new FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(file);
                    sr.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Clear();

                    while (!sr.EndOfStream)
                    {
                        richTextBox1.Text += $"{sr.ReadLine()} \n";
                    }

                    sr.Close();
                }catch(Exception e)
                {
                    MessageBox.Show($"Erro: {e.Message}", "ERRO", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Copy()
        {
            if(richTextBox1.TextLength > 0)
            {
                try
                {
                    this.txt = richTextBox1.SelectedText;

                }catch(Exception e)
                {
                    MessageBox.Show(e.Message, "ERRO", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"ERRO: A Caixa de Texto está vazia!");
            }
        }

        public void Paste()
        {
            if (!String.IsNullOrEmpty(this.txt))
            {
                try
                {
                    richTextBox1.Text += this.txt;
                }
                catch (Exception e) 
                {
                    MessageBox.Show(e.Message, "ERRO", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Área de transferência vazia!", "ERRO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Bold()
        {

            Font bold = new Font(richTextBox1.Font.FontFamily, 
                richTextBox1.Font.Size, FontStyle.Bold);

            Font regular = new Font(richTextBox1.Font.FontFamily,
                richTextBox1.Font.Size, FontStyle.Regular);

            if(richTextBox1.SelectionFont.Style == FontStyle.Regular)
            {
                richTextBox1.SelectionFont = bold;
            }
            else
            {
                richTextBox1.SelectionFont = regular;
            }
        }

        public void Italic()
        {

            Font italic = new Font(richTextBox1.SelectionFont.FontFamily,
                richTextBox1.SelectionFont.Size, FontStyle.Italic);

            Font regular = new Font(richTextBox1.Font.FontFamily,
                richTextBox1.Font.Size, FontStyle.Regular);

            if (richTextBox1.SelectionFont.Style == FontStyle.Regular)
            {
                richTextBox1.SelectionFont = italic;
                
            }
            else
            {
                richTextBox1.SelectionFont = regular;
            }
        }

        public void Underline()
        {

            Font underline = new Font(richTextBox1.SelectionFont.FontFamily,
                richTextBox1.SelectionFont.Size, FontStyle.Underline);

            Font regular = new Font(richTextBox1.Font.FontFamily,
                richTextBox1.Font.Size, FontStyle.Regular);

            if (richTextBox1.SelectionFont.Style == FontStyle.Regular)
            {
                richTextBox1.SelectionFont = underline;
            }
            else
            {
                richTextBox1.SelectionFont = regular;
            }
        }

        public void Left_Alingment()
        {
            if(richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            } 
        }

        public void Center_Alingment()
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        public void Right_Alignment()
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        public void Print()
        {
            printDialog1.Document = printDocument1;
            this.contentToPrint = richTextBox1.Text;

            if(this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void tsmi_newFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void tsb_newFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void tsmi_save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void tsb_save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void tsmi_openFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void tsb_openFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void tsb_copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void tsmi_copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void tsmi_paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void tsb_paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void tsmi_bold_Click(object sender, EventArgs e)
        {
            Bold();
        }

        private void tsmi_italic_Click(object sender, EventArgs e)
        {
            Italic();
        }

        private void tsmi_underline_Click(object sender, EventArgs e)
        {
            Underline();
        }

        private void tsmi_left_Click(object sender, EventArgs e)
        {
            Left_Alingment();
        }

        private void tsmi_center_Click(object sender, EventArgs e)
        {
            Center_Alingment();
        }

        private void tsmi_right_Click(object sender, EventArgs e)
        {
            Right_Alignment();
        }

        private void tsb_print_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void tsmi_print_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int line_lenght = 0;
            int linesPorPage = 0;

            e.Graphics.MeasureString(this.contentToPrint, richTextBox1.Font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out line_lenght, out linesPorPage);

            e.Graphics.DrawString(this.contentToPrint, richTextBox1.Font,
                Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

            this.contentToPrint = this.contentToPrint.Substring(line_lenght);

            e.HasMorePages = (this.contentToPrint.Length > 0);
        }
    }
}
