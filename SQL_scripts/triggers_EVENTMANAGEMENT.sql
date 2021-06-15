/*	
** script that contains the project Triggers
**
** Pedro Abreu & João Gameiro
 */

 /* não podem existir dois eventos ao mesmo tempo */
 GO
 CREATE TRIGGER simultaneos_events ON EM.EVENTO
 INSTEAD OF INSERT 
 AS
 BEGIN
	DECLARE @dataini AS DATE;
	DECLARE @datafim AS DATE;
	DECLARE @d_ini AS DATE;
	DECLARE @d_fim AS DATE;

	SELECT @dataini = inserted.dataini, @datafim = inserted.datafim FROM inserted;
	
	DECLARE C CURSOR
	FOR
		SELECT dataini, datafim
		FROM EM.EVENTO;

	OPEN C;
	FETCH C INTO @d_ini, @d_fim;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF ((@dataini >= @d_ini AND @dataini <= @d_fim) OR (@datafim >= @d_ini AND @datafim <= @d_fim)) 
		BEGIN
			RAISERROR('ERROR: Event date overlaps other events', 16, 1);
			CLOSE C;
			DEALLOCATE C;
			RETURN;
		END
		FETCH C INTO @d_ini, @d_fim;
	END
	CLOSE C;
	DEALLOCATE C;

	INSERT INTO EM.EVENTO SELECT * FROM inserted;
 END

 SELECT * FROM EM.EVENTO;
 --Teste
 INSERT INTO EM.EVENTO VALUES(25, 'TEste', 4, '2018-06-03', '2018-06-05', 1234, 114444, '2017-12-01', 32032541)






/* não podem existir dois concertos ao mesmo tempo e o concerto tem de estar entre a data de ínicio e de fim do evento */
GO
CREATE TRIGGER simultaneos_concerts ON EM.CONCERTO
INSTEAD OF INSERT 
AS
BEGIN
	DECLARE @event_id AS VARCHAR(20);
	DECLARE @dataini AS DATE;
	DECLARE @datafim AS DATE;
	DECLARE @d_ini AS DATE;
	DECLARE @d_fim AS DATE;
	DECLARE @ini_event AS DATE;
	DECLARE @fim_event AS DATE;

	SELECT @dataini = inserted.datatimeini, @datafim = DATEADD(SECOND, DATEPART(SECOND,inserted.duracao), DATEADD(MINUTE, DATEPART(MINUTE, inserted.duracao), DATEADD(hour, DATEPART(hour, inserted.duracao), inserted.datatimeini))), @event_id=id_evento FROM inserted;
	SELECT @ini_event = dataini, @fim_event = datafim FROM EM.EVENTO WHERE id=@event_id;

	IF ( CONVERT(DATE, @dataini) < @ini_event OR  CONVERT(DATE, @dataini) > @fim_event)
	BEGIN
		RAISERROR('ERROR: Concert date must be after event start or before event ends', 16, 1);
		RETURN;
	END

	DECLARE C CURSOR
	FOR
		SELECT datatimeini, DATEADD(SECOND, DATEPART(SECOND,duracao), DATEADD(MINUTE, DATEPART(MINUTE, duracao), DATEADD(hour, DATEPART(hour, duracao), datatimeini)))  AS fim 
		FROM EM.CONCERTO;

	OPEN C;
	FETCH C INTO @d_ini, @d_fim;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF ((@dataini >= @d_ini AND @dataini <= @d_fim) OR (@datafim >= @d_ini AND @datafim <= @d_fim)) 
		BEGIN
			RAISERROR('ERROR: Concert date overlaps other concerts', 16, 1);
			CLOSE C;
			DEALLOCATE C;
			RETURN;
		END
		FETCH C INTO @d_ini, @d_fim;
	END
	CLOSE C;
	DEALLOCATE C;

	INSERT INTO EM.CONCERTO SELECT * FROM inserted;
END







/* Apagar um concerto apaga também o seu soundcheck */
GO
CREATE TRIGGER delete_concert ON EM.CONCERTO
AFTER DELETE
AS
BEGIN
	DECLARE @sc_id AS VARCHAR(20);

	SELECT @sc_id = id_soundcheck FROM deleted;

	DELETE FROM EM.SOUNDCHECK WHERE  id=@sc_id;
END
GO




/* Apagar um evento apaga também os seus concertos e soundchecks */
GO
CREATE TRIGGER delete_event ON EM.EVENTO
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @ev_id AS VARCHAR(20);
	
	SELECT @ev_id = id FROM deleted;

	DELETE FROM EM.CONCERTO WHERE id_evento = @ev_id;
	DELETE FROM EM.EVENTO WHERE id = @ev_id;
END
GO