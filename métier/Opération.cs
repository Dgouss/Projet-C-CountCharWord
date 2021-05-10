namespace métier
{
    class Opération
    {
        public string Source { get; set; }
        public string SaveChoice { get; set; }

        public Opération(string source, string saveChoice)
        {
            this.Source = source;
            this.SaveChoice = saveChoice;
        }
    }
}
