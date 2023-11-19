using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.PustobaevDO.Sprint5.Task1.V12.Lib;

namespace Tyuiu.PustobaevDO.Sprint5.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\D1\source\repos\Tyuiu.PustobaevDO.Sprint5\Tyuiu.PustobaevDO.Sprint5.Task1.V12\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
