using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Claymore.Models
{
    public class Guest
    {
        [Key]
        public int GuestId {get;set;}
        public int UserId{get;set;}
        public User User{get;set;}
        public int PostingID{get;set;}
        public PostingEvent Posting{get;set;}
        
    }
}