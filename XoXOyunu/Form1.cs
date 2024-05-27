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
            Button butonSecilen= sender as Button;//9 butona aynı anda tıklandığı için gönderilen butonu seçmemizi sağlayacak.

            if (lblXo.Text=="${{ secrets.CONNECTION_STRING }}" )//Sıra X de ise 
            {
                butonSecilen.Text = "X";//Eğer labelın textinde X yazıyorsa tıklanan butonun texti de X olur.
                butonSecilen.Enabled = false;//Tıklanan butona tekrar tıklanmaması için.
                lblXo.Text = "O";//Bir sonraki sıra O ya geçeceği için yazdık.

            }
            else
            {
                butonSecilen.Text = "O";//Eğer seçilen buton X değilde O ise tıklanan butonun texti O olur.
                butonSecilen.Enabled = false;//Tıklanan butona tekrar tıklanmaması için.
                lblXo.Text = "X";//Tekrar sıra X e geçti.
            }

            #region Oyunun Kazanılması
            //Oyunun kazanılması için 8 ihtimal var:

            //1:Button(1,2,3)'ün birlikte X olması .
            //2:Button(4,5,6)'ün birlikte X olması .
            //3:Button(7,8,9)'ün birlikte X olması .
            //4:Button(1,4,7)'ün birlikte X olması .
            //5:Button(2,5,8)'ün birlikte X olması .
            //6:Button(3,6,9)'ün birlikte X olması .
            //7:Button(1,5,9)'ün birlikte X olması .
            //8:Button(3,5,7)'ün birlikte X olması .

            // "X" için olanlar:

            if (button1.Text=="X" && button2.Text == "X"&& button3.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }

            //Aynı işlemler "O" için de geçerli

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduğu için OyunBitisi() metodunu çağırdık.
            }
            #endregion

            //Berabere kalma durumunda yani kazanan olmazsa:

            if (button1.Text!=""&& button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button9.Text != "" && button9.Text != "") //Tüm butonların içi boş değilse(Yani doluysa) ve kazanan olmadığı için berabere kalınır.
            {
                MessageBox.Show("Berabere!");
                OyunBitisi();//Berabere kalındığında da yine oyun biter,bu yüzden OyunBitisi() metodunu çağırırız.               
            }

        }
        private void OyunBitisi() //Oyun bitişi için metod tanımladık.
        {
            lblXo.Text = "X";//X le başladığı için oyun bitişinde tekrar sıra X e dönüyor.

            //Butonların textlerinin içi boş hale getirilir.
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            //Kullanılan butonların enabled (tıklanabilirlik) özelliğini aktif hale getirmemiz gerekiyor.

            button1.Enabled= true;
            button2.Enabled= true;
            button3.Enabled= true;
            button4.Enabled= true;
            button5.Enabled= true;
            button6.Enabled= true;
            button7.Enabled= true;
            button8.Enabled= true;
            button9.Enabled= true;


            //Oyunu 3 kere oynattıktan sonra kapatıyoruz.
            oyunSayac++;
            if (oyunSayac == 3)
            {
                this.Close();
            }
        }
    }
}
