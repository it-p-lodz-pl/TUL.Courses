# Projekt Etap 3 Lista kontrolna - programowanie współbieżne i czasu rzeczywistego

Opracowanie programu w tym etapie powinno być zrealizowane z wykorzystaniem poniższej listy kontrolnej. Skopiuj ten text do nowego _issue_ w repozytorium i użyj tej listy zadań do sprawdzenia kompletności wykonania zadania. Przed oddanie do oceny utwórz kolejne _issue_ z "pustą" listą dla prowadzącego do wykorzystania w trakcie oceny. Szczegółowy opis zadania znajduje się w osobnym dokumencie.

``` txt

# Project Stage 3 Checklist

- [ ] **to get started**
  - [ ] program text is in C#
  - [ ] Create a tag according to the [semantic versioning](https://semver.org/) compliant with the following syntax 3.a.n where: a: approach number [1..3], n: any number you like
  - [ ] all UT are green
- [ ] **Data Layer**
  - [ ] responsibility of this layer is
    - [ ] implement balls behavior as self-contained independent entities
    - [ ] save diagnostic data to a file (external package is not allowed)
  - [ ] protect balls velocity against any influence from other balls and the environmental behavior
  - [ ] balls implementation uses concurrent programming and real-time programming
  - [ ] prove that the diagnostic logging doesn't have an impact on the behavior of the balls
- [ ] **Logic Layer**
  - [ ] responsibility of this layer is to manage movement rectangle boundaries and balls interaction (collisions)
  - [ ] prove that the protection of data (balls position on the abstract table during collisions detection) integration is implemented
  - [ ] `Logic` uses only the abstract `Data` layer API
- [ ] **Presentation Layer**
  - [ ] the presentation layer has to be implemented using the MVVM programming pattern
  - [ ] responsibility of this layer is to manage the graphical user interface (GUI)
  - [ ] user => GUI interoperability must be implemented using interactive programming only
  - [ ] GUI => the user interoperability must be implemented using reactive programming only (timer is not allowed)
  - [ ] interoperability of the GUI and underlying layers must be synchronized
  - [ ] prove that the protection of data (balls position on the screen) integration is implemented
- [ ] **Testing**
  - [ ] the program behaves as expected (intermediate approval test)
  - [ ] Unit Test - layers are tested independently using dependency injection (additional framework is not allowed)
  - [ ] Mock (external package) must not be used for testing purposes
  
```
