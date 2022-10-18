using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Data
{
    public class SchoolManagementSystemDbContext : DbContext
    {
        public SchoolManagementSystemDbContext(DbContextOptions<SchoolManagementSystemDbContext> options) : base(options)
        { }


        public DbSet<Gender> Genders { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Classs> Classses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Markk> Markks { get; set; }
        public DbSet<Userr> Userrs { get; set; }
        public DbSet<Rolee> Rolees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>().HasData(

                                                     new Gender { GenderId = 1, GenderName = "Male" },
                                                     new Gender { GenderId = 2, GenderName = "Female" },
                                                     new Gender { GenderId = 3, GenderName = "Couldn't find" }, 
                                                     new Gender { GenderId = 19, GenderName = "Agender" },
                                                     new Gender { GenderId = 4, GenderName = "Transsexual" },
                                                     new Gender { GenderId = 5, GenderName = "Intersex" },
                                                     new Gender { GenderId = 6, GenderName = "Non-Conforming" },
                                                     new Gender { GenderId = 7, GenderName = "Bigender" },
                                                     new Gender { GenderId = 8, GenderName = "Butch" },
                                                     new Gender { GenderId = 9, GenderName = "Cisgender" },
                                                     new Gender { GenderId = 10, GenderName = "Gender expansive" },
                                                     new Gender { GenderId = 11, GenderName = "Genderfluid" },
                                                     new Gender { GenderId = 12, GenderName = "Gender Outlaw" },
                                                     new Gender { GenderId = 13, GenderName = "Genderqueer" },
                                                     new Gender { GenderId = 14, GenderName = "Masculine of center" },
                                                     new Gender { GenderId = 15, GenderName = "Nonbinary" },
                                                     new Gender { GenderId = 16, GenderName = "Omnigender" },
                                                     new Gender { GenderId = 17, GenderName = "Polygender" },
                                                     new Gender { GenderId = 18, GenderName = "Two Spirit" }


                                                    );

            modelBuilder.Entity<Classs>().HasData(

                                                     new Classs { ClasssId = 1, ClasssName = "A" },
                                                     new Classs { ClasssId = 2, ClasssName = "B" },
                                                     new Classs { ClasssId = 3, ClasssName = "C" },
                                                     new Classs { ClasssId = 4, ClasssName = "D" },
                                                     new Classs { ClasssId = 5, ClasssName = "E" }



                                                );

            modelBuilder.Entity<Student>().HasData(

                                                     new Student { HumanId = 1, FirstandSecondName = "Maryse Deanna", Lastname = "Hoedemaeker", DOB = Convert.ToDateTime("6/12/2001"), ClasssId = 1, Email = "marysedenna@gmail.com", PhoneNumber = "0543-432-12-45", GenderId = 2, Address = "Deneme sokağı 14", JoinDate = Convert.ToDateTime("6/10/2016")},
                                                     new Student { HumanId = 2, FirstandSecondName = "Maryse Deanna", Lastname = "Hoedemaeker", DOB = Convert.ToDateTime("6/12/2001"), ClasssId = 1, Email = "marysedenna@gmail.com", PhoneNumber = "0543-432-12-45", GenderId = 1, Address = "Deneme sokağı 14", JoinDate = Convert.ToDateTime("6/10/2016")},
                                                     new Student { HumanId = 3, FirstandSecondName = "Maryse Deanna", Lastname = "Hoedemaeker", DOB = Convert.ToDateTime("6/12/2001"), ClasssId = 1, Email = "marysedenna@gmail.com", PhoneNumber = "0543-432-12-45", GenderId = 4, Address = "Deneme sokağı 14", JoinDate = Convert.ToDateTime("6/10/2016")},
                                                     new Student { HumanId = 4, FirstandSecondName = "Maryse Deanna", Lastname = "Hoedemaeker", DOB = Convert.ToDateTime("6/12/2001"), ClasssId = 1, Email = "marysedenna@gmail.com", PhoneNumber = "0543-432-12-45", GenderId = 3, Address = "Deneme sokağı 14", JoinDate = Convert.ToDateTime("6/10/2016")},
                                                     new Student { HumanId = 5, FirstandSecondName = "Maryse Deanna", Lastname = "Hoedemaeker", DOB = Convert.ToDateTime("6/12/2001"), ClasssId = 1, Email = "marysedenna@gmail.com", PhoneNumber = "0543-432-12-45", GenderId = 2, Address = "Deneme sokağı 14", JoinDate = Convert.ToDateTime("6/10/2016")},
                                                     new Student { HumanId = 6, FirstandSecondName = "Maryse Deanna", Lastname = "Hoedemaeker", DOB = Convert.ToDateTime("6/12/2001"), ClasssId = 1, Email = "marysedenna@gmail.com", PhoneNumber = "0543-432-12-45", GenderId = 5, Address = "Deneme sokağı 14", JoinDate = Convert.ToDateTime("6/10/2016")},
                                                     new Student { HumanId = 7, FirstandSecondName = "Maryse Deanna", Lastname = "Hoedemaeker", DOB = Convert.ToDateTime("6/12/2001"), ClasssId = 1, Email = "marysedenna@gmail.com", PhoneNumber = "0543-432-12-45", GenderId = 5, Address = "Deneme sokağı 14", JoinDate = Convert.ToDateTime("6/10/2016")},
                                                     new Student { HumanId = 8, FirstandSecondName = "Maryse Deanna", Lastname = "Hoedemaeker", DOB = Convert.ToDateTime("6/12/2001"), ClasssId = 1, Email = "marysedenna@gmail.com", PhoneNumber = "0543-432-12-45", GenderId = 6, Address = "Deneme sokağı 14", JoinDate = Convert.ToDateTime("6/10/2016")},
                                                     new Student { HumanId = 9, FirstandSecondName = "Maryse Deanna", Lastname = "Hoedemaeker", DOB = Convert.ToDateTime("6/12/2001"), ClasssId = 1, Email = "marysedenna@gmail.com", PhoneNumber = "0543-432-12-45", GenderId = 9, Address = "Deneme sokağı 14", JoinDate = Convert.ToDateTime("6/10/2016")},
                                                     new Student { HumanId = 10, FirstandSecondName = "Maryse Deanna", Lastname = "Hoedemaeker", DOB = Convert.ToDateTime("6/12/2001"), ClasssId = 1, Email = "marysedenna@gmail.com", PhoneNumber = "0543-432-12-45", GenderId = 7, Address = "Deneme sokağı 14", JoinDate = Convert.ToDateTime("6/10/2016")},
                                                     new Student { HumanId = 11, FirstandSecondName = "Maryse Deanna", Lastname = "Hoedemaeker", DOB = Convert.ToDateTime("6/12/2001"), ClasssId = 1, Email = "marysedenna@gmail.com", PhoneNumber = "0543-432-12-45", GenderId = 10, Address = "Deneme sokağı 14", JoinDate = Convert.ToDateTime("6/10/2016")},
                                                     new Student { HumanId = 12, FirstandSecondName = "Maryse Deanna", Lastname = "Hoedemaeker", DOB = Convert.ToDateTime("6/12/2001"), ClasssId = 1, Email = "marysedenna@gmail.com", PhoneNumber = "0543-432-12-45", GenderId = 8, Address = "Deneme sokağı 14", JoinDate = Convert.ToDateTime("6/10/2016") ,},
                                                     new Student { HumanId = 13, FirstandSecondName = "Maryse Deanna", Lastname = "Hoedemaeker", DOB = Convert.ToDateTime("6/12/2001"), ClasssId = 1, Email = "marysedenna@gmail.com", PhoneNumber = "0543-432-12-45", GenderId = 5, Address = "Deneme sokağı 14", JoinDate = Convert.ToDateTime("6/10/2016") , }



                                                      );


            modelBuilder.Entity<Parentt>().HasData(

                                                     new Parentt { HumanId = 1, StudentId = 1, GenderId = 1, FirstandSecondName = "Augna Luna", Lastname = "Deanna1", DOB = Convert.ToDateTime("2/8/1964"), Address = "Deneme sokağı 14" },
                                                     new Parentt { HumanId = 2, StudentId = 2, GenderId = 2, FirstandSecondName = "Augna Huna", Lastname = "Deanna2", DOB = Convert.ToDateTime("10/2/1960"), Address = "Deneme sokağı 14" },
                                                     new Parentt { HumanId = 3, StudentId = 3, GenderId = 2, FirstandSecondName = "Augna Beina", Lastname = "Deanna3", DOB = Convert.ToDateTime("7/9/1964"), Address = "Deneme sokağı 14" },
                                                     new Parentt { HumanId = 4, StudentId = 4, GenderId = 2, FirstandSecondName = "Augna Layna", Lastname = "Deanna4", DOB = Convert.ToDateTime("3/1/1966"), Address = "Deneme sokağı 14" },
                                                     new Parentt { HumanId = 5, StudentId = 5, GenderId = 1, FirstandSecondName = "Augna Abuen", Lastname = "Deanna5", DOB = Convert.ToDateTime("4/5/1968"), Address = "Deneme sokağı 14" },
                                                     new Parentt { HumanId = 6, StudentId = 6, GenderId = 1, FirstandSecondName = "Augna Linu", Lastname = "Deanna6", DOB = Convert.ToDateTime("7/6/1970"), Address = "Deneme sokağı 14" },
                                                     new Parentt { HumanId = 7, StudentId = 7, GenderId = 2, FirstandSecondName = "Augna Ohan", Lastname = "Deanna7", DOB = Convert.ToDateTime("8/9/1971"), Address = "Deneme sokağı 14" },
                                                     new Parentt { HumanId = 8, StudentId = 8, GenderId = 2, FirstandSecondName = "Augna Michele", Lastname = "Deanna8", DOB = Convert.ToDateTime("11/10/1959"), Address = "Deneme sokağı 14" },
                                                     new Parentt { HumanId = 9, StudentId = 9, GenderId = 1, FirstandSecondName = "Augna Larn", Lastname = "Deanna9", DOB = Convert.ToDateTime("6/12/1957"), Address = "Deneme sokağı 14" },
                                                     new Parentt { HumanId = 10, StudentId = 10, GenderId = 1, FirstandSecondName = "Augna Cubert", Lastname = "Deanna10", DOB = Convert.ToDateTime("3/18/1980"), Address = "Deneme sokağı 14" },
                                                     new Parentt { HumanId = 11, StudentId = 11, GenderId = 1, FirstandSecondName = "Augna Ignis", Lastname = "Deanna11", DOB = Convert.ToDateTime("4/24/1978"), Address = "Deneme sokağı 14" }
                                                     );
            modelBuilder.Entity<Teacher>().HasData(

                                                     new Teacher { HumanId = 1, FirstandSecondName = "Leila Hun", Lastname = "Clock", DOB = Convert.ToDateTime("9/10/1986"), ClasssId = 1, Email = "Leilahunclock@gmail.com", PhoneNumber = "0543-234-12-45", GenderId = 1, JoinDate = Convert.ToDateTime("04/12/2006"), Address = "Some random stree 16" },
                                                     new Teacher { HumanId = 2, FirstandSecondName = "Leila Hun", Lastname = "Clock", DOB = Convert.ToDateTime("9/10/1986"), ClasssId = 2, Email = "Leilahunclock@gmail.com", PhoneNumber = "0543-234-12-45", GenderId = 2, JoinDate = Convert.ToDateTime("04/12/2006"), Address = "Some random stree 16" },
                                                     new Teacher { HumanId = 3, FirstandSecondName = "Leila Hun", Lastname = "Clock", DOB = Convert.ToDateTime("9/10/1986"), ClasssId = 3, Email = "Leilahunclock@gmail.com", PhoneNumber = "0543-234-12-45", GenderId = 1, JoinDate = Convert.ToDateTime("04/12/2006"), Address = "Some random stree 16" },
                                                     new Teacher { HumanId = 4, FirstandSecondName = "Leila Hun", Lastname = "Clock", DOB = Convert.ToDateTime("9/10/1986"), ClasssId = 4, Email = "Leilahunclock@gmail.com", PhoneNumber = "0543-234-12-45", GenderId = 2, JoinDate = Convert.ToDateTime("04/12/2006"), Address = "Some random stree 16" },
                                                     new Teacher { HumanId = 5, FirstandSecondName = "Leila Hun", Lastname = "Clock", DOB = Convert.ToDateTime("9/10/1986"), ClasssId = 2, Email = "Leilahunclock@gmail.com", PhoneNumber = "0543-234-12-45", GenderId = 1, JoinDate = Convert.ToDateTime("04/12/2006"), Address = "Some random stree 16" },
                                                     new Teacher { HumanId = 6, FirstandSecondName = "Leila Hun", Lastname = "Clock", DOB = Convert.ToDateTime("9/10/1986"), ClasssId = 2, Email = "Leilahunclock@gmail.com", PhoneNumber = "0543-234-12-45", GenderId = 2, JoinDate = Convert.ToDateTime("04/12/2006"), Address = "Some random stree 16" },
                                                     new Teacher { HumanId = 7, FirstandSecondName = "Leila Hun", Lastname = "Clock", DOB = Convert.ToDateTime("9/10/1986"), ClasssId = 5, Email = "Leilahunclock@gmail.com", PhoneNumber = "0543-234-12-45", GenderId = 1, JoinDate = Convert.ToDateTime("04/12/2006"), Address = "Some random stree 16" },
                                                     new Teacher { HumanId = 8, FirstandSecondName = "Leila Hun", Lastname = "Clock", DOB = Convert.ToDateTime("9/10/1986"), ClasssId = 5, Email = "Leilahunclock@gmail.com", PhoneNumber = "0543-234-12-45", GenderId = 1, JoinDate = Convert.ToDateTime("04/12/2006"), Address = "Some random stree 16" }

                                                     );

            modelBuilder.Entity<Rolee>().HasData(

              new Rolee { RoleeID = 1, RoleeName = "Candidate" },
              new Rolee { RoleeID = 2, RoleeName = "Student" },
              new Rolee { RoleeID = 3, RoleeName = "Teacher" },
              new Rolee { RoleeID = 4, RoleeName = "Admin" }
              );

            modelBuilder.Entity<Userr>().HasData(

                new Userr { UserrID = 1, Emaill = "candidate@hotmail.com", Passwordd = "123456", RoleeID = 1 },
                new Userr { UserrID = 2, Emaill = "student@hotmail.com", Passwordd = "123456", RoleeID = 2 },
                new Userr { UserrID = 3, Emaill = "teacher@hotmail.com", Passwordd = "123456", RoleeID = 3 },
                new Userr { UserrID = 4, Emaill = "admin@hotmail.com", Passwordd = "123456", RoleeID = 4 },
                new Userr { UserrID = 5, Emaill = "user2@hotmail.com", Passwordd = "123456", RoleeID = 2 }
                );



        }
    }
}

