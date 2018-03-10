using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class FactorsPurchases : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private Random gen = new Random();
        DateTime RandomDay()
        {
            DateTime start = new DateTime(2018, 2, 27);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                VodioContainer ve = new VodioContainer();
                User ali = new User()
                {
                    Msisdn = "912",
                    Platform = "test",
                    Code = 0,
                    CodeSentTime = DateTime.Now,
                    RetryCodeSent = 0,
                    FailedCodeTry = 0
                };
                ve.Users.Add(ali);
                ve.SaveChanges();

                Movie mov1 = ve.Movies.Where(a => a.Id == 1).FirstOrDefault();
                Movie mov2 = ve.Movies.Where(a => a.Id == 2).FirstOrDefault();
                Movie mov3 = ve.Movies.Where(a => a.Id == 3).FirstOrDefault();
                Movie mov4 = ve.Movies.Where(a => a.Id == 4).FirstOrDefault();
                Movie mov5 = ve.Movies.Where(a => a.Id == 5).FirstOrDefault();
                Movie mov6 = ve.Movies.Where(a => a.Id == 6).FirstOrDefault();
                Movie mov7 = ve.Movies.Where(a => a.Id == 7).FirstOrDefault();

                Purchase p1 = new Purchase()
                {
                    UserId = ve.Users.Where(a => a.Msisdn == "912").FirstOrDefault().Id,
                    MovieId = mov1.Id,
                    DateTime = RandomDay()
                };
                Purchase p2 = new Purchase()
                {
                    UserId = ve.Users.Where(a => a.Msisdn == "912").FirstOrDefault().Id,
                    MovieId = mov2.Id,
                    DateTime = RandomDay()
                };
                Purchase p3 = new Purchase()
                {
                    UserId = ve.Users.Where(a => a.Msisdn == "912").FirstOrDefault().Id,
                    MovieId = mov3.Id,
                    DateTime = RandomDay()
                };
                Purchase p4 = new Purchase()
                {
                    UserId = ve.Users.Where(a => a.Msisdn == "912").FirstOrDefault().Id,
                    MovieId = mov4.Id,
                    DateTime = RandomDay()
                };
                Purchase p5 = new Purchase()
                {
                    UserId = ve.Users.Where(a => a.Msisdn == "912").FirstOrDefault().Id,
                    MovieId = mov5.Id,
                    DateTime = RandomDay()
                };
                Purchase p6 = new Purchase()
                {
                    UserId = ve.Users.Where(a => a.Msisdn == "912").FirstOrDefault().Id,
                    MovieId = mov6.Id,
                    DateTime = RandomDay()
                };
                Purchase p7 = new Purchase()
                {
                    UserId = ve.Users.Where(a => a.Msisdn == "912").FirstOrDefault().Id,
                    MovieId = mov7.Id,
                    DateTime = RandomDay(),

                };
                //ve.Purchases.Add(p1);
                //ve.Purchases.Add(p2);
                //ve.Purchases.Add(p3);
                //ve.Purchases.Add(p4);
                //ve.Purchases.Add(p5);
                //ve.Purchases.Add(p6);
                //ve.Purchases.Add(p7);
                //ve.SaveChanges();


                Factor fac1 = new Factor
                {
                    DateTime = RandomDay(),
                    TransactionId = "0",
                    UserId = ve.Users.Where(a => a.Msisdn == "912").FirstOrDefault().Id,
                    MovieID = mov1.Id,
                    Amount = 0,
                    Result = true,
                    CompleteDateTime = RandomDay(),
                    Purchase = p1
                };
                Random rand = new Random();
                if (rand.Next(5) == 0)
                {
                    ve.Factors.Add(fac1);
                    ve.SaveChanges();
                }

                Factor fac2 = new Factor
                {
                    DateTime = RandomDay(),
                    TransactionId = "0",
                    UserId = ve.Users.Where(a => a.Msisdn == "912").FirstOrDefault().Id,
                    MovieID = mov2.Id,
                    Amount = 0,
                    Result = true,
                    CompleteDateTime = RandomDay(),
                    Purchase = p2
                };
                Random rand2 = new Random();
                if (rand2.Next(2) == 0)
                {
                    ve.Factors.Add(fac2);
                    ve.SaveChanges();
                }
                Factor fac3 = new Factor
                {
                    DateTime = RandomDay(),
                    TransactionId = "0",
                    UserId = ve.Users.Where(a => a.Msisdn == "912").FirstOrDefault().Id,
                    MovieID = mov3.Id,
                    Amount = 0,
                    Result = true,
                    CompleteDateTime = RandomDay(),
                    Purchase = p3
                };
                Random rand3 = new Random();
                if (rand3.Next(7) == 0)
                {
                    ve.Factors.Add(fac3);
                    ve.SaveChanges();
                }
                Factor fac4 = new Factor
                {
                    DateTime = RandomDay(),
                    TransactionId = "0",
                    UserId = ve.Users.Where(a => a.Msisdn == "912").FirstOrDefault().Id,
                    MovieID = mov4.Id,
                    Amount = 0,
                    Result = true,
                    CompleteDateTime = RandomDay(),
                    Purchase = p4
                };
                Random rand4 = new Random();
                if (rand4.Next(6) == 0)
                {
                    ve.Factors.Add(fac4);
                    ve.SaveChanges();
                }
                Factor fac5 = new Factor
                {
                    DateTime = RandomDay(),
                    TransactionId = "0",
                    UserId = ve.Users.Where(a => a.Msisdn == "912").FirstOrDefault().Id,
                    MovieID = mov5.Id,
                    Amount = 0,
                    Result = true,
                    CompleteDateTime = RandomDay(),
                    Purchase = p5
                };
                Random rand5 = new Random();
                if (rand5.Next(5) == 0)
                {
                    ve.Factors.Add(fac5);
                    ve.SaveChanges();
                }
                Factor fac6 = new Factor
                {
                    DateTime = RandomDay(),
                    TransactionId = "0",
                    UserId = ve.Users.Where(a => a.Msisdn == "912").FirstOrDefault().Id,
                    MovieID = mov6.Id,
                    Amount = 0,
                    Result = true,
                    CompleteDateTime = RandomDay(),
                    Purchase = p6
                };
                Random rand6 = new Random();
                if (rand6.Next(3) != 0)
                {
                    ve.Factors.Add(fac6);
                    ve.SaveChanges();
                }
                Factor fac7 = new Factor
                {
                    DateTime = RandomDay(),
                    TransactionId = "0",
                    UserId = ve.Users.Where(a => a.Msisdn == "912").FirstOrDefault().Id,
                    MovieID = mov7.Id,
                    Amount = 0,
                    Result = true,
                    CompleteDateTime = RandomDay(),
                    Purchase = p7
                };
                Random rand7 = new Random();
                if (rand7.Next(4) != 0)
                {
                    ve.Factors.Add(fac7);
                    ve.SaveChanges();
                }
            }
        }
    }
}