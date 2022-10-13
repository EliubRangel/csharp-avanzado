
int[] NumArray = new int[]{ 23,4,56,7,88,2,123,46,1,4,89,56,32,15,27,52,79,67,32 };
string[] StrArray = new string[]
{
    "cafe","bebidas","silla","mesa","pastel de chocolate","fuente","centro comercial",
    "telefono celular","cajero automatico"
};

int[] otroArr = new int[NumArray.Length];
for(int i=0; i< NumArray.Length;i++){
    if(NumArray[i]>=50)
        otroArr[i] = NumArray[i];
}

int[] numfiltrados = NumArray.Where((int x) => x > 50).ToArray();

int[] numPares = NumArray.Where(x => x%2 == 0).ToArray();

List<int> numImpares = NumArray.Where(x => x%2 != 0).ToList();

List<int> numOrdered = NumArray.OrderBy(x => x).ToList();

List<string> stringsOrdered = StrArray.OrderBy(x => x).ToList();
List<string> stringsOrderedLength = StrArray.OrderBy(x => x.Length).ToList();

Console.WriteLine("Arreglo original");
imprimir(NumArray);
Console.WriteLine("arreglo filtrado > 50");
imprimir(numfiltrados);
Console.WriteLine("Arreglo ordenado");
imprimir(numOrdered);
Console.WriteLine("Arreglo string ordenado");
imprimirstr(stringsOrdered);
Console.WriteLine("Arreglo string ordenado por length");
imprimirstr(stringsOrderedLength);

Console.WriteLine("Suma de los pares");
Console.WriteLine(numPares.Sum());

Console.WriteLine("Suma length de strings");
Console.WriteLine(StrArray.Sum(x => x.Length));

Console.WriteLine("Promedio de los pares");
Console.WriteLine(numPares.Average());

Console.WriteLine("Promedio de los mayores de 50");
Console.WriteLine(NumArray.Where(x => x > 50).Average());

void imprimir(IEnumerable<int> nums)
{
    foreach (var x in nums)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}

void imprimirstr(IEnumerable<string> nums)
{
    foreach (var x in nums)
    {
        Console.Write($"{x} | ");
    }
    Console.WriteLine();
}