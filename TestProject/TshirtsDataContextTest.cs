using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Data.Linq.Mapping;
using System.Data;
using System.Data.Linq;

namespace TestProject
{
    
    
    /// <summary>
    ///This is a test class for TshirtsDataContextTest and is intended
    ///to contain all TshirtsDataContextTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TshirtsDataContextTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for TshirtsDataContext Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\julio\\Documents\\GitHub\\lp3", "/lp3")]
        [UrlToTest("http://localhost/lp3")]
        public void TshirtsDataContextConstructorTest()
        {
            string connection = string.Empty; // TODO: Initialize to an appropriate value
            MappingSource mappingSource = null; // TODO: Initialize to an appropriate value
            TshirtsDataContext_Accessor target = new TshirtsDataContext_Accessor(connection, mappingSource);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for TshirtsDataContext Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\julio\\Documents\\GitHub\\lp3", "/lp3")]
        [UrlToTest("http://localhost/lp3")]
        public void TshirtsDataContextConstructorTest1()
        {
            IDbConnection connection = null; // TODO: Initialize to an appropriate value
            MappingSource mappingSource = null; // TODO: Initialize to an appropriate value
            TshirtsDataContext_Accessor target = new TshirtsDataContext_Accessor(connection, mappingSource);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for TshirtsDataContext Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\julio\\Documents\\GitHub\\lp3", "/lp3")]
        [UrlToTest("http://localhost/lp3")]
        public void TshirtsDataContextConstructorTest2()
        {
            IDbConnection connection = null; // TODO: Initialize to an appropriate value
            TshirtsDataContext_Accessor target = new TshirtsDataContext_Accessor(connection);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for TshirtsDataContext Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\julio\\Documents\\GitHub\\lp3", "/lp3")]
        [UrlToTest("http://localhost/lp3")]
        public void TshirtsDataContextConstructorTest3()
        {
            TshirtsDataContext_Accessor target = new TshirtsDataContext_Accessor();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for TshirtsDataContext Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\julio\\Documents\\GitHub\\lp3", "/lp3")]
        [UrlToTest("http://localhost/lp3")]
        public void TshirtsDataContextConstructorTest4()
        {
            string connection = string.Empty; // TODO: Initialize to an appropriate value
            TshirtsDataContext_Accessor target = new TshirtsDataContext_Accessor(connection);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for clients
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\julio\\Documents\\GitHub\\lp3", "/lp3")]
        [UrlToTest("http://localhost/lp3")]
        public void clientsTest()
        {
            TshirtsDataContext_Accessor target = new TshirtsDataContext_Accessor(); // TODO: Initialize to an appropriate value
            Table<client> actual;
            actual = target.clients;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for detailedTshirts
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\julio\\Documents\\GitHub\\lp3", "/lp3")]
        [UrlToTest("http://localhost/lp3")]
        public void detailedTshirtsTest()
        {
            TshirtsDataContext_Accessor target = new TshirtsDataContext_Accessor(); // TODO: Initialize to an appropriate value
            Table<detailedTshirt> actual;
            actual = target.detailedTshirts;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for items
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\julio\\Documents\\GitHub\\lp3", "/lp3")]
        [UrlToTest("http://localhost/lp3")]
        public void itemsTest()
        {
            TshirtsDataContext_Accessor target = new TshirtsDataContext_Accessor(); // TODO: Initialize to an appropriate value
            Table<item> actual;
            actual = target.items;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for sellOrders
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\julio\\Documents\\GitHub\\lp3", "/lp3")]
        [UrlToTest("http://localhost/lp3")]
        public void sellOrdersTest()
        {
            TshirtsDataContext_Accessor target = new TshirtsDataContext_Accessor(); // TODO: Initialize to an appropriate value
            Table<sellOrder> actual;
            actual = target.sellOrders;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for sizes
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\julio\\Documents\\GitHub\\lp3", "/lp3")]
        [UrlToTest("http://localhost/lp3")]
        public void sizesTest()
        {
            TshirtsDataContext_Accessor target = new TshirtsDataContext_Accessor(); // TODO: Initialize to an appropriate value
            Table<size> actual;
            actual = target.sizes;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for tshirts
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\julio\\Documents\\GitHub\\lp3", "/lp3")]
        [UrlToTest("http://localhost/lp3")]
        public void tshirtsTest()
        {
            TshirtsDataContext_Accessor target = new TshirtsDataContext_Accessor(); // TODO: Initialize to an appropriate value
            Table<tshirt> actual;
            actual = target.tshirts;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
