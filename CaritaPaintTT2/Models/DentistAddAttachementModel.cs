using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaritaPaintTT2.Models
{
    public class DentistAddAttachementModel
    {
        public DentistOrdersModel.DentistOrder Order { get; set; }

        [Required(ErrorMessage = "Fältet {0} är obligatoriskt.")]
        [Display(Name = "Filnamn")]
        public string Name { get; set; }


        [Display(Name = "Bilaga")]
        [DataType(DataType.Upload)]
        public HttpPostedFileBase newAttachment { get; set; }

        [Display(Name = "Order")]
        public int OrdSNr { get; set; }

        [Required(ErrorMessage = "Fältet {0} är obligatoriskt.")]
        [Display(Name = "Beskrivning")]
        [DataType(DataType.MultilineText)]
        public string cTxtP { get; set; }
    }
}