using Contentful.Core.Models;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Case_Study_Lwam_Teklay.Models
{
    public class Student
    {
        public SystemProperties Sys { get; set; }
        [JsonProperty("StudentName")]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public int DegreePhase { get; set; }
        public List<Asset> Image { get; set; }
        public string Description { get; set; }
      

    }
}
