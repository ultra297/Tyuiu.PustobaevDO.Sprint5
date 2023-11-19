using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.PustobaevDO.Sprint5.Task3.V24.Lib;

namespace Tyuiu.PustobaevDO.Sprint5.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\D1\source\repos\Tyuiu.PustobaevDO.Sprint5\Tyuiu.PustobaevDO.Sprint5.Task3.V24\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(false, fileExists);
        }
    }
}
