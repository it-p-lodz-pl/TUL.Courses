# Zadanie 1 - Kolekcje, testy jednostkowe, wstrzykiwanie zależności

## Cel

Celem zadania jest praktyczne potwierdzenie umiejętności:

- korzystania z wybranego środowiska projektowego, tzn.
  - GitHub, VisualStudio, język C#
  - cyklu tworzenia programu
  - cyklu życia programu
- wykorzystania paradygmatu programowania obiektowego
- posługiwania się wybranymi konstrukcjami językowymi języka C#
- projektowania programu warstwowego
- testowania programu z wykorzystaniem testów jednostkowych

## Zakres

- Dane
  - wartościowe/referencyjne
  - strukturalne
  - zdarzenia
  - kolekcja
  - słowniki
- Typy
- Programowanie obiektowe (abstrakcja, dziedziczenie, polimorfizm, hermetyzacja)
- wykorzystanie kolekcji platformy .NET w przykładowym zastosowaniu:
  - katalogowanie, np. katalog produktów, wykaz klientów,
  - rejestracja zdarzeń, np. lista faktur,
  - opis stanu, np. stan biblioteki, stan magazynu.
- definiowanie API dla biblioteki (deklaracje publiczne)
- **użycie wzorca wstrzykiwania zależności**

## Opis zadania

### Wymagania ogólne

Utworzyć bibliotekę, której zadaniem będzie dostarczenie funkcjonalności pozwalającej na automatyzacje wybranego procesu biznesowego, np. bibliotekę książek, sklep internetowy, magazyn, itp. Biblioteka ma implementować warstwy: danych i logiki biznesowej zgodnie z modelem trójwarstwowym, który był omawiany na wykładzie. Na własne potrzeby można również zaimplementować warstwę prezentacji w dowolnej technologii.

Warstwę danych i logiki biznesowej (w skrócie logiki) należy zaimplementować z wykorzystaniu  biblioteki przenośnej (technologia .NET Standard). 

Wymienione wyżej warstwy danych i logiki muszą być testowane z wykorzystaniem testów jednostkowych.

Nie ma wymagań, co do ilości użytych projektów Visual Studio.

### Warstwa Danych

Ta warstwa musi zawierać wszystkie klasy reprezentujące dane istotne dla wybranego procesu.

#### Definicja modelu obiektowego

Zdefiniuj zbiór wzajemnie powiązane typów, reprezentujących dane wybranego procesu biznesowego. Model ten powinien reprezentować następujące dane:

- `Wykaz` ma reprezentować elementy wykazu z danymi opisującymi osoby, jak: czytelnicy, klienci
- `Katalog` ma opisywać pozycje w słowniku, jak: opisy książek, opisy produktów
- `OpisStanu` ma opisywać wystąpienia odnoszące się do pozycji słownikowych, jak: egzemplarz książki - opis książki, data zakupu; stan magazynu - produkt, jego ilość, cena netto, stawka podatku
- `Zdarzenie` ma opisywać relacje wiążące osoby oraz wystąpienia odnoszące się do pozycji słownikowych, jak: wypożyczenia - kto, który egzemplarz, data wypożyczenia, data zwrotu; faktura - kto, kiedy, który stan magazynowy produktu, ilość, cena i stawka dla produktu

Inne klasy mogą zostać wprowadzone w uzasadnionych przypadku (np. w celu normalizacji struktury danych).

#### Implementacja modelu obiektowego

Zaimplementuj model obiektowy tak, by był do niego swobodny dostęp. Jeśli nie masz lepszego pomysłu, proponowana jest nazwa `DataContext`. Przeznaczeniem tej klasy jest zagwarantowanie pojedyńczego punku dostępowego do modelu obiektowego. Pozwala to traktować model, jako pewna całość (przykładowo ekwiwalent bazy danych).

W tej klasie zadeklaruj pola gromadzące obiekty z danymi w postaci odpowiednich kolekcji:

- Dane z informacjami o elementach wykazu należy przechowywać w obiekcie `List`.
- Pozycje katalogu należy przechowywać w obiekcie `Dictionary`.
- Zdarzenia łączące pozycje słownikowe z elementami wykazu należy przechowywać o obiekcie klasy `ObservableCollection`.
- Opisy stanu można przechowywać w obiektach dowolnej z powyższych kolekcji, np. `List` lub `ObservableCollection`.

Przy takim rozwiązaniu powstaje problem odpowiedzialność za spójność danych w modelu obiektowym, będącym przykładem danych strukturalnych. Problem ten można rozwiązać korzystając z wzorca projektowego `Bridge`. W takim przypadku warstwa danych jest reprezentowany przez zbiór dedykowanych operacji utworzonych zgodnie z tym wzorcem tak, aby tą spójność zapewnić. Pamiętaj, że spójność danych można zapewnić na dwa następujące sposoby:

- sprawdzając, czy żądana modyfikacja nie naruszy spójności
- wymusić spójność, czyli nie dopuścić do możliwości powstania niespójności

#### API warstwy danych

API tej warstwy musi być zdefiniowane jako abstrakcja.

#### Odtwarzanie stanu początkowego modelu danych

Należy przygotować API do wypełniania kolekcji przykładowymi danymi. Można to zrealizować wprowadzając klasę abstrakcyjną lub interfejs. Użycie konkretnej implementacji ma być realizowane **na zasadzie wzorca Wstrzykiwania Zależności (Dependency Injection, DI)**. **Przykładowo** wypełnianie danymi może być zrealizowane poprzez:

- odczyt danych z przygotowanego pliku tekstowego,
- deserializację danych w formacie JSON, XML, itp.

### Warstwa logiki biznesowej

Zaimplementuj logikę biznesową jao osobną warstwę programu zgodnie z algorytmem wybranego procesu biznesowego. Jeśli nie masz lepszego pomysłu, proponowana jest nazwa `DataService`.

### Testy jednostkowe

- Sprawdź poprawność rozwiązania - tworząc testy jednostkowe
- Warstwa danych i logiki muszą byc testowane niezależnie

## Lista źródeł

Rozwiązanie zadania jest możliwe wyłącznie na bazie nabytej dotychczas wiedzy i przykładowego kodu na [GitHub](https://github.com/mpostol/TP) używanego w trakcie zajęć. Literatura uzupełniająca podana jest na stronie kursu.

## Zaliczenie

### Realizacja zakresu zadania

W minimum zaliczeniowym jest wymagane:

1. Brak błędów kompilatora po wyciągnięciu nowej kopii kodu z repozytorium
1. Pozytywne wyniki wymaganych testów jednostkowych
1. Poprawne zdefiniowanie modelu obiektowego dla wybranego procesu biznesowego
1. Rozwiązanie problemu zapewnienia spójności danych w modelu obiektowym
1. Wykorzystanie testów jednostkowych do testowania modelu obiektowego i logiki biznesowej **niezależnie**
1. Poprawnego przetestowania z wykorzystaniem testów jednostkowych modelu obiektowego dla dwóch rożnych sposobów generowania danych testowych

### Osiągnięcie celu - przykładowe zagadnienia

W trakcie zaliczenia mogą być poruszane zagadnienie związane z:

- użyciem danych wartościowych i referencyjnych oraz omówienia warunku wyboru odpowiedniego ich rodzaju
- umiejętnością tworzenia i wykorzystania danych strukturalnych
- sposobem zapewnienia wspólnych cech danych złożonych
- umiejętnością wskazania miejsc wykorzystania i wytłumaczenia, co to jest kolekcja używając **wyłącznie** terminologii języka C#
- wskazaniem miejsca wykorzystania wzorca wstrzykiwania zależności
- wykazaniem, że warstwy testowane sa niezależnie
- sposobem zapewnienia spójności danych
- wykorzystaniem abstrakcji i jej implementacji
- koniecznością implementacji zachowań polimorficznych
- umiejętnością uzasadnienia, że API warstwy danych musi być zadeklarowane z wykorzystaniem abstrakcji
- deserjalizacją, jeśli ktoś użył jej do odczytu danych zewnętrznych
