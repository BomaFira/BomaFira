namespace TP_KPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1 = printPreviewDialog1.Document;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtvalue.Text, new Font("Calibri", 20, FontStyle.Italic), Brushes.Black, new PointF(25, 50));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}