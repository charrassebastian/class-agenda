using System.ComponentModel.DataAnnotations;

namespace ClassAgendaBackend.Models;

public class ClassModel {
    [Key]
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public required CourseModel Course { get; set; }
    public required StudentModel Student { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}