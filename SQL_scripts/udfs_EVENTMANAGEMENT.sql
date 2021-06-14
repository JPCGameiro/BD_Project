/*	
** script that contains the project UDFs
**
** Pedro Abreu & João Gameiro
 */

 --Dado um id devolve um evento
GO 
CREATE FUNCTION getEventosById (@id VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT * FROM EM.EVENTO
		   WHERE id = @id)
GO
 --Teste
SELECT * FROM getEventosById(10);



--Dado um nome devolve um evento
GO 
CREATE FUNCTION getEventosByNome (@nome VARCHAR(250)) RETURNS TABLE AS
	RETURN(SELECT * FROM EM.EVENTO
		   WHERE nome = @nome)
GO
 --Teste
SELECT * FROM getEventosByNome('RockFest');



--Dado um ccPromotor devolve um evento
GO 
CREATE FUNCTION getEventosByPromotor (@promotor_cc VARCHAR(12)) RETURNS TABLE AS
	RETURN(SELECT * FROM EM.EVENTO
		   WHERE cc_promotor = @promotor_cc)
GO
 --Teste
SELECT * FROM getEventosByPromotor(114444);



--Dado um ccStageManager devolve um evento
GO 
CREATE FUNCTION getEventosByStageManager (@manager_cc VARCHAR(12)) RETURNS TABLE AS
	RETURN(SELECT * FROM EM.EVENTO
		   WHERE cc_stageManager = @manager_cc)
GO
 --Teste
SELECT * FROM getEventosByStageManager(32032541);



--Dado o id de um Evento devolver os seus concertos
GO
CREATE FUNCTION getConcertosByIDEvento (@evento_id VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT * FROM EM.CONCERTO
		   WHERE id_evento = @evento_id)
GO
--Teste
SELECT * FROM getConcertosByIDEvento(14);



--Dado o id de um Evento devolver os seus concertos e respectivos soundchecks
GO
CREATE FUNCTION getConcertosSounchecksByIDEvento (@evento_id VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT EM.CONCERTO.id, EM.CONCERTO.datatimeini as init_concerto, EM.CONCERTO.duracao as duracao_concerto, id_banda, id_evento, id_soundcheck, EM.SOUNDCHECK.duracao as duracao_soundcheck, EM.SOUNDCHECK.datatimeini as ini_soundcheck 
		   FROM EM.CONCERTO, EM.SOUNDCHECK
		   WHERE id_evento = 14 AND id_soundcheck = EM.SOUNDCHECK.id)
GO
--Teste
SELECT * FROM getConcertosSounchecksByIDEvento(14);



--Dado o id de um Evento devolver as bandas que vão tocar
GO
CREATE FUNCTION getBandasByIDEvento (@evento_id VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT EM.BANDA.id, nome, telefone, email, numElem, genero FROM EM.CONCERTO, EM.BANDA
		   WHERE id_evento = @evento_id AND id_banda = EM.BANDA.id)
GO
--Teste
SELECT * FROM getBandasByIDEvento(14);



--Dado o id de uma Banda devolver as músicos constituintes que vão tocar
GO
CREATE FUNCTION getMusicosByIDBanda (@banda_id VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT * FROM EM.MUSICO
		   WHERE id_banda = @banda_id)
GO
--Teste
SELECT * FROM getMusicosByIDBanda('gd');
-- IDEIA : fazer uma função para obter músicos de apoio???? 