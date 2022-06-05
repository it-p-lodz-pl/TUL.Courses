# .NET standard deliverables portability using cloud services  <!-- omit in toc -->

## Table of Contents  <!-- omit in toc -->

- [Project prerequisites](#project-prerequisites)
- [Project objectives](#project-objectives)
- [Notes](#notes)
- [Remarks](#remarks)
- [Requirements checklist](#requirements-checklist)
- [See also](#see-also)

## Project prerequisites

The student shall have basic knowledge related to design, development and deployment of the .NET web app.

## Project objectives

1. Selection of a web technology that is suitable to provide a user interface (GUI) for an interactive, stateless .NET command line application
2. Describe the limits related to using web app to provide a graphical user interface (GUI) for an interactive, stateless .NET command line application
3. Describe basic requirements that the .NET command line application must be compliant with
4. Design web app to publish a selected application - prototype with the [Address Space Prototyping Tool (asp.exe)][asp]
5. Use the web app against the selected testing data - prototype with the OPC UA Information models gathered in a public repository [OPC UA NodeSets, ModelDesign and Other Supporting Files][UA-Nodeset]

## Notes

Project must be concluded up to: to 21.08.2022

## Remarks

The main goal of the project is to prove that hosting using a web app of an available interactive, and stateless .NET command-line application is possible. As a proof of concept, you will use existing deliverables produced as a result of the Object-Oriented Internet project (asp.exe application). If your results will be good enough I will add them to my GitHub project. Apart from others, as a reward, you will be mentioned as a contributor on the project contributors page). Hopefully, you recognize it as a good opportunity to add new skills and experience to your CV.

## Requirements checklist

- [ ] describe the problem in the context of portability of an exposing an interactive, stateless software as a web app (for example; it allows to avoid problems with shipping deliverables to an end-user)
- [ ] propose the solution on how to publish existing software (without any modifications) using a web app atop a selected cloud service, for example, Azure, Github, etc.
- [ ] design a proof of concept on how to publish the software atop of selected platform (preferable is Azure)
- [ ] test your solution using selected models from [OPC UA NodeSets, ModelDesign and Other Supporting Files][UA-Nodeset]
- [ ] based on your findings and the proof of concept prepare a document on how to get started

## See also

- [Address Space Prototyping Tool (asp.exe)][asp]
- [OPC UA NodeSets, ModelDesign and Other Supporting Files][UA-Nodeset]

[UA-Nodeset]: https://github.com/mpostol/UA-Nodeset#opc-ua-nodesets-modeldesign-and-other-supporting-files-
[asp]: https://github.com/mpostol/OPC-UA-OOI/tree/master/SemanticData/AddressSpaceComplianceTestTool#address-space-prototyping-tool-aspexe