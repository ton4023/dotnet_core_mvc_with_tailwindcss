using System;
using System.ComponentModel.DataAnnotations;

namespace webmvc.Models
{
    public class CustomerEntity 
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string NameTH { get; set; }
        public string NameEN { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
       

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd'-'MM'-'yyyy' 'HH':'mm':'ss}")]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd'-'MM'-'yyyy' 'HH':'mm':'ss}")]
        public DateTime LastUpdateDate { get; set; }

    }
}