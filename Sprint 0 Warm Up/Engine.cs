namespace Sprint_0_Warm_Up
{
    public class Engine
    {
        public bool IsStarted;

        public Engine()
        {

        }

        public string About()
        {
            if(IsStarted)
            {
                return "It's started";
            } else
            {
                return "It's not started";
            }
        }

        public void Start()
        {
            IsStarted = true;
        }
        public void Stop()
        {
            IsStarted = false;
        }
    }
}