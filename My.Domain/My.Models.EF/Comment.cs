using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema; 
using System.ComponentModel.DataAnnotations.Schema;

namespace My.Domain.My.Models.EF
{
    [ComplexType]
   public  class Comment
    {
        public string Created { get; set; }

        [MaxLength(250)]
        public string CommentText { get; set; }
    }
}
