using TempConversionLibrary;

char fromScale, toScale;

while (true)
{
    Console.WriteLine("What temperature do you want to convert? (int number please)");
    int fromTemp = int.Parse(Console.ReadLine());

    Console.WriteLine($"What temperature scale is {fromTemp} in? (C F or K)");
    fromScale = Console.ReadLine()[0];

    Console.WriteLine("What temperature do you want to convert to? (C F or K)");
    toScale = Console.ReadLine()[0];

    var calculator = new ConversionCalculator(fromTemp, fromScale);


    switch(toScale)
    {
        case 'C':
            //res = calculator.ToCelsius();
            Console.WriteLine($"{fromTemp}°{fromScale} is {calculator.ToCelsius()}°{toScale}\n\n");
            //Console.WriteLine($"{fromTemp} in Celsius is {calculator.ToCelsius()}\n\n");
            break;

        case 'F':
            //res = calculator.ToFahrenheight();
            Console.WriteLine($"{fromTemp}°{fromScale} is {calculator.ToFahrenheight()}°{toScale}\n\n");
            //Console.WriteLine($"{fromTemp} in Celsius is {calculator.ToFahrenheight()}\n\n");
            break;

        case 'K':
            //res = calculator.ToKelvin();
            Console.WriteLine($"{fromTemp}°{fromScale} is {calculator.ToKelvin()}°{toScale}\n\n");
            //Console.WriteLine($"{fromTemp} in Celsius is {calculator.ToKelvin()}\n\n");
            break;
    }

   

}



