namespace DeCapAPeus.models
{
    internal class Order(int id, int box, DateOnly date, DateOnly date_done, 
                         Client client, string description, float price, State state,
                         bool delivered, bool notify, bool paid)
    {
        private int id = id;

        private int box = box;

        private DateOnly date = date;

        private DateOnly date_done = date_done;

        private Client client = client;

        private string description = description;

        private float price = price;

        private State state = state;

        private bool delivered = delivered;

        private bool notify = notify;

        private bool paid = paid;
    }

    enum State
    {
        Waiting,
        Done,
        Delivered,
    }
}
