namespace LanguagesAndFrameworks.Model.Domain
{

    /**
     * The Language Model 
     * 
     */
    public class Language
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string CreatorsName { get; set; }

        public int DateCreated { get; set; }

        public double CurrentVersion { get; set; }

        // A language can support multiple projects

        public IEnumerable<Framework> frameworks { get; set; }  





        //def constructor 
        public Language() { }
    }
}
