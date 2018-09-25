## Cel

* wykorzystanie kolekcji platformy .NET w przyk³adowym zastosowaniu:
  * katalogowanie, np. katalog produktów, wykaz klientów,
  * rejestracja zdarzeñ, np. lista faktur,
  * opis stanu, np. stan biblioteki, stan magazynu.
* definiowanie API dla biblioteki (publiczne deklaracje)
* u¿ycie Dependency Injection, gdzie decyzja o wyborze zachowania jest odroczona do czasu realizacji programu

## Czêœæ 1 

**a) Utwórz projekt C# biblioteki klas, zawieraj¹cy wzajemnie powi¹zane klasy danych, reprezentuj¹ce wybrany proces biznesowy, np. bibliotekê, sklep internetowy, magazyn, itp.**

* Klasa <code>Wykaz</code> ma reprezentowaæ elementy wykazu z danymi opisuj¹cymi osoby (jak: czytelnicy, klienci).
* Klasa <code>Katalog</code> ma opisywaæ pozycje w s³owniku (jak: opisy ksi¹¿ek, opisy produktów), przy czym:
  * Konieczne bêdzie tu okreœlenie klucza u¿ywanego do dostêpu do danych (<code>string</code>, <code>int</code>, itp).
  * Nie nale¿y dodawaæ do tej klasy w³aœciwoœci typu "CzyWypozyczona", "KtoWypozyczyl", "IloscProduktow", "Cena",    
    czyli informacji, które bêdzie mo¿na uzyskaæ z innych struktur danych.
* Klasa <code>OpisStanu</code> ma opisywaæ wyst¹pienia odnosz¹ce siê do pozycji s³ownikowych (jak: egzemplarz ksi¹¿ki - opis ksi¹¿ki, data zakupu; stan magazynu - produkt, jego iloœæ, cena netto, stawka podatku).
* Klasa <code>Zdarzenie</code> ma opisywaæ relacje wi¹¿¹ce osoby oraz wyst¹pienia odnosz¹ce siê do pozycji s³ownikowych (jak: wypo¿yczenia - kto, który egzemplarz, data wypo¿yczenia, data zwrotu; faktura - kto, kiedy, który stan magazynowy produktu, iloœæ, cena i stawka dla produktu).

Inne klasy mog¹ zostaæ wprowadzone w celu normalizacji struktury danych (autorzy ksi¹¿ek, pozycje faktur, sprzedawcy wystawiaj¹cy rachunki, magazynierzy realizuj¹cy operacje magazynowe).

**b) Utwórz klasê gromadz¹c¹ obiekty z danymi**

Jeœli nie masz lepszego pomys³u, proponowana jest nazwa <code>DataContext</code>. Jej pola mog¹ byæ publiczne, gdy¿ obiekt tej klasy nie bêdzie bezpoœrednio dostêpny w innych czêœciach systemu. Przeznaczeniem tej klasy jest tylko gromadzenie danych, bez dalszych operacji na nich. Pozwala to traktowaæ j¹ jako zastêpnik bazy danych, lub dokument w pamiêci przechowuj¹cy w jednym obiekcie wszystkie dane systemu. Przy okazji uzyskuje siê obiekt, który mo¿na póŸniej serializowaæ i deserializowaæ, wygodnie realizuj¹c operacje np. zapisu dokumentu do pliku i ponowne odczytanie dokumentu z pliku.

Pola klasy gromadz¹cej obiekty z danymi zadeklaruj w postaci kolekcji:

* Dane z informacjami o elementach wykazu nale¿y przechowywaæ w obiekcie <code>List<Wykaz></code>.
* Pozycje s³ownikowe nale¿y przechowywaæ w obiekcie <code>Dictionary<_Klucz_, Katalog></code>.
* Zdarzenia ³¹cz¹ce opisy stanu z elementami wykazu nale¿y przechowywaæ o obiekcie klasy <code>ObservableCollection<Zdarzenie></code>.
* Opisy stanu mo¿na przechowywaæ w obiektach dowolnej z powy¿szych kolekcji, np. <code>List<OpiStanu></code> lub <code>ObservableCollection<OpiStanu></code>.

**d) Dodaj klasê zarz¹dzaj¹c¹ obiektami danych**

Jeœli nie masz lepszego pomys³u, proponowana jest nazwa <code>DataRepository</code>. Dodaj w niej pole prywatne typu <code>DataContext</code>. Klasa zarz¹dzaj¹ca obiektami danych bêdzie rozbudowana w dalszej czêœci zadania.

## Czêœæ 2

Nale¿y przygotowaæ API do wype³niania kolekcji przyk³adowymi danymi. Mo¿na to zrealizowaæ wprowadzaj¹c klasê abstrakcyjn¹ (*abstract class*) lub interfejs (*interface*).
Ró¿ne implementacje tego abstrakcyjnego typu bêd¹ póŸniej wykorzystane w dalszych czêœciach zadania (poni¿ej).

U¿ycie konkretnej implementacji ma byæ realizowane na zasadzie wzorca _Wstrzykiwania Zale¿noœci (Dependency Injection, DI)_,
gdzie odpowiedzialnoœæ za kontrolê wybranych czynnoœci przenoszona jest na zewn¹trz obiektu a wyboru dokonuje siê w trakcie realizacji programu.

- - -
Celem zastosowania wspomnianego wzorca jest aby klasa przechowuj¹ca dane nie decydowa³a o typie u¿ywanego obiektu (np. jednej, wybranej klasy <code>Wypelnianie{...}</code>) i nie tworzy³a go samodzielnie w konstruktorze, tylko ¿eby decydowa³ o tym kod tworz¹cy i konfiguruj¹cy obiekty aplikacji.
Taki sposób zarz¹dzania zale¿noœciami miêdzy obiektami pozwala na pozbycie siê œcis³ych zale¿noœci pomiêdzy czêœciami systemu. Pozwala to tak¿e ³atwiej (lub w ogóle) testowaæ czêœci niezale¿nie, w oderwaniu od ca³oœci systemu.

Do przejrzenia:

* Wikipedia (EN + przyk³ady): [Dependency Injection](https://en.wikipedia.org/wiki/Dependency_injection), Wikipedia (PL): [Wstrzykiwanie zale¿noœci](https://pl.wikipedia.org/wiki/Wstrzykiwanie_zale%C5%BCno%C5%9Bci)  
* Przyk³ad: [TP / DependencyInjection](https://github.com/mpostol/TP/tree/master/DependencyInjection)  
* ród³o: [Inversion of Control Containers and the Dependency Injection pattern, Martin Fowler](http://www.martinfowler.com/articles/injection.html)  
* ród³o: [Dependency Injection in .NET, Mark Seemann](https://www.manning.com/books/dependency-injection-in-dot-net)

Rozwi¹zania _DI_ oparte s¹ o przekazywanie z zewn¹trz do wybranego obiektu innych obiektów, których u¿ywa on do realizacji swoich zadañ.  
Typowe sposoby realizacji _DI_ to:

* Constructor Injection - obiekt przekazywany jest jako wymagany parametr konstruktora klasy,
* Method Injection - obiekt przekazywany jest jako parametr wywo³ania metody,
* Setter Injection / Property Injection - obiekt wpisywany jest do pola lub w³aœciwoœci klasy,
* Dependency Injection Container - technologie wykorzystuj¹ce powy¿sze sposoby realizacji, gdzie specyfikacjê zale¿noœci okreœla siê poprzez atrybuty lub konfiguracjê - a realizacjê zale¿noœci wykonuj¹ biblioteki przy uruchamianiu aplikacji.  
  Przyk³ady: Castle Windsor, StructureMap, Ninject, Spring.NET, Autofac, Unity, Managed Extensibility Framework (MEF), Prism Library.

Alternatywne do _DI_ wzorce - patrz np. [Factories, Service Locators, and Dependency Injection](https://msdn.microsoft.com/en-us/library/dn178469(v=pandp.30).aspx):

* Factory Method, Abstract Factory, Simple Factory - zamiast u¿ywaæ s³owa kluczowego <code>new</code>, tworzenie obiektu deleguje siê do fabryki obiektów,
* Service Locator - klasy us³ug s¹ rejestrowane przy starcie, a nastêpnie wyszukiwane podaj¹c potrzebny typ obiektu (jest uwa¿any czasem jako _antywzorzec_).
- - -

#### Wstrzykiwanie zale¿noœci

W celu prostej realizacji _DI_ mo¿na dodaæ w kodzie klasy przechowuj¹cej dane konstruktor z parametrem okreœlaj¹cym typ ¿¹danego interfejsu (lub klasy abstrakcyjnej) i zapamiêtywaæ wskazany obiekt w polu prywatnym do dalszego u¿ytku.

Alternatywnie mo¿na utworzyæ w klasie w³aœciwoœæ _(property)_ ¿¹danego interfejsu (lub klasy abstrakcyjnej), oraz ustawiaæ wartoœæ tej w³aœciwoœci po utworzeniu obiektu klasy przechowuj¹cej dane.

**d) Dodaj typ abstrakcyjny definiuj¹cy API pozwalaj¹ce wype³niaæ kolekcje danymi**

* W klasie <code>DataRepository</code> dodaj konstruktor z odpowiednim parametrem lub dodaj w³aœciwoœæ (property, z sekcj¹ <code>set</code>, ewentualnie <code>private get</code>).
* Przygotuj klasê np. <code>WypelnianieStalymi</code>, która bêdzie umieszczaæ w ka¿dej kolekcji sta³¹, niewielk¹ iloœæ obiektów o ustalonych wartoœciach.
* Dodaj kod konfiguruj¹cy komponenty aplikacji przed uruchomieniem, który bêdzie przekazywaæ do klasy <code>DataRepository</code> obiekt klasy <code>WypelnianieStalymi</code>.
* Klasa <code>DataRepository</code> powinna wykorzystaæ przekazany obiekt - w swoim konstruktorze lub w sekcji <code>set</code> w³aœciwoœci - aby wype³niæ kolekcje zawarte w <code>DataContext</code> przyk³adowymi danymi.

## Czêœæ 3

**e) Rozbuduj klasê zarz¹dzaj¹c¹ obiektami danych**

W klasie <code>DataRepository</code> zaimplementuj zbiór metod typu C.R.U.D. (Create, Read, Update, Delete) do obs³ugi obiektów danych, dla ka¿dej kolekcji z klasy <code>DataContext</code>:

* (_Add_) Dodawanie nowych danych do kolekcji
* (_Get_) Odczyt pojedynczych obiektów, np. na podstawie identyfikatora lub pozycji w kolekcji
* (_GetAll_) Odczyt wszystkich obiektów z kolekcji
* (_Update_) Aktualizacja danych w kolekcji - opcjonalnie, podaj¹c obiekt lub pozycjê w kolekcji
* (_Delete_) Usuwanie wskazanych danych z kolekcji - podaj¹c obiekt lub pozycjê w kolekcji

_**Do ka¿dej metody powinny byæ napisane testy jednostkowe sprawdzaj¹ce poprawnoœæ jej dzia³ania (!)**_

## Czêœæ 4

**f) Utwórz klasê realizuj¹c¹ logikê dzia³ania aplikacji**

Jeœli nie masz lepszego pomys³u, proponowana jest nazwa <code>DataService</code>.

Zapewnij na zasadzie _DI_ przekazanie do klasy logiki aplikacji obiektu klasy zarz¹dzaj¹cej danymi <code>DataRepository</code>.  
Upewnij siê, ¿e przekazany obiekt bêdzie zapamiêtany w polu prywatnym klasy (aby u¿ywaæ tego obiektu póŸniej tylko z poziomu klasy logiki aplikacji).

**g) WprowadŸ mechanizmy przetwarzania przechowywanych danych:**

* Wyœwietlanie danych z przekazanej jako parametr kolekcji (pozycje katalogu, opisy stanu, elementy wykazu, zdarzenia)
* Wyœwietlanie danych przekazanej kolekcji w postaci powi¹zanej, to znaczy:
  * zaczynaj¹c od elementów wykazu (np. czytelnicy, klienci),
  * za nimi zdarzenia odpowiadaj¹ce kolejnym elementom wykazu (np. wypo¿yczenia ksi¹¿ek, faktury),
  * które przechodz¹c przez opisy stanu bêd¹ indentyfikowaæ pozycje katalogu (np. wypo¿yczone ksi¹¿ki, zakupione towary).
* Operacje modyfikacji danych (dodaj zdarzenie na podstawie elementu wykazu i opisu stanu, usuñ, itp.)
  * niektóre operacje bêd¹ wprost przekazywane do <code>DataRepository</code>
  * niektóre bêd¹ wymagaæ dodatkowych operacji (tworzenie obiektów, wyszukiwanie obiektów, itp.)
* Filtrowanie lub wyszukiwanie danych (zwracanie obiektów spe³niaj¹cych za³o¿one kryterium).

**h) Dodaj obs³ugê zdarzeñ generowanych przez ObservableCollection, z wyœwietlaniem informacji zmianie jej zawartoœci (dodawanie do niej i usuwanie z niej obiektów).**

## Czêœæ 5

**i) Utwórz inn¹ implementacjê wype³niania kolekcji danymi i wykorzystaj j¹ do testów wydajnoœci**

* Kolejna implementacja wype³niania kolekcji danymi powinna umieszczaæ w kolekcjach obiekty w inny sposób ni¿ poprzednia - opisana w punkcie **d)**.  
  Jednak nadal powinno to byæ polimorficznie zgodne z ustalonym poprzednio API, czyli podmiana implementacji powinna wymagaæ minimalnych zmian w aplikacji.
* Przyk³adowo mo¿e to byæ zrealizowane poprzez:
  * odczyt danych z przygotowanego pliku tekstowego,
  * deserializacjê danych w formacie JSON, XML, itp.
  * odczyt do pamiêci i zamiana na obiekty informacji z bazy danych SQL,
  * tworzenie obiektów o losowych wartoœciach.
* SprawdŸ poprawnoœæ rozwi¹zania - tworz¹c testy jednostkowe.
* SprawdŸ wydajnoœæ rozwi¹zania - np. tworz¹c testy jednostkowe pod k¹tem wydajnoœci i wype³niaj¹c przy tym kolekcje du¿¹ iloœci¹ losowych danych (dziesi¹tki i setki tysiêcy obiektów).  
  Porównaj dzia³anie w kilku punktach odniesienia, np. przy logarytmicznie rosn¹cej iloœci obiektów.

## Diagramy UML

<a target="_blank" href="http://ftims.edu.p.lodz.pl/pluginfile.php/77273/mod_page/content/2/zadanie1-DataService-i-DataRepository.png">
<img src="http://ftims.edu.p.lodz.pl/pluginfile.php/77273/mod_page/content/2/zadanie1-DataService-i-DataRepository.png" alt="DataService i DataRepository" title="DataService i DataRepository" width="262px" height="183px"></a>
 &nbsp;
<a target="_blank" href="http://ftims.edu.p.lodz.pl/pluginfile.php/77273/mod_page/content/2/zadanie1-DataRepository-i-wypelnianie-danymi.png">
<img src="http://ftims.edu.p.lodz.pl/pluginfile.php/77273/mod_page/content/2/zadanie1-DataRepository-i-wypelnianie-danymi.png" alt="DataRepository i wype³nianie danymi" title="DataRepository i wype³nianie danymi" width="244px" height="183px"></a>
