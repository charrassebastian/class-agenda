using System.ComponentModel.DataAnnotations;

namespace ClassAgendaBackend.Models;

public class AnnotationModel {
    [Key]
    public Guid Id { get; set; }
    public required string Content { get; set; }
    public required MaterialModel Material { get; set; }
}