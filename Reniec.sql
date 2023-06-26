select * from TipoTramite

INSERT INTO TipoTramite Values (2,'Rectificación de domicilio')
INSERT INTO TipoTramite Values (3,'Rectificación del estado civil')
INSERT INTO TipoTramite Values (4,'Certificado de Inscripción (C4)')
INSERT INTO TipoTramite Values (5,'Copias certificadas de actas/partidas')
INSERT INTO TipoTramite Values (6,'Validación de copias certificadas')
INSERT INTO TipoTramite Values (7,'Acceso a la Información Pública')
INSERT INTO TipoTramite Values (8,'Asignar/Cambiar Domicilio Electrónico')
DELETE FROM TipoTramite WHERE ID_TipoTramite = 2

--UPDATE TipoTramite SET TipoTramite = 'Duplicado de DNI/DNIe' WHERE ...