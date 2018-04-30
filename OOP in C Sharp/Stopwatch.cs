using System; 

namespace OOP_in_C_Sharp
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _hasStarted = false; 
        
        public void Start()
        {
            if (_hasStarted)
                throw new InvalidOperationException("Cannot start the stopwatch twice in a row !!!");

            _startTime = DateTime.Now;
            _hasStarted = true; 
        }

        public void Stop()
        {
            if(!_hasStarted)
                throw new InvalidOperationException("Stopwatch is not running  !!!");
    
            _hasStarted = false;
            _endTime = DateTime.Now;     
        }

        public TimeSpan GetDuration()
        {
            return _endTime.Subtract(_startTime);
        }
    }
}
