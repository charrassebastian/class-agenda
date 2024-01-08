using System.ComponentModel.DataAnnotations;

namespace ClassAgendaBackend.Models;

public class MaterialModel {
    [Key]
    public Guid Id { get; set; }
    public required string Type { get; set; }
    public required string Name { get; set; }
    public DateTime Due { get; set; }
    public CourseModel? Course { get; set; }
    public StudentModel? Student { get; set; }
    public required string Teacher { get; set; }
    public List<AnnotationModel> Annotations { get; } = new();
    public List<PhotoModel> Photos { get; } = new();
}