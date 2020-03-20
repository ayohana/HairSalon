using System.Collections.Generic;

namespace ProjectName.Models
{
  public class ParentClassName
  {

    public int ParentClassNameId { get; set; }
    public virtual ICollection<ClassName> ClassesName { get; set; }

    public ParentClassName()
    {
      this.ClassesName = new HashSet<ClassName>();
    }

  }
}