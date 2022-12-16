using ApiRequestValidation.Attributes;

namespace ApiRequestValidation.Entities;

[PersonValidator]
public class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public DateTime BirthDate { get; set; }
    public int? VAT { get; set; }
    public String? Address1 { get; set; }
    public String? Address2 { get; set; }
}