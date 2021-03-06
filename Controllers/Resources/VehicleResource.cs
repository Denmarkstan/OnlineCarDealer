using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using MyVegaApp.Core.Models;
namespace MyVegaApp.Controllers.Resources {

    public class VehicleResource {
        public int Id { get; set; }

        [Required]
        public int ModelId { get; set; }

        public bool IsRegistered { get; set; }

        [Required]
        public ContactResource Contact { get; set; }
        public ICollection<int> Features { get; set; }
        public VehicleResource () {
            Features = new Collection<int> ();
        }

    }
}