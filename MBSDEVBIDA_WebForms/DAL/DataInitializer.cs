using System.Collections.Generic;
using System.Data.Entity;
using DAL;


namespace DAL
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<AXMbsDevEntities>
    {
        protected override void Seed(AXMbsDevEntities context)
        {
            GetWebUsers().ForEach(m => context.MBSWBWEBUSERCONTACT.Add(m));
            GetSalesReps().ForEach(s => context.MBSBDSALESREPTABLE.Add(s));
            GetCompanies().ForEach(c => context.DATAAREA.Add(c));
            GetInvoices().ForEach(i => context.CUSTINVOICEJOUR.Add(i));
            GetInvoiceLines().ForEach(il => context.CUSTINVOICETRANS.Add(il));
            GetCustomers().ForEach(ct => context.CUSTTABLE.Add(ct));
        }
        private static List<CUSTTABLE> GetCustomers()
        {
            var customers = new List<CUSTTABLE> {
                new CUSTTABLE
                {
                    ACCOUNTNUM = "100000",
                    NAME = "Master Yoda",                    
                    CITY = "Hoth",
                    STATE = "CO",
                    ZIPCODE = "80012",
                    STREET = "1234 Wookie Way",
                    MBSDEPARTMENTCODE = "Accounts Receivable",
                    PHONE = "3031234567",
                    EMAIL = "Masteryoda@jedi.com",
                    DATAAREAID = "MBS"
                },
                new CUSTTABLE
                {
                    ACCOUNTNUM = "100001",
                    NAME = "Nick Olsen",                    
                    CITY = "Parker",
                    STATE = "CO",
                    ZIPCODE = "80135",
                    STREET = "11321 Lowage Way",
                    MBSDEPARTMENTCODE = "Warehouse",
                    PHONE = "3038765432",
                    EMAIL = "nickolsen@hotmail.com",
                    DATAAREAID = "MBS"
                },
                new CUSTTABLE
                {
                    ACCOUNTNUM = "100003",
                    NAME = "Scott VandenElzen",                    
                    CITY = "Denver",
                    STATE = "CO",
                    ZIPCODE = "80011",
                    STREET = "123 Regis Way",
                    MBSDEPARTMENTCODE = "Academia",
                    PHONE = "3033124567",
                    EMAIL = "scottvandenelzen@hotmail.com",
                    DATAAREAID = "COP"
                },
                new CUSTTABLE
                {
                    ACCOUNTNUM = "100004",
                    NAME = "Sidney Crosby",                    
                    CITY = "Pittsburgh",
                    STATE = "PA",
                    ZIPCODE = "60001",
                    STREET = "9891 S. University St.",
                    MBSDEPARTMENTCODE = "Hockey",
                    PHONE = "7174328543",
                    EMAIL = "sidneycrosby@hotmail.com",
                    DATAAREAID = "COP"
                }
                
            };

            return customers;
        }
        private static List<MBSBDSALESREPTABLE> GetSalesReps()
        {
            var salesReps = new List<MBSBDSALESREPTABLE> {
                new MBSBDSALESREPTABLE
                {
                    SALESREPID = "1",
                    NAME = "Joe Cheeseball",
                    DATAAREAID = "MBS"
                },
                new MBSBDSALESREPTABLE
                {
                    SALESREPID = "2",
                    NAME = "Chris Jones",
                    DATAAREAID = "COP"
                }
                
            };

            return salesReps;
        }
        private static List<DATAAREA> GetCompanies()
        {
            var dataAreas = new List<DATAAREA> {
                new DATAAREA
                {
                ID = "MBS",
                NAME = "MBS Dev, INC.",
                },
                new DATAAREA
                {
                ID = "COP",
                NAME = "C Office Products",
                }          
            };

            return dataAreas;
        }
        private static List<CUSTINVOICEJOUR> GetInvoices()
        {


            var invoices = new List<CUSTINVOICEJOUR> {
                new CUSTINVOICEJOUR
                {
                    SALESID = "1",
                    ORDERACCOUNT = "100000",
                    INVOICEDATE = new System.DateTime(2013, 11, 10),
                    SALESBALANCE = 100,
                    INVOICEAMOUNT =  110,
                    INVOICEID = "1",
                    SUMTAX = 10,
                    MBSPRIMARYSALESREP = "1",
                    DATAAREAID = "MBS"
                },
                new CUSTINVOICEJOUR
                {
                    SALESID = "1",
                    ORDERACCOUNT = "100000",
                    INVOICEDATE = new System.DateTime(2013, 11, 11),
                    SALESBALANCE = 100,
                    INVOICEAMOUNT =  110,
                    INVOICEID = "2",
                    SUMTAX = 10,
                    MBSPRIMARYSALESREP = "1",
                    DATAAREAID = "MBS"
                },
                new CUSTINVOICEJOUR
                {
                    SALESID = "2",
                    ORDERACCOUNT = "100001",
                    INVOICEDATE = new System.DateTime(2013, 10, 10),
                    SALESBALANCE = 100,
                    INVOICEAMOUNT =  110,
                    INVOICEID = "3",
                    SUMTAX = 10,
                    MBSPRIMARYSALESREP = "1",
                    DATAAREAID = "MBS"
                },    
                new CUSTINVOICEJOUR
                {
                    SALESID = "3",
                    ORDERACCOUNT = "100001",
                    INVOICEDATE = new System.DateTime(2013, 9, 10),
                    SALESBALANCE = 100,
                    INVOICEAMOUNT =  110,
                    INVOICEID = "4",
                    SUMTAX = 10,
                    MBSPRIMARYSALESREP = "2",
                    DATAAREAID = "COP"
                },      
                new CUSTINVOICEJOUR
                {
                    SALESID = "4",
                    ORDERACCOUNT = "100003",
                    INVOICEDATE = new System.DateTime(2013, 8, 7),
                    SALESBALANCE = 1000,
                    INVOICEAMOUNT =  1100,
                    INVOICEID = "5",
                    SUMTAX = 100,
                    MBSPRIMARYSALESREP = "2",
                    DATAAREAID = "COP"
                }   
            };

            return invoices;
        }
        private static List<CUSTINVOICETRANS> GetInvoiceLines()
        {
            var invoiceLines = new List<CUSTINVOICETRANS> {
                new CUSTINVOICETRANS
                {
                    INVOICEID = "1",
                    INVOICEDATE = new System.DateTime(2013, 11, 10),
                    ITEMID = "1",
                    NAME = "Paper Ream",
                    QTY = 2,
                    SALESPRICE = 25,
                    LINEAMOUNT = 50,
                    DATAAREAID = "MBS"
                },
                new CUSTINVOICETRANS
                {
                    INVOICEID = "1",
                    INVOICEDATE = new System.DateTime(2013, 11, 10),
                    ITEMID = "2",
                    NAME = "Staples",
                    QTY = 1,
                    SALESPRICE = 50,
                    LINEAMOUNT = 50,
                    DATAAREAID = "MBS"
                },
                new CUSTINVOICETRANS
                {
                    INVOICEID = "2",
                    INVOICEDATE = new System.DateTime(2013, 11, 11),
                    ITEMID = "3",
                    NAME = "Paper Clips",
                    QTY = 1,
                    SALESPRICE = 100,
                    LINEAMOUNT = 100,
                    DATAAREAID = "MBS"
                },
                new CUSTINVOICETRANS
                {
                    INVOICEID = "3",
                    INVOICEDATE = new System.DateTime(2013, 10, 10),
                    ITEMID = "4",
                    NAME = "Office Chair",
                    QTY = 1,
                    SALESPRICE = 100,
                    LINEAMOUNT = 100,
                    DATAAREAID = "MBS"
                },
                new CUSTINVOICETRANS
                {
                    INVOICEID = "4",
                    INVOICEDATE = new System.DateTime(2013, 9, 10),
                    ITEMID = "4",
                    NAME = "Office Chair",
                    QTY = 1,
                    SALESPRICE = 100,
                    LINEAMOUNT = 100,
                    DATAAREAID = "COP"
                },
                new CUSTINVOICETRANS
                {
                    INVOICEID = "5",
                    INVOICEDATE = new System.DateTime(2013, 11, 10),
                    ITEMID = "4",
                    NAME = "Office Chair",
                    QTY = 10,
                    SALESPRICE = 100,
                    LINEAMOUNT = 1000,
                    DATAAREAID = "COP"
                }              
            };

            return invoiceLines;
        }
        private static List<MBSWBWEBUSERCONTACT> GetWebUsers()
        {
            var webUsers = new List<MBSWBWEBUSERCONTACT> {
                new MBSWBWEBUSERCONTACT
                {
                    ACCOUNTNUM = "100",
                    WEBLOGON = "username",
                    WEBPASSWORD = "Pass@word1",
                    DATAAREAID = "MBS"
                   
                },
                new MBSWBWEBUSERCONTACT
                {
                    ACCOUNTNUM = "100",
                    WEBLOGON = "username",
                    WEBPASSWORD = "Pass@word1",
                    DATAAREAID = "MBS"
                }              
            };
            return webUsers;
        }
    }
}