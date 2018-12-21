﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChatTest.Models
{
    public class ChatContext: DbContext
    {
        public ChatContext() : base("DefaultConnection")
        {

        }

        public static ChatContext Create()
        {
            return new ChatContext();
        }

        public DbSet<User> Users { get; set; }
    }
}