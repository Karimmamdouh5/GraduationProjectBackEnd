﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Domain.ViewModels.Identity
{
    public class AddPhotoRequest
    {
        public IFormFile photo { get; set; }
    }
}
