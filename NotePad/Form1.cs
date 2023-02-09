namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter write  = new StreamWriter(File.Create((save.FileName)));
                write.Write(richTextBox1.Text);
                write.Dispose();
            }
        }

        private void customizeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
            richTextBox1.Font = font.Font;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colors = new ColorDialog();
            colors.ShowDialog();   
            richTextBox1.ForeColor = colors.Color; 
        }

        private void notepadColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colors = new ColorDialog();
            colors.ShowDialog();
            richTextBox1.BackColor = colors.Color;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFile.FileName);
            }
        }

        private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.ForeColor= Color.Black;
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.BackColor = Color.White;
        }

        private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.ForeColor = Color.White;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.BackColor = Color.Black;
        }

        private void neonThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.Orange;
            richTextBox1.ForeColor = Color.Magenta;
            richTextBox1.BackColor = Color.Black;
        }

        private void hackerThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.ForeColor = Color.White;
            richTextBox1.ForeColor = Color.LimeGreen;
            richTextBox1.BackColor = Color.Black;
        }

        private void midnightBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.RoyalBlue;
            menuStrip1.ForeColor = Color.White;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.BackColor = Color.MidnightBlue;
        }
    }
}