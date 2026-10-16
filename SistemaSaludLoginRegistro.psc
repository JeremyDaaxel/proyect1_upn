
Algoritmo SistemaSaludLoginRegistro
	
	// Declaración de variables de Paciente
	Definir pacNombre, pacApellido, pacCelular, pacTieneSIS, pacClaveGenerada Como Cadena
	
	// Variables para la cita médica
	Definir fechaCita, especialidad Como Cadena
	Definir costoCita Como Entero
	
	// Variables para el registro de Tópico (Signos Vitales)
	Definir temperatura, talla, peso Como Real
	Definir presionArterial Como Cadena
	
	// Variables para el registro del Doctor (Diagnóstico y Medicamentos)
	Definir diagnostico, medicamentos Como Cadena
	
	// Variables de login y navegación
	Definir usuario, clave Como Cadena
	Definir opcionUsuario, opcionMenu Como Entero
	Definir autenticado Como Logico
	Definir salirPrograma Como Logico
	
	salirPrograma <- Falso
	pacClaveGenerada <- ""
	
	// Valores iniciales por defecto para pruebas
	pacNombre <- "Juan"
	pacApellido <- "Pérez"
	pacCelular <- "999888777"
	pacTieneSIS <- "NO"
	pacClaveGenerada <- "PAC2026"
	fechaCita <- "20/10/2026"
	especialidad <- "Medicina General"
	temperatura <- 36.5
	presionArterial <- "120/80"
	talla <- 1.75
	peso <- 70.0
	
	Repetir
		autenticado <- Falso
		Limpiar Pantalla
		
		Escribir "======================================="
		Escribir "   SISTEMA DE GESTION MEDICA Y SALUD   "
		Escribir "======================================="
		Escribir "Seleccione el tipo de usuario para ingresar:"
		Escribir "1. Paciente"
		Escribir "2. Tópico / Triaje"
		Escribir "3. Doctor / Médico"
		Escribir "4. Salir"
		Escribir "---------------------------------------"
		Escribir Sin Saltar "Ingrese una opción (1-4): "
		Leer opcionUsuario
		
		Si opcionUsuario = 1 Entonces
			// -------------------------------------------------------------
			// REGISTRO PREVIO PARA PACIENTE
			// -------------------------------------------------------------
			Escribir ""
			Escribir "======================================="
			Escribir "         REGISTRO DE PACIENTE          "
			Escribir "======================================="
			Escribir Sin Saltar "Ingrese su Nombre: "
			Leer pacNombre
			Escribir Sin Saltar "Ingrese su Apellido: "
			Leer pacApellido
			Escribir Sin Saltar "Ingrese su Número de Celular: "
			Leer pacCelular
			
			Escribir "¿Pertenece al SIS? (SI / NO): "
			Leer pacTieneSIS
			pacTieneSIS <- Mayusculas(pacTieneSIS)
			
			// Asignación de contraseña automática
			pacClaveGenerada <- "PAC2026"
			
			Escribir "---------------------------------------"
			Escribir "¡Registro realizado y guardado con éxito!"
			Escribir "Su contraseña asignada es: ", pacClaveGenerada
			Escribir "---------------------------------------"
			Escribir "Presione ENTER para ir al Inicio de Sesión..."
			Esperar Tecla
			Limpiar Pantalla
			
			// -------------------------------------------------------------
			// INICIO DE SESIÓN PACIENTE (SOLO CLAVE)
			// -------------------------------------------------------------
			Escribir "======================================="
			Escribir "       INICIO DE SESIÓN PACIENTE        "
			Escribir "======================================="
			Escribir Sin Saltar "Ingrese su clave asignada: "
			Leer clave
			
			Si clave = pacClaveGenerada Entonces
				autenticado <- Verdadero
			SiNo
				Escribir "Error: La clave ingresada es incorrecta."
				Escribir "Presione ENTER para volver al menú principal..."
				Esperar Tecla
			FinSi
			
		SiNo
			Si opcionUsuario = 2 O opcionUsuario = 3 Entonces
				// -------------------------------------------------------------
				// INICIO DE SESIÓN TÓPICO / DOCTOR
				// -------------------------------------------------------------
				Escribir ""
				Escribir "--- INICIO DE SESIÓN ---"
				Escribir Sin Saltar "Usuario: "
				Leer usuario
				Escribir Sin Saltar "Contraseña: "
				Leer clave
				
				Si opcionUsuario = 2 Y usuario = "topico" Y clave = "top123" Entonces
					autenticado <- Verdadero
				SiNo
					Si opcionUsuario = 3 Y usuario = "doctor" Y clave = "doc123" Entonces
						autenticado <- Verdadero
					SiNo
						Escribir "Error: Credenciales incorrectas."
						Escribir "Presione ENTER para volver al menú principal..."
						Esperar Tecla
					FinSi
				FinSi
			SiNo
				Si opcionUsuario = 4 Entonces
					salirPrograma <- Verdadero
				SiNo
					Escribir "Opción no válida. Presione ENTER para continuar..."
					Esperar Tecla
				FinSi
			FinSi
		FinSi
		
		// -------------------------------------------------------------
		// PANEL Y MÓDULOS DE ATENCIÓN POST-LOGIN
		// -------------------------------------------------------------
		Si autenticado Entonces
			Escribir ""
			Escribir "¡Acceso concedido! Bienvenido/a al sistema."
			Escribir ""
			
			Segun opcionUsuario Hacer
				1:
					// PANEL PACIENTE - PROGRAMACIÓN DE CITA
					Escribir "======================================="
					Escribir "           PANEL DE PACIENTE           "
					Escribir "======================================="
					Escribir "1. Realizar / Programar Cita Médica"
					Escribir "2. Cerrar sesión (Volver al menú principal)"
					Escribir "---------------------------------------"
					Escribir Sin Saltar "Seleccione una opción: "
					Leer opcionMenu
					
					Si opcionMenu = 1 Entonces
						Escribir ""
						Escribir "--- PROGRAMACIÓN DE CITA MÉDICA ---"
						
						// Muestra de datos guardados previamente
						Escribir "Datos del Paciente:"
						Escribir " - Nombre completo: ", pacNombre, " ", pacApellido
						Escribir " - Teléfono: ", pacCelular
						Escribir " - ¿Cuenta con SIS?: ", pacTieneSIS
						Escribir "-----------------------------------"
						
						// Ingreso de datos de la cita
						Escribir Sin Saltar "Ingrese la fecha de la cita (ej. DD/MM/AAAA): "
						Leer fechaCita
						Escribir Sin Saltar "Ingrese la especialidad médica: "
						Leer especialidad
						
						// Cálculo estricto del costo según SIS
						Si pacTieneSIS = "SI" O pacTieneSIS = "S" Entonces
							costoCita <- 0
						SiNo
							costoCita <- 20
						FinSi
						
						Escribir ""
						Escribir "======================================="
						Escribir "       RESUMEN DE CITA GENERADA        "
						Escribir "======================================="
						Escribir "Paciente: ", pacNombre, " ", pacApellido
						Escribir "Fecha de atención: ", fechaCita
						Escribir "Especialidad: ", especialidad
						
						Si costoCita = 0 Entonces
							Escribir "Monto a pagar: S/ 0 (Cobertura total por SIS)"
						SiNo
							Escribir "Monto a pagar: S/ ", costoCita, " soles (Sin SIS)"
						FinSi
						Escribir "---------------------------------------"
						Escribir "¡Su cita ha sido registrada con éxito!"
						Escribir ""
						Escribir "Presione ENTER para retornar al menú principal..."
						Esperar Tecla
					SiNo
						Escribir "Cerrando sesión..."
						Esperar 1 Segundos
					FinSi
					
				2:
					// PANEL TÓPICO / TRIAJE
					Escribir "========= PANEL DE TÓPICO / TRIAJE ========="
					Escribir "1. Registrar Triaje (Temperatura, Presión, Talla, Peso)"
					Escribir "2. Cerrar sesión"
					Escribir Sin Saltar "Seleccione una opción: "
					Leer opcionMenu
					
					Si opcionMenu = 1 Entonces
						Escribir ""
						Escribir "--- DATOS DEL PACIENTE Y CITA PROGRAMADA ---"
						Escribir " - Paciente: ", pacNombre, " ", pacApellido
						Escribir " - Celular: ", pacCelular
						Escribir " - ¿Tiene SIS?: ", pacTieneSIS
						Escribir " - Fecha de Cita: ", fechaCita
						Escribir " - Especialidad: ", especialidad
						Escribir "--------------------------------------------"
						Escribir "Ingrese los signos vitales:"
						Escribir Sin Saltar " - Temperatura (°C, ej. 36.5): "
						Leer temperatura
						Escribir Sin Saltar " - Presión Arterial (ej. 120/80): "
						Leer presionArterial
						Escribir Sin Saltar " - Talla (m, ej. 1.70): "
						Leer talla
						Escribir Sin Saltar " - Peso (kg, ej. 70.5): "
						Leer peso
						
						Escribir ""
						Escribir "--------------------------------------------"
						Escribir "Guardado, enviado a doctor"
						Escribir "--------------------------------------------"
						Escribir "Presione ENTER para retornar al menú principal..."
						Esperar Tecla
					FinSi
					
				3:
					// PANEL DOCTOR
					Escribir "======================================="
					Escribir "            PANEL DE DOCTOR            "
					Escribir "======================================="
					Escribir "1. Atender consulta médica (Diagnóstico y Receta)"
					Escribir "2. Cerrar sesión"
					Escribir Sin Saltar "Seleccione una opción: "
					Leer opcionMenu
					
					Si opcionMenu = 1 Entonces
						Escribir ""
						Escribir "--- EXPEDIENTE Y TRIAJE DEL PACIENTE ---"
						Escribir " - Paciente: ", pacNombre, " ", pacApellido
						Escribir " - Cita: ", fechaCita, " (", especialidad, ")"
						Escribir " - Signos Vitales (Tópico):"
						Escribir "   * Temperatura: ", temperatura, " °C"
						Escribir "   * Presión: ", presionArterial
						Escribir "   * Talla: ", talla, " m"
						Escribir "   * Peso: ", peso, " kg"
						Escribir "---------------------------------------"
						
						// Registro de Diagnóstico y Medicamentos
						Escribir Sin Saltar "Ingrese el Diagnóstico médico: "
						Leer diagnostico
						Escribir Sin Saltar "Ingrese la Receta / Medicamentos: "
						Leer medicamentos
						
						Escribir ""
						Escribir "======================================="
						Escribir "       RESUMEN DE ATENCIÓN MÉDICA      "
						Escribir "======================================="
						Escribir "Paciente: ", pacNombre, " ", pacApellido
						Escribir "Diagnóstico: ", diagnostico
						Escribir "Medicamentos prescritos: ", medicamentos
						Escribir "---------------------------------------"
						Escribir "Consulta terminada"
						Escribir "---------------------------------------"
						Escribir "Presione ENTER para volver al menú principal..."
						Esperar Tecla
					FinSi
			FinSegun
		FinSi
		
	Hasta Que salirPrograma = Verdadero
	
	Escribir ""
	Escribir "Saliendo del sistema. ¡Hasta luego!"

FinAlgoritmo