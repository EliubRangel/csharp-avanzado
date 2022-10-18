// See https://aka.ms/new-console-template for more information
using LamdaExpressions;


DemoLambda demo = new DemoLambda();

// demo.Saludar(() => Console.WriteLine("Hola mundo"));

// demo.Saludar(() => {
//     Console.WriteLine("Kiubole");
//     Console.WriteLine("Mundo");
// });

// demo.SaludosPagados((int x, string artista) => Console.WriteLine($"Pague {x} por un saludo a {artista}"));


demo.vender(() => {
    return 10;
});

demo.vender(() => 20);


demo.vender2((int x) => {
    return x * 0.16;
});
demo.vender2((int x) => x * 0.11);

int[] numeros = new int[] { 1, 5, 7, 8, 34, 12 };

arrays arr = new arrays();

arr.buscarNumero(numeros, (int x)=> {
    return x==5;
});

Console.WriteLine(arr.buscarNumero(numeros, (int x)=> x==8));

Console.WriteLine(arr.buscarNumero(numeros, x => x==8));

Console.WriteLine(arr.buscarNumero(numeros, x => x%5==0 || x%7==0));
