﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class Entity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreationDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
