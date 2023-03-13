# Projekt Etap 1 - szczegółowy opis

## Opis

programowania interaktywne/reaktywne, IoC (ang. inversion of control)

## Cel

To trzy etapowe zadanie polega na opracowaniu programu komputerowego o architekturze wielowarstwowej i funkcjonalności pozwalającej na obserwowaniu zachowania się kul na  prostokątnej płaszczyźnie ograniczonej ścianami bocznymi.

Celem tego etapu jest praktyczne zastosowanie:

- wybranego środowiska projektowego, tzn. GitHub, VisualStudio, język C#
- reaktywnego i interaktywnego współdziałania użytkownik/komputer
- zastosowanie wzorca `MVVM` (architektury warstwowej)
- graficznego interfejsu użytkownika (GUI) z wykorzystaniem języka `XAML`
- programowania asynchronicznego (reaktywnego i interaktywnego)
- testowania jednostkowego i integracyjnego
- techniki wstrzykiwania zależności (ang. Dependency Injection)
- techniki MOCK (opcja)

## Opis zadania

W tym etapie kule poruszają się po ograniczonej płaszczyźnie, ale nie oddziaływają między sambą i ze ściankami ograniczającymi. Kule poruszają się według trajektorii określonej przez generator pseudolosowy, tzn. jedynym warunkiem na określenie ich następnego położenia jest to, aby nadal znajdowały się wewnątrz ograniczonej płaszczyzny. Na ekranie kula może być wizualizowana jako okrąg. Ruch powinien być płynny. Należy umożliwić wprowadzenie przez użytkownika początkowej liczby kul poprzez umieszczenie odpowiednich kontrolek na ekranie (GUI). Początkowe położenie kul na płaszczyźnie jest losowe.

Opracować program z wykorzystaniem technologii .NET, który będzie implementował warstwy: `Dane`, `Logika` i `Prezentacja`, więc w architekturze programu należy **wyraźnie** wydzielić następujące warstwy:

- `Dane` - zarządzanie danymi
- `Logika` - usługi realizujące funkcjonalność dedykowaną dla wybranego procesu biznesowego
- `Prezentacja` - graficzny interfejs użytkownika

Bardziej szczegółowo warstwy te opisano w rozdziale **Architektura**.

Wymienione wyżej warstwy `Dane` i `Logika` muszą być testowane niezależnie z wykorzystaniem testów jednostkowych. Aby to było możliwe API warstwy `Dane` i `Logika` musi być zrealizowany jako wyraźnie wydzielone definicje abstrakcyjne.

**UWAGA**: rozwiązanie dalej będzie modyfikowane w celu uzyskania końcowej funkcjonalności, która opisana jest w kolejnych etapach.

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

Dane i kontrolki muszą być powiązane ze sobą za pomocą mechanizmu wiązania danych `DataBinding` (programowanie interaktywne). Oznacza to również, że nie można tworzyć kodu w warstwie widoku (tzw. code-behind) w plikach `*.xaml.cs`, poza kodem automatycznie generowanym przez środowisko projektowe. Do powiadamiania warstwy `View` o zmianach zachodzących w warstwie poniżej (programowanie reaktywne), należy wykorzystać implementację interfejsów `INotifyPropertyChanged` oraz `INotifyCollectionChanged` lub ich pochodnych.

Do obsługi poleceń użytkownika należy wykorzystać mechanizm poleceń (implementacja interfejsu `ICommand`). Dotyczy to w szczególności obsługi przycisków, ale także menu i innych interaktywnych elementów interfejsu. Polecenia muszą zostać zaimplementowane (obsłużone) w warstwie `ViewModel`.

## Wytyczne do realizacji

Dodatkowe informacje ułatwiające wykonanie zadania:

- Warstwy `Model`, `ViewModel`, `Dane` i `Logika` powinna być zrealizowana w technologii `.NET Standard`.
- Warstwę `View` powinna być zrealizowana w technologii `WPF`.
- Warstwa `Logika` powinna reprezentować wszystkie operacje realizowane w wybranym procesie.
- Proszę pamiętać, że `Dane` + `Logika` to sekcja krytyczna i rozwiązanie musi być odporne na zdarzenia jednoczesne.
- Proszę dodać testy jednostkowe dla ważniejszych operacji warstwy `Dane`, `Logika`.
- Warstwy powinny być luźno powiązane na potrzeby testowania używając DI lub MOCK.
- Przy realizacji warstwy **Danych** należy unikać korzystania z zewnętrznych repozytoriów danych, jak pliki, bazy danych, itp. Jednak w każdym przypadku trzeba zapewnić, że pozytywny wynik realizacji testów jednostkowych nie będzie stawiał dodatkowych wymagań dla środowiska wykonawczego.
- architekturę warstwową (luźno powiązane warstwy) programu najprościej uzyskać, implementując warstwy jako osobne projekty.
- do realizacji podstawowych funkcji programu nie trzeba stosować wstrzykiwania zależności (DI)

## Zaliczenie

W celu potwierdzenia osiągnięcia celu i zrealizowania zakresu zadania, w trakcie omawiania kodu programu należy wykazać, że zostały zrealizowane punkty z listy kontrolnej zamieszczonej w osobnym pliku. Przed oddaniem pracy do oceny, należy ten plik dodać jako issue i upewnić się samemu, że wszystkie punkty listy kontrolnej zostały zrealizowane. Po upewnieniu się zamknąć issue. Utworzyć kolejne z tą samą listą kontrolna dla prowadzącego na potrzeby zaliczenia.

## Lista źródeł

Do zrealizowania zadania można wykorzystać przykładowy kodu na [C# in Practice - set of C# examples targeting education purpose](https://github.com/mpostol/TP). Literatura uzupełniająca podana jest na stronie kursu.

- [Elastic collisions; Wikipedia](https://en.wikipedia.org/wiki/Elastic_collision)
