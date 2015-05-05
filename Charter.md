# Introduction #

## Vision ##
Unify and enhance Asset System Management’s common programming library by reworking the existing code base to include interfaces for ESRI ArcGIS 9.x, improve both server and client-side database access, and solve existing problems with modeling processes.

## Authorities ##

### Management Sponsor - Mark Liebe ###
Sets overall goals and requirements for the product and project.

### Project Sponsor - Arnel Mandilag ###
Sets definitions of high-level project and product requirements and architecture.  Staffs the project and directly oversees the project manager.  Ensures business needs of ASM are met by the project.  Makes final decisions.

## Agent ##
David Cautley, Project Manager.  Sets fine-grain product and project requirements.  Responsible for weekly progress.

## Assumptions ##
Arc GIS 9.3, Map Info 7.0, and .NET Framework 3.5 (Visual Studio 2008) are the development platforms required for this project.

SQL Server 2005 will be used to store spatial and tabular data. Arc Server / SDE will be used to manage spatial data. Spatial data will be stored as Feature Classes.

Resources will be trained during the course of this project.

## Stakeholders ##

### Customers ###
Because this project's product is a precursor to other ASM development projects, many of the drivers for developing this framework are dependent on the needs of those projects.

### External Projects ###
The following projects are dependent on this project’s products: besasm-emgaats (Collection Systems Modeling Framework), besasm-mapforge (Mapping Tools), besasm-opus (Workflow), besasm-planforge (Systems Planning Framework), besasm-qualmod (Water Quality Modeling Framework), and besasm-toys (Analysis Tools).  The needs of these projects will generally be driving the short-term direction of this framework.

# Project Definition #
The besasm-prgfx project (ASM Programming Framework) is envisioned to be a programming interface providing common services for the External Projects named above.  By decoupling these interfaces with the actual front-ends provided in the above external projects, development efficiency, cross-training, and risk reduction will be realized to enable ASM to become more adaptable to policy changes.

## Goals ##
  * Isolate hydraulic, hydrologic, and water quality modeling functions and classes properly into a logical framework
  * Make mapping and database framework platform-agnostic to reduce risk of platform shifts
  * Improve diagnostics and reporting

## Scope ##

### In Scope ###
  * Full lifecycle development project to meet project goals (design, coding, testing, and documentation-as-needed)
  * Documentation of old processes to inform and develop new processes
  * Deployment and maintenance
  * Development training for team members of other projects not involved in this project

### Out of Scope ###
  * User interfaces

## Drivers ##
| Driver | Priority | Description |
|:-------|:---------|:------------|
| Cost | Low | No immediate cost target |
| Schedule | High | Dependent projects will need products from this project |
| Performance | Medium | Dependent projects will need minimum working features from this project |

## Resources ##
  * Dave Collins
  * Arnold Engelmann
  * Issac Gardner
  * Neil Revello

## Constraints ##

# Risks and Assets #

## Project Risks ##
  * Familiarization with current code base needed
  * Familiarization with intended classes and domain needed for team members

## Project Assets ##
  * Existing code base in besasm-legacy (http://code.google.com/p/besasm-legacy)

# Business Case #

## Benefits ##
This project is critical to ASM operations, as it seeks to improve the group’s adaptability to changing System Plan and Asset Management requirements (many of which are conceptual), as well as to improve the current risk incurred due to difficult data maintenance and modeling of certain modeling constructs.

This project will also improve knowledge of the current system by providing current documentation on theory and processes supporting many ASM analysis operations.

## Costs ##
Executing the besasm-prgfx will require involvement of a substantial number of production workers from the Modeling team.