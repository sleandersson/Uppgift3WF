namespace Uppgift3WF
{
    public partial class Person     //klassen Person 
    {
        public static string FNamn { get; set; }
        public static string ENamn { get; set; }
        public static string PersNr { get; set; }
        public static string Kön { get; set; }
        public static bool Luhn(string nummer)      //Luhn algoritmen, mod 10 algoritm, för att kolla om personnumret är giltigt, funkar också på kredit-kort b.l.a.
        {
            return nummer.All(char.IsDigit) && nummer.Reverse()
                .Select(c => c - 48)
                .Select((dettaNum, i) => i % 2 == 0
                    ? dettaNum
                    : ((dettaNum *= 2) > 9 ? dettaNum - 9 : dettaNum)
                ).Sum() % 10 == 0;
        }
        public static string könsKoll(string kön)   //Gör en array av alla siffror i p.nummer, näst sista siffran kollas och könsbestämmer efter modulo 
        {
            int[] list = PersNr.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray(); //Använder LINQ, konverterar char till
                                                                                           //numeriskt värde -48 för att få det numeriska värdet
            int rest = list[8] % 2;
            if (rest == 0)
            {
                return Person.Kön = " kvinna";
            }
            else
                return Person.Kön = " man";
        }
    }
}
