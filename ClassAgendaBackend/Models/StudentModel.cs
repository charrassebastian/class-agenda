using System.ComponentModel.DataAnnotations;

namespace ClassAgendaBackend.Models;

public class StudentModel {
    [Key]
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Phone { get; set; }
    public required string Preferred_platform { get; set; }
    public required string Other { get; set; }
    public List<CourseModel> Courses { get; } = new();
    public List<ClassModel> Classes { get; } = new();
    public List<MaterialModel> Materials { get; } = new();
}