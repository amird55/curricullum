using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requests;

public class Requests
{
    private string r_teahcer_id { get; set; }
    private string r_teahcer_name { get; set; }
    private int[,] r_avilable_days { get; set; }

    private List<string> r_courses { get; set; }

    public Requests(Teacher teacher)
    {
        this.r_teahcer_id = teacher.getID();
        this.r_teahcer_name = teacher.GetName();
        this.r_avilable_days = teacher.getDays().getScedual();
        this.r_courses = new List<string>();
        foreach (var course in teacher.getCourses())
        {
            r_courses.Add(course.getName());
        }
    }
    public void Print()
    {
        Console.WriteLine(r_teahcer_name);
        Console.WriteLine(r_teahcer_id);
        Console.WriteLine(r_avilable_days.ToString());
        foreach(var course in r_courses)
        {
            Console.Write(" " + course);
        }
    }

    public void Export()
    {
        JArray days = new JArray(r_avilable_days);
        JArray course = new JArray(r_courses);
        JObject json = new JObject();
        json["Teacher-name"] = r_teahcer_name;
        json["Teacher-id"] = r_teahcer_id;
        json["AvailableDays"] = days;
        json["courses"] = course;
        File.WriteAllText(Directory.GetCurrentDirectory(), json.ToString());

    }
}
