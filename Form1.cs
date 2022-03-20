using System.Text.RegularExpressions; //För att kunna använda Regex.Replace

namespace Uppgift3WF //Staffan Leandersson, Sleandersson@yahoo.se, LB0002B, Uppgift 3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      
        private void btnKör_Click(object sender, EventArgs e)
        {
            lblResultat.Text = "";
            string perNum = Regex.Replace(txtPersNr.Text, @"[^0-9]", "");       //regexar bort allt utom siffrorna 0-9 och ersätter de med ""

            if (perNum.Length < 10)     //Längdcheck
            {
                lblResultat.Text ="Det är för få siffror i personnummret!";
                txtPersNr.Focus();
                return;
            }
            else if(perNum.Length > 10)     //Om de två första siffrorna är med skippa dom
                perNum = string.Join(string.Empty, perNum.Skip(2));

                try
                {
                    Person.PersNr = perNum;             
                    Person.FNamn = txtBNamn.Text;
                    Person.ENamn = txtBEftNamn.Text;
                    if (Person.Luhn(perNum) == true)       //personnummer kontroll, boolean
                    {
                        Person.könsKoll(Person.PersNr);     //om sant kontrollera kön
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
            lblResultat.Text = Person.FNamn + " " + Person.ENamn + " med personnummer: " + perNum + " är en" + Person.Kön;      //Printa ut resultatet
            Rensa();            //snygga till
        }
        private void Rensa()    //rensar och ställer markören i Namn-rutan
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