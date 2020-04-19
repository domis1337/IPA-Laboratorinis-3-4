# Versija 0.1

1. Įvesti naują studenta, įvesti jo pažymius.
2. Pasirinkti, kad studento pažymiai būtų automatiškai generuojami.
3. Atvaizduoti studentus ir jų galutinius pagal vidurkį.
4. Atvaizduoti studentus ir jų galutinius pagal medianą.


# Versija 0.2

1. Galimybė įvesti iš failo.
2. Studentai surušiuojami.
3. Sutvarkytas studentų vaizdavimas.


# Versija 0.3

1. Atliktas kodo reorganizavimas.
2. Panaudotas išimčių valdymas.

# Versija 0.4

1. Pridėtas failų generavimas.
2. Pridėtas studentų surūšiavimas į vargšelius ir kietiakus.
3. Pridėtas programos veikimo laiko tikrinimas.

**Programos greitis(studentai, vargsiukai/kietiakai, greitis):**
```
10 studentų, 2v/8k, 00:00:00:009
100 studentų, 42v/58k, 00:00:00:011
1000 studentų, 440v/560k, 00:00:00:046
10000 studentų, 4275v/5725k, 00:00:00:203
100000 studentų, 43240v/56760k, 00:00:01:752
Visos programos greitis 00:00:02:021
```

# Versija 0.5

**Time measured in Ms**
|          File          |        List         |  LinkedList.AddFirst   |  LinkedList.ElementAt  |   LinkedList.AddLast   |     Queue.Enqueue      |    Queue.ElementAt     |      Queue.Append      |
|-|-|-|-|-|-|-|-|
|        '10.txt'        |         4         |         0:00.0         |         0:00.0         |         0:00.0         |         0:00.0         |         0:00.0         |         0:00.0         |
|       '100.txt'        |         0:00.0         |         0:00.0         |         0:00.0         |         0:00.0         |         0:00.0         |         0:00.0         |         0:00.0         |
|       '1000.txt'       |         0:00.0         |         0:00.0         |         0:00.5         |         0:00.0         |         0:00.0         |         0:00.7         |         0:00.0         |
|      '10000.txt'       |         0:00.1         |         0:00.1         |        0:00.605        |         0:00.1         |         0:00.1         |        0:00.622        |         0:00.1         |
|      '100000.txt'      |        0:00.19         |        0:00.26         |        2:10.990        |        0:00.54         |        0:00.19         |        0:49.714        |        0:00.23         |

