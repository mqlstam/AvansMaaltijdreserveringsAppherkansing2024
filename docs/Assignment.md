# SERVERSIDE WEB DEVELOPMENT INDIVIDUEEL

## OPDRACHT BESCHRIJVING VOEDSELVERSPILLING

![Croissants](https://pixabay.com/photos/bread-croissant-morning-puff-paste-1284438/)

IVT2.1 ServerSide Web Development Individueel - Opdracht
Pagina 1 van 16
---
# Inhoudsopgave

Inleiding............................................................................................................................. 3

Doel.................................................................................................................................... 3

Casus.................................................................................................................................. 3

US_01 Als student wil ik kunnen zien welke pakketten er aangeboden worden en welke 
ik gereserveerd heb, zodat ik makkelijk naar deze kan navigeren................................... 5

US_02 Als kantinemedewerker wil ik kunnen zien welke pakketten er aangeboden 
worden, zodat ik weet wat het huidige aanbod al is........................................................ 5

US_03 Als kantinemedewerker wil ik een pakket kunnen aanbieden, zodat een student 
deze kan reserveren......................................................................................................... 6

US_04 Als kantinemedewerker wil ik een pakket alleen voor volwassenen beschikbaar 
stellen, zodat minderjarigen niet kunnen reserveren...................................................... 6

US_05 Als student wil ik een pakket kunnen reserveren, zodat ik goedkoop producten 
kan bemachtigen............................................................................................................. 7

US_06 Als student wil ik weten wat voor producten er ongeveer in een pakket zitten, 
zodat ik weet of het pakket interessant voor mij is......................................................... 7

US_07 Als kantinemedewerker wil ik geen dubbele reservervingen hebben voor een 
pakket, zodat een pakket maar een keer gereservezeerd kan worden............................. 7

US_08 Als student wil ik kunnen filteren op locatie en type maaltijd, zodat ik 
snel een overzicht kan krijgen welke gewenste pakketten op mijn favoriete 
locatie aangeboden worden............................................................................................ 8

US_09 Als kantinemedewerker Mag ik alleen een warme maaltijd pakket 
opvoeren als dat ook op mijn locatie aangeboden wordt............................................... 8

US_10 Als kantinemedewerker wil ik weten of studenten reserveringen niet 
op hebben gehaald, zodat ik eventueel nieuwe reserveringen kan blokkeren. 9

Opdracht........................................................................................................................... 10

Oplevering......................................................................................................................... 14

Bibliografie........................................................................................................................ 15

IVT2.1 ServerSide Web Development Individueel - Opdracht
Pagina 2 van 16
---
# INLEIDING

Aan het begin van periode IVT2.1 heb je kennisgemaakt met het ontwikkelen van een webapplicatie met behulp van het ASP.net MVC Core framework, en heb je ook een aantal vaardigheden geleerd op het gebied van UX-design. In Software ontwerp & -architectuur 2 komt aantal applicatie-architecturen aan bod, zoals de clean (onion) architecture (Smith, 2017). In deze architectuurstijl staat de application core, het domeinmodel met bijbehorende services, centraal, (Figuur 1). Ook het ontwikkelen van een RESTful web API komt daar aan bod. De opdracht bij het onderdeel ServerSide Web Development Individueel (EIIN-SSWPI) integreert de genoemde vakken.

![Figuur 1 Onion architecture](image_placeholder)

In EIIN-SSWPI ontwikkel je een webapplicatie en een webservice en maakt daarbij gebruik van een software-ontwikkelstraat met automatische tests en deployment.

# DOEL

Het doel van deze opdracht is het ontwikkelen van een webapplicatie in ASP.net MVC Core waarbij je een UX-design maakt, een goede applicatie-architectuur toepast en waarbij je een ontwikkelstraat gebruikt, die automatisch de unit tests uitvoert en deployed. Tijdens het afrondend assessment demonstreer je je uitwerking en licht je gemaakte keuzes toe.

# CASUS

Avans heeft duurzaamheid hoog in haar vaandel staan. Daarom wil het college van bestuur graag dat binnen Avans verspilling zo veel mogelijk tegengegaan wordt. De verschillende kantines binnen Avans moeten aan het eind van de dag vaak nog veel eten weggooien. Dat is natuurlijk zonde van de grondstoffen. Daarom heeft het college van bestuur in samenspraak met studenten besloten om een alternatief voor "Too good to go" te lanceren voor studenten binnen Avans. De verschillende kantines (Breda, Tilburg en Den Bosch) kunnen per dag een pakket samenstellen van producten die ze aan willen bieden tegen een gereduceerde prijs. Studenten kunnen een pakket reserveren. Bij het afhalen in de kantine hoeft het pakket pas betaald te worden. Het college van bestuur heeft

IVT2.1 ServerSide Web Development Individueel - Opdracht
Pagina 3 van 16
---
# ATIx

De opleiding informatica gevraagd hier een systeem voor te ontwikkelen. Als docenten van de opleiding geven we natuurlijk onze studenten graag de kans om dit uit te voeren. Aan jullie dan ook de uitdaging om hier een mooi systeem voor te ontwikkelen.

## Wie zijn de actoren?

In het systeem bestaat natuurlijk de student. Van een student wordt de naam, de geboortedatum, het studentnummer, het e-mailadres, de studiestad en het telefoonnummer bijgehouden. De geboortedatum mag niet in de toekomst liggen en de leeftijd bij aanmelden voor een account is minimaal 16 jaar.

Een andere actor is natuurlijk de medewerker van de kantine. Van deze medewerker wordt de naam en het personeelsnummer bijgehouden en de locatie (specifieke kantine, b.v. 1a of 1d) waar hij of zij werkt.

De producten die aangeboden worden, worden in de vorm van een pakket aangeboden. Je kunt hierbij bijvoorbeeld denken aan een brood assortiment, een warme maaltijd assortiment (inclusief toetje), drank arrangement, enz. De exacte inhoud van het pakket wordt niet getoond op de website, omdat de vulling van het pakket bepaald wordt door de producten die op die specifieke dag over zijn gebleven. Wel wordt per pakket een voorbeeldvulling gegeven op basis van pakketten in het verleden. Het moet voor de student duidelijk zijn dat de getoonde vulling geen garantie is voor het eigen pakket.

Van een pakket worden in ieder geval de volgende gegevens bijgehouden:

- Beschrijvende naam (niet leeg)
- Lijst van producten (indicatie op basis van historie)
- Stad (Breda, Den Bosch, Tilburg)
- Kantine (per stad zijn er meerdere kantines, mag via enumeratie)
- Datum en tijdstip van ophalen
- Tijdstip tot wanneer een pakket opgehaald kan worden
- Indicatie 18+
- Prijs
- Type maaltijd (brood, warme avondmaaltijd, drank, ..., Deze staan vast en kan dus als enumeratie)
- Gereserveerd door (referentie naar student)

Van een product wordt in ieder geval bijgehouden:

- Beschrijvende naam (niet leeg)
- Alcoholhoudend ja/nee
- Foto

Van een kantine wordt in ieder geval bijgehouden:

- Stad
- Locatie
- Indicatie of warme maaltijden aangeboden worden (ja/nee)
---
# Wat zijn de user stories?

Userstory 1 tot en met 7 zijn verplicht. Naast deze user story's kies je 1 extra userstory van 8, 9 of 10. In totaal moeten dus minimaal 8 userstories geïmplementeerd worden.

## US_01 ALS STUDENT WIL IK KUNNEN ZIEN WELKE PAKKETTEN ER AANGEBODEN WORDEN EN WELKE IK GERESERVEERD HEB, ZODAT IK MAKKELIJK NAAR DEZE KAN NAVIGEREN.

Storypoints: 3

Toelichting:

Pakketten kunnen een paar dagen van tevoren al gepubliceerd worden door een kantine op basis van een inschatting van de medewerkers. Als student wil je natuurlijk een makkelijk overzicht hebben over de beschikbare pakketten.

Acceptatiecriteria:

- Er zijn twee pagina's. Een waarin alle aangeboden pakketten te zien zijn die nog niet gereserveerd zijn en één waarin de door de gebruiker gereserveerde pakketten te zien zijn, met informatie wanneer elk pakket opgehaald moet worden.

## US_02 ALS KANTINEMEDEWERKER WIL IK KUNNEN ZIEN WELKE PAKKETTEN ER AANGEBODEN WORDEN, ZODAT IK WEET WAT HET HUIDIGE AANBOD AL IS

Storypoints: 2

Toelichting:

Een kantinemedewerker heeft natuurlijk inzicht nodig in de pakketten die aangeboden worden. Om het aanbod eventueel zo breed mogelijk te maken, moet een kantinemedewerker ook het aanbod van andere kantines kunnen zien.

Acceptatiecriteria:

- Een kantinemedewerker kan het aanbod aan pakketten van zijn eigen kantine zien. De lijst moet gesorteerd worden oplopend op datum.
- Een kantinemedewerker moet ook het aanbod van pakketten kunnen zien van de andere kantines. Ook deze lijst moet oplopend op datum worden gesorteerd.
---
# US_03 ALS KANTINEMEDEWERKER WIL IK EEN PAKKET KUNNEN AANBIEDEN, ZODAT EEN STUDENT DEZE KAN RESERVEREN.

Storypoints: 3

## Toelichting:

Als kantinemedewerker kan ik op basis van ervaring en de evenementen die op een dag gehouden worden een pakket samen kunnen stellen. Ik mag dit voor maximaal 2 dagen vooruit plannen, om teleurstellingen te voorkomen doordat pakketten aangeboden worden die niet gevuld kunnen worden met producten.

## Acceptatiecriteria:

- Een kantinemedewerker moet een nieuw pakket, inclusief producten, toe kunnen voegen, kunnen wijzigen en verwijderen. De locatie van de medewerker moet hierbij als locatie voor het pakket worden gebruikt.
- Wijzigen of verwijderen van een pakket, inclusief gekoppelde producten, mag alleen als er nog geen reserveringen voor zijn.
- De kantinemedewerker moet een overzicht hebben van de pakketten die op zijn locatie aangeboden worden. De lijst moet oplopend op datum gesorteerd worden.

# US_04 ALS KANTINEMEDEWERKER WIL IK EEN PAKKET ALLEEN VOOR VOLWASSENEN BESCHIKBAAR STELLEN, ZODAT MINDERJARIGEN NIET KUNNEN RESERVEREN.

Storypoints: 1

## Toelichting:

Bij een aantal evenementen blijven soms ook alcoholhoudende producten over. Deze mogen natuurlijk niet aan minderjarigen verstrekt worden.

## Acceptatiecriteria:

- Een product heeft een eigenschap of het alcoholhoudend kan zijn.
- Een pakket heeft een 18+ indicator. Deze wordt automatisch gezet als er een product in het pakket zit dat alcoholhoudend is.
- Iemand van onder de 18 kan geen 18+ pakket reserveren. (Controle dient plaats te vinden ten opzichte van de ophaaldatum).
---
## US_05 ALS STUDENT WIL IK EEN PAKKET KUNNEN RESERVEREN, ZODAT IK GOEDKOOP PRODUCTEN KAN BEMACHTIGEN.

Storypoints: 3

Toelichting:
Als student is het natuurlijk handig om goedkoop producten te kunnen kopen. Het systeem werkt op basis van reservering, dus als een student interesse heeft in een pakket, dan kan hij of zij dat product reserveren.

Acceptatiecriteria:
- Als student moet ik een pakket kunnen reserveren.
- Een student mag maximaal 1 pakket per afhaaldag reserveren.

## US_06 ALS STUDENT WIL IK WETEN WAT VOOR PRODUCTEN ER ONGEVEER IN EEN PAKKET ZITTEN, ZODAT IK WEET OF HET PAKKET INTERESSANT VOOR MIJ IS.

Storypoints: 3

Toelichting:
Natuurlijk wil je als student wel weten wat je ongeveer kunt verwachten in je pakket. Daarom wordt een aantal voorbeeldproducten aan een pakket toegevoegd, zodat een student een indruk kan krijgen wat er in het verleden in een soortgelijk pakket zit.

Acceptatiecriteria:
- In de eigenschappen van een pakket zijn de producten zichtbaar
- In de eigenschappen van een product is duidelijk en aantrekkelijk weergegeven.

## US_07 ALS KANTINEMEDEWERKER WIL IK GEEN DUBBELE RESERVERVINGEN HEBBEN VOOR EEN PAKKET, ZODAT EEN PAKKET MAAR EEN KEER GERESERVEERD KAN WORDEN

Storypoints: 1

Toelichting:
Meerdere studenten kunnen natuurlijk interesse hebben in een pakket. Binnen ons systeem gaan we dit heel simpel oplossen door de reservering te gunnen aan de eerste student die op reserveren klikt.

Acceptatiecriteria:
- Het systeem moet controleren of er al een reservering voor een pakket is. Als deze er al is, dan moet het systeem een klantvriendelijke foutmelding geven aan de student.
---
ATIx

• Als er nog geen reservering is, dan wordt de student geregistreerd als de student die het pakket mag komen ophalen.

IVT2.1 ServerSide Web Development Individueel - Opdracht
Pagina 8 van 16
---
## US_08 ALS STUDENT WIL IK KUNNEN FILTEREN OP LOCATIE EN TYPE MAALTIJD, ZODAT IK SNEL EEN OVERZICHT KAN KRIJGEN WELKE GEWENSTE PAKKETTEN OP MIJN FAVORIETE LOCATIE AANGEBODEN WORDEN.

Storypoints: 2

Toelichting:

Als student wil je natuurlijk een zo specifiek mogelijk overzicht krijgen van de pakketten die op jouw gewenste locatie aangeboden worden. Bovendien heb je misschien als student ook wel een voorkeur in wat voor type maaltijd je geïnteresseerd bent.

Acceptatiecriteria:

- Een student moet het overzicht van de aangeboden pakketten kunnen filteren op locatie. De stad van de student moet hierbij als standaardwaarde worden gebruikt. De student moet dit echter wel makkelijk aan kunnen passen.
- Een student moet een filtering kunnen toepassen op de lijst van aangeboden pakketten op basis van het type maaltijd.

## US_09 ALS KANTINEMEDEWERKER MAG IK ALLEEN EEN WARME MAALTIJD PAKKET OPVOEREN ALS DAT OOK OP MIJN LOCATIE AANGEBODEN WORDT.

Storypoints: 1

Toelichting:

Niet alle locaties bieden warme maaltijden als diner aan. Om vergissingen te voorkomen mag een kantinemedewerker alleen warme maaltijd pakketten opvoeren als deze ook op de locatie van de medewerker aangeboden worden.

Acceptatiecriteria:

- Een pakket heeft een indicatie of het een warme maaltijd is.
- Bij een medewerker wordt bijgehouden op welke locatie hij of zij werkzaam is en of op deze locatie warme avondmaaltijden aangeboden worden.
- Een medewerker mag alleen een warme avondmaaltijd opvoeren als dit ook op zijn locatie aangeboden wordt
---
# US_10 ALS KANTINEMEDEWERKER WIL IK WETEN OF STUDENTEN RESERVERINGEN NIET OP HEBBEN GEHAALD, ZODAT IK EVENTUEEL NIEUWE RESERVERINGEN KAN BLOKKEREN

Storypoints: 2

## Toelichting:

Helaas komen studenten reserveringen ook wel eens niet ophalen (no-shows). Dat is natuurlijk jammer, want dan moet het pakket alsnog weggegooid worden. Om dit te voorkomen kan een kantinemedewerker in het overzicht van reserveringen aangeven dat een pakket niet opgehaald is. Dit wordt ook bijgehouden bij een student. Als een student meer dan 2 keer een reservering niet opgehaald heeft, dan kan deze student geen pakketten meer reserveren.

## Acceptatiecriteria:

- Een baliemedewerker moet bij een reservering aan kunnen geven dat deze niet opgehaald is. Hierbij wordt ook een teller bij de student verhoogd.
- Als een student meer dan 2 keer zijn of haar reservering niet opgehaald heeft, dan mag deze student geen nieuwe reserveringen meer maken.
---
# OPDRACHT

De functionele requirements en business rules die van toepassing zijn, heb je kunnen lezen in de vorige paragraaf. Wat de niet-functionele eisen betreft, leggen we de focus op schaalbaarheid, onderhoudbaarheid en testbaarheid (zie ook Softwareontwerp & -architectuur). Een grove, conceptuele opzet voor de applicaties vind je in Figuur 2.

![Figuur 2 Conceptuele opzet]

De Avans Maaltijdreserverings webapplicatie is een ASP.NET MVC Core applicatie die voor gegevens over de maaltijdpakketten een SQL Server database gebruikt (In Azure heet deze Azure SQL Database). De inloggegevens worden in verband met veiligheid verplicht in een aparte database opgeslagen. Het team van AvansOne zal een mobiele applicatie schrijven voor dit onderdeel, waarbij studenten alleen de lijst pakketten, inclusief producten kunnen zien en een reservering kunnen plaatsen voor een pakket. Ons systeem biedt hiervoor een RESTful Web API (op RMM level 2) (aanmelden voor een pakket) en een GraphQL endpoint (lijst met pakketten en producten) aan. Deze webservice gaan we testen met Postman. (Tip: maak voor jezelf voor deze onderdelen ook 2 losse user story's aan).

Voor user accountmanagement en bijbehorende authenticatie en autorisatie gebruik je het Identity framework.
---
# Ontwerp

De beschrijving van het maaltijdreserveringssysteem is vrij generiek. Je geeft zelf de opdracht meer kleur door een thema te kiezen, door je bijvoorbeeld te richten op specifieke studentgroepen. We hebben naast de voltijdstudenten namelijk ook nog een grote groep deeltijdstudenten die met name in de avondies volgen. Je houdt daarbij expliciet rekening met betrekking tot het UX-design. Je stuurt hiermee ook welke persona je van toepassing vindt en welke maatregelen je treft om een gebruiksvriendelijke userinterface te maken. De uitwerking van het UX-design neem je op in het portfolio dat voor dat vak is voorgeschreven.

Je maakt ook een aantal (UML-)diagrammen:
- Package- en klassendiagram voor toepassing van clean (onion) architectuur.
- Componentdiagram voor het gehele systeem.
- Deploymentdiagram voor het gehele systeem.
- In de toekomst willen we de webapplicatie gebruik laten maken van de webservice, zodat de webapplicatie niet meer direct toegang tot de database nodig heeft. Maak hiervoor een aangepast ontwerp waarbij je deze nieuwe situatie modelleert. Maak hierbij zelf een keuze welke diagramtypes hierbij het beste aansluiten.

De diagrammen heb je zelf met de hand gemaakt en zijn dus niet gegenereerd vanuit de code door bijvoorbeeld Visual Studio.

Het ontwerp en overige documentatie neem je op in een verslag. Zorg ervoor dat dit professioneel vormgegeven is. Neem b.v. een inleiding, samenvatting en beschrijvende tekst op, NIET alleen de diagrammen.

De Avans Maaltijdreserverings webservice biedt zijn functionaliteit aan via een correcte RESTful Web API die voldoet aan Richardson Maturity Model level (RMM) 2 en een los GraphQL-endpoint. De RMM2 variant voldoet aan de volgende criteria voor RESTful architectuur constraints (zie ook studiemateriaal SO&A 2):

- Client/server
- Resources
- Standard operations
- Stateless communication
- Resources with multiple representations

Het ontwerp voor de endpoints bestaat uit een schema met het gedrag voor de CRUD-operaties op de resources in termen van HTTPS verbs aangevuld met query's voor GraphQL. Als een methode volgens de casus niet geïmplementeerd kan worden, dan moet een vooraf gedefinieerde foutmelding terug worden gegeven. Het gedrag wordt ondersteund voor zowel de verzameling resources als individuele resources. Je past de richtlijnen volgens Brian Mulloy van Apigee (Mulloy, 2012) toe op de Web API's, daar waar het basisschema niet voldoende is. Je documenteert je Web API's, dus de RMM level 2 en GraphQL, beide met behulp van Swagger.

IVT2.1 ServerSide Web Development Individueel - Opdracht
Pagina 12 van 16
---
# ATIx

## Code
Je programmeert je ontwerp in ASP.NET MVC Core 8 en C#. De code is netjes: volgens coding guidelines¹, geen uitgecommentarieerde codeblokken, netjes uitgelijnd, geen warnings tijdens build, etc. Gebruik eventueel de editorconfig-feature op je hierbij te helpen.

Ook mogen er geen ongebruikte codebestanden of projecten meer in de solution aanwezig zijn. De naamgeving van de solution, de projecten en de bestanden moet relevant zijn (m.a.w. geen 'Project1', 'Class1.cs', etc). Hetzelfde geldt voor de naamgeving van code constructies (variabelen, classes, enums, etc).

Is de oplevering te rommelig (voldoet niet aan bovenstaande) resulteert dit in een NV!

Je past de volgende concepten toe:

1. Dependency injection d.m.v. een dependency injection container.
2. Persistentie in de database d.m.v. entity framework code first en migrations.
3. Relaties tussen modellen d.m.v. navigational properties.
4. Het gebruik maken van repositories op basis van interfaces zodat we eenvoudig de manier van dataopslag kunnen wijzigen.
5. Het kunnen maken van validatieregels op de velden van de models.
6. Het gebruik van strongly typed views.
7. Het gebruik van Microsoft Identity voor authenticatie en autorisatie voor zowel de webapplicatie als de webservice
8. Toepassen van Lambda expressies om selecties te maken op datasets.

## Testen
Voor de business rules van het domein implementeer je unit testen. Je test dus geen standaard get-ers en set-ers van klassen waarbij 'gewoon' waardes direct worden teruggegeven of opgeslagen.
Je past ook mocking toe (b.v. voor de repositories).
De business rules staan vermeld in de acceptatiecriteria bij de user story's. De tests omvattten de happy flow en een aantal foute scenario's.

Tip: werk de unit testen per user story uit. Zo voorkom je dat je aan het eind van de opdracht tijd tekort komt om nog alle unit testen te schrijven.

Maak gebruik van versiebeheer (git) om het ontwikkelen makkelijker te maken (eventueel met feature branches)

De endpoints van de Avans Spelavonden webservice worden getest met end-to-end tests met behulp van een aantal collecties in Postman.

---

¹ https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions

IVT2.1 ServerSide Web Development Individueel - Opdracht
Pagina 13 van 16
---
ATIx

# Overig

Je werkt met CI/CD (continous integration/ continuous deployment) waarbij je gebruik maakt van een development pipeline (ontwikkelstraat) die automatisch een build start wanneer je wijzigingen levert ('pusht'), daarna ook automatisch de unit testen uitvoert en vervolgens de webapps deployed, inclusief de twee databases.

Wijzigingen in entiteiten (modellen) moeten dus ook in de CD pipeline via migraties doorgevoerd worden op de Azure database.

De gerealiseerde userinterface is consistent met het UX-design waarbij je de design principes uit UX-design 1 toepast. Ook als je UX Design 1 niet hoeft te doen, dan zorg je nog voor een gebruikersvriendelijke user interface.

Als je aan het vak UX-design 1 deelneemt, kijk dan in het materiaal van dat vak op BrightSpace voor meer informatie.

IVT2.1 ServerSide Web Development Individueel - Opdracht
Pagina 14 van 16
---
# OPLEVERING

Voor alle studenten gelden de volgende bepalingen. Herkansers van vorige jaren moeten ook de complete opdracht uitwerken.

## Wat lever je in?

Lever de opdracht in via de Blackboard inleverlink; daar staat ook de deadline voor inleveren vermeld.

De ingeleverde opdracht dient te bevatten:

- Opleveringsdocument met (UML-)diagrammen en verdere onderbouwing. Dit moet een net, professioneel vormgegeven document zijn.
- Gehele Visual Studio solution met alle projecten, zonder obj-files, binaries en packages folders. Gebruik de functie 'Clean Project' uit het menu en verwijder eventueel de packages folder!
(Is je solution zip tientallen of honderden MB's groot kan dat uitsluiting van het assessment opleveren)
  - Er is gebruik gemaakt van ASP.NET Core 8
  - De DB connectiestring met credentials naar Azure staat NIET in appsettings.json
    - Zie https://brightspace.avans.nl/d2l/le/lessons/209514/topics/1397554
  - Nullable reference types zijn actief
    - (dit is de default dus hoef je niets voor te doen)
  - Er is een consistentie coding conventie gebruikt
  - Er zijn geen warnings of errors
    - Alleen NuGet vulnerability warnings mogen onderdrukt worden maar mogen niet zichtbaar zijn tijdens de build
  - Er zijn GEEN lege bestanden, klasses uit de VS template of ongebruikte codebestanden aanwezig
    - (b.v. class1.cs)
  - Er zijn GEEN blokken code 'commented out' of niet in gebruik
    - Correct versiebeheer (git met stash en branches) maakt het onnodig om blokken code tijdelijk te uit te 'commenten'
  - De solution ingericht volgens Onion Architecture met aparte projecten voor het domein, infra, API, webapp, etc
  - Er worden GEEN EF migraties doorgevoerd in de programma code (seeden mag wel natuurlijk)
  - Het domein model bevat entiteiten opgebouwd uit logische datatypes, hebben relaties met elkaar en er is minimaal een veel-op-veel relatie aanwezig
---
# ATIx

- URL van de gedeployde applicatie op Azure zodat de applicatie bezocht kan worden.
- URL van de devops omgeving (En de docent moet hier toegang toe hebben).
- Een account (gebruikersnaam én wachtwoord) waarmee de docent kan inloggen op jouw webapplicatie in Azure. Dit account moet voldoende rechten hebben om alle activiteiten uit te kunnen voeren.
- Binnen de gedeployde applicatie moeten een aantal gebruikers aanwezig (kantinemedewerker en een aantal studenten).
- Swagger API documentatie
- Postman collectie welke alle endpoints test. De collectie moet direct uit te voeren zijn zonder knippen en plakken van tokens; maak dus gebruik van de functionaliteit van Postman om dit mogelijk te maken.
- Video met een schermopname om aan te tonen dat alle functionaliteit van UC 1 t/m UC 7 en een eigen te kiezen user story in de applicatie (webapp + API) is opgenomen. Laat per user story zien dat je voldoet aan de acceptatiecriteria die per user story staan vermeld. De demonstratie moet de gedeployde webapp gebruiken, NIET de development versie op 'localhost'!

Bovenstaande producten ingepakt in 1 zipfile met de volgende naam:

- <klas> - <voornaam + achternaam> - IVT2-1-MaaltijdenApp.zip
Ontbreekt één van bovenstaande punten kun je NIET op assessment en zul je een herkansing moeten doen. Loop dus voor je het inlevert bovenstaande punten na!

## BIBLIOGRAFIE

Mulloy, B. (2012). Web API Design. unknown: Apigee. Opgehaald van https://pages.apigee.com/rs/apigee/images/api-design-ebook-2012-03.pdf

Smith, S. (2017). Architecting Modern Web Applications with ASP.NET Core and Azure. Redmond, Washington: Microsoft Corporation.

IVT2.1 ServerSide Web Development Individueel - Opdracht
Pagina 16 van 16