using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
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
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //MATCH MISSMATCH GAP DEGERLERINI ALMA
            int match = 1;
            int missmatch = -1;
            int gap = -2;
            if ((matchText.Text != "") && (missmatchText.Text != "") && (gapText.Text != ""))
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
            stopwatch.Stop();
            label8.Text = Convert.ToString(stopwatch.ElapsedMilliseconds+"saniye sürdü.");

        }
        private void FileFunction(string seq1, string seq2, int match, int missmatch, int gap)
        {
            //DOSYA OLUSTURMA

            WriteFile(seq1, seq2, match, missmatch, gap);


        }
        private void WriteFile(string seq1, string seq2, int match, int missmatch, int gap)
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
            ReadFile(match, missmatch, gap);
        }
        private void ReadFile(int match, int missmatch, int gap)
        {
            //SEQ1 DOSYASINI OKUMA------------------
            string dosya_yolu = @"D:\seq1.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string seq1 = "";
            while (seq1 != null)
            {

                if (sw.ReadLine() == null)
                {
                    break;
                }
                seq1 = sw.ReadLine();
            }
            sw.Close();
            fs.Close();

            // SEQ2 DOSYASINI OKUMA
            string dosya_yolu2 = @"D:\seq2.txt";
            FileStream fs2 = new FileStream(dosya_yolu2, FileMode.Open, FileAccess.Read);
            StreamReader sw2 = new StreamReader(fs2);
            string seq2 = "";
            while (seq2 != null)
            {

                if (sw2.ReadLine() == null)
                {
                    break;
                }

                seq2 = sw2.ReadLine();
            }

            sw2.Close();
            fs2.Close();
            if (seq1 != null && seq2 != null)
            {
                NeedlemanWunsch(seq1, seq2, match, missmatch, gap);
            }
            else
            {
                alignmentseq1.Text = Convert.ToString("Boþ seq1,seq2");
            }

        }

        private void NeedlemanWunsch(string seq1, string seq2, int match, int missmatch, int gap)
        {


            //MATRIX TANIMLAMA
            int[,] matrix = new int[seq1.Length+30 , seq2.Length+30 ];

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
                    int rule1 = matrix[i - 1, j - 1] + matchScore;
                    int rule2 = matrix[i - 1, j] + gap;
                    int rule3 = matrix[i, j - 1] + gap;
                    int maxScore = Math.Max(rule1, Math.Max(rule2, rule3));
                    matrix[i, j] = maxScore;


                }

            }




            //SUTUN VE KOLON BASLIKLARI YAZMA
            dataGridView1.ColumnCount = seq2.Length + 30;
            dataGridView1.RowCount = seq1.Length + 30;
            dataGridView1.Columns[0].HeaderText = "m";
           
            string[] dizi1 = new string[seq1.Length];
            string[] dizi2 = new string[seq2.Length];
            int a = 0;
            int b = 0;
            dataGridView1.RowHeadersWidth = dataGridView1.RowHeadersWidth + (30);
            foreach (char c in seq1.ToCharArray())
            {
                dizi1[a] = c.ToString();
                dataGridView1.Columns[a + 1].HeaderText = dizi1[a];
             
                a++;
            }
            foreach (char d in seq2.ToCharArray())
            {
                dizi2[b] = d.ToString();
                dataGridView1.Rows[0].HeaderCell.Value = "n";
                dataGridView1.Rows[b +1].HeaderCell.Value = dizi2[b];
                b++;
            }

            //OLUSTURDUGUMUZ MATRIXI DATAGRIDE YAZDIRMA
            for (int i = 0; i <= seq1.Length; i++)
            {
                for (int j = 0; j <= seq2.Length; j++)
                {

                    dataGridView1[i, j].Value = matrix[i, j];

                }
            }

            //SCORE VE HIZALAMA OLUSTURMA
         
           

            string Alignmentseq1 = string.Empty;
            string Alignmentseq2 = string.Empty;
       
            int column = seq1.Length ;
            int row = seq2.Length ;
          
            while (column > 0 && row > 0)
            {
                dataGridView1.Rows[row].Cells[column].Style.BackColor = Color.SkyBlue;
                int scroeDiag = 0;
                if (seq1[column - 1] == seq2[row - 1])
                    scroeDiag = match;
                else
                    scroeDiag = missmatch;

                if (column > 0 && row > 0 && matrix[column, row] == matrix[column - 1, row - 1] + scroeDiag)
                {
                    Alignmentseq1 = seq1[column - 1]+Alignmentseq1  ;
                    Alignmentseq2 = seq2[row - 1]+ Alignmentseq2  ;
                    column--;
                    row--;
                    dataGridView1.Rows[row].Cells[column].Style.BackColor = Color.SkyBlue;
                }
                else if (row > 0 && matrix[column, row] == matrix[column, row - 1] + gap)
                {
                    Alignmentseq1 = seq1[column - 1]+ Alignmentseq1  ;
                    Alignmentseq2 = "--"+Alignmentseq2 ;
                    row--;
                    dataGridView1.Rows[row].Cells[column].Style.BackColor = Color.SkyBlue;

                }
                else //if (column > 0 && matrix[column, row] == matrix[column - 1, row] + gap)
                {
                    Alignmentseq1 = "--" + Alignmentseq1  ;
                    Alignmentseq2 = seq2[row - 1]+ Alignmentseq2  ;
                    column--;
                    dataGridView1.Rows[row].Cells[column].Style.BackColor = Color.SkyBlue;
                }
             
                score.Text = Convert.ToString(scroeDiag);
            }
            alignmentseq1.Text = Convert.ToString(Alignmentseq1);
            alignmentseq2.Text = Convert.ToString(Alignmentseq2);










        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
        
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}