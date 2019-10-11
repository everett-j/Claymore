using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Claymore.Models
{
    public class PostingEvent
    {
        public User Creator {get;set;}
        public int CreatorId{get;set;}
        
        [Key]
        public int PostingId{get;set;}

        
        public DateTime DateApply {get;set;}

        
        public string JobLink {get;set;}

        public string JobPosting {get;set;}
        
        
        public string Company{get;set;}
        
        
        public string PositionTitle {get;set;}

        public string Notes {get;set;}


        public string RecruiterName {get;set;}

        public string ContactName {get;set;}

        public DateTime PhoneScreen {get;set;}

        public string ScreenNotes {get;set;}

        public DateTime PhoneInterview {get;set;}

        public string PhoneNotes {get;set;}

        public DateTime Interview {get;set;}

        public string InterviewNotes {get;set;}

        public DateTime Denied {get;set;}

        public string DeniedNotes {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Guest> Guests {get;set;}

        public PostingEvent(){
            Guests = new List<Guest>();
        }
        
        public bool ScreenEmail {get;set;}
        public bool ScreenLetter {get;set;}
        public bool ScreenCall {get;set;}
        public bool PhoneEmail {get;set;}
        public bool PhoneLetter {get;set;}
        public bool PhoneCall {get;set;}
        public bool InterviewEmail {get;set;}
        public bool InterviewLetter {get;set;}
        public bool InterviewCall {get;set;}
        public bool DeniedEmail {get;set;}
        public bool DeniedLetter {get;set;}
        public bool DeniedCall {get;set;}
         public bool ConfirmationEmail {get;set;}



    }
}