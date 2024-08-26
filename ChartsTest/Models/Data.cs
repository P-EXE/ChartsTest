namespace ChartsTest.Models;

public sealed class Data
{
  public int Id { get; set; }
  public string? Name { get; set; }
  public string? Description { get; set; }
  public DateTime CreatedDate { get; set; }
  public DateTime UpdatedDate { get; set; }
  public double? Value { get; set; }
}
