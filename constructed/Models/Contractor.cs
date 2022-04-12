namespace constructed.Models
{
  public class Contractor
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }

  public class ContractorJobViewModel : Contractor
  {
    public int JobId { get; set; }
  }
}