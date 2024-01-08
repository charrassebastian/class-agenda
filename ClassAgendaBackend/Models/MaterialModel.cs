using System.ComponentModel.DataAnnotations;

namespace ClassAgendaBackend.Models;

public class MaterialModel {
    [Key]
    public Guid Id { get; set; }
    public required string Type { get; set; }
    public required string Name { get; set; }
    public DateTime Due { get; set; }
    public required CourseModel Course { get; set; }
    public required StudentModel Student { get; set; }
    public required string Teacher { get; set; }
}