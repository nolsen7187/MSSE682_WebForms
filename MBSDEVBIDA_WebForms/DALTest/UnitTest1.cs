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
        public void TestWriteToDataAreaTable()
        {
            /*ar CIJRepo = new DataRepository<CUSTINVOICEJOUR>();
            CUSTINVOICEJOUR CIJ = new CUSTINVOICEJOUR();
            CIJ.DATAAREAID = "MBS";
            CIJRepo.Create(CIJ);*/

            AXMbsDevEntities data = new AXMbsDevEntities();
            DATAAREA DA = new DATAAREA();
            DA.ID = "Rr";
            DA.NAME = "Sucks Balls";
            //DA.RECID = 1;

            data.DATAAREAs.Add(DA);
            data.SaveChanges();
        }
        [TestMethod]
        public void TestRepositoryWriteToDataAreaTable()
        {
            var DARepo = new DataRepository<DATAAREA>();
            DATAAREA DA = new DATAAREA();
            DA.ID = "aR";
            DA.NAME = "Sucks Balls";
            DARepo.Create(DA);
        }
        [TestMethod]
        public void TestRepositoryWriteToMbsWbWebUserTable()
        {
            var MWCRepo = new DataRepository<MBSWBWEBUSERCONTACT>();
            MBSWBWEBUSERCONTACT MWC = new MBSWBWEBUSERCONTACT();
            MWC.ACCOUNTNUM = "100";
            MWC.EMAIL = "nolsen@mbsdev.com";
            MWC.NAME = "Nick Olsen";
            MWC.CONTACTPERSONID = "101";
            MWC.WEBLOGON = "username";
            MWC.WEBPASSWORD = "Pass@word1";
            MWC.DATAAREAID = "MBS";
            MWCRepo.Create(MWC);
        }
    }
}
