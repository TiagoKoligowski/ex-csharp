Console.WriteLine("Insira um numero: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira outro numero: ");
int n2 = int.Parse(Console.ReadLine());

if(n1 > n2){
    Console.WriteLine($"O numero {n1} é maior que {n2}!");
}

else if(n2> n1){
    Console.WriteLine($"O numero {n2} é maior que {n1}!");
}

else{
    Console.WriteLine("Os numeros são iguais!");
}