using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Notes { get; set; }
    public string WorkStatus { get; set; }
    public DateTime HireDate { get; set; }
    public string FullName
    {
      get { return FirstName + " " + LastName; }
    }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}