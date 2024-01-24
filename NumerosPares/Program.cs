//Lista de inteiros utilizando o List<int>
List<int> numbers = new List<int>();

for(int i = 0; i < 100; i++)
{
    numbers.Add(i);
}

//utilizando o for para exibir apenas os números pares
Console.WriteLine("Números pares entre 0 e 100 (utilizando FOR)");
Console.WriteLine("-------------------------------------------------\n");

for(int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] % 2 == 0)
    {
        Console.WriteLine(numbers[i]);
    }
}

//utilizando o foreach para exibir apenas os números pares
Console.WriteLine("\nNúmeros pares entre 0 e 100 (utilizando FOREACH)");
Console.WriteLine("-------------------------------------------------\n");

foreach(int number in numbers)
{
    if(number % 2 == 0)
    {
        Console.WriteLine(number);
    }
}