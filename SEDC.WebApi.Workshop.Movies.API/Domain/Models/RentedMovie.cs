﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class RentedMovie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
