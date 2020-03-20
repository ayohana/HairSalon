using System;
using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientID { get; set; }
    public string Name { get; set; }
    public int StylistID { get; set; }

    public virtual Stylist Stylist { get; set; }

  }
}