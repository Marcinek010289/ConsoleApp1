string name = "Ewa";
bool woman = true;
int age = 33;

if (woman == true)
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa lat 33");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}
else
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
}
