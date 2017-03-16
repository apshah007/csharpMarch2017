namespace example_from_class
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class StudentContext : DbContext
    {
        // Your context has been configured to use a 'StudentContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'example_from_class.StudentContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StudentContext' 
        // connection string in the application configuration file.
        //constructor method for class
        public StudentContext() : base("name=StudentDb")
        {
            //code that I put here will run before the base constructor runs
            //StudentContext class inherits from DbContext 
            //run this code and then run the base constructor
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Student> Students { get; set; }

         public virtual DbSet<Course> Courses { get; set; }

         public virtual DbSet<Teacher> Teachers { get; set; }

         public virtual DbSet<CourseStudent> CourseStudents { get; set; }
    }

   public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
    }

    public class CourseStudent
    {
        [Key, Column(Order =0)]
        public int CourseId { get; set; }

        [Key, Column(Order =1)]
        public int StudentId { get; set; }

        public string Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }


    }

    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
       
    }


}