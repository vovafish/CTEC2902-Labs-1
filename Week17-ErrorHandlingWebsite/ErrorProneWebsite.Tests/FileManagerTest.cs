﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ErrorProneWebsite.Models;
using System.IO;

namespace ErrorProneWebsite.Tests
{
    [TestClass]
    public class FileManagerTest
    {
        private const string TEST_FILE_PATH = @"C:\Users\vladi\Desktop\Advanced Programming\CTEC2902-Labs-1\Week17-ErrorHandlingWebsite\ErrorProneWebsite.Tests\TestContent\TestContent.txt";

        [TestMethod]
        public void TheFileManagerCanReadAFile()
        {
            FileManager fileManager = new FileManager(TEST_FILE_PATH);

            Assert.AreEqual("Here is some test content.", fileManager.GetContent());


        }

        [TestMethod]
        public void TheFileManagerHandlesAMissingFile()
        {
            FileManager fileManager =
            new FileManager(@"C:\Users\vladi\Desktop\Advanced Programming\CTEC2902-Labs-1\Week17-ErrorHandlingWebsite\ErrorProneWebsite.Tests\TestContent\TestContent1.txt");
            Assert.IsTrue(fileManager.GetContent().Contains("Oops! The content could not be found at the location specified."));
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TheSystemThrowsAFileNotFoundExceptionWhenGivenAPathToAMissingFile()
        {
            FileManager fileManager = new
            FileManager(@"C:\MissingFileThereIsNoFileHere.txt");
            Assert.IsTrue(fileManager.GetEvenMoreContent().Contains("This line won't execute as the exception will be thrown before it's hit"));
        }
    }
}
