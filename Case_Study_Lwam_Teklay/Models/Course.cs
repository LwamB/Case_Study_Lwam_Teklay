using Contentful.Core.Configuration;
using Contentful.Core.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace Case_Study_Lwam_Teklay.Models
{
    /*[JsonConverter(typeof(JsonConverter))]*/
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public bool Availability { get; set; }
    }
}
