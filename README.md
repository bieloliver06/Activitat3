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

[^1]: Utilitzam `catch (System.FormatException)` per evitar que ens surti un error si el que hem introduit siguin nombres, i utilitzam `catch (System.OverflowException)` per evitar que ens surti un error si el que hem introduit no sigui major que 0;
