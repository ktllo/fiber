namespace FabrikamFiber.DAL.Models
{
    /**
     * A model class for phone information
     */
    public class Phone
    {
        public int ID { get; set; }

        public string Label { get; set; }

        public string Number { get; set; }

        public int CustomerID { get; set; }


    }
}
