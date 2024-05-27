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
            Button butonSecilen= sender as Button;//9 butona ayný anda týklandýðý için gönderilen butonu seçmemizi saðlayacak.

            if (lblXo.Text=="X" )//Sýra X de ise 
            {
                butonSecilen.Text = "X";//Eðer labelýn textinde X yazýyorsa týklanan butonun texti de X olur.
                butonSecilen.Enabled = false;//Týklanan butona tekrar týklanmamasý için.
                lblXo.Text = "O";//Bir sonraki sýra O ya geçeceði için yazdýk.

            }
            else
            {
                butonSecilen.Text = "O";//Eðer seçilen buton X deðilde O ise týklanan butonun texti O olur.
                butonSecilen.Enabled = false;//Týklanan butona tekrar týklanmamasý için.
                lblXo.Text = "X";//Tekrar sýra X e geçti.
            }

            #region Oyunun Kazanýlmasý
            //Oyunun kazanýlmasý için 8 ihtimal var:

            //1:Button(1,2,3)'ün birlikte X olmasý .
            //2:Button(4,5,6)'ün birlikte X olmasý .
            //3:Button(7,8,9)'ün birlikte X olmasý .
            //4:Button(1,4,7)'ün birlikte X olmasý .
            //5:Button(2,5,8)'ün birlikte X olmasý .
            //6:Button(3,6,9)'ün birlikte X olmasý .
            //7:Button(1,5,9)'ün birlikte X olmasý .
            //8:Button(3,5,7)'ün birlikte X olmasý .

            // "X" için olanlar:

            if (button1.Text=="X" && button2.Text == "X"&& button3.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }

            //Ayný iþlemler "O" için de geçerli

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                OyunBitisi();//Kazanan olduðu için OyunBitisi() metodunu çaðýrdýk.
            }
            #endregion

            //Berabere kalma durumunda yani kazanan olmazsa:

            if (button1.Text!=""&& button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button9.Text != "" && button9.Text != "") //Tüm butonlarýn içi boþ deðilse(Yani doluysa) ve kazanan olmadýðý için berabere kalýnýr.
            {
                MessageBox.Show("Berabere!");
                OyunBitisi();//Berabere kalýndýðýnda da yine oyun biter,bu yüzden OyunBitisi() metodunu çaðýrýrýz.               
            }

        }
        private void OyunBitisi() //Oyun bitiþi için metod tanýmladýk.
        {
            lblXo.Text = "X";//X le baþladýðý için oyun bitiþinde tekrar sýra X e dönüyor.

            //Butonlarýn textlerinin içi boþ hale getirilir.
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            //Kullanýlan butonlarýn enabled (týklanabilirlik) özelliðini aktif hale getirmemiz gerekiyor.

            button1.Enabled= true;
            button2.Enabled= true;
            button3.Enabled= true;
            button4.Enabled= true;
            button5.Enabled= true;
            button6.Enabled= true;
            button7.Enabled= true;
            button8.Enabled= true;
            button9.Enabled= true;


            //Oyunu 3 kere oynattýktan sonra kapatýyoruz.
            oyunSayac++;
            if (oyunSayac == 3)
            {
                this.Close();
            }
        }
    }
}
