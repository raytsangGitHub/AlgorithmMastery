using LeetCode150Lib;
using Microsoft.Extensions.Hosting;

namespace LeetCodeLibNunit
{
    public abstract class TestBase
    {
        protected IHost TestHost { get; private set; }
        protected IServiceProvider ServiceProvider => TestHost.Services;

        [SetUp]
        public void Setup()
        {
            //Method setup test host
            TestHost = Host.CreateDefaultBuilder()
                .ConfigRegisterService()  // Use the custom extension method
                .Build();
        }

        [TearDown]
        public void TearDown()
        {
            TestHost?.Dispose();

            //if (TestHost is not null)  //var v = o != null ? o.ToString() : null;
            //{
            //    TestHost.Dispose();
            //}
        }
    }
}