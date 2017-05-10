﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarkOrm.NET
{
    public static class TarkDataExtensions
    {
        public static IEnumerable<T> GetAll<T>(this IDbConnection connection)
        {
            using (var dataAccess = new TarkDataAccess(connection))
            {
                return dataAccess.GetAll<T>();
            }
        }

        public static TarkDataAccess WithTableHint(this IDbConnection connection, string tableHint)
        {
            var dataAccess = new TarkDataAccess(connection);
            dataAccess.QueryBuilder.TableHint = tableHint;
            return dataAccess;
        }
        //public static IEnumerable<T> GetAll<T>(this IDbConnection connection, string TableHint)
        //{
        //    using (var dataAcess = new TarkDataAccess(connection))
        //    {
        //        dataAcess.QueryBuilder.TableHint = TableHint;
        //        return dataAcess.GetAll<T>();
        //    }
        //}

        //public static T GetById<T>(this IDbConnection connection, string TableHint, params object[] keyValues)
        //{
        //    using (var dataAcess = new TarkDataAccess(connection))
        //    {
        //        dataAcess.QueryBuilder.TableHint = TableHint;
        //        return dataAcess.GetById<T>(keyValues);
        //    }
        //}

        public static T GetById<T>(this IDbConnection connection, params object[] keyValues)
        {
            using (var dataAccess = new TarkDataAccess(connection))
            {
                return dataAccess.GetById<T>(keyValues);
            }
        }

        public static void Add<T>(this IDbConnection connection, T entity)
        {
            using (var dataAccess = new TarkDataAccess(connection))
            {
                dataAccess.Add<T>(entity);
            }
        }

        public static void RemoveById<T>(this IDbConnection connection, params object[] keyValues)
        {
            using (var dataAccess = new TarkDataAccess(connection))
            {
                dataAccess.RemoveById<T>(keyValues);
            }
        }

        public static void Update<T>(this IDbConnection connection, T entity)
        {
            using (var dataAccess = new TarkDataAccess(connection))
            {
                dataAccess.Update<T>(entity);
            }
        }
    }
}