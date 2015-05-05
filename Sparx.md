# Introduction #

Sparx EA (or just EA) provides a modest cost / rich function software design and documentation tool. These wiki pages provide an introduction to the structure of the BES-ASM EA structure and some suggestions about how to use the tool.

Documentation, white papers and guidance material is available from the Sparx web site:  http://www.sparxsystems.com

ASM Cookbook pages are located here:

  * [Using EA for ASM](SparxAtASM.md)
  * [Testing EA Version Control](TestingEAVersionControl.md)

# BES-ASM EA Project Structure #

## Enterprise Architect Structure ##

  * **Design Model** (include object models and data models here)
  * **Deployment Model** _(version control this level)_: describes the way we deploy the framework and applications, as well as how they are updated as changes from iteration come into play

Here is our initial project structure. This represents the items that we think will be useful to project teams.

![http://wiki.besasm-prgfx.googlecode.com/hg/Images/EAStructure01.png](http://wiki.besasm-prgfx.googlecode.com/hg/Images/EAStructure01.png)

| **Model** | **Purpose** |
|:----------|:------------|
| [Architectual and Process Model](Sparx#Architectural_and_Process_Model.md) | Big Picture concepts |
| [Use Case Model](Sparx#Use_Case_Model.md) | Specific Use Cases and associated diagrams |
| [Design Model](Sparx#Design_Model.md) | Detailed designs; classes and databases |
| [Implementation Model](Sparx#Implementation_Model.md) | Physical organization |

## Architectural and Process Model ##

_(version control this level)_

Descriptions of the high-level functionality of the entire BES-ASM applications system and the relationships of the projects to each other and the programming framework (besasm-prgfx); generally has ties to the General non-functional requirements (see below in Requirements under the Use Case Model).

The Architectual model doesn't have any content, as of 1/20/10.

## Use Case Model ##

  * Actors _(version control this level)_: A list of external entities or systems interacting with the systems being developed
  * Requirements: Things the users expect from an application in order for it to be considered "working."  These usually come directly from the users. See [Working with requirements](WorkingWithRequirements.md).
    * Functional: Specific functionality to be implemented (what the application does; more implementation-oriented).  Divide this into sections for each project.  Also designate an "unassigned" section for collation into another unnamed project if certain requirements do not fit into an existing project.
      * Project\_A _(version control this level)_
      * Project\_B
      * Project\_n
      * Unassigned
    * Non-Functional: Generalized qualities of the application (what the application is; more oriented to what the user thinks of the application and its place in their work, or to what the architect thinks of its place in the development environment).  Divide this into sections for each project.  Also designate a "general" section for common non-functional requirements applications (as applicable) should have.
      * Project\_A _(version control this level)_
      * Project\_B
      * Project\_n
      * General
  * Use Cases: Detailed steps of what an application does to accomplish functional requirements.  These are developed by the project team.  They can also be used to discover additional requirements that may not have been articulated by the users. See [Working with use cases](WorkingWithUseCases.md).  The use cases are divided by major functional area: _Cautley: should we be project specific here?_
    * Data Management -- Creation, editing and manipulation of data _(version control this level)_
    * Model Building -- Creation, editing and running of models, and capture of model results
    * System Planning -- Alternative creation, tracing, etc.

## Design Model ##

The design model describes the technical details of the software. Two particular packages are stored here:

  * Persistent Objects -- which describe database tables and their in-memory representations
  * Transient Objects -- which describe objects that are hydrated only while software is running.

  * Project\_A _(version control this level)_
  * Project\_B
  * Project\_n
  * Unassigned

## Implementation Model ##

The implementation model is currently (1/20/10) empty. It will eventually describe the servers and their arrangement on the network; how the various artifacts are deployed on the servers and so on.