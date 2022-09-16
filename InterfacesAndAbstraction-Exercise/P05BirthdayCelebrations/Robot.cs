
namespace P05BirthdayCelebrations
{
    public class Robot : IIdentifiable
    {
        private string model;
        private string id;
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Id 
        {
            get { return this.id; }
            set { this.id = value; } 
        }
    }
}
