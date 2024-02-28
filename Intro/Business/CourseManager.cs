using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concreates;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    // dependency injection                 // Loosely coupled
    private readonly ICourseDal _courseDal; // bir business veri erişiminin sadece soyutlarından çalışabilir

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        // business rules
        
        
        return _courseDal.GetAll();
    }
}
