select * from TipoTramite

INSERT INTO TipoTramite Values (2,'Rectificaci�n de domicilio')
INSERT INTO TipoTramite Values (3,'Rectificaci�n del estado civil')
INSERT INTO TipoTramite Values (4,'Certificado de Inscripci�n (C4)')
INSERT INTO TipoTramite Values (5,'Copias certificadas de actas/partidas')
INSERT INTO TipoTramite Values (6,'Validaci�n de copias certificadas')
INSERT INTO TipoTramite Values (7,'Acceso a la Informaci�n P�blica')
INSERT INTO TipoTramite Values (8,'Asignar/Cambiar Domicilio Electr�nico')
DELETE FROM TipoTramite WHERE ID_TipoTramite = 2

--UPDATE TipoTramite SET TipoTramite = 'Duplicado de DNI/DNIe' WHERE ...