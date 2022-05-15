﻿using System.Collections.Generic;

namespace Intsar_F_Project.Models.ViewModels
{
    public class UserVM
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Specialization { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
