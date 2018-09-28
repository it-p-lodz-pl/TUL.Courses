# Task 4 - WPF

# Cel

Celem zadania jest poznanie sposobu tworzenia aplikacji dla systemu Windows w oparciu o technologię `WPF` i język `XAML` z wykorzystaniem wzorca `MVVM`. Po zakończeniu zadania student będzie potrafił:

- Tworzyć aplikacje dla systemu Windows w technologii `WPF`,
- Definiować interfejs użytkownika z wykorzystaniem języka `XAML`,
- Stosować architekturę `MVVM`,
- Realizować aplikacje wielowarstwowe.

# Opis zadania

## Wstęp ##

Zadanie polega na opracowaniu programu komputerowego o architekturze wielowarstwowej przeznaczonego do edycji danych z wykorzystaniem graficznego interfejsu użytkownika. Powinno być zrealizowane z wykorzystaniem warstwy danych zrealizowanej w zadaniu 3. 

Do każdej części projektu powinny zostać opracowane testy jednostkowe.

Należy wyraźnie wydzielić następujące warstwy, które opisano w rozdziale **Architektura**:

- **Danych**: dostęp do repozytorium danych 
- **Usług**: usług przetwarzania danych
- **GUI**: graficznego interfejsu użytkownika

## Architektura

### Warstwa danych
 
Podobnie jak w zadaniu 3 należy wykorzystać jako repozytorium danych procesowych bazę SQL `AdventureWorks` i utworzone w tym zadaniu typy odpowiedzialne za interakcję z tą bazą. W miarę potrzeb funkcjonalność oferowana przez te typy powinna być rozszerzona.  W uzasadnionych przypadkach dopuszcza się możliwość modyfikowania uprzednio opracowanego kodu źródłowego.

### Warstwa usług 

- Klasy odpowiedzialne za przetwarzanie danych procesowych zgromadzonych w bazie muszą być zaimplementowane jako osobna warstwa,
- Usługi powinien przypominać zastosowany w zadaniu 1 klasę `DataRepository`,
- Realizując usługi należy dostarczyć funkcjonalność umożliwiającą tworzenie, odczyt, aktualizację i usuwania encji (w skrócie oznaczanych `CRUD`) z bazy danych,
- Ta warstwa powinien udostępniać publiczne API, a ukrywać szczegóły implementacji, np. potrzebę tworzenia `DataContext`,
- Warstwa musi być zrealizowana jako osobny projekt.

### Graficzny interfejs użytkownika (GUI)

Należy utworzyć nowy projekt `Visual C# > WPF Application`, czyli aplikację dla systemu Windows z wykorzystaniem technologii `WPF` pozwalającą na przeglądanie i edycję danych.
- Utworzyć okno główne aplikacji i zdefiniować jej podstawowe zachowania, jak inicjalizacja i wyłączenie,
- Zaprojektować odpowiedni interfejs graficzny GUI wykorzystując język XAML,
- Wykorzystać utworzony serwis danych do operowania na danych.

Warstwa ta musi być zaimplementowany zgodnie ze wzorcem `Model-View-ViewModel` (`MVVM`). Oznacza to, że należy w niej wydzielić następujące warstwy:

- `View`: zestaw kontrolek bezpośrednio zapewniający interakcję pomiędzy użytkownikiem i programem zaprojektowany z wykorzystaniem języka XAML (`*.xaml`).
- `ViewModel`: klasy odpowiedzialne za odpowiednie zachowanie się interfejsu użytkownika tak, aby wyświetlać aktualne dane i realizować polecenia użytkownika w zależności od stanu interfejsu. Warstwa odpowiedzialna za powiązanie kontrolek z API oferowanym przez warstwę `Model`   
- `Model`: klasy odpowiedzialne za przechowywanie danych na potrzeby interfejsu użytkownika (GUI) i realizację operacji na danych z wykorzystaniem funkcjonalności oferowanej przez warstwę opisaną w poprzednim rozdziale **Warstwa usług**,

Dane i kontrolki muszą być powiązane ze sobą za pomocą mechanizmu wiązania danych `DataBinding`. Oznacza to również, że nie powinno się tworzyć kodu c# w warstwie widoku (tzw. code-behind) w plikach `*.xaml.cs`, poza kodem automatycznie generowanym przez `Visual Studio`. Do powiadamiania warstwy `View` o zmianach zachodzących na niższej warstwie należy wykorzystać implementację interfejsów `INotifyPropertyChanged` oraz `INotifyCollectionChanged` lub ich pochodnych.

Do obsługi poleceń użytkownika należy wykorzystać mechanizm poleceń (implementacja interfejsu `ICommand`). Dotyczy to w szczególności obsługi przycisków, ale także menu i innych elementów interfejsu. Polecenia powinny zostać zaimplementowane jako niezależne klasy w warstwie `ViewModel`.

GUI należy zaprojektować tak, aby wyświetlać listę głównych elementów z podstawową informacją. Dla zaznaczonego elementu powinny zostać zaprezentowane dane szczegółowe. Oznacza to implementację wzorca `Master-Detail`. Na widoku `Master` należy wyświetlić dane w formie tabeli, bez zawierania dokładnych informacji o elementach, które powinny być zawarte dopiero na widoku szczegółowym `Detail`. Do wyświetlenia danych poszczególnych elementów należy użyć elementy wzorców `DataTemplate`.

Interfejs poza wyświetlaniem musi pozwolić na edycję danych, na dowolnym poziomie. Edytując dane pracowników, program powinien umożliwić dodawanie i usuwanie pracownika, a także edycję danych konkretnego pracownika.
Program musi pozwolić na zapis nowych lub zmodyfikowanych danych do bazy danych. W interfejsie użytkownika powinna istnieć możliwość wykonania operacji zapisu danych osobnym przyciskiem lub za z wykorzystaniem menu.

# Wytyczne do realizacji

Realizacja zadania powinno uwzględniać zalecenia zdefiniowane przez programistów firmy Microsoft (Patterns & Practices), a także dobre praktyki tworzenia oprogramowania. Więcej informacji na ten temat w punkcie **Lista źródeł**, a w szczególności:

* Zachować przejrzystość implementacji i segregacji kodu, m.in. przez stosowanie folderów `Models`, `Views` oraz `ViewModels`.
* Korzystać z dobrych praktyk tworzenia oprogramowania `SOLID`, `DRY` i innych,

Należy również zadbać o ograniczenia wynikające ze struktury w bazie danych, np. długości pól tekstowych.
Oznacza to konieczność walidacji danych. Walidacja powinna wykorzystywać interfejsy `IDataErrorInfo`, `INotifyDataErrorInfo` lub stworzenie mapowania z `Validation Rule`, które zapewnią sprawdzenie danych przed wysłaniem ich do bazy danych.

Operacje bazodanowe jako potencjalnie czasochłonne nie powinny być wykonywane w sposób, który blokowałby GUI objawiający się brakiem interakcji z użytkownikiem. Zaleca się wykorzystanie asynchonicznego wykonania komend, przykładowo wykorzystując klasę `Task` (`Task-based Asynchronous Pattern`) do operacji związanych z odczytem i zapisem w bazie danych. Poniższy przykład pokazuje jak można ten problem rozwiązać.

```
// opreracja poza interfejsem użytkownika
void LongOperation() {
  // ...
}

//Implementacja ICommand
void Execute() {
  // zle
  LongOperation();

  // dobrze
  Task.Run(() => {
    LongOperation();
  });
}

```

Istnieje wiele bibliotek wspierających wykorzystanie wzorca MVVM. Rozważając wykorzystanie jednej z nich proszę brać pod uwagę, że nadrzędnym celem zadania jest zrozumienie po co ten mechanizm jest i jak on działa. Zasada ta będzie egzekwowana bez względu na zaproponowane rozwiązanie. Z doświadczenia wiemy, że implementują wybrane rozwiązania samemu ma się gwarancję, że odpowiedź na powyższe pytania jest zdecydowanie łatwiejsza.

Często realizacja GUI wymaga wyświetlenia użytkownikowi dodatkowego okienka w celu zasygnalizowania sytuacji wymagającej podjęcia decyzji lub wystąpienia błędu. Jest wiele sposobów rozwiązania tego problemu. Dla potrzeb tego zadania zaleca się realizację tego typu operacji w warstwie `ViewModel`. Niestety to utrudnia testowanie tej warstwy, ponieważ w testach jednostkowych może pojawić się graficzna kontrolka, a to jest sprzeczne z zasadą, że testy muszą być realizowane zawsze bez interakcji z użytkownikiem. Aby rozwiązać ten problem wystarczy zastosować wzorzec wstrzykiwania zależności i zastąpić tą funkcjonalność inną, która nie wykorzystuje kontrolek graficznych.


## Lista źródeł

## Wprowadzenie

[Windows Presentation Foundation](http://msdn.microsoft.com/en-us/library/ms754130.aspx)

[Architektura WPF](http://msdn.microsoft.com/en-us/library/ms750441.aspx)

[Język XAML](http://msdn.microsoft.com/en-us/library/ms747122.aspx)

[Wiązanie danych WPF](http://msdn.microsoft.com/en-us/library/ms752347.aspx)

[Wprowadzenie do wzorca MVVM](http://msdn.microsoft.com/pl-pl/library/wprowadzenie-do-wzorca-projektowego-model-view-viewmodel-na-przykladzie-aplikacji-wpf.aspx)

[Uniwersalne aplikacje z MVVM](https://channel9.msdn.com/events/DEVintersection/DEVintersection-2016/DEV12)

## Realizacja zadania

[Długi kurs MVVM](http://www.software-architects.com/devblog/2010/09/10/MVVM-Tutorial-from-Start-to-Finish)

[Przykład aplikacji do edycji danych w WPF z MVVM](http://www.codeproject.com/Articles/332615/WPF-Master-Details-MVVM-Application)

[Opis relacji bazy danych Adventure Works](https://akela.mendelu.cz/~jprich/vyuka/db2/AdventureWorks2008_db_diagram.pdf)

## Dodatkowe

[Optymalizacja aplikacji WPF](http://msdn.microsoft.com/en-us/library/aa970683.aspx)

[Implementacja wzorca MVVM w WPF z biblioteką Prism](http://msdn.microsoft.com/en-us/library/gg405484.aspx)

[Tworzenie aplikacji dla systemu Windows 8](http://channel9.msdn.com/Series/Tworzenie-aplikacji-w-stylu-Modern-UI-dla-programist-w/MVVM-Tworzenie-aplikacji-dla-systemu-Windows-8-dla-programistw)

[Najlepsze praktyki MVVM](https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/MVVM-Best-Practices)

[Krótki kurs MVVM](http://www.codeproject.com/Articles/81484/A-Practical-Quick-start-Tutorial-on-MVVM-in-WPF)

[Programowanie asynchorniczne](https://msdn.microsoft.com/en-us/library/jj152938.aspx)

[Wzorzec zadań asynchornicznych](https://msdn.microsoft.com/en-us/library/hh873175.aspx)

