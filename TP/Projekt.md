# Cel

Głównym celem projektu jest zrozumienie:

1. Zmiany sposobu reprezentacji tej samej informacji ze szczególnym uwzględnieniem postaci obiektowej i strumieniowej;
* Rekurencji na przykładzie, gdy program opisuje program, typ zawiera typ, itp.
* Iteracji wyrażonej jako instrukcja powtarzania lub kwerendy dla populacji w kolekcji;
* Wyjątków – obsługi zdarzeń wymagających przerwania aktualnej sekwencji instrukcji
* Modelu MVVM (Model-View-ViewModel), a więc warstwowej budowy aplikacji, w której oddzielono warstwę prezentacji od warstwy danych warstwą modelu widoku z wykorzystaniem powiązań luźnych (ang. data bindings).

# Wymagania

1. Z wykorzystaniem mechanizmu refleksji analizowanie zawartości wybranej .dll i zapisanie możliwie dużo informacji do utworzonego modelu obiektowego;
* Serializacja modelu obiektowego w pliku xml
* Deserializacja pliku xml do modelu obiektowego
* Wyświetlenie zawartości modelu użytkownikowi z wykorzystaniem technologii WPF
* Wyświetlenie zawartości pliku XML z wykorzystaniem transformaty XML (style sheet xslt)
* Wszystkie ważniejsze funkcje muszą być testowane z wykorzystaniem Unit Tests
* Wymaga się zastosowania architektury warstwowej z wykorzystaniem modelu MVVM.

# Funkcje
1. Odczyt matadanych ze wskazanego komponentu .dll/.exe
* Zapis do pliku .xml odczytanych metadanych dla komponentu .dll/exe
* Odczyt pliku .xml zawierającego metadane dla komponentu .dll/exe
* Wyświetlenie metadanych w postaci hierarchicznej z wykorzystaniem drzewa pokazującego wzajemne zależności konstrukcji językowych,

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

## Lista przykładów

* [TP](https://github.com/mpostol/TP) - projekt open source na GitHub;
* [Develop UWP apps](https://developer.microsoft.com/en-us/windows/develop) - How-to articles for UWP apps (Universal Windows apps) on Windows 10. Instructions and code examples for all kinds of tasks, such as using geolocation services, transferring data over a network, and porting apps to Windows 10. (For individual classes, methods, properties and other APIs, see the [API reference](https://msdn.microsoft.com/library/windows/apps/bg124285.aspx).)

* [Presenting working data outside the application](http://code.msdn.microsoft.com/Presenting-working-data-2760d1c6): This sample demonstrates how to save working data in a file containing `xml` document, which next can be directly presented for example in MS Word editor or Internet Explorer translated using a style sheet. It is simplest way to detach the document content from its presentation.

* [Reflector](http://code.msdn.microsoft.com/Reflector-39a3a670): The sample illustrates using `System.Reflection` to run queries over components from `System.Xml.Linq`. The by-product is an HTML document outlining the public APIs for a given assembly, in this case `System.Xml.Linq.dll`.

* [TreeView SelectedItem TwoWay MVVM plus expand to selected and close all others](https://code.msdn.microsoft.com/TreeView-SelectedItem-13985bd1): This sample shows how to TWO-WAY BIND to the `SelectedItem` property of a `Silverlight` (or `WPF`) `TreeView`! It also shows how to expand nodes down to the selected item, and collapse all other nodes (to keep it tidy).

# Zaliczenie

Zaliczenie wymaga przedstawienia i omówienia wyników pracy w następujących etapach:

* Etap 1: Interfejs użytkownika (GUI)
* Etap 2: implementacja logiki aplikacji
* Etap 3: działający program

Każdy z etapów będzie oceniany osobno.
