Console.WriteLine ("Введите число возводимое в степень");
int number = int.Parse(Console.ReadLine ());
Console.WriteLine ("Введите степень в которую надо возвести число");
int stepen = int.Parse(Console.ReadLine ());
int resultat = 1;
for (int i = 0; i < stepen; i++)
{
    resultat = resultat * number;
}
Console.WriteLine (resultat);