// See https://aka.ms/new-console-template for more information

using Requests;

Comment nivcom = new Comment();
List<Course> courses = new List<Course>() { new Course("english", "1"), new Course("hebrew", "2") };
Teacher niv = new Teacher("niv", "213214091", nivcom, courses);
Requests.Requests nivreq = new Requests.Requests(niv);
nivreq.Export();