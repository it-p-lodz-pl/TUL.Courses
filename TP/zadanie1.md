## Cel

* wykorzystanie kolekcji platformy .NET w przyk�adowym zastosowaniu:
  * katalogowanie, np. katalog produkt�w, wykaz klient�w,
  * rejestracja zdarze�, np. lista faktur,
  * opis stanu, np. stan biblioteki, stan magazynu.
* definiowanie API dla biblioteki (publiczne deklaracje)
* u�ycie Dependency Injection, gdzie decyzja o wyborze zachowania jest odroczona do czasu realizacji programu

## Cz�� 1 

**a) Utw�rz projekt C# biblioteki klas, zawieraj�cy wzajemnie powi�zane klasy danych, reprezentuj�ce wybrany proces biznesowy, np. bibliotek�, sklep internetowy, magazyn, itp.**

* Klasa <code>Wykaz</code> ma reprezentowa� elementy wykazu z danymi opisuj�cymi osoby (jak: czytelnicy, klienci).
* Klasa <code>Katalog</code> ma opisywa� pozycje w s�owniku (jak: opisy ksi��ek, opisy produkt�w), przy czym:
  * Konieczne b�dzie tu okre�lenie klucza u�ywanego do dost�pu do danych (<code>string</code>, <code>int</code>, itp).
  * Nie nale�y dodawa� do tej klasy w�a�ciwo�ci typu "CzyWypozyczona", "KtoWypozyczyl", "IloscProduktow", "Cena",    
    czyli informacji, kt�re b�dzie mo�na uzyska� z innych struktur danych.
* Klasa <code>OpisStanu</code> ma opisywa� wyst�pienia odnosz�ce si� do pozycji s�ownikowych (jak: egzemplarz ksi��ki - opis ksi��ki, data zakupu; stan magazynu - produkt, jego ilo��, cena netto, stawka podatku).
* Klasa <code>Zdarzenie</code> ma opisywa� relacje wi���ce osoby oraz wyst�pienia odnosz�ce si� do pozycji s�ownikowych (jak: wypo�yczenia - kto, kt�ry egzemplarz, data wypo�yczenia, data zwrotu; faktura - kto, kiedy, kt�ry stan magazynowy produktu, ilo��, cena i stawka dla produktu).

Inne klasy mog� zosta� wprowadzone w celu normalizacji struktury danych (autorzy ksi��ek, pozycje faktur, sprzedawcy wystawiaj�cy rachunki, magazynierzy realizuj�cy operacje magazynowe).

**b) Utw�rz klas� gromadz�c� obiekty z danymi**

Je�li nie masz lepszego pomys�u, proponowana jest nazwa <code>DataContext</code>. Jej pola mog� by� publiczne, gdy� obiekt tej klasy nie b�dzie bezpo�rednio dost�pny w innych cz�ciach systemu. Przeznaczeniem tej klasy jest tylko gromadzenie danych, bez dalszych operacji na nich. Pozwala to traktowa� j� jako zast�pnik bazy danych, lub dokument w pami�ci przechowuj�cy w jednym obiekcie wszystkie dane systemu. Przy okazji uzyskuje si� obiekt, kt�ry mo�na p�niej serializowa� i deserializowa�, wygodnie realizuj�c operacje np. zapisu dokumentu do pliku i ponowne odczytanie dokumentu z pliku.

Pola klasy gromadz�cej obiekty z danymi zadeklaruj w postaci kolekcji:

* Dane z informacjami o elementach wykazu nale�y przechowywa� w obiekcie <code>List<Wykaz></code>.
* Pozycje s�ownikowe nale�y przechowywa� w obiekcie <code>Dictionary<_Klucz_, Katalog></code>.
* Zdarzenia ��cz�ce opisy stanu z elementami wykazu nale�y przechowywa� o obiekcie klasy <code>ObservableCollection<Zdarzenie></code>.
* Opisy stanu mo�na przechowywa� w obiektach dowolnej z powy�szych kolekcji, np. <code>List<OpiStanu></code> lub <code>ObservableCollection<OpiStanu></code>.

**d) Dodaj klas� zarz�dzaj�c� obiektami danych**

Je�li nie masz lepszego pomys�u, proponowana jest nazwa <code>DataRepository</code>. Dodaj w niej pole prywatne typu <code>DataContext</code>. Klasa zarz�dzaj�ca obiektami danych b�dzie rozbudowana w dalszej cz�ci zadania.

## Cz�� 2

Nale�y przygotowa� API do wype�niania kolekcji przyk�adowymi danymi. Mo�na to zrealizowa� wprowadzaj�c klas� abstrakcyjn� (*abstract class*) lub interfejs (*interface*).
R�ne implementacje tego abstrakcyjnego typu b�d� p�niej wykorzystane w dalszych cz�ciach zadania (poni�ej).

U�ycie konkretnej implementacji ma by� realizowane na zasadzie wzorca _Wstrzykiwania Zale�no�ci (Dependency Injection, DI)_,
gdzie odpowiedzialno�� za kontrol� wybranych czynno�ci przenoszona jest na zewn�trz obiektu a wyboru dokonuje si� w trakcie realizacji programu.

- - -
Celem zastosowania wspomnianego wzorca jest aby klasa przechowuj�ca dane nie decydowa�a o typie u�ywanego obiektu (np. jednej, wybranej klasy <code>Wypelnianie{...}</code>) i nie tworzy�a go samodzielnie w konstruktorze, tylko �eby decydowa� o tym kod tworz�cy i konfiguruj�cy obiekty aplikacji.
Taki spos�b zarz�dzania zale�no�ciami mi�dzy obiektami pozwala na pozbycie si� �cis�ych zale�no�ci pomi�dzy cz�ciami systemu. Pozwala to tak�e �atwiej (lub w og�le) testowa� cz�ci niezale�nie, w oderwaniu od ca�o�ci systemu.

Do przejrzenia:

* Wikipedia (EN + przyk�ady): [Dependency Injection](https://en.wikipedia.org/wiki/Dependency_injection), Wikipedia (PL): [Wstrzykiwanie zale�no�ci](https://pl.wikipedia.org/wiki/Wstrzykiwanie_zale%C5%BCno%C5%9Bci)  
* Przyk�ad: [TP / DependencyInjection](https://github.com/mpostol/TP/tree/master/DependencyInjection)  
* �r�d�o: [Inversion of Control Containers and the Dependency Injection pattern, Martin Fowler](http://www.martinfowler.com/articles/injection.html)  
* �r�d�o: [Dependency Injection in .NET, Mark Seemann](https://www.manning.com/books/dependency-injection-in-dot-net)

Rozwi�zania _DI_ oparte s� o przekazywanie z zewn�trz do wybranego obiektu innych obiekt�w, kt�rych u�ywa on do realizacji swoich zada�.  
Typowe sposoby realizacji _DI_ to:

* Constructor Injection - obiekt przekazywany jest jako wymagany parametr konstruktora klasy,
* Method Injection - obiekt przekazywany jest jako parametr wywo�ania metody,
* Setter Injection / Property Injection - obiekt wpisywany jest do pola lub w�a�ciwo�ci klasy,
* Dependency Injection Container - technologie wykorzystuj�ce powy�sze sposoby realizacji, gdzie specyfikacj� zale�no�ci okre�la si� poprzez atrybuty lub konfiguracj� - a realizacj� zale�no�ci wykonuj� biblioteki przy uruchamianiu aplikacji.  
  Przyk�ady: Castle Windsor, StructureMap, Ninject, Spring.NET, Autofac, Unity, Managed Extensibility Framework (MEF), Prism Library.

Alternatywne do _DI_ wzorce - patrz np. [Factories, Service Locators, and Dependency Injection](https://msdn.microsoft.com/en-us/library/dn178469(v=pandp.30).aspx):

* Factory Method, Abstract Factory, Simple Factory - zamiast u�ywa� s�owa kluczowego <code>new</code>, tworzenie obiektu deleguje si� do fabryki obiekt�w,
* Service Locator - klasy us�ug s� rejestrowane przy starcie, a nast�pnie wyszukiwane podaj�c potrzebny typ obiektu (jest uwa�any czasem jako _antywzorzec_).
- - -

#### Wstrzykiwanie zale�no�ci

W celu prostej realizacji _DI_ mo�na doda� w kodzie klasy przechowuj�cej dane konstruktor z parametrem okre�laj�cym typ ��danego interfejsu (lub klasy abstrakcyjnej) i zapami�tywa� wskazany obiekt w polu prywatnym do dalszego u�ytku.

Alternatywnie mo�na utworzy� w klasie w�a�ciwo�� _(property)_ ��danego interfejsu (lub klasy abstrakcyjnej), oraz ustawia� warto�� tej w�a�ciwo�ci po utworzeniu obiektu klasy przechowuj�cej dane.

**d) Dodaj typ abstrakcyjny definiuj�cy API pozwalaj�ce wype�nia� kolekcje danymi**

* W klasie <code>DataRepository</code> dodaj konstruktor z odpowiednim parametrem lub dodaj w�a�ciwo�� (property, z sekcj� <code>set</code>, ewentualnie <code>private get</code>).
* Przygotuj klas� np. <code>WypelnianieStalymi</code>, kt�ra b�dzie umieszcza� w ka�dej kolekcji sta��, niewielk� ilo�� obiekt�w o ustalonych warto�ciach.
* Dodaj kod konfiguruj�cy komponenty aplikacji przed uruchomieniem, kt�ry b�dzie przekazywa� do klasy <code>DataRepository</code> obiekt klasy <code>WypelnianieStalymi</code>.
* Klasa <code>DataRepository</code> powinna wykorzysta� przekazany obiekt - w swoim konstruktorze lub w sekcji <code>set</code> w�a�ciwo�ci - aby wype�ni� kolekcje zawarte w <code>DataContext</code> przyk�adowymi danymi.

## Cz�� 3

**e) Rozbuduj klas� zarz�dzaj�c� obiektami danych**

W klasie <code>DataRepository</code> zaimplementuj zbi�r metod typu C.R.U.D. (Create, Read, Update, Delete) do obs�ugi obiekt�w danych, dla ka�dej kolekcji z klasy <code>DataContext</code>:

* (_Add_) Dodawanie nowych danych do kolekcji
* (_Get_) Odczyt pojedynczych obiekt�w, np. na podstawie identyfikatora lub pozycji w kolekcji
* (_GetAll_) Odczyt wszystkich obiekt�w z kolekcji
* (_Update_) Aktualizacja danych w kolekcji - opcjonalnie, podaj�c obiekt lub pozycj� w kolekcji
* (_Delete_) Usuwanie wskazanych danych z kolekcji - podaj�c obiekt lub pozycj� w kolekcji

_**Do ka�dej metody powinny by� napisane testy jednostkowe sprawdzaj�ce poprawno�� jej dzia�ania (!)**_

## Cz�� 4

**f) Utw�rz klas� realizuj�c� logik� dzia�ania aplikacji**

Je�li nie masz lepszego pomys�u, proponowana jest nazwa <code>DataService</code>.

Zapewnij na zasadzie _DI_ przekazanie do klasy logiki aplikacji obiektu klasy zarz�dzaj�cej danymi <code>DataRepository</code>.  
Upewnij si�, �e przekazany obiekt b�dzie zapami�tany w polu prywatnym klasy (aby u�ywa� tego obiektu p�niej tylko z poziomu klasy logiki aplikacji).

**g) Wprowad� mechanizmy przetwarzania przechowywanych danych:**

* Wy�wietlanie danych z przekazanej jako parametr kolekcji (pozycje katalogu, opisy stanu, elementy wykazu, zdarzenia)
* Wy�wietlanie danych przekazanej kolekcji w postaci powi�zanej, to znaczy:
  * zaczynaj�c od element�w wykazu (np. czytelnicy, klienci),
  * za nimi zdarzenia odpowiadaj�ce kolejnym elementom wykazu (np. wypo�yczenia ksi��ek, faktury),
  * kt�re przechodz�c przez opisy stanu b�d� indentyfikowa� pozycje katalogu (np. wypo�yczone ksi��ki, zakupione towary).
* Operacje modyfikacji danych (dodaj zdarzenie na podstawie elementu wykazu i opisu stanu, usu�, itp.)
  * niekt�re operacje b�d� wprost przekazywane do <code>DataRepository</code>
  * niekt�re b�d� wymaga� dodatkowych operacji (tworzenie obiekt�w, wyszukiwanie obiekt�w, itp.)
* Filtrowanie lub wyszukiwanie danych (zwracanie obiekt�w spe�niaj�cych za�o�one kryterium).

**h) Dodaj obs�ug� zdarze� generowanych przez ObservableCollection, z wy�wietlaniem informacji zmianie jej zawarto�ci (dodawanie do niej i usuwanie z niej obiekt�w).**

## Cz�� 5

**i) Utw�rz inn� implementacj� wype�niania kolekcji danymi i wykorzystaj j� do test�w wydajno�ci**

* Kolejna implementacja wype�niania kolekcji danymi powinna umieszcza� w kolekcjach obiekty w inny spos�b ni� poprzednia - opisana w punkcie **d)**.  
  Jednak nadal powinno to by� polimorficznie zgodne z ustalonym poprzednio API, czyli podmiana implementacji powinna wymaga� minimalnych zmian w aplikacji.
* Przyk�adowo mo�e to by� zrealizowane poprzez:
  * odczyt danych z przygotowanego pliku tekstowego,
  * deserializacj� danych w formacie JSON, XML, itp.
  * odczyt do pami�ci i zamiana na obiekty informacji z bazy danych SQL,
  * tworzenie obiekt�w o losowych warto�ciach.
* Sprawd� poprawno�� rozwi�zania - tworz�c testy jednostkowe.
* Sprawd� wydajno�� rozwi�zania - np. tworz�c testy jednostkowe pod k�tem wydajno�ci i wype�niaj�c przy tym kolekcje du�� ilo�ci� losowych danych (dziesi�tki i setki tysi�cy obiekt�w).  
  Por�wnaj dzia�anie w kilku punktach odniesienia, np. przy logarytmicznie rosn�cej ilo�ci obiekt�w.

## Diagramy UML

<a target="_blank" href="http://ftims.edu.p.lodz.pl/pluginfile.php/77273/mod_page/content/2/zadanie1-DataService-i-DataRepository.png">
<img src="http://ftims.edu.p.lodz.pl/pluginfile.php/77273/mod_page/content/2/zadanie1-DataService-i-DataRepository.png" alt="DataService i DataRepository" title="DataService i DataRepository" width="262px" height="183px"></a>
 &nbsp;
<a target="_blank" href="http://ftims.edu.p.lodz.pl/pluginfile.php/77273/mod_page/content/2/zadanie1-DataRepository-i-wypelnianie-danymi.png">
<img src="http://ftims.edu.p.lodz.pl/pluginfile.php/77273/mod_page/content/2/zadanie1-DataRepository-i-wypelnianie-danymi.png" alt="DataRepository i wype�nianie danymi" title="DataRepository i wype�nianie danymi" width="244px" height="183px"></a>
