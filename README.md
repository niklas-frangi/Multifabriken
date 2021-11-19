[![Open in Visual Studio Code](https://classroom.github.com/assets/open-in-vscode-f059dc9a6f8d3a56e377f745f24479a46679e63a5d9fe6f495e02850cd0d8118.svg)](https://classroom.github.com/online_ide?assignment_repo_id=6358513&assignment_repo_type=AssignmentRepo)
# Multifabriken

>Du ska skapa en konsolapplikation där man kan välja att beställa nya produkter från fabriken.
>
>[Gå till uppgiften](https://ju.instructure.com/courses/5951/assignments/22265)


                                                **Självskattningen**

|**1**|**Ja**| *Lösningen ska bestå av en konsolapplikation skriven i C# som är körbar med .NET Core*|
               **Löst genom att skriva dotnet new console i Git Bash** 

|**2**|**Ja**| *När man startar programmet ska man mötas av en meny samt en kort introduktion till programmet*|
               **Både programmet och introtexten är i separata klasser och filer för att få en bätte överblick**

|**3**|**Ja**| *Man ska kunna göra ett val i menyn med vilken typ av produkt man vill beställa, om man vill lista alla  - produkter man beställt, eller om man  vill avsluta programmet*|
               **Klassen Menu som visar menyn är kopplad till klassen Choices och skickar med svarsalternativet**

|**4**|**Ja**| *Produkterna man kan välja mellan är bilar, godis, snören samt tofu*|
               **Varje produkt har sin egen klass som innehåller en konstruktor**

|**5**|**Ja**| *När man väljer att skapa ett snöre så ombes man att mata in "färg" samt "längd"*|
               **Två stycken console.ReadLine() som kopplas till variablerna stringColor och stringLength**

|**6**|**Ja**| *När man väljer att skapa en bil ska man ombes att mata in ett "registreringsnummer", en "färg", och sedan ett  - "bilmärke"*|
               **Fyra stycken console.ReadLine() som kopplas till variablerna letterPlate, numberPlate, color och brand**

|**7**|**Ja**| *När man väljer att skapa en godis ombes man att mata in "smak" följt av "antal"*|
               **Två stycken console.ReadLine() som kopplas till variablerna flavour och candyAmount**

|**8**|**Ja**| *När man väljer att skapa tofu ombes man att mata in "volym" i liter samt en "kryddning"*|
               **Två stycken console.ReadLine() som kopplas till variablerna tofuAmount och tofuSeasoning**

|**9**|**Ja**| *Om man väljer att lista alla produkter ska alla produkter man beställt hittills skrivas ut med den  - informationen man angett*|
               **Körde en foreach-loop genom samtliga listor**

|**10**|**Ja**| *Om man väljer att avsluta programmet ska programmet helt enkelt sluta köras*|
                **Menyalternativ 6 avbryter loopen som görs i Program.cs genom att skicka tillbaka false till loopen**

|**11**|**Ja**| *Lösningen ska bestå av en "Program.cs" fil, en ".csproj" fil samt en fil för varje extra klass du skapar*|
                **Program.cs och .csproj skapades automatiskt efter att ha skapat ett dotnet new console i Git Bash. Resten av filerna skapade jag själv och la i respektive klass**

|**12**|**Ja**| *Lösningen ska förutom kod innehålla en fil med namnet "reflections" i formatet md, txt eller pdf*|

|**13**|**Ja**| *reflections-filen ska en ska innehålla en kort beskrivning av kodens funktioner och struktur*|

|**14**|**Ja**| *Filen reflections ska också innehålla en egen analys och reflektion över hur du strukturerat din kod genom användandet av metoder och klasser.*|