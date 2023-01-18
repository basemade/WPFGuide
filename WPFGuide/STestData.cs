using System;
using System.Collections.Generic;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;


namespace WPFGuide
{
    public class STestData
    {
        public List<gagaEmployee1> empList_1 = new List<gagaEmployee1>()
        {
            new gagaEmployee1(){theId_1 = 1, theName_1 = "Tim", Age_1 = 30},
            new gagaEmployee1(){theId_1 = 2, theName_1 = "Tom", Age_1 = 26},
            new gagaEmployee1(){theId_1 = 3, theName_1 = "Guo", Age_1 = 24},
            new gagaEmployee1(){theId_1 = 4, theName_1 = "Kam", Age_1 = 34},
            new gagaEmployee1(){theId_1 = 5, theName_1 = "Ape", Age_1 = 30},
            new gagaEmployee1(){theId_1 = 6, theName_1 = "Ron", Age_1 = 28}
        };
    }

    public class gagaEmployee1
    {
        public int theId_1;
        public string theName_1;
        public int Age_1;
    }

}
