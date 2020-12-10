namespace Module2.Models.SafariPark
{
    using Module2.Enums;

    /// <summary>
    /// This is base class.
    /// </summary>
    public class Animals
    {
        private string name;
        private int age;
        private float weight;
        private string phylum;
        private ClassOfAnimal classOfAnimal;
        private SubclassOfAnimal subclassOfAnimal;
        private GenusOfAnimal genusOfAnimal;

        /// <summary>
        ///  Gets or sets anumal name.
        /// </summary>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        ///  Gets or sets anumal age.
        /// </summary>
        public int Age { get => this.age; set => this.age = value; }

        /// <summary>
        ///  Gets or sets anumal weight.
        /// </summary>
        public float Weight { get => this.weight; set => this.weight = value; }

        /// <summary>
        ///  Gets or sets phylum of animal: only mammal for now, reptiles planned.
        ///  Устанавливает тип животного: пока только млекопитающие, пресмыкающиеся планируются.
        /// </summary>
        public string Phylum { get => this.phylum; set => this.phylum = value; }

        /// <summary>
        ///  Gets or sets class of animal: Herbivore, Predator.
        ///  Устанавливает класс животного: травоядное, хищник.
        /// </summary>
        public ClassOfAnimal ClassOfAnimal { get => this.classOfAnimal; set => this.classOfAnimal = value; }

        /// <summary>
        ///  Gets or sets subclass of animal: Artiodactyls, Equid, Canine, Feline.
        ///  Устанавливает подкласс животного: парнокопытные, непарнокопытные, собачьи, кошачьи.
        /// </summary>
        public SubclassOfAnimal SubclassOfAnimal { get => this.subclassOfAnimal; set => this.subclassOfAnimal = value; }

        /// <summary>
        ///  Gets or sets class of animal: Bison, Camel, Donkey, Horse, Fox, Wolf, Lion, Panther.
        ///  Устанавливает вид животного: зубр, верблюд, ослик, лошадь, лис, волк, лев, пантера.
        /// </summary>
        public GenusOfAnimal GenusOfAnimal { get => this.genusOfAnimal; set => this.genusOfAnimal = value; }
    }
}
