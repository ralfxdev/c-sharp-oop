using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_oop.Classes
{
    internal class Car
    {
        public string Brand { get; }
        public int Model { get; }
        public int MaxSpeed { get; }
        public string? Color { get; set; }
        public string? Owner { get; set; }
        public string? Price { get; set; }
        public string? Plate { get; set; }

        public bool IsOn = false;
        public bool IsLookDoors = false;
        public bool IsLightsOn = false;

        // 0 = Neutral
        private int _Gear = 0;
        private bool _Clutch = false;
        private int _SpeedCurrent = 0;
        private double _FuelLevel = 0;

        public Car(string brand, int model, int maxSpeed)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
        }

        public void SwitchCar()
        {
            IsOn = !IsOn;
        }

        public void Clutch()
        {
            _Clutch = !_Clutch;
        }

        public int Accelerate()
        {
            if (IsOn)
            {
                if (_SpeedCurrent < MaxSpeed && _Gear > 0 && _FuelLevel > 0)
                {
                    _SpeedCurrent += 10;
                    _FuelLevel -= _SpeedCurrent * 0.1;
                }   
            }
            return _SpeedCurrent;
        }

        public int Decelerate()
        {
            if (IsOn)
            {
                if (_SpeedCurrent > 0 && _Gear > 0)
                {
                    _SpeedCurrent -= 10;
                }
            }

            return _SpeedCurrent;
        }

        public int Brake()
        {
           return _SpeedCurrent = 0;
        }

        public int ShiftUp()
        {
            if (_Gear < 5 && _Clutch)
            {
                _Gear++;
            }
            return _Gear;
        }

        public int ShiftDown()
        {
            if (_Gear > 0 && _Clutch)
            {
                _Gear--;
            }
            return _Gear;
        }

        public void SwitchDoors()
        {
            IsLookDoors = !IsLookDoors;
        }

        public void SwitchLights()
        {
            IsLightsOn = !IsLightsOn;
        }

        public void Refuel(double liters)
        {
            _FuelLevel += liters;
        }

        public double GetFuelLevel()
        {
            return _FuelLevel;
        }

    }
}
