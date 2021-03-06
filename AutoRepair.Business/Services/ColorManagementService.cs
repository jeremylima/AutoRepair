﻿using System.Collections.Generic;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Infrastructure;
using CustomExceptions;

namespace AutoRepair.Business.Services
{
    public class ColorManagementService : IColorManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.Color> _colorRepository;

        public ColorManagementService(IIntKeyedRepository<DataAccess.Entities.Color> colorRepository)
        {
            _colorRepository = colorRepository;

        }

        public void Dispose()
        {
            _colorRepository.Dispose();
        }

        public IEnumerable<Color> GetAllColors()
        {
            return _colorRepository.All().Select(AutoMapper.Mapper.Map<DataAccess.Entities.Color, Color>);
        }

        public void Add(Color color)
        {
            var _color = _colorRepository.FindBy(x => x.Name == color.Name);
            if (_color != null)
                throw new DuplicatedEntryKeyException();

            _colorRepository.Add(AutoMapper.Mapper.Map<Color, DataAccess.Entities.Color>(color));
        }

        public void Update(Color color)
        {
            var _color = _colorRepository.FindBy(x => x.Name == color.Name);
            if (_color != null)
            {
                if (_color.Id != color.Id)
                    throw new DuplicatedEntryKeyException();
            }

            _colorRepository.Update(AutoMapper.Mapper.Map<Color, DataAccess.Entities.Color>(color));
        }

        public Color GetColor(int colorId)
        {
            var make = _colorRepository.FindBy(colorId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.Color, Color>(make);
        }

        public void Delete(Color color)
        {
            _colorRepository.Delete(AutoMapper.Mapper.Map<Color, DataAccess.Entities.Color>(color));
        }
    }
}