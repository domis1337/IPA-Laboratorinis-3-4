# Kaip naudotis?
1. Įjunkite programą.
2. Skaitykite programos Meniu aprašytas funkcijas.
3. Sekite programos veikimo metu rodomas žinutes.

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

1. Pridėta galimybė išmatuoti programos greitį naudojant skirtingus konteinerius.


**Time measured in Ms**
|          File          |        List         |  LinkedList   |     Queue      |
|-|-|-|-|
|        '10.txt'        |         4         |         10         |         8              |
|       '100.txt'        |         7         |         8          |         9              |
|       '1000.txt'       |         23        |         27         |         22             |
|      '10000.txt'       |         88        |         92         |         87             |
|      '100000.txt'      |        590        |        564         |        567             |

Rezultatuose matyti, kad Queue<T> konteinerio greitis yra didžiausias.
  
# Versija 1.0

Programos veikimo greitis skirtingomis strategijomis, bei List<T> greitis su pakeistais algoritmais, antra strategija.

**Time measured in Ms**
|          File          |        List(strat1)         |  LinkedList(strat1)   |     Queue(strat1)      |        List(strat2)         |  LinkedList(strat2)   |     List(algoritm)      |
|-|-|-|-|-|-|-|
|        '10.txt'        |         6         |         4          |         5             |         5         |         5          |         4              |
|       '100.txt'        |         7         |         7          |         8             |         6         |         7          |         5              |
|       '1000.txt'       |         26        |         28         |         27            |         24        |         30         |         11             |
|      '10000.txt'       |         101       |        113         |         101           |         98        |         1027       |         51             |
|      '100000.txt'      |         705       |        707         |         604           |         1401      |         126563     |         474            |

Rezultatuose matyti, kad LinkedList<T> veikia lėčiausiai, ypač lėtai naudojant antrą strategiją ir su dideliais kiekiais duomenų.
Antra strategija, kurioje elementai yra trinami iš sąrašo, programa veikia lėčiau.


# Kaip įdiegti?
1. Eikite į "**releases**" skyrių.
2. Raskite programos 1.0 versiją.
3. Išskleiskite "**Assets**" skyrių.
4. Atsisiūskite **IPA_Laboratorinis_3_4.exe**.
5. Paleiskie **IPA_Laboratorinis_3_4.exe** programą.
