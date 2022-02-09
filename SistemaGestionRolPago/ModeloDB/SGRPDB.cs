using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
    public class SGRPDB: DbContext
    {
        public SGRPDB()
        {

        }
        public SGRPDB(DbContextOptions<SGRPDB> options)
            : base(options)
        {

        }

        /*================================================================
         *          Borrado y creacion de la Base de Datos
         *================================================================*/
        public void PeprararDB()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        /*================================================================
         *                  Configuracion de Entidades
         *================================================================*/
        public DbSet<Asistencia> asistencias { get; set; }
        public DbSet<Cargo> cargos { get; set; }
        public DbSet<Contrato> contratos { get; set; }
        public DbSet<Ciudad> ciudades { get; set; }
        public DbSet<Departamento> departamentos { get; set; }
        public DbSet<Empleado> empleados { get; set; }
        public DbSet<JornadaTrabajo> jornadasTrabajos { get; set; }
        public DbSet<Pais> paises { get; set; }
        public DbSet<Permiso> permisos { get; set; }
        public DbSet<Region> regiones { get; set; }
        public DbSet<RolPago> rolPagos { get; set; }
        public DbSet<Rubro> rubros { get; set; }
        public DbSet<TipoContrato> tiposContratos { get; set; }
        public DbSet<TipoPermiso> tiposPermisos { get; set; }
        //public DbSet<RubroEmpleado> rubrosEmpleados { get; set; }

        /*================================================================
         *            Configuracion de la conexion a la BD
         *================================================================*/
        override protected void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            /*-------------------------------------------------------------------
             *  Si no se ha configurado la conexion, se configura con SqlServer
             *-------------------------------------------------------------------*/
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer("SERVER=DESKTOP-JEQTB22; initial catalog = DBSGRP; trusted_connection = true;");
            }
        }
        
        /*================================================================
         *                  Modelado de las Entidades
         *================================================================*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relacion uno a muchos de Region a Pais
            modelBuilder.Entity<Region>()
                .HasOne(region => region.Paises)
                .WithMany(pais => pais.Regiones)
                .HasForeignKey(region => region.PaisId);

            //Relacion uno a muchos de Region a Ciudad
            modelBuilder.Entity<Ciudad>()
                .HasOne(ciudad => ciudad.Regiones)
                .WithMany(region => region.Ciudades)
                .HasForeignKey(ciudad => ciudad.RegionId);

            //Relacion uno a muchos de Empleado a Ciudad
            modelBuilder.Entity<Empleado>()
                .HasOne(empleado => empleado.Nombre_Ciudad)
                .WithMany(ciudad => ciudad.Empleados)
                .HasForeignKey(empleado => empleado.CiudadId);

            //Relaicon uno a muchos de Cargo a Departamento
            modelBuilder.Entity<Cargo>()
                .HasOne(cargo => cargo.Departamentos)
                .WithMany(departamento => departamento.Cargos)
                .HasForeignKey(cargo => cargo.DepartamentoId);

            //Relacion uno a muchos de Tipo de Contrato a Contrato
            modelBuilder.Entity<Contrato>()
                .HasOne(contrato => contrato.Tipos_Contratos)
                .WithMany(tipoContrato => tipoContrato.Contratos)
                .HasForeignKey(contrato => contrato.TipoContratoId);

            //Relacion uno a muchos de TipoPermiso a Permiso
            modelBuilder.Entity<Permiso>()
                .HasOne(permiso => permiso.Tipo_Permisos)
                .WithMany(tipoPermiso => tipoPermiso.permiso)
                .HasForeignKey(permiso => permiso.TipoPermisosId);

            //Relacion uno a muchos de Permiso a Empleado
            modelBuilder.Entity<Empleado>()
                .HasOne(empleado => empleado.Permiso)
                .WithMany(permiso => permiso.Empleados)
                .HasForeignKey(empleado => empleado.PermisoId);

            //Realacion uno a uno de Cargo a Contrato
            modelBuilder.Entity<Contrato>()
                .HasOne(contrato => contrato.Cargos)
                .WithOne(cargo => cargo.Contratos)
                .HasForeignKey<Contrato>(contrato => contrato.CargoId);

            //Relacion uno a muchos de Empleado a Contrato
            modelBuilder.Entity<Empleado>()
                .HasOne(empleado => empleado.Contrato)
                .WithMany(contrato => contrato.Empleados)
                .HasForeignKey(empleado => empleado.ContratoId);

            //Relacion uno a muchos de Empleado a Asistencia
            modelBuilder.Entity<Empleado>()
                .HasOne(empleado => empleado.AsistenciaEmpleados)
                .WithMany(asistencia => asistencia.Lista_Empleados)
                .HasForeignKey(empleado => empleado.AsistenciaId);

            //Relacion uno a muchos de JornadaTrabajo a Empleado
            modelBuilder.Entity<Empleado>()
                .HasOne(empleado => empleado.Jornada_Trabajo)
                .WithMany(jornadaTrabajo => jornadaTrabajo.Empleados)
                .HasForeignKey(empleado => empleado.JornadaTrabajoId);

            //Relacion uno a uno de Rubros a RolPago
            modelBuilder.Entity<RolPago>()
                .HasOne(rol => rol.Rubros)
                .WithOne(rubo => rubo.Rol_Pagos)
                .HasForeignKey<RolPago>(rol => rol.RubroId);

            //Relacion uno a varios de Rubros a Empleado
            modelBuilder.Entity<Empleado>()
                .HasOne(empleado => empleado.Rubros)
                .WithMany(rubro => rubro.Empleados)
                .HasForeignKey(empleado => empleado.RubroId);

            //Relacion Rubros - RubosEmpleados - Empleado}
            /*
            modelBuilder.Entity<RubroEmpleado>()
                .HasKey(rubrosEmpleados => new { rubrosEmpleados.RubrosId, rubrosEmpleados.EmpeladoId });

            modelBuilder.Entity<RubroEmpleado>()
                .HasOne(rubrosEmpleados => rubrosEmpleados.Rubros)
                .WithMany(rubros => rubros.RubroEmpleado)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(rubrosEmpleados => rubrosEmpleados.RubrosId);

            modelBuilder.Entity<RubroEmpleado>()
                .HasOne(rubrosEmpleados => rubrosEmpleados.Empleados)
                .WithMany(empleado => empleado.RubroEmpleado)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(rubrosEmpleados => rubrosEmpleados.EmpeladoId);
            */
        }

    }
}
