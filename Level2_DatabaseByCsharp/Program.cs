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
            //var deptSet = db.Departments;
            var traineeSet = db.Trainees;
            //var traineeCSESet = traineeSet.Where(x=>x.DeptId=="3"); //var and Iqueryble both work
            IQueryable<Trainee> traineeCSESet = traineeSet.Where(x => x.DeptId == "3");
            //List<Department> deptList = deptSet.ToList();
            List<Trainee> traineeList = traineeCSESet.ToList();

            foreach (Trainee dIndex in traineeList)
            {
                Console.WriteLine(dIndex.Name);
            }
            Console.Read();
        }
    }
}
