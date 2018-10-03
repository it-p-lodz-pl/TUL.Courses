# Cel

Głównym celem projektu jest zrozumienie:

1. Zmiany sposobu reprezentacji tej samej informacji ze szczególnym uwzględnieniem postaci obiektowej i strumieniowej
1. Rekurencji na przykładzie, gdy program opisuje program, typ zawiera typ, itp.
1. Iteracji wyrażonej jako instrukcja powtarzania lub kwerendy dla populacji w kolekcji
2. Kompozycji aplikacji z niezależnie utworzonych modułów
3. Wariantowego wykorzystania różnych technologii do implementacji interfejsu użytkownika
4. Wariantowego wykorzystania różnych technologii do implementacji repozytorium danych
5. Wariantowego wykorzystania różnych technologii do implementacji mechanizmów śledzenia przebiegu programu
1. Modelu MVVM (Model-View-ViewModel), a więc warstwowej budowy aplikacji, w której oddzielono warstwę prezentacji od warstwy danych warstwą modelu widoku z wykorzystaniem powiązań luźnych (ang. data bindings)

# Wymagania

1. Z wykorzystaniem mechanizmu refleksji umożliwienie analizowania zawartości wybranej .dll/.exe i zapisania możliwie dużo metadanych programu do modelu obiektowego
1. Umożliwienie wariantowego zapisu i odczytu modelu obiektowego do:
 * pliku xml
 * relacyjnej bazie danych
1. Umożliwienie wariantowego wykorzystania interfejsu użytkownika z wykorzystaniem:
 * technologii WPF - wymaga się zastosowania architektury warstwowej zgodnej modelem MVVM
 * tekstowego interfejs użytkownika (Command Line)
2. Umożliwienie wariantowego wykorzystania mechanizmu śledzenia zachowania aplikacji z wykorzystaniem:
 * plików tekstowych
 * relacyjnej bazy danych
3. Do sprawdzenia poprawności programu należy testy jednostkowych (ang. Unit Tests) na wszystkich etapach projektu:
 * wszystkie ważniejsze funkcje muszą być testowane
 * do testowania należy wykorzystać wstrzykiwanie zależności lub technikę 'mock`
2. Umożliwienia wariantowej kompozycji aplikacji z wykorzystaniem technologii MEF
3. Funkcje analizy i zapisu danych do repozytorium powinny być wykonywane asynchronicznie w stosunku do wątku obsługi interfejsu użytkownika
4. Ważniejsze cechy aplikacji muszą by konfigurowalne

# Funkcje

1. Odczyt metadanych ze wskazanego komponentu .dll/.exe.
1. Zapis/odczyt do repozytorium odczytanych metadanych dla komponentu .dll/exe.
1. Wyświetlenie metadanych w postaci
 *  dla technologi MEF: hierarchicznej z wykorzystaniem drzewa pokazującego wzajemne zależności konstrukcji językowych,
 *  dla interfejsu tekstowego: tekstu sformatowanego poprzez wcięcia.
1. Śledzenie przebiegu programu.  

# Wytyczne do realizacji

## Lista źródeł

* [XSL Languages](http://www.w3schools.com/xsl/xsl_languages.asp): odwiedź W3C School aby dowiedzieć się więcej jak korzystać z XSLT;
* [Serialization in the .NET Framework](https://goo.gl/cPQO1J) aby dowiedzieć się więcej o serializacji;
* Przykłady kodu i programów można znaleźć tu:
[Windows 8](http://code.msdn.microsoft.com/windowsapps/),
[Windows 10](https://blogs.windows.com/buildingapps/2016/03/30/windows-10-anniversary-sdk-is-bringing-exciting-opportunities-to-developers/),
[Windows Azure](http://code.msdn.microsoft.com/windowsazure/),
[Office](http://code.msdn.microsoft.com/office/),
[SharePoint](http://code.msdn.microsoft.com/sharepoint/),
[Silverlight](http://code.msdn.microsoft.com/silverlight/);
* Treści związane z Visual Studio są tu: [C#](http://code.msdn.microsoft.com/Visual-Studio-2010-Samples-31b491f3),
[VB.NET](http://code.msdn.microsoft.com/Official-Visual-Studio-f48134ec),
i [101 LINQ samples](http://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b);
* [Developer code samples](https://code.msdn.microsoft.com/): przykłady kodu dla dewelopera;
* [Windows Presentation Foundation:](https://goo.gl/s1Re1J) - w tym artykule można znaleźć:
	* Create Modern Desktop Applications with Windows Presentation Foundation
	* Designing XAML in Visual Studio
	* WPF in the .NET Framework
* [Patterns - WPF Apps With The Model-View-ViewModel Design Pattern](https://msdn.microsoft.com/en-us/magazine/dd419663.aspx) - ten artykuł dotyczy
	* Patterns and WPF
	* MVP pattern
	* Why MVVM is better for WPF
	* Building an application with MVVM
* [Tracing and Instrumenting Applications](https://docs.microsoft.com/en-us/dotnet/framework/debug-trace-profile/tracing-and-instrumenting-applications)
* [Managed Extensibility Framework (MEF)](https://docs.microsoft.com/en-us/dotnet/framework/mef/)
* [Moq - Mock Database](https://www.codeproject.com/Articles/478504/Moq-Mock-Database)
 
# Zaliczenie

Zaliczenie wymaga przedstawienia i omówienia wyników pracy w następujących etapach:

* Etap 1: Interfejs użytkownika w dwóch wersjach. model obiektowy (dane symulowane), śledzenie programu w wybranej technologii.
* Etap 2: implementacja logiki aplikacji i zapis do wybranego repozytorium.
* Etap 3: kompozycja aplikacji z możliwością wykorzystania alternatywnych implementacji.
* Etap 4: implementacja alternatywnych implementacji dla repozytorium i śledzenia.

Każdy z etapów będzie oceniany osobno.
