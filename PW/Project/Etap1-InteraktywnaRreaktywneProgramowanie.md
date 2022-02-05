# Projekt Etap 1 - programowania interaktywne/reaktywne, IoC (ang. inversion of control)

## Cel

Celem zadania jest praktyczne zastosowanie:

- wybranego środowiska projektowego, tzn. GitHub, VisualStudio, język C#
- programowania reaktywnego i interaktywnego
- architektury warstwowej, a w tym zastosowanie wzorca `MVVM`
- graficznego interfejsu użytkownika (GUI) z wykorzystaniem języka `XAML`
- testowania jednostkowego i integracyjnego
- techniki wstrzykiwania zależności (ang. Dependency Injection)
- techniki MOCK

## Opis zadania

### Wstęp

Zadanie polega na opracowaniu programu komputerowego o architekturze wielowarstwowej i funkcjonalności pozwalającej na automatyzację wybranego procesu biznesowego z wykorzystaniem graficznego interfejsu użytkownika. Do zaimplementowania należy wybrać jeden z poniższych modeli biznesowy:

- bibliotekę, sklep, itp.
- zakład usługowy
- internetowe wybory Prezydenta kraju
- system antywłamaniowy
- śledzenie i zdalna kontrola pojazdów
- zdalne sterowanie ogrzewania mieszkania
- grę komputerową

Po konsultacji z prowadzącym można wybrać inny model biznesowy.

Opracować program z wykorzystaniem technologi .NET, który będzie implementował warstwy: `Dane`, `Logika` i `Prezentacja`, więc w architekturze programu należy **wyraźnie** wydzielić następujące warstwy:

- `Dane` - zarządzanie danymi
- `Logika` - usługi realizujące funkcjonalność dedykowaną dla wybranego procesu biznesowego
- `Prezentacja` - graficzny interfejs użytkownika

Wymienione wyżej warstwy `Dane` i `Logika` muszą być testowane z wykorzystaniem testów jednostkowych. Bardziej szczegółowo warstwy te opisano w rozdziale **Architektura**.

### Architektura

#### Warstwa `Dane`

- Jako repozytorium danych procesowych należy wykorzystać model obiektowy w pamięci operacyjnej. Początkowy stan procesu biznesowego należy odtworzyć z wygenerowanych/odczytanych danych, z zastrzeżeniami opisanymi w rozdziale **Wytyczne do realizacji**.
- Warstwa powinna udostępniać publiczne abstrakcyjne API, a ukrywać szczegóły implementacji.

#### Warstwa `Logika`

- Implementując usługi w tej warstwie, należy dostarczyć funkcjonalność umożliwiającą przetwarzanie danych na potrzeby wybranego procesu biznesowego.
- API warstwy `Logika` powinno zawierać operacje interaktywne (np. zakup czegoś) i reaktywne (okresowe wysłanie PIT'u).
- Warstwa powinna udostępniać publiczne abstrakcyjne API, a ukrywać szczegóły implementacji.

#### Warstwa `Prezentacja` - graficzny interfejs użytkownika (GUI)

- Utworzyć okno główne aplikacji zawijające potrzebne kontrolki do monitorowania i sterowania procesem biznesowym
- Ta warstwa jest odpowiedzialna za inicjację programu (bootstrap) i jego zakończenie
- zaprojektować interfejs graficzny wykorzystując język XAML
- Wykorzystać API warstwy **Logika** do wizualizacji i sterowania procesem biznesowym

Warstwa ta musi być zaimplementowana zgodnie ze wzorcem `Model-View-ViewModel` (`MVVM`). Oznacza to, że należy w niej wydzielić następujące warstwy:

- `View`: zawiera zestaw kontrolek bezpośrednio zapewniający interakcję pomiędzy użytkownikiem i programem oraz zaprojektowany z wykorzystaniem języka XAML (`*.xaml`).
- `ViewModel`: implementuje zachowanie się interfejsu użytkownika tak, aby wyświetlać aktualne dane i realizować polecenia użytkownika w zależności od stanu procesu. Warstwa odpowiedzialna za powiązanie kontrolek z API oferowanym przez warstwę `Model`
- `Model`: odpowiedzialna za przechowywanie danych na potrzeby interfejsu użytkownika (GUI) i realizację operacji na danych z wykorzystaniem funkcjonalności oferowanej przez warstwę opisaną w poprzednim rozdziale **Warstwa `Logika`**,

Dane i kontrolki muszą być powiązane ze sobą za pomocą mechanizmu wiązania danych `DataBinding`. Oznacza to również, że nie powinno się tworzyć kodu w warstwie widoku (tzw. code-behind) w plikach `*.xaml.cs`, poza kodem automatycznie generowanym przez środowisko projektowe. Do powiadamiania warstwy `View` o zmianach zachodzących w warstwie poniżej, należy wykorzystać implementację interfejsów `INotifyPropertyChanged` oraz `INotifyCollectionChanged` lub ich pochodnych.

Do obsługi poleceń użytkownika należy wykorzystać mechanizm poleceń (implementacja interfejsu `ICommand`). Dotyczy to w szczególności obsługi przycisków, ale także menu i innych elementów interfejsu. Polecenia powinny zostać zaimplementowane jako niezależne klasy w warstwie `ViewModel`.

## Wytyczne do realizacji

- Warstwy `Dane` i `Logika` proszę zrealizować w technologii .NET STandard
- Warstwa `Dane` ma zwierać model obiektowy reprezentujący wybrany proces biznesowy, np. sklep
- Warstwa `Logiki` powinna reprezentować wszystkie operacje realizowane w wybranym procesie
- Proszę pamiętać, że `Dane` + `Logika` to sekcja krytyczna i rozwiązanie musi być odporne na zdarzenia jednoczesne
- Proszę dodać testy jednostkowe dla ważniejszych operacji warstwy `Dane`, `Logika`. Proszę odprzęgnąć warstwy na potrzeby testowania używając DI lub MOCK
- Przy realizacji warstwy **Danych** należy unikać korzystania z zewnętrznych repozytoriów danych, jak pliki, bazy danych, itp. Jednak w każdym przypadku trzeba zapewnić, że pozytywny wynik realizacji testów jednostkowych nie będzie stawiał dodatkowych wymagań dla środowiska wykonawczego.
- warstwowość programu najprościej uzyskać, implementując warstwy jako osobne projekty.
- abstrakcyjne API najprościej zadeklarować jako wspólny projekt oraz implementację warstwy w postaci niezależnego silosu realizującego API.

- **UWAGA**: rozwiązanie dalej będzie modyfikowane w celu uzyskania aplikacji rozproszonej, tzn. realizowanej na kilku komputerach połączonych poprzez sieć
  - Proszę pomyśleć, w którym miejscu wstawić komunikację pomiędzy klientem i serwerem pamiętając, że klient/serwer komunikuje się ze sobą z wykorzystaniem technologii Web-sockets

## Lista źródeł

Do zrealizowania zadania można wykorzystać przykładowy kodu na [C# in Practice - set of C# examples targeting education purpose](https://github.com/mpostol/TP). Literatura uzupełniająca podana jest na stronie kursu.

## Zaliczenie

 W celu potwierdzenia osiągnięcia celu i zrealizowania zakresu zadania, w trakcie omawiania kodu programu, mogą byc poruszane zagadnienia z nim związane, a w tym

- wykazania zastosowania architektury warstwowej
- wykazaniem, że warstwy testowane sa niezależnie
- jak zapewniono spójności danych
- umiejętnością uzasadnienia, że API warstwy danych musi być zadeklarowane z wykorzystaniem abstrakcji
- deserjalizacją, jeśli ktoś użył jej do odczytu danych zewnętrznych
- wskazaniem miejsca wykorzystania wzorca wstrzykiwania zależności lub użycia techniki Mock
