﻿using DotNet5_API_Showcase.DTOs;
using DotNet5_API_Showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet5_API_Showcase
{
    public static class Extensions
    {
        public static User_Response AsDto(this User user)
        {
            return new User_Response
            {
                userId = user.userId,
                name = user.name,
                birthDate = user.birthDate.ToString("yyyy-MM-dd"),
                email = user.email
            };
        }
    }
}
