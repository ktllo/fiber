namespace FabrikamFiber.DAL.Models
{
    /**
     * A model class for phone information
     */
    public class Phone
    {
        /** ID for the phone number */
        public int ID { get; set; }

        /** Label for the phone, should be human readable*/
        public string Label { get; set; }

        /** The phone number itself */
        public string Number { get; set; }

        /** The customer who own this phone number */
        public int CustomerID { get; set; }


    }
}
