using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.PustobaevDO.Sprint5.Task5.V24.Lib;

namespace Tyuiu.PustobaevDO.Sprint5.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\D1\source\repos\Tyuiu.PustobaevDO.Sprint5\Tyuiu.PustobaevDO.Sprint5.Task5.V24\bin\Debug\OutPutFileTask5V24.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
