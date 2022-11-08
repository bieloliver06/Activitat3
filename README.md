# Activitat 3

1. Fer un programa que demani l’edat de tres persones i mostri per pantalla la mitjana
   d’edat introduïda (s’ha de fer la mitja de les tres edats).
2. Fes un programa que et demana el radi d’un cercle, i et mostra per pantalla l’àrea i el
   perímetre de la circumferència.
3. Fes un programa que et demana dos valors, A i B, i et mostra per pantalla el resultat
   de fer A mòdul B.

## Apartat 1

### 1. Introduim el nombre de persones

Primer demanam el nombre de persones de les cuals se ha de introduir les edats. [^1]

```C#
UInt16 i_numAges;
while (true)
{
    Console.WriteLine("Introdueix el nombre de edats que vols introduir : ");
    string? s_numAges = Console.ReadLine();
    if (s_numAges != null)
    {
        try
        {
            i_numAges = Convert.ToUInt16(s_numAges);
            break;
        }
        catch (System.FormatException)
        {
            Console.WriteLine("El que has introduit no hes valid");
        }
        catch (System.OverflowException)
        {
            Console.WriteLine("El nombre no pot ser menor que 0");
        }
    }
}
```

### 2. Intrduir les edats

Per introduir les edats utilitzam `for (int i = 0; i < i_numAges; i++)` per demanar-les el nombre de vegades que hem introduit abans i ja que el que hem de fer es la mitja el que feim es sumar la edat que han introduit a les edats anteriors. [^1]

```C#
uint i_ageTotal = 0;
for (int i = 0; i < i_numAges; i++)
{
    while (true)
    {
        Console.WriteLine($"Introdueix la edat {i + 1} :");
        string? s_age = Console.ReadLine();
        if (s_age != null)
        {
            try
            {
                uint i_age = Convert.ToUInt16(s_age);
                i_ageTotal = i_ageTotal + i_age;
                break;
            }
            catch (System.FormatException)
            {
                Console.WriteLine("El que has introduit no es valid");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("El nombre no pot ser menor que 0");
            }
        }
    }
}
```

### 3. Feim la mitja i mostrar-la

Feim la mitja dividint el total de les edats introduides per el nombre de edats introduides.

```C#
uint mitja = i_ageTotal / i_numAges;
Console.WriteLine($"La mitja es de {mitja}");
```

## Apartat 2

### 1. Definim les variables

Definim les variables que utilitzarem

```C#
double d_radius;
double d_area;
double d_perimeter;
```

### 2. Introduim el radi de la circumferencia

Demanam que ens introduesqui el radi, i utilitzam `Math.Abs` per fer el valor absolut i que sempre sigui positiu. [^2]

```C#
while (true)
{
    Console.WriteLine("Introdueix el radi del cercle (cm) : ");
    string? s_radius = Console.ReadLine();
    if (s_radius != null)
    {
        try
        {
            d_radius = Math.Abs(Convert.ToDouble(s_radius));
            break;
        }
        catch (System.FormatException)
        {
            Console.WriteLine("El que has introduit no és valid");
        }
    }
}
```

### 3. Calculam l'area i el perimetre

Per calcular el perimetre i l'area utilitzarem `Math.PI` per tenir un nombre pi constant. Per fer l'area farem `d_area = Math.PI * Math.Pow(d_radius, 2);`, i per el perimetre farem `d_perimeter = 2 * Math.PI * d_radius;` i finalment el mostrarem amb :

```C#
Console.WriteLine($"El perimetre de un cercle amb un radi {d_radius} és de {d_perimeter} cm, i té un area de {d_area} cm^2");
```

## Apartat 3

### 1. Definim les variables

Definim les variables que utilitzarem.

```c#
float A;
float B;
```

### 2. Introduim els valors

Introduim els valors A i B [^2]

```C#
while (true)
{
    Console.WriteLine("Introdueix el valor A : ");
    string? s_A = Console.ReadLine();
    if (s_A != null)
    {
        try
        {
            A = float.Parse(s_A);
            break;
        }
        catch (System.FormatException)
        {
            Console.WriteLine("El que has introduit no és valid");
        }
    }
}
```

### 3. Mostram el resultat de fer A modul B

```c#
Console.WriteLine($"{A} mòdul {B} és {A % B}");
```

## License

[MIT](https://choosealicense.com/licenses/mit/)

[^1]: Utilitzam `catch (System.FormatException)` per evitar que ens surti un error si el que hem introduit no son nombres, i utilitzam `catch (System.OverflowException)` per evitar que ens surti un error si el que hem introduit no sigui major que 0;
[^2]: Utilitzam `catch (System.FormatException)` per evitar que ens surti un error si el que hem introduit no son nombres.
