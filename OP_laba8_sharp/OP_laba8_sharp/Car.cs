using System;
namespace OP_laba8_sharp
{
    public class Car
    {
        private readonly float _fuelTank;
        private readonly float _fuelConsumption;
        private float _fuelConsumed;
        public float KilometresPassed { get; private set; }
        private bool _isEngineStarted;  
        public delegate void ActionHandler(ActionHandlerArgs handlerArgs);

        public event ActionHandler Notify;

        public Car(float fuel, float fuelConsumption)
        {
            if (fuel < 0 || fuelConsumption <= 0)
            { 
                throw new ArgumentException( "Tank capacity and fuel consumption should be higher than zero");
            }
            _fuelTank = fuel;
            _fuelConsumption = fuelConsumption;
            _fuelConsumed = 0;
        }


        public void StartMoving()
        {
            _isEngineStarted = true;
            Notify?.Invoke(new ActionHandlerArgs("The car has started the engine!", this));
        }

        public void Move(int kilometers)
        {
            if (_isEngineStarted)
            {
                KilometresPassed = 0;
                Notify?.Invoke(new ActionHandlerArgs("The car is now moving!", this));
                for (int i = 0; i < kilometers; i++)
                {
                    if (_fuelConsumed >= _fuelTank)
                    {
                        Notify?.Invoke(new ActionHandlerArgs("You`re out of fuel!", this));
                        StopMoving();
                        break;
                    }
                    KilometresPassed += 1;
                    _fuelConsumed += _fuelConsumption;
                }
                Notify?.Invoke(new ActionHandlerArgs("Car have moved " + KilometresPassed + " kilometers!", this));
            }
            else
            {
                Notify?.Invoke(new ActionHandlerArgs("Start the engine first!", this));
            }
        }

        public void RefillTank()
        {
            if (_fuelConsumed == 0)
            {
                Notify?.Invoke(new ActionHandlerArgs("Engine is already full!", this));
            }
            else
            {
                _fuelConsumed = 0;
                Notify?.Invoke(new ActionHandlerArgs("Fuel refilled!", this));
            }
        }
        public void StopMoving()
        {
            if (_isEngineStarted)
            {
                _isEngineStarted = false;
                Notify?.Invoke(new ActionHandlerArgs("The engine was stopped!", this));                
            }

        }
    }
}