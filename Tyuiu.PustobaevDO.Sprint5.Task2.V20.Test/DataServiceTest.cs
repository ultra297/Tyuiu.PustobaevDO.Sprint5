using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.PustobaevDO.Sprint5.Task2.V20.Lib;

namespace Tyuiu.PustobaevDO.Sprint5.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test2()
        {
            string path = @"C:\Users\D1\source\repos\Tyuiu.PustobaevDO.Sprint5\Tyuiu.PustobaevDO.Sprint5.Task2.V20\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileex);
        }
    }
}
