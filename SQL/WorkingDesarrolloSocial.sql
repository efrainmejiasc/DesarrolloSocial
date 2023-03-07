SELECT  * FROM CargaFJefeDefamilia
SELECT  * FROM CargaFAdultos
SELECT  * FROM CargaFAdultosMayores
SELECT  * FROM CargaFamiliar
SELECT  * FROM CargaFAdolescentes
SELECT  * FROM CargaFNiños

SELECT * FROM Responsabledefamilia

SELECT * FROM  Gestores
Select * FROM DatosPrincipalesRG

--truncate table CargaFamiliar
--truncate table Gestores
--update DatosPrincipalesRG SET IdGestor = 1

SELECT A.*,B.*,C.*,D.*  FROM CargaFJefeDefamilia A 
                INNER JOIN  CargaFAdolescentes B ON A.Id = B.IDCargaFamiliar
				INNER JOIN  CargaFAdultos C ON A.Id = C.IDCargaFamiliar
				INNER JOIN  CargaFNiños D ON A.Id = D.IDCargaFamiliar
				INNER JOIN  CargaFAdultosMayores E ON A.Id = C.IDCargaFamiliar
		
		SELECT A.*,B.*  FROM CargaFJefeDefamilia A 