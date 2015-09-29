using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //AAA
            //1. Arrange => Instancie 
            Pupil p = new Pupil("pupil1", 20, 1);
            Activity a = new Activity("act2", true);
            //2. Act => On utilise
            p.AddActivity(a);
            p.AddEvaluation("act2", 'd');
            //3. Assert => On compare résultat obtenu et on compare
            var evaluation = p.GetEvaluationFor("act2");
            Assert.AreEqual('d', evaluation);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void TestForException()
        {
            //AAA
            //1.Arrange
            Pupil p = new Pupil("pupil1", 20, 1);
            Activity a = new Activity("act2", true);
            //2.Act
            p.AddActivity(a);
            p.AddEvaluation("act2", 'd');
            //3.Assert
            var evaluation = p.GetEvaluationFor("act3");
            Assert.AreEqual('d', evaluation);
        }
    }
}
