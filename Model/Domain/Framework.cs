namespace LanguagesAndFrameworks.Model.Domain
{
    public class Framework
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string CreatorsName { get; set; }


        // ref to Language model 

        public Guid LanguageID { get; set; }

        public Guid ProjectsID { get; set; }

        public Language Language { get; set; }

        public Project Project { get; set; }


        public Framework() { }

    }
}
