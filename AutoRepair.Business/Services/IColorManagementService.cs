using System;
using System.Collections.Generic;
using AutoRepair.Business.Models;

namespace AutoRepair.Business.Services
{
    public interface IColorManagementService : IDisposable
    {
        IEnumerable<Color> GetAllColors();
        void Add(Color color);
        void Update(Color color);
        Color GetColor(int colorId);
        void Delete(Color color);
    }
}