using System;
using System.Collections.Generic;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;


namespace WPFGuide
{
    public class TTestData
    {
        public static List<gagaEmployee3> empList_3 = new List<gagaEmployee3>()
        //原本沒加static會報錯：CS0120
        //https://learn.microsoft.com/zh-tw/dotnet/csharp/language-reference/compiler-messages/cs0120?f1url=%3FappId%3Droslyn&k=k(CS0120)
        //https://learn.microsoft.com/zh-tw/dotnet/csharp/programming-guide/classes-and-structs/static-constructors

            {
                new gagaEmployee3(){theName_3 = "Ti", Age_3 = 3},
                new gagaEmployee3(){theName_3 = "To", Age_3 = 2},
                new gagaEmployee3(){theName_3 = "Gu", Age_3 = 2},
                new gagaEmployee3(){theName_3 = "Ka", Age_3 = 3},
                new gagaEmployee3(){theName_3 = "Ap", Age_3= 3},
                new gagaEmployee3(){theName_3 = "Ro", Age_3 = 2}
            };
    }

    public class gagaEmployee3
    {
        public string theName_3 { get; set; }
        public int Age_3 { get; set; }
    }

}
