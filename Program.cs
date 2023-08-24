Console.WriteLine("Iveskite metu skaiciu: ");
int numberOfYear = Convert.ToInt32(Console.ReadLine());
if ((numberOfYear % 4 == 0 && numberOfYear % 100 != 0) || numberOfYear % 400 == 0)
{ 
    Console.WriteLine("Tai yra keliamieji metai");
}
else
{
    Console.WriteLine("Tai nėra keliamieji metai");
}