using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using first_azure_app.Models;
using System.Data;

namespace first_azure_app.Controllers;
public class Course
{
    public int CourseID { get; set; }
    public string? CourseName { get; set; }
    public decimal Rating { get; set; }
}
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    // private readonly string _connectionString;
    public HomeController(ILogger<HomeController> logger)//, IConfiguration configuration
    {
        _logger = logger;
        // _connectionString = configuration.GetConnectionString("myConnectionString");
    }
  


 
    public IActionResult Index()
    {
        // List<Course> courses = new List<Course>();
    
        // using (SqlConnection con = new SqlConnection(_connectionString))
        // {
        //     string query = "SELECT CourseID, CourseName, Rating FROM Course";
        //     SqlCommand cmd = new SqlCommand(query, con);
        //     con.Open();
        //     SqlDataReader reader = cmd.ExecuteReader();

        //     while (reader.Read())
        //     {
        //         Course course = new Course
        //         {
        //             CourseID = Convert.ToInt32(reader["CourseID"]),
        //             CourseName = reader["CourseName"].ToString(),
        //             Rating = Convert.ToDecimal(reader["Rating"])
        //         };
        //         courses.Add(course);
        //     }

        //     reader.Close();
        // }
         var courses = new List<Course>
        {
            new Course { CourseID = 1, CourseName = "Docker and Kubernetes", Rating = 4.5M },
            new Course { CourseID = 2, CourseName = "AZ-204 Azure Developer", Rating = 4.6M },
            new Course { CourseID = 3, CourseName = "AZ-104 Administrator", Rating = 4.7M },
            new Course { CourseID = 4, CourseName = "AZ-7777 Pro Max Azure", Rating = 5.0M },
            new Course { CourseID = 5, CourseName = "AZPS1 Powershell Course", Rating = 8.0M },
            new Course { CourseID = 6, CourseName = "Moc Exam AZ-204", Rating = 9.0M }
        };

        return View(courses);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
