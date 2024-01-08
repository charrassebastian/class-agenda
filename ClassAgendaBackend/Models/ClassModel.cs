using System.ComponentModel.DataAnnotations;

namespace ClassAgendaBackend.Models;

public class ClassModel {
    [Key]
    public Guid Id { get; set; }
    public CourseModel? Course { get; set; }
    public StudentModel? Student { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}