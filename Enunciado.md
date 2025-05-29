## Descripción
Esta aplicación web permite registrar pacientes atendidos en un hospital y visualizar un listado de los mismos.

## Requisitos
Los pacientes deben registrarse con los siguientes datos:
- **Nombre** (campo de texto, obligatorio)
- **Obra Social** (select, debe ser OSDE, PAMI, APROSS u otro)
- **Edad** (numérico, mínimo 0)
- **Síntomas** (campo de texto, obligatorio)

## Funcionalidades
- **Registro de Paciente**: Se valida cada campo antes de guardar los datos.
- **Listado de Pacientes**: Muestra todos los pacientes registrados en una lista ordenada.
- **Redirección**: Luego de registrar un paciente, el sistema redirige automáticamente al listado.
