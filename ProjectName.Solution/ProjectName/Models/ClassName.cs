using System;
using System.Collections.Generic;

namespace ProjectName.Models
{
  public class ClassName
  {
    public int ClassNameId { get; set; }

    public virtual ParentClassName ParentClassName { get; set; }

  }
}