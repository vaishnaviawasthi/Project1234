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
    class ProjectRepositoryTest
    {
        IRepository<Project> repo;
        [SetUp]
        public void SetUp()
        {
            repo = new ProjectRepository();
        }
        //[Test]
        //public void AddProjectTest()
        //{
        //    ProjectRepository obj = new ProjectRepository();
        //    int Actual = obj.Add();
        //}
        [Test]
        public void GetAllProjectTest()
        {
            var ActualCount = repo.Display().Count;
            var ExpectedCount = 0;
            Assert.AreEqual(ExpectedCount, ActualCount);
        }
        [Test]
        public void FindProjectTest()
        {
            var Obj = repo.Find(1);
            Assert.IsNotNull(Obj);
            Assert.IsInstanceOf<Project>(Obj);
        }
        [Test]
        public void FindReturnNullProjectTest()
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