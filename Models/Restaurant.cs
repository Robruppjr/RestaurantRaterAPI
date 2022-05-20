using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
    public class Restaurant
    {
        [Key]
        public int ID {get; set;}
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength (100)]
        public string Location { get; set; }
        public virtual List<Rating> Ratings {get; set;} = new List<Rating>();
        public double AverageRating
            {
                get
                {
                    if(Ratings.Count == 0)
                    {
                        return 0;
                    }
                    double total = 0.0;
                    foreach(Rating rating in Ratings)
                    {
                        total += rating.Score;
                    }
                    return total / Ratings.Count;
                }
            }
    }
