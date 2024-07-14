﻿using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities
{
    public class Review
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        public int ParentId { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public int BusinessID { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public float Rating { get; set; }
        public string Comment { get; set; }

        public Review(int id, int parentId, int customerID, int businessID, DateTime timeStamp, float rating, string comment)
        {
            this.Id = id;
            this.ParentId = parentId;
            this.CustomerID = customerID;
            this.BusinessID = businessID;
            this.TimeStamp = timeStamp;
            this.Rating = rating;
            this.Comment = comment;
        }

        public Review()
        {
            Comment = string.Empty;
        }
    }
}
