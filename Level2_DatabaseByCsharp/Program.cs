using System;
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
            var deptSet = db.Departments;

            DateTime date = new DateTime(1964, 1, 1);
            IQueryable<Department> deptBirth = deptSet.Where(x => x.EntryAt > date);

            List<Department> deptList = deptBirth.ToList();

            //var traineeSet = db.Trainees;
            //var traineeCSESet = traineeSet.Where(x=>x.DeptId=="3"); //var and Iqueryble both work
            //IQueryable<Trainee> traineeCSESet = traineeSet.Where(x => x.DeptId == "3");

            var v = 3;
            var dbSet = db.Enrollments;
            //IQueryable<Enrollment> enrollSet = dbSet.Where(x => x.CourseID > v);
            //IQueryable<Enrollment> enrollSet = dbSet.OrderBy(x => x.TraineeID);
            //List<Enrollment> enrollList = enrollSet.ToList();


            foreach (Department dIndex in deptList)
            {
                Console.WriteLine(dIndex.Id);
            }
            Console.Read();
        }
    }
}
