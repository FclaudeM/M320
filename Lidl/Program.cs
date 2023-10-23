namespace Lidl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person() { Name = "Efe", Vorname = "Bora" };
            Kunde kunde1 = new Kunde("Max", "Muster", 8, "0912481", 15.5);
            Lagerist lagerist1 = new Lagerist("Stapelfahrer", "Klaus", 7, "1234235623", 1.84);
            //person1.Esse();
            kunde1.Esse();
            kunde1.Kaufe();
            lagerist1.Esse();
            lagerist1.LagereEin();
            lagerist1.Trage();
            kunde1.Trage();
            Kind kind1 = new Kind("Beby", "Boy", 6, "102983", 1);
            kind1.Esse();
            kind1.Trage();
        }
    }
}