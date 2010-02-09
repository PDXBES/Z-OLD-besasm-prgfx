
USE [SAMaster]
GO
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_nodes_ac_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_nodes_ac_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_nodes_ac_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the mst_nodes_ac table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_nodes_ac_Get_List

AS


				
				SELECT
					[MAPINFO_ID],
					[Node],
					[XCoord],
					[YCoord],
					[NodeType],
					[GrndElev],
					[HasSpecNode],
					[HasSpecLink],
					[GageID],
					[DME_GlobalID]
				FROM
					[dbo].[mst_nodes_ac]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_nodes_ac_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_nodes_ac_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_nodes_ac_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the mst_nodes_ac table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_nodes_ac_GetPaged
(

	@WhereClause varchar (2000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [MAPINFO_ID] int 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([MAPINFO_ID])'
				SET @SQL = @SQL + ' SELECT'
				IF @PageSize > 0
				BEGIN
					SET @SQL = @SQL + ' TOP ' + CONVERT(nvarchar, @PageUpperBound)
				END
				SET @SQL = @SQL + ' [MAPINFO_ID]'
				SET @SQL = @SQL + ' FROM [dbo].[mst_nodes_ac]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Return paged results
				SELECT O.[MAPINFO_ID], O.[Node], O.[XCoord], O.[YCoord], O.[NodeType], O.[GrndElev], O.[HasSpecNode], O.[HasSpecLink], O.[GageID], O.[DME_GlobalID]
				FROM
				    [dbo].[mst_nodes_ac] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[MAPINFO_ID] = PageIndex.[MAPINFO_ID]
				ORDER BY
				    PageIndex.IndexId
				
				-- get row count
				SET @SQL = 'SELECT COUNT(*) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[mst_nodes_ac]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_nodes_ac_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_nodes_ac_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_nodes_ac_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the mst_nodes_ac table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_nodes_ac_Insert
(

	@MapinfoId int   ,

	@Node nvarchar (6)  ,

	@Xcoord float   ,

	@Ycoord float   ,

	@NodeType nvarchar (4)  ,

	@GrndElev float   ,

	@HasSpecNode nvarchar (1)  ,

	@HasSpecLink nvarchar (1)  ,

	@GageId nvarchar (8)  ,

	@DmeGlobalId int   
)
AS


				
				INSERT INTO [dbo].[mst_nodes_ac]
					(
					[MAPINFO_ID]
					,[Node]
					,[XCoord]
					,[YCoord]
					,[NodeType]
					,[GrndElev]
					,[HasSpecNode]
					,[HasSpecLink]
					,[GageID]
					,[DME_GlobalID]
					)
				VALUES
					(
					@MapinfoId
					,@Node
					,@Xcoord
					,@Ycoord
					,@NodeType
					,@GrndElev
					,@HasSpecNode
					,@HasSpecLink
					,@GageId
					,@DmeGlobalId
					)
				
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_nodes_ac_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_nodes_ac_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_nodes_ac_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the mst_nodes_ac table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_nodes_ac_Update
(

	@MapinfoId int   ,

	@OriginalMapinfoId int   ,

	@Node nvarchar (6)  ,

	@Xcoord float   ,

	@Ycoord float   ,

	@NodeType nvarchar (4)  ,

	@GrndElev float   ,

	@HasSpecNode nvarchar (1)  ,

	@HasSpecLink nvarchar (1)  ,

	@GageId nvarchar (8)  ,

	@DmeGlobalId int   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[mst_nodes_ac]
				SET
					[MAPINFO_ID] = @MapinfoId
					,[Node] = @Node
					,[XCoord] = @Xcoord
					,[YCoord] = @Ycoord
					,[NodeType] = @NodeType
					,[GrndElev] = @GrndElev
					,[HasSpecNode] = @HasSpecNode
					,[HasSpecLink] = @HasSpecLink
					,[GageID] = @GageId
					,[DME_GlobalID] = @DmeGlobalId
				WHERE
[MAPINFO_ID] = @OriginalMapinfoId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_nodes_ac_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_nodes_ac_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_nodes_ac_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the mst_nodes_ac table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_nodes_ac_Delete
(

	@MapinfoId int   
)
AS


				DELETE FROM [dbo].[mst_nodes_ac] WITH (ROWLOCK) 
				WHERE
					[MAPINFO_ID] = @MapinfoId
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_nodes_ac_GetByNode procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_nodes_ac_GetByNode') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_nodes_ac_GetByNode
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the mst_nodes_ac table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_nodes_ac_GetByNode
(

	@Node nvarchar (6)  
)
AS


				SELECT
					[MAPINFO_ID],
					[Node],
					[XCoord],
					[YCoord],
					[NodeType],
					[GrndElev],
					[HasSpecNode],
					[HasSpecLink],
					[GageID],
					[DME_GlobalID]
				FROM
					[dbo].[mst_nodes_ac]
				WHERE
					[Node] = @Node
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_nodes_ac_GetByMapinfoId procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_nodes_ac_GetByMapinfoId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_nodes_ac_GetByMapinfoId
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the mst_nodes_ac table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_nodes_ac_GetByMapinfoId
(

	@MapinfoId int   
)
AS


				SELECT
					[MAPINFO_ID],
					[Node],
					[XCoord],
					[YCoord],
					[NodeType],
					[GrndElev],
					[HasSpecNode],
					[HasSpecLink],
					[GageID],
					[DME_GlobalID]
				FROM
					[dbo].[mst_nodes_ac]
				WHERE
					[MAPINFO_ID] = @MapinfoId
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_nodes_ac_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_nodes_ac_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_nodes_ac_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the mst_nodes_ac table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_nodes_ac_Find
(

	@SearchUsingOR bit   = null ,

	@MapinfoId int   = null ,

	@Node nvarchar (6)  = null ,

	@Xcoord float   = null ,

	@Ycoord float   = null ,

	@NodeType nvarchar (4)  = null ,

	@GrndElev float   = null ,

	@HasSpecNode nvarchar (1)  = null ,

	@HasSpecLink nvarchar (1)  = null ,

	@GageId nvarchar (8)  = null ,

	@DmeGlobalId int   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [MAPINFO_ID]
	, [Node]
	, [XCoord]
	, [YCoord]
	, [NodeType]
	, [GrndElev]
	, [HasSpecNode]
	, [HasSpecLink]
	, [GageID]
	, [DME_GlobalID]
    FROM
	[dbo].[mst_nodes_ac]
    WHERE 
	 ([MAPINFO_ID] = @MapinfoId OR @MapinfoId IS NULL)
	AND ([Node] = @Node OR @Node IS NULL)
	AND ([XCoord] = @Xcoord OR @Xcoord IS NULL)
	AND ([YCoord] = @Ycoord OR @Ycoord IS NULL)
	AND ([NodeType] = @NodeType OR @NodeType IS NULL)
	AND ([GrndElev] = @GrndElev OR @GrndElev IS NULL)
	AND ([HasSpecNode] = @HasSpecNode OR @HasSpecNode IS NULL)
	AND ([HasSpecLink] = @HasSpecLink OR @HasSpecLink IS NULL)
	AND ([GageID] = @GageId OR @GageId IS NULL)
	AND ([DME_GlobalID] = @DmeGlobalId OR @DmeGlobalId IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [MAPINFO_ID]
	, [Node]
	, [XCoord]
	, [YCoord]
	, [NodeType]
	, [GrndElev]
	, [HasSpecNode]
	, [HasSpecLink]
	, [GageID]
	, [DME_GlobalID]
    FROM
	[dbo].[mst_nodes_ac]
    WHERE 
	 ([MAPINFO_ID] = @MapinfoId AND @MapinfoId is not null)
	OR ([Node] = @Node AND @Node is not null)
	OR ([XCoord] = @Xcoord AND @Xcoord is not null)
	OR ([YCoord] = @Ycoord AND @Ycoord is not null)
	OR ([NodeType] = @NodeType AND @NodeType is not null)
	OR ([GrndElev] = @GrndElev AND @GrndElev is not null)
	OR ([HasSpecNode] = @HasSpecNode AND @HasSpecNode is not null)
	OR ([HasSpecLink] = @HasSpecLink AND @HasSpecLink is not null)
	OR ([GageID] = @GageId AND @GageId is not null)
	OR ([DME_GlobalID] = @DmeGlobalId AND @DmeGlobalId is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_links_ac_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_links_ac_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_links_ac_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the mst_links_ac table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_links_ac_Get_List

AS


				
				SELECT
					[MAPINFO_ID],
					[MLinkID],
					[CompKey],
					[USNode],
					[DSNode],
					[PipeShape],
					[LinkType],
					[PipeFlowType],
					[Length],
					[DiamWidth],
					[Height],
					[Material],
					[upsdpth],
					[dwndpth],
					[USIE],
					[DSIE],
					[AsBuilt],
					[Instdate],
					[FromX],
					[FromY],
					[ToX],
					[ToY],
					[Roughness],
					[TimeFrame],
					[DataFlagSynth],
					[DataQual],
					[Hservstat],
					[ValidFromDate],
					[ValidToDate],
					[CADKey],
					[AuditNodeID],
					[AuditDups],
					[AuditSpatial],
					[AuditOK2Go],
					[AuditProcTimestamp],
					[Qdes],
					[DME_GlobalID]
				FROM
					[dbo].[mst_links_ac]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_links_ac_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_links_ac_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_links_ac_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the mst_links_ac table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_links_ac_GetPaged
(

	@WhereClause varchar (2000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [MAPINFO_ID] int 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([MAPINFO_ID])'
				SET @SQL = @SQL + ' SELECT'
				IF @PageSize > 0
				BEGIN
					SET @SQL = @SQL + ' TOP ' + CONVERT(nvarchar, @PageUpperBound)
				END
				SET @SQL = @SQL + ' [MAPINFO_ID]'
				SET @SQL = @SQL + ' FROM [dbo].[mst_links_ac]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Return paged results
				SELECT O.[MAPINFO_ID], O.[MLinkID], O.[CompKey], O.[USNode], O.[DSNode], O.[PipeShape], O.[LinkType], O.[PipeFlowType], O.[Length], O.[DiamWidth], O.[Height], O.[Material], O.[upsdpth], O.[dwndpth], O.[USIE], O.[DSIE], O.[AsBuilt], O.[Instdate], O.[FromX], O.[FromY], O.[ToX], O.[ToY], O.[Roughness], O.[TimeFrame], O.[DataFlagSynth], O.[DataQual], O.[Hservstat], O.[ValidFromDate], O.[ValidToDate], O.[CADKey], O.[AuditNodeID], O.[AuditDups], O.[AuditSpatial], O.[AuditOK2Go], O.[AuditProcTimestamp], O.[Qdes], O.[DME_GlobalID]
				FROM
				    [dbo].[mst_links_ac] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[MAPINFO_ID] = PageIndex.[MAPINFO_ID]
				ORDER BY
				    PageIndex.IndexId
				
				-- get row count
				SET @SQL = 'SELECT COUNT(*) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[mst_links_ac]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_links_ac_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_links_ac_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_links_ac_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the mst_links_ac table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_links_ac_Insert
(

	@MapinfoId int   ,

	@MlinkId int   ,

	@CompKey int   ,

	@UsNode nvarchar (6)  ,

	@DsNode nvarchar (6)  ,

	@PipeShape nvarchar (4)  ,

	@LinkType nvarchar (2)  ,

	@PipeFlowType nvarchar (1)  ,

	@Length float   ,

	@DiamWidth float   ,

	@Height float   ,

	@Material nvarchar (6)  ,

	@Upsdpth float   ,

	@Dwndpth float   ,

	@Usie float   ,

	@Dsie float   ,

	@AsBuilt nvarchar (14)  ,

	@Instdate datetime   ,

	@Fromx float   ,

	@Fromy float   ,

	@Tox float   ,

	@Toy float   ,

	@Roughness float   ,

	@TimeFrame nvarchar (2)  ,

	@DataFlagSynth int   ,

	@DataQual nvarchar (15)  ,

	@Hservstat nvarchar (4)  ,

	@ValidFromDate nvarchar (8)  ,

	@ValidToDate nvarchar (8)  ,

	@CadKey nvarchar (14)  ,

	@AuditNodeId nvarchar (20)  ,

	@AuditDups nvarchar (30)  ,

	@AuditSpatial nvarchar (30)  ,

	@AuditOk2Go bit   ,

	@AuditProcTimestamp nvarchar (30)  ,

	@Qdes float   ,

	@DmeGlobalId int   
)
AS


				
				INSERT INTO [dbo].[mst_links_ac]
					(
					[MAPINFO_ID]
					,[MLinkID]
					,[CompKey]
					,[USNode]
					,[DSNode]
					,[PipeShape]
					,[LinkType]
					,[PipeFlowType]
					,[Length]
					,[DiamWidth]
					,[Height]
					,[Material]
					,[upsdpth]
					,[dwndpth]
					,[USIE]
					,[DSIE]
					,[AsBuilt]
					,[Instdate]
					,[FromX]
					,[FromY]
					,[ToX]
					,[ToY]
					,[Roughness]
					,[TimeFrame]
					,[DataFlagSynth]
					,[DataQual]
					,[Hservstat]
					,[ValidFromDate]
					,[ValidToDate]
					,[CADKey]
					,[AuditNodeID]
					,[AuditDups]
					,[AuditSpatial]
					,[AuditOK2Go]
					,[AuditProcTimestamp]
					,[Qdes]
					,[DME_GlobalID]
					)
				VALUES
					(
					@MapinfoId
					,@MlinkId
					,@CompKey
					,@UsNode
					,@DsNode
					,@PipeShape
					,@LinkType
					,@PipeFlowType
					,@Length
					,@DiamWidth
					,@Height
					,@Material
					,@Upsdpth
					,@Dwndpth
					,@Usie
					,@Dsie
					,@AsBuilt
					,@Instdate
					,@Fromx
					,@Fromy
					,@Tox
					,@Toy
					,@Roughness
					,@TimeFrame
					,@DataFlagSynth
					,@DataQual
					,@Hservstat
					,@ValidFromDate
					,@ValidToDate
					,@CadKey
					,@AuditNodeId
					,@AuditDups
					,@AuditSpatial
					,@AuditOk2Go
					,@AuditProcTimestamp
					,@Qdes
					,@DmeGlobalId
					)
				
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_links_ac_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_links_ac_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_links_ac_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the mst_links_ac table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_links_ac_Update
(

	@MapinfoId int   ,

	@OriginalMapinfoId int   ,

	@MlinkId int   ,

	@CompKey int   ,

	@UsNode nvarchar (6)  ,

	@DsNode nvarchar (6)  ,

	@PipeShape nvarchar (4)  ,

	@LinkType nvarchar (2)  ,

	@PipeFlowType nvarchar (1)  ,

	@Length float   ,

	@DiamWidth float   ,

	@Height float   ,

	@Material nvarchar (6)  ,

	@Upsdpth float   ,

	@Dwndpth float   ,

	@Usie float   ,

	@Dsie float   ,

	@AsBuilt nvarchar (14)  ,

	@Instdate datetime   ,

	@Fromx float   ,

	@Fromy float   ,

	@Tox float   ,

	@Toy float   ,

	@Roughness float   ,

	@TimeFrame nvarchar (2)  ,

	@DataFlagSynth int   ,

	@DataQual nvarchar (15)  ,

	@Hservstat nvarchar (4)  ,

	@ValidFromDate nvarchar (8)  ,

	@ValidToDate nvarchar (8)  ,

	@CadKey nvarchar (14)  ,

	@AuditNodeId nvarchar (20)  ,

	@AuditDups nvarchar (30)  ,

	@AuditSpatial nvarchar (30)  ,

	@AuditOk2Go bit   ,

	@AuditProcTimestamp nvarchar (30)  ,

	@Qdes float   ,

	@DmeGlobalId int   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[mst_links_ac]
				SET
					[MAPINFO_ID] = @MapinfoId
					,[MLinkID] = @MlinkId
					,[CompKey] = @CompKey
					,[USNode] = @UsNode
					,[DSNode] = @DsNode
					,[PipeShape] = @PipeShape
					,[LinkType] = @LinkType
					,[PipeFlowType] = @PipeFlowType
					,[Length] = @Length
					,[DiamWidth] = @DiamWidth
					,[Height] = @Height
					,[Material] = @Material
					,[upsdpth] = @Upsdpth
					,[dwndpth] = @Dwndpth
					,[USIE] = @Usie
					,[DSIE] = @Dsie
					,[AsBuilt] = @AsBuilt
					,[Instdate] = @Instdate
					,[FromX] = @Fromx
					,[FromY] = @Fromy
					,[ToX] = @Tox
					,[ToY] = @Toy
					,[Roughness] = @Roughness
					,[TimeFrame] = @TimeFrame
					,[DataFlagSynth] = @DataFlagSynth
					,[DataQual] = @DataQual
					,[Hservstat] = @Hservstat
					,[ValidFromDate] = @ValidFromDate
					,[ValidToDate] = @ValidToDate
					,[CADKey] = @CadKey
					,[AuditNodeID] = @AuditNodeId
					,[AuditDups] = @AuditDups
					,[AuditSpatial] = @AuditSpatial
					,[AuditOK2Go] = @AuditOk2Go
					,[AuditProcTimestamp] = @AuditProcTimestamp
					,[Qdes] = @Qdes
					,[DME_GlobalID] = @DmeGlobalId
				WHERE
[MAPINFO_ID] = @OriginalMapinfoId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_links_ac_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_links_ac_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_links_ac_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the mst_links_ac table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_links_ac_Delete
(

	@MapinfoId int   
)
AS


				DELETE FROM [dbo].[mst_links_ac] WITH (ROWLOCK) 
				WHERE
					[MAPINFO_ID] = @MapinfoId
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_links_ac_GetByDsNode procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_links_ac_GetByDsNode') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_links_ac_GetByDsNode
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the mst_links_ac table through a foreign key
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_links_ac_GetByDsNode
(

	@DsNode nvarchar (6)  
)
AS


				SET ANSI_NULLS OFF
				
				SELECT
					[MAPINFO_ID],
					[MLinkID],
					[CompKey],
					[USNode],
					[DSNode],
					[PipeShape],
					[LinkType],
					[PipeFlowType],
					[Length],
					[DiamWidth],
					[Height],
					[Material],
					[upsdpth],
					[dwndpth],
					[USIE],
					[DSIE],
					[AsBuilt],
					[Instdate],
					[FromX],
					[FromY],
					[ToX],
					[ToY],
					[Roughness],
					[TimeFrame],
					[DataFlagSynth],
					[DataQual],
					[Hservstat],
					[ValidFromDate],
					[ValidToDate],
					[CADKey],
					[AuditNodeID],
					[AuditDups],
					[AuditSpatial],
					[AuditOK2Go],
					[AuditProcTimestamp],
					[Qdes],
					[DME_GlobalID]
				FROM
					[dbo].[mst_links_ac]
				WHERE
					[DSNode] = @DsNode
				
				SELECT @@ROWCOUNT
				SET ANSI_NULLS ON
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_links_ac_GetByUsNode procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_links_ac_GetByUsNode') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_links_ac_GetByUsNode
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the mst_links_ac table through a foreign key
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_links_ac_GetByUsNode
(

	@UsNode nvarchar (6)  
)
AS


				SET ANSI_NULLS OFF
				
				SELECT
					[MAPINFO_ID],
					[MLinkID],
					[CompKey],
					[USNode],
					[DSNode],
					[PipeShape],
					[LinkType],
					[PipeFlowType],
					[Length],
					[DiamWidth],
					[Height],
					[Material],
					[upsdpth],
					[dwndpth],
					[USIE],
					[DSIE],
					[AsBuilt],
					[Instdate],
					[FromX],
					[FromY],
					[ToX],
					[ToY],
					[Roughness],
					[TimeFrame],
					[DataFlagSynth],
					[DataQual],
					[Hservstat],
					[ValidFromDate],
					[ValidToDate],
					[CADKey],
					[AuditNodeID],
					[AuditDups],
					[AuditSpatial],
					[AuditOK2Go],
					[AuditProcTimestamp],
					[Qdes],
					[DME_GlobalID]
				FROM
					[dbo].[mst_links_ac]
				WHERE
					[USNode] = @UsNode
				
				SELECT @@ROWCOUNT
				SET ANSI_NULLS ON
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_links_ac_GetByMapinfoId procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_links_ac_GetByMapinfoId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_links_ac_GetByMapinfoId
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the mst_links_ac table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_links_ac_GetByMapinfoId
(

	@MapinfoId int   
)
AS


				SELECT
					[MAPINFO_ID],
					[MLinkID],
					[CompKey],
					[USNode],
					[DSNode],
					[PipeShape],
					[LinkType],
					[PipeFlowType],
					[Length],
					[DiamWidth],
					[Height],
					[Material],
					[upsdpth],
					[dwndpth],
					[USIE],
					[DSIE],
					[AsBuilt],
					[Instdate],
					[FromX],
					[FromY],
					[ToX],
					[ToY],
					[Roughness],
					[TimeFrame],
					[DataFlagSynth],
					[DataQual],
					[Hservstat],
					[ValidFromDate],
					[ValidToDate],
					[CADKey],
					[AuditNodeID],
					[AuditDups],
					[AuditSpatial],
					[AuditOK2Go],
					[AuditProcTimestamp],
					[Qdes],
					[DME_GlobalID]
				FROM
					[dbo].[mst_links_ac]
				WHERE
					[MAPINFO_ID] = @MapinfoId
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.mst_links_ac_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.mst_links_ac_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.mst_links_ac_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the mst_links_ac table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.mst_links_ac_Find
(

	@SearchUsingOR bit   = null ,

	@MapinfoId int   = null ,

	@MlinkId int   = null ,

	@CompKey int   = null ,

	@UsNode nvarchar (6)  = null ,

	@DsNode nvarchar (6)  = null ,

	@PipeShape nvarchar (4)  = null ,

	@LinkType nvarchar (2)  = null ,

	@PipeFlowType nvarchar (1)  = null ,

	@Length float   = null ,

	@DiamWidth float   = null ,

	@Height float   = null ,

	@Material nvarchar (6)  = null ,

	@Upsdpth float   = null ,

	@Dwndpth float   = null ,

	@Usie float   = null ,

	@Dsie float   = null ,

	@AsBuilt nvarchar (14)  = null ,

	@Instdate datetime   = null ,

	@Fromx float   = null ,

	@Fromy float   = null ,

	@Tox float   = null ,

	@Toy float   = null ,

	@Roughness float   = null ,

	@TimeFrame nvarchar (2)  = null ,

	@DataFlagSynth int   = null ,

	@DataQual nvarchar (15)  = null ,

	@Hservstat nvarchar (4)  = null ,

	@ValidFromDate nvarchar (8)  = null ,

	@ValidToDate nvarchar (8)  = null ,

	@CadKey nvarchar (14)  = null ,

	@AuditNodeId nvarchar (20)  = null ,

	@AuditDups nvarchar (30)  = null ,

	@AuditSpatial nvarchar (30)  = null ,

	@AuditOk2Go bit   = null ,

	@AuditProcTimestamp nvarchar (30)  = null ,

	@Qdes float   = null ,

	@DmeGlobalId int   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [MAPINFO_ID]
	, [MLinkID]
	, [CompKey]
	, [USNode]
	, [DSNode]
	, [PipeShape]
	, [LinkType]
	, [PipeFlowType]
	, [Length]
	, [DiamWidth]
	, [Height]
	, [Material]
	, [upsdpth]
	, [dwndpth]
	, [USIE]
	, [DSIE]
	, [AsBuilt]
	, [Instdate]
	, [FromX]
	, [FromY]
	, [ToX]
	, [ToY]
	, [Roughness]
	, [TimeFrame]
	, [DataFlagSynth]
	, [DataQual]
	, [Hservstat]
	, [ValidFromDate]
	, [ValidToDate]
	, [CADKey]
	, [AuditNodeID]
	, [AuditDups]
	, [AuditSpatial]
	, [AuditOK2Go]
	, [AuditProcTimestamp]
	, [Qdes]
	, [DME_GlobalID]
    FROM
	[dbo].[mst_links_ac]
    WHERE 
	 ([MAPINFO_ID] = @MapinfoId OR @MapinfoId IS NULL)
	AND ([MLinkID] = @MlinkId OR @MlinkId IS NULL)
	AND ([CompKey] = @CompKey OR @CompKey IS NULL)
	AND ([USNode] = @UsNode OR @UsNode IS NULL)
	AND ([DSNode] = @DsNode OR @DsNode IS NULL)
	AND ([PipeShape] = @PipeShape OR @PipeShape IS NULL)
	AND ([LinkType] = @LinkType OR @LinkType IS NULL)
	AND ([PipeFlowType] = @PipeFlowType OR @PipeFlowType IS NULL)
	AND ([Length] = @Length OR @Length IS NULL)
	AND ([DiamWidth] = @DiamWidth OR @DiamWidth IS NULL)
	AND ([Height] = @Height OR @Height IS NULL)
	AND ([Material] = @Material OR @Material IS NULL)
	AND ([upsdpth] = @Upsdpth OR @Upsdpth IS NULL)
	AND ([dwndpth] = @Dwndpth OR @Dwndpth IS NULL)
	AND ([USIE] = @Usie OR @Usie IS NULL)
	AND ([DSIE] = @Dsie OR @Dsie IS NULL)
	AND ([AsBuilt] = @AsBuilt OR @AsBuilt IS NULL)
	AND ([Instdate] = @Instdate OR @Instdate IS NULL)
	AND ([FromX] = @Fromx OR @Fromx IS NULL)
	AND ([FromY] = @Fromy OR @Fromy IS NULL)
	AND ([ToX] = @Tox OR @Tox IS NULL)
	AND ([ToY] = @Toy OR @Toy IS NULL)
	AND ([Roughness] = @Roughness OR @Roughness IS NULL)
	AND ([TimeFrame] = @TimeFrame OR @TimeFrame IS NULL)
	AND ([DataFlagSynth] = @DataFlagSynth OR @DataFlagSynth IS NULL)
	AND ([DataQual] = @DataQual OR @DataQual IS NULL)
	AND ([Hservstat] = @Hservstat OR @Hservstat IS NULL)
	AND ([ValidFromDate] = @ValidFromDate OR @ValidFromDate IS NULL)
	AND ([ValidToDate] = @ValidToDate OR @ValidToDate IS NULL)
	AND ([CADKey] = @CadKey OR @CadKey IS NULL)
	AND ([AuditNodeID] = @AuditNodeId OR @AuditNodeId IS NULL)
	AND ([AuditDups] = @AuditDups OR @AuditDups IS NULL)
	AND ([AuditSpatial] = @AuditSpatial OR @AuditSpatial IS NULL)
	AND ([AuditOK2Go] = @AuditOk2Go OR @AuditOk2Go IS NULL)
	AND ([AuditProcTimestamp] = @AuditProcTimestamp OR @AuditProcTimestamp IS NULL)
	AND ([Qdes] = @Qdes OR @Qdes IS NULL)
	AND ([DME_GlobalID] = @DmeGlobalId OR @DmeGlobalId IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [MAPINFO_ID]
	, [MLinkID]
	, [CompKey]
	, [USNode]
	, [DSNode]
	, [PipeShape]
	, [LinkType]
	, [PipeFlowType]
	, [Length]
	, [DiamWidth]
	, [Height]
	, [Material]
	, [upsdpth]
	, [dwndpth]
	, [USIE]
	, [DSIE]
	, [AsBuilt]
	, [Instdate]
	, [FromX]
	, [FromY]
	, [ToX]
	, [ToY]
	, [Roughness]
	, [TimeFrame]
	, [DataFlagSynth]
	, [DataQual]
	, [Hservstat]
	, [ValidFromDate]
	, [ValidToDate]
	, [CADKey]
	, [AuditNodeID]
	, [AuditDups]
	, [AuditSpatial]
	, [AuditOK2Go]
	, [AuditProcTimestamp]
	, [Qdes]
	, [DME_GlobalID]
    FROM
	[dbo].[mst_links_ac]
    WHERE 
	 ([MAPINFO_ID] = @MapinfoId AND @MapinfoId is not null)
	OR ([MLinkID] = @MlinkId AND @MlinkId is not null)
	OR ([CompKey] = @CompKey AND @CompKey is not null)
	OR ([USNode] = @UsNode AND @UsNode is not null)
	OR ([DSNode] = @DsNode AND @DsNode is not null)
	OR ([PipeShape] = @PipeShape AND @PipeShape is not null)
	OR ([LinkType] = @LinkType AND @LinkType is not null)
	OR ([PipeFlowType] = @PipeFlowType AND @PipeFlowType is not null)
	OR ([Length] = @Length AND @Length is not null)
	OR ([DiamWidth] = @DiamWidth AND @DiamWidth is not null)
	OR ([Height] = @Height AND @Height is not null)
	OR ([Material] = @Material AND @Material is not null)
	OR ([upsdpth] = @Upsdpth AND @Upsdpth is not null)
	OR ([dwndpth] = @Dwndpth AND @Dwndpth is not null)
	OR ([USIE] = @Usie AND @Usie is not null)
	OR ([DSIE] = @Dsie AND @Dsie is not null)
	OR ([AsBuilt] = @AsBuilt AND @AsBuilt is not null)
	OR ([Instdate] = @Instdate AND @Instdate is not null)
	OR ([FromX] = @Fromx AND @Fromx is not null)
	OR ([FromY] = @Fromy AND @Fromy is not null)
	OR ([ToX] = @Tox AND @Tox is not null)
	OR ([ToY] = @Toy AND @Toy is not null)
	OR ([Roughness] = @Roughness AND @Roughness is not null)
	OR ([TimeFrame] = @TimeFrame AND @TimeFrame is not null)
	OR ([DataFlagSynth] = @DataFlagSynth AND @DataFlagSynth is not null)
	OR ([DataQual] = @DataQual AND @DataQual is not null)
	OR ([Hservstat] = @Hservstat AND @Hservstat is not null)
	OR ([ValidFromDate] = @ValidFromDate AND @ValidFromDate is not null)
	OR ([ValidToDate] = @ValidToDate AND @ValidToDate is not null)
	OR ([CADKey] = @CadKey AND @CadKey is not null)
	OR ([AuditNodeID] = @AuditNodeId AND @AuditNodeId is not null)
	OR ([AuditDups] = @AuditDups AND @AuditDups is not null)
	OR ([AuditSpatial] = @AuditSpatial AND @AuditSpatial is not null)
	OR ([AuditOK2Go] = @AuditOk2Go AND @AuditOk2Go is not null)
	OR ([AuditProcTimestamp] = @AuditProcTimestamp AND @AuditProcTimestamp is not null)
	OR ([Qdes] = @Qdes AND @Qdes is not null)
	OR ([DME_GlobalID] = @DmeGlobalId AND @DmeGlobalId is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

