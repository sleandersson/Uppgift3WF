using System.Text.RegularExpressions; //F�r att kunna anv�nda Regex.Replace

namespace Uppgift3WF //Staffan Leandersson, Sleandersson@yahoo.se, LB0002B, Uppgift 3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      
        private void btnK�r_Click(object sender, EventArgs e)
        {
            lblResultat.Text = "";
            string perNum = Regex.Replace(txtPersNr.Text, @"[^0-9]", "");       //regexar bort allt utom siffrorna 0-9 och ers�tter de med ""

            if (perNum.Length < 10)     //L�ngdcheck
            {
                lblResultat.Text ="Det �r f�r f� siffror i personnummret!";
                txtPersNr.Focus();
                return;
            }
            else if(perNum.Length > 10)     //Om de tv� f�rsta siffrorna �r med skippa dom
                perNum = string.Join(string.Empty, perNum.Skip(2));

                try
                {
                    Person.PersNr = perNum;             
                    Person.FNamn = txtBNamn.Text;
                    Person.ENamn = txtBEftNamn.Text;
                    if (Person.Luhn(perNum) == true)       //personnummer kontroll, boolean
                    {
                        Person.k�nsKoll(Person.PersNr);     //om sant kontrollera k�n
                    }
                    else
                    {                                       //annars felmeddelande
                        lblResultat.Text = "Felaktigt person-nummer eller fel ordning i personnumret!" + '\n' + "var god kontrollera och prova igen";
                    txtPersNr.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            lblResultat.Text = Person.FNamn + " " + Person.ENamn + " med personnummer: " + perNum + " �r en" + Person.K�n;      //Printa ut resultatet
            Rensa();            //snygga till
        }
        private void Rensa()    //rensar och st�ller mark�ren i Namn-rutan
        {
            txtBNamn.Clear();
            txtBEftNamn.Clear();
            txtPersNr.Clear();
            txtBNamn.Focus();
        }
        private void btnAvsluta_Click(object sender, EventArgs e)       //Avslutar
        {
            Application.Exit();
        }              
    }
}