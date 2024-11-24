namespace DNLR.Models.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime KayitZamani { get; set; } = DateTime.Now;
    public bool Silindi { get; set; } = false;
    public bool Aktif { get; set; } = true;
}