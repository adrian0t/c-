

string inp = Console.ReadLine();
string[] words = inp.Split(' ');




var nazwisko = words[0];
var wiek = int.Parse(words[1]);
var wiekem = int.Parse(words[2]);




if (wiek >= wiekem && wiekem >= 0)
{
    Console.Write("Witaj emerycie " + nazwisko + "!");
}
if (wiek < 0 || wiekem < 0)
{
    Console.Write("Wiek nie może być ujemny!");
}
if (wiek < wiekem && wiek >= 0)
{
    int odp = wiekem - wiek;
    int lastDigit = odp % (10);

    if (odp == 1)
    {
        Console.Write("Witaj " + nazwisko + "! ");
        Console.Write("Do emerytury brakuje Ci " + odp + " rok!");
    }
    if (odp > 1 && odp < 5)
    {
        Console.Write("Witaj " + nazwisko + "! ");
        Console.Write("Do emerytury brakuje Ci " + odp + " lata!");
    }

    if (odp > 4 && odp < 100)
    {
        Console.Write("Witaj " + nazwisko + "! ");
        Console.Write("Do emerytury brakuje Ci " + odp + " lat!");
    }

    if (lastDigit > 1 && lastDigit < 5 && odp > 100)
    {
        Console.Write("Witaj " + nazwisko + "! ");
        Console.Write("Do emerytury brakuje Ci " + odp + " lata!");
    }
    if (lastDigit > 4 && lastDigit < 10 && odp > 100)
    {
        Console.Write("Witaj " + nazwisko + "! ");
        Console.Write("Do emerytury brakuje Ci " + odp + " lat!");
    }
    if (lastDigit == 0)
    {
        Console.Write("Witaj " + nazwisko + "! ");
        Console.Write("Do emerytury brakuje Ci " + odp + " lat!");
    }

}

