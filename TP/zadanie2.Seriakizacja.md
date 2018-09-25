# Zadanie 3 - Serializacja i strumienie

# Cel

Celem zadania jest poznanie technologii pozwalających na zapamiętywanie i odczytywanie danych roboczych w plikach z wykorzystaniem różnych formatów (gramatyki), jak: 

* własna - dopasowana do indywidualnych potrzeb ,
* binarny - oferowany przez biblioteki systemowe,
* JSON - Java Script Object Notation,
* XML - eXtensible Markup Language,

Ten proces musi uwzględniać:

- zapis i odczyt wartości prostych, jak liczby, teksty, wartości logiczne, itp.
- zapis i odczyt relacji (referencji) w przypadku danych strukturalnych, jak klasy, kolekcje, tablice, drzewa, grafy, itd.
- kontrolę poprawności odczytywanych danych,
- możliwość przenoszenia danych pomiędzy rożnymi środowiskami programistycznymi,
- możliwość posługiwania się danymi przez człowieka - użytkownika aplikacji,
- tolerowanie możliwości zmiany wersji oprogramowania i w konsekwencji potrzeb w zakresie przechowywania i przesyłania danych.

W trakcie realizacji tego zadania poznamy wybrane implementacje technologii ogólnie zwanej serializacją. Używane implementacje procesu serializacji (patrz Lista źródeł) mają swoje wady i zalety. Poznanie tych wad i zalet pozwoli lepiej dobierać implementacje do wymagań stawianych przez użytkowników.

# Opis zadania

1. Należy opracować program konsolowy, pozwalający na zapis/odczyt do/z pliku danych z **zadania 1** dotyczącego operowania na kolekcjach. W tym celu należy wykorzystać mechanizm serializacji. 
2. Na podstawie danych **zadania 1** utworzyć przykładowe listy obiektów tworzące graf obiektów z relacjami wiele do jednego (np. wiele wypożyczeń => jedna książka).
3. Zaimplementować funkcjonalność realizującą własny mechanizm serializacji, która korzystając z dowolnego strumienia [System.IO.Stream](https://msdn.microsoft.com/en-us/library/system.io.stream.aspx) pozwoli na zapisywanie i odtworzenia obiektów opisanych w poprzednim punkcie.
4. Wykorzystując dostępną w bibliotekach funkcjonalność serializacji umożliwić zapis/odczyt do/z pliku danych opisanych powyżej w jednym z następujących formatów: binarnym, JSON lub XML. 
5. Opracować testy jednostkowe.

# Wytyczne do realizacji

## Serializacja własna. 

Przy realizacji własnego  mechanizmu serializacji warto zapoznać się z opisem zawartym w artykule [ISerializable Interface](https://msdn.microsoft.com/library/system.runtime.serialization.iserializable.aspx). Do implementacji można opracować klasę dziedzicząca po klasie bazowej [Formatter](https://msdn.microsoft.com/en-us/library/system.runtime.serialization.formatter.aspx).

## Lokalizacja funkcjonalności

W klasach `partial` można zawrzeć szczegóły implementacyjne związane z poszczególnymi formatami danych.

## Serializacja grafu

Jednym ze sposobów realizacji relacji pomiędzy obiektami są referencje. Dzięki nim możemy utworzyć dowolną strukturę zależności, a w tym: drzewa, rekurencje, itp. Przy serializacji relacji pomiędzy obiektami należy pamiętać, że referencje bezpośrednio nie mogą być zapamiętane w tworzonym strumieniu. Przy odtwarzaniu grafu istotne jest, aby nie dublować obiektów w przypadku relacji wile do jednego. Do serializacji referencji proszę rozważyć użycie klasy [ObjectIDGenerator](https://msdn.microsoft.com/en-us/library/system.runtime.serialization.objectidgenerator.aspx)

W przypadku wykorzystania istniejącej biblioteki użytkownik może mieć tylko pośredni (nie może modyfikować kodu programu) wpływ na zachowanie w tym aspekcie funkcji serializatora poprzez odpowiednie parametry. Poniżej podano dwa przykłady klas, gdzie taka parametryzacja jest konieczna.

## [DataContractSerializer Class](https://msdn.microsoft.com/library/system.runtime.serialization.datacontractserializer.aspx)

W tej klasie jeden z konstruktorów (patrz przykład poniżej) ma parametr `preserveObjectReferences`, który można wykorzystać do sterowania sposobem zapisywania referencji obiektu. **W przypadku wybrania wartości `true` tracimy na kompatybilności ze standardem XML**.

```
public DataContractSerializer(
	Type type,
	IEnumerable<Type> knownTypes,
	int maxItemsInObjectGraph,
	bool ignoreExtensionDataObject,
	bool preserveObjectReferences,
	IDataContractSurrogate dataContractSurrogate,
	DataContractResolver dataContractResolver
)
``` 

Przykład użycia tego konstruktora można znaleźć w artykule [Preserving Object Reference in WCF](https://blogs.msdn.microsoft.com/sowmy/2006/03/26/preserving-object-reference-in-wcf/)

## [Json.NET](http://www.newtonsoft.com/json/help/html/Introduction.htm)

Zachowanie tego serializatora w kontekście zapisywania i odtwarzania referencji obiektów zostało opisane w artykule [Preserving Object References](http://www.newtonsoft.com/json/help/html/PreserveObjectReferences.htm)

Przykład kodu realizującego serializację:

```
string json = JsonConvert.SerializeObject(people, Formatting.Indented, new JsonSerializerSettings{ PreserveReferencesHandling = PreserveReferencesHandling.Objects });
```

#Lista źródeł

## Wprowadzenie
* [Serialization in the .NET Framework](https://msdn.microsoft.com/en-US/library/7ay27kt9.aspx)
* [How to: Serialize and Deserialize JSON Data](https://msdn.microsoft.com/library/bb412179.aspx)
* [The JavaScript Object Notation (JSON) Data Interchange Format, Request for Comments:7159, ](https://tools.ietf.org/rfc/rfc7159.txt)

## Użyteczne API 
* [ISerializable Interface](https://msdn.microsoft.com/library/system.runtime.serialization.iserializable.aspx)
* [BinaryFormatter Class](https://msdn.microsoft.com/library/system.runtime.serialization.formatters.binary.binaryformatter.aspx)
* [XmlSerializer Class](https://msdn.microsoft.com/library/system.xml.serialization.xmlserializer.aspx)
* [DataContractSerializer Class](https://msdn.microsoft.com/library/system.runtime.serialization.datacontractserializer.aspx)
* [NetDataContractSerializer Class](https://msdn.microsoft.com/library/system.runtime.serialization.netdatacontractserializer.aspx)
* [SoapFormatter Class](https://msdn.microsoft.com/library/system.runtime.serialization.formatters.soap.soapformatter.aspx)
* [DataContractJsonSerializer Class](https://msdn.microsoft.com/library/system.runtime.serialization.json.datacontractjsonserializer.aspx)
* [Json.NET](https://github.com/JamesNK/Newtonsoft.Json)

# Zaliczenie

## Realizacja zakresu - minimalne wymagania

Aby przystąpić do zaliczenia zadania muszą być spełnione wymagania:

1. Brak błędów kompilatora po wyciągnięciu nowej kopii kodu źródłowego z repozytorium,
2. Pozytywne wyniki wymaganych testów jednostkowych,
3. Program powinien tworzyć pliki dla każdego z formatów osobno.

## Osiągnięcie celu - przykładowe zagadnienia

W trakcie zaliczenia następuje sprawdzenie znajomości następujących pojęć i związków między nimi:

- plik, 
- strumień, 
- obiekt,
- klasa,
- referencja,
- relacja,  
- typ, typ generyczny, typ referencyjny, typ wartościowy, 
- stan obiektu

W trakcie zaliczenia mogą być dyskutowane następujące zagadnienia: 

- na czym polega serializacja i skąd ta nazwa,
- jakie są alternatywne metody dla serializacji,
- kiedy serializacja jest potrzebna,
- jak sterować procesem serializacji,
- serializacja danych strukturalnych,
- serializacja danych rekurencyjnych,