using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManagerAPI.Controllers;
using Moq;
using Repository;
using Common.Logging;
using System.Net.Http;

namespace APITest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        //[TestMethod]
        //public void TestGetTasks()
        //{
        //    var mockTaskrepository = new Mock<IRepository<Task>>();
        //    var mockvwTaskrepository = new Mock<IRepository<vw_Tasks>>();
        //    var mockLog = new Mock<ILogger>();
        //    var service = new TaskController(mockTaskrepository.Object, mockvwTaskrepository.Object, mockLog.Object);
        //    //Check the equality between the returned data and the expected data
        //    Assert.AreEqual(1, service.GetTasks().Count);
        //}
    }
}
