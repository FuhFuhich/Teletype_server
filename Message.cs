namespace shooter_server
{
    public class Message
    {
        public int id_sender { get; set; }
        public int id_msg { get; set; }
        public DateTime time_msg { get; set; }
        public byte[] msg { get; set; }

        public Message()
        {
            msg = new byte[0];
        }

        public string GetString()
        {
            return id_sender.ToString() + " " + id_msg.ToString() + " " + time_msg.ToString() + " " + msg.ToString() + " ";
        }
    }
}