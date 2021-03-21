# Task 3 LINQ to SQL
# Cel

Celem zadania jest praktyczne poznanie mechanizmów pozwalających operować na danych zewnętrznych z wykorzystaniem zintegrowanych konstrukcji języka programowania, a w tym:

* zintegrowane z językiem zapytania (ang. Language Integrated Query - LINQ), 
* funkcje anonimowe, a w tym wyrażenia lambda (ang. Lambda expressions),
* metody rozszerzające,
* reprezentowanie wybranych elementów bazy danych w programie,

## Wprowadzenie
### Programowanie deklaratywne i imperatywne

W językach Java, C++ i C# programuje się w sposób **imperatywny**. Oznacza to, że programista musi podać przepis pozwalający na osiągnięcie założonego efektu końcowego. Przykładowo, żeby znaleźć w tablicy żądane elementy należy napisać pętlę, która będzie iterowana po wszystkich elementach tej tablicy, a wewnątrz pętli znajdzie się warunek sprawdzający, czy konkretny element ma zadaną wartość.

Z innym podejściem mamy do czynienia w języku SQL. W tym języku musimy jedynie podać, jakie efekty końcowe nas interesują, natomiast nie wskazujemy sposobu, w jaki mają one zostać osiągnięte. Za pozyskanie rezultatu odpowiada oprogramowanie, w przypadku języka SQL - serwer baz danych (ang Data Base Management System). Takie podejście nosi nazwę programowania **deklaratywnego**. Pomimo tego, że za wykonanie polecenia w języku deklaratywnym odpowiada "zewnętrzne" oprogramowanie, to programista ponosi odpowiedzialność za sformułowanie zapytania (ang. query).

### Przetwarzanie danych w .NET

Język C# posiada w bibliotekach standardowych bardzo duże możliwości w zakresie przetwarzania danych zawartych w  tablicach (klasa `Array`) i kolekcjach (interfejs `ICollection` i jego podstawowa implementacja `CollectionBase`). Dodatkowo obiekty tablic i kolekcji posiadają szerokie zbiory metod rozszerzających pozwalających na operacje na ich elementach bez jawnego korzystania z pętli. Metody te umożliwiają chociażby:

* wyszukiwanie obiektów (np. metoda `Where`)
* sortowanie (np. metoda `Sort`)
* obliczenie minimalnych/maksymalnych wartości w tablicy/kolekcji (np. metoda `Max`).

Dodatkowo mechanizmy, których dotyczy to zadanie, pozwalają na:

* posługiwanie się przy przetwarzaniu danych składnią deklaratywną. Siłę konstrukcji LINQ stanowi to, że ujednolica sposób formułowania zapytań "działa" zarówno dla tablic i kolekcji obiektów, jak również rekordów w bazie danych.

 ```
IEnumerable<string> wynik = from Osoba o in osoby
                where o.Wiek > 18
                select o.Imie + " " + o.Nazwisko
 ```

* pominięcie typów zmiennych w trakcie ich deklaracji, jeżeli kompilator będzie sam w stanie je określić

 ```
var wynik = from Osoba o in osoby
                where o.Wiek > 18
                select o.Imie + " " + o.Nazwisko
 ```

* rozszerzanie funkcjonalności istniejących klas (nawet takich, które wykluczają możliwość dziedziczenia z nich) poprzez zastosowanie tzw. metod rozszerzających (ang. extension methods). Takie metody są definiowane w osobnych klasach a następnie można je wykonywać na rzecz obiektów rozszerzanej klasy.

* posługiwanie się rachunkiem lambda i funkcjami anonimowymi podczas przetwarzania danych
 ```
 IEnumerable<string> wynik = 
    osoby.Where(o => o.Wiek > 18).Select(o=> o.Imie + " " + o.Nazwisko)
 ```

# Opis zadania

Zadanie powinno być zrealizowane z wykorzystaniem aktualnie dostępnej (np. w ramach DreamSpark) licencji Microsoft SQL Server. Baza danych wykorzystywana w aplikacji powinna być uruchomiona na serwerze znajdującym się bądź na komputerze Studenta, bądź na komputerze w laboratorium. Zadanie składa się z kilku etapów. Realizacja każdego z nich jest obligatoryjna.

## Etap 1 - Instalacja bazy `AdventureWorks`
Należy pobrać bazę danych `AdventureWorks` dostępną pod adresem:

* [AdventureWorks dla SQL Server 2014](https://msftdbprodsamples.codeplex.com/downloads/get/880661) 
* [AdventureWorks dla SQL Server 2012](https://msftdbprodsamples.codeplex.com/downloads/get/165399)

Jest to baza danych obrazująca fikcyjne przedsiębiorstwo zajmujące się wytwarzaniem i sprzedażą sprzętu turystycznego. W ramach jednej bazy danych dostępnych jest kilka schematów obrazujących poszczególne części przedsiębiorstwa (np. produkcja, sprzedaż, dane pracowników). Baza jest już wypełniona danymi. Ilość danych odpowiada przypadkom możliwym do napotkania w warunkach tworzenia rzeczywistych aplikacji.

Bazę danych można zaimportować na serwer wykorzystując instrukcję znajdującą się pod adresem:
[Readme for Adventure Works 2014 Sample Databases](https://msftdbprodsamples.codeplex.com/downloads/get/1467801) 

## Etap 2 - Realizacja mapowania relacyjno - obiektowego (tzw. ORM)
Po zainstalowaniu bazy danych możliwe jest przeprowadzenie mapowania relacyjno-obiektowego. Proces ten pozwala na reprezentowaniu wybranych fragmentów schematu bazy danych przez typy dostępne dla programów napisanych w .NET. 

W celu zapewnienia mapowania relacyjno - obiektowego w projekcie należy dodać element `LINQ to SQL Classes` i wykonać mapowanie tabel ze schematu `Production`.

Biblioteki zapewniające mapowanie relacyjno-obiektowe są dostępne w różnych językach programowania i oferują następujące funkcjonalności:
* tłumaczenie (w obie strony) struktur dostępnych na serwerze baz danych i w wykonywanym programie
* uwzględnianie połączeń relacyjnych
* walidacja wartości pól przed modyfikacją
* i wiele innych :)

## Etap 3 - Realizacja zapytań na bazie danych
W ramach etapu należy utworzyć klasę narzędziową, realizującą przy pomocy składni deklaratywnej `from` lub metod rozszerzających wykonywanych na rzecz kolekcji obiektów, metody zwracające:
   * produkty, których nazwa zawiera ciąg znaków podany jako parametr wywołania
```
public static List<Product> GetProductsByName(string namePart)
```

   * produkty dostarczane przez dostawcę (`Vendor`) o konkretnej nazwie.
```
public static List<Product> GetProductsByVendorName(string vendorName)
```

   * nazwy produktów (tabela `Product`) dostarczane przez dostawcę (`Vendor`) o konkretnej nazwie. 
```
public static List<string> GetProductNamesByVendorName(string vendorName)
```

   * nazwę dostawcy produktu o konkretnej nazwie
```
public static string GetProductVendorByProductName(string productName)
```

   * produkty (`Product`), które otrzymały N ostatnich opinii (`ProductReview`)
```
public static List<Product> GetProductsWithNRecentReviews(int howManyReviews)
```

   * N ostatnio recenzowanych produktów
```
public static List<Product> GetNRecentlyReviewedProducts(int howManyProducts)
```

   * listę pierwszych n produktów posortowanych względem kategorii (`ProductCategory`) i nazwy
```
public static List<Product> GetNProductsFromCategory(string categoryName, int n)
```

   * łączną cenę standardową wszystkich produktów (po jednej sztuce) z wybranej kategorii
```
public static int GetTotalStandardCostByCategory(ProductCategory category)
```

>**UWAGA - do wszystkich metod mają być napisane testy jednostkowe sprawdzające poprawność ich działania. Warunkami sprawdzanymi w testach mogą być np. liczba zwróconych elementów i ich wartości.**

## Etap 4 - metody rozszerzające
Zaimplementować następującą funkcjonalność (z wykorzystaniem stylu deklaratywnego - konstrukcja from i imperatywnego - metod rozszerzających) w postaci metod rozszerzających działających na listach obiektów klasy `Product`:

* wybranie produktów nie posiadających przypisanej kategorii (wynik w postaci listy produktów)
* podział listy produktów na 'strony' (jak w sklepie internetowym). Metoda powinna przyjmować dwa parametry: rozmiar i numer strony. (wynik w postaci listy/tablicy list/tablic produktów)

Zaimplementować metodę rozszerzającą dla listy obiektów klasy `Product` zwracającą łańcuch znaków zawierający nazwy produktów i ich dostawców rozdzielone myślnikiem. Każda para produkt - dostawca ma się znajdować w osobnej linii. W trakcie implementacji należy __koniecznie__ zachować wynik przetwarzania kolekcji produktów w postaci kolekcji obiektów typu anonimowego a następnie tę kolekcję zamienić na łańcuch znaków wg formatu w zadaniu.

## Etap 5 - operacje na kolekcjach obiektów

Na podstawie klasy `Product` przygotować klasę `MyProduct` oraz listę obiektów tej klasy na podstawie danych z bazy `AdventureWorks`. Zaimplementować trzy dowolne metody z Etapu 3 zwracające `List<MyProduct>`.

# Wytyczne do realizacji

# Lista źródeł
[101 przykładów z LINQ w C#](http://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b)

[Baza danych Adventure Works](http://msftdbprodsamples.codeplex.com/releases/view/93587)

[Dokumentacja LINQ](http://msdn.microsoft.com/en-us/library/vstudio/bb397926.aspx)

[Dokumentacja wyrażeń lambda](https://msdn.microsoft.com/en-us/library/bb397687.aspx)

# Zaliczenie
## Wymagania
Zaliczenie zadania odbywa się indywidualnie, sprawdzana jest znajomość konstrukcji języka C# i mechanizmów .NET, których dotyczyło bieżące zadanie, w szczególności:

* konstrukcji `from`
* przekształcenia wyrażenia from na wyrażenie zbudowane z metod rozszerzających
* implementacja LINQ dla SQL
* rola i sposób tworzenia modelu obiektowego
* kiedy, gdzie i jak realizowane są operacje bezpośrednio związane z bazą danych, a w tym:
    * połączenie z bazą
	* selekcja danych (select)
    * rozłączanie z bazą

## Przykładowe zagadnienia
W trakcie zaliczenia mogą być poruszane zagadnienie związane z:

* zrozumieniem składni i semantyki konstrukcji LINQ
* zamianą składni konstrukcji from na wyrażenie zawierające ciąg wywołań metod rozszerzających
* rodzajem informacji przechowywanych w zmiennych, do których podstawiany jest wynik wyrażenia LINQ
* wykazanie, że w proponowanym rozwiązaniu faktycznie zastosowano technologię LINQ to SQL
* zestawianiem połączenia z bazą danych, parametrami połączenia i jego rolą dla realizacji operacji na bazie
* czasem życia wybranych obiektów szczególnie w kontekście realizacji operacji na bazie 
* programowaniem atrybutowym wykorzystanym do mapowaniem konstrukcji językowych (np. klasy, właściwości) i elementów schematu basy danych (np. tablice, wiersze, typy danych, relacje, klucze)
* przebiegiem procesu odczytu danych
* zamykanie połączanie i zarządzaniem zasobami

## Osiągnięcie celu i realizacja zakresu zadania
Student zaliczający zadanie powinien:
- zainstalować bazę danych AdventureWorks i zmapować ją zgodnie z wytycznymi w punktach 1 i 2.
- zaimplementować metody z punktów 3, 4 i 5 i napisać do nich testy jednostkowe. Podczas oceny zadania sprawdzana będzie zarówno zawartość implementacji metod, jak również poprawność asercji w testach jednostkowych 
- znać odpowiedzi na pytania oraz posiadać umiejętności wskazane w punktach 'Wymagania' i 'Przykładowe zagadanienia'
