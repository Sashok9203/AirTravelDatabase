using Microsoft.EntityFrameworkCore;
using AirTravelDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirTravelDatabase.Data
{
    public static class Data
    {
        public static void Initializer(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(Data.Cities);
            modelBuilder.Entity<Country>().HasData(Data.Countries);
            modelBuilder.Entity<Account>().HasData(Data.Accounts);
            modelBuilder.Entity<Gender>().HasData(Data.Genders);
            modelBuilder.Entity<PlaneType>().HasData(Data.PlaneTypes);
            modelBuilder.Entity<Client>().HasData(Data.Clients);
            modelBuilder.Entity<Plane>().HasData(Data.Planes);
            modelBuilder.Entity<Flight>().HasData(GetFlights(1000));
        }

        

        public static readonly City[] Cities =
        {
            new(){ Id = 1, CountryId =  1, Name = "Gdansk" },
            new(){ Id = 2, CountryId =  1, Name = "Wroclaw" },
            new(){ Id = 3, CountryId =  1, Name = "Poznan" },

            new(){ Id = 4, CountryId =  2, Name = "Berlin"},
            new(){ Id = 5, CountryId =  2, Name = "Frankfurt"},
            new(){ Id = 6, CountryId =  2, Name = "Cologne"},

            new(){ Id = 7, CountryId =  3, Name = "Kyiv" },
            new(){ Id = 8, CountryId =  3, Name = "Lviv"},
            new(){ Id = 9, CountryId =  3, Name = "Dnipro"},
        };

      

        public static readonly Country[] Countries =
        {
            new(){Id = 1,  Name ="Poland"},
            new(){Id = 2,  Name ="Germany"},
            new(){Id = 3,  Name = "Ukraine"},
        };
        public static readonly Account[] Accounts =
        {
             new(){ Id=1,Login="fraun0",Password="rY5&+hU#'gnU"  ,ClientId = 1 },
             new(){ Id=2,Login="bkiffe1",Password="vT3=sZx}Wbdgiz4",ClientId = 2},
             new(){ Id=3,Login="jolivie2",Password="rH5`J7!BKd2" ,ClientId = 3},
             new(){ Id=4,Login="chasker3",Password="rW5+$F.CP9%aXIq" , ClientId = 4},
             new(){ Id=5,Login="bdrogan4",Password="cS6%q0NTB" ,ClientId = 5 },
             new(){ Id=6,Login="ahalpin5",Password="gP5\"kJLnew DateTime.Now,r_.F5_|" ,ClientId = 6 },
             new(){ Id=7,Login="pjoye6",Password="zP4/Jg@lnew DateTime.Now,ckYeeP@" , ClientId = 7},
             new(){ Id=8,Login="mskeene7",Password="tX9>)arjOU)tS27$"    , ClientId = 8},
             new(){ Id=9,Login="esiemandl8",Password="pU6/2lRf+!\""      , ClientId = 9},
             new(){ Id=10,Login="dbuey9",Password="oC5\\eUvZL8"          , ClientId = 10},
             new(){ Id=11,Login="hlermita",Password="zD4new DateTime.Now,A0H&"           , ClientId = 11},
             new(){ Id=12,Login="msymonesb",Password="vH2|C>hz+J2YR,L<"  , ClientId = 12},
             new(){ Id=13,Login="hknobellc",Password="yC9\\'LaMtOf=HGU"  , ClientId = 13},
             new(){ Id=14,Login="clehriand",Password="vG3,ER\"W{6fN3e"   , ClientId = 14},
             new(){ Id=15,Login="solneye",Password="pQ6.daQY<)6>{"       , ClientId = 15},
             new(){ Id=16,Login="dislepf",Password="iF7}k(new DateTime.Now,h"            , ClientId = 16},
             new(){ Id=17,Login="sgarvaghg",Password="wE3\"/&#y"         , ClientId = 17},
             new(){ Id=18,Login="bhedgesh",Password="cU4>7atC"           , ClientId = 18},
             new(){ Id=19,Login="nrudgleyi",Password="pR4.iZP("          , ClientId = 19},
             new(){ Id=20,Login="afairheadj",Password="kB6/67pf>W"       , ClientId = 20},
             new(){ Id=21,Login="hoadesk",Password="oI2&}ef1mqU34"       , ClientId = 21},
             new(){ Id=22,Login="rstallebrassl",Password="hZ5,Yf,rz"     , ClientId = 22},
             new(){ Id=23,Login="awyrillm",Password="xX0,Ru\\7Y4}p"      , ClientId = 23},
             new(){ Id=24,Login="akeelann",Password="eW6</U#iLO,TN"      , ClientId = 24},
             new(){ Id=25,Login="cstainingo",Password="hE2!'__y"         , ClientId = 25},
             new(){ Id=26,Login="ecellonep",Password="iW7<xQC/q"         , ClientId = 26},
             new(){ Id=27,Login="shyettq",Password="eL9+s}w.t1jSqnew DateTime.Now,"      , ClientId = 27},
             new(){ Id=28,Login="hpettegrer",Password="rW0=bl?uE"        , ClientId = 28},
             new(){ Id=29,Login="dogborns",Password="uK0)QO5WWk8*{bew"   , ClientId = 29},
             new(){ Id=30,Login="lhurlestonet",Password="cE1?2}pcbq@"    , ClientId = 30},
             new(){ Id=31,Login="dmacgettigenu",Password="uR6\"cs@N=zQR" , ClientId = 31},
             new(){ Id=32,Login="rrodbournev",Password="aV6$hB.0%L"      , ClientId = 32},
             new(){ Id=33,Login="ctevelovw",Password="nL9+W<<Z.20ZO"     , ClientId = 33},
             new(){ Id=34,Login="rpavlishchevx",Password="xE8#P`j{cD(kyK", ClientId = 34},
             new(){ Id=35,Login="dchudleighy",Password="lO0}mMtx|Obnew DateTime.Now,w%"  , ClientId = 35},
             new(){ Id=36,Login="islopierz",Password="mC1\"wzv}l\"bctN"  , ClientId = 36},
             new(){ Id=37,Login="bmcquorkel10",Password="kY0#>4UI.{O#x5" , ClientId = 37},
             new(){ Id=38,Login="pbellows11",Password="aH0new DateTime.Now,uY7Y{xIkhohr" , ClientId = 38},
             new(){ Id=39,Login="agarrad12",Password="sE1*u4XM\\o2e"     , ClientId = 39},
             new(){ Id=40,Login="jwaberer13",Password="vG3'5Dgha3gY"     , ClientId = 40},
             new(){ Id=41,Login="gpond14",Password="uZ2&V?@,"            , ClientId = 41},
             new(){ Id=42,Login="jstanlake15",Password="kS5}}L9EU(s#$ad#", ClientId = 42},
             new(){ Id=43,Login="gchesters16",Password="zU1=?\"Ef>W{g8'0", ClientId = 43},
             new(){ Id=44,Login="cgillet17",Password="sM3<SZH7q{!JQLxp"  , ClientId = 44},
             new(){ Id=45,Login="tgrundey18",Password="fR8)&G6m",ClientId = 45},
             new(){ Id=46,Login="akann19",Password="gQ5)new DateTime.Now,new DateTime.Now,1'"            , ClientId = 46},
             new(){ Id=47,Login="fjapp1a",Password="oH7`8new DateTime.Now,G4"            , ClientId = 47},
             new(){ Id=48,Login="sgrishanov1b",Password="lP7._@uhP??"    , ClientId = 48},
             new(){ Id=49,Login="gogrowgane1c",Password="sN5new DateTime.Now,W?4!"       , ClientId = 49},
             new(){ Id=50,Login="msiemantel1d",Password="hF0{wzFa#0$<" , ClientId = 50}  
        };

        public static readonly Gender[] Genders =
        {
            new(){ Id=1,Name = "Male" },
            new(){ Id=2,Name = "Female" },
        };

        public static readonly PlaneType[] PlaneTypes =
         {
            new(){Id = 1, Type = "Passenger Jet" },
            new(){Id = 2, Type = "Turboprop" },
            new(){Id = 3, Type = "Regional Jet" },
            new(){Id = 4, Type = "Light Aircraft" },
            new(){Id = 5, Type = "Business Jet" }
        };

        public static readonly Client[] Clients =
         {
             new(){Id=1,Name="Ermin",Surname="Manuele",Email="emanuele0@ycombinator.com",GenderId=2,AccountId=1 },
             new(){Id=2,Name="Alyce",Surname="Haslock",Email="ahaslock1@wired.com",GenderId=2,AccountId=2  },
             new(){Id=3,Name="Carlye",Surname="Enefer",Email="cenefer2@state.tx.us",GenderId=1,AccountId=3  },
             new(){Id=4,Name="Thaddus",Surname="Lumsdaine",Email="tlumsdaine3@stanford.edu",GenderId=2,AccountId=4 },
             new(){Id=5,Name="Gillie",Surname="McGebenay",Email="gmcgebenay4@istockphoto.com",GenderId=1,AccountId=5},
             new(){Id=6,Name="Fidela",Surname="Hassent",Email="fhassent5@who.int",GenderId=2,AccountId=6},
             new(){Id=7,Name="Joel",Surname="Galland",Email="jgalland6@ucoz.ru",GenderId=1,AccountId=7 },
             new(){Id=8,Name="Filmore",Surname="Kann",Email="fkann7@linkedin.com",GenderId=1,AccountId=8 },
             new(){Id=9,Name="Carleen",Surname="Drew,Clifton",Email="cdrewclifton8@ftc.gov",GenderId=2,AccountId=9 },
             new(){Id=10,Name="Sofia",Surname="Kennet",Email="skennet9@cnet.com",GenderId=1,AccountId=10  },
             new(){Id=11,Name="Morlee",Surname="Lennox",Email="mlennoxa@163.com",GenderId=2,AccountId=11  },
             new(){Id=12,Name="Ogdon",Surname="Bougen",Email="obougenb@ezinearticles.com",GenderId=2,AccountId=12  },
             new(){Id=13,Name="Albina",Surname="Marjanovic",Email="amarjanovicc@imdb.com",GenderId=2,AccountId=13 },
             new(){Id=14,Name="Abagail",Surname="Tarling",Email="atarlingd@usatoday.com",GenderId=1,AccountId=14 },
             new(){Id=15,Name="Currie",Surname="Jess",Email="cjesse@ox.ac.uk",GenderId=2,AccountId=15 },
             new(){Id=16,Name="Modestine",Surname="Moyers",Email="mmoyersf@earthlink.net",GenderId=1,AccountId=16  },
             new(){Id=17,Name="Lionello",Surname="Iddy",Email="liddyg@unesco.org",GenderId=2,AccountId=17  },
             new(){Id=18,Name="Maje",Surname="Beslier",Email="mbeslierh@boston.com",GenderId=1,AccountId=18 },
             new(){Id=19,Name="Val",Surname="Dot",Email="vdoti@rambler.ru",GenderId=1,AccountId=19  },
             new(){Id=20,Name="Tedda",Surname="Kilian",Email="tkilianj@nationalgeographic.com",GenderId=1,AccountId=20 },
             new(){Id=21,Name="Meris",Surname="Warrilow",Email="mwarrilowk@tinypic.com",GenderId=1,AccountId=21 },
             new(){Id=22,Name="Mic",Surname="Thornebarrow",Email="mthornebarrowl@squarespace.com",GenderId=1,AccountId=22 },
             new(){Id=23,Name="Gilles",Surname="Deniso",Email="gdenisom@cbslocal.com",GenderId=1,AccountId=23   },
             new(){Id=24,Name="Paco",Surname="Buglar",Email="pbuglarn@geocities.com",GenderId=1,AccountId=24   },
             new(){Id=25,Name="Priscilla",Surname="Calley",Email="pcalleyo@tamu.edu",GenderId=2,AccountId=25 },
             new(){Id=26,Name="Demetria",Surname="Rives",Email="drivesp@lulu.com",GenderId=2,AccountId=26  },
             new(){Id=27,Name="Calvin",Surname="Gerran",Email="cgerranq@de.vu",GenderId=2,AccountId=27    },
             new(){Id=28,Name="Marty",Surname="Duchatel",Email="mduchatelr@constantcontact.com",GenderId=2,AccountId=28 },
             new(){Id=29,Name="Ronnie",Surname="Brahm",Email="rbrahms@bigcartel.com",GenderId=2,AccountId=29 },
             new(){Id=30,Name="Rees",Surname="Scholar",Email="rscholart@disqus.com",GenderId=1,AccountId=30  },
             new(){Id=31,Name="Giorgia",Surname="Pilgrim",Email="gpilgrimu@google.com.hk",GenderId=1,AccountId=31 },
             new(){Id=32,Name="Dieter",Surname="Chene",Email="dchenev@joomla.org",GenderId=1,AccountId=32 },
             new(){Id=33,Name="Artus",Surname="Hartford",Email="ahartfordw@163.com",GenderId=1,AccountId=33 },
             new(){Id=34,Name="Lukas",Surname="Nekrews",Email="lnekrewsx@aol.com",GenderId=2,AccountId=34  },
             new(){Id=35,Name="Kaela",Surname="Tebb",Email="ktebby@google.ca",GenderId=1,AccountId=35  },
             new(){Id=36,Name="Elga",Surname="Golagley",Email="egolagleyz@wsj.com",GenderId=2,AccountId=36  },
             new(){Id=37,Name="Alwyn",Surname="Ivens",Email="aivens10@ning.com",GenderId=1,AccountId=37  },
             new(){Id=38,Name="Chelsy",Surname="Paulitschke",Email="cpaulitschke11@adobe.com",GenderId=2,AccountId=38 },
             new(){Id=39,Name="Barbaraanne",Surname="Franzolini",Email="bfranzolini12@goodreads.com",GenderId=1,AccountId=39 },
             new(){Id=40,Name="Amandy",Surname="Tapscott",Email="atapscott13@rambler.ru",GenderId=2,AccountId=40 },
             new(){Id=41,Name="Tedmund",Surname="Sheldrick",Email="tsheldrick14@bbc.co.uk",GenderId=2,AccountId=41 },
             new(){Id=42,Name="Randy",Surname="Wood",Email="rwood15@princeton.edu",GenderId=2,AccountId=42  },
             new(){Id=43,Name="Lurlene",Surname="Sadgrove",Email="lsadgrove16@bloglines.com",GenderId=1,AccountId=43},
             new(){Id=44,Name="Lizabeth",Surname="Schwerin",Email="lschwerin17@123,reg.co.uk",GenderId=1,AccountId=44 },
             new(){Id=45,Name="Johanna",Surname="Luther",Email="jluther18@soundcloud.com",GenderId=2,AccountId=45  },
             new(){Id=46,Name="Nick",Surname="Denmead",Email="ndenmead19@ifeng.com",GenderId=2,AccountId=46   },
             new(){Id=47,Name="Rollins",Surname="Gionettitti",Email="rgionettitti1a@ustream.tv",GenderId=2,AccountId=47 },
             new(){Id=48,Name="Isak",Surname="Drioli",Email="idrioli1b@yale.edu",GenderId=2,AccountId=48 },
             new(){Id=49,Name="Casey",Surname="Pridding",Email="cpridding1c@npr.org",GenderId=2,AccountId=49 },
             new(){Id=50,Name="Gabie",Surname="Foyston",Email="gfoyston1d@networksolutions.com",GenderId=2,AccountId=50 },
        };

        public static readonly Plane[] Planes =
         {
             new(){Id=1,Model="Piper PA,28",PlaneTypeId=4,CountryId=1,PassengersCount=34 },
             new(){Id=2,Model="Embraer E,Jet",PlaneTypeId=3,CountryId=2,PassengersCount=92 },
             new(){Id=3,Model="Airbus A380",PlaneTypeId=1,CountryId=3,PassengersCount=36  },
             new(){Id=4,Model="ATR 72",PlaneTypeId=2,CountryId=1,PassengersCount=39  },
             new(){Id=5,Model="Boeing 747",PlaneTypeId=1,CountryId=2,PassengersCount=24  },
             new(){Id=6,Model="Cessna 172",PlaneTypeId=4,CountryId=3,PassengersCount=78   },
             new(){Id=7,Model="Bombardier Dash 8",PlaneTypeId=2,CountryId=1,PassengersCount=99 },
             new(){Id=8,Model="Bombardier Global 6000",PlaneTypeId=5,CountryId=2,PassengersCount=56 },
             new(){Id=9,Model="Bombardier CRJ Series",PlaneTypeId=3,CountryId=3,PassengersCount=69 },
             new(){Id=10,Model="Gulfstream G650",PlaneTypeId=5,CountryId=1,PassengersCount=15 }
        };

        private static List<Flight> GetFlights(int count)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            List<Flight> flights = new();
            DateTime tmpDate = DateTime.Now;
            Random rnd = new();
            char[] tmpChars = new char[2];
            for (int i = 1; i < count; i++)
            {
                tmpChars[0] = chars[rnd.Next(0, 26)];
                tmpChars[1] = chars[rnd.Next(0, 26)];
                tmpDate = tmpDate.AddMinutes(10);
                Flight tmpFlight = new()
                {
                    Id = i,
                    Arrival = tmpDate,
                    Departure = tmpDate.AddHours(rnd.Next(1, 4)),
                    Number = new string(tmpChars) + " " + rnd.Next(1000, 10000),
                    PlaneId = rnd.Next(1, 11),
                    ArrivalCityId = rnd.Next(1, 10),
                    DepartureCityId = rnd.Next(1, 10)
                    
                };
                flights.Add(tmpFlight);
            }

            return flights;
        }
    }
    }
    
