-- Procedimiento almacenado para filtrar carreras por facultad seleccionada en el formulario desde la tabla Facultad--

CREATE PROCEDURE [dbo].[sp_FiltrarCarrera]
@Facultad varchar(50)
AS
BEGIN
SELECT * FROM Carrera WHERE Facultad = @Facultad
END

	
	
USE [UTP_1]
GO
/****** Object:  StoredProcedure [dbo].[sp_Estudiante_Select]    Script Date: 12/04/2022 12:16:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_Estudiante_Select] 
@cedula as char(15) = null,
@order as char(30) = null
as
   if(@cedula is null)
     if (@order is null)
      select * from estudiante, Facultad, carrera where cod_facultad = codigo_fac and cod_carrera = codigo_carrera
	  else
	      select * from estudiante, Facultad, carrera where cod_facultad = codigo_fac and cod_carrera = codigo_carrera order by
		  case
		      when @order = 'cedula' then cedula
			  when @order = 'nombre' then nombre
			  when @order = 'apellido' then apellido
			  end
	else
	select * from estudiante, Facultad, carrera where cedula = @cedula and cod_facultad = codigo_fac

-- LISTAR ESTUDIANTES Y ORDENAR POR CEDULA, NOMBRE O APELLIDO--


--insertar nueva carrera--

CREATE PROCEDURE [dbo].[sp_InsertarCarrera]
@facultad varchar(50)
@codigo_carrera varchar(50),
@nombre_carrera varchar(50),

AS
BEGIN
INSERT INTO Carrera VALUES (@facultad, @codigo_carrera, @nombre_carrera)
END

CREATE PROCEDURE [dbo].[sp_InsertarCarrera]
@cod_fac varchar(50),
@codigo_carrera varchar(50),
@nombre_carrera varchar(50)
AS
BEGIN
INSERT INTO Carrera VALUES (@cod_fac, @codigo_carrera, @nombre_carrera)
END
