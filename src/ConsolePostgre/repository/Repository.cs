﻿using System;
using System.Data;
using ConsolePostgre.domain;
using ConsolePostgre.repository.context;
using Dapper.Contrib.Extensions;
using Npgsql;

namespace ConsolePostgre.repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected IDbConnection Conn => new NpgsqlConnection(Connection.GetConnectionString());
        public T Insert(T obj)
        {
            OpenConn();

            using (var transation = Conn.BeginTransaction())
            {
                try
                {
                    Conn.Insert(obj);
                    transation.Commit();
                }
                catch (Exception)
                {
                    transation.Rollback();
                }
                finally
                {
                    if (Conn.State == ConnectionState.Open)
                    {
                        transation.Dispose();
                        Conn.Close();
                    }
                }
            }

            return obj;
        }

        public T Update(T obj)
        {
            Conn.Open();

            using (var transation = Conn.BeginTransaction())
            {
                try
                {
                    Conn.Update(obj);
                    transation.Commit();
                }
                catch (Exception)
                {
                    transation.Rollback();
                }
                finally
                {
                    if (Conn.State == ConnectionState.Open)
                    {
                        transation.Dispose();
                        Conn.Close();
                    }
                }
            }

            return obj;
        }

        public T Delete(T obj)
        {
            Conn.Open();

            using (var transation = Conn.BeginTransaction())
            {
                try
                {
                    Conn.Delete(obj);
                    transation.Commit();
                }
                catch (Exception)
                {
                    transation.Rollback();
                }
                finally
                {
                    if (Conn.State == ConnectionState.Open)
                    {
                        transation.Dispose();
                        Conn.Close();
                    }
                }
            }

            return obj;
        }

        public T GetById(int id)
        {
            return Conn.Get<T>(id);
        }
    }
}