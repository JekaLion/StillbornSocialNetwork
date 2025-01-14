﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class Group : Entity
    {
        public int? ContentId { get; set; }
        public Content Content { get; set; }

        public int WallId { get; set; }
        public Wall Wall { get; set; }
        public IEnumerable<Member> Members { get; set; }
    }
}
