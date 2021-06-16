/*	
** script that contains the project Procedures
**
** Pedro Abreu & João Gameiro
 */

/* Criar um evento */
GO
CREATE PROCEDURE create_evento( @id VARCHAR(20), @nome VARCHAR(150), @numdias INT, @dataini DATE, @datafim DATE, @numbilhetes INT, @cc_promotor VARCHAR(12), @dataproposta DATE, @cc_stageManager VARCHAR(12))
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO EM.EVENTO VALUES(@id, @nome, @numdias, @dataini, @datafim, @numbilhetes, @cc_promotor, @dataproposta, @cc_stageManager);
			PRINT 'Sucess'
		COMMIT
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
		ROLLBACK
	END CATCH
END

SELECT * FROM EM.EvENTO;

/* Teste */
EXEC create_evento 12, 'Evento Teste', 1,'2021-06-01', '2021-06-01',1400, 2134022,'2020-01-30',12003011; --Rollback por causa do trigger eventos simultaneos
EXEC create_evento 40, 'Evento Teste', 1,'2022-06-05', '2022-06-05',1400, 2134022,'2020-01-30',12003011; --Sucesso




/* Criar um concerto e um soundcheck para o concerto com banda já existente*/
GO
CREATE PROCEDURE create_concerto( @id VARCHAR(20), @datatimeini DATETIME, @duracao TIME, @id_banda VARCHAR(20), @id_evento INT, @id_soundcheck INT, @duracao_s TIME, @data_s DATETIME)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO EM.SOUNDCHECK VALUES(@id_soundcheck, @duracao_s, @data_s); 
			INSERT INTO EM.CONCERTO VALUES(@id, @datatimeini, @duracao, @id_banda, @id_evento, @id_soundcheck);
			PRINT 'Sucess'
		COMMIT
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
		ROLLBACK
	END CATCH
END

/* Teste */
EXEC create_concerto 80, '2022-06-05 21:00:00', '04:00:00', 'ff', 40, 80, '00:30:00', '2022-06-05 13:00:00';

