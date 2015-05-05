This project is for the development of the base programming framework for collection system modeling tools used by BES-ASM, and includes an API for facilitating hydraulic, hydrologic, and water quality modeling.  This framework is built around Microsoft's .NET Framework 3.5.

Project documentation is contained in the [wiki](http://code.google.com/p/besasm-prgfx/wiki/GettingStarted).

As of 12/9/09 the precise scope of the work is still under discussion. Some context has been established:
  * User interface standards and patterns, and user-facing widgets are **not** part of the work at this time.
  * Data and class management _are_ part of the work, including:
    * Class and data dictionary
    * Data persistence framework
  * Common functions (such as system tracing) that are currently present in many programs will be factored out and consolidated; their use will be implemented as each program comes under major revision.

The framework will be first implemented for data subjects that are not currently handled by the legacy tools. Some likely subjects are:

  * Inflow Controls
  * Condition Data
  * Support for the upcoming Stormwater System Master Plan -- which will require unprecedented data subjects.