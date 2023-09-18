using Microsoft.AspNetCore.Mvc.RazorPages;
using studentnamebyId.model;
using System.Xml.Linq;

namespace studentnamebyId.bl
{
    public class studentdetails
    {
        public student GetStudent(int id)
        {
            student model = new student();
            if (id ==1) {


                model.Id = 1;
                model.Age = 1;
                model.Batch = "s";
                model.ClassRoom = 1;
                model.ClassTeacher = "ram";
                model.Name = "adarsh nayak";
                return model;
            };
            if (id == 2)
            {


                model.Id = 1;
                model.Age = 1;
                model.Batch = "s";
                model.ClassRoom = 1;
                model.ClassTeacher = "ram";
                model.Name = "adarsh nayak";
                return model;
            };
            if (id == 3)
            {


                model.Id = 1;
                model.Age = 1;
                model.Batch = "s";
                model.ClassRoom = 1;
                model.ClassTeacher = "ram";
                model.Name = "adarsh nayak";
                return model;
            };
            return model;
        }
    }
}
