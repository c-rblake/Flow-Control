namespace Flow_Control
{
    
    internal class CinemaGoer
        // GET AGE AND TICKET PRICES
    
    {

        
        public int Age { get; }

        // ENUM SPOT

        //public TicketPrice TicketPrice => Age < 20 ? TicketPrice.youth,  MANY STATEMENTS => will crash

        public TicketTypes ticketType 
        { get
            {
                if (Age < 20)
                    return TicketTypes.Youth;
                if (Age > 65)
                    return TicketTypes.Retired;
                else
                    return TicketTypes.Standard;
            }
            
        }
        public int TicketPrice
        {
            get
            {
                if (Age < 20)
                    return 80;
                if (Age > 65)
                    return 90;
                else
                    return 120;
            }

        }

        //private int GetTicketPrice()
        //{
        //    return 1;
        //}

        public CinemaGoer(int age)
        {
            this.Age = age;
        }
        

        public override string ToString() // Just return age
        {
            return $"Age: {Age} -- Ticket Price {ticketType}  -- {TicketPrice}";
            //return $"Age: {Age} -- Ticket Price {ticketType}  -- {TicketPrices}";
        }
        

    }
    


}