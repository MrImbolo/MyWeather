namespace DTOs.Weathers
{
    public partial class Weather
    {
        public long Id { get; set; }
        public Main Main { get; set; }
        public Description Description { get; set; }
        public string Icon { get; set; }
    }
}
