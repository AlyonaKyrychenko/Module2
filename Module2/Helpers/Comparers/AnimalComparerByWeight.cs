namespace Module2.Helpers.Comparers
{
    using System.Collections;
    using Module2.Models.SafariPark;

    public class AnimalComparerByWeight : IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as Animals;
            var y = second as Animals;

            if (x.Weight > y.Weight)
            {
                return 1;
            }
            else if (x.Weight < y.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
