using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();

            Assert.IsTrue(testJob1.Id != testJob2.Id);
            Assert.IsTrue(testJob2.Id - testJob1.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            string name = "Product Tester";
            Employer employerName = new Employer("ACME");
            Location employerLocation = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");

            Job testJob = new Job(name, employerName, employerLocation, jobType, jobCoreCompetency);

            Assert.AreEqual(testJob.Name, name);
            Assert.AreEqual(testJob.EmployerName, employerName);
            Assert.AreEqual(testJob.EmployerLocation, employerLocation);
            Assert.AreEqual(testJob.JobType, jobType);
            Assert.AreEqual(testJob.JobCoreCompetency, jobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            string name = "Product Tester";
            Employer employerName = new Employer("ACME");
            Location employerLocation = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");

            Job testJob1 = new Job(name, employerName, employerLocation, jobType, jobCoreCompetency);
            Job testJob2 = new Job(name, employerName, employerLocation, jobType, jobCoreCompetency);

            Assert.IsFalse(testJob1.Equals(testJob2));
        }

        [TestMethod]
        public void TestJobToStringStartsAndEndsWithEmptyLine()
        {
            string name = "Product Tester";
            Employer employerName = new Employer("ACME");
            Location employerLocation = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");

            Job testJob = new Job(name, employerName, employerLocation, jobType, jobCoreCompetency);

            Assert.IsTrue(testJob.ToString().StartsWith("\n"));
            Assert.IsTrue(testJob.ToString().EndsWith("\n"));
        }

        [TestMethod]
        public void TestJobToStringCorrectOutput()
        {
            string name = "Product Tester";
            Employer employerName = new Employer("ACME");
            Location employerLocation = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");

            Job testJob = new Job(name, employerName, employerLocation, jobType, jobCoreCompetency);

            string expectedOutput = String.Format("\nId: {0}\nName: {1}\nEmployer: {2}\nLocation: {3}\nPosition Type: {4}\nCore Competency: {5}\n", testJob.Id, name, employerName, employerLocation, jobType, jobCoreCompetency);

            Assert.IsTrue(testJob.ToString() == expectedOutput);
        }

        [TestMethod]
        public void TestJobToStringEmptyField()
        {
            Job testJob = new Job();

            string emptyFieldString = "Data not available";
            string expectedOutput = String.Format("\nId: {0}\nName: {1}\nEmployer: {2}\nLocation: {3}\nPosition Type: {4}\nCore Competency: {5}\n", testJob.Id, emptyFieldString, emptyFieldString, emptyFieldString, emptyFieldString, emptyFieldString);

            Assert.IsTrue(testJob.ToString() == expectedOutput);
        }
    }
}
