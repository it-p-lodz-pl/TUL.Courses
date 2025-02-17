# Projekt Etap 2 - szczegółowy opis <!-- omit in toc -->

## Spis treści <!-- omit in toc -->

- [Opis na stronie kursu](#opis-na-stronie-kursu)
- [Cel](#cel)
- [Opis zadania](#opis-zadania)
- [Wytyczne do realizacji](#wytyczne-do-realizacji)
  - [Wymagania zadania](#wymagania-zadania)
  - [Procedura sprawdzenia zawartości repozytorium](#procedura-sprawdzenia-zawartości-repozytorium)
  - [Zgłoszenie do oceny](#zgłoszenie-do-oceny)
- [Zaliczenie](#zaliczenie)
  - [Warunki ogólne](#warunki-ogólne)
  - [Typowe błędy](#typowe-błędy)
- [Lista źródeł](#lista-źródeł)
  - [Architektura warstwowa](#architektura-warstwowa)
  - [Zobacz też](#zobacz-też)

## Opis na stronie kursu

- programowanie współbieżne, sekcja krytyczna

## Cel

To wieloetapowe zadanie polega na opracowaniu programu komputerowego o architekturze wielowarstwowej i funkcjonalności pozwalającej na obserwowaniu zachowania się kul na prostokątnej płaszczyźnie ograniczonej ścianami bocznymi (kolokwialnie "stół bilardowy"). Ten etap służy również do zaimplementowania tych wymagań, które w poprzednich etapach zostały przyjęte warunkowo.

Celem tego etapu jest zrozumienie i praktyczne zastosowanie:

- architektury warstwowej programu i niezależnego tworzenia i testowania warstw
- dwukierunkowej komunikacji warstw
- programowania wspołbieznego
- implementacji koncepcji sekcji krytycznej
- testowania jednostkowego i integracyjnego
- techniki wstrzykiwania zależności (ang. Dependency Injection)

## Opis zadania

W tym etapie należy zmodyfikować utworzony w etapie 1 program tak, aby uwzględnić, że:

- kule poruszając się po trajektoriach zgodnych z fizyką zjawiska przy założeniu braku tarcia
- kule odbijają sie od siebie i od ścian (odbicie sprężyste bez straty energii) [Elastic collisions; Wikipedia][EC]
- kierunek i prędkość poruszania się kul po odbiciu będą uwzględniały ich masę, poprzedni kierunek i wartość prędkości z jaką się poruszały przed odbiciem
- zachowania interaktywne proszę zaimplementować jako asynchroniczne

Opracować program z wykorzystaniem technologii .NET, który będzie implementował warstwy: `Dane`, `Logika` i `Prezentacja`. Bardziej szczegółowo warstwy te opisano w rozdziale **Architektura** opisu do `Projekt Etap 1`.

Wymienione wyżej warstwy `Dane` i `Logika` muszą być testowane niezależnie z wykorzystaniem testów jednostkowych. Aby to było możliwe API warstwy `Dane` i `Logika` muszą być zrealizowane jako wyraźnie wydzielone definicje abstrakcyjne.

> **UWAGA**: program dalej będzie modyfikowany w celu uzyskania końcowej funkcjonalności, która opisana jest w kolejnych etapach.

## Wytyczne do realizacji

Dodatkowe informacje ułatwiające wykonanie zadania:

### Wymagania zadania

- warstwa `Logika` powinna reprezentować wszystkie operacje realizowane w procesie implementacji zderzeń i informować warstwę `Model` o aktualnym położeniu kul
- warstwa `Dane` odpowiada za cechy kul (waga i średnica) i ruch kul
- nie ma wymagania, aby cechy kul były różne, a jesli są to musi to być wizualizowane na ekranie
- proszę pamiętać, że `Dane` + `Logika` mogą zawierać sekcje krytyczne, a w konsekwencji rozwiązanie musi być odporne na zdarzenia współbieżne
- do wykrywania zderzeń proszę rozważyć możliwość wykorzystania drzewa binarnego
- pomocne będzie odprzęgnięcie warstw na potrzeby testowania używając abstrakcyjnego API oraz DI
- do realizacji podstawowych funkcji programu nie trzeba stosować wstrzykiwania zależności (DI)

### Procedura sprawdzenia zawartości repozytorium

Z uwagi na konieczność pracy z wykorzystaniem lokalnej kopii, może się zdarzyć że proponowane rozwiązanie umieszczone w repozytorium nie jest kompletne i zgodne z celem jakiemu ma służyć. Dlatego warto dodatkowo to sprawdzić korzystając z następującej procedury.

1. **GitHub**: sklonować repozytorium do pustego katalogu na dysku tak, aby utworzyć lokalną kopię
1. **Lokalna kopia**: sprawdzić, czy przykład jest kompletny i da się kompilować
1. **Lokalna kopia**: sprawdzić, czy wszystkie testy dają pozytywny wynik
1. **Lokalna kopia**: sprawdzić, czy w lokalnej kopii są jakieś modyfikacje (wszystkie wygenerowane pliki muszą byc ignorowane)

### Zgłoszenie do oceny

- `GitHub`: utworzyć release, w którym tag zostanie nadany zgodnie z [Semantic Versioning 2.0.0][SV]
- `WIKAMP`: skopiować do tekstu `Komentarz zwrotny` web URL (zielony klawisz) i tag
- `WIKAMP`: zgłosić zadanie do oceny

> nie zaleca się aby do sprawdzenia poprawności stosować inne rozwiązania nawet jeśli są zgodne z aktualnymi trendami.
>
> UWAGA: po zdefiniowaniu `tag` mozna i trzeba kontynuować prace nad kolejnym etapem.

## Zaliczenie

### Warunki ogólne

W celu potwierdzenia osiągnięcia celu i zrealizowania zakresu zadania, w trakcie omawiania treści programu należy wykazać, że zostały zrealizowane punkty z listy kontrolnej zamieszczonej w osobnym pliku. Przed oddaniem pracy do oceny, należy ten plik dodać jako issue i upewnić się samemu, że wszystkie punkty listy kontrolnej zostały zrealizowane. Po upewnieniu się (wszystkie punkty muszą być zaznaczone jako wykonane) **zamknąć issue**. Utworzyć kolejne z tą samą listą kontrolna dla Prowadzącego na potrzeby zaliczenia.

### Typowe błędy

- prace nie są rozłożone równomiernie
- repozytorium jest niekompletne i po utworzeniu lokalnej kopii na komputerze Prowadzącego nie można kompilować programu lub testy nie dają pozytywnego wyniku
- zamiast testów jednostkowych są zastosowane testy integracyjne (np. testowanie kilku warstw w jednym teście)
- nie wszyscy członkowie grupy roboczej zgłosili zadanie do oceny
- zadanie jest w trybie roboczym - nie zostało skutecznie zgłoszone przez wszystkich członków grupy roboczej
- proponowane rozwiązanie nie jest zgodne z listą kontrolną lub szczegółowym opisem, przykładowo
  - wartosci współrzędnych nie są skalowane do aktualnego rozmiaru ekranu komputera
  - kule wychodzą poza obręb ograniczenia płaszczyzny

## Lista źródeł

Do zrealizowania zadania można wykorzystać przykładowy kod znajdujący się w publicznym repozytorium [Programming in Practice - set of examples targeting education purposes][TP].

Literatura uzupełniająca jest podana na stronie kursu.

### Architektura warstwowa

W celu ułatwienia poprawnej realizacji wymagania utworzenia programu o architekturze warstwowej można wziąć udział w następującym kursie:

- [Programming in Practice - Information Computation; Udemy, 2023](https://www.udemy.com/course/information-computation/?referralCode=9003E3EF42419C6E6B21)

Darmowy dostęp do kursu wymaga odpowiedniego kuponu. Można go uzyskać zwracając się bezpośrednio do Prowadzącego. Natomiast, na początek wystarczy przykład programu umieszczony w repozytorium [GitHub mpostol/TP][TP] (zawierającego przykłady edukacyjne) zgodnie z poniższym rysunkiem. Należy podkreślić, że warunkiem jest pełne zrozumienie tej architektury.

![ReferenceApplicationArchitecture][LA]

### Zobacz też

- [Programming in Practice - Information Computation; Udemy, 2023](https://www.udemy.com/course/information-computation/?referralCode=9003E3EF42419C6E6B21)
- [Język C# w praktyce. Kurs video. Przetwarzanie danych zewnętrznych](https://videopoint.pl/kurs/jezyk-c-w-praktyce-kurs-video-przetwarzanie-danych-zewnetrznych-mariusz-postol,vjcprv.htm#format/w)
- [Elastic collisions; Wikipedia][EC]
- [Semantic Versioning 2.0.0][SV]
- [Architektura warstwowa (przykład w TP Concurrent Programming)][AW]
- [repozytorium GitHub mpostol/TP][TP]

[SV]: https://semver.org/
[LA]: https://ftims.edu.p.lodz.pl/pluginfile.php/278449/mod_resource/content/1/ReferenceApplication.png
[AW]: https://github.com/mpostol/TP/tree/master/ConcurrentProgramming/ReactiveInteractiveUserInterface
[TP]: https://github.com/mpostol/TP
[EC]: https://en.wikipedia.org/wiki/Elastic_collision
