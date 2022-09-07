using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMySchoolConnectionDB
{
    internal class Program
    {

        static string connectionString =
         @"Server = LAPTOP-E7175F56\SQLEXPRESS;Database = MySchool; Trusted_Connection = True;";

        static SqlConnection sqlConnection = new SqlConnection(connectionString);
        
          

            static void Main(string[] args)
            {
                using (sqlConnection)
                {
                    try
                    {
                        sqlConnection.Open();
                    #region Insert data Assignment
                    //Insert Assignment Id , Title, Description
                    Console.WriteLine("Please insert Assignemnt's Id: ");
                    int idAssignment = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please insert Assignemnt's Title: ");
                    string title = Console.ReadLine();
                    Console.WriteLine("Please insert Assignemnt's Description: ");
                    string description = Console.ReadLine();


                    SqlCommand cmdInsert =
                    new SqlCommand($"INSERT INTO Assignment(Title, Description, AssignmentId ) VALUES('{title}', '{description}', '{idAssignment}')", sqlConnection);

                    int insertedRows = cmdInsert.ExecuteNonQuery();
                    if (insertedRows > 0)
                    {
                        Console.WriteLine(" Assignemnt table: Rows affected successfully");
                        Console.WriteLine($"{insertedRows} affected");
                    }
                    #endregion

                    #region Insert data Course
                    //Insert Id Course, Title, Stream, Type, Startdate, Enddate
                    Console.WriteLine("Please insert Course's Id");
                    int courseId = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please insert Course's Title");
                    string courseTitle = Console.ReadLine();
                    Console.WriteLine("Please insert Course' Type");
                    string courseType = Console.ReadLine();
                    Console.WriteLine("Please insert Course' Stream");
                    string courseStream = Console.ReadLine();
                    //Console.WriteLine("Please insert Course's StartDate in date format y-m-d");

                    //DateTime courseStartDate = new DateTime();
                    SqlCommand cmdInsertCourse = new SqlCommand($"INSERT INTO Courses(CourseId, Title, Type, Stream ) VALUES('{courseId}', '{courseTitle}', '{courseType}', '{courseStream}')", sqlConnection);
                    int insertedCourseRows = cmdInsertCourse.ExecuteNonQuery();
                    if (insertedCourseRows > 0)
                    {
                        Console.WriteLine(" Course table: Rows affected successfully");
                        Console.WriteLine($"Course Rows affected {insertedCourseRows}");
                    }
                    #endregion

                    #region Insert data Student
                    //    //Insert StudentId, First_name , Last_Name, Fees
                    Console.WriteLine("Please insert Student's Id");
                    int studentId = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please insert First Name");
                    string studentFirstName = Console.ReadLine();
                    Console.WriteLine("Please insert Last Name");
                    string studentLastName = Console.ReadLine();
                    Console.WriteLine("Please insert Fee");
                    string studentFee = Console.ReadLine();

                    SqlCommand cmdInsertStudent = new SqlCommand($"INSERT INTO Students( StudentId, First_Name, Last_Name, Fees) VALUES('{studentId}', '{studentFirstName}', '{studentLastName}, {studentFee}')", sqlConnection);
                    int insertedStudentRows = cmdInsertStudent.ExecuteNonQuery();

                    if (insertedStudentRows > 0)
                    {
                        Console.WriteLine(" Students table: Rows affected successfully");
                        Console.WriteLine($"Course Rows affected {insertedStudentRows}");
                    }
                    #endregion

                    #region Insert data trainer
                    //Insert TrainerId, First_name , Last_Name
                    Console.WriteLine("Please insert Trainer's Id");
                    int trainerId = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please insert First Name");
                    string trainerFirstName = Console.ReadLine();
                    Console.WriteLine("Please insert Last Name");
                    string trainerLastName = Console.ReadLine();


                    SqlCommand cmdInsertTrainer = new SqlCommand($"INSERT INTO Trainers( TrainerId, First_Name, Last_Name) VALUES('{trainerId}', '{trainerFirstName}', '{trainerLastName}')", sqlConnection);
                    int insertedTrainerRows = cmdInsertTrainer.ExecuteNonQuery();

                    if (insertedTrainerRows > 0)
                    {
                        Console.WriteLine(" Trainer table: Rows affected successfully");
                        Console.WriteLine($"Course Rows affected {insertedTrainerRows}");
                    }
                    #endregion








                    //SELECT ASSIGNMENT
                    //SqlCommand cmdSelectAssignment =
                    //    new SqlCommand("SELECT FROM Assignment(Title) ", sqlConnection) ;

                    //cmdSelectAssignment.Parameters.;




                }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }

            }



        
    }
}
