using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjectManagerDAL;
namespace ProjectManagerDALTest
{
    [TestFixture]
    class TaskRepositoryTest
    {
        IRepository<TaskN> repo;
        [SetUp]
        public void SetUp()
        {
            repo = new TaskNRepository();
        }
      
        [Test]
        public void GetAllTaskTest()
        {
            var ActualCount = repo.Display().Count;
            var ExpectedCount = 0;
            Assert.AreEqual(ExpectedCount, ActualCount);
        }
        [Test]
        public void FindTaskTest()
        {
            var Obj = repo.Find(1);
            Assert.IsNotNull(Obj);
            Assert.IsInstanceOf<TaskN>(Obj);
        }
        [Test]
        public void FindReturnNullTaskTest()
        {
            var Obj = repo.Find(0);
            Assert.IsNull(Obj);
        }
        [TearDown]
        public void CleanUp()
        {
            repo.Dispose();
        }
    }
}