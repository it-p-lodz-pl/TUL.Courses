# .NET application portability using containerization <!-- omit in toc -->

## Table of Contents  <!-- omit in toc -->

- [Project prerequisites](#project-prerequisites)
- [Project objectives](#project-objectives)
- [Notes](#notes)
- [Remarks](#remarks)
- [Requirements checklist](#requirements-checklist)
- [See also](#see-also)

## Project prerequisites

The student shall have basic knowledge related to software portability using the containerization concept.

## Project objectives

1. Selection of a containerization technology to guaranty the portability of the .NET command line application
1. Describe the portability scope (list of operating systems) for the selected technology
1. Describe basic requirements that the .NET command line application must be compliant with
1. Create a container for selected application - prototype with the [Address Space Prototyping Tool (asp.exe)][asp]
1. Create a description of how to use the container
1. Create a script to test the container against the selected testing data - prototype with the OPC UA Information models gathered in a public repository [OPC UA NodeSets, ModelDesign and Other Supporting Files][UA-Nodeset]

## Notes

Project must be concluded up to: to 21.08.2022

## Remarks

The main goal of the project is to prove that using containerization of an available interactive, and stateless .NET command-line application is possible. As a proof of concept, you will use existing deliverables produced as a result of the Object-Oriented Internet project (asp.exe application). If your results will be good enough I will add them to my GitHub project. Apart from others, as a reward, you will be mentioned as a contributor on the project contributors page). Hopefully, you recognize it as a good opportunity to add new skills and experience to your CV.

## Requirements checklist

- [ ] describe the problem in the context of portability of an exposing an interactive, stateless software as a web app (for example; it allows to avoid problems with shipping deliverables to an end-user)
- [ ] propose the solution on how to publish existing software (without any modifications) using container
- [ ] design a proof of concept on how to containerize the software
- [ ] test your solution using selected models from [OPC UA NodeSets, ModelDesign and Other Supporting Files][UA-Nodeset]
- [ ] based on your findings and the proof of concept prepare a document on how to get started

## See also

- [Address Space Prototyping Tool (asp.exe)][asp]
- [OPC UA NodeSets, ModelDesign and Other Supporting Files][UA-Nodeset]

[UA-Nodeset]: https://github.com/mpostol/UA-Nodeset#opc-ua-nodesets-modeldesign-and-other-supporting-files-
[asp]: https://github.com/mpostol/OPC-UA-OOI/tree/master/SemanticData/AddressSpaceComplianceTestTool#address-space-prototyping-tool-aspexe
