namespace Flow_Control
{
    
    internal class CinemaGoer
        // GET AGE AND TICKET PRICES
    
    {

        
        public int Age { get; }

        // ENUM SPOT

        //public TicketPrice TicketPrice => Age < 20 ? TicketPrice.youth,  MANY STATEMENTS => will crash

        public TicketPrices ticketprice 
        { get
            {
                if (Age < 20)
                    return TicketPrices.Youth;
                if (Age > 65)
                    return TicketPrices.Retired;
                else
                    return TicketPrices.Standard;
            }       
        }

        public CinemaGoer(int age)
        {
            this.Age = age;           
            
        }

        public override string ToString() // Just return age
        {
            return $"Age: {Age} -- Ticket Price {ticketprice}";
        }
        

    }
    


}