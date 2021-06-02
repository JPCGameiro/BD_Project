/*	
** script that includes querys to the database
**
** Pedro Abreu & João Gameiro
 */

 /* Eventos de um promotor especifico */
SELECT * 
FROM EM.EVENTO
WHERE cc_promotor = 22303412;

/*	Promotores com mais do que um evento */
SELECT EM.PROMOTOR.nome, numCC, email, telefone, COUNT(id) as numEventos
FROM EM.PROMOTOR, EM.EVENTO
WHERE numCC = cc_promotor
GROUP BY EM.PROMOTOR.nome, numCC, email, telefone
HAVING  COUNT(id) > 1;

/* Promotores dos eventos com mais de um dia */
SELECT EM.PROMOTOR.nome, numCC, email, telefone
FROM EM.EVENTO, EM.PROMOTOR
WHERE numdias > 1 AND cc_promotor = numCC;

/* Promotores dos eventos que a acontecer a partir de 2020 */
SELECT EM.PROMOTOR.nome, numCC, email, telefone
FROM EM.EVENTO, EM.PROMOTOR
WHERE dataini > '2019-12-31' AND cc_promotor = numCC;

/* Promotores de eventos com mais de 3 concertos */
SELECT numCC, EM.PROMOTOR.nome, EM.EVENTO.id, EM.EVENTO.nome, cc_promotor, COUNT(EM.EVENTO.nome) as numConcertos
FROM EM.EVENTO, EM.CONCERTO, EM.PROMOTOR
WHERE id_evento = EM.EVENTO.id AND EM.EVENTO.cc_promotor = numCC
GROUP BY numCC, EM.PROMOTOR.nome, EM.EVENTO.id, EM.EVENTO.nome, cc_promotor
HAVING COUNT(EM.EVENTO.nome) > 3;


/* Eventos cujo número de bilhetes seja maior que a média de todos os bilhetes vendidos */
SELECT id, nome, numdias, numbilhetes 
FROM EM.EVENTO
WHERE numbilhetes > ANY( SELECT AVG(numbilhetes) as media_bilhetes
						 FROM EM.EVENTO);

