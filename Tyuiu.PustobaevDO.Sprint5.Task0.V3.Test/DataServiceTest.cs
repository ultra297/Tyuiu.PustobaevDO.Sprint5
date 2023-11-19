using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PustobaevDO.Sprint5.Task0.V3.Lib;
using System.IO;


namespace Tyuiu.PustobaevDO.Sprint5.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\D1\source\repos\Tyuiu.PustobaevDO.Sprint5\Tyuiu.PustobaevDO.Sprint5.Task0.V3\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
