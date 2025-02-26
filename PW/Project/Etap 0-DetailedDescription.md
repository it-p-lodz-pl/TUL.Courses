# Projekt Etap 0 - szczegółowy opis <!-- omit in toc -->

## Spis treści <!-- omit in toc -->

- [Opis na stronie kursu](#opis-na-stronie-kursu)
- [Cel](#cel)
- [Opis zadania](#opis-zadania)
- [Wytyczne do realizacji](#wytyczne-do-realizacji)
  - [Dane identyfikacyjne](#dane-identyfikacyjne)
  - [Program o architekturze warstwowej](#program-o-architekturze-warstwowej)
  - [Procedura sprawdzenia zawartości repozytorium](#procedura-sprawdzenia-zawartości-repozytorium)
- [Zaliczenie](#zaliczenie)
  - [Warunki ogólne](#warunki-ogólne)
  - [Typowe błędy](#typowe-błędy)
- [Lista źródeł](#lista-źródeł)
  - [Tworzenie repozytorium](#tworzenie-repozytorium)
  - [Architektura warstwowa](#architektura-warstwowa)

## Opis na stronie kursu

repozytorium GitHub i przykładowy program warstwowy

## Cel

Cele tego etapu są następujące:

- utworzenie repozytorium dla grupy roboczej
- identyfikacja repozytorium - powiązanie personalnej identyfikacji WIKAMP z identyfikacją na GitHub
- poznanie procedury zaliczania
- poznanie podstaw języka programowania C# (praca w parach)
- poznanie postaw zintegrowanego środowiska projektowego MS VS
- przypomnienie podstaw korzystania z testów jednostkowych i ich wpływu na program  komputerowy (Test Driven Development)
- sprawdzenie kompatybilności i kompletnosci własnego środowiska projektowego ze środowiskiem Prowadzącego

## Opis zadania

Zgodnie z celem teg etapu należy utworzyć repozytorium GitHub na potrzeby realizacji projektu. Tworzenie repozytorium powinno być zrealizowane z wykorzystaniem listy kontrolnej dostepnej w odrębnym dokumencie.

Utworzone repozytorium musi zawierać:

1. dokument identyfikacyjny (`README.md`) o treści zgodnie z szablonem znajdującym się w osobnym dokumencie
2. początkową wersję programu o architekturze warstwowej

Dokument identyfikacyjny musi zawierać nazwę uzytkownika używaną na GitHub i wygenerowany unikalny identyfikator skojarzony z kontem na WIKAMP.

To cztero-etapowe zadanie polega na opracowaniu programu komputerowego o architekturze wielowarstwowej i funkcjonalności pozwalającej na obserwowaniu zachowania się kul na  prostokątnej płaszczyźnie ograniczonej ścianami bocznymi.

Etap musi być oddany do oceny za pośrednictwem odpowiedniego modułu WIKAMP. Przed oddanie do oceny nalezy utworzyć kolejne `issue` z pustą lista dla Prowadzącego do wykorzystania w trakcie oceny. Repozytorium powinno zawierać program, który nastepnie będzie modyfikowany w następnych etapach w celu osiagniecia celów dydaktycznych przedmiotu. Program musi mieć architekturę warstwową zgodnie z lista kontrolną.

Podsumowując, procedura jest następująca:

1. `GitHub`: utworzyć repozytorium dla grupy roboczej
1. `GitHub`: utworzyc plik identyfikacyjny `README.md` o treści zgodnej z szablonem dostepnym w osobnym dokumencie ([Etap 0 README Template.md][E0T])
1. `GitHub`: uzupełnić plik wpisując swoje dane identyfikacyjne, a w tym wygenerowany unikalny identyfikatory
1. `GitHub`: w repozytorium należy umieścić przykładowy program zgodnie z wymaganiami, który da się skompilować
1. `GitHub`: w programie należy umieścić testy jednostkowe, które dadzą się wykonać z wynikiem pozytywnym
1. `WIKAMP`: skopiować URL (zielony klawisz) dla repozytorium i swój identyfikator do `Tekst online` w odpowiednim module oceny
1. `WIKAMP`: zgłosić zadanie do oceny

## Wytyczne do realizacji

### Dane identyfikacyjne

Dodatkowe informacje ułatwiające dodanie do repozytorium danych identyfikacyjnych.

1. `GitHub`: skopiować zawartość pliku [Etap 0 README Template.md][E0T] do pliku `README.md` repozytorium
1. Przy tworzeniu repozytorium można skorzystać z załaczonego filmiku ilustrującego jak to zrobić (_uwaga filmik nie jest nowy więc aktualne widoki mogą się różnić od zarejestrowanych_).
1. Do generowania unikalnego identyfikatora mozna użyć MS VS (GUID) lub dostepnych darmowych narzędzi w sieci Internet (patrz lista źródeł poniżej).
1. Dane identyfikacyjne są używane przez Prowadzącego do wystawienia oceny, więc muszą być bardzo rzetelne (w przypadku wątpliwości proszę pytać Prowadzącego)

### Program o architekturze warstwowej

1. Realizację polecenia umieszczenia w repozytorium programu o architekturze warstwowej można zrealizowac poprzez skopiowanie przykładu z repozytorium TP (patrz lista źródeł)

![ReferenceApplicationArchitecture][LA]

2. Proszę zwrócić uwagę, że widok z wykorzystaniem folderów przykładu umieszczonego w repozytorium TP jest inny w porównaniu do widoku przedstawianego na powyższym rysunku
3. Szczegółowy opis z przykładami architektury warstwowej zamieszono w niezaleznym kursie - [Programming in Practice - Information Computation; Udemy, 2023](https://www.udemy.com/course/information-computation/?referralCode=9003E3EF42419C6E6B21)
4. W celu poprawy przenośności rozwiązania, zaleca się aby warstwy `Model`, `ViewModel`, `Dane` i `Logika` były zrealizowana w technologii `.NET Standard` (lub ekwiwalentnej).
5. Warstwę `View` powinna być zrealizowana w technologii `WPF`.
6. Warstwa `Logika` powinna reprezentować wszystkie operacje realizowane w wybranym procesie.
7. Aby podnieść jakoś proponowanego rozwiązania, zaleca się, aby dodać testy jednostkowe dla ważniejszych operacji warstwy `Dane`, `Logika`.
8. Warstwy powinny być luźno powiązane na potrzeby testowania używając wzorca programowania Dependency Injection (DI).
9. Przy realizacji warstwy **Danych** nie nalezy korzystać z zewnętrznych repozytoriów danych, jak pliki, bazy danych, itp. Jednak w każdym przypadku trzeba zapewnić, że pozytywny wynik realizacji testów jednostkowych nie będzie stawiał dodatkowych wymagań dla środowiska wykonawczego.
10. architekturę warstwową (luźno powiązane warstwy) programu najprościej uzyskać implementując warstwy jako osobne projekty.

### Procedura sprawdzenia zawartości repozytorium

Z uwagi na konieczność pracy z wykorzystaniem lokalnej kopii, może się zdarzyć że proponowane rozwiązanie umieszczone w repozytorium nie jest kompletne i zgodne z celem jakiemu ma służyć. Dlatego warto dodatkowo to sprawdzić korzystając z następującej procedury.

1. **GitHub**: sklonować repozytorium do pustego katalogu na dysku tak, aby utworzyć lokalną kopię
1. **Lokalna kopia**: sprawdzić, czy przykład jest kompletny i da się kompilować
1. **Lokalna kopia**: sprawdzić, czy wszystkie testy dają pozytywny wynik
1. **Lokalna kopia**: sprawdzić, czy w lokalnej kopii są jakieś modyfikacje (wszystkie wygenerowane pliki muszą byc ignorowane)

> nie zaleca się aby do sprawdzenia poprawności stosować inne rozwiązania nawet jeśli są zgodne z aktualnymi trendami.
>
> UWAGA: po zdefiniowaniu `tag` można i trzeba kontynuować prace nad kolejnym etapem.

## Zaliczenie

### Warunki ogólne

W celu potwierdzenia osiągnięcia celu i zrealizowania zakresu zadania, w trakcie omawiania treści programu należy wykazać, że zostały zrealizowane punkty z listy kontrolnej zamieszczonej w osobnym pliku. Przed oddaniem pracy do oceny, należy ten plik dodać jako issue i upewnić się samemu, że wszystkie punkty listy kontrolnej zostały zrealizowane. Po upewnieniu się (wszystkie punkty muszą być zaznaczone jako wykonane) **zamknąć issue**. Utworzyć kolejne z tą samą listą kontrolna dla Prowadzącego na potrzeby zaliczenia.

### Typowe błędy

- dane identyfikacyjne są nierzetelne, nieprawdziwe lub niekompletne
- prace nie są rozłożone równomiernie
- repozytorium jest niekompletne i po utworzeniu lokalnej kopii na komputerze Prowadzącego nie można kompilować programu lub testy nie dają pozytywnego wyniku
- zamiast testów jednostkowych są zastosowane testy integracyjne (np. testowanie kilku warstw w jednym teście)
- nie wszyscy członkowie grupy roboczej zgłosili zadanie do oceny
- zadanie jest w trybie roboczym - nie zostało skutecznie zgłoszone przez wszystkich członków grupy roboczej
- proponowane rozwiązanie nie jest zgodne z listą kontrolną  lub szczegółowym opisem

## Lista źródeł

### Tworzenie repozytorium

Aby ułatwić tworzenie repozytorium można skorzystać z filmiku ilustrującego tę procedurę.

- [jak utworzyć repozytorium GitHub na potrzeby projektu](https://youtu.be/uANd4kfWfVA)

Aby prawidłowo utworzyć `tag` (za pośrednictwem tworzenia `Release`) w repozytorium proszę skorzystać z dokumentu specyfikacji

- [Semantic Versioning 2.0.0][SV]

### Architektura warstwowa

W celu ułatwienia poprawnej realizacji wymagania utworzenia programu o architekturze warstwowej można wziąć udział w następującym kursie:

- [Programming in Practice - Information Computation; Udemy, 2023](https://www.udemy.com/course/information-computation/?referralCode=9003E3EF42419C6E6B21)

Darmowy dostęp do kursu wymaga odpowiedniego kuponu. Można go uzyskać zwracając się bezpośrednio do Prowadzącego. Natomiast, na początek wystarczy przykład programu umieszczony w repozytorium [GitHub mpostol/TP][TP] (zawierającego przykłady edukacyjne) zgodnie z poniższym rysunkiem. Należy podkreślić, że warunkiem jest pełne zrozumienie tej architektury.

![ReferenceApplicationArchitecture][LA]

- [Repozytorium GitHub mpostol/TP](https://github.com/mpostol/TP) - C# in Practice - set of C# examples targeting education purpose

[SV]: https://semver.org/
[LA]: https://ftims.edu.p.lodz.pl/pluginfile.php/278449/mod_resource/content/1/ReferenceApplication.png
[E0T]: https://ftims.edu.p.lodz.pl/pluginfile.php/184472/mod_resource/content/4/Etap%200%20EADME%20Templlate.md
[TP]: https://github.com/mpostol/TP
