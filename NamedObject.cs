namespace ChallengeApp
{
    public class NamedObject
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name.ToLower();
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }

            }
        }

        public NamedObject(string name)
        {
            this.Name = name;
        }
    }
}