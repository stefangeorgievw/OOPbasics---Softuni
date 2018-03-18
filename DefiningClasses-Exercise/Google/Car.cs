﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    class Car
    {
        private string carModel;
        private int carSpeed;

        public Car(string carModel, int carSpeed)
        {
            this.carModel = carModel;
            this.carSpeed = carSpeed;
        }

        public override string ToString()
        {
            return $"{this.carModel} {this.carSpeed}";
        }
    }
}
