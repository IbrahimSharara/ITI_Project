﻿using El_Tamayez.Models;

namespace Graduation_Project.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAllPosts();
        int DeleteStudent(int id);
        int Insert(Student student);
    }
}
