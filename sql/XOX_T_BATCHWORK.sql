
--XOX_T_BATCHWORK
DROP TABLE XOX_T_BATCHWORK

CREATE TABLE XOX_T_BATCHWORK
(
 ROW_ID BIGINT IDENTITY(1,1) NOT NULL
,CREATED_BY	BIGINT
,CREATED DATETIME
,LAST_UPD_BY BIGINT
,LAST_UPD DATETIME

,START_AT DATETIME
,END_AT DATETIME
,JOB_NAME NVARCHAR(MAX)
,JOB_TYPE NVARCHAR(MAX)
,DESCRIPTION NVARCHAR(MAX)
,REMARKS NVARCHAR(MAX)
,STATUS INT
,RUN_SEQUENCE INT
,FREQUENCY BIGINT
,TEMP_FREQUENCY BIGINT


 CONSTRAINT XOX_T_BATCHWORK_P01 PRIMARY KEY CLUSTERED 
(
	ROW_ID
)
)