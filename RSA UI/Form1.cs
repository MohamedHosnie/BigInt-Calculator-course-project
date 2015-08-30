using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RSA_UI
{
    public partial class Form1 : Form
    {
        #region main
        private Boolean plus, minus, div, mul,mod,power;
        private BigInt A, B, Res;
        public Form1()
        {
            plus = false;
            minus = false;
            div = false;
            mul = false;
            mod = false;
            power = false;
            InitializeComponent();
            progressBar.Visible = false;
        }
        private void progressBar_Click(object sender, EventArgs e)
        {

        }
        private void file_dir_text_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void saved_button_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion 

        #region RSA
     
        private void start_button_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Value = 0;
            SyncTask.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open RSA File";
            dlg.Filter = "TXT files|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                file_dir_text.Text = fileName;

            }
        }


        private void save_button_Click(object sender, EventArgs e)
        {
            String SavedText = textBox1.Text;
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = saved_button.Text + ".txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(save.FileName))
                    sw.Write(SavedText);
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                start_button.Text = "Working ...";
                textBox1.Text = "";
                Time.Text = "";
                String s = "";
                String tmpED;
                String tmpM;
                String tmp_N;
                String check;
                int start = System.Environment.TickCount;
                FileStream file = new FileStream(file_dir_text.Text, FileMode.Open);
                StreamReader SR = new StreamReader(file);

                int test = int.Parse(SR.ReadLine());
                while (SR.Peek() != -1)
                {
                    tmp_N = SR.ReadLine();
                    BigInt N = new BigInt(tmp_N);
                    tmpED = SR.ReadLine();
                    BigInt ED = new BigInt(tmpED);
                    tmpM = SR.ReadLine();
                    BigInt M = new BigInt(tmpM);
                    BigInt res = BigInt.En_Decrytion(ED, N, M);
                    check = SR.ReadLine();
                    String fres = BigInt.UIRes(res);
                    s += fres + Environment.NewLine;
                    textBox1.Text += fres + Environment.NewLine + Environment.NewLine;
                    progressBar.Increment(100 / test);
                }
                int end = System.Environment.TickCount;
                double dif = TimeSpan.FromMilliseconds(end - start).TotalSeconds;  
                Time.Text = dif.ToString();
                SR.Close();
                file.Close();
                progressBar.Value = 100;
                start_button.Text = "Start";
                MessageBox.Show("File has Been Encrypted", "Done");
            }
            catch
            {
                MessageBox.Show("File doesn't Exist", "Error");
            }


        }

       
       

        private void button2_Click(object sender, EventArgs e)
        {
            file_dir_text.Text = "";
        }
        #endregion

        #region Calculator

       

        private void mod_button_Click(object sender, EventArgs e)
        {
            string tmp = input.Text;
            A = new BigInt(tmp);
            input.Text = "";
            full_text.Text = BigInt.UIRes(A) + " % ";
            power = false;
            mod = true;
            div = false;
            plus = false;
            minus = false;
            mul = false;

        }

        private void power_button_Click(object sender, EventArgs e)
        {
            string tmp = input.Text;
            A = new BigInt(tmp);
            input.Text = "";
            full_text.Text = BigInt.UIRes(A) + " ^ ";
            power = true;
            mod = false;
            div = false;
            plus = false;
            minus = false;
            mul = false;

        }
        private void div_button_Click(object sender, EventArgs e)
        {
            string tmp = input.Text;
            A =new BigInt(tmp);
            input.Text = "";
            full_text.Text = BigInt.UIRes(A) + " / ";
            power = false;
            mod = false;
            div = true;
            plus = false;
            minus = false;
            mul = false;
        }

        private void add_button_Click(object sender, EventArgs e)
        {

            String tmp = input.Text;
            A = new BigInt(tmp);
            input.Text = "";
            full_text.Text = BigInt.UIRes(A) + " + ";
            power = false;
            mod = false;
            div = false;
            plus = true ;
            minus = false;
            mul = false;
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
                String tmp = input.Text;
                A = new BigInt(tmp);
                input.Text = "";
                full_text.Text = BigInt.UIRes(A) + " - ";
                power = false;
                mod = false;    
                div = false;
                plus = false;
                minus = true;
                mul = false;
            
            }

        private void mul_button_Click(object sender, EventArgs e)
        {
            String tmp = input.Text;
            A = new BigInt(tmp);
            input.Text = "";
            full_text.Text = BigInt.UIRes(A) + " * ";
            power = false;
            mod = false;
            div = false;
            plus = false;
            minus = false;
            mul = true ;
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            try
            {
                int start, end;
                double dif;
                String tmp = input.Text;
                B = new BigInt(tmp);
                full_text.Text += BigInt.UIRes(B);
                if (plus == true)
                {
                    start = System.Environment.TickCount; 
                    Res = A + B;
                    end = System.Environment.TickCount;
                    dif = TimeSpan.FromMilliseconds(end - start).TotalSeconds; 
                    operation_time.Text = dif.ToString();
                    input.Text = BigInt.UIRes(Res);
                }
                else if (minus == true)
                {
                    start = System.Environment.TickCount; 
                    Res = A - B;
                    end = System.Environment.TickCount;
                    dif = TimeSpan.FromMilliseconds(end - start).TotalSeconds; 
                    operation_time.Text = dif.ToString();
                    input.Text = BigInt.UIRes(Res);
                }

                else if (div == true)
                {
                    BigInt[] res2 = new BigInt[2];
                    start= System.Environment.TickCount;
                    res2 = A / B;
                    end = System.Environment.TickCount;
                    dif = TimeSpan.FromMilliseconds(end - start).TotalSeconds; 
                    operation_time.Text = dif.ToString();
                    input.Text = BigInt.UIRes(res2[0]);
                }
                else if (mul == true)
                {
                    start = System.Environment.TickCount;
                    Res = A * B;
                    end = System.Environment.TickCount;
                    dif = TimeSpan.FromMilliseconds(end - start).TotalSeconds; 
                    operation_time.Text = dif.ToString();
                    input.Text = BigInt.UIRes(Res);
                }
                else if (power == true)
                {
                    start = System.Environment.TickCount;
                    Res = A ^ B;
                    end = System.Environment.TickCount;
                    dif = TimeSpan.FromMilliseconds(end - start).TotalSeconds; 
                    operation_time.Text = dif.ToString();
                    input.Text = BigInt.UIRes(Res);
                }
                else if (mod == true)
                {
                    start = System.Environment.TickCount;
                    Res = A % B;
                    end = System.Environment.TickCount;
                    dif = TimeSpan.FromMilliseconds(end - start).TotalSeconds; 
                    operation_time.Text = dif.ToString();
                    input.Text = BigInt.UIRes(Res);
                }
                else
                {
                    operation_time.Text = "";
                    full_text.Text = "";
                    MessageBox.Show("You haven't chosen any Function", "Error");
                }
                plus = false;
                minus = false;
                div = false;
                mul = false;
            }
            catch {
                MessageBox.Show("Something Went Wrong ", "Error");
            }
        }

        private void clear_but_Click(object sender, EventArgs e)
        {
            plus = false;
            minus = false;
            div = false;
            mul = false;
            full_text.Text = "";
            input.Text = "";
            operation_time.Text = "";
        }

        #endregion
       
        #region BONUSES

        private void intgenerate()
        {
            Random r = new Random();
            long x = r.Next();
            long y = r.Next();
            while (IsPrime(x) == false)
            {
                x = r.Next();
            }
            while (IsPrime(y) == false)
            {
                y = r.Next();
            }

            long n = x * y;
            long T = (x - 1) * (y - 1);
            long E = r.Next(1, (Int32)(T >> 32));
            while (IsPrime(E) == false && GCD(E, T) != 1)
            {
                E = r.Next();
            }
            long D = (1 / E) * 1 % T; 
            //long tmp = T + 1;
            //long D = tmp / E;
            MessageBox.Show("E = " + E.ToString()+ " N = " + n.ToString() + "D = " + D.ToString(),"Display");

        }

        private void BigintGenerate(String input)
        {

            int size = input.Length;
            Random r = new Random();    
            int psize = size / 2 + 3;
            int qsize = size / 2 + 3;
            int fp = r.Next();
            int fq = r.Next();
            BigInt p = new BigInt(fp);
            BigInt q = new BigInt(fq);
            int counter = 0;
            do
            {
                if(counter>0)
                {
                    p = new BigInt(psize);
                }
                while (p.size < psize)
                {
                    int tmp = r.Next();
                    p.append(new BigInt(tmp));
                }
                counter =1;
            } while (BigInt.Prime(p) == false);
            MessageBox.Show(BigInt.UIRes(p));

        }
        private void Prime_Click(object sender, EventArgs e)
        {
            String input = Bouns_text.Text;
            if (input.Length<30)
                intgenerate();
            else
            {
                BigintGenerate(input);
            }
            //BigInt x = new BigInt(223);
            //if (BigInt.Prime(x))
            //    MessageBox.Show("Prime");
            //else
            //    MessageBox.Show("Not");

            //Random r = new Random();
            //String message = input.Text;
            //int size = message.Length;

            //BigInt first, second;
            //String ou = "";
            //first = new BigInt((size / 2) + 1, 0);
            //second = new BigInt((size / 2) + 1, 0);
            //try
            //{
            //    do
            //    {
            //        for (int i = 0; i < first.size; i++)
            //        {
            //            first.set(i, r.Next(1, 9));
            //        }

            //    } while (BigInt.Prime(first) == false);
            //    ou += BigInt.UIRes(first);
            
           
            //    do
            //    {
            //        for (int i = 0; i < second.size; i++)
            //        {
            //            second.set(i, r.Next(0, 9));
            //        }

            //    } while (BigInt.Prime(second) == false);
            //    ou += "second      " + BigInt.UIRes(second);
            //}
            //catch (Exception f)
            //{
            //    MessageBox.Show(f.Message);
            //}

            //MessageBox.Show(ou);
            //MessageBox.Show(ou+"  Second ="+BigInt.UIRes(second),"Number");
            //long x = r.Next();
            //long y = r.Next();
            //while(IsPrime(x)==false )
            //{
            //    x = r.Next();
            //}
            //while (IsPrime(y) == false)
            //{
            //   y= r.Next();
            //}

            //long n = x * y;
            //long T = (x - 1) * (y - 1);
            //   long E = r.Next(1, (Int32)(T >> 32));
            //        while (IsPrime (E) == false && GCD(E,T) != 1)
            //        {
            //            E = r.Next();
            //       }
            //        long tmp = T + 1;
            //        long D = tmp / E;
            //for(int i= 12452; i<M ; i++)
            //{
            //    if (IsPrime(i))
            //        E = i;
            //}
            //int E = GCD(n, M);

            //input.Text = "x =" +x.ToString() + " y = " +y.ToString() +" E =" +E.ToString()  + " D =" + D.ToString();
        }

        #region GCD
        public long GCD ( long x , long y)
        {
        if( x == 0 & y ==0)
            return  0;
        if (x == 0)
            return y;
        if (y == 0)
            return x;
        long reminder = 0;
        do
        {
        reminder =  x % y;
        x = y;
        y = reminder;
        } while (reminder != 0);
            return x;
        }


        #endregion

        #region Prime
        public static bool IsPrime(long candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
        #endregion



        #endregion

    }
}
