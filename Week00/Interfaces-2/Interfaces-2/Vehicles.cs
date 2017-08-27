using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_2
{
    class Vehicles
    {
        public class GasEngine : IEngine
        {
            private uint _curThrottle = 0;
            private uint _maxThrottle = 0;
            public GasEngine(uint maxThrottle)
            {
                _maxThrottle = maxThrottle;
            }
            public uint MaxThrottle
            {
                get { return _maxThrottle; }
            }
            public void SetThrottle(uint thr)
            {
                _curThrottle = thr;
            }
            public uint GetThrottle()
            {
                return _curThrottle;
            }
        }

        public class MotorBike
        {
            private IEngine _engine = null;
            public MotorBike(IEngine engine)
            {
                _engine = engine;
            }
            void RunAtHalfSpeed()
            {
                _engine.SetThrottle(_engine.MaxThrottle / 2);
            }
        }
        public class Application
        {
            static void Main(string[] args)
            {
                IEngine engine = new GasEngine(2);
                MotorBike myBike = new MotorBike(engine);
            }
        }

    }
}
