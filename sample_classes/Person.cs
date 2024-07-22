namespace reckonwrit_drill.sample_classes
{
    internal class Person
    {
        public string Name { get; set; }
        public long Money { get; set; }
        public Adress Adress { get; set; }

        public Person() { }

        private Person(string name, long money)
        {
            Name = name;
            Money = money;
        }
    }
}
