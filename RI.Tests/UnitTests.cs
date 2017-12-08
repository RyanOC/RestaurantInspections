using System;
using System.Data.SqlClient;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using RI.Core.Contracts.Inspection;
using RI.Core.Contracts.Restaurant;
using RI.Core.Contracts.Restaurant.Query;
using RI.Core.Contracts.Violation;
using RI.Data.Repository;
using RI.Infrastructure.Queries;
using RI.Infrastructure.Services;

namespace RI.Tests
{
    [TestClass]
    [TestCategory("Unit")]
    public class UnitTests
    {
        private const string _connectionString = @"data source=.\SQLEXPRESS;initial catalog=Testing;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        [TestMethod]
        public void TestDbConnection()
        {
            string sql = null;

            // sql = "Select * from [Testing].[ri].[Restaurant]";

            sql = @"

            select * from ri.Restaurant

            ";

            var cnn = new SqlConnection(_connectionString);

            try
            {
                cnn.Open();
                var cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestImportData()
        {
            IRestaurantRepository repo = new RestaurantRepository();
            IInspectionRepository insRepo = new InspectionRepository();
            IViolationRepository vioRepo = new ViolationRepository();

            RI.Data.Startup.Start(); //initialize automapper

            InspectionImportService importer = new InspectionImportService(repo, insRepo, vioRepo);
            importer.Import(@"..\..\..\Sample_Data\3fdinspi_subset.csv");
        }

        [TestMethod]
        public void GetRestaurantsListTest()
        {
            RI.Data.Startup.Start(); //initialize automapper

            IRestaurantRepository repo = new RestaurantRepository();
            IGetRestaurantsListQuery _query = new GetRestaurantsListQuery(repo);

            var list = _query.Execute();
            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void BurnDownDb()
        {
            SqlConnection cnn;
            SqlCommand cmd;
            string sql = null;

            sql = "Select * from [Testing].[ri].[Restaurant]";

            sql = @"

            drop table ri.InspectionViolation
            drop table ri.violation
            drop table ri.Inspection
            drop table ri.Restaurant
            drop table dbo.VersionInfo
            DROP SCHEMA ri

            ";

            cnn = new SqlConnection(_connectionString);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                //
            }
        }

        //TODO: run the fluent migrator to rebuild the database... https://softwareengineering.stackexchange.com/a/159202/101534
    }
}
