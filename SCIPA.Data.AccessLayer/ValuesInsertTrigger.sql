CREATE TRIGGER InsertTrigger
ON SCIPA.dbo.[Values] FOR INSERT
AS
	/*
		The following comment area is used to explain the build up of the queries executed
		as part of this trigger.

		--Selects the ID Numbers from the Values table where the Event occured longer than the maximum time range ago.
		(SELECT (Id) FROM dbo.[Values] WHERE (EventTime < DATEADD(hour, -@maxHourRange, getdate())))

		-- List of Devices with too many values
		DECLARE @DevicesWithTooManyValues int= (SELECT DeviceId FROM dbo.[Values] GROUP BY DeviceId HAVING COUNT(Id) > @maxValue )

		-- List of allowed values (as per the Max rule)
		DECLARE @AcceptableValues int = (SELECT TOP (@maxValue) Id FROM dbo.[Values] WHERE DeviceId IN (@DevicesWithTooManyValues) ORDER BY Id DESC)

		-- List of disallowed values (as per the Max rule)
		(SELECT Id FROM dbo.[Values] WHERE Id NOT IN (@AcceptableValues))
	*/

	SET NOCOUNT ON;
	PRINT 'Pruning [Values] table following insert.'

	DECLARE @maxValue int =     1000; -- Maximum number of Values to store per device.
	DECLARE @maxHourRange int = 72; -- Maximum number of hours worth of values to store per device.
	
	DELETE FROM SCIPA.dbo.[Values] WHERE
	(
		------ Built Query: Max Value Count ------
		Id IN (SELECT Id FROM dbo.[Values] WHERE Id NOT IN 
		(
			(SELECT TOP (@maxValue) Id FROM dbo.[Values] WHERE DeviceId IN
				(
					(SELECT DeviceId FROM dbo.[Values] GROUP BY DeviceId HAVING COUNT(Id) > @maxValue )
				) ORDER BY Id DESC)
		)
		)

		OR

		------ Built Query: Max Time Range ------
		Id IN (SELECT (Id) FROM dbo.[Values] WHERE (EventTime < DATEADD(hour, -@maxHourRange, getdate())))
	)

	PRINT 'The [Values] table has been pruned successfully.'
GO