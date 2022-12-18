using Case_Study_Lwam_Teklay.Models;
using Contentful.Core;
using Contentful.Core.Search;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Case_Study_Lwam_Teklay.Controllers
{
    public class StudentsController: Controller
    {
        private readonly IContentfulClient _client;
        public StudentsController(IContentfulClient client)
        {
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            var qb = QueryBuilder<Student>.New.ContentTypeIs("student");
            var entries = await _client.GetEntries(qb);
            return View(entries);
        }

        public async Task<IActionResult> Details(string id)
        {
            var qb = QueryBuilder<Student>.New.ContentTypeIs("student").FieldEquals(f => f.Sys.Id, id);
            var entry = await _client.GetEntries(qb);
            return View(entry);
        }
    }
}
