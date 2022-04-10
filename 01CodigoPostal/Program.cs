//Tarea:
//El usuario debe poder introducir su código postal.
//Se comprueba si el código postal tiene cinco dígitos.
//Si no es el caso, se mostrará en la consola "Código postal no válido".
//Si el código postal es correcto, se determinará la región correspondiente y se mostrará en la consola.
// Códigos postales: Empezando por 0 o 1 => Alemania del Este
// A partir de 2 => Norte de Alemania
// A partir de 3 => Alemania Central
// A partir de 4 o 5 => Alemania Occidental
// Que empiece por 6,7,8 o 9 => Sur de Alemania

Console.WriteLine("Por favor introduce un codigo postal");
Console.ForegroundColor = ConsoleColor.Yellow;
string codigoPostal = Console.ReadLine(); //guardamos los numeros introducidos por el usuario
Console.ResetColor();
bool validarCP = codigoPostal.Length == 5; //aqui verificamos que el codigo postal tenga 5 digitos
string region = "";

if (validarCP == false) //si el falso mostramos el siguiente mensaje
{
    Console.WriteLine("El codigo postal " + codigoPostal + " introducido no es valido. Debe tener al menos 5 digitos");
}
else
{
    char primerNumero = codigoPostal[0]; //verificamos las regiones
    switch (primerNumero)
    {
        case '0':
        case '1':
            region = "Alemania del Este";
            break;
        case '2':
            region = "Norte de Alemania";
            break;
        case '3':
            region = "Alemania Central";
            break;
        case '4':
        case '5':
            region = "Alemania Occidental";
            break;
        case '6':
        case '7':
        case '8':
        case '9':
            region = "Sur de Alemania";
            break;
        default:
            Console.WriteLine("Sie haben eine falsche eingabe gemacht");
            validarCP = false;
            break;
    }
    if (validarCP == true)
    {
        //Hay varias formas de incluir variables en una cadena y así emitirlas al usuario.
        //Concatenación
        //string ausgabe = "Ha introducido el siguiente código postal: " + codigoPostal + ". Usted viene de " + region;
        //Composición
        //ausgabe = String.Format("Ha introducido el siguiente código postal: {0}. Usted viene de {1}", codigoPostal, region);
        //Interpolación
        string salida = $"Ha introducido el siguiente código postal: {codigoPostal}. Usted viene de {region}";
        Console.WriteLine(salida);
    }
}