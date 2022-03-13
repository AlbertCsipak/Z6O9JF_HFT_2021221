﻿using Z6O9JF_HFT_2021221.Models;

namespace Z6O9JF_HFT_2021221.WPFClient.Logic
{
    public interface ICarControlLogic
    {
        void Add(Car car);
        void Edit(Car car);
        void Remove(Car car);
        void Setup(RestCollection<Car> cars);
    }
}