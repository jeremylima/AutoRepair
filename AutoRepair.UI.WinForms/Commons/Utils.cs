using System;
using System.Collections.Generic;
using System.Linq;
using AutoRepair.UI.WinForms.Forms.GeneralCruds;

namespace AutoRepair.UI.WinForms.Commons
{
    public class FormName
    {
        public static string Category => "Categoria";
        public static string Categories => "Categorias";
        public static string VehicleMake => "Marca de Vehiculo";
        public static string VehicleMakes => "Marcas de Vehiculos";
        public static string VehicleModel => "Modelo";
        public static string VehicleModels => "Modelos de Vehiculos";
        public static string Color => "Color";
        public static string Colors => "Colores";
        public static string MotorType => "Tipo de Motor";
        public static string MotorTypes => "Tipos de Motores de Vehiculos";
        public static string VehicleType => "Tipo de Vehiculo";
        public static string VehicleTypes => "Tipos de Vehiculos";
        public static string TransmissionType => "Tipo de Transmision";
        public static string TransmissionTypes => "Tipos de Transmision de Vehiculos";
        public static string ProductMake => "Marca de Producto";
        public static string ProductMakes => "Marcas de Productos";
        
    }

    public class Utils
    {
        public static IEnumerable<object> GetRangeOfYears()
        {
            var years = Enumerable.Range(1900, DateTime.Now.Year - 1900 + 1).ToList().OrderByDescending(x => x);

            return years.Select(year => new 
            {
                Name = year
            }).ToList();
        }
       
    }
}