

/* NGENE UGOCHUKWU */

// 1
var result = Courses.Count();
result.Dump();

// 2
var students =  Persons.Where (p => (p.Discriminator == "Student")).Count();
students.Dump();

// 3
var studentInfo = (from p in Persons
				   where p.Discriminator == "Student"
                   join e in Enrollments on p.ID equals e.StudentID join c in Courses on e.CourseID equals c.CourseID
                   select new{p.LastName, p.FirstName, p.EnrollmentDate, c.Title}
				   );
studentInfo.Dump();

// 4 
var studentsAscending = Persons.OrderBy(p=>p.FirstName).Take(100);
studentsAscending.Dump();

// 5 
var studentsDescending = Persons.OrderByDescending(p=>p.LastName).Take(100);
studentsDescending.Dump();

// 6
var studentInfo2 = from c in Courses
					join e in Enrollments on c.CourseID equals e.CourseID join p in Persons on e.StudentID equals p.ID into ps
				   from p in ps.DefaultIfEmpty()
				   where p == null
                   select new{Title = c.Title, p.LastName, p.FirstName, p.EnrollmentDate};
				  
studentInfo2.Dump();


// 7 
void Pagination(int pageSize = 5, int pageNumber = 1){
	var pCollection = Persons.Skip( pageSize*(pageNumber-1)).Take(pageSize).Select(x=>new{x.LastName, x.FirstName, x.EnrollmentDate, x.Discriminator}).Where(x=>(x.Discriminator == "Student"));
	pCollection.Dump();
}

Pagination(5,1);
Pagination(5,2);

// 8 
var InstructorAssignment = (from p in Persons
				   where p.Discriminator == "Instructor"
                   join of in OfficeAssignments on p.ID equals of.InstructorID 
                   select new{p.LastName, p.FirstName, p.HireDate, AssignmentDetails = of}
				   );
InstructorAssignment.Dump();

// 9
var InstructorNulls = (from p in Persons
				   where p.Discriminator == "Instructor"
                   join of in OfficeAssignments on p.ID equals of.InstructorID into ps
				   from of in ps.DefaultIfEmpty()
				   where of == null
                   select new{p.LastName, p.FirstName, p.HireDate, AssignmentDetails = of}
				   );
InstructorNulls.Dump();

// 10
var departmentInstructor = (from d in Departments
                   			join p in Persons on d.InstructorID equals p.ID
		                    select new{ Department = d.Name , FullName = p.LastName +' '+ p.FirstName}
						    );
departmentInstructor.Dump();

// 11
var departmentOverBudget = Departments.Where (d => d.Budget > 100000);
departmentOverBudget.Dump();
