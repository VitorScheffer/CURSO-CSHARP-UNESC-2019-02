using Npgsql;
using Projeto.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Data.Migrations
{
    public class NpgsqlConfiguration : System.Data.Entity.DbConfiguration
    {
        public NpgsqlConfiguration()
        {
            SetProviderServices("Npgsql", Npgsql.NpgsqlServices.Instance);
            SetProviderFactory("Npgsql", Npgsql.NpgsqlFactory.Instance);
            SetDefaultConnectionFactory(new Npgsql.NpgsqlConnectionFactory());

            //            Loaded += (_, a) =>
            //            {
            //                a.AddDependencyResolver(new DbProviderDependencyResolver(), true);
            //            };
            //
            //            SetDefaultConnectionFactory(new NpgsqlConnectionFactory());
            //            SetProviderServices("Npgsql", NpgsqlServices.Instance);
            //            SetHistoryContext("Npgsql", (connection, defaultSchema) => new ErpHistoryContext(connection, defaultSchema));
        }
    }

    public class DbProviderDependencyResolver : System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
    {
        public object GetService(Type type, object key)
        {
            if (type == typeof(System.Data.Common.DbProviderFactory))
            {
                return Npgsql.NpgsqlFactory.Instance;

            }
            else if (type == typeof(System.Data.Entity.Infrastructure.IProviderInvariantName) && key?.ToString() == "Npgsql.NpgsqlFactory")
            {
                return new InvariantName();
            }

            return null;
        }

        public IEnumerable<object> GetServices(Type type, object key)
        {
            return new object[] { GetService(type, key) }.ToList().Where(o => o != null);
        }
        class InvariantName : System.Data.Entity.Infrastructure.IProviderInvariantName
        {
            public string Name { get; } = "Npgsql";
        }
    }
}