﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using studentdatabase.Data;
using studentdatabase.Model;

namespace studentdatabase.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly studentdatabase.Data.studentdatabaseContext _context;

        public IndexModel(studentdatabase.Data.studentdatabaseContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Course != null)
            {
                Course = await _context.Course.ToListAsync();
            }
        }
    }
}
