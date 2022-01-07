using System.Collections.Generic;

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
    public DateTime StartDate { get; set; }
    public virtual ICollection<EngineerMachine> EngineerMachines { get; set; }
  }
}