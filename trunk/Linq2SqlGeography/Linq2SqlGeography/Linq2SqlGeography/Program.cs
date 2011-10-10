﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Linq2SqlGeography;
using Microsoft.SqlServer.Types;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Linq2SqlGeography
{

    class Program
    {
        static void Main(string[] args)
        {
            DisplayLiJiaoSite();
            Console.ReadKey();
        }

        private static void DisplayLiJiaoSite()
        {
            DataClasses2DataContext dc = new DataClasses2DataContext();
            List<LiJiaoSite> lijiaosites = new List<LiJiaoSite>();
            Console.WriteLine(dc.MCOMSITE.Count());

            foreach (var site in dc.MCOMSITE)
            {
                if (site.SP_GEOMETRY != null)
                {
                    //SqlGeometry ->SqlGeography
                    var sp = SqlGeography.Point((double)site.Latitude, (double)site.Longitude, 4326);
                    var sitebuffer = sp.STBuffer(5000);   //类型转换以后没有问题，单位是米
                    foreach (var lj in dc.立交ABC)
                    {
                        if (lj.SP_GEOMETRY != null)
                        {
                            //SqlGeometry ->SqlGeography
                            var ljp = SqlGeography.STGeomFromWKB(lj.SP_GEOMETRY.STAsBinary(), 4326);
                            if (ljp.STIntersects(sitebuffer))
                            {
                                LiJiaoSite lijiaosite = new LiJiaoSite();
                                lijiaosite.lj = lj;
                                lijiaosite.site = site;
                                lijiaosites.Add(lijiaosite);
                            }
                        }
                    }

                    Console.WriteLine(lijiaosites.Count());
                    WriteConsoleLine(lijiaosites);
                }
            }
            Console.WriteLine(lijiaosites.Count());
            WriteConsoleLine(lijiaosites);



        }
        private static void WriteConsoleLine(List<LiJiaoSite> lijiaosites)
        {
            foreach (var m in lijiaosites)
                if (m != null)
                    Console.WriteLine("{0},,,,,{1},,,,{2}",
                        m.lj.高架桥ID,
                        m.lj.名称,
                        m.site.SiteName
                        );
        }
    }
}
