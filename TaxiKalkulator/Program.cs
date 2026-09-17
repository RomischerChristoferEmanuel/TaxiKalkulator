//2. feladat
string utasnev = "Márton Károly";
double tavolsag = 14;
bool ejszak = true;
double alapdij = 1100;
double kmdij = 440;
double potlek = 1.20;

double osszeg = kmdij * tavolsag + alapdij;

//3. feladat
if (ejszak == true)
{
    double vegosszeg = osszeg * potlek;
    Console.WriteLine("Utas neve: Márton Károly");
    Console.WriteLine($"Megtett távolság: {tavolsag}");
    Console.WriteLine($"Alapérték: {osszeg}");
    Console.WriteLine($"Fizetendő összeg: {vegosszeg}");
    Console.WriteLine("Sátusz: 20% éjszakai pótlék felszámolva.");
}
