﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2_DatabaseByCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //tasks in brief
            //connect app to the server's database
            //fetch data from server's database
            //display data on the console display

            VirtualTraineesDBEntities db = new VirtualTraineesDBEntities();

            List<Department> deptList = db.Departments.ToList();

            foreach(Department dIndex in deptList)
            {
                Console.WriteLine(dIndex.Name);
            }
            Console.Read();
        }
    }
}
