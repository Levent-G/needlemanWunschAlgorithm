using System.Data;
using System.IO;
using System.Windows.Forms;

namespace NeedlemanWunsch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }
     
        private void button1_Click(object sender, EventArgs e)
        {

            //MATCH MISSMATCH GAP DEGERLERINI ALMA
            int match = 1;
            int missmatch = -1;
            int gap = -2;
            if ((matchText.Text != "")&&(missmatchText.Text!="")&&(gapText.Text!="") )
            {
                match = Convert.ToInt32(matchText.Text);
                missmatch = Convert.ToInt32(missmatchText.Text);
                gap = Convert.ToInt32(gapText.Text);
            }

        // SEQ DEGERLERINI ALMA
            string seq1 = Convert.ToString(seq1Text.Text);
            string seq2 = Convert.ToString(seq2Text.Text);


            //SEQ1 DOSYASI TEMIZLEME
            string dosya_yolu = @"D:\seq1.txt";
            TextWriter tw = new StreamWriter(dosya_yolu);
            tw.Write("");
            tw.Close();


            //SEQ2 DOSYASI TEMIZLEME
            string dosya_yolu2 = @"D:\seq2.txt";
            TextWriter tw2 = new StreamWriter(dosya_yolu2);
            tw2.Write("");
            tw2.Close();

            FileFunction(seq1, seq2, match, missmatch, gap);

        }
        private void FileFunction(string seq1, string seq2, int match, int missmatch, int gap)
        {
            //DOSYA OLUSTURMA
            string seq1lenght="" ;
            string seq2lenght = "";
            WriteFile(seq1,seq2);
            ReadFile(seq1,seq1lenght,seq2, seq1lenght);
            NeedlemanWunsch(seq1, seq2, match, missmatch, gap);
        }
        private void WriteFile(string seq1 ,string seq2)
        {
            //SEQ1 DOSYASI YAZMA------
            string dosya_yolu = @"D:\seq1.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(seq1.Length);
            sw.WriteLine(seq1);
            sw.Flush();
            sw.Close();
            fs.Close();

            //SEQ2 DOSYASI YAZMA
            string dosya_yolu2 = @"D:\seq2.txt";
            FileStream fs2 = new FileStream(dosya_yolu2, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw2 = new StreamWriter(fs2);
            sw2.WriteLine(seq2.Length);
            sw2.WriteLine(seq2);
            sw2.Flush();
            sw2.Close();
            fs2.Close();
        }
        private void ReadFile(string seq1,string seq1lenght, string seq2, string seq2lenght)
        {
            //SEQ1 DOSYASINI OKUMA------------------
            string dosya_yolu = @"D:\seq1.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);       
            while (seq1 != null)
            {
                seq1lenght = sw.ReadLine();

                seq1 = sw.ReadLine();
            }
            sw.Close();
            fs.Close();

 // SEQ2 DOSYASINI OKUMA
            string dosya_yolu2 = @"D:\seq2.txt";
            FileStream fs2 = new FileStream(dosya_yolu2, FileMode.Open, FileAccess.Read);
            StreamReader sw2 = new StreamReader(fs2);
            while (seq2 != null)
            {
                seq2lenght = sw2.ReadLine();
                seq2 = sw2.ReadLine();
            }

            sw2.Close();
            fs2.Close();

        }

        private void NeedlemanWunsch(string seq1, string seq2, int match, int missmatch, int gap)
        {
        
           
            //MATRIX TANIMLAMA
            int[,] matrix = new int[seq1.Length + 1, seq2.Length + 1];

            // ILK KOLON VE SUTUNLARI TANIMLAMA
            for (int i = 0; i <= seq1.Length; i++)
            {
                matrix[0, i] = i * gap;
            }
            for (int j = 0; j <= seq2.Length; j++)
            {
                matrix[j, 0] = j * gap;
            }

            // MATRIXI DOLDURMA
            for (int i = 1; i <= seq1.Length; i++)
            {
                for (int j = 1; j <= seq2.Length; j++)
                {
                    int matchScore = seq1[i - 1] == seq2[j - 1] ? match : missmatch;
                    int diagonalScore = matrix[i - 1, j - 1] + matchScore;
                    int upScore = matrix[i - 1, j] + gap;
                    int leftScore = matrix[i, j - 1] + gap;
                    int maxScore = Math.Max(diagonalScore, Math.Max(upScore, leftScore));
                    matrix[i, j] = maxScore;
                    label1.Text = "score" + " " + maxScore.ToString();

                }

            }


      

            //SUTUN VE KOLON BASLIKLARI YAZMA
            dataGridView1.ColumnCount = seq2.Length + 1;
            dataGridView1.RowCount = seq1.Length + 1;
            dataGridView1.Columns[0].HeaderText = "seq1 =>";
            string[] dizi1 = new string[seq1.Length];
            int a = 0;
            foreach (char c in seq1.ToCharArray())
            {
                dizi1[a] = c.ToString();
                dataGridView1.Columns[a + 1].HeaderText = dizi1[a];
                a++;
            }

            //OLUSTURDUGUMUZ MATRIXI DATAGRIDE YAZDIRMA
            for (int i = 0; i <= seq1.Length; i++)
            {
                for (int j = 0; j <= seq2.Length; j++)
                {

                    dataGridView1[i, j].Value = matrix[i, j];
                }
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerformat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerformat);
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}