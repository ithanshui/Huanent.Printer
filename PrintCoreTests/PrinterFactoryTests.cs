﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PrintCore.Tests
{
    [TestClass()]
    public class PrinterFactoryTests
    {
        [TestMethod()]
        public void GetPritnterTest()
        {
            string printName = "Microsoft XPS Document Writer";
            var print = PrinterFactory.GetPrinter(printName, PrintWidth.Print80mm);
            print.Print(new PrintUnit[] {
                new PrintUnit{
                    Alignment =StringAlignment.Center,
                    Content ="测试文本",
                    Y =10,
                    Font =new Font("黑体",12)
                }
            });
        }
    }
}