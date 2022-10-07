namespace PhoneDomin
{
    public class MobilePhone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public List<Specifications> Specifications { get; set; } = new List<Specifications>();

    }
}