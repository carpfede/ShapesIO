﻿using CodingChallenge.Data.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly decimal _lado;
        public Cuadrado(decimal lado)
        {
            if (lado <= 0)
                throw new ArgumentException();
            _lado = lado;
        }

        public override decimal CalculateArea()
        {
            return _lado * _lado;
        }

        public override decimal CalculatePerimeter()
        {
            return _lado * 4;
        }

        public override string GetQuantityDescription(List<FormaGeometrica> shapes)
        {
            return $"{shapes.Count} {(shapes.Count == 1 ? Messages.Square : Messages.Squares)}";
        }
    }
}
