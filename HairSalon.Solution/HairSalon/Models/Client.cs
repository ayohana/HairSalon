using System;
using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }

    public virtual Stylist Stylist { get; set; }

  }
}