﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Repository.Memory
{
    public class InMemoryDatabaseObjectContext
    {
        public List<DatabaseCustomer> DatabaseCustomers { get; set; }
        public InMemoryDatabaseObjectContext()
        {
            InitialiseDatabaseCustomers();
        }

        public void AddEntity<T>(T databaseEntity)
        {
            if (databaseEntity is DatabaseCustomer)
            {
                DatabaseCustomer databaseCustomer = databaseEntity as DatabaseCustomer;
                databaseCustomer.Id = DatabaseCustomers.Count + 1;
                DatabaseCustomers.Add(databaseEntity as DatabaseCustomer);
            }
        }

        public void UpdateEntity<T>(T databaseEntity)
        {
            if (databaseEntity is DatabaseCustomer)
            {
                DatabaseCustomer dbCustomer = databaseEntity as DatabaseCustomer;
                var dbCustomerToBeUpdated = DatabaseCustomers.Find(t => t.Id == dbCustomer.Id);
                dbCustomerToBeUpdated.Address = dbCustomer.Address;
                dbCustomerToBeUpdated.City = dbCustomer.City;
                dbCustomerToBeUpdated.Country = dbCustomer.Country;
                dbCustomerToBeUpdated.CustomerName = dbCustomer.CustomerName;
                dbCustomerToBeUpdated.Telephone = dbCustomer.Telephone;
            }
        }

        public void DeleteEntity<T>(T databaseEntity)
        {
            if (databaseEntity is DatabaseCustomer)
            {
                var dbCustomer = databaseEntity as DatabaseCustomer;
                var dbCustomerToBeDeleted =DatabaseCustomers.Find(t => t.Id == dbCustomer.Id);
                if (dbCustomerToBeDeleted !=null)
                {
                    DatabaseCustomers.Remove(dbCustomerToBeDeleted);
                }
            }
        }

        private void InitialiseDatabaseCustomers()
        {
            DatabaseCustomers = new List<DatabaseCustomer>();
            DatabaseCustomers.Add(new DatabaseCustomer() { Address = "Main street", City = "Birmingham", Country = "UK", CustomerName = "GreatCustomer", Id = 1, Telephone = "N/A" });
            DatabaseCustomers.Add(new DatabaseCustomer() { Address = "Strandvägen", City = "Stockholm", Country = "Sweden", CustomerName = "BadCustomer", Id = 2, Telephone = "123345456" });
            DatabaseCustomers.Add(new DatabaseCustomer() { Address = "Kis utca", City = "Budapest", Country = "Hungary", CustomerName = "FavouriteCustomer", Id = 3, Telephone = "987654312" });
        }

        public static InMemoryDatabaseObjectContext Instance
        {
            get { return Nested.instance; }
        }    
    }

    public sealed class Nested
    {
        static Nested()
        {

        }
        internal static readonly InMemoryDatabaseObjectContext instance = new InMemoryDatabaseObjectContext();
    }

}

