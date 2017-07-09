using System;

namespace ECommerce.Models
{

    public abstract class BaseEntity {
        public  DateTime created_at {get; set; }
        public   DateTime updated_at {get; set; }
        
        public  BaseEntity(){
            created_at=DateTime.Now;
            updated_at=DateTime.Now;
            
        }
        public  string TimeAgo()
            {
            
                TimeSpan span = DateTime.Now - created_at;
                
                if (span.Days > 365)
                {
                    int years = (span.Days / 365);
                    if (span.Days % 365 != 0)
                        years += 1;
                    return String.Format("about {0} {1} ago", 
                    years, years == 1 ? "year" : "years");
                }
                if (span.Days > 30)
                {
                    int months = (span.Days / 30);
                    if (span.Days % 31 != 0)
                        months += 1;
                    return String.Format("about {0} {1} ago", 
                    months, months == 1 ? "month" : "months");
                }
                if (span.Days > 0)
                    return String.Format("about {0} {1} ago", 
                    span.Days, span.Days == 1 ? "day" : "days");
                if (span.Hours > 0)
                    return String.Format("about {0} {1} ago", 
                    span.Hours, span.Hours == 1 ? "hour" : "hours");
                if (span.Minutes > 0)
                    return String.Format("about {0} {1} ago", 
                    span.Minutes, span.Minutes == 1 ? "minute" : "minutes");
                if (span.Seconds > 5)
                    return String.Format("about {0} seconds ago", span.Seconds);
                if (span.Seconds <= 5)
                    return "just now";
                return string.Empty;
            }
     }
}