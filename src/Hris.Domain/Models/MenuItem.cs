using Hris.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hris.Infrastructure.Database.Models
{
    public class MenuItem  : EntityBase
    {
        public Guid Id { get; set; }
        public Guid? Parent { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public int Position { get; set; }
        public bool OpenInNewWindow { get; set; }
    }
}
