using Microsoft.EntityFrameworkCore;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRP
{
    public class SGRPDBBuilder
    {
        const string DB_TIPO = "DBTipo";
        enum DBTypeConnection { SqlServer, Postgres, Memoria};
        static SGRPDB db;

        public static SGRPDB Crear()
        {
            /*===================================================================================
            *   Leer la configuracion acerca de qué base de datos usar del archivo App.config
            *====================================================================================*/
            string dbTipo = ConfigurationManager.AppSettings[DB_TIPO];
            string connection = ConfigurationManager.ConnectionStrings[dbTipo].ConnectionString;

            /*===================================================================================
            *                           Construccion de la conexion
            *====================================================================================*/
            DbContextOptions<SGRPDB> contextOptions;
            switch (dbTipo)
            {
                case nameof(DBTypeConnection.SqlServer):
                    contextOptions = new DbContextOptionsBuilder<SGRPDB>()
                        .UseSqlServer(connection)
                        .Options;
                    break;

                 case nameof(DBTypeConnection.Postgres):
                      contextOptions = new DbContextOptionsBuilder<SGRPDB>()
                        .UseNpgsql(connection)
                        .Options;
                    break;

                 default:
                    contextOptions = new DbContextOptionsBuilder<SGRPDB>()
                        .UseInMemoryDatabase(connection)
                        .Options;
                    break;
            }

            db = new SGRPDB(contextOptions);
            return db;
        }
    }
}
