# Projekt Etap 1 -  szczegółowy opis <!-- omit in toc -->

## Spis treści <!-- omit in toc -->

- [Opis na stronie kursu](#opis-na-stronie-kursu)
- [Cel](#cel)
- [Opis zadania](#opis-zadania)
  - [Wymagania ogólne](#wymagania-ogólne)
  - [Architektura](#architektura)
    - [Warstwa `Dane`](#warstwa-dane)
    - [Warstwa `Logika`](#warstwa-logika)
    - [Warstwa `Prezentacja` - graficzny interfejs użytkownika (GUI)](#warstwa-prezentacja---graficzny-interfejs-użytkownika-gui)
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

- architektura warstwowa, współdziałanie interaktywne/reaktywne

## Cel

To wieloetapowe zadanie polega na opracowaniu programu komputerowego o architekturze wielowarstwowej i funkcjonalności pozwalającej na obserwowaniu zachowania się kul na prostokątnej płaszczyźnie ograniczonej ścianami bocznymi. Ten etap służy również do zaimplementowania tych wymagań, które w poprzednich etapach zostały przyjęte warunkowo.

Celem tego etapu jest zrozumienie i praktyczne zastosowanie:

- wybranego środowiska projektowego, tzn. GitHub, VisualStudio, język C#
- reaktywnego i interaktywnego współdziałania użytkownik/komputer
- architektury warstwowej programu i niezależnego tworzenia i testowania warstw
- wzorca `MVVM` (architektury warstwowej)
- dedykowanych języków (ang. Domain Specific Language), na przykładzie języka `XAML` do utworzenia graficznego interfejsu użytkownika (GUI) z elementami interaktywnymi i reaktywnymi
- programowania interaktywnego i reaktywnego
- testowania jednostkowego i integracyjnego
- techniki wstrzykiwania zależności (ang. Dependency Injection)

## Opis zadania

### Wymagania ogólne

To wieloetapowe zadanie polega na opracowaniu programu komputerowego o architekturze wielowarstwowej i funkcjonalności pozwalającej na obserwowaniu zachowania się kul na  prostokątnej płaszczyźnie ograniczonej ścianami bocznymi (kolokwialnie "stół bilardowy"). W tym etapie kule poruszają się po ograniczonej płaszczyźnie, ale nie oddziaływają między sambą i ze ściankami ograniczającymi. Kule poruszają się według trajektorii określonej przez generator pseudolosowy, tzn. jedynym warunkiem na określenie ich następnego położenia jest to, aby nadal znajdowały się wewnątrz ograniczonej płaszczyzny. Na ekranie kula jest wizualizowana jako okrąg. Należy umożliwić wprowadzenie przez użytkownika początkowej liczby kul poprzez umieszczenie odpowiednich kontrolek na ekranie (GUI). Początkowe położenie kul na płaszczyźnie jest losowe, ale wewnatrz ograniczonej płaszczyzny.

Opracować program z wykorzystaniem technologii .NET, który będzie implementował warstwy: `Dane`, `Logika` i `Prezentacja`, więc w architekturze programu należy **wyraźnie** wydzielić następujące warstwy:

- `Dane` - zarządzanie danymi
- `Logika` - usługi realizujące funkcjonalność dedykowaną dla wybranego procesu biznesowego
- `Prezentacja` - graficzny interfejs użytkownika

Bardziej szczegółowo warstwy te opisano w rozdziale **Architektura** opisu do tego etapu.

Wymienione wyżej warstwy `Dane` i `Logika` muszą być testowane niezależnie z wykorzystaniem testów jednostkowych. Aby to było możliwe API warstwy `Dane` i `Logika` muszą być zrealizowane jako wyraźnie wydzielone definicje abstrakcyjne.

> **UWAGA**: program dalej będzie modyfikowany w celu uzyskania końcowej funkcjonalności, która opisana jest w kolejnych etapach.

### Architektura

#### Warstwa `Dane`

W tym etapie nie ma ograniczeń co do funkcjonalności tej warstwy, a w szczególności interakcji z zewnętrznymi repozytoriami danych.

#### Warstwa `Logika`

- Implementując usługi w tej warstwie, należy dostarczyć funkcjonalność umożliwiającą przetwarzanie danych na potrzeby wybranego procesu biznesowego.
- API warstwy `Logika` powinno zawierać operacje interaktywne (np. twórz kule) i reaktywne (okresowe wysłanie położenia kul).

#### Warstwa `Prezentacja` - graficzny interfejs użytkownika (GUI)

- Ta warstwa jest odpowiedzialna za inicjację programu (bootstrap) i jego zakończenie
- Utworzyć okno główne aplikacji zawierające  potrzebne kontrolki do monitorowania i sterowania procesem (współdziałanie interaktywne)
- utworzyć w tym oknie ograniczoną ścinami przestrzeń, w której poruszają się kule (współdziałanie reaktywne)
- zaprojektować interfejs graficzny wykorzystując język XAML
- Wykorzystać API warstwy **Logika** do wizualizacji i sterowania (np. zakończenie)

Warstwa ta musi być zaimplementowana zgodnie ze wzorcem `Model-View-ViewModel` (`MVVM`). Oznacza to, że należy w niej wydzielić następujące warstwy wewnętrzne:

- `View`: zawiera zestaw kontrolek bezpośrednio zapewniający interakcję pomiędzy użytkownikiem i programem. Warstwę zaprojektować z wykorzystaniem języka XAML (`*.xaml`).
- `ViewModel`: implementuje zachowanie się interfejsu użytkownika tak, aby wyświetlać aktualne dane i realizować polecenia użytkownika w zależności od stanu GUI. Warstwa odpowiedzialna za powiązanie kontrolek z API oferowanym przez warstwę `Model`
- `Model`: odpowiedzialna za przechowywanie danych wyłącznie na potrzeby interfejsu użytkownika (GUI) i realizację operacji na danych z wykorzystaniem funkcjonalności oferowanej przez warstwę opisaną w **Warstwa `Logika`**,

Dane i kontrolki muszą być powiązane ze sobą za pomocą mechanizmu wiązania danych `DataBinding`. Oznacza to również, że nie można tworzyć kodu w warstwie widoku (tzw. code-behind) w plikach `*.xaml.cs`, poza kodem automatycznie generowanym przez środowisko projektowe. 

Do powiadamiania warstwy `View` o zmianach zachodzących w warstwie poniżej (programowanie reaktywne), należy wykorzystać implementację interfejsów `INotifyPropertyChanged` oraz `INotifyCollectionChanged` lub ich pochodnych.

Do obsługi poleceń użytkownika należy wykorzystać mechanizm poleceń (implementacja interfejsu `ICommand`). Dotyczy to w szczególności obsługi przycisków, ale także menu i innych interaktywnych elementów interfejsu. Polecenia muszą zostać zaimplementowane (obsłużone) w warstwie `ViewModel`.

## Wytyczne do realizacji

Dodatkowe informacje ułatwiające wykonanie zadania:

### Wymagania zadania

- przy ograniczenie ruchu kul do wnętrza przestrzeni mozna zrealizowac poprzez ograniczenie wartości współrzędnych
- przy ograniczeniu ruchu kul trzeba uwzględnić ich średnicę
- w przypadku wykorzystania wektora, proszę pamiętać, że wektor ma długość i kierunek, więc powinien byc reprezentowany przez typ złożony
- przy okazji warto się zastanowić jak jest różnica pomiędzy typami złożonymi i strukturalnymi i to nie tylko w kontekście tego języka programowania
- zwracam uwagę, że w zadaniu nie ma potrzeby uzgodnienia różnych gęstości materii uzytej do budowy kul
- jeśli uwzględniacie różną gęstość kul, to musi to być zobrazowane w wyglądzie kul
- w następnych etapach jest wymagane, aby ruch kul był płynny, więc trzeba ograniczyć prędkość poruszania się lub częstość odswiezania - tu warto zastanowić się czemu i jaka jest inzynierska miara płynności
- tu warto pokreślić, że nie ma wymagania stosowania grafiki 3D; inaczej nie warto utrudniać sobie pracy stawianiem dodatkowych wymagań, ale nie jest to zabronione
- przypominam wymaganie: "API warstwy `Dane` i `Logika` muszą być zrealizowane jako wyraźnie wydzielone definicje abstrakcyjne" - tu warto się zastanowić, co jest powodem takiego wymagania
- ten etap nie wymaga programowania współbieżnego, ale warto się zastanowić jakie programowanie jest wymagane i co trzeba będzie w przyszłości zmienić, aby programowanie wspołbiezne było wykorzystane i po co ten rodzaj programowania
- choć nie ma wymagań dotyczących odpowiedzialności warstwy `Dane` w tym etapie, lokując tu dane i funkcjonalność związana z ruchem kul ułatwimy wykonanie następnych etapów.
- należy podkreślić, że warstwa `Model` jest odpowiedzialna za skalowanie wartości otrzymywanych z warstwy poniżej.
- należy podkreślić, że nie należy stosować zewnetrznych metod kontroli jakości programu, a w szczególności `Mock` (external package)-tu warto zadać sobie pytanie: jaki jest powód tego zalecenia (a wręcz wymagania)

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
  - wartosci otrzymywane przez warstwę `Model` nie są skalowane do aktualnego rozmiaru ekranu komputera
  - kule wychodzą poza obręb ograniczenia płaszczyzny
  - kule nie poruszają się płynnie po akranie

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
