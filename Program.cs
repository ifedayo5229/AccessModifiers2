using System;

namespace Access
{
    class Program
    {
        static void Main(string[] args)
        {
            OffCampusStudent student = new OffCampusStudent( );
            AllStudent student1=new AllStudent();

            // student.name = "ife";  // public access
            
            student.studentDetails();
            student1.GetHostelPassCode= 1234;
            var hostelpass = student1.GetHostelPassCode;
            Console.WriteLine("My Hostel PassCode : " + hostelpass);
           

        
            Console.WriteLine("Welcome!");
        }
    }

    public class AllStudent
    {
        public string name;
        protected  string dept;
        private int HostelPassCode ;

        
        // private access
        public int GetHostelPassCode
        {
            get{
           return HostelPassCode;
            }
            set{
                HostelPassCode= value;
            }
              
        }
    }


 // protected access and public access
    public class OffCampusStudent : AllStudent

    {
      public void studentDetails()
      {

          this.dept = " Crop Protection";
          this.name = "Ifedayo Ademodi";
          Console.WriteLine("Student Name : " + name + "\nDept Name : " + dept);

          
       
        //    Console.WriteLine("\nPress Enter  to view Hostel passcode: ..");
        //    Console.ReadLine();
      }
    }

    
}
