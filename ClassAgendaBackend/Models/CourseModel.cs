using System.ComponentModel.DataAnnotations;

namespace ClassAgendaBackend.Models;

public class CourseModel {
    [Key]
    public Guid Id { get; set; }
    public required string Topic { get; set; }
    public DateTime Year { get; set; }
    public required string Name { get; set; }
    public required string Level { get; set; }
    public required string School { get; set; }
    public required string EvaluationType { get; set; }

}