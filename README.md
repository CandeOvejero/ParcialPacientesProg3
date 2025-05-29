Un hospital necesita una pequeña aplicación web para registrar los pacientes que son atendidos. tu tarea es implementar las vistas necesarias para: registrar un paciente, ver el listado de todos los pacientes registrados

registros funcionales: se debe permitir registrar un paciente con los siguientes datos: 
NOMBRE DE CAMPO | TIPO DE DATO    | VALIDACION
nombre		      | campo de texto  | no vacio
obra social	    | select	        | que sea osde, pami, apross u otro
edad		        | numerico	      | que sea al menos 0
síntomas 	      | campo de texto  | no vacio

se deben validar los datos
luego de cargar un paciente, debe redirigir al listado
en el listado de pacientes, se deben mostrar todos los datos en una lista ordenada
