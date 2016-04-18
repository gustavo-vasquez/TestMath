using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;

namespace Capa_Servicios
{
    public class StudentServices
    {
        private SchoolContext context = new SchoolContext();
        
        public List<Student> GetStudents()
        {
            var students = context.Students.ToList();
            return students;
        }

        public void AddNewStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }
    }
}
