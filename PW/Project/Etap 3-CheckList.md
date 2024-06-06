# Project Stage 3 Checklist

- [ ] **Starting point**
  - [ ] program text is in C#
  - [ ] all UT are green
  - [ ] the program behaves as expected (intermediate approval test)
- [ ] **Data Layer**
  - [ ] responsibility of this layer is
    - [ ] to represent boundaries of the movement rectangle if necessary
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
  - [ ] Unit Test - layers are tested independently using dependency injection (additional framework is not allowed)
  - [ ] Mock (external package) must not be used for testing purposes
  