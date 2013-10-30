using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Linq;
using DAL;
using System.Collections.Generic;
using System.Collections;
using System.Data.Entity;
using System.Configuration;

namespace DALTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRepoWrite()
        {
            /*ar CIJRepo = new DataRepository<CUSTINVOICEJOUR>();
            CUSTINVOICEJOUR CIJ = new CUSTINVOICEJOUR();
            CIJ.DATAAREAID = "MBS";
            CIJRepo.Create(CIJ);*/

            MBSDEVBIDAEntities data = new MBSDEVBIDAEntities();
            CUSTINVOICEJOUR CIJ = new CUSTINVOICEJOUR();
            CIJ.DATAAREAID = "MBS";

            data.CUSTINVOICEJOURs.Add(CIJ);
            data.SaveChanges();
        }
    }
}
