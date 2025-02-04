# Projekt Etap 2 Lista kontrolna - programowania asynchroniczne, sekcja krytyczna

Opracowanie programu w tym etapie powinno być zrealizowane z wykorzystaniem poniższej listy kontrolnej. Skopiuj ten text do nowego _issue_ w repozytorium i użyj tej listy zadań do sprawdzenia kompletności wykonania zadania. Przed oddanie do oceny utwórz kolejne _issue_ z "pustą" listą dla prowadzącego do wykorzystania w trakcie oceny. Szczegółowy opis zadania znajduje się w osobnym dokumencie.

``` txt
# Project Stage 2 Checklist

- [ ] **to get started**
  - [ ] Create a tag according to the [semantic versioning](https://semver.org/) compliant with the following syntax 2.a.n where: a: approach number [1..3], n: any number you like
  - [ ] program text is in C#
  - [ ] all UT are green
  - [ ] the program behaves as expected
- [ ] **Data Layer**
  - [ ] responsibility of this layer is to represent balls
  - [ ] balls representation are independent and self-contained (containing or having **only** everything that is needed within itself)
  - [ ] balls implementation uses concurrent programming
- [ ] **Logic Layer**
  - [ ] responsibility of this layer is to manage the interaction of balls with rectangle boundaries and other balls (collisions)
  - [ ] prove that the protection  of data integration is implemented
  - [ ] `Logic` uses only the abstract `Data` layer API
- [ ] **Presentation Layer**
  - [ ] the presentation layer has to be implemented using the MVVM programming pattern
  - [ ] responsibility of this layer is to manage the graphical user interface (GUI)
  - [ ] user => GUI interoperability must be implemented using interactive programming only
  - [ ] GUI => the user interoperability must be implemented using reactive programming only (timer is not allowed)
  - [ ] interoperability of the GUI and underlying layers must be synchronized
- [ ] Fulfill functional requirements of the task
- [ ] **Testing**
  - [ ] Unit Test - layers are tested independently using dependency injection (external package is not allowed)
  - [ ] Mock (external package) must not be used for testing purposes
```
