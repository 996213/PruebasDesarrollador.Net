

//1. INvertir la cadena
using System.Text.RegularExpressions;

string text = "Esteban";
string textResult = "";

for (int i = text.Length -1; i>= 0; i--)
{
    textResult+= text[i];
    
}
Console.WriteLine($"Primera forma ciclo invertir Cadena: {textResult}");
char[] chars = text.ToCharArray();
Array.Reverse(chars);


textResult = new String(chars);
Console.WriteLine($"Segunda forma ToCharArray invertir Cadena: {textResult}");
textResult = "";
textResult = string.Join("",chars);
Console.WriteLine($"Tercera forma Join invertir Cadena: {textResult}");

//2. Cuantas veces se repite un caracter - Forma iterativa con IEnumerable de texto
string text2 = "dfsdfjisernvnsdnslkdnaklkdjfsd";
char character = 'n';
int contadorCaracterRepetido = 0;
foreach (char c in text2)
{
    if(c == character)
        contadorCaracterRepetido++;
}
Console.WriteLine($"se repite la letra {character} {contadorCaracterRepetido} veces. Con IEnumerable");

//Utilizando LINQ forma declarativa
contadorCaracterRepetido = 0;
contadorCaracterRepetido = text2.Where(x => x == character).Count();

Console.WriteLine($"se repite la letra {character} {contadorCaracterRepetido} veces. Con LINQ");

//3. Distancia de Hamming Comparar dos cadenas caracter por caracter y contar las diferencias.
string cadenaHamming1 = "cerditos1";
string cadenaHamming2 = "perfit0s1";
int contadorHamming = 0;
if (cadenaHamming1.Length != cadenaHamming2.Length)
    throw new Exception("Longitudes diferentes");

for(int i = 0; i < cadenaHamming1.Length; i++)
{
    if(cadenaHamming1[i]!= cadenaHamming2[i])
    {
        contadorHamming += 1;
    }
}

Console.WriteLine($"caracteres diferentes {contadorHamming}. Forma iterativa");

//4. Contador de palabras Con metodo Inmutable Trim()
string textPalabras = "Este     es un      texto de         prueba             ";
int contadorPalabras;

textPalabras = Regex.Replace(textPalabras, @"\s+", "        ");
var words = textPalabras.Trim().Split(' ');
Console.WriteLine($"N de palabras { words.Count() }. Usando Expresion Regular");


//5. Contador de numeros en cadena
string textCadenaNumeros = "1j2d3f44";
string pattern = @"[0-9]";
int contadorNumeros = 0;
var regex = new Regex(pattern);
contadorNumeros = regex.Matches(textCadenaNumeros).Count();

Console.WriteLine($"Cantidad de Numeros { contadorNumeros }. Usando Expresion Regular");
pattern = @"[a-zA-Z]";
regex = new Regex(pattern);
contadorNumeros = regex.Matches(textCadenaNumeros).Count();
Console.WriteLine($"Cantidad de Letras { contadorNumeros }. Usando Expresion Regular");

