﻿using Helpers;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaDatos
{
    public class DatosIniciales
    {
        public enum ListasTipo
        {
            Asistencias, Cargos, Ciudades,
            Contratos, Departamentos, DiscapacidadEmpleados,
            Empleados, JornadaTrabajos, Pais,
            Permisos, Regiones, RolPagos,
            Rubros, RubrosEmpleados, TipoContratos,
            TipoPermisos, TipoDiscapacidad
        }

        public Dictionary<ListasTipo, object> Carga()
        {
            /*=======================================
             *                  Pais
             *=======================================*/
            #region
            Pais ecuador = new Pais()
            {
                Nombre_Pais = "Ecuador"
            };
            #endregion
            /*=======================================
             *           Lista de Regiones
             *=======================================*/
            #region
            Region sierra = new Region()
            {
                Nombre_Region = Regiones.Sierra,
                Paises = ecuador
            };
            Region costa = new Region()
            {
                Nombre_Region = Regiones.Costa,
                Paises = ecuador
            };
            Region amazonia = new Region()
            {
                Nombre_Region = Regiones.Amazonia,
                Paises = ecuador
            };
            List<Region> listaRegion = new List<Region>()
            {
                costa, sierra, amazonia
            };
            #endregion

            /*=======================================
            *       Lista de Departamentos
            *======================================= */
            #region
            Departamento sistemas = new Departamento()
            {
                Nombre_Departamento = "Sistemas",
            };
            Departamento rrhh = new Departamento()
            {
                Nombre_Departamento = "RRHH"
            };
            Departamento finanzas = new Departamento()
            {
                Nombre_Departamento = "Finanzas"
            };
            List<Departamento> listaDepartamentos = new List<Departamento>()
            {
                sistemas, rrhh, finanzas
            };
            #endregion
            /*=======================================
            *           Lista de Cargos
            *======================================= */
            #region
            Cargo analista = new Cargo()
            {
                Nombre_Cargo = "Analista",
                Departamentos = sistemas
            };
            Cargo formacion = new Cargo()
            {
                Nombre_Cargo = "Formación",
                Departamentos = rrhh
            };
            Cargo contabilidad = new Cargo()
            {
                Nombre_Cargo = "Contabilidad",
                Departamentos = finanzas
            };
            List<Cargo> listaCargos = new List<Cargo>()
            {
                analista, contabilidad, formacion
            };
            #endregion

            /*=======================================
            *       Lista de Tipo de Permisos
            *======================================= */
            #region
            TipoPermiso tipoPermisoMatrimonio = new TipoPermiso()
            {
                Nombre_Tipo_Permiso = "Matrimonio",
                Descripcion_Tipo_Permiso = "Se debe informar con quince días de antelación "
            };
            TipoPermiso tipoPermisoNacimiento = new TipoPermiso()
            {
                Nombre_Tipo_Permiso = "Nacimiento de hijo",
                Descripcion_Tipo_Permiso = "Se tiene 8 semanas"
            };
            TipoPermiso tipoPermisoFallecimiento = new TipoPermiso()
            {
                Nombre_Tipo_Permiso = "Fallecimiento de un familiar",
                Descripcion_Tipo_Permiso = "Se tiene de 2 a 4 días"
            };
            TipoPermiso tipoPermisoEnfermedad = new TipoPermiso()
            {
                Nombre_Tipo_Permiso = "Acidente o enfermedad grave",
                Descripcion_Tipo_Permiso = "Depende de si es por enfermedad común" +
                " o si se provocado por algún asunto dentro de la empresa"
            };
            TipoPermiso tipoPermisoHospitalizacion = new TipoPermiso()
            {
                Nombre_Tipo_Permiso = "Hospitalización o intervención quirúrgica",
                Descripcion_Tipo_Permiso = "Se requiera reposo domiciliario de parientes " +
                "hasta segundo grado de consanguinidad o afinidad"
            };
            TipoPermiso tipoPermisoMudanza = new TipoPermiso()
            {
                Nombre_Tipo_Permiso = "Traslado de domicilio habitual",
                Descripcion_Tipo_Permiso = "Se establece un día libre el permiso por mudanza"
            };
            TipoPermiso tipoPermisoCompromiso = new TipoPermiso()
            {
                Nombre_Tipo_Permiso = "Compromiso inexcusable de carácter público o personal",
                Descripcion_Tipo_Permiso = "En caso de que el empleado reciba algún tipo de indemnización por su labor, " +
                "esta se le desconectará del salario que corresponda."
            };
            TipoPermiso tipoPermisoNacimientoBebePrematuro = new TipoPermiso()
            {
                Nombre_Tipo_Permiso = "Nacimiento prematuro del hijo/a",
                Descripcion_Tipo_Permiso = "En esos supuestos, o debido a cualquier hecho, " +
                "en el que deban permanecer hospitalizados."
            };
            TipoPermiso tipoPermisoAsistenciaExamenes = new TipoPermiso()
            {
                Nombre_Tipo_Permiso = "Asistencia a exámenes",
                Descripcion_Tipo_Permiso = "Se considera parte de los permisos debido a la retribución laboral la ausencia " +
                ".para la presentación de exámenes académicos o profesionales."
            };
            List<TipoPermiso> listaTipoPermisos = new List<TipoPermiso>()
            {
                tipoPermisoMatrimonio, tipoPermisoNacimiento, tipoPermisoFallecimiento, tipoPermisoEnfermedad,
                tipoPermisoHospitalizacion, tipoPermisoMudanza, tipoPermisoCompromiso, tipoPermisoNacimientoBebePrematuro,
                tipoPermisoAsistenciaExamenes
            };
            #endregion
            /*=======================================
            *       Lista de Permisos
            *======================================= */
            #region
            Permiso permisoMatrimonio = new Permiso()
            {
                Nombre_Permiso = "Permiso por matrimonio",
                Tipo_Permisos = tipoPermisoMatrimonio,
                Fecha_Inicio_Permiso = new DateTime(2020, 2, 15),
                Fecha_Fin_Permiso = new DateTime(2020, 3, 1),
                Hora_Inicio = "8:00 am",
                Hora_Fin = "8:00 am",
                Estado_Permiso = "Finalizado"
            };
            Permiso permisoNacimientoHijo = new Permiso()
            {
                Nombre_Permiso = "Permiso por nacimiento de hijo",
                Tipo_Permisos = tipoPermisoNacimiento,
                Fecha_Inicio_Permiso = new DateTime(2021, 10, 15),
                Fecha_Fin_Permiso = new DateTime(2022, 2, 15),
                Hora_Inicio = "11:00 am",
                Hora_Fin = "11:00 am",
                Estado_Permiso = "Vigente"
            };
            Permiso permisoFallecimiento = new Permiso()
            {
                Nombre_Permiso = "Permiso por fallecimiento de hijo y/o familiar",
                Tipo_Permisos = tipoPermisoFallecimiento,
                Fecha_Inicio_Permiso = new DateTime(2022, 1, 15),
                Fecha_Fin_Permiso = new DateTime(2022, 1, 20),
                Hora_Inicio = "14:30 pm",
                Hora_Fin = "14:30 pm",
                Estado_Permiso = "Finalizado"
            };
            Permiso permisoAccidente = new Permiso()
            {
                Nombre_Permiso = "Permiso por accidente o enfermedad grave",
                Tipo_Permisos = tipoPermisoEnfermedad,
                Fecha_Inicio_Permiso = new DateTime(2021, 1, 15),
                Fecha_Fin_Permiso = new DateTime(2022, 4, 15),
                Hora_Inicio = "13:30 pm",
                Hora_Fin = "13:30 pm",
                Estado_Permiso = "Finalizado"
            };
            Permiso permisoHospitalizacion = new Permiso()
            {
                Nombre_Permiso = "Permiso por hospitalización o intervención quirúrgica",
                Tipo_Permisos = tipoPermisoHospitalizacion,
                Fecha_Inicio_Permiso = new DateTime(2022, 1, 15),
                Fecha_Fin_Permiso = new DateTime(2022, 4, 15),
                Hora_Inicio = "13:30 pm",
                Hora_Fin = "13:30 pm",
                Estado_Permiso = "Vigente"
            };
            Permiso permisoMudanza = new Permiso()
            {
                Nombre_Permiso = "Permiso por traslado domiciliario",
                Tipo_Permisos = tipoPermisoMudanza,
                Fecha_Inicio_Permiso = new DateTime(2021, 1, 15),
                Fecha_Fin_Permiso = new DateTime(2021, 1, 16),
                Hora_Inicio = "13:30 pm",
                Hora_Fin = "13:30 pm",
                Estado_Permiso = "Finalizado"
            };
            Permiso permisoCompromiso = new Permiso()
            {
                Nombre_Permiso = "Permiso por Compromiso de carácter público",
                Tipo_Permisos = tipoPermisoCompromiso,
                Fecha_Inicio_Permiso = new DateTime(2021, 1, 15),
                Fecha_Fin_Permiso = new DateTime(2022, 3, 15),
                Hora_Inicio = "13:30 pm",
                Hora_Fin = "13:30 pm",
                Estado_Permiso = "Finalizado"
            };
            Permiso permisoBebePrematuro = new Permiso()
            {
                Nombre_Permiso = "Permiso por nacimiento de bebé prematuro",
                Tipo_Permisos = tipoPermisoNacimientoBebePrematuro,
                Fecha_Inicio_Permiso = new DateTime(2021, 1, 15),
                Fecha_Fin_Permiso = new DateTime(2022, 1, 15),
                Hora_Inicio = "9:00 am",
                Hora_Fin = "18:00 pm",
                Estado_Permiso = "Finalizado"
            };
            Permiso permisoAsistenciaExamanes = new Permiso()
            {
                Nombre_Permiso = "Permiso por asistencia a exámenes",
                Tipo_Permisos = tipoPermisoAsistenciaExamenes,
                Fecha_Inicio_Permiso = new DateTime(2021, 1, 15),
                Fecha_Fin_Permiso = new DateTime(2022, 4, 15),
                Hora_Inicio = "13:30 pm",
                Hora_Fin = "13:30 pm",
                Estado_Permiso = "Finalizado"
            };
            List<Permiso> listaPermisos = new List<Permiso>()
            {
                permisoMatrimonio, permisoNacimientoHijo, permisoFallecimiento,
                permisoAccidente, permisoHospitalizacion, permisoMudanza,
                permisoCompromiso, permisoBebePrematuro, permisoAsistenciaExamanes
            };
            #endregion
            /*=======================================
            *       Lista de Jornada de Trabajo
            *======================================= */
            #region
            JornadaTrabajo ordinaria = new JornadaTrabajo()
            {
                Tipo_Jornada = JornadaTipo.Ordinaria
            };
            JornadaTrabajo nocturna = new JornadaTrabajo()
            {
                Tipo_Jornada = JornadaTipo.Nocturna
            };
            List<JornadaTrabajo> listaJornadoTrabajos = new List<JornadaTrabajo>()
            {
                ordinaria, nocturna
            };
            #endregion

            /*=======================================
            *               Asistencia
            *======================================= */
            #region
            Asistencia asistenciaOrdinaria = new Asistencia()
            {
                Hora_Inicio = new DateTime(2021, 1, 5, 8, 0, 0),
                Hora_Fin = new DateTime(2021, 1, 5, 18, 0, 0),
                Tipo_Asistencia = "Jornada normal de trabajo"
            };
            Asistencia asistenciaNocturna = new Asistencia()
            {
                Hora_Inicio = new DateTime(2021, 1, 5, 15, 0, 0),
                Hora_Fin = new DateTime(2021, 1, 6, 0, 0, 0),
                Tipo_Asistencia = "Jornada normal de trabajo"
            };
            List<Asistencia> listaAsistencia = new List<Asistencia>()
            {
                asistenciaOrdinaria, asistenciaNocturna
            };
            #endregion
            /*=======================================
            *          Lista de Empleados
            *======================================= */
            #region

            Empleado TamaraBravo = new Empleado()
            {
                Apellidos_Empleado = "TAMARA KATHERINE",
                Nombres_Empleado = "BRAVO ASTUDILLO",
                Cedula_Empleado = "170934611-6",
                Email_Empleado = "tbravo@mail.com",
                Celular_Empleado = "0963258741",
                Profesion_Empleado = "Ingeniero en Sistemas",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Femenino,
                Estado_Civil = EstadoCivil.Separado,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Corriente,
                Numero_Cuenta = "3359628741",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoMatrimonio,
                AsistenciaEmpleados = asistenciaOrdinaria,
            };

            Empleado AnaBravo = new Empleado()
            {
                Apellidos_Empleado = "ANA LEÓNOR",
                Nombres_Empleado = "BRAVO BASTIDAS",
                Cedula_Empleado = "080067255-2",
                Email_Empleado = "abravo@mail.com",
                Celular_Empleado = "0952368741",
                Profesion_Empleado = "Ingeniero en Sistemas",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Femenino,
                Estado_Civil = EstadoCivil.Casado,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Ahorros,
                Numero_Cuenta = "2258963158",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoMudanza,
                AsistenciaEmpleados = asistenciaOrdinaria
            };

            Empleado FlavioBravo = new Empleado()
            {
                Apellidos_Empleado = "FLAVIO GEOVANNY",
                Nombres_Empleado = "BRAVO LUZURIAGA",
                Cedula_Empleado = "110212185-0",
                Email_Empleado = "fbravo@mail.com",
                Celular_Empleado = "0970171302",
                Profesion_Empleado = "Ingeniero en Contabilidad",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Masculino,
                Estado_Civil = EstadoCivil.Divorciado,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Ahorros,
                Numero_Cuenta = "2257896321",
                sueldo = 1200.00,
                Jornada_Trabajo = nocturna,
                Permiso = permisoFallecimiento,
                AsistenciaEmpleados = asistenciaNocturna
            };

            Empleado IsabellaOlmedo = new Empleado()
            {
                Apellidos_Empleado = "Isabella Patricia",
                Nombres_Empleado = "Olmedo Jimenez",
                Cedula_Empleado = "178523694",
                Email_Empleado = "iolmedo@mail.com",
                Celular_Empleado = "0930806804",
                Profesion_Empleado = "Ingeniera Sistemas",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Femenino,
                Estado_Civil = EstadoCivil.Soltero,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Ahorros,
                Numero_Cuenta = "2210361461",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoHospitalizacion,
                AsistenciaEmpleados = asistenciaOrdinaria
            };

            Empleado CarlosBravo = new Empleado()
            {
                Apellidos_Empleado = "CARLOS RICARTE",
                Nombres_Empleado = "BRAVO MEDINA",
                Cedula_Empleado = "070068556-3",
                Email_Empleado = "cbravo@mail.com",
                Celular_Empleado = "0970167513",
                Profesion_Empleado = "Ingeniero en Sistemas",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Masculino,
                Estado_Civil = EstadoCivil.Soltero,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Corriente,
                Numero_Cuenta = "3330262096",
                Jornada_Trabajo = ordinaria,
                Permiso = permisoMatrimonio,
                sueldo = 1200.00,
                AsistenciaEmpleados = asistenciaOrdinaria,
            };

            Empleado PedroGomez = new Empleado()
            {
                Apellidos_Empleado = "Pedro Pablo",
                Nombres_Empleado = "Gomez Heredia",
                Cedula_Empleado = "1785236940",
                Email_Empleado = "pgomez@mail.com",
                Celular_Empleado = "091398427",
                Profesion_Empleado = "Ingeniero en Sistemas",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Masculino,
                Estado_Civil = EstadoCivil.Casado,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Ahorros,
                Numero_Cuenta = "2220449982",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoMudanza,
                AsistenciaEmpleados = asistenciaOrdinaria
            };

            Empleado KarlaNajarez = new Empleado()
            {
                Apellidos_Empleado = "Karen Yoali",
                Nombres_Empleado = "Najarez Gonzales",
                Cedula_Empleado = "0963258741",
                Email_Empleado = "knajarez@mail.com",
                Celular_Empleado = "09130840118",
                Profesion_Empleado = "Ingeniera en Sitemas",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Femenino,
                Estado_Civil = EstadoCivil.Soltero,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Ahorros,
                Numero_Cuenta = "2210417740",
                sueldo = 1200.00,
                Jornada_Trabajo = nocturna,
                Permiso = permisoFallecimiento,
                AsistenciaEmpleados = asistenciaNocturna
            };

            Empleado FernandoBrayanes = new Empleado()
            {
                Apellidos_Empleado = "FERNANDO ALFONSO",
                Nombres_Empleado = "BRAYANES LIMA",
                Cedula_Empleado = "110296705-4",
                Email_Empleado = "fbrayanes@mail.com",
                Celular_Empleado = "0970301806",
                Profesion_Empleado = "Ingeniera Sistemas",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Masculino,
                Estado_Civil = EstadoCivil.Separado,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Ahorros,
                Numero_Cuenta = "2271082337",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoHospitalizacion,
                AsistenciaEmpleados = asistenciaOrdinaria
            };

            Empleado EnriqueBriones = new Empleado()
            {
                Apellidos_Empleado = "ENRIQUE SANTIAGO",
                Nombres_Empleado = "BRIONES SOTOMAYOR",
                Cedula_Empleado = "120122184-1",
                Email_Empleado = "ebriones@mail.com",
                Celular_Empleado = "090020556",
                Profesion_Empleado = "Ingeniero en Comercial",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Masculino,
                Estado_Civil = EstadoCivil.Viudo,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Corriente,
                Numero_Cuenta = "3370200462",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoMatrimonio,
                AsistenciaEmpleados = asistenciaOrdinaria,
            };

            Empleado EdmundoBriones = new Empleado()
            {
                Apellidos_Empleado = "EDMUNDO ALBERTO",
                Nombres_Empleado = "BRIONES VALERO",
                Cedula_Empleado = "091389696-5",
                Email_Empleado = "eabriones@mail.com",
                Celular_Empleado = "0970771737",
                Profesion_Empleado = "Ingeniero en Comercial",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Otro,
                Estado_Civil = EstadoCivil.Casado,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Corriente,
                Numero_Cuenta = "3370326986",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoMatrimonio,
                AsistenciaEmpleados = asistenciaOrdinaria,
            };

            Empleado JohanBriones = new Empleado()
            {
                Apellidos_Empleado = "JOHAN VINICIO",
                Nombres_Empleado = "BRIONES VALERO",
                Cedula_Empleado = "091643638-9",
                Email_Empleado = "jbriones@mail.com",
                Celular_Empleado = "090904641",
                Profesion_Empleado = "Ingeniero en Comercial",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Masculino,
                Estado_Civil = EstadoCivil.Casado,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Corriente,
                Numero_Cuenta = "3310325673",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoMatrimonio,
                AsistenciaEmpleados = asistenciaOrdinaria,
            };

            Empleado ArturoBrito = new Empleado()
            {
                Apellidos_Empleado = "ARTURO ALEXANDER",
                Nombres_Empleado = "BRITO CENTENO",
                Cedula_Empleado = "171351416-2",
                Email_Empleado = "abrito@mail.com",
                Celular_Empleado = "0980218574",
                Profesion_Empleado = "Ingeniero en Comercial",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Otro,
                Estado_Civil = EstadoCivil.Casado,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Ahorros,
                Numero_Cuenta = "2210185257",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoHospitalizacion,
                AsistenciaEmpleados = asistenciaOrdinaria
            };

            Empleado MaxBrito = new Empleado()
            {
                Apellidos_Empleado = "MAX PATRICIO",
                Nombres_Empleado = "BRITO CEVALLOS",
                Cedula_Empleado = "171048122-5",
                Email_Empleado = "mbrito@mail.com",
                Celular_Empleado = "0910349230",
                Profesion_Empleado = "Ingeniero en Contabilidad",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Masculino,
                Estado_Civil = EstadoCivil.Soltero,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Corriente,
                Numero_Cuenta = "3380272463",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoMatrimonio,
                AsistenciaEmpleados = asistenciaOrdinaria,
            };

            Empleado GuillermoBucheli = new Empleado()
            {
                Apellidos_Empleado = "GUILLERMO ALBERTO",
                Nombres_Empleado = "BUCHELI BONILLA",
                Cedula_Empleado = "130395263-2",
                Email_Empleado = "gbucheli@mail.com",
                Celular_Empleado = "0940023704",
                Profesion_Empleado = "Ingeniero en Contabilidad",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Otro,
                Estado_Civil = EstadoCivil.Soltero,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Corriente,
                Numero_Cuenta = "3330169264",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoMatrimonio,
                AsistenciaEmpleados = asistenciaOrdinaria,
            };

            Empleado RichardBuenano = new Empleado()
            {
                Apellidos_Empleado = "RICHARD IVÁN",
                Nombres_Empleado = "BUENANO LOJA",
                Cedula_Empleado = "120301590-2",
                Email_Empleado = "rbuenano@mail.com",
                Celular_Empleado = "0940068873",
                Profesion_Empleado = "Ingeniero en RRHH",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Masculino,
                Estado_Civil = EstadoCivil.Soltero,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Corriente,
                Numero_Cuenta = "3310311021",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoMatrimonio,
                AsistenciaEmpleados = asistenciaOrdinaria,
            };

            Empleado MyrianBunay = new Empleado()
            {
                Apellidos_Empleado = "MYRIAN DEL ROCÍO",
                Nombres_Empleado = "BUÑAY CUYO",
                Cedula_Empleado = "171245272-9",
                Email_Empleado = "mbunay@mail.com",
                Celular_Empleado = "0930754711",
                Profesion_Empleado = "Ingeniero en RRHH",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Femenino,
                Estado_Civil = EstadoCivil.Casado,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Corriente,
                Numero_Cuenta = "3330380154",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoMatrimonio,
                AsistenciaEmpleados = asistenciaOrdinaria,
            };

            Empleado AnacelinaBurbano = new Empleado()
            {
                Apellidos_Empleado = "ANACELIDA",
                Nombres_Empleado = "BURBANO JATIVA",
                Cedula_Empleado = "171111397-5",
                Email_Empleado = "aburbano@mail.com",
                Celular_Empleado = "0970293151",
                Profesion_Empleado = "Ingeniero en Contabilidad",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Femenino,
                Estado_Civil = EstadoCivil.Casado,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Corriente,
                Numero_Cuenta = "330339957",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoMatrimonio,
                AsistenciaEmpleados = asistenciaOrdinaria,
            };

            Empleado HectorBurneo = new Empleado()
            {
                Apellidos_Empleado = "HÉCTOR EFRÉN",
                Nombres_Empleado = "BURNEO SAAVEDRA",
                Cedula_Empleado = "110147302-1",
                Email_Empleado = "hBurneo@mail.com",
                Celular_Empleado = "0980082793",
                Profesion_Empleado = "Ingeniero en Contabilidad",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Otro,
                Estado_Civil = EstadoCivil.Soltero,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Ahorros,
                Numero_Cuenta = "2220208587",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoMudanza,
                AsistenciaEmpleados = asistenciaOrdinaria
            };

            Empleado FrankCaamano = new Empleado()
            {
                Apellidos_Empleado = "FRANK RICARDO",
                Nombres_Empleado = "CAAMAÑO OCHOA",
                Cedula_Empleado = "110355454-7",
                Email_Empleado = "fcaamano@mail.com",
                Celular_Empleado = "090153891",
                Profesion_Empleado = "Ingeniera en Contabilidad",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Masculino,
                Estado_Civil = EstadoCivil.Soltero,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Ahorros,
                Numero_Cuenta = "220278017",
                sueldo = 1200.00,
                Jornada_Trabajo = nocturna,
                Permiso = permisoFallecimiento,
                AsistenciaEmpleados = asistenciaNocturna
            };

            Empleado AndreaCabrera = new Empleado()
            {
                Apellidos_Empleado = "ANDREA ELIZABETH",
                Nombres_Empleado = "CABRERA ARIAS",
                Cedula_Empleado = "170766484-1",
                Email_Empleado = "acabrera@mail.com",
                Celular_Empleado = "0930122978",
                Profesion_Empleado = "Ingeniera Contabilidad",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Femenino,
                Estado_Civil = EstadoCivil.Separado,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Ahorros,
                Numero_Cuenta = "220185896",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoHospitalizacion,
                AsistenciaEmpleados = asistenciaOrdinaria
            }; ;

            Empleado RothmanCaceres = new Empleado()
            {
                Apellidos_Empleado = "ROTHMAN GERARDO",
                Nombres_Empleado = "CÁCERES MEDINA",
                Cedula_Empleado = "180344632-5",
                Email_Empleado = "rcaceres@mail.com",
                Celular_Empleado = "0920128751",
                Profesion_Empleado = "Ingeniero en Administracion",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Masculino,
                Estado_Civil = EstadoCivil.Casado,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Corriente,
                Numero_Cuenta = "3330150923",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoMatrimonio,
                AsistenciaEmpleados = asistenciaOrdinaria,
            };

            Empleado CarmenCadena = new Empleado()
            {
                Apellidos_Empleado = "CARMEN ELIZABETH",
                Nombres_Empleado = "CADENA CALLE",
                Cedula_Empleado = "070169712-0",
                Email_Empleado = "ccadena@mail.com",
                Celular_Empleado = "0970591891",
                Profesion_Empleado = "Ingeniero en Administracion",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Femenino,
                Estado_Civil = EstadoCivil.Viudo,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Ahorros,
                Numero_Cuenta = "2200148605",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoMudanza,
                AsistenciaEmpleados = asistenciaOrdinaria
            };

            Empleado MercedesCaicedo = new Empleado()
            {
                Apellidos_Empleado = "MERCEDES JOHANNA",
                Nombres_Empleado = "CAICEDO ALDAZ",
                Cedula_Empleado = "120591963-0",
                Email_Empleado = "mcaicedo@mail.com",
                Celular_Empleado = "0920503707",
                Profesion_Empleado = "Ingeniera en Administracion",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Femenino,
                Estado_Civil = EstadoCivil.Soltero,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Ahorros,
                Numero_Cuenta = "2210259930",
                sueldo = 1200.00,
                Jornada_Trabajo = nocturna,
                Permiso = permisoFallecimiento,
                AsistenciaEmpleados = asistenciaNocturna
            };

            Empleado LuciaCajamarca = new Empleado()
            {
                Apellidos_Empleado = "LUCÍA IRENE",
                Nombres_Empleado = "CAJAMARCA GUARTAZACA",
                Cedula_Empleado = "010259930-5",
                Email_Empleado = "lcajamarca@mail.com",
                Celular_Empleado = "0991516874",
                Profesion_Empleado = "Ingeniera Administracion",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = TipoSexo.Femenino,
                Estado_Civil = EstadoCivil.Soltero,
                Banco = "Pichincha",
                Tipo_Cuenta = TipoCuenta.Ahorros,
                Numero_Cuenta = "2280106861",
                sueldo = 1200.00,
                Jornada_Trabajo = ordinaria,
                Permiso = permisoHospitalizacion,
                AsistenciaEmpleados = asistenciaOrdinaria
            };


            List<Empleado> listaEmpleados1 = new List<Empleado>()
            {
                TamaraBravo, AnaBravo, FlavioBravo, CarlosBravo, FernandoBrayanes, EnriqueBriones,
                EdmundoBriones, JohanBriones, ArturoBrito, MaxBrito, GuillermoBucheli, RichardBuenano,
                MyrianBunay, AnacelinaBurbano, HectorBurneo, FrankCaamano, AndreaCabrera, RothmanCaceres,
                CarmenCadena, LuciaCajamarca ,MercedesCaicedo , PedroGomez, KarlaNajarez, IsabellaOlmedo
            };

            /*=======================================
            *           Lista de Ciudades
            *======================================= */
            #region
            Ciudad guayaquil = new Ciudad()
            {
                Nombre_Ciudad = "Guayaquil",
                Regiones = costa,
                Empleados = new List<Empleado>()
                {
                    TamaraBravo, AnaBravo, IsabellaOlmedo, CarlosBravo,
                    PedroGomez, KarlaNajarez, FernandoBrayanes
                }
            };
            Ciudad quito = new Ciudad()
            {
                Nombre_Ciudad = "Quito",
                Regiones = sierra,
                Empleados = new List<Empleado>()
                {
                    RichardBuenano, MyrianBunay, RothmanCaceres,
                    CarmenCadena, MercedesCaicedo, LuciaCajamarca
                }
            };
            Ciudad cuenca = new Ciudad()
            {
                Nombre_Ciudad = "Cuenca",
                Regiones = sierra,
                Empleados = new List<Empleado>()
                {
                    FlavioBravo, MaxBrito, GuillermoBucheli, AnacelinaBurbano,
                    HectorBurneo, FrankCaamano, AndreaCabrera
                }
            };
            Ciudad moronaSantiago = new Ciudad()
            {
                Nombre_Ciudad = "Morona Santiago",
                Regiones = amazonia,
                Empleados = new List<Empleado>()
                {
                    EnriqueBriones, EdmundoBriones, JohanBriones, ArturoBrito
                }
            };
            List<Ciudad> listaCiudades = new List<Ciudad>()
            {
                guayaquil, quito, cuenca, moronaSantiago
            };
            #endregion

            /*=======================================
            *       Lista de Tipo de Contrato
            *======================================= */
            #region
            TipoContrato tipoContratoPlazoFijo = new TipoContrato()
            {
                Nombre_Tipo_Contrato = "Contrato a Plazo Fijo",
                Descripcion_Tipo_Contrato = "Tiempo limitado"
            };
            TipoContrato tipoContratoPrueba = new TipoContrato()
            {
                Nombre_Tipo_Contrato = "Contrato de Prueba",
                Descripcion_Tipo_Contrato = "Trabajo por un tiempo"
            };
            List<TipoContrato> listaTipoContrato = new List<TipoContrato>()
            {
                tipoContratoPlazoFijo, tipoContratoPrueba
            };
            #endregion
            /*=======================================
            *       Lista de Contratos
            *======================================= */
            #region
            //======== Contratos Analista ========
            #region
            Contrato contratoPlazoFijoAnalista = new Contrato()
            {
                Tipos_Contratos = tipoContratoPlazoFijo,
                Cargos = analista,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1700.00,
                Empleados = new List<Empleado>()
                {
                    TamaraBravo, AnaBravo, IsabellaOlmedo
                }
            };

            Contrato contratoPruebaAnalista = new Contrato()
            {
                Tipos_Contratos = tipoContratoPrueba,
                Cargos = analista,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)850.00,
                Empleados = new List<Empleado>()
                {
                    CarlosBravo,
                    PedroGomez, KarlaNajarez, FernandoBrayanes
                }
            };
            #endregion

            //======== Contratos Formacion ========
            #region
            Contrato contratoPlazoFijoFormacion = new Contrato()
            {
                Tipos_Contratos = tipoContratoPlazoFijo,
                Cargos = formacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1400.00,
                Empleados = new List<Empleado>()
                {
                    RichardBuenano, MyrianBunay, RothmanCaceres,
                }
            };

            Contrato contratoPruebaFormacion = new Contrato()
            {
                Tipos_Contratos = tipoContratoPrueba,
                Cargos = formacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)850.00,
                Empleados = new List<Empleado>()
                {
                    CarmenCadena, MercedesCaicedo, LuciaCajamarca
                }
            };


            #endregion
            //======== Contratos Contabilidad ========
            #region
            Contrato contratoPlazoFijoContabilidad = new Contrato()
            {
                Tipos_Contratos = tipoContratoPlazoFijo,
                Cargos = contabilidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1120.00,
                Empleados = new List<Empleado>()
                {
                    FlavioBravo, MaxBrito, GuillermoBucheli, AnacelinaBurbano,
                    EnriqueBriones, EdmundoBriones, JohanBriones, ArturoBrito
                }
            };

            Contrato contratoPruebaContabilidad = new Contrato()
            {
                Tipos_Contratos = tipoContratoPrueba,
                Cargos = contabilidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)550.00,
                Empleados = new List<Empleado>()
                {
                    HectorBurneo, FrankCaamano, AndreaCabrera
                }
            };

            #endregion

            #endregion
            List<Contrato> listaContratos = new List<Contrato>()
            {
                //Contrato plazo Fijo
                contratoPlazoFijoAnalista,

                
                //Contrato de Prueba
                contratoPruebaAnalista, contratoPruebaContabilidad,
                contratoPruebaFormacion, contratoPlazoFijoFormacion, contratoPlazoFijoContabilidad
            };
            #endregion

            /*=======================================
            *           Lista de Rubros
            *======================================= */
            #region
            Rubro ingenieriaSistemas = new Rubro()
            {
                Nombre_Rubro = "Ingeniería en Sistemas",
                Tipo_Rubro = "Ingeniegía",
                Mes_Pago_Rubro = 1,
                Dias_Gracia_Rubro = 5,
                Empleados = new List<Empleado>()
                {
                    TamaraBravo, AnaBravo, IsabellaOlmedo, CarlosBravo,
                    PedroGomez, KarlaNajarez, FernandoBrayanes
                }
            };
            Rubro ingenieriaFinanzas = new Rubro()
            {
                Nombre_Rubro = "Ingeniería en Finanzas",
                Tipo_Rubro = "Ingeniegía",
                Mes_Pago_Rubro = 3,
                Dias_Gracia_Rubro = 5,
                Empleados = new List<Empleado>()
                {
                    RichardBuenano, MyrianBunay, RothmanCaceres,
                    CarmenCadena, MercedesCaicedo, LuciaCajamarca
                }
            };
            Rubro ingenieriaContabilidad = new Rubro()
            {
                Nombre_Rubro = "Ingeniería en Contabilidad",
                Tipo_Rubro = "Ingeniegía",
                Mes_Pago_Rubro = 2,
                Dias_Gracia_Rubro = 5,
                Empleados = new List<Empleado>()
                {
                    FlavioBravo, MaxBrito, GuillermoBucheli, AnacelinaBurbano,
                    HectorBurneo, FrankCaamano, AndreaCabrera
                }
            };
            Rubro ingenieriaMarketing = new Rubro()
            {
                Nombre_Rubro = "Ingeniería en Marketing",
                Tipo_Rubro = "Ingeniegía",
                Mes_Pago_Rubro = 3,
                Dias_Gracia_Rubro = 5,
                Empleados = new List<Empleado>()
                {
                    EnriqueBriones, EdmundoBriones, JohanBriones, ArturoBrito
                }
            };
            List<Rubro> listaRubros = new List<Rubro>()
            {
                ingenieriaContabilidad, ingenieriaMarketing,
                ingenieriaFinanzas, ingenieriaSistemas
            };
            #endregion
            /*=======================================
            *           Rol de Pagos
            *======================================= */
            #region
            RolPago rolRubroIngenieriaSistemas = new RolPago()
            {
                Nombre_Empresa = "Sonda Ecuador",
                RUC_Empresa = "1782963542001",
                Representante_Empresa = "María Puican",
                Descripcion_RolPagos = "Pago del mes Enero",
                Fecha_Inicio = new DateTime(2021, 1, 1),
                Fecha_Fin = new DateTime(2021, 1, 5),
                Estado_Rol = "Pagado",
                Rubros = ingenieriaSistemas
            };
            OperacionesRolPagos rolPagoTamaraBravo = new OperacionesRolPagos(TamaraBravo);
            //OperacionesRolPagos contratoTamaraBravo = new OperacionesRolPagos(contratoPlazoFijoAnalista);
            rolRubroIngenieriaSistemas.salarioEmpleado = rolPagoTamaraBravo.salarioMensual();
            rolRubroIngenieriaSistemas.decimoCuartoSueldo = rolPagoTamaraBravo.calcularDecimoCuarto();
            rolRubroIngenieriaSistemas.decimoTercerSueldo = rolPagoTamaraBravo.calcularDecimoTercer();
            rolRubroIngenieriaSistemas.asistenciaEmpleado = rolPagoTamaraBravo.calcularAsistencia();
            rolRubroIngenieriaSistemas.numeroHorasTrabajas = rolPagoTamaraBravo.calcularNumeroHoras();
            rolRubroIngenieriaSistemas.quincenaEmpleado = rolPagoTamaraBravo.calcularQuincena();
            rolRubroIngenieriaSistemas.horasExtras = rolPagoTamaraBravo.calcularHorasExtras();
            rolRubroIngenieriaSistemas.valorHora = rolPagoTamaraBravo.valorHora();
            rolRubroIngenieriaSistemas.aportacionIESS = rolPagoTamaraBravo.calcularAportacionIESS();

            OperacionesRolPagos rolPagoAnaBravo = new OperacionesRolPagos(AnaBravo);
            rolRubroIngenieriaSistemas.salarioEmpleado = rolPagoAnaBravo.salarioMensual();
            rolRubroIngenieriaSistemas.decimoCuartoSueldo = rolPagoAnaBravo.calcularDecimoCuarto();
            rolRubroIngenieriaSistemas.decimoTercerSueldo = rolPagoAnaBravo.calcularDecimoTercer();
            rolRubroIngenieriaSistemas.asistenciaEmpleado = rolPagoAnaBravo.calcularAsistencia();
            rolRubroIngenieriaSistemas.numeroHorasTrabajas = rolPagoAnaBravo.calcularNumeroHoras();
            rolRubroIngenieriaSistemas.quincenaEmpleado = rolPagoAnaBravo.calcularQuincena();
            rolRubroIngenieriaSistemas.horasExtras = rolPagoAnaBravo.calcularHorasExtras();
            rolRubroIngenieriaSistemas.valorHora = rolPagoAnaBravo.valorHora();
            rolRubroIngenieriaSistemas.aportacionIESS = rolPagoAnaBravo.calcularAportacionIESS();

            OperacionesRolPagos rolPagoIsabellaOlmedo = new OperacionesRolPagos(IsabellaOlmedo);
            rolRubroIngenieriaSistemas.salarioEmpleado = rolPagoIsabellaOlmedo.salarioMensual();
            rolRubroIngenieriaSistemas.decimoCuartoSueldo = rolPagoIsabellaOlmedo.calcularDecimoCuarto();
            rolRubroIngenieriaSistemas.decimoTercerSueldo = rolPagoIsabellaOlmedo.calcularDecimoTercer();
            rolRubroIngenieriaSistemas.asistenciaEmpleado = rolPagoIsabellaOlmedo.calcularAsistencia();
            rolRubroIngenieriaSistemas.numeroHorasTrabajas = rolPagoIsabellaOlmedo.calcularNumeroHoras();
            rolRubroIngenieriaSistemas.quincenaEmpleado = rolPagoIsabellaOlmedo.calcularQuincena();
            rolRubroIngenieriaSistemas.horasExtras = rolPagoIsabellaOlmedo.calcularHorasExtras();
            rolRubroIngenieriaSistemas.valorHora = rolPagoIsabellaOlmedo.valorHora();
            rolRubroIngenieriaSistemas.aportacionIESS = rolPagoIsabellaOlmedo.calcularAportacionIESS();

            OperacionesRolPagos rolPagoCarlosBravo = new OperacionesRolPagos(CarlosBravo);
            rolRubroIngenieriaSistemas.salarioEmpleado = rolPagoCarlosBravo.salarioMensual();
            rolRubroIngenieriaSistemas.decimoCuartoSueldo = rolPagoCarlosBravo.calcularDecimoCuarto();
            rolRubroIngenieriaSistemas.decimoTercerSueldo = rolPagoCarlosBravo.calcularDecimoTercer();
            rolRubroIngenieriaSistemas.asistenciaEmpleado = rolPagoCarlosBravo.calcularAsistencia();
            rolRubroIngenieriaSistemas.numeroHorasTrabajas = rolPagoCarlosBravo.calcularNumeroHoras();
            rolRubroIngenieriaSistemas.quincenaEmpleado = rolPagoCarlosBravo.calcularQuincena();
            rolRubroIngenieriaSistemas.horasExtras = rolPagoCarlosBravo.calcularHorasExtras();
            rolRubroIngenieriaSistemas.valorHora = rolPagoCarlosBravo.valorHora();
            rolRubroIngenieriaSistemas.aportacionIESS = rolPagoCarlosBravo.calcularAportacionIESS();

            OperacionesRolPagos rolPagoPedroGomez = new OperacionesRolPagos(PedroGomez);
            rolRubroIngenieriaSistemas.salarioEmpleado = rolPagoPedroGomez.salarioMensual();
            rolRubroIngenieriaSistemas.decimoCuartoSueldo = rolPagoPedroGomez.calcularDecimoCuarto();
            rolRubroIngenieriaSistemas.decimoTercerSueldo = rolPagoPedroGomez.calcularDecimoTercer();
            rolRubroIngenieriaSistemas.asistenciaEmpleado = rolPagoPedroGomez.calcularAsistencia();
            rolRubroIngenieriaSistemas.numeroHorasTrabajas = rolPagoPedroGomez.calcularNumeroHoras();
            rolRubroIngenieriaSistemas.quincenaEmpleado = rolPagoPedroGomez.calcularQuincena();
            rolRubroIngenieriaSistemas.horasExtras = rolPagoPedroGomez.calcularHorasExtras();
            rolRubroIngenieriaSistemas.valorHora = rolPagoPedroGomez.valorHora();
            rolRubroIngenieriaSistemas.aportacionIESS = rolPagoPedroGomez.calcularAportacionIESS();

            OperacionesRolPagos rolPagoKarlaNajarez = new OperacionesRolPagos(KarlaNajarez);
            rolRubroIngenieriaSistemas.salarioEmpleado = rolPagoKarlaNajarez.salarioMensual();
            rolRubroIngenieriaSistemas.decimoCuartoSueldo = rolPagoKarlaNajarez.calcularDecimoCuarto();
            rolRubroIngenieriaSistemas.decimoTercerSueldo = rolPagoKarlaNajarez.calcularDecimoTercer();
            rolRubroIngenieriaSistemas.asistenciaEmpleado = rolPagoKarlaNajarez.calcularAsistencia();
            rolRubroIngenieriaSistemas.numeroHorasTrabajas = rolPagoKarlaNajarez.calcularNumeroHoras();
            rolRubroIngenieriaSistemas.quincenaEmpleado = rolPagoKarlaNajarez.calcularQuincena();
            rolRubroIngenieriaSistemas.horasExtras = rolPagoKarlaNajarez.calcularHorasExtras();
            rolRubroIngenieriaSistemas.valorHora = rolPagoKarlaNajarez.valorHora();
            rolRubroIngenieriaSistemas.aportacionIESS = rolPagoKarlaNajarez.calcularAportacionIESS();

            OperacionesRolPagos rolPagoFernandoBrayanes = new OperacionesRolPagos(FernandoBrayanes);
            rolRubroIngenieriaSistemas.salarioEmpleado = rolPagoFernandoBrayanes.salarioMensual();
            rolRubroIngenieriaSistemas.decimoCuartoSueldo = rolPagoFernandoBrayanes.calcularDecimoCuarto();
            rolRubroIngenieriaSistemas.decimoTercerSueldo = rolPagoFernandoBrayanes.calcularDecimoTercer();
            rolRubroIngenieriaSistemas.asistenciaEmpleado = rolPagoFernandoBrayanes.calcularAsistencia();
            rolRubroIngenieriaSistemas.numeroHorasTrabajas = rolPagoFernandoBrayanes.calcularNumeroHoras();
            rolRubroIngenieriaSistemas.quincenaEmpleado = rolPagoFernandoBrayanes.calcularQuincena();
            rolRubroIngenieriaSistemas.horasExtras = rolPagoFernandoBrayanes.calcularHorasExtras();
            rolRubroIngenieriaSistemas.valorHora = rolPagoFernandoBrayanes.valorHora();
            rolRubroIngenieriaSistemas.aportacionIESS = rolPagoFernandoBrayanes.calcularAportacionIESS();

            RolPago rolRubroIngenieriaContabilidad = new RolPago()
            {
                Nombre_Empresa = "Sonda Ecuador",
                RUC_Empresa = "1782963542001",
                Representante_Empresa = "María Puican",
                Descripcion_RolPagos = "Pago del mes Enero",
                Fecha_Inicio = new DateTime(2021, 1, 1),
                Fecha_Fin = new DateTime(2021, 1, 5),
                Estado_Rol = "Pagado",
                Rubros = ingenieriaContabilidad
            };
            OperacionesRolPagos rolPagoFlavioBravo = new OperacionesRolPagos(FlavioBravo);
            rolRubroIngenieriaContabilidad.salarioEmpleado = rolPagoFlavioBravo.salarioMensual();
            rolRubroIngenieriaContabilidad.decimoCuartoSueldo = rolPagoFlavioBravo.calcularDecimoCuarto();
            rolRubroIngenieriaContabilidad.decimoTercerSueldo = rolPagoFlavioBravo.calcularDecimoTercer();
            rolRubroIngenieriaContabilidad.asistenciaEmpleado = rolPagoFlavioBravo.calcularAsistencia();
            rolRubroIngenieriaContabilidad.numeroHorasTrabajas = rolPagoFlavioBravo.calcularNumeroHoras();
            rolRubroIngenieriaContabilidad.quincenaEmpleado = rolPagoFlavioBravo.calcularQuincena();
            rolRubroIngenieriaContabilidad.horasExtras = rolPagoFlavioBravo.calcularHorasExtras();
            rolRubroIngenieriaContabilidad.valorHora = rolPagoFlavioBravo.valorHora();
            rolRubroIngenieriaContabilidad.aportacionIESS = rolPagoFlavioBravo.calcularAportacionIESS();

            OperacionesRolPagos rolPagoMaxBrito = new OperacionesRolPagos(MaxBrito);
            rolRubroIngenieriaContabilidad.salarioEmpleado = rolPagoMaxBrito.salarioMensual();
            rolRubroIngenieriaContabilidad.decimoCuartoSueldo = rolPagoMaxBrito.calcularDecimoCuarto();
            rolRubroIngenieriaContabilidad.decimoTercerSueldo = rolPagoMaxBrito.calcularDecimoTercer();
            rolRubroIngenieriaContabilidad.asistenciaEmpleado = rolPagoMaxBrito.calcularAsistencia();
            rolRubroIngenieriaContabilidad.numeroHorasTrabajas = rolPagoMaxBrito.calcularNumeroHoras();
            rolRubroIngenieriaContabilidad.quincenaEmpleado = rolPagoMaxBrito.calcularQuincena();
            rolRubroIngenieriaContabilidad.horasExtras = rolPagoMaxBrito.calcularHorasExtras();
            rolRubroIngenieriaContabilidad.valorHora = rolPagoMaxBrito.valorHora();
            rolRubroIngenieriaContabilidad.aportacionIESS = rolPagoMaxBrito.calcularAportacionIESS();

            OperacionesRolPagos rolPagoGuillermoBucheli = new OperacionesRolPagos(GuillermoBucheli);
            rolRubroIngenieriaContabilidad.salarioEmpleado = rolPagoGuillermoBucheli.salarioMensual();
            rolRubroIngenieriaContabilidad.decimoCuartoSueldo = rolPagoGuillermoBucheli.calcularDecimoCuarto();
            rolRubroIngenieriaContabilidad.decimoTercerSueldo = rolPagoGuillermoBucheli.calcularDecimoTercer();
            rolRubroIngenieriaContabilidad.asistenciaEmpleado = rolPagoGuillermoBucheli.calcularAsistencia();
            rolRubroIngenieriaContabilidad.numeroHorasTrabajas = rolPagoGuillermoBucheli.calcularNumeroHoras();
            rolRubroIngenieriaContabilidad.quincenaEmpleado = rolPagoGuillermoBucheli.calcularQuincena();
            rolRubroIngenieriaContabilidad.horasExtras = rolPagoGuillermoBucheli.calcularHorasExtras();
            rolRubroIngenieriaContabilidad.valorHora = rolPagoGuillermoBucheli.valorHora();
            rolRubroIngenieriaContabilidad.aportacionIESS = rolPagoGuillermoBucheli.calcularAportacionIESS();

            OperacionesRolPagos rolPagoRichardBuenano = new OperacionesRolPagos(RichardBuenano);
            rolRubroIngenieriaContabilidad.salarioEmpleado = rolPagoRichardBuenano.salarioMensual();
            rolRubroIngenieriaContabilidad.decimoCuartoSueldo = rolPagoRichardBuenano.calcularDecimoCuarto();
            rolRubroIngenieriaContabilidad.decimoTercerSueldo = rolPagoRichardBuenano.calcularDecimoTercer();
            rolRubroIngenieriaContabilidad.asistenciaEmpleado = rolPagoRichardBuenano.calcularAsistencia();
            rolRubroIngenieriaContabilidad.numeroHorasTrabajas = rolPagoRichardBuenano.calcularNumeroHoras();
            rolRubroIngenieriaContabilidad.quincenaEmpleado = rolPagoRichardBuenano.calcularQuincena();
            rolRubroIngenieriaContabilidad.horasExtras = rolPagoRichardBuenano.calcularHorasExtras();
            rolRubroIngenieriaContabilidad.valorHora = rolPagoRichardBuenano.valorHora();
            rolRubroIngenieriaContabilidad.aportacionIESS = rolPagoRichardBuenano.calcularAportacionIESS();

            OperacionesRolPagos rolPagoMyrianBunay = new OperacionesRolPagos(MyrianBunay);
            rolRubroIngenieriaContabilidad.salarioEmpleado = rolPagoMyrianBunay.salarioMensual();
            rolRubroIngenieriaContabilidad.decimoCuartoSueldo = rolPagoMyrianBunay.calcularDecimoCuarto();
            rolRubroIngenieriaContabilidad.decimoTercerSueldo = rolPagoMyrianBunay.calcularDecimoTercer();
            rolRubroIngenieriaContabilidad.asistenciaEmpleado = rolPagoMyrianBunay.calcularAsistencia();
            rolRubroIngenieriaContabilidad.numeroHorasTrabajas = rolPagoMyrianBunay.calcularNumeroHoras();
            rolRubroIngenieriaContabilidad.quincenaEmpleado = rolPagoMyrianBunay.calcularQuincena();
            rolRubroIngenieriaContabilidad.horasExtras = rolPagoMyrianBunay.calcularHorasExtras();
            rolRubroIngenieriaContabilidad.valorHora = rolPagoMyrianBunay.valorHora();
            rolRubroIngenieriaContabilidad.aportacionIESS = rolPagoMyrianBunay.calcularAportacionIESS();

            OperacionesRolPagos rolPagoAnacelinaBurbano = new OperacionesRolPagos(AnacelinaBurbano);
            rolRubroIngenieriaContabilidad.salarioEmpleado = rolPagoAnacelinaBurbano.salarioMensual();
            rolRubroIngenieriaContabilidad.decimoCuartoSueldo = rolPagoAnacelinaBurbano.calcularDecimoCuarto();
            rolRubroIngenieriaContabilidad.decimoTercerSueldo = rolPagoAnacelinaBurbano.calcularDecimoTercer();
            rolRubroIngenieriaContabilidad.asistenciaEmpleado = rolPagoAnacelinaBurbano.calcularAsistencia();
            rolRubroIngenieriaContabilidad.numeroHorasTrabajas = rolPagoAnacelinaBurbano.calcularNumeroHoras();
            rolRubroIngenieriaContabilidad.quincenaEmpleado = rolPagoAnacelinaBurbano.calcularQuincena();
            rolRubroIngenieriaContabilidad.horasExtras = rolPagoAnacelinaBurbano.calcularHorasExtras();
            rolRubroIngenieriaContabilidad.valorHora = rolPagoAnacelinaBurbano.valorHora();
            rolRubroIngenieriaContabilidad.aportacionIESS = rolPagoAnacelinaBurbano.calcularAportacionIESS();

            OperacionesRolPagos rolPagoHectorBurneo = new OperacionesRolPagos(HectorBurneo);
            rolRubroIngenieriaContabilidad.salarioEmpleado = rolPagoHectorBurneo.salarioMensual();
            rolRubroIngenieriaContabilidad.decimoCuartoSueldo = rolPagoHectorBurneo.calcularDecimoCuarto();
            rolRubroIngenieriaContabilidad.decimoTercerSueldo = rolPagoHectorBurneo.calcularDecimoTercer();
            rolRubroIngenieriaContabilidad.asistenciaEmpleado = rolPagoHectorBurneo.calcularAsistencia();
            rolRubroIngenieriaContabilidad.numeroHorasTrabajas = rolPagoHectorBurneo.calcularNumeroHoras();
            rolRubroIngenieriaContabilidad.quincenaEmpleado = rolPagoHectorBurneo.calcularQuincena();
            rolRubroIngenieriaContabilidad.horasExtras = rolPagoHectorBurneo.calcularHorasExtras();
            rolRubroIngenieriaContabilidad.valorHora = rolPagoHectorBurneo.valorHora();
            rolRubroIngenieriaContabilidad.aportacionIESS = rolPagoHectorBurneo.calcularAportacionIESS();

            OperacionesRolPagos rolPagoFrankCaamano = new OperacionesRolPagos(FrankCaamano);
            rolRubroIngenieriaContabilidad.salarioEmpleado = rolPagoFrankCaamano.salarioMensual();
            rolRubroIngenieriaContabilidad.decimoCuartoSueldo = rolPagoFrankCaamano.calcularDecimoCuarto();
            rolRubroIngenieriaContabilidad.decimoTercerSueldo = rolPagoFrankCaamano.calcularDecimoTercer();
            rolRubroIngenieriaContabilidad.asistenciaEmpleado = rolPagoFrankCaamano.calcularAsistencia();
            rolRubroIngenieriaContabilidad.numeroHorasTrabajas = rolPagoFrankCaamano.calcularNumeroHoras();
            rolRubroIngenieriaContabilidad.quincenaEmpleado = rolPagoFrankCaamano.calcularQuincena();
            rolRubroIngenieriaContabilidad.horasExtras = rolPagoFrankCaamano.calcularHorasExtras();
            rolRubroIngenieriaContabilidad.valorHora = rolPagoFrankCaamano.valorHora();
            rolRubroIngenieriaContabilidad.aportacionIESS = rolPagoFrankCaamano.calcularAportacionIESS();

            OperacionesRolPagos rolPagoAndreaCabrera = new OperacionesRolPagos(AndreaCabrera);
            rolRubroIngenieriaContabilidad.salarioEmpleado = rolPagoAndreaCabrera.salarioMensual();
            rolRubroIngenieriaContabilidad.decimoCuartoSueldo = rolPagoAndreaCabrera.calcularDecimoCuarto();
            rolRubroIngenieriaContabilidad.decimoTercerSueldo = rolPagoAndreaCabrera.calcularDecimoTercer();
            rolRubroIngenieriaContabilidad.asistenciaEmpleado = rolPagoAndreaCabrera.calcularAsistencia();
            rolRubroIngenieriaContabilidad.numeroHorasTrabajas = rolPagoAndreaCabrera.calcularNumeroHoras();
            rolRubroIngenieriaContabilidad.quincenaEmpleado = rolPagoAndreaCabrera.calcularQuincena();
            rolRubroIngenieriaContabilidad.horasExtras = rolPagoAndreaCabrera.calcularHorasExtras();
            rolRubroIngenieriaContabilidad.valorHora = rolPagoAndreaCabrera.valorHora();
            rolRubroIngenieriaContabilidad.aportacionIESS = rolPagoAndreaCabrera.calcularAportacionIESS();

            RolPago rolRubroIngenieriaFinanzas = new RolPago()
            {
                Nombre_Empresa = "Sonda Ecuador",
                RUC_Empresa = "1782963542001",
                Representante_Empresa = "María Puican",
                Descripcion_RolPagos = "Pago del mes Enero",
                Fecha_Inicio = new DateTime(2021, 1, 1),
                Fecha_Fin = new DateTime(2021, 1, 5),
                Estado_Rol = "Pagado",
                Rubros = ingenieriaFinanzas
            };
            OperacionesRolPagos rolPagoEnriqueBriones = new OperacionesRolPagos(EnriqueBriones);
            rolRubroIngenieriaFinanzas.salarioEmpleado = rolPagoEnriqueBriones.salarioMensual();
            rolRubroIngenieriaFinanzas.decimoCuartoSueldo = rolPagoEnriqueBriones.calcularDecimoCuarto();
            rolRubroIngenieriaFinanzas.decimoTercerSueldo = rolPagoEnriqueBriones.calcularDecimoTercer();
            rolRubroIngenieriaFinanzas.asistenciaEmpleado = rolPagoEnriqueBriones.calcularAsistencia();
            rolRubroIngenieriaFinanzas.numeroHorasTrabajas = rolPagoEnriqueBriones.calcularNumeroHoras();
            rolRubroIngenieriaFinanzas.quincenaEmpleado = rolPagoEnriqueBriones.calcularQuincena();
            rolRubroIngenieriaFinanzas.horasExtras = rolPagoEnriqueBriones.calcularHorasExtras();
            rolRubroIngenieriaFinanzas.valorHora = rolPagoEnriqueBriones.valorHora();
            rolRubroIngenieriaFinanzas.aportacionIESS = rolPagoEnriqueBriones.calcularAportacionIESS();

            OperacionesRolPagos rolPagoEdmundoBriones = new OperacionesRolPagos(EdmundoBriones);
            rolRubroIngenieriaFinanzas.salarioEmpleado = rolPagoEdmundoBriones.salarioMensual();
            rolRubroIngenieriaFinanzas.decimoCuartoSueldo = rolPagoEdmundoBriones.calcularDecimoCuarto();
            rolRubroIngenieriaFinanzas.decimoTercerSueldo = rolPagoEdmundoBriones.calcularDecimoTercer();
            rolRubroIngenieriaFinanzas.asistenciaEmpleado = rolPagoEdmundoBriones.calcularAsistencia();
            rolRubroIngenieriaFinanzas.numeroHorasTrabajas = rolPagoEdmundoBriones.calcularNumeroHoras();
            rolRubroIngenieriaFinanzas.quincenaEmpleado = rolPagoEdmundoBriones.calcularQuincena();
            rolRubroIngenieriaFinanzas.horasExtras = rolPagoEdmundoBriones.calcularHorasExtras();
            rolRubroIngenieriaFinanzas.valorHora = rolPagoEdmundoBriones.valorHora();
            rolRubroIngenieriaFinanzas.aportacionIESS = rolPagoEdmundoBriones.calcularAportacionIESS();

            OperacionesRolPagos rolPagoJohanBriones = new OperacionesRolPagos(JohanBriones);
            rolRubroIngenieriaFinanzas.salarioEmpleado = rolPagoJohanBriones.salarioMensual();
            rolRubroIngenieriaFinanzas.decimoCuartoSueldo = rolPagoJohanBriones.calcularDecimoCuarto();
            rolRubroIngenieriaFinanzas.decimoTercerSueldo = rolPagoJohanBriones.calcularDecimoTercer();
            rolRubroIngenieriaFinanzas.asistenciaEmpleado = rolPagoJohanBriones.calcularAsistencia();
            rolRubroIngenieriaFinanzas.numeroHorasTrabajas = rolPagoJohanBriones.calcularNumeroHoras();
            rolRubroIngenieriaFinanzas.quincenaEmpleado = rolPagoJohanBriones.calcularQuincena();
            rolRubroIngenieriaFinanzas.horasExtras = rolPagoJohanBriones.calcularHorasExtras();
            rolRubroIngenieriaFinanzas.valorHora = rolPagoJohanBriones.valorHora();
            rolRubroIngenieriaFinanzas.aportacionIESS = rolPagoJohanBriones.calcularAportacionIESS();

            OperacionesRolPagos rolPagoArturoBrito = new OperacionesRolPagos(ArturoBrito);
            rolRubroIngenieriaFinanzas.salarioEmpleado = rolPagoArturoBrito.salarioMensual();
            rolRubroIngenieriaFinanzas.decimoCuartoSueldo = rolPagoArturoBrito.calcularDecimoCuarto();
            rolRubroIngenieriaFinanzas.decimoTercerSueldo = rolPagoArturoBrito.calcularDecimoTercer();
            rolRubroIngenieriaFinanzas.asistenciaEmpleado = rolPagoArturoBrito.calcularAsistencia();
            rolRubroIngenieriaFinanzas.numeroHorasTrabajas = rolPagoArturoBrito.calcularNumeroHoras();
            rolRubroIngenieriaFinanzas.quincenaEmpleado = rolPagoArturoBrito.calcularQuincena();
            rolRubroIngenieriaFinanzas.horasExtras = rolPagoArturoBrito.calcularHorasExtras();
            rolRubroIngenieriaFinanzas.valorHora = rolPagoArturoBrito.valorHora();
            rolRubroIngenieriaFinanzas.aportacionIESS = rolPagoArturoBrito.calcularAportacionIESS();
            
            RolPago rolRubroIngenieriaMarketing = new RolPago()
            {
                Nombre_Empresa = "Sonda Ecuador",
                RUC_Empresa = "1782963542001",
                Representante_Empresa = "María Puican",
                Descripcion_RolPagos = "Pago del mes Enero",
                Fecha_Inicio = new DateTime(2021, 1, 1),
                Fecha_Fin = new DateTime(2021, 1, 5),
                Estado_Rol = "Pagado",
                Rubros = ingenieriaMarketing
            };
            OperacionesRolPagos rolPagoRothmanCaceres = new OperacionesRolPagos(RothmanCaceres);
            rolRubroIngenieriaMarketing.salarioEmpleado = rolPagoRothmanCaceres.salarioMensual();
            rolRubroIngenieriaMarketing.decimoCuartoSueldo = rolPagoRothmanCaceres.calcularDecimoCuarto();
            rolRubroIngenieriaMarketing.decimoTercerSueldo = rolPagoRothmanCaceres.calcularDecimoTercer();
            rolRubroIngenieriaMarketing.asistenciaEmpleado = rolPagoRothmanCaceres.calcularAsistencia();
            rolRubroIngenieriaMarketing.numeroHorasTrabajas = rolPagoRothmanCaceres.calcularNumeroHoras();
            rolRubroIngenieriaMarketing.quincenaEmpleado = rolPagoRothmanCaceres.calcularQuincena();
            rolRubroIngenieriaMarketing.horasExtras = rolPagoRothmanCaceres.calcularHorasExtras();
            rolRubroIngenieriaMarketing.valorHora = rolPagoRothmanCaceres.valorHora();
            rolRubroIngenieriaMarketing.aportacionIESS = rolPagoRothmanCaceres.calcularAportacionIESS();

            OperacionesRolPagos rolPagoCarmenCadena = new OperacionesRolPagos(CarmenCadena);
            rolRubroIngenieriaMarketing.salarioEmpleado = rolPagoCarmenCadena.salarioMensual();
            rolRubroIngenieriaMarketing.decimoCuartoSueldo = rolPagoCarmenCadena.calcularDecimoCuarto();
            rolRubroIngenieriaMarketing.decimoTercerSueldo = rolPagoCarmenCadena.calcularDecimoTercer();
            rolRubroIngenieriaMarketing.asistenciaEmpleado = rolPagoCarmenCadena.calcularAsistencia();
            rolRubroIngenieriaMarketing.numeroHorasTrabajas = rolPagoCarmenCadena.calcularNumeroHoras();
            rolRubroIngenieriaMarketing.quincenaEmpleado = rolPagoCarmenCadena.calcularQuincena();
            rolRubroIngenieriaMarketing.horasExtras = rolPagoCarmenCadena.calcularHorasExtras();
            rolRubroIngenieriaMarketing.valorHora = rolPagoCarmenCadena.valorHora();
            rolRubroIngenieriaMarketing.aportacionIESS = rolPagoCarmenCadena.calcularAportacionIESS();

            OperacionesRolPagos rolPagoMercedesCaicedo = new OperacionesRolPagos(MercedesCaicedo);
            rolRubroIngenieriaMarketing.salarioEmpleado = rolPagoMercedesCaicedo.salarioMensual();
            rolRubroIngenieriaMarketing.decimoCuartoSueldo = rolPagoMercedesCaicedo.calcularDecimoCuarto();
            rolRubroIngenieriaMarketing.decimoTercerSueldo = rolPagoMercedesCaicedo.calcularDecimoTercer();
            rolRubroIngenieriaMarketing.asistenciaEmpleado = rolPagoMercedesCaicedo.calcularAsistencia();
            rolRubroIngenieriaMarketing.numeroHorasTrabajas = rolPagoMercedesCaicedo.calcularNumeroHoras();
            rolRubroIngenieriaMarketing.quincenaEmpleado = rolPagoMercedesCaicedo.calcularQuincena();
            rolRubroIngenieriaMarketing.horasExtras = rolPagoMercedesCaicedo.calcularHorasExtras();
            rolRubroIngenieriaMarketing.valorHora = rolPagoMercedesCaicedo.valorHora();
            rolRubroIngenieriaMarketing.aportacionIESS = rolPagoMercedesCaicedo.calcularAportacionIESS();

            OperacionesRolPagos rolPagoLuciaCajamarca = new OperacionesRolPagos(LuciaCajamarca);
            rolRubroIngenieriaMarketing.salarioEmpleado = rolPagoLuciaCajamarca.salarioMensual();
            rolRubroIngenieriaMarketing.decimoCuartoSueldo = rolPagoLuciaCajamarca.calcularDecimoCuarto();
            rolRubroIngenieriaMarketing.decimoTercerSueldo = rolPagoLuciaCajamarca.calcularDecimoTercer();
            rolRubroIngenieriaMarketing.asistenciaEmpleado = rolPagoLuciaCajamarca.calcularAsistencia();
            rolRubroIngenieriaMarketing.numeroHorasTrabajas = rolPagoLuciaCajamarca.calcularNumeroHoras();
            rolRubroIngenieriaMarketing.quincenaEmpleado = rolPagoLuciaCajamarca.calcularQuincena();
            rolRubroIngenieriaMarketing.horasExtras = rolPagoLuciaCajamarca.calcularHorasExtras();
            rolRubroIngenieriaMarketing.valorHora = rolPagoLuciaCajamarca.valorHora();
            rolRubroIngenieriaMarketing.aportacionIESS = rolPagoLuciaCajamarca.calcularAportacionIESS();
            

            List<RolPago> listaRolPagos = new List<RolPago>()
            {
                rolRubroIngenieriaContabilidad, rolRubroIngenieriaFinanzas,
                rolRubroIngenieriaMarketing, rolRubroIngenieriaSistemas
            };
            #endregion


            /*=======================================================================================
            *                   Diccionario que contiene todas las listas
            *========================================================================================*/
            Dictionary<ListasTipo, object> dictionaryListData = new Dictionary<ListasTipo, object>()
            {
                { ListasTipo.Regiones, listaRegion },
                { ListasTipo.Ciudades, listaCiudades },
                { ListasTipo.Departamentos, listaDepartamentos },
                { ListasTipo.Cargos, listaCargos },
                { ListasTipo.TipoContratos, listaTipoContrato },
                { ListasTipo.Contratos, listaContratos },
                { ListasTipo.TipoPermisos, listaTipoPermisos },
                { ListasTipo.Permisos, listaPermisos },
                { ListasTipo.JornadaTrabajos, listaJornadoTrabajos },
                { ListasTipo.Rubros, listaRubros },
                { ListasTipo.RolPagos, listaRolPagos },
                { ListasTipo.Asistencias, listaAsistencia },
                { ListasTipo.Empleados, listaEmpleados1 }
            };

            return dictionaryListData;
        }
    }
}
