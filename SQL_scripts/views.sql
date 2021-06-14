/*
 * VIEWS
 *
*/

CREATE VIEW EM.V_OVERVIEW AS
	SELECT		EM.EVENTO.nome, EM.EVENTO.dataini, EM.EVENTO.numdias, EM.EVENTO.numbilhetes, EM.PROMOTOR.nome AS PROMOTOR, EM.BANDA.nome AS BANDA, EM.CONCERTO.datatimeini AS horainicio, EM.CONCERTO.duracao
	FROM		EM.PROMOTOR INNER JOIN
					  EM.EVENTO ON EM.PROMOTOR.numCC = EM.EVENTO.cc_promotor INNER JOIN
					  EM.CONCERTO ON EM.EVENTO.id = EM.CONCERTO.id_evento INNER JOIN
					  EM.BANDA ON EM.CONCERTO.id_banda = EM.BANDA.id

GO;

CREATE VIEW EM.V_CONCERTOS AS
	SELECT			EM.CONCERTO.id, EM.EVENTO.nome, EM.CONCERTO.id_evento, EM.BANDA.nome AS banda, EM.CONCERTO.id_banda, EM.CONCERTO.datatimeini, EM.CONCERTO.duracao
	FROM            EM.CONCERTO INNER JOIN
                         EM.BANDA ON EM.CONCERTO.id_banda = EM.BANDA.id INNER JOIN
                         EM.EVENTO ON EM.CONCERTO.id_evento = EM.EVENTO.id INNER JOIN
                         EM.SOUNDCHECK ON EM.CONCERTO.id_soundcheck = EM.SOUNDCHECK.id

select * from EM.V_CONCERTOS