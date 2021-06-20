using Sneakers.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sneakers.Core.Data.ViewModels
{
    public class SneakerListViewModel
    {
        public IEnumerable<Sneaker> Sneakers { get; set; }
    }
}
