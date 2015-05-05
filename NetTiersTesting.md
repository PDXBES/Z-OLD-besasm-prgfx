# Introduction #

NetTiers has been successfully implemented with tabular data on SQL Server.  However, due to the way ArcSDE deals with feature classes by default (a mishmash of business tables, feature "f" tables, and shape "s" tables -- see http://webhelp.esri.com/arcgisserver/9.3/java/index.htm#geodatabases/using_t-920830601.htm), more testing with NetTiers needs to be performed.


# Details #

Initial out of the box tests show that NetTiers does not process any code because of its requirement that primary and foreign keys must be defined on the tables it is processing.  By default, the business tables that are created by ArcSDE and that house the logical data we are most interested in do not have anything more than a unique index on the OBJECTID field.

Primary keys were added to all the tables and foreign keys were added (On MST\_LINKS to MST\_NODES, USNode to Node and DSNode to Node).  ArcGIS appears to operate normally and with very rudimentary editing (field edits and object adds).  The NetTiers template was successfully run.

# Additional Testing #

  1. **Versioning** SDE feature classes must be versioned for editing using Arc (at least interactively; not sure whether ArcObjects manipulation requires this, but it seems highly likely that it would).  However, this versioning is not required if the tabular data is manipulated via SQL.  Granted, it would be of limited use if we were restricted to tabular manipulation only.  Therefore, more extensive testing with versioned SDE feature classes is recommended:
    * Observe the attendant add "a" and delete "d" tables
    * Determine the effect of using the "move-to-base" option that is required when the feature classes are initially versioned versus not using it, and whether this feature is important in future master data work

-- Arnel