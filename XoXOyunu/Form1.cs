using System.Drawing.Text;

namespace XoXOyunu
{
    public partial class Form1 : Form
    {
        int oyunSayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void XoxTiklama(object sender, EventArgs e)
        {
            Button butonSecilen= sender as Button;//9 butona ayn� anda t�kland��� i�in g�nderilen butonu se�memizi sa�layacak.

            if (lblXo.Text=="X" )//S�ra X de ise 
            {
                butonSecilen.Text = "X";//E�er label�n textinde X yaz�yorsa t�klanan butonun texti de X olur.
                butonSecilen.Enabled = false;//T�klanan butona tekrar t�klanmamas� i�in.
                lblXo.Text = "O";//Bir sonraki s�ra O ya ge�ece�i i�in yazd�k.

            }
            else
            {
                butonSecilen.Text = "O";//E�er se�ilen buton X de�ilde O ise t�klanan butonun texti O olur.
                butonSecilen.Enabled = false;//T�klanan butona tekrar t�klanmamas� i�in.
                lblXo.Text = "X";//Tekrar s�ra X e ge�ti.
            }

            #region Oyunun Kazan�lmas�
            //Oyunun kazan�lmas� i�in 8 ihtimal var:

            //1:Button(1,2,3)'�n birlikte X olmas� .
            //2:Button(4,5,6)'�n birlikte X olmas� .
            //3:Button(7,8,9)'�n birlikte X olmas� .
            //4:Button(1,4,7)'�n birlikte X olmas� .
            //5:Button(2,5,8)'�n birlikte X olmas� .
            //6:Button(3,6,9)'�n birlikte X olmas� .
            //7:Button(1,5,9)'�n birlikte X olmas� .
            //8:Button(3,5,7)'�n birlikte X olmas� .

            // "X" i�in olanlar:

            if (button1.Text=="X" && button2.Text == "X"&& button3.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }

            //Ayn� i�lemler "O" i�in de ge�erli

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan oldu�u i�in OyunBitisi() metodunu �a��rd�k.
            }
            #endregion

            //Berabere kalma durumunda yani kazanan olmazsa:

            if (button1.Text!=""&& button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button9.Text != "" && button9.Text != "") //T�m butonlar�n i�i bo� de�ilse(Yani doluysa) ve kazanan olmad��� i�in berabere kal�n�r.
            {
                MessageBox.Show("Berabere!");
                OyunBitisi();//Berabere kal�nd���nda da yine oyun biter,bu y�zden OyunBitisi() metodunu �a��r�r�z.               
            }

        }
        private void OyunBitisi() //Oyun biti�i i�in metod tan�mlad�k.
        {
            lblXo.Text = "X";//X le ba�lad��� i�in oyun biti�inde tekrar s�ra X e d�n�yor.

            //Butonlar�n textlerinin i�i bo� hale getirilir.
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            //Kullan�lan butonlar�n enabled (t�klanabilirlik) �zelli�ini aktif hale getirmemiz gerekiyor.

            button1.Enabled= true;
            button2.Enabled= true;
            button3.Enabled= true;
            button4.Enabled= true;
            button5.Enabled= true;
            button6.Enabled= true;
            button7.Enabled= true;
            button8.Enabled= true;
            button9.Enabled= true;


            //Oyunu 3 kere oynatt�ktan sonra kapat�yoruz.
            oyunSayac++;
            if (oyunSayac == 3)
            {
                this.Close();
            }
        }
    }
}
