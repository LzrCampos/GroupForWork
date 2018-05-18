using System.Collections.Generic;
using SharedLayer.Entities;

namespace DomainLayer.Entities
{
    public class StudentsGroup : entity
    {
        private List<Student> _students;

        public StudentsGroup(string tag, int limitStudent)
        {
            Tag = tag;
            LimitStudent = limitStudent;
            _students = new List<Student>();
        }

        public string Tag { get; private set; }
        public int LimitStudent { get; private set; }
        public IReadOnlyCollection<Student> Students => _students.ToArray();
        

        public string AddStudent(Student student)
        {
            if (checkedLimit())
            {
                _students.Add(student);
                return "Estudante adicionado ao grupo!";
            }
            return "Grupo já atingiu o limite de estudantes!";
        }

        public bool checkedLimit()
        {
            if (Students.Count < LimitStudent)
            {
                return true;
            }
            return false;
        }
    }
}