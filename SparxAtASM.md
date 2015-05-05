# Usage #

http://bes-asm-code-discussion.googlegroups.com/web/Data+Modeling+in+EA.docx

# The EA Database #

EA stores its model in a documented relational database. There is also a rich programming object model that can be use externally or to extend the EA user interface. The data can be stored in Microsoft Access form (with a file extension of EAP) or in a server database such as SQL Server. The information for individual packages (folders) can be imported or exported. These capabilities provide the structure that we will use to exchange design information. EA supports several common source control packages, but unfortunately, not Mercurial.

# ASM Restrictions #

The EA database is accessed both by people who are attached to the City network and also by consultants who are not. This keeps us from using some of the simplest methods of sharing data.

We will store the database in three forms. Currency between the forms will be maintained by the BES project lead or his delegate.
  1. A full, accepted copy will be kept in SQL Server accessible to people on the City network. This will be a read-only copy.
  1. The team will determine which packages will be managed as units of work; that is, which packages can be checked out and worked on (understanding that Mercurial does not use the concept of 'check out'). These packages will be stored in Mercurial as XML files in the EA import/export schema.
  1. Each person working on EA will obtain a baseline copy of the database, make their edits, export the XML for the unit of work then commit that XML file to Mercurial.

This process parallels the way that EA works with version control software and would work if we ever build a Mercurial interface that mimics one of the EA supported VCS.

The ASM delegate will apply new, checked in versions of the XML files to the master SQL database; and periodically, export that master copy to EAP form and upload that to the downloads library here on Google Code.

Here is a link to a (very preliminary) EA database:
http://besasm-prgfx.googlecode.com/files/BES-ASM%20Domain%20V0.1.eap
Persons on the City network can use the database tools to clone the EA SQL database to their local working copy.